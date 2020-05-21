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
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;

namespace ShifaClinic.Accounts
{
    public partial class frmBill : ShifaClinic.Common.BaseForm
    {
        private Auth auth = new Auth();
        clinicDbContext db = new clinicDbContext();
        private int billId;

        private enum Services
        {
            OPDVISIT = 1,
            CONSULTANTVISIT = 2,
            OTHERS
        }

        private void Ctrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F3)
            {
                this.toggleUserList();
            }
            else if (e.KeyCode == Keys.Escape && this.searchPanel.Visible)
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
        private int generateBill()
        {
            using (var db = new clinicDbContext())
            {
                Bill bill = new Bill();
                bill.patientId = int.Parse(txtPatientId.Text.Trim()) == 0 ?
                    this.insertPatientRecord() : this.updatePatientRecord();

                bill.billAmount = Convert.ToDouble(lblBillAmount.Text.Trim());
                bill.discount = Convert.ToDouble(lblTotalDiscount.Text.Trim());
                bill.gross = bill.billAmount + bill.discount;
                bill.paid = Convert.ToDouble(txtPaidAmount.Text.Trim());
                bill.balance = Convert.ToDouble(lblBanalce.Text.Trim());
                bill.remarks = txtRemarks.Text.Trim();
                bill.tokenNumber = Convert.ToInt32(lblToken.Text.Trim());
                bill.bloodPressureUpper = Convert.ToInt32(txtBloodPressureUpper.Text);
                bill.bloodPressureLower = Convert.ToInt32(txtBloodPressureLower.Text);
                bill.patientAge = Convert.ToInt32(txtAge.Text);
                bill.patientHeight = Convert.ToInt32(txtHight.Text);
                bill.patientWeight = Convert.ToInt32(txtWeight.Text);

                bill.createDate = DateTime.Now;
                bill.createdBy = auth.currentUser.id;
                db.Bills.Add(bill);
                db.SaveChanges();
                this.billId = bill.id;

                foreach (DataGridViewRow row in dgvVisit.Rows)
                {
                    BillDetail billDetail = new BillDetail();
                    billDetail.billId = this.billId;
                    billDetail.amount = Convert.ToDouble(row.Cells["Price"].Value.ToString());

                    billDetail.serviceId = Convert.ToInt32(row.Cells["id"].Value.ToString());
                    if (row.Cells["doctorId"].Value != null && Convert.ToInt32(row.Cells["doctorId"].Value) > 0)
                        billDetail.doctorId = Convert.ToInt32(row.Cells["doctorId"].Value);
                    db.BillDetails.Add(billDetail);
                    db.SaveChanges();
                }
                return bill.id;
            }
        }
        private void prepareAndPrintInvoice(int billId = 0)
        {
            List<string> _services = new List<string>();
            using (var db = new clinicDbContext())
            {
                var bill = new ShifaClinic.Reports.Poco.dsBillFormInvoice();
                bill.BillID = string.Format("{0:0000000}", billId);
                bill.CreatedByFullname = string.Format("{0}", auth.currentUser.fullName).ToUpper();
                bill.CreatedDate = DateTime.Now;
                bill.fullName = txtPatientName.Text.Trim();
                bill.mobileNumber = txtMobile.Text.Trim();
                bill.age = txtAge.Text.Trim();
                bill.height = txtHight.Text.Trim();
                bill.weight = txtWeight.Text.Trim();
                bill.bloodPressureUpper = txtBloodPressureUpper.Text.Trim();
                bill.bloodPressureLower = txtBloodPressureLower.Text.Trim();
                bill.bloodGroup = cmbBloodGroup.Text.Trim();

                foreach (DataGridViewRow row in dgvVisit.Rows)
                {
                    if ((int)row.Cells["id"].Value == (int)Services.OPDVISIT
                        || (int)row.Cells["id"].Value == (int)Services.CONSULTANTVISIT)
                    {
                        int id = Convert.ToInt32(row.Cells["doctorId"].Value);
                        var doc = db.Doctors.Where(p => p.id == id).FirstOrDefault();
                        if (doc != null)
                        {
                            if ((int)Services.OPDVISIT == (int)row.Cells["id"].Value)
                            {
                                bill.OPDDoctor = doc.name.Trim();
                                bill.OPDDoctorCredientials = doc.credentials.Trim();
                            }
                            else
                            {
                                bill.Consultant = doc.name.Trim();
                                bill.ConsultantCredientials = doc.credentials.Trim();
                            }
                        }
                    }
                    else
                    {
                        string strService = "";
                        if (row.Cells["doctorName"].Value != null
                            && !string.IsNullOrEmpty(row.Cells["doctorName"].Value.ToString().Trim()))
                        {
                            strService = string.Format("{0}{1}by: Dr. {2}",
                                row.Cells["title"].Value.ToString().Trim(),
                                Environment.NewLine,
                                row.Cells["doctorName"].Value
                            );
                        }
                        else
                        {
                            strService = string.Format("{0}", row.Cells["title"].Value.ToString().Trim());
                        }
                        _services.Add(strService);
                    }
                }

                if (!string.IsNullOrEmpty(bill.OPDDoctor))
                {
                    this.printReciept(Services.OPDVISIT, bill);
                }
                if (!string.IsNullOrEmpty(bill.Consultant))
                {
                    this.printReciept(Services.CONSULTANTVISIT, bill);
                }
                if (_services.Count > 0)
                {
                    bill.ServiceTitle = _services;
                    this.printReciept(Services.OTHERS, bill);
                }
            }
        }
        private void printReciept(Services services, ShifaClinic.Reports.Poco.dsBillFormInvoice billFormInvoice)
        {
            string reportName = "";
            var dtValue = new DataTable();
            dtValue = Utility.MapToDataTable<Reports.Poco.dsBillFormInvoice>(billFormInvoice);

            switch (services)
            {
                case Services.OPDVISIT:
                    reportName = "Invoice_PatientInvoiceForm_OPD_3x9.rdlc";
                    break;
                case Services.CONSULTANTVISIT:
                    reportName = "Invoice_PatientInvoiceForm_CONSULTANT_3x9.rdlc";
                    break;
                case Services.OTHERS:
                    reportName = "Invoice_PatientInvoiceForm_SERVICES_3x9.rdlc";

                    var itemArray = dtValue.Rows[0].ItemArray;
                    dtValue.Rows.Clear();
                    foreach (var service in billFormInvoice.ServiceTitle)
                    {
                        var row = dtValue.NewRow();
                        row.ItemArray = itemArray;
                        row["ServiceTitle"] = service.ToString().Trim();
                        dtValue.Rows.Add(row);
                    }
                    break;
            }
            string p = Path.GetDirectoryName(Application.ExecutablePath);
            string path = p.Remove(p.Length - 10) + "\\Accounts\\reports\\" + reportName;
            LocalReport report = new LocalReport();
            report.ReportPath = path;

            ReportDataSource ds = new ReportDataSource();
            ds.Name = "dsBillPoco";
            ds.Value = dtValue;
            report.DataSources.Add(ds);

            //report.PrintToPrinter();
            var print = new ReportPrint();
            print.PrintToPrinter(report);
        }
        private void resetform()
        {
            txtPatientName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            rbMale.Checked = true;
            rbPrivate.Checked = true;
            cmbBloodGroup.SelectedIndex = 0;

            txtPatientId.Text = "0";
            lblDocFee.Text = "0";
            txtAge.Text = "0";
            txtHight.Text = "0";
            txtWeight.Text = "0";
            txtBloodPressureUpper.Text = "0";
            lblToken.Text = "0";

            txtPaidAmount.Text = "0";
            lblBanalce.Text = "0";
            lblBillAmount.Text = "0";
            lblGrandTotal.Text = "0";
            lblTotalDiscount.Text = "0";
            lblBillAmount.Text = "0";
            lblBanalce.Text = "0";
            txtRemarks.Text = "";
            this.dgvVisit.Rows.Clear();
            this.dgvVisit.Refresh();

            this.bindSerivesCombobox();
        }

