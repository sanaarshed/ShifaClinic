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
        }
        private void Ctrl_GotFocus(object sender, EventArgs e)
        {
            var ctrl = sender as TextBox;
            //ctrl.SelectAll();
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
                }
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

            if (string.IsNullOrEmpty(txtPaidAmmount.Text))
            {
                int _paid = int.Parse(txtPaidAmmount.Text);
                int _balance = _billAmount - _paid;
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

        private void bindDoctorCombobox(clinicDbContext db)
        {
            foreach (var doc in db.Doctors.ToList())
            {
                string _text = string.Format("{0} ({1})", doc.name, doc.DoctorDepartment.title);
                cmbDoctor.Items.Add(new ComboBoxItem(doc.fees.Value, _text));
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
            var _source = db.Patients.ToList();

            List<POCO.Patient> _patients = new List<POCO.Patient>();
            foreach (var i in _source)
            {
                var _p = new POCO.Patient();
                _p.id = i.id;
                _p.fullName = i.fullName;
                _p.mobileNumber = i.mobileName;
                _p.gender = i.gender ? "Male" : "Female";
                _p.mobileNumber = i.mobileName;
                _p.mobileNumber = i.mobileName;
                _p.status = i.status.Value ? "Active" : "In-Active";
                _p.roleTitle = i.Role.roleTitle;

                _patients.Add(_p);
            }

            gvPatientList.AutoGenerateColumns = false;
            gvPatientList.DataSource = _patients;
        }
        
        /// Constructor
        /// 
        public InvoiceForm()
        {
            InitializeComponent();
        }
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            this.applyToAll(gbPatientDetail);

            using (var db = new clinicDbContext())
            {
                this.bindDoctorCategoryCombobox(db);
                this.bindDoctorCombobox(db);
                this.bindPatientList(db);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.toggleUserList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            using (var db = new clinicDbContext())
            {

                var _patientRecord = new DataContext.Patient();
                _patientRecord.fullName = txtPatientName.Text.Trim();
                _patientRecord.mobileName = txtMobile.Text.Trim();
                //_patientRecord.DOB = txtAge.Text.Trim();
                _patientRecord.patientType = rbPrivate.Checked ? "private" : "Staff";
                _patientRecord.weight = int.Parse(txtWeight.Text.Trim());
                _patientRecord.bloodPressure = int.Parse(txtBloodPressure.Text.Trim());
                _patientRecord.patientType = rbFemale.Checked ? "Female" : "Male";
                _patientRecord.createdBy = 1;
                _patientRecord.createDate = DateTime.Now;
                _patientRecord.doctorId = int.Parse(cmbDoctor.SelectedValue.ToString());//???????? we have to put doctors id in patient record how can it will be able to get the id rather the combo box is showing a different data..eg doctor name or department id
                _patientRecord.token = int.Parse(lblToken.Text);
                //_patientRecord.b = billNumberGenerated();


                var _bill = new Bill();
                _bill.gross = int.Parse(lblGross.Text);
                //_bill.discount = int.Parse(txtDiscount.Text)||int.Parse(txtDiscountInPercentage.Text); 
                _bill.billAmount = int.Parse(lblBillAmmount.Text);
                _bill.balance = int.Parse(lblBanalce.Text);

                db.Patients.Add(_patientRecord);

                db.SaveChanges();
                MessageBox.Show("patient record addede sucessfully", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetform();

            }

        }

        private void resetform()
        {
            txtPatientName.Text = string.Empty;
            txtFee.Text = string.Empty;
            txtPatientId.Text = string.Empty;
            txtMobile.Text = string.Empty;
            rbMale.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtBloodPressure.Text = string.Empty;
            rbStaff.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtDiscountInPercentage.Text = string.Empty;
            lblBanalce.Text = string.Empty;
            lblBillAmmount.Text = string.Empty;
            lblGross.Text = string.Empty;
            lblToken.Text = string.Empty;

        }

        private int generateBill(int fees)
        {
            return 0;
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
                var _docId = int.Parse(cmbDoctor.SelectedValue.ToString());
                var _fee = db.Doctors.Where(x => x.id == _docId).FirstOrDefault().fees.Value;
                txtFee.Text = _fee.ToString();
                lblGross.Text = _fee.ToString();

                generateBill(_fee);
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
            this.calculateBill();
        }
        private void txtDiscountInPercentage_TextChanged(object sender, EventArgs e)
        {
            this.txtDiscount.Text = "0";
            this.calculateBill();
        }

        private void txtPaidAmmount_TextChanged(object sender, EventArgs e)
        {
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
    }
}
