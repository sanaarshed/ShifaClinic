using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using ShifaClinic.Common;
using ShifaClinic.DataContext;
using ShifaClinic.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Accounts
{
    public partial class frmReturnProcedures : BaseForm
    {
        Auth auth = new Auth();

        private bool validateForm(bool DisplayMessageBox = false)
        {
            bool _result = false;
            List<string> errorLog = new List<string>();
            if (string.IsNullOrEmpty(txtPatientId.Text))
            {
                errorLog.Add("Invalid return, please check Bill ID.");
                txtBillProcedureId.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtBillProcedureId.BorderColor = Color.Blue;
                errorLog.Remove("Invalid return, please check Bill ID.");
            }

            double paidAmount = Convert.ToDouble(string.IsNullOrEmpty(txtPaidAmount.Text) ? "0" : txtPaidAmount.Text);
            if (string.IsNullOrEmpty(txtPaidAmount.Text) && Convert.ToDouble(txtPaidAmount.Text) <= 0)
            {
                errorLog.Add("Paid amount is required.");
                txtPaidAmount.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtPaidAmount.BorderColor = Color.Blue;
                errorLog.Remove("Paid amount is required.");
            }
            double returnableAmount = string.IsNullOrEmpty(txtReturnableAmount.Text) ? 0
                : Convert.ToDouble(txtReturnableAmount.Text);
            if (paidAmount <= 0 || returnableAmount <= 0)
            {
                errorLog.Add("Invalid amount, please check Bill ID.");
                txtPaidAmount.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtPaidAmount.BorderColor = Color.Blue;
                errorLog.Remove("Invalid amount, please check Bill ID.");
            }

            if (paidAmount > returnableAmount)
            {
                errorLog.Add("Invalid Paid Amount.");
                txtPaidAmount.BorderColor = Color.Red;
                txtPaidAmount.Focus();
                txtPaidAmount.SelectAll();
                _result = true;
            }
            else
            {
                txtPaidAmount.BorderColor = Color.Blue;
                errorLog.Remove("Invalid Paid Amount.");
            }


            if (string.IsNullOrEmpty(txtReason.Text) || txtReason.Text == "Please provide reason before submitting return...")
            {
                errorLog.Add("Return Reason is required.");
                txtReason.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtReason.BorderColor = Color.Blue;
                errorLog.Remove("Return Reason is required.");
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
        private void submitReturn()
        {
            int voucherId = 0;
            Cursor.Current = Cursors.WaitCursor;
            using (var db = new clinicDbContext())
            {
                db.Configuration.ProxyCreationEnabled = false;

                var returnObjectList = new List<ProcedureReturn>();
                foreach (DataGridViewRow row in dgvServices.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].EditedFormattedValue))
                    {
                        var returnObject = new ProcedureReturn()
                        {
                            billProcedureId = Convert.ToInt32(txtBillProcedureId.Text),
                            billProcedureDetailId = Convert.ToInt32(row.Cells["id"].Value),
                            doctorId = Convert.ToInt32(row.Cells["DoctorId"].Value),
                            actualAmount = Convert.ToDouble(txtReturnableAmount.Text),
                            balanceAmount = Convert.ToDouble(lblBalanceAmount.Text),
                            returnedAmount = Convert.ToDouble(txtPaidAmount.Text),
                            reason = txtReason.Text.Trim(),
                            createDate = DateTime.Now,
                            createdBy = this.auth.currentUser.id
                        };
                        returnObjectList.Add(returnObject);

                        var procedureDetail = db.BillProcedureDetails
                            .Where(p => p.id == returnObject.billProcedureDetailId)
                            .FirstOrDefault();
                        if (!procedureDetail.isReturnFiled)
                        {
                            procedureDetail.isReturnFiled = true;
                            db.SaveChanges();
                        }
                    }
                }
                db.ProcedureReturns.AddRange(returnObjectList);
                db.SaveChanges();

                var referenceDataInJson = Newtonsoft.Json.JsonConvert.SerializeObject(returnObjectList,
                    new Newtonsoft.Json.JsonSerializerSettings()
                    {
                        PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects,
                        Formatting = Newtonsoft.Json.Formatting.Indented
                    });

                var voucher = new Voucher()
                {
                    amount = Convert.ToDouble(txtPaidAmount.Text),
                    flow = "Out",
                    mode = "Cash",
                    title = "Procedure Return Cash Reciept",
                    createdBy = this.auth.currentUser.id,
                    createDate = DateTime.Now,
                    referenceEntity = returnObjectList.GetType().ToString(),
                    referenceData = referenceDataInJson
                };
                db.Vouchers.Add(voucher);
                db.SaveChanges();
                voucherId = voucher.id;

                // Overhead
                foreach (var item in returnObjectList)
                {
                    var pr = db.ProcedureReturns.Where(p => p.id == item.id).FirstOrDefault();
                    if(pr != null)
                        pr.voucherId = voucherId;
                    db.SaveChanges();
                }
            }

            if (MessageBox.Show("Do you want to generate voucher for this Return?",
                "QUESTION",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // send report to printer
            }

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Return filed successfully...",
                "SUCCESS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.formReset();

        }
        private void findBillProcedure()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (var db = new clinicDbContext())
            {
                int billProcedureId = Convert.ToInt32(txtBillProcedureId.Text);
                var billProcedure = db.BillProcedures.Where(p => p.id == billProcedureId).FirstOrDefault();
                if (billProcedure is null)
                {
                    MessageBox.Show("Invalid Procedure Bill #, Please try again...",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var procedureDetails = billProcedure.BillProcedureDetails.Where(p => p.billProcedureId == billProcedureId).ToList();
                if (procedureDetails.Count <= 0)
                {
                    MessageBox.Show("There are NO PURCHASED PROCEDURE for return against ID...",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.formReset();
                    return;
                }

                List<POCO.BillProcedureDetail> procedureList = new List<POCO.BillProcedureDetail>();
                foreach (var sd in procedureDetails
                    .Where(p => p.isReturnFiled == false && p.billProcedureId == billProcedureId).ToList())
                {
                    procedureList.Add(new POCO.BillProcedureDetail()
                    {
                        Id = sd.id,
                        DoctorId = sd.doctorId,
                        DoctorName = sd.Doctor.name,
                        Price = sd.amount,
                        ProcedureTitle = sd.Procedure.title
                    });
                }
                dgvServices.DataSource = procedureList;

                txtBillProcedureId.Enabled = false;
                btnFind.Enabled = false;

                lblBillId.Text = string.Format("{0:0000000}", billProcedure.id);
                lblBillDate.Text = string.Format("{0:dddd, dd MMM yyyy hh:mm:ss tt}", billProcedure.createDate);
                lblBilledByName.Text = string.Format("{0} ({1})", billProcedure.User.fullName, billProcedure.User.username);

                var patient = db.Patients.Where(p => p.id == billProcedure.patientId).FirstOrDefault();
                if (patient != null)
                {
                    txtPatientId.Text = patient.id.ToString();
                    txtPatientName.Text = patient.fullName;
                    txtPatientMobileNumber.Text = patient.mobileNumber;
                    lblGender.Text = patient.GenderText;
                    rbPrivate.Checked = true;
                    txtAge.Text = patient.age.ToString();
                }

                btnSave.Enabled = true;
                txtReason.Focus();
            }
            Cursor.Current = Cursors.Default;
        }
        private void formReset()
        {
            btnSave.Enabled = false;
            btnFind.Enabled = true;

            lblDate.Text = string.Format("{0:dddd, dd MMM yyyy}", DateTime.Now);
            txtBillProcedureId.Enabled = true;
            txtBillProcedureId.Text = "0";
            txtBillProcedureId.Focus();
            txtBillProcedureId.SelectAll();
            lblBillDate.Text = "";
            lblBilledByName.Text = "";

            txtReturnableAmount.Text = "0.00";
            txtPaidAmount.Text = "0.00";
            lblBalanceAmount.Text = "0.00";
            txtReason.Text = "Please provide reason before submitting return...";
            cmbReasonTemplates.SelectedIndex = 0;

            txtPatientId.Text = "0";
            txtPatientName.Text = "";
            txtPatientMobileNumber.Text = "";
            lblGender.Text = "Male/Female";

            txtPatientId.Text = "0";
            txtAge.Text = "0";
            dgvServices.DataSource = null;
        }
        private void calculateTotal()
        {
            double sum = 0;
            foreach (DataGridViewRow row in dgvServices.Rows)
            {
                if (Convert.ToBoolean(row.Cells["chkService"].Value))
                    sum += Convert.ToDouble(row.Cells["price"].Value);
            }
            txtReturnableAmount.Text = string.Format("{0:0.00}", sum);
        }

        public frmReturnProcedures()
        {
            InitializeComponent();
        }
        private void frmReturnServices_Load(object sender, EventArgs e)
        {
            dgvServices.AutoGenerateColumns = false;
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvServices.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.formReset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Enabled && !this.validateForm(true))
                this.submitReturn();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.findBillProcedure();
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Utility.onlyAllowNumericValue(sender, e);
        }

        private void txtBillId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Utility.onlyAllowNumericValue(sender, e);
        }

        private void txtReason_Enter(object sender, EventArgs e)
        {
            txtReason.SelectAll();
        }

        private void txtBillId_Enter(object sender, EventArgs e)
        {
            txtBillProcedureId.SelectAll();
        }

        private void txtPaidAmount_Enter(object sender, EventArgs e)
        {
            txtPaidAmount.SelectAll();
        }

        private void txtPaidAmount_Click(object sender, EventArgs e)
        {
            txtPaidAmount.SelectAll();
        }

        private void txtPaidAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnSave.Enabled && !this.validateForm(true))
                    this.submitReturn();
            }
        }

        private void txtBillId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind_Click(null, null);
            }
        }

        private void cmbReasonTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReasonTemplates.SelectedIndex > 0)
            {
                txtReason.Text = cmbReasonTemplates.Text;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.formReset();
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            double returnableAmount = string.IsNullOrEmpty(txtReturnableAmount.Text) ? 0
                : Convert.ToDouble(txtReturnableAmount.Text);
            double paidAmount = string.IsNullOrEmpty(txtPaidAmount.Text) ? 0
                : Convert.ToDouble(txtPaidAmount.Text);

            var sum = paidAmount - returnableAmount;
            lblBalanceAmount.Text = string.Format("{0:0.00}", sum);
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                double sum = Convert.ToDouble(txtReturnableAmount.Text);
                var row = dgvServices.Rows[e.RowIndex];

                if (Convert.ToBoolean(row.Cells[e.ColumnIndex].EditedFormattedValue))
                    sum += Convert.ToDouble(dgvServices.Rows[e.RowIndex].Cells["price"].Value);
                else
                {
                    sum -= Convert.ToDouble(dgvServices.Rows[e.RowIndex].Cells["price"].Value);
                }

                txtReturnableAmount.Text = string.Format("{0:0.00}", sum);
            }

            // this.calculateTotal();
        }
    }
}
