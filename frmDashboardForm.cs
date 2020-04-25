using ShifaClinic.Common;
using ShifaClinic.DataContext;
using ShifaClinic.Employee;
using ShifaClinic.Patient;
using ShifaClinic.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Session
{
    public partial class frmDashboardForm : Form
    {
        private List<Form> openedForms;

        public bool Status { get; set; }

        private void ManageMenuForms(BaseForm form)
        {
            Cursor.Current = Cursors.WaitCursor;

            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.FormClosing += Form_FormClosing; ;
            form.Show();

            #region TabControl
            //form.MinimizeBox = false;
            //form.MaximizeBox = false;
            //form.Dock = DockStyle.Fill;
            //form.FormBorderStyle = FormBorderStyle.None;
            //TabPage tabPage = new TabPage(form.Text);
            //tabPage.Controls.Add(form);
            //tabPage.Text = form.Text;
            //mainTabControl.TabPages.Add(tabPage);
            //int tabPageIndex = mainTabControl.TabPages.Count - 1;
            //mainTabControl.SelectTab(tabPageIndex);
            //form.TabPageIndex = tabPageIndex;
            #endregion

            var exist = this.MdiChildren
                .Where(f => f.GetType() == form.GetType())
                .FirstOrDefault();

            if (exist == null)
            {
            }

            Cursor.Current = Cursors.Default;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Event for runtime added forms
        }

        //private void TabPageContextMenuClose_Click(object sender, EventArgs e) { }
        public frmDashboardForm()
        {
            InitializeComponent();
            this.openedForms = new List<Form>();
        }
        private void frmDashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        //this.ManageMenuForms(new frmClosingBookForm());

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Logout
            var _f = new frmLogInForm();
            this.Hide();
            _f.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void serviceBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Accounts.frmBill());
        }

        private void procedureBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Accounts.frmProcedureBill());
        }

        private void oPDVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Accounts.frmReturnServiceOPD());
        }

        private void consultantVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Accounts.frmReturnServiceConsultant());
        }

        private void serviceBillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Accounts.frmReturnServices());
        }

        private void procedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Accounts.frmReturnProcedures());
        }

        private void cashBookCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Accounts.frmDailyCashBookClose());
        }

        private void drBookCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Accounts.frmDrClosingBookForm());
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Doctors.frmDoctor());
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Patient.frmEntryForm());
        }

        private void medicalPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Patient.frmCheckupAndPriscriptionForm());
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ManageMenuForms(new Patient.frmAppointmentForm());
        }
    }
}