        private void bindDoctorCombobox(int departmentId = -1)
        {
            ComboBoxItem cmbServiceItem = cmbServices.SelectedItem as ComboBoxItem;
            List<Doctor> docList = db.Doctors.ToList();
            this.cmbDoctor.Items.Clear();

            if ((int)cmbServiceItem.Value == (int)Services.OPDVISIT) // OPD
            {
                docList = docList
                .Where(c => c.isOpd)
                .ToList();
            }
            else if (Convert.ToInt32(cmbServiceItem.Value) == (int)Services.CONSULTANTVISIT) // CONSULTANT
            {
                docList = docList
                .Where(c => c.isConsultant)
                .ToList();
            }

            if (departmentId > 0)
            {
                docList = docList.Where(p => p.departmentId == departmentId).ToList();
            }

            foreach (var doc in docList)
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
            foreach (var s in db.Services.ToList())
            {
                var item = new ComboBoxItem(s.id, s.title);
                cmbServices.Items.Add(item);
            }
            this.cmbServices.DisplayMember = "Text";
            this.cmbServices.ValueMember = "Value";

            this.cmbServices.SelectedIndex = 0;
        }
        private void bindPatientList(string searchCriteria = null)
        {
            List<DataContext.Patient> _patientData = new List<DataContext.Patient>();
            if (string.IsNullOrEmpty(searchCriteria))
                _patientData = db.Patients.ToList();
            else
            {
                _patientData = db.Patients
                    .Where(p => p.fullName.Contains(searchCriteria) || p.mobileNumber.Contains(searchCriteria))
                    .ToList();
            }

            List<POCO.Patient> _patients = new List<POCO.Patient>();
            foreach (var i in _patientData)
            {
                var _p = new POCO.Patient();
                _p.id = i.id;
                _p.fullName = i.fullName;
                _p.mobileNumber = i.mobileNumber;
                _p.gender = i.gender.Value ? "Male" : "Female";
                _p.CNIC = i.CNIC;
                _p.age = i.age.HasValue ? i.age.Value : 0;

                _patients.Add(_p);
            }
            gvPatientList.AutoGenerateColumns = false;
            gvPatientList.DataSource = _patients;
        }
        private void bindServicesGrid()
        {
            POCO.BillDetail _temp = null;
            //int _id = 0;
            if (cmbServices.SelectedIndex > 0)
            {
                var billDetail = new POCO.BillDetail();
                var serviceItem = cmbServices.SelectedItem as ComboBoxItem;
                var serviceId = Convert.ToInt32(serviceItem.Value);
                var doctorItem = cmbDoctor.SelectedItem as ComboBoxItem;
                var doctorId = Convert.ToInt32(doctorItem.Value);

                if ((serviceId == (int)Services.OPDVISIT || serviceId == (int)Services.CONSULTANTVISIT)
                    && cmbDoctor.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please select doctor for this service.",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var doctor = db.Doctors.Where(p => p.id == doctorId).FirstOrDefault();
                if (doctor != null)
                {
                    billDetail.doctorId = doctor.id;
                    billDetail.doctorName = doctor.name;
                }

                billDetail.price = Convert.ToInt32(lblDocFee.Text);
                billDetail.total = billDetail.price;
                billDetail.title = serviceItem.Text;
                //billDetail.id = serviceId >= (int)Services.OTHERS ? serviceId : billDetail.doctorId;
                billDetail.id = serviceId;
                billDetail.discount = "0";
                dgvVisit.Rows.Add(billDetail.id,
                    billDetail.title,
                    billDetail.doctorId,
                    billDetail.doctorName,
                    string.Format("{0:0.00}", billDetail.price),
                    billDetail.discount,
                    billDetail.discountRate,
                    string.Format("{0:0.00}", billDetail.total));
            }
            else
            {
                MessageBox.Show("Please select one or more services...",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void toggleUserList()
        {
            if (!this.searchPanel.Visible)
            {
                int _top = 0; int _left = 0;
                _top = this.gbPatientDetail.Top + this.btnSearch.Top;
                _left = this.btnSearch.Left + this.btnSearch.Width + 20;
                this.searchPanel.Top = _top;
                this.searchPanel.Left = _left;
                this.searchPanel.Width = this.Width - (_left + 20);
                this.searchPanel.Height = this.Height - (_top + 50);

                this.searchPanel.Visible = true;
                this.searchPanel.BringToFront();

                this.txtSearchCriteria.Focus();
                this.txtSearchCriteria.SelectAll();
            }
            else
            {
                this.searchPanel.Visible = false;
            }
        }
        public int generateToken(int docid)
        {
            using (var db = new clinicDbContext())
            {
                var _t = db.Tokens.Where(x => x.docId == docid
                && x.tokenDate.Value.Year == DateTime.Now.Year
                && x.tokenDate.Value.Month == DateTime.Now.Month
                && x.tokenDate.Value.Day == DateTime.Now.Day).FirstOrDefault();
                if (_t != null)
                {
                    int _newTokenNumber = _t.tokenNumber.HasValue ? _t.tokenNumber.Value : 0;
                    return _newTokenNumber + 1;
                }
                else
                    return 1;
            }
        }
        private void calculateTotal()
        {
            double sumTotal = 0;
            double sumDiscount = 0;

            foreach (DataGridViewRow row in dgvVisit.Rows)
            {
                sumTotal += Convert.ToDouble(row.Cells["total"].Value);
                sumDiscount += Convert.ToDouble(row.Cells["DiscountRate"].Value);
            }

            lblGrandTotal.Text = string.Format("{0:0.00}", sumTotal);
            lblTotalDiscount.Text = string.Format("{0:0.00}", sumDiscount);
        }
        private void onlyAllowNumericValue(object sender, KeyPressEventArgs e)
        {
            var txt = (sender as TextBox);
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (txt.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = "0";
                txt.SelectAll();
            }
        }
        private bool validateForm(bool DisplayMessageBox = false)
        {
            bool _result = false;
            List<string> errorLog = new List<string>();
            if (string.IsNullOrEmpty(txtPatientName.Text))
            {
                errorLog.Add("Patient Name is required");
                txtPatientName.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtPatientName.BorderColor = Color.Blue;
                errorLog.Remove("Patient Name is required");
            }

            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                errorLog.Add("Mobile number is required");
                txtMobile.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtMobile.BorderColor = Color.Blue;
                errorLog.Remove("Mobile number is required");
            }

            double amount = Convert.ToDouble(string.IsNullOrEmpty(txtPaidAmount.Text) ? "0" : txtPaidAmount.Text);
            if ((amount <= 0 || amount < Convert.ToDouble(lblBillAmount.Text)))
            {
                errorLog.Add("Amount is required");
                txtPaidAmount.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtPaidAmount.BorderColor = Color.Blue;
                errorLog.Remove("Amount is required");
            }

            if (dgvVisit.Rows.Count <= 0)
            {
                errorLog.Add("Bill detail is missing, please add particulars");
                _result = true;
            }
            else
            {
                errorLog.Remove("Bill detail is missing, please add particulars");
            }

            if (DisplayMessageBox && errorLog.Count > 0)
            {
                StringBuilder elog = new StringBuilder();
                foreach (var error in errorLog)
                {
                    elog.AppendLine(error);
                }
                MessageBox.Show(elog.ToString(),
                    "ERROR!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return _result;
        }
        private int insertPatientRecord()
        {
            var _patientRecord = new DataContext.Patient();
            _patientRecord.fullName = txtPatientName.Text.Trim();
            _patientRecord.mobileNumber = txtMobile.Text.Trim();
            _patientRecord.age = int.Parse(txtAge.Text.Trim());
            _patientRecord.patientType = rbPrivate.Checked ? "Private" : "Staff";
            _patientRecord.weight = int.Parse(txtWeight.Text.Trim());
            _patientRecord.gender = !rbMale.Checked;
            _patientRecord.bloodPressure = int.Parse(txtBloodPressureUpper.Text.Trim());
            _patientRecord.bloodGroup = this.cmbBloodGroup.Text.Trim();
            _patientRecord.height = Convert.ToDouble(txtHight.Text.Trim());
            _patientRecord.createdBy = 1;
            _patientRecord.createDate = DateTime.Now;

            db.Patients.Add(_patientRecord);
            db.SaveChanges();

            return _patientRecord.id;
        }
        private int updatePatientRecord()
        {
            int _id = int.Parse(txtPatientId.Text.ToString());
            var patient = db.Patients.Where(a => a.id == _id).FirstOrDefault();
            if (patient != null)
            {
                patient.fullName = txtPatientName.Text.ToString();
                patient.mobileNumber = txtMobile.Text.ToString();
                patient.age = int.Parse(txtAge.Text.ToString());
                patient.weight = int.Parse(txtWeight.Text.ToString());
                patient.height = Convert.ToDouble(txtHight.Text);
                patient.patientType = rbPrivate.Checked ? "Private" : "Staff";
                patient.gender = rbMale.Checked;
                patient.bloodPressure = int.Parse(txtBloodPressureUpper.Text.ToString());
                patient.bloodGroup = this.cmbBloodGroup.Text.Trim();
                patient.modifiedBy = auth.currentUser.id;
                patient.modifiedDate = DateTime.Now;
                db.SaveChanges();
            }
            return _id;
        }


        //************************************************//
        public frmBill()
        {
            InitializeComponent();
        }
        private void frmPatientInvoiceForm_Load(object sender, EventArgs e)
        {
            cmbDoctor.Enabled = false;
            cmbDoctorDepartment.Enabled = false;
            this.applyToAll(gbPatientDetail);
            this.applyToAll(this);
            this.bindSerivesCombobox();
            this.bindPatientList();
            this.bindDoctorCategoryCombobox();
            this.bindDoctorCombobox();
            cmbBloodGroup.SelectedIndex = 0;
            this.billId = 0;

            dgvVisit.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVisit.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvVisit.Columns["Discount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVisit.Columns["Discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvVisit.Columns["DiscountRate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVisit.Columns["DiscountRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvVisit.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVisit.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }


        private void cmbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDocFee.Text = "0";
            ComboBoxItem item = cmbServices.SelectedItem as ComboBoxItem;
            if (item != null)
            {
                cmbDoctor.Enabled = true;
                cmbDoctorDepartment.Enabled = true;
                int value = Convert.ToInt32(item.Value);
                if (value > 2)
                {
                    var _fee = db.Services
                        .Where(p => p.id == value)
                        .FirstOrDefault()
                        .price.Value;
                    lblDocFee.Text = _fee.ToString();
                }
                this.bindDoctorCombobox();
            }
        }
        private void cmbDoctorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbDoctorDepartment.SelectedIndex > 0)
            {
                lblDocFee.Text = "0";
                lblToken.Text = "0";

                var _item = cmbDoctorDepartment.SelectedItem as ComboBoxItem;
                int _departmentId = Convert.ToInt32(_item.Value);
                this.bindDoctorCombobox(_departmentId);
            }
        }
        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedIndex > 0)
            {
                var _item = cmbDoctor.SelectedItem as ComboBoxItem;
                int _docid = Convert.ToInt32(_item.Value);
                var service = cmbServices.SelectedItem as ComboBoxItem;
                if (service != null)
                {
                    double _fee = 0;
                    if (((int)service.Value == (int)Services.OPDVISIT))
                    {
                        _fee = db.Doctors
                       .Where(x => x.id == _docid)
                       .FirstOrDefault()
                       .opdFee;
                    }
                    else if ((int)service.Value == (int)Services.CONSULTANTVISIT)
                    {
                        _fee = db.Doctors
                        .Where(x => x.id == _docid)
                        .FirstOrDefault()
                        .consultantFee;
                    }

                    lblDocFee.Text = string.Format("{0:0.00}", _fee);
                    lblToken.Text = generateToken(_docid).ToString();
                }
            }
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
                    txtMobile.Text = _patient.mobileNumber.ToString();
                    txtAge.Text = _patient.age.HasValue ? _patient.age.ToString() : "0";
                    //male/female.Text = _patient.fullName.ToString();
                    if (!_patient.gender.Value) rbMale.Checked = true;
                    else rbFemale.Checked = true;

                    if (_patient.patientType == "Staff") rbStaff.Checked = true;
                    else rbPrivate.Checked = true;

                    cmbBloodGroup.Text = _patient.bloodGroup;
                    txtHight.Text = _patient.height.HasValue ? _patient.height.Value.ToString() : "0";
                }
            }
        }
        private void dgvVisit_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double _gross = 0;
            foreach (DataGridViewRow row in dgvVisit.Rows)
            {
                var priceColumn = row.Cells["Price"];
                if (!string.IsNullOrEmpty(priceColumn.Value.ToString()))
                    _gross += Convert.ToDouble(priceColumn.Value);
            }

