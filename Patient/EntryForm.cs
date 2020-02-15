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

            if (string.IsNullOrEmpty(txtMobileNumber.Text))
            {
                this.formError.SetError(txtMobileNumber, "This field is required");
            }
            else
            {
                this.formError.SetError(txtMobileNumber, "");
            }


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
    }
}
