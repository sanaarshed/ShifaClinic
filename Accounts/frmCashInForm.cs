using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ShifaClinic.Common;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShifaClinic.DataContext;
using ShifaClinic.Session;

namespace ShifaClinic.Accounts
{
    public partial class frmCashInForm : Form
    {
        Auth auth = new Auth();
        public void calculateTotal()
        {
            txtTotal.Text =
             (Convert.ToInt32(txt5000.Text == "" ? "0" : txt5000.Text) * 5000 +
             Convert.ToInt32(txt1000.Text == "" ? "0" : txt1000.Text) * 1000 +
             Convert.ToInt32(txt500.Text == "" ? "0" : txt500.Text) * 500 +
             Convert.ToInt32(txt100.Text == "" ? "0" : txt100.Text) * 100 +
             Convert.ToInt32(txt50.Text == "" ? "0" : txt50.Text) * 50 +
             Convert.ToInt32(txt20.Text == "" ? "0" : txt20.Text) * 20 +
             Convert.ToInt32(txt10.Text == "" ? "0" : txt10.Text) * 10 +
             Convert.ToInt32(txt5.Text == "" ? "0" : txt5.Text) * 5 +
             Convert.ToInt32(txt2.Text == "" ? "0" : txt2.Text) * 2 +
             Convert.ToInt32(txt1.Text == "" ? "0" : txt1.Text)).ToString();
        }
        private void printReciept()
        {
        }
        public void resetForm()
        {
            txt5000.Text = "0";
            txt1000.Text = "0";
            txt500.Text = "0";
            txt100.Text = "0";
            txt50.Text = "0";
            txt20.Text = "0";
            txt10.Text = "0";
            txt5.Text = "0";
            txt2.Text = "0";
            txt1.Text = "0";
        }
        public frmCashInForm()
        {
            InitializeComponent();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();

        }
        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            resetForm();
        }
        private void frmCashInForm_Load(object sender, EventArgs e)
        {
            foreach (var c in this.groupBox.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    var ctrl = (TextBox)c;
                    ctrl.GotFocus += Ctrl_GotFocus;
                    ctrl.Enter += Ctrl_Enter;
                    ctrl.Click += Ctrl_Click;
                }
            }
        }
        private void Ctrl_Click(object sender, EventArgs e)
        {
            var ctrl = sender as TextBox;
            ctrl.SelectAll();
        }

        private void Ctrl_Enter(object sender, EventArgs e)
        {
            var ctrl = sender as TextBox;
            ctrl.SelectAll();
        }

        private void Ctrl_GotFocus(object sender, EventArgs e)
        {
            var ctrl = sender as TextBox;
            ctrl.SelectAll();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var db = new clinicDbContext())
            {
                var cashIn = new CashIn();
                cashIn.totalCashIn = Convert.ToInt32(txtTotal.Text);
                cashIn.remarks = txtRemarks.Text;
                cashIn.Rs5000 = Convert.ToInt32(txt5000.Text);
                cashIn.Rs1000 = Convert.ToInt32(txt1000.Text);
                cashIn.Rs500 = Convert.ToInt32(txt500.Text);
                cashIn.Rs100 = Convert.ToInt32(txt100.Text);
                cashIn.Rs50 = Convert.ToInt32(txt50.Text);
                cashIn.Rs20 = Convert.ToInt32(txt20.Text);
                cashIn.Rs10 = Convert.ToInt32(txt10.Text);
                cashIn.Rs5 = Convert.ToInt32(txt5.Text);
                cashIn.Rs2 = Convert.ToInt32(txt2.Text);
                cashIn.Rs1 = Convert.ToInt32(txt1.Text);
                cashIn.createDate = DateTime.Now;
                cashIn.createdBy = auth.currentUser.id;
                db.CashIns.Add(cashIn);

                MessageBox.Show("Cash Added successfully...",
                        "SUCCESSFUL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                if (MessageBox.Show("Do you want to generate voucher for this?",
                     "QUESTION",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    printReciept();
                }
                this.resetForm();
            }
        }
    }
}
