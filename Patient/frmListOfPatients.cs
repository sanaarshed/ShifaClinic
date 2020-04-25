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
    public partial class frmListOfPatients : ShifaClinic.Common.BaseForm
    {
        public frmListOfPatients()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchByName_KeyPress(object sender, KeyPressEventArgs e)
        {

            using (var db = new clinicDbContext())
            {
                string _name = txtSearchByName.Text.ToString().Trim();

                var _n = db.Patients.Where(a => a.fullName == _name).FirstOrDefault().fullName.ToString();
                dgvbindPatientList(_n);
            }

        }

        private void dgvbindPatientList(string n)
        {

            //binding list of patients 

        }
    }
}
