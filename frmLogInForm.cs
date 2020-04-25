using ShifaClinic.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Session
{
    public partial class frmLogInForm : Form
    {
        public frmLogInForm()
        {
            InitializeComponent();
        }
       
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            using (var db = new clinicDbContext())
            {
                string _username = txtUserName.Text.ToString().Trim();
                string _password = txtPassword.Text.ToString().Trim();
                if (db.Users.Where(a => a.username == _username ).
                    FirstOrDefault() != null)
                {
                    if (db.Users.Where(x => x.password == _password).FirstOrDefault() != null)
                    {
                        var _status = db.Users.Where(x => x.password == _password).FirstOrDefault().
                            status.Value;
                        this.Hide();
                        var _dashboardForm = new frmDashboardForm();
                        _dashboardForm.Status = _status;
                        _dashboardForm.Show();

                    }
                    else {
                        MessageBox.Show("your password was " +
                            "incorrect.Please double-check your password","Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);  
                    }
                }
                else {
                    MessageBox.Show("Sorry, User name does't exist ", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {

            formError.Clear();
            if (string.IsNullOrEmpty(txtUserName.Text))
                this.formError.SetError(txtUserName, "this field is required");
            else
            {
                this.formError.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

            formError.Clear();
            if (string.IsNullOrEmpty(txtPassword.Text))
                this.formError.SetError(txtPassword, "this field is required");
            else
            {
                this.formError.SetError(txtPassword, "");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogInForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}
