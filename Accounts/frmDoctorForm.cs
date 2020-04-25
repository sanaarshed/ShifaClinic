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
using System.Data.Entity;
using ShifaClinic.DataContext;


namespace ShifaClinic.Session
{
    public partial class frmDoctorForm : ShifaClinic.Common.BaseForm
    {
        clinicDbContext db = new clinicDbContext();
        private void frmDoctorForm_Load(object sender, EventArgs e)
        {
            bindDoctorDeparmentComboBox();
            bindDoctorsList();
            db.Configuration.ProxyCreationEnabled = false;
            db.Doctors.Load();
            this.dgvDoctorsList.DataSource = db.Doctors.Local.ToBindingList();
        }
        Auth auth = new Auth();
        public frmDoctorForm()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to add this record",
                "CONFIRMATION", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                insertData();
                bindDoctorsList();
            }
            else
            { //return to previous state
            }
        }
        public void insertData()
        {
            using (clinicDbContext db = new clinicDbContext())
            {
                var _doctor = new Doctor();
                _doctor.name = txtfullName.Text.Trim();
                _doctor.mobileNumber = txtMobile.Text.Trim();
                _doctor.licenseNumber = txtLicenceNumber.Text.Trim();
                _doctor.departmentId = Convert.ToInt32(cmbDocDepartment.SelectedValue.ToString());
                _doctor.gender = rbMale.Checked ? true : false;
                _doctor.age = Convert.ToInt32(txtAge.Text.Trim());
                _doctor.opdFee = Convert.ToDouble(txtFee.Text.Trim());
                _doctor.CNIC = txtCNIC.Text.Trim();
                //_doctor.sharePercentage = int.Parse(txtSharePercentage.Text.Trim());
                _doctor.backupPhone = txtBackupPhone.Text.Trim();
                _doctor.permanentAddress = txtPermanentAddress.Text;
                _doctor.createdBy = auth.currentUser.id;
                _doctor.createdDate = DateTime.Now;
                //_doctor.photo = ;
                db.Doctors.Add(_doctor);
                db.SaveChanges();
            }
                MessageBox.Show("Record has been added succesfully",
                    "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void bindDoctorDeparmentComboBox()
        {
            List<DoctorDepartment> _doctorDepartments = db.DoctorDepartments.ToList();
            this.cmbDocDepartment.DisplayMember = "title";
            this.cmbDocDepartment.ValueMember = "id";
            this.cmbDocDepartment.DataSource = _doctorDepartments;
        }

        public void bindDoctorsList()
        {
            using (var db = new clinicDbContext())
            {
                var _doc = db.Doctors.ToList();
                List<POCO.Doctor> _d = new List<POCO.Doctor>();
                foreach (var _i in _doc)
                {
                    var _temp = new POCO.Doctor();
                    _temp.name = _i.name;
                    _temp.dob = _i.age.HasValue ? _i.age.ToString() : "0";
                    _temp.gender = _i.gender.Value ? "Male" : "Female";
                    _temp.id = _i.id;
                    _temp.mobileNumber = _i.mobileNumber.ToString();
                    _temp.licenseNumber = _i.licenseNumber.ToString();
                    _temp.Address = _i.permanentAddress;
                    //_temp.share = _i.sharePercentage.Value;
                    _temp.departmentTitle = _i.DoctorDepartment.title.ToString();
                    _temp.fee = _i.opdFee.ToString();
                    _temp.CNIC = _i.CNIC.ToString();
                    _d.Add(_temp);
                }
                dgvDoctorsList.AutoGenerateColumns = false;
                dgvDoctorsList.DataSource = _d;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }
        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }
        private void txtLicenceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }
        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }
        private void txtCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }
        private void txtSharePercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }
        private void txtBackupPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }
        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            var _x = sender as DateTimePicker;
            var age = Utility.GetAge(_x.Value);
            txtAge.Text = age.ToString(); ;
        }
        private void dgvDoctorsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //String value = e.Value as string;
            //if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            //{
            //    e.Value = e.CellStyle.NullValue;
            //    e.FormattingApplied = true;
            //}
        }
        private void txtSerarchByName_TextChanged(object sender, EventArgs e)
        {   
            //if (string.IsNullOrEmpty(this.txtSerarchByName.Text))
            //{
            //    var filteredData = db.Doctors.Where(x => x.name.Contains(
            //        this.txtSerarchByName.Text));

            ////this.dgvDoctorsList.DataSource = filteredData.Count() > 0 ?
            ////filteredData: filteredData.ToArray();
            //this.dgvDoctorsList.DataSource = db.Doctors.Local.ToBindingList();
            //}
        }
        private void cmbDocDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
        }
    }
}


