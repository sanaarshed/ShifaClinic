using ShifaClinic.DataContext;
using ShifaClinic.Patient;
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
    public partial class frmDashboardForm : Form
    {
        public bool Status { get; set; }
        public frmDashboardForm()
        {
            InitializeComponent();
        }

        private void frmDashboardForm_Load(object sender, EventArgs e)
        {
            if (this.Status == true)
            {
                //this.btnUsers.Visible = true;
                //this.btnDoctors.Visible = true;
            }
            else
            {
                //btnUsers.Visible = false;
                //btnDoctors.Visible = false;
            }

            using (var db = new clinicDbContext())
            {
                
            }

        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            InvoiceForm f = new InvoiceForm();
            f.MdiParent = this;
            f.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
