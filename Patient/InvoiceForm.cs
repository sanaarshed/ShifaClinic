using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShifaClinic.Common;
using ShifaClinic.DataContext;
using ShifaClinic.Session;
using ShifaClinic.Common;

namespace ShifaClinic.Patient
{

    public partial class InvoiceForm : Form
    {
        private Auth auth = new Auth();

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
            //ctrl.SelectAll();
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

            txtFee.Text = "0";
            txtAge.Text = "0";
            txtWeight.Text = "0";
            txtBloodPressure.Text = "0";
            txtDiscount.Text = "0";
            txtDiscountInPercentage.Text = "0";
            lblBanalce.Text = "0";
            lblBillAmmount.Text = "0";
            lblGross.Text = "0";
            lblToken.Text = "0";
            txtHight.Text = "0";

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
        private void calculateBill()
        {
            int _discount = 0;

            if (!string.IsNullOrEmpty(txtDiscount.Text) || txtDiscount.Text != "0")
                _discount = int.Parse(txtDiscount.Text);
            else if (!string.IsNullOrEmpty(txtDiscountInPercentage.Text) || txtDiscountInPercentage.Text != "0")
                _discount = int.Parse(txtDiscountInPercentage.Text);

            int _billAmount = int.Parse(lblGross.Text) - _discount;

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

        private void bindDoctorCombobox(int departmentId)
        {
            using (var db = new clinicDbContext())
            {
                cmbDoctor.Items.Clear();
                foreach (var doc in db.Doctors
                    .Where(c => c.departmentId == departmentId)
                    .ToList())
                {
                    var item = new ComboBoxItem(doc.id, doc.name);
                    cmbDoctor.Items.Add(item);
                }
                cmbDoctor.ValueMember = "Value";
                cmbDoctor.DisplayMember = "Text";
            }
        }
        private void bindDoctorCategoryCombobox(clinicDbContext db)
        {
            // this will display inside dropdown
            this.cmbDoctorCategory.DisplayMember = "title";
            // on selection of displayed text, value is used for backend operations
            this.cmbDoctorCategory.ValueMember = "id";

            this.cmbDoctorCategory.DataSource = db.DoctorDepartments.ToList();
        }
        private void bindPatientList(clinicDbContext db)
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

        /// Constructor

        public InvoiceForm()
        {
            InitializeComponent();
        }
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            this.resetform();

            this.applyToAll(gbPatientDetail);

            using (var db = new clinicDbContext())
            {
                this.bindDoctorCategoryCombobox(db);
                this.bindPatientList(db);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.toggleUserList();
        }



        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to generate this invoice?",
                   "SAVE",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                insertRecord();
            // there should be an option to return back to the filled form ..else goBacktoForm(); or previous state
            resetform();

        }

        private void insertRecord()
        {
            using (var db = new clinicDbContext())
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
                _patientRecord.doctorId = int.Parse(cmbDoctor.SelectedValue.ToString());
                _patientRecord.bloodGroup = cmbBloodGroup.Text.Trim();
                _patientRecord.hight = int.Parse(txtHight.Text.Trim());


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
                MessageBox.Show("Record Added successfully...",
                    "SUCCESS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        private void updateRecord()
        {
            using (var db = new clinicDbContext())
            {
                int _id = int.Parse(txtPatientId.Text.Trim());
                var _p = db.Patients
                    .Where(c => c.id.Equals(_id))
                    .FirstOrDefault();
                if (_p != null)
                {

                    _p.fullName = txtPatientName.Text.Trim();
                    _p.mobileName = txtMobile.Text.Trim();
                    _p.age = int.Parse(txtAge.Text.Trim());
                    _p.patientType = rbPrivate.Checked ? "Private" : "Staff";
                    _p.weight = int.Parse(txtWeight.Text.Trim());
                    _p.bloodPressure = int.Parse(txtBloodPressure.Text.Trim());
                    _p.gender = !rbMale.Checked;
                    _p.modifiedBy = auth.currentUser;
                    _p.modifiedDate = DateTime.Now;
                    _p.doctorId = int.Parse(cmbDoctor.SelectedValue.ToString());
                    _p.bloodGroup = cmbBloodGroup.Text.Trim();
                    _p.hight = int.Parse(txtHight.Text.Trim());

                    db.SaveChanges();
                }
            }

            MessageBox.Show("Record Updated successfully...",
                    "SUCCESS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {

        }


        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new clinicDbContext())
            {
                int _docid = int.Parse((cmbDoctor.SelectedItem as ComboBoxItem).Value.ToString());
                var _fee = db.Doctors
                    .Where(x => x.id == _docid)
                    .FirstOrDefault()
                    .fees.Value;
                txtFee.Text = _fee.ToString();
                lblGross.Text = _fee.ToString();
                lblToken.Text = generateToken(_docid).ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.toggleUserList();
        }

        private void lblGross_TextChanged(object sender, EventArgs e)
        {
            //gross - dicount /% = bill - paid = balance
            this.calculateBill();
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

        private void txtPaidAmmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPaidAmmount.Text))
                this.calculateBill();
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.onlyAllowNumericValue(sender, e);
        }

        private void txtDiscountInPercentage_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPaidAmmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.onlyAllowNumericValue(sender, e);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.onlyAllowNumericValue(sender, e);
        }


        private void txtBloodPressure_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.onlyAllowNumericValue(sender, e);
        }

        private void gvPatientList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new clinicDbContext())
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
            }
        }



        private void gvPatientList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.toggleUserList();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
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
                        insertRecord();
                    else
                        updateRecord();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateRecord();
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

        private void cmbDoctorCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _departmentId = int.Parse(cmbDoctorCategory.SelectedValue.ToString());
            this.bindDoctorCombobox(_departmentId);
            txtFee.Text = "0";
            lblToken.Text = "0";
            lblGross.Text = "0";
        }
    }
}
