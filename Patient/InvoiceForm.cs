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
    public partial class InvoiceForm : Form
    {
        private void applyToAll(Control groupBox) {
            foreach (var c in groupBox.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    var ctrl = (TextBox)c;
                    ctrl.GotFocus += Ctrl_GotFocus;
                }
            }
        }

        private void Ctrl_GotFocus(object sender, EventArgs e)
        {
            var ctrl = sender as TextBox;
            //ctrl.SelectAll();
        }

        public InvoiceForm()
        {
            InitializeComponent();

            this.applyToAll(gbPatientDetail);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.gvPatientList.Visible)
            {
                int _top = 0; int _left = 0;
                _top = this.gbPatientDetail.Top + this.btnSearch.Top;
                _left = this.btnSearch.Left + this.btnSearch.Width + 20;
                this.gvPatientList.Top = _top;
                this.gvPatientList.Left = _left;
                this.gvPatientList.Visible = true;
                this.gvPatientList.BringToFront();
            }
            else
            {
                this.gvPatientList.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
