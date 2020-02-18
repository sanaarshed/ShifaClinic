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

namespace ShifaClinic.Patient
{
    public partial class frmBillForm : Form
    {
        public frmBillForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new clinicDbContext())
            {
                var _bills = new Bill();


            }
        }
    }
}
