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

namespace ShifaClinic.Patient
{
    public partial class frmEntryForm : Form
    {
        private bool validateForm()
        {
            bool result = false;
            formError.Clear();

            if (string.IsNullOrEmpty(txtPatientName.Text))
            {
                this.formError.SetError(txtPatientName, "This field is required");
            }
            else
            {
                this.formError.SetError(txtPatientName, "");
            }

            //if (string.IsNullOrEmpty(txtMobileNumber.Text))
            //{
            //    this.formError.SetError(txtMobileNumber, "This field is required");
            //}
            //else
            //{
            //    this.formError.SetError(txtMobileNumber, "");
            //}


            return result;
        }
        public frmEntryForm()
        {
            InitializeComponent();
        }

        private void txtPatientName_Leave(object sender, EventArgs e)
        {
            this.validateForm();
        }

        private void txtMobileNumber_Leave(object sender, EventArgs e)
        {
            this.validateForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.validateForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.validateForm();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("There is some error on form", "Error!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            }
        }

        private void frmEntryForm_Load(object sender, EventArgs e)
        {
            using (var db = new clinicDbContext())
            {
                var list = db.Users.ToList();
                dgvPatientList.AutoGenerateColumns = false;
                dgvPatientList.DataSource = list;
            }
        }

        private void dgvPatientList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvPatientList.Rows[e.RowIndex].Cells[0].Value.ToString());
            using (var db = new clinicDbContext()) {
                var user = db.Users.Where(c => c.id == id).FirstOrDefault();
                if (user != null)
                {
                    //txtFatherName.Text = user.fullName;
                }
            }

        }
    }
}
