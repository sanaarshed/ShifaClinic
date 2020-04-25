using ShifaClinic.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Accounts
{
    public partial class frmDailyCashBookClose : BaseForm
    {
        public frmDailyCashBookClose()
        {
            InitializeComponent();
        }

        public bool IsCashBookClosedForTheDay
        {
            get
            {
                return !false;
            }
        }

        private bool validateForm(bool DisplayMessageBox = false)
        {
            bool _result = false;
            List<string> errorLog = new List<string>();
            if (string.IsNullOrEmpty(txtReceivedBy.Text))
            {
                errorLog.Add("Reciever Name is required");
                txtReceivedBy.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtReceivedBy.BorderColor = Color.Blue;
                errorLog.Remove("Reciever Name is required");
            }

            if (DisplayMessageBox && errorLog.Count > 0)
            {
                StringBuilder elog = new StringBuilder();
                foreach (var error in errorLog)
                {
                    elog.AppendLine(error);
                }
                MessageBox.Show(elog.ToString(),
                    "ERROR!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return _result;
        }

        private void frmDailyCashBookClose_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = string.Format("{0:dddd, dd MMM yyyy}", DateTime.Now);
            if (this.IsCashBookClosedForTheDay)
            {
                groupBox1.Enabled = false;
                lblErrorMessage.Text = string.Format("STOP! System can't proceed. Cash book already closed by {0}.",
                    "SOHAIL ARSHAD");
            }
            else
            {
                groupBox1.Enabled = true;
                lblErrorMessage.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.validateForm(true))
            {
                // db save logic
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
