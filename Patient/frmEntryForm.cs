using Microsoft.IdentityModel.Tokens;
using ShifaClinic.Common;
using ShifaClinic.DataContext;
using ShifaClinic.Session;
using SqlServerTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Patient
{
    public partial class frmEntryForm : ShifaClinic.Common.BaseForm
    {
        private Auth auth;
        private bool isEdit;
        private int editRowIndex;
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

            if (string.IsNullOrEmpty(txtAge.Text) || Convert.ToInt32(txtAge.Text) <= 0)
            {
                errorLog.Add("Age is required");
                txtAge.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtAge.BorderColor = Color.Blue;
                errorLog.Remove("Age is required");
            }

            if (string.IsNullOrEmpty(txtMobileNumber.Text))
            {
                errorLog.Add("Mobile number is required");
                txtMobileNumber.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtMobileNumber.BorderColor = Color.Blue;
                errorLog.Remove("Mobile number is required");
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
        private void resetForm()
        {
            this.isEdit = false;
            lblFormMode.Text = "NEW";
            txtPatientId.Text = "0";
            txtPatientName.Text = "";
            txtAge.Text = "0";
            rbMale.Checked = true;
            txtCNIC.Text = "";
            txtMobileNumber.Text = "";
            txtFatherName.Text = "";
            txtFatherMobile.Text = "";
            txtHomeAddress.Text = "";
        }
        private void dgvPatientList_SelectRowForEdit(int rowIndex)
        {
            using (var row = dgvPatientList.Rows[rowIndex])
            {
                txtPatientId.Text = row.Cells["id"].Value.ToString();
                txtPatientName.Text = row.Cells["fullName"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value is null ? "0" : row.Cells["age"].Value.ToString();
                txtMobileNumber.Text = row.Cells["mobileNumber"].Value.ToString();
                rbMale.Checked = row.Cells["gender"].Value.Equals("Male") ? true : false;
                rbFemale.Checked = row.Cells["gender"].Value.Equals("Female") ? true : false;

                dtpDOB.Value = row.Cells["dob"].Value is null ? DateTime.Now : Convert.ToDateTime(row.Cells["dob"].Value);
                txtCNIC.Text = Convert.ToString(row.Cells["cnic"].Value);
                txtFatherMobile.Text = Convert.ToString(row.Cells["fatherMobileNumber"].Value);
                txtFatherName.Text = Convert.ToString(row.Cells["fatherName"].Value);
                txtHomeAddress.Text = Convert.ToString(row.Cells["address"].Value);

                this.isEdit = true;
                lblFormMode.Text = "EDIT";
                txtPatientName.Focus();
                txtPatientName.SelectAll();
            }
        }
        public frmEntryForm()
        {
            InitializeComponent();
        }
        private void frmEntryForm_Load(object sender, EventArgs e)
        {
            this.isEdit = false;
            this.editRowIndex = -1;
            this.auth = new Auth();
            using (var db = new clinicDbContext())
            {
                var list = db.Patients.ToList();
                dgvPatientList.AutoGenerateColumns = false;
                dgvPatientList.DataSource = list;
                dgvPatientList.ScrollBars = ScrollBars.Both;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.validateForm(true))
            {
                if (MessageBox.Show("Are you sure to save?",
                    "QUESTION",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new clinicDbContext())
                    {
                        if (this.isEdit)
                        {
                            int id = Convert.ToInt32(txtPatientId.Text);
                            var p = db.Patients.Where(c => c.id == id).FirstOrDefault();
                            if (p != null)
                            {
                                p.fullName = txtPatientName.Text.Trim();
                                p.age = Convert.ToInt32(string.IsNullOrEmpty(txtAge.Text) ? "0" : txtAge.Text.Trim());
                                p.mobileNumber = txtMobileNumber.Text.Trim();
                                p.gender = rbMale.Checked;
                                p.modifiedBy = auth.currentUser.id;
                                p.modifiedDate = DateTime.Now;

                                if (dtpDOB.Value.Date < DateTime.Now)
                                    p.dob = dtpDOB.Value;

                                if (!string.IsNullOrEmpty(txtCNIC.Text))
                                    p.CNIC = txtCNIC.Text.Trim();

                                if (!string.IsNullOrEmpty(txtFatherMobile.Text))
                                    p.fatherMobile = txtFatherMobile.Text.Trim();

                                if (!string.IsNullOrEmpty(txtFatherName.Text))

                                    p.fatherName = txtFatherName.Text.Trim();

                                if (!string.IsNullOrEmpty(txtHomeAddress.Text))
                                    p.address = txtHomeAddress.Text.Trim();

                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            DataContext.Patient p = new DataContext.Patient();
                            p.fullName = txtPatientName.Text.Trim();
                            p.age = Convert.ToInt32(string.IsNullOrEmpty(txtAge.Text) ? "0" : txtAge.Text.Trim());
                            p.gender = rbMale.Checked;
                            p.mobileNumber = txtMobileNumber.Text.Trim();
                            p.createdBy = auth.currentUser.id;
                            p.createDate = DateTime.Now;

                            if (dtpDOB.Value < DateTime.Now)
                                p.dob = dtpDOB.Value;
                            if (string.IsNullOrEmpty(txtCNIC.Text))
                                p.CNIC = txtCNIC.Text.Trim();
                            if (string.IsNullOrEmpty(txtFatherMobile.Text))
                                p.fatherMobile = txtFatherMobile.Text.Trim();
                            if (string.IsNullOrEmpty(txtFatherName.Text))
                                p.fatherName = txtFatherName.Text.Trim();
                            if (string.IsNullOrEmpty(txtHomeAddress.Text))
                                p.address = txtHomeAddress.Text.Trim();

                            db.Patients.Add(p);
                            db.SaveChanges();
                        }

                        dgvPatientList.DataSource = null;
                        dgvPatientList.Rows.Clear();
                        dgvPatientList.DataSource = db.Patients.ToList();
                        this.resetForm();

                        MessageBox.Show("Record Saved Successfully...",
                                    "SUCCESS", 
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.resetForm();
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Utility.onlyAllowNumericValue(sender, e);
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = Common.Utility.GetAge(dtpDOB.Value).ToString();
        }

        private void dgvPatientList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dgvPatientList_SelectRowForEdit(e.RowIndex);
        }

        private void dgvPatientList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.dgvPatientList_SelectRowForEdit(this.editRowIndex);
            }
        }

        private void dgvPatientList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.editRowIndex = e.RowIndex;
        }
    }
}
