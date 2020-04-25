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
    public partial class frmRoleForm : ShifaClinic.Common.BaseForm
    {
        public frmRoleForm()
        {
            InitializeComponent();
        }

        private void bindRoleList()
        {

            using (var db = new clinicDbContext())
            {

                List<string> _roleList = new List<string>();

                foreach (var _r in db.Roles.ToList())
                {
                    _roleList.Add(_r.roleTitle);
                }
                dgvRoleList.AutoGenerateColumns = false;
                dgvRoleList.DataSource = _roleList;
            }
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            bindRoleList();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (var db = new clinicDbContext())
            {
                if (string.IsNullOrEmpty(txtRoleTitle.Text))
                {
                    MessageBox.Show("please enter Role Title", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var _role = new Role();
                    _role.roleTitle = txtRoleTitle.Text.ToString();

                    if (db.Roles.Where(a => a.roleTitle == _role.roleTitle).FirstOrDefault() != null)
                    {
                        db.Roles.Add(_role);
                        db.SaveChanges();
                        MessageBox.Show("successfully added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindRoleList();
                        txtRoleTitle.Clear();
                    }
                }
            }

        }

        private void txtRoleTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
