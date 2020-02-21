using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShifaClinic.DataContext;

namespace ShifaClinic.Session
{
    public partial class UserForm : Form
    {
        private Auth auth = new Auth();

        public UserForm()
        {
            InitializeComponent();
        }


        private bool validateForm()
        {
            bool _result = false;

            if (string.IsNullOrEmpty(txtUserName.Text.Trim())) { }
            //
            //
            //

            using (var db = new clinicDbContext())
            {
                var u = db.Users.Where(c => c.username.Equals(txtUserName.Text.Trim())).FirstOrDefault();
                if (u != null)
                {
                    MessageBox.Show("Username already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    _result = true;
            }

            return _result;
        }

        private void resetForm()
        {
            txtUserName.Focus();
            txtEmail.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            rbStatusActive.Checked = true;
            cmbUserRole.SelectedIndex = 0;
        }

        private void bindUserList(clinicDbContext db)
        {
            var _source = db.Users.ToList();

            List<POCO.User> _users = new List<POCO.User>();
            foreach (var u in _source)
            {
                var _nu = new POCO.User();
                _nu.id = u.id;
                _nu.username = u.username;
                _nu.email = u.email;
                _nu.status = u.status.Value ? "Active" : "In-Active";
                _nu.roleTitle = u.Role.roleTitle;

                _users.Add(_nu);
            }

            dgvUsersList.AutoGenerateColumns = false;
            dgvUsersList.DataSource = _users;
        }



        private void UserForm_Load(object sender, EventArgs e)
        {
            using (var db = new clinicDbContext())
            {
                cmbUserRole.DisplayMember = "roleTitle";
                cmbUserRole.ValueMember = "id";
                cmbUserRole.DataSource = db.Roles.ToList();

                this.bindUserList(db);
            }

            resetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                using (var db = new clinicDbContext())
                {
                    var _user = new User();
                    _user.username = txtUserName.Text.Trim();
                    _user.password = txtPassword.Text.Trim();
                    _user.status = rbStatusActive.Checked;
                    _user.roleId = int.Parse(cmbUserRole.SelectedValue.ToString());
                    _user.createdBy = auth.currentUser;
                    _user.createDate = DateTime.Now;

                    db.Users.Add(_user);
                    db.SaveChanges();

                    MessageBox.Show("User account created successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.bindUserList(db);
                    resetForm();

                }
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
