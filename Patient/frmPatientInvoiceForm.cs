using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using ShifaClinic.DataContext;
using ShifaClinic.Common;
using System.Windows.Forms;
using ShifaClinic.Session;
using System.IO;
using ShifaClinic.Patient.reports;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace ShifaClinic.Patient
{
    public partial class frmPatientInvoiceForm : Form
    {
        private Auth auth = new Auth();
        clinicDbContext db = new clinicDbContext();
        public frmPatientInvoiceForm()
        {
            InitializeComponent();
        }


        private void Ctrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F3)
            {
                this.toggleUserList();
            }
            else if (e.KeyCode == Keys.Escape && this.gvPatientList.Visible)
            {
                this.toggleUserList();
            }
        }
        private void Ctrl_GotFocus(object sender, EventArgs e)
        {
            var ctrl = sender as TextBox;
            ctrl.BackColor = Color.Beige;
            ctrl.SelectAll();
        }
        private void Ctrl_LostFocus(object sender, EventArgs e)
        {
            var ctrl = sender as TextBox;
            if (ctrl.Name == "txtPatientName")
                ctrl.BackColor = Color.AliceBlue;
            else
                ctrl.BackColor = Color.White;
        }

        private void applyToAll(Control groupBox)
        {
            foreach (var c in groupBox.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    var ctrl = (TextBox)c;
                    ctrl.KeyDown += Ctrl_KeyDown;
                    ctrl.GotFocus += Ctrl_GotFocus;
                    ctrl.LostFocus += Ctrl_LostFocus;
                }
            }
        }
        private void resetform()
        {
            txtPatientName.Text = string.Empty;
            txtPatientId.Text = string.Empty;
            txtMobile.Text = string.Empty;
            rbMale.Checked = true;
            rbPrivate.Checked = true;
            cmbBloodGroup.SelectedIndex = 0;

            lblDocFee.Text = "0";
            txtAge.Text = "0";
            txtWeight.Text = "0";
            txtBloodPressure.Text = "0";
            txtDiscountInPercentage.Text = "0";
            txtDiscount.Text = "0";
            lblBanalce.Text = "0";
            lblBillAmmount.Text = "0";
            lblGross.Text = "0";
            lblToken.Text = "0";
            txtHight.Text = "0";
            this.dgvVisit.Rows.Clear();
            this.dgvVisit.Refresh();
            var billid = new Bill();

        }

        private void bindDoctorCombobox(int departmentId)
        {
            this.cmbDoctor.Items.Clear();
            foreach (var doc in db.Doctors
                .Where(c => c.departmentId == departmentId)
                .ToList())
            {
                var item = new ComboBoxItem(doc.id, doc.name);
                this.cmbDoctor.Items.Add(item);
            }
            this.cmbDoctor.ValueMember = "Value";
            this.cmbDoctor.DisplayMember = "Text";

            this.cmbDoctor.Items.Insert(0, new ComboBoxItem(0, "-- SELECT DOCTOR --"));
            this.cmbDoctor.SelectedIndex = 0;

        }
        private void bindDoctorCategoryCombobox()
        {
            this.cmbDoctorDepartment.Items.Clear();
            this.cmbDoctorDepartment.Items.Add(new ComboBoxItem(0, "-- SELECT DEPARTMENT --"));
            foreach (var dep in db.DoctorDepartments.ToList())
            {
                var item = new ComboBoxItem(dep.id, dep.title);
                this.cmbDoctorDepartment.Items.Add(item);
            }
            this.cmbDoctorDepartment.ValueMember = "Value";
            this.cmbDoctorDepartment.DisplayMember = "Text";

            this.cmbDoctorDepartment.SelectedIndex = 0;
        }
        private void bindSerivesCombobox()
        {
            this.cmbServices.Items.Clear();
            this.cmbServices.Items.Insert(0, new ComboBoxItem(0, "-- SELECT SERVICE --"));
            this.cmbServices.Items.Insert(1, new ComboBoxItem(-1, "DOCTOR VISIT"));
            foreach (var s in db.Services.ToList())
            {
                var item = new ComboBoxItem(s.id, s.title);
                cmbServices.Items.Add(item);
            }
            this.cmbServices.DisplayMember = "Text";
            this.cmbServices.ValueMember = "Value";

            this.cmbServices.SelectedIndex = 0;
        }
        private void bindPatientList()
        {
            var _patientData = db.Patients.ToList();

            List<POCO.Patient> _patients = new List<POCO.Patient>();
            foreach (var i in _patientData)
            {
                var _p = new POCO.Patient();
                _p.id = i.id;
                _p.fullName = i.fullName;
                _p.mobileNumber = i.mobileName;
                _p.gender = i.gender.Value ? "Male" : "Female";
                _p.CNIC = i.CNIC;
                _p.age = i.age.HasValue ? i.age.Value : 0;
                //_p.bloodGroup = i.bloodGroup;

                _patients.Add(_p);

            }

            gvPatientList.AutoGenerateColumns = false;
            gvPatientList.DataSource = _patients;
        }
        private void bindgdvVisit()
        {
            POCO.BillDetail _temp = null;
            int _id = 0;
            // Doctor Visit
            if (cmbServices.SelectedIndex == 1 &&
                cmbDoctorDepartment.SelectedIndex > 0 &&
                cmbDoctor.SelectedIndex > 0)
            {
                _temp = new POCO.BillDetail();
                var item = cmbDoctor.SelectedItem as ComboBoxItem;
                _id = int.Parse(item.Value.ToString());
                var _d = db.Doctors.Where(i => i.id == _id).FirstOrDefault();
                if (_d != null)
                {
                    _temp.fees = _d.fees.HasValue ? _d.fees.Value : 0;
                    _temp.title = _d.name;
                    _temp.id = _id;
                    _temp.visitType = true;
                    cmbServices.Items.RemoveAt(1);
                }
            }
            else if (cmbServices.SelectedIndex > 0)
            {
                _temp = new POCO.BillDetail();
                var item = cmbServices.SelectedItem as ComboBoxItem;
                _id = int.Parse(item.Value.ToString());
                var _s = db.Services.Where(i => i.id == _id).FirstOrDefault();
                if (_s != null)
                {
                    _temp.fees = _s.price.HasValue ? _s.price.Value : 0;
                    _temp.title = _s.title;
                    _temp.visitType = false;
                    _temp.id = _s.id;
                    lblDocFee.Text = _temp.fees.ToString();
                }
            }

            if (_temp == null)
            {
                MessageBox.Show("Please select Service or Dr Visit",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var _title = _temp.visitType ?
                    string.Format("VISIT - {0} - {1}", _temp.title, cmbDoctorDepartment.Text) :
                    _temp.title;

                dgvVisit.Rows.Add(_temp.id, _temp.visitType, _title, _temp.fees);
            }
        }

        private void toggleUserList()
        {
            if (!this.gvPatientList.Visible)
            {
                int _top = 0; int _left = 0;
                _top = this.gbPatientDetail.Top + this.btnSearch.Top;
                _left = this.btnSearch.Left + this.btnSearch.Width + 20;
                this.gvPatientList.Top = _top;
                this.gvPatientList.Left = _left;
                this.gvPatientList.Width = 360;
                this.gvPatientList.Height = 124;

                this.gvPatientList.Visible = true;
                this.gvPatientList.BringToFront();
                this.gvPatientList.Focus();
            }
            else
            {
                this.gvPatientList.Visible = false;
            }
        }
        public int generateToken(int docid)
        {
            using (var db = new clinicDbContext())
            {
                var _t = db.Tokens.Where(x => x.docId == docid).FirstOrDefault();
                if (_t != null)
                {
                    int _newTokenNumber = _t.tokenNumber.HasValue ? _t.tokenNumber.Value : 0;
                    return _newTokenNumber + 1;
                }
                else
                    return 1;
            }
        }
        private void calculateBill()
        {
            int _discount = 0;

            if (!string.IsNullOrEmpty(txtDiscountInPercentage.Text) || txtDiscountInPercentage.Text != "0")
            {
                _discount = int.Parse(txtDiscountInPercentage.Text);
                int _g = int.Parse(lblGross.Text.ToString());
                _discount = _discount / 100;
                _discount = _g * _discount;
            }
            else if (!string.IsNullOrEmpty(txtDiscount.Text) || txtDiscount.Text != "0")
            {
                _discount = int.Parse(txtDiscount.Text);
            }
            int _i = int.Parse(lblGross.Text.ToString());
            int _billAmount = _i - _discount;
            lblBillAmmount.Text = _billAmount.ToString();

            if (!string.IsNullOrEmpty(txtPaidAmmount.Text))
            {
                int _paid = int.Parse(txtPaidAmmount.Text);
                int _balance = _paid - _billAmount;
                lblBanalce.Text = _balance.ToString();
            }
        }
        private void onlyAllowNumericValue(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                (sender as TextBox).Text = "0";
            }
        }
        private void validateform()
        {
            //bool _result = false;
            formError.Clear();
            if (string.IsNullOrEmpty(txtPatientName.Text))
            {
                this.formError.SetError(txtPatientName, "this field is required");
            }
            else
            {
                this.formError.SetError(txtPatientName, "");
            }
            //return _result;
        }
        private void insertRecord()
        {
            

            var _patientRecord = new DataContext.Patient();
            _patientRecord.fullName = txtPatientName.Text.Trim();
            _patientRecord.mobileName = txtMobile.Text.Trim();
            _patientRecord.age = int.Parse(txtAge.Text.Trim());
            _patientRecord.patientType = rbPrivate.Checked ? "Private" : "Staff";
            _patientRecord.weight = int.Parse(txtWeight.Text.Trim());
            _patientRecord.bloodPressure = int.Parse(txtBloodPressure.Text.Trim());
            _patientRecord.gender = !rbMale.Checked;
            _patientRecord.createdBy = 1;
            _patientRecord.createDate = DateTime.Now;
            _patientRecord.bloodGroup = this.cmbBloodGroup.Text.Trim();
            _patientRecord.hight = double.Parse(txtHight.Text.Trim());

            db.Patients.Add(_patientRecord);
            db.SaveChanges();
            var _bill = new Bill();
            _bill.gross = int.Parse(lblGross.Text);
            _bill.billAmount = int.Parse(lblBillAmmount.Text);
            _bill.balance = int.Parse(lblBanalce.Text);
            _bill.patientId = _patientRecord.id;
            _bill.createdBy = auth.currentUser;
            _bill.createDate = DateTime.Now;
            _bill.tokenNumber = int.Parse(lblToken.Text);
            _bill.remarks = txtRemarks.Text;

            db.Bills.Add(_bill);
            db.SaveChanges();

            int _docId, _serviceId;
            _docId = _serviceId = 0;
            foreach (DataGridViewRow row in dgvVisit.Rows)
            {
                var _billDetails = new BillDetail();
                if (bool.Parse(row.Cells[1].Value.ToString()))
                {
                    _docId = int.Parse(row.Cells[0].Value.ToString());
                    _billDetails.doctorId = _docId;
                }
                else if (!bool.Parse(row.Cells[1].Value.ToString()))
                {
                    _serviceId = int.Parse(row.Cells[0].Value.ToString());
                    _billDetails.serviceId = _serviceId;
                }

                _billDetails.billId = _bill.id;
                db.BillDetails.Add(_billDetails);

                db.SaveChanges();
            }

            MessageBox.Show("Record Added successfully...",
                           "SUCCESS",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            resetform();
        }



        private void updateRecord()
        {
            int _id = int.Parse(txtPatientId.Text.ToString());
            var patient = db.Patients.Where(a => a.id == _id).FirstOrDefault();
            if (patient != null)
            {
                patient.fullName = txtPatientName.Text.ToString();
                patient.mobileName = txtMobile.Text.ToString();
                patient.age = int.Parse(txtAge.Text.ToString());
                patient.weight = int.Parse(txtWeight.Text.ToString());
                patient.hight = double.Parse(txtHight.Text.ToString());
                patient.patientType = rbPrivate.Checked ? "Private" : "Staff";
                patient.gender = rbMale.Checked;
                patient.bloodGroup = cmbBloodGroup.SelectedValue.ToString();
                patient.bloodPressure = int.Parse(txtPatientName.Text.ToString());

                var _bill = db.Bills.Where(a => a.patientId == _id).FirstOrDefault();
                _bill.gross = int.Parse(lblGross.Text);
                _bill.billAmount = int.Parse(lblBillAmmount.Text);
                _bill.balance = int.Parse(lblBanalce.Text);
                _bill.createdBy = auth.currentUser;
                _bill.createDate = DateTime.Now;
                _bill.tokenNumber = int.Parse(lblToken.Text);
                _bill.remarks = txtRemarks.Text;

                int _docId, _serviceId;
                _docId = _serviceId = 0;
                foreach (DataGridViewRow row in dgvVisit.Rows)
                {
                    var _billDetails = db.BillDetails.Where(a => a.billId == _bill.id).FirstOrDefault();
                    if (bool.Parse(row.Cells[1].Value.ToString()))
                    {
                        _docId = int.Parse(row.Cells[0].Value.ToString());
                        _billDetails.doctorId = _docId;
                    }
                    else if (!bool.Parse(row.Cells[1].Value.ToString()))
                    {
                        _serviceId = int.Parse(row.Cells[0].Value.ToString());
                        _billDetails.serviceId = _serviceId;
                    }

                    db.SaveChanges();

                }
                MessageBox.Show("UPDATE", "Record has been Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //************************************************//
        private void frmPatientInvoiceForm_Load(object sender, EventArgs e)
        {
            this.applyToAll(gbPatientDetail);
            this.applyToAll(this);
            this.bindSerivesCombobox();
            this.bindPatientList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bindgdvVisit();

            cmbServices.SelectedIndex = 0;
            lblDocFee.Text = "0";
        }

        private void cmbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cmbdoctor and cmbdoctordepartment selected index become null or empty
            lblDocFee.Text = "0";
            if (cmbServices.SelectedIndex == 1 && cmbServices.Text == "DOCTOR VISIT")
            {
                this.bindDoctorCategoryCombobox();
                cmbDoctor.Enabled = true;
                cmbDoctorDepartment.Enabled = true;
            }
            else
            {
                var _item = cmbServices.SelectedItem as ComboBoxItem;
                int _serviceId = int.Parse(_item.Value.ToString());
                if (_serviceId > 0)
                {
                    var _fee = db.Services
                        .Where(x => x.id == _serviceId)
                        .FirstOrDefault()
                        .price.Value;
                    lblDocFee.Text = _fee.ToString();
                }
                cmbDoctor.Enabled = false;
                cmbDoctorDepartment.Enabled = false;
                cmbDoctor.Items.Clear();
                cmbDoctorDepartment.Items.Clear();
            }

        }

        private void cmbDoctorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbServices.FormattingEnabled = false;
            if (this.cmbDoctorDepartment.SelectedIndex > 0)
            {
                var _item = cmbDoctorDepartment.SelectedItem as ComboBoxItem;
                int _departmentId = int.Parse(_item.Value.ToString());
                this.bindDoctorCombobox(_departmentId);
                lblDocFee.Text = "0";
                lblToken.Text = "0";
                //lblGross.Text = "0";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to generate this invoice?",
                  "SAVE",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == DialogResult.Yes)
                insertRecord();
            // there should be an option to return back to the filled form ..else goBacktoForm(); or previous state
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedIndex > 0)
            {
                var _item = cmbDoctor.SelectedItem as ComboBoxItem;
                int _docid = int.Parse(_item.Value.ToString());
                var _fee = db.Doctors
                    .Where(x => x.id == _docid)
                    .FirstOrDefault()
                    .fees.Value;
                lblDocFee.Text = _fee.ToString();
                // lblGross.Text = _fee.ToString();
                lblToken.Text = generateToken(_docid).ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateRecord();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.toggleUserList();
        }

        private void lblGross_TextChanged(object sender, EventArgs e)
        {
            this.calculateBill();

        }

        private void txtPaidAmmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPaidAmmount.Text))
                this.calculateBill();
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.onlyAllowNumericValue(sender, e);

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            var _s = sender as DateTimePicker;
            //var _age = DateTime.Now.Year - _s.Value.Year;
            var _age = Utility.GetAge(_s.Value);
            txtAge.Text = _age.ToString();
        }

        private void gvPatientList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var _id = int.Parse(gvPatientList.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (_id != null)
            {
                txtPatientId.Text = _id.ToString();
                var _patient = db.Patients.Where(x => x.id == _id).FirstOrDefault();
                if (_patient != null)
                {
                    txtPatientName.Text = _patient.fullName.ToString();
                    txtMobile.Text = _patient.mobileName.ToString();
                    txtAge.Text = _patient.age.HasValue ? _patient.age.ToString() : "0";
                    //male/female.Text = _patient.fullName.ToString();
                    if (!_patient.gender.Value) rbMale.Checked = true;
                    else rbFemale.Checked = true;

                    if (_patient.patientType == "Staff") rbStaff.Checked = true;
                    else rbPrivate.Checked = true;

                    cmbBloodGroup.Text = _patient.bloodGroup;
                    txtHight.Text = _patient.hight.HasValue ? _patient.hight.Value.ToString() : "0";
                }
            }


            //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            //{
            //    if (e.ColumnIndex == 4)
            //    {
            //        MessageBox.Show("ID - " + dgvDoctorsList.Rows[e.RowIndex].Cells[0].Value);
            //        MessageBox.Show("Type - " + dgvDoctorsList.Rows[e.RowIndex].Cells[1].Value);

            //        var row = dgvDoctorsList.Rows[e.RowIndex];
            //        dgvDoctorsList.Rows.Remove(row);
            //    }
            //}



        }

        private void gvPatientList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.toggleUserList();
                //this.ActiveControl = txtPatientName;
                txtPatientName.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPaidAmmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (MessageBox.Show("Are you sure to generate this invoice?",
                    "SAVE",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtPatientId.Text))
                    {
                        validateform();
                        insertRecord();
                        bindPatientList();
                    }
                    else
                        updateRecord();
                }
            }
        }

        private void dgvVisit_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //calculate all the previous rows fee and update txtgross
        }

        private void dgvVisit_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int _gross = 0;
            foreach (DataGridViewRow row in dgvVisit.Rows)
            {
                if (row.Cells[3] != null && !string.IsNullOrEmpty(row.Cells[3].Value.ToString()))
                    _gross += int.Parse(row.Cells[3].Value.ToString());
            }
            lblGross.Text = _gross.ToString();
        }

        private void dgvVisit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var visitType = bool.Parse(dgvVisit.Rows[e.RowIndex].Cells[1].Value.ToString());
                int price = int.Parse(dgvVisit.Rows[e.RowIndex].Cells[3].Value.ToString());
                dgvVisit.Rows.RemoveAt(e.RowIndex);
                int previousPrice = int.Parse(lblGross.Text.ToString());
                price = previousPrice - price;
                lblGross.Text = price.ToString();

                if (visitType)
                {
                    this.cmbServices.Items.Insert(1, new ComboBoxItem(-1, "DOCTOR VISIT"));
                }
            }
        }
        private void dgvVisit_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // dgvVisit_CellContentClick(sender, new DataGridViewCellEventArgs(4, e.RowIndex));
        }

        private void dgvVisit_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
        }
        private void dgvVisit_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //MessageBox.Show(e.Row.);
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            this.txtDiscountInPercentage.Text = "0";
            if (!string.IsNullOrEmpty(txtDiscount.Text))
                this.calculateBill();
        }

        private void txtDiscountInPercentage_TextChanged(object sender, EventArgs e)
        {
            this.txtDiscount.Text = "0";
            if (!string.IsNullOrEmpty(txtDiscountInPercentage.Text))
                this.calculateBill();
        }

        private void txtDiscount_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void txtDiscountInPercentage_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void txtPaidAmmount_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void txtWeight_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void txtAge_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void txtPatientName_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void txtMobile_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void txtHight_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void txtBloodPressure_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void frmPatientInvoiceForm_Click(object sender, EventArgs e)
        {
            this.gvPatientList.Visible = false;
        }

        private void gvPatientList_Leave(object sender, EventArgs e)
        {
            this.gvPatientList.Visible = false;
        }

        private void txtPatientName_Leave(object sender, EventArgs e)
        {
            validateform();
        }

        private void btnPrintDetails_Click(object sender, EventArgs e)
        {
            string p = Path.GetDirectoryName(Application.ExecutablePath);
            string path = p.Remove(p.Length - 10) + "\\Patient\\reports\\Invoice_PatientInvoiceForm.rdlc";
            LocalReport report = new LocalReport();
            report.ReportPath = path;
            var dt = new dsPatient.dtRpt_Invoice_PatientInvoiceFormDataTable();
            var row = dt.NewRow();
            row["name"] = "Sohail Arshad";
            row["tokenNumber"] = 54;
            dt.Rows.Add(row);
            ReportDataSource ds = new ReportDataSource();
            ds.Name = dt.TableName;
            ds.Value = dt;
            report.DataSources.Add(ds);
            //report.PrintToPrinter();
            var print = new ReportPrint();
            print.PrintToPrinter(report);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            resetform();

        }
    }
}
