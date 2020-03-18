using ShifaClinic.DataContext;
using ShifaClinic.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Session
{
    public partial class frmDashboardForm : Form
    {
        private List<Form> openedForms;

        public bool Status { get; set; }
        public frmDashboardForm()
        {
            InitializeComponent();
            this.openedForms = new List<Form>();
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
            var _f = new frmPatientInvoiceForm();
            _f.MdiParent = this;

            var exist = openedForms.Where
                (a => a.GetType() == _f.GetType()).
                FirstOrDefault();

            if (exist == null)
            {
                openedForms.Add(_f);
                _f.Show();

            }
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
        
            var form = new frmPatientInvoiceForm();
            form.MdiParent = this;
            

            var exist = this.openedForms
                .Where(p => form.GetType() == p.GetType())
                .FirstOrDefault();

            if (exist == null)
            {
                this.openedForms.Add(form);
                form.Show();
                
            }
            else { 
                // If you want to show customize message....
            }
        }

        private void tsmiDoctorsClosingBook_Click(object sender, EventArgs e)
        {
            var form = new frmClosingBookForm();
            form.MdiParent = this;

            var exist = this.openedForms.Where
                (a => form.GetType() == a.GetType())
                .FirstOrDefault();

            if (exist == null)
            {
                this.openedForms.Add(form);
                form.Show();
            }
        }

        private void tsmiProfile_Click(object sender, EventArgs e)
        {

        }

        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            var _f = new frmLogInForm();
            this.Hide();
            _f.Show();

        }

        private void tsmiPatientsList_Click(object sender, EventArgs e)
        {
            ListOfPatients _f = new ListOfPatients();
            _f.MdiParent = this;

            var exist = openedForms.Where
                (a => a.GetType() == _f.GetType()).
                FirstOrDefault();

            if (exist == null)
            {
                openedForms.Add(_f);
                _f.Show();

            }


        }

        private void tsmiDoctors_Click(object sender, EventArgs e)
        {
            frmDoctorForm _f = new frmDoctorForm();
            _f.MdiParent = this;

            var exist = openedForms.Where
                (a => a.GetType() == _f.GetType()).
                FirstOrDefault();

            if (exist == null)
            {
                openedForms.Add(_f);
                _f.Show();

            }
        }

        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            UserForm _f = new UserForm();
            _f.MdiParent = this;

            var exist = openedForms.Where
                (a => a.GetType() == _f.GetType()).
                FirstOrDefault();

            if (exist == null)
            {
                openedForms.Add(_f);
                _f.Show();

            }

        }

        private void tsmiPatients_Click(object sender, EventArgs e)
        {
            var _f = new ListOfPatients();
            _f.MdiParent = this;

            var exist = openedForms.Where
                (a => a.GetType() == _f.GetType()).
                FirstOrDefault();

            if (exist == null)
            {
                openedForms.Add(_f);
                _f.Show();

            }
        }

        private void stsmiDoctors_Click(object sender, EventArgs e)
        {
            var _f = new frmDoctorForm();
            _f.MdiParent = this;

            var exist = openedForms.Where
                (a => a.GetType() == _f.GetType()).
                FirstOrDefault();

            if (exist == null)
            {
                openedForms.Add(_f);
                _f.Show();

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