            lblGrandTotal.Text = string.Format("{0:0.00}", _gross);
        }
        private void gvPatientList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.toggleUserList();
            txtPatientName.Focus();
        }

        private void gvPatientList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.toggleUserList();
                txtPatientName.Focus();
            }
        }
        private void txtSearchCriteria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down
                || e.KeyCode == Keys.Up
                || e.KeyCode == Keys.PageDown
                || e.KeyCode == Keys.PageUp)
            {
                gvPatientList.NavigateGridView(e.KeyCode);
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Enter)
            {
                this.toggleUserList();
            }
        }
        private void txtPaidAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !this.validateForm(true))
            {
                int id = 0;
                if (MessageBox.Show("Are you sure to save?", "SAVE?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = this.generateBill();
                }

                if (MessageBox.Show("Are you sure to generate this invoice?",
                    "SAVE",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.prepareAndPrintInvoice(id);
                }

                if (id > 0)
                    this.bindPatientList();

                MessageBox.Show("Record saved successfully...",
                        "SUCCESS",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                this.resetform();
            }
        }

        private void btnSearchPanelClose_Click(object sender, EventArgs e)
        {
            this.toggleUserList();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.toggleUserList();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            KeyEventArgs ke = new KeyEventArgs(Keys.Enter);
            txtPaidAmount_KeyDown(txtPaidAmount, ke);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.bindServicesGrid();
            this.calculateTotal();

            cmbServices.SelectedIndex = 0;
            lblDocFee.Text = "0";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtControls_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }
        //private void btnPrintDetails_Click(object sender, EventArgs e)
        //{
        //    //if (this.validateForm(true))
        //    //this.printReciept();
        //    this.prepareAndPrintInvoice();
        //}

        private void lblGrandTotal_TextChanged(object sender, EventArgs e)
        {
            lblBillAmount.Text = string.Format("{0:0.00}", lblGrandTotal.Text);
        }
        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double paid = Convert.ToDouble(txtPaidAmount.Text);
                double total = Convert.ToDouble(lblGrandTotal.Text);
                if (paid >= total)
                {
                    lblBanalce.Text = string.Format("{0:0.00}", total - paid);
                }
            }
            catch (Exception ex)
            {
                lblBanalce.Text = string.Format("{0:0.00}", 0);
            }
        }
    
        private void gvPatientList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gvPatientList.Visible = true;
        }

        private void cmbServices_Leave(object sender, EventArgs e)
        {
            if (cmbServices.SelectedItem is null)
                MessageBox.Show("Invalid service please try again.",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void txtControl_Leave(object sender, EventArgs e)
        {
            this.validateForm();
        }

        private void txtControls_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyAllowNumericValue(sender, e);
        }

        private void dgvVisit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var totalCell = dgvVisit.Rows[e.RowIndex].Cells["Total"];

                var priceCell = dgvVisit.Rows[e.RowIndex].Cells["Price"];
                double priceCellValue = Convert.ToDouble(priceCell.Value);

                var discountCell = dgvVisit.Rows[e.RowIndex].Cells["Discount"];
                var discountCellValue = discountCell.Value.ToString();

                double discountValue = discountCellValue.Contains("%") ?
                    (priceCellValue * (Convert.ToDouble(discountCellValue.Substring(0, discountCellValue.IndexOf('%'))) / 100))
                    : Convert.ToDouble(discountCellValue);

                dgvVisit.Rows[e.RowIndex].Cells["DiscountRate"].Value = string.Format("{0:0.00}", discountValue);

                totalCell.Value = string.Format("{0:0.00}", priceCellValue - discountValue);

                this.calculateTotal();
            }
            catch (Exception ex)
            {
                dgvVisit.Rows[e.RowIndex].Cells["Discount"].Value = "0";
                MessageBox.Show("Invalid discount value.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgvVisit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvVisit.Columns["btnDelete"].Index)
            {
                dgvVisit.Rows.RemoveAt(e.RowIndex);
                this.calculateTotal();
            }
        }

    }
}