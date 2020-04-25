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
using ShifaClinic.Session;
using System.IO;

namespace ShifaClinic.Doctors
{
    public partial class frmDoctor : BaseForm
    {
        Auth auth;
        private bool editMode;
        private bool isPictureUpdated;
        private List<int> removedServicesFromShares;
        private List<int> removedProceduresFromShares;
        private List<int> removedShareConfigurationIds;
        private object tempServiceShareValue;
        private object tempProcedureShareValue;
        private enum Services
        {
            OPDVISIT = 1,
            CONSULTANTVISIT = 2,
            OTHERS
        }

        private void bindDoctorDeparmentComboBox()
        {
            using (var db = new clinicDbContext())
            {
                List<DoctorDepartment> _doctorDepartments = db.DoctorDepartments.ToList();
                this.cmbDoctorDepartment.DisplayMember = "title";
                this.cmbDoctorDepartment.ValueMember = "id";
                this.cmbDoctorDepartment.DataSource = _doctorDepartments;
            }
        }
        private void bindDoctorsGrid()
        {
            using (var db = new clinicDbContext())
            {
                dgvDoctorsList.Columns["Fees"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDoctorsList.Columns["Fees"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDoctorsList.AutoGenerateColumns = false;
                var dsDoctors = new List<POCO.Doctor>();
                foreach (var dr in db.Doctors.Include("DoctorDepartment").ToList())
                {
                    var d = new POCO.Doctor();
                    d.id = dr.id;
                    d.name = dr.name.Trim();
                    d.mobileNumber = dr.mobileNumber.Trim();
                    d.backupPhone = dr.backupPhone.Trim();
                    d.dob = dr.dob.HasValue ? dr.dob.Value.ToShortDateString() : "";
                    d.Address = dr.permanentAddress is null ? "" : dr.permanentAddress.Trim();
                    d.departmentTitle = dr.DoctorDepartment.title;
                    d.gender = dr.GenderText;
                    d.licenseNumber = dr.licenseNumber.Trim();
                    d.CNIC = dr.CNIC.Trim();
                    dsDoctors.Add(d);
                }
                dgvDoctorsList.DataSource = dsDoctors;
            }
        }
        private void bindServicesComboBox()
        {
            using (var db = new clinicDbContext())
            {
                foreach (var item in db.Services.ToList())
                {
                    var comboBoxItem = new ComboBoxItem()
                    {
                        Text = item.title.Trim(),
                        Value = item.id
                    };
                    cmbServices.Items.Add(comboBoxItem);
                }
                cmbServices.Items.Insert(0, new ComboBoxItem() { Value = 0, Text = "-- SELECT SERVICE--" });
                cmbServices.SelectedIndex = 0;
                cmbServices.DisplayMember = "Text";
                cmbServices.ValueMember = "Value";
            }
        }
        private void bingProceduresComboBox()
        {
            using (var db = new clinicDbContext())
            {
                foreach (var item in db.Procedures.ToList())
                {
                    var comboBoxItem = new ComboBoxItem()
                    {
                        Text = item.title.Trim(),
                        Value = item.id
                    };
                    cmbProcedures.Items.Add(comboBoxItem);
                }
                cmbProcedures.Items.Insert(0, new ComboBoxItem() { Value = 0, Text = "-- SELECT PROCEDURE--" });
                cmbProcedures.SelectedIndex = 0;
                cmbProcedures.DisplayMember = "Text";
                cmbProcedures.ValueMember = "Value";
            }
        }
        private void resetForm(TabPage selectedPage = null)
        {
            this.editMode = false;
            this.isPictureUpdated = true;
            this.removedProceduresFromShares = new List<int>();
            this.removedServicesFromShares = new List<int>();
            this.tempProcedureShareValue = null;
            this.tempServiceShareValue = null;

            pbDisplayPicture.Image = null;
            cmbDoctorDepartment.SelectedIndex = 0;
            cmbServices.SelectedIndex = 0;
            cmbProcedures.SelectedIndex = 0;
            txtOpdFee.Text = "0.00";
            txtDoctorId.Text = "0";
            txtName.Text = "";
            txtMobile.Text = "";
            txtBackupPhone.Text = "";
            txtPermanentAddress.Text = "";
            txtCredentials.Text = "";
            txtLicenceNumber.Text = "";
            chkIsConsultant.Checked = false;
            rbMale.Checked = true;
            dgvProcedures.Rows.Clear();
            dgvServices.Rows.Clear();
            cmbDoctorDepartment.Focus();

            tcMaster.SelectedTab = selectedPage is null ? tpDetails : selectedPage;
        }
        private bool validateForm(bool DisplayMessageBox = false)
        {
            bool _result = false;
            List<string> errorLog = new List<string>();
            Color ErrorHighlightColor = Color.Linen;
            Color ValidColor = Color.White;
            if (cmbDoctorDepartment.SelectedIndex == 0)
            {
                errorLog.Add("Department is required.");
                cmbDoctorDepartment.BackColor = ErrorHighlightColor;
                _result = true;
            }
            else
            {
                cmbDoctorDepartment.BackColor = ValidColor;
                errorLog.Remove("Department is required.");
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorLog.Add("Name is required.");
                txtName.BackColor = ErrorHighlightColor;
                _result = true;
            }
            else
            {
                txtMobile.BackColor = ValidColor;
                errorLog.Remove("Name is required.");
            }

            if (string.IsNullOrEmpty(txtCNIC.Text))
            {
                errorLog.Add("CNIC Number is required.");
                txtCNIC.BackColor = ErrorHighlightColor;
                _result = true;
            }
            else
            {
                txtCNIC.BackColor = ValidColor;
                errorLog.Remove("CNIC Number is required.");
            }

            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                errorLog.Add("Mobile Number is required.");
                txtMobile.BackColor = ErrorHighlightColor;
                _result = true;
            }
            else
            {
                txtMobile.BackColor = ValidColor;
                errorLog.Remove("Mobile Number is required.");
            }

            if (string.IsNullOrEmpty(txtCredentials.Text))
            {
                errorLog.Add("Credentials are required.");
                txtCredentials.BackColor = ErrorHighlightColor;
                _result = true;
            }
            else
            {
                txtCredentials.BackColor = ValidColor;
                errorLog.Remove("Credentials are required.");
            }

            double amount = Convert.ToDouble(string.IsNullOrEmpty(txtOpdFee.Text) ? "0" : txtOpdFee.Text);
            if ((amount <= 0 || amount < Convert.ToDouble(txtOpdFee.Text)))
            {
                errorLog.Add("Fee is required.");
                txtOpdFee.BackColor = ErrorHighlightColor;
                _result = true;
            }
            else
            {
                txtOpdFee.BackColor = ValidColor;
                errorLog.Remove("Fee is required.");
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
        private void insert()
        {
            Cursor.Current = Cursors.WaitCursor;

            if (!this.validateForm(true))
            {
                using (var db = new clinicDbContext())
                {
                    var dr = new Doctor();
                    dr.name = txtName.Text.Trim();
                    dr.mobileNumber = txtMobile.Text.Trim();
                    dr.licenseNumber = txtLicenceNumber.Text.Trim();
                    dr.departmentId = int.Parse(cmbDoctorDepartment.SelectedValue.ToString());
                    dr.dob = dtpDOB.Value;
                    dr.gender = rbMale.Checked ? true : false;
                    dr.opdFee = Convert.ToDouble(txtOpdFee.Text.Trim());
                    dr.consultantFee = Convert.ToDouble(txtConsultantFee.Text.Trim());
                    dr.CNIC = txtCNIC.Text.Trim();
                    dr.backupPhone = txtBackupPhone.Text.Trim();
                    dr.permanentAddress = txtPermanentAddress.Text;
                    dr.isConsultant = chkIsConsultant.Checked;
                    dr.isOpd = chkIsOpd.Checked;
                    dr.credentials = txtCredentials.Text.Trim();
                    dr.createdBy = auth.currentUser.id;
                    dr.createdDate = DateTime.Now;

                    if (pbDisplayPicture.Image != null)
                    {
                        ImageConverter converter = new ImageConverter();
                        dr.photo = (byte[])converter.ConvertTo(pbDisplayPicture.Image, typeof(byte[]));
                    }

                    db.Doctors.Add(dr);
                    db.SaveChanges();

                    foreach (DataGridViewRow row in dgvServices.Rows)
                    {
                        var ss = new DoctorShareConfiguration();
                        ss.serviceId = Convert.ToInt32(row.Cells["serviceId"].Value);
                        ss.doctorId = dr.id;
                        ss.percentage = Convert.ToInt32(row.Cells["serviceSharePercentage"].Value);
                        ss.createdBy = auth.currentUser.id;
                        ss.createDate = DateTime.Now;
                        db.DoctorShareConfigurations.Add(ss);
                    }
                    foreach (DataGridViewRow row in dgvProcedures.Rows)
                    {
                        var ps = new DoctorShareConfiguration();
                        ps.procedureId = Convert.ToInt32(row.Cells["procedureId"].Value);
                        ps.doctorId = dr.id;
                        ps.percentage = Convert.ToInt32(row.Cells["procedureSharePercentage"].Value);
                        ps.createdBy = auth.currentUser.id;
                        ps.createDate = DateTime.Now;
                        db.DoctorShareConfigurations.Add(ps);
                    }
                    db.SaveChanges();
                }
                this.resetForm();

                MessageBox.Show("Record has been added succesfully",
                    "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Cursor.Current = Cursors.Default;
        }
        private void update(int doctorId)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (!this.validateForm(true))
            {
                using (var db = new clinicDbContext())
                {
                    var dr = db.Doctors.Where(p => p.id == doctorId).FirstOrDefault();
                    if (dr is null)
                    {
                        MessageBox.Show("There is some error to update this Doctor's information. Please try again.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dr.departmentId = int.Parse(cmbDoctorDepartment.SelectedValue.ToString());
                    dr.isConsultant = chkIsConsultant.Checked;
                    dr.isOpd = chkIsOpd.Checked;
                    dr.name = txtName.Text.Trim();
                    dr.mobileNumber = txtMobile.Text.Trim();
                    dr.backupPhone = txtBackupPhone.Text.Trim();
                    dr.dob = dtpDOB.Value;
                    dr.gender = rbMale.Checked ? true : false;
                    dr.CNIC = txtCNIC.Text.Trim();
                    dr.permanentAddress = txtPermanentAddress.Text;
                    dr.licenseNumber = txtLicenceNumber.Text.Trim();
                    dr.credentials = txtCredentials.Text.Trim();
                    dr.opdFee = Convert.ToDouble(txtOpdFee.Text.Trim());
                    dr.consultantFee = Convert.ToDouble(txtConsultantFee.Text.Trim());

                    if (this.isPictureUpdated && pbDisplayPicture.Image != null)
                    {
                        ImageConverter converter = new ImageConverter();
                        dr.photo = (byte[])converter.ConvertTo(pbDisplayPicture.Image, typeof(byte[]));
                    }
                    dr.modifiedBy = auth.currentUser.id;
                    dr.modifyDate = DateTime.Now;

                    // Removed selected to database - Services/Procedure
                    foreach (var id in this.removedShareConfigurationIds)
                    {
                        var share = db.DoctorShareConfigurations.Where(p => p.id == id).FirstOrDefault();
                        if (share != null)
                            db.DoctorShareConfigurations.Remove(share);
                    }
                    db.SaveChanges();

                    // Update selected to database -Services
                    foreach (DataGridViewRow row in dgvServices.Rows)
                    {
                        bool isChangeOccured = false;
                        if ((bool)row.Cells["IsServiceShareUpdated"].Value
                            && Convert.ToInt32(row.Cells["serviceShareId"].Value) > 0)
                        {
                            // Update existing values
                            var id = Convert.ToInt32(row.Cells["serviceShareId"].Value);
                            var share = db.DoctorShareConfigurations.Where(p => p.id == id).FirstOrDefault();
                            if (share is null)
                            {
                                // Insert new configuration
                                var ss = new DoctorShareConfiguration();
                                ss.serviceId = Convert.ToInt32(row.Cells["serviceId"].Value);
                                ss.doctorId = dr.id;
                                ss.percentage = Convert.ToInt32(row.Cells["serviceSharePercentage"].Value);
                                ss.createdBy = auth.currentUser.id;
                                ss.createDate = DateTime.Now;
                                db.DoctorShareConfigurations.Add(ss);
                            }
                            else
                            {
                                share.percentage = Convert.ToInt32(row.Cells["serviceSharePercentage"].Value);
                                share.modifiedBy = auth.currentUser.id;
                                share.modifyDate = DateTime.Now;
                            }
                            isChangeOccured = true;
                        }
                        else if (!(bool)row.Cells["IsServiceShareUpdated"].Value && Convert.ToInt32(row.Cells["serviceShareId"].Value) <= 0)
                        {
                            // Insert new configuration
                            var ss = new DoctorShareConfiguration();
                            ss.serviceId = Convert.ToInt32(row.Cells["serviceId"].Value);
                            ss.doctorId = dr.id;
                            ss.percentage = Convert.ToInt32(row.Cells["serviceSharePercentage"].Value);
                            ss.createdBy = auth.currentUser.id;
                            ss.createDate = DateTime.Now;
                            db.DoctorShareConfigurations.Add(ss);
                            isChangeOccured = true;
                        }
                        if (isChangeOccured)
                            db.SaveChanges();
                    }

                    // Update selected to database - Procedure
                    foreach (DataGridViewRow row in dgvProcedures.Rows)
                    {
                        bool isChangeOccured = false;
                        if ((bool)row.Cells["IsProcedureShareUpdated"].Value
                            && Convert.ToInt32(row.Cells["procedureShareId"].Value) > 0)
                        {
                            // Update existing values
                            var id = Convert.ToInt32(row.Cells["procedureShareId"].Value);
                            var share = db.DoctorShareConfigurations.Where(p => p.id == id).FirstOrDefault();
                            if (share is null)
                            {
                                // Insert new configuration
                                var ss = new DoctorShareConfiguration();
                                ss.procedureId = Convert.ToInt32(row.Cells["procedureId"].Value);
                                ss.doctorId = dr.id;
                                ss.percentage = Convert.ToInt32(row.Cells["procedureSharePercentage"].Value);
                                ss.createdBy = auth.currentUser.id;
                                ss.createDate = DateTime.Now;
                                db.DoctorShareConfigurations.Add(ss);
                            }
                            else
                            {
                                share.percentage = Convert.ToInt32(row.Cells["procedureSharePercentage"].Value);
                                share.modifiedBy = auth.currentUser.id;
                                share.modifyDate = DateTime.Now;
                            }
                            isChangeOccured = true;
                        }
                        else if (Convert.ToInt32(row.Cells["procedureShareId"].Value) <= 0)
                        {
                            // Insert new configuration
                            var ss = new DoctorShareConfiguration();
                            ss.procedureId = Convert.ToInt32(row.Cells["procedureId"].Value);
                            ss.doctorId = dr.id;
                            ss.percentage = Convert.ToInt32(row.Cells["procedureSharePercentage"].Value);
                            ss.createdBy = auth.currentUser.id;
                            ss.createDate = DateTime.Now;
                            db.DoctorShareConfigurations.Add(ss);
                            isChangeOccured = true;
                        }
                        if (isChangeOccured)
                            db.SaveChanges();
                    }

                }

                MessageBox.Show("Record has been updated succesfully",
                    "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.resetForm();
            }

            Cursor.Current = Cursors.Default;
        }
        private void loadData()
        {
            Cursor.Current = Cursors.WaitCursor;
            this.editMode = true;
            this.removedServicesFromShares = new List<int>();
            this.removedProceduresFromShares = new List<int>();

            using (var db = new clinicDbContext())
            {
                var drId = Convert.ToInt32(txtDoctorId.Text);
                var dr = db.Doctors.Where(p => p.id == drId).FirstOrDefault();
                if (dr != null)
                {
                    cmbDoctorDepartment.SelectedValue = dr.departmentId;
                    txtName.Text = dr.name.Trim();
                    txtMobile.Text = dr.mobileNumber.Trim();
                    txtBackupPhone.Text = dr.backupPhone.Trim();
                    txtCNIC.Text = dr.CNIC.Trim();
                    txtPermanentAddress.Text = dr.permanentAddress is null ? "" : dr.permanentAddress.Trim();
                    dtpDOB.Value = dr.dob.HasValue ? dr.dob.Value : DateTime.Now;
                    rbMale.Checked = dr.gender.Value ? true : false;
                    rbFemale.Checked = !dr.gender.Value ? true : false;
                    txtCredentials.Text = dr.credentials is null ? "" : dr.credentials.Trim();

                    txtOpdFee.Text = string.Format("{0:0.00}", dr.opdFee);
                    txtConsultantFee.Text = string.Format("{0:0.00}", dr.consultantFee);
                    chkIsConsultant.Checked = dr.isConsultant;
                    chkIsOpd.Checked = dr.isOpd;

                    if (dr.photo != null)
                    {
                        var stream = new MemoryStream(dr.photo as byte[]);
                        pbDisplayPicture.Image = Image.FromStream(stream);
                        pbDisplayPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    dgvServices.AutoGenerateColumns = false;
                    foreach (var s in db.DoctorShareConfigurations
                                        .Where(p => p.serviceId != null && p.doctorId == dr.id)
                                        .Select(p => new
                                        {
                                            id = p.id,
                                            serviceId = p.serviceId,
                                            serviceTitle = p.Service.title.Trim(),
                                            serviceSharePercentage = p.percentage.ToString()
                                        }).ToList())
                    {
                        dgvServices.Rows.Add(s.serviceId, s.serviceTitle, s.serviceSharePercentage, false, s.id);
                    }

                    dgvProcedures.AutoGenerateColumns = false;
                    foreach (var s in db.DoctorShareConfigurations
                                        .Where(p => p.procedureId != null && p.doctorId == dr.id)
                                        .Select(p => new
                                        {
                                            id = p.id,
                                            procedureId = p.procedureId,
                                            procedureTitle = db.Procedures.Where(pr => pr.id == p.procedureId).FirstOrDefault().title.Trim(),
                                            procedureSharePercentage = p.percentage.ToString()
                                        }).ToList())
                    {
                        dgvProcedures.Rows.Add(s.procedureId, s.procedureTitle, s.procedureSharePercentage, false, s.id);
                    }
                }
                tcMaster.SelectedTab = tpDetails;
            }

            Cursor.Current = Cursors.Default;
        }

        public frmDoctor()
        {
            InitializeComponent();
        }
        private void frmDoctorForm_Load(object sender, EventArgs e)
        {
            this.auth = new Auth();
            this.editMode = false;
            this.removedProceduresFromShares = new List<int>();
            this.removedServicesFromShares = new List<int>();
            this.removedShareConfigurationIds = new List<int>();

            this.bindDoctorDeparmentComboBox();
            this.bindServicesComboBox();
            this.bingProceduresComboBox();
            this.bindDoctorsGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to save the record?",
                "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (this.editMode && Convert.ToInt32(txtDoctorId.Text) > 0)
                {
                    this.update(Convert.ToInt32(txtDoctorId.Text));
                }
                else
                {
                    this.insert();
                }
                this.bindDoctorsGrid();
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

        private void txtOpdFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }

        private void txtConsultantFee_KeyPress(object sender, KeyPressEventArgs e)
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
            this.resetForm();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp"
            };
            openFileDialog.Title = "SELECT DISPLAY PICTURE";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbDisplayPicture.ImageLocation = openFileDialog.FileName;
                pbDisplayPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                this.isPictureUpdated = true;
            }
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            if (cmbServices.SelectedIndex > 0 && Convert.ToInt32(txtServiceShare.Text) > 0)
            {
                var item = cmbServices.SelectedItem as ComboBoxItem;
                #region Error validation for isConsultant Checkbox
                //int serviceId = Convert.ToInt32(item.Value);
                //if (serviceId == (int)Services.OPDVISIT && chkIsConsultant.Checked)
                //{
                //    MessageBox.Show("For OPD share configuration, Consultant shall be un-checked.", "INFORMATION",
                //        MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    chkIsConsultant.BackColor = Color.Yellow;
                //    chkIsConsultant.Focus();
                //    return;
                //}
                //if (serviceId == (int)Services.CONSULTANTVISIT && !chkIsConsultant.Checked)
                //{
                //    MessageBox.Show("For Consultants share configuration, Consultant shall be checked.", "INFORMATION",
                //        MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    chkIsConsultant.BackColor = Color.Yellow;
                //    chkIsConsultant.Focus();
                //    return;
                //}
                #endregion

                // Validate if entry exist for Services
                foreach (DataGridViewRow row in dgvServices.Rows)
                {
                    //(int)row.Cells["serviceId"].Value == (int)Services.OPDVISIT || (int)row.Cells["serviceId"].Value == (int)Services.CONSULTANTVISIT
                    if (row.Cells["serviceId"].Value == item.Value)
                    {
                        MessageBox.Show("This configuration already exist. Please update share (%) value.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvServices.CurrentCell = row.Cells["serviceSharePercentage"];
                        dgvServices.BeginEdit(false);
                        row.Selected = true;
                        return;
                    }
                }

                chkIsConsultant.BackColor = Color.Transparent;

                dgvServices.Rows.Add(item.Value, item.Text, txtServiceShare.Text, false);
                txtServiceShare.Text = "0";
                cmbServices.SelectedIndex = 0;
                cmbServices.Focus();
            }
            else
            {
                txtServiceShare.Focus();
                txtServiceShare.SelectAll();
            }
        }

        private void btnProcedureAdd_Click(object sender, EventArgs e)
        {
            if (cmbProcedures.SelectedIndex > 0 && Convert.ToInt32(txtProcedureShare.Text) > 0)
            {
                var item = cmbProcedures.SelectedItem as ComboBoxItem;
                // Validate if entry exist for Procedures
                foreach (DataGridViewRow row in dgvProcedures.Rows)
                {
                    if (row.Cells["procedureId"].Value == item.Value)
                    {
                        MessageBox.Show("This configuration already exist. Please update share (%) value.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        row.Selected = true;
                        dgvProcedures.CurrentCell = row.Cells["procedureSharePercentage"];
                        dgvProcedures.BeginEdit(false);
                        return;
                    }
                }

                dgvProcedures.Rows.Add(item.Value, item.Text, txtProcedureShare.Text, false);
                txtProcedureShare.Text = "0";
                cmbProcedures.SelectedIndex = 0;
                cmbProcedures.Focus();
            }
            else
            {
                txtProcedureShare.Focus();
                txtProcedureShare.SelectAll();
            }
        }

        private void txtProcedureShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }

        private void txtServiceShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }

        private void txtProcedureShare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnProcedureAdd_Click(null, null);
            }
        }

        private void txtServiceShare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnServiceAdd_Click(null, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All changes will be lost, are you sure to cancel?",
                "QUESTION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TabPage selectedPage = tpDetails;
                if (this.editMode)
                    selectedPage = tpList;
                this.resetForm(selectedPage);
            }
        }

        private void txtCNIC_Click(object sender, EventArgs e)
        {
            txtCNIC.SelectAll();
        }

        private void dgvDoctorsList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.loadData();
        }

        private void dgvDoctorsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.loadData();
        }
        private void dgvDoctorsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.loadData();
        }

