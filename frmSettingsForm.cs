using ShifaClinic.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic
{
    public partial class frmSettingsForm : Form
    {
        public frmSettingsForm()
        {
            InitializeComponent();
        }
        private void frmSettingsForm_Load(object sender, EventArgs e)
        {
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new clinicDbContext())
            {
                var printer = db.PrinterInfoes.Where(p => p.id == 1).FirstOrDefault();
                if (printer != null)
                {
                    printer.name = txtPrinterName.Text;
                    db.SaveChanges();
                }
                btnSave.Enabled = false;
            }
        }
        private void btnOpenPrintDialog_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            txtPrinterName.Text = printDialog.PrinterSettings.PrinterName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
