using System;
using ShifaClinic.Common;
using System.Windows.Forms;
using ShifaClinic.DataContext;
using ShifaClinic.Session;
using ShifaClinic.Reports.Poco;

namespace ShifaClinic.Accounts
{
    public partial class frmCashInForm : Form
    {
        Auth auth = new Auth();
        public bool validateForm()
        {
            if (txt5000.Text != "0" ||
                txt1000.Text != "0" ||
                txt500.Text != "0" ||
                txt100.Text != "0" ||
                txt50.Text != "0" ||
                txt20.Text != "0" ||
                txt10.Text != "0" ||
                txt5.Text != "0" ||
                txt2.Text != "0" ||
                txt1.Text != "0"
                )
            {
                return true;
            }
            else
            {
                MessageBox.Show("Add any amount",
                   "ERROR",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }
        }
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
            var dscashIn = new dsCashIn();
            dscashIn.createDate = DateTime.Now.ToString();
            dscashIn.createdByName = auth.currentUser.fullName;
            dscashIn.totalAmount = txtTotal.Text;
            dscashIn.remarks = txtRemarks.Text;
            dscashIn.Rs5000 = txt5000.Text;
            dscashIn.Rs1000 = txt1000.Text;
            dscashIn.Rs500 = txt500.Text;
            dscashIn.Rs100 = txt100.Text;
            dscashIn.Rs50 = txt50.Text;
            dscashIn.Rs20 = txt20.Text;
            dscashIn.Rs10 = txt10.Text;
            dscashIn.Rs5 = txt5.Text;
            dscashIn.Rs2 = txt2.Text;
            dscashIn.Rs1 = txt1.Text;
            var dtcashIn = Utility.MapToDataTable<Reports.Poco.dsCashIn>(dscashIn);
            dtcashIn.TableName = "dsCashIn";
            ReportPrint reportPrint = new ReportPrint();
            reportPrint.Print(dtcashIn, "dsCashIn", "Voucher_CashIn.rdlc", "Accounts");
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
            if (validateForm())
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

        private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.Focus();
            }
        }
    }
}