        private void dgvDoctorsList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.loadData();
            }
        }

        private void dgvDoctorsList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtDoctorId.Text = dgvDoctorsList.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }

        private void tpList_Enter(object sender, EventArgs e)
        {
            dgvDoctorsList.Focus();
            dgvDoctorsList.Select();
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvServices.Columns["btnDeleteServiceShare"].Index)
            {
                if (editMode)
                {
                    this.removedShareConfigurationIds.Add(Convert.ToInt32(dgvServices.Rows[e.RowIndex].Cells["serviceShareId"].Value));
                    this.removedServicesFromShares.Add(Convert.ToInt32(dgvServices.Rows[e.RowIndex].Cells["serviceId"].Value));
                }

                dgvServices.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvProcedures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProcedures.Columns["btnDeleteProcedureShare"].Index)
            {
                if (editMode)
                {
                    this.removedShareConfigurationIds.Add(Convert.ToInt32(dgvProcedures.Rows[e.RowIndex].Cells["procedureShareId"].Value));
                    this.removedProceduresFromShares.Add(Convert.ToInt32(dgvProcedures.Rows[e.RowIndex].Cells["procedureId"].Value));
                }

                dgvProcedures.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvProcedures_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.tempProcedureShareValue = dgvProcedures.Rows[e.RowIndex].Cells["procedureSharePercentage"].Value;
        }

        private void dgvProcedures_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.tempProcedureShareValue != dgvProcedures.Rows[e.RowIndex].Cells["procedureSharePercentage"].Value)
            {
                dgvProcedures.Rows[e.RowIndex].Cells["IsProcedureShareUpdated"].Value = true;
            }
        }

        private void dgvServices_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.tempServiceShareValue = dgvServices.Rows[e.RowIndex].Cells["serviceSharePercentage"].Value;

        }

        private void dgvServices_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.tempServiceShareValue != dgvServices.Rows[e.RowIndex].Cells["serviceSharePercentage"].Value)
            {
                dgvServices.Rows[e.RowIndex].Cells["IsServiceShareUpdated"].Value = true;
            }
        }

        private void chkIsOpd_CheckedChanged(object sender, EventArgs e)
        {
            txtOpdFee.Enabled = chkIsOpd.Checked;
        }

        private void chkIsConsultant_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultantFee.Enabled = chkIsConsultant.Checked;
        }
    }
}