using ShifaClinic.Common;
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

namespace ShifaClinic.Accounts
{
    public partial class frmProcedureBill : BaseForm
    {
        private Session.Auth auth = new Session.Auth();
        private void bindProcedureComboBox()
        {
            using (var db = new clinicDbContext())
            {
                cmbProcedures.Items.Clear();
                foreach (var item in db.Procedures.ToList())
                {
                    ComboBoxItem cmbItem = new ComboBoxItem(item.id, item.title);
                    cmbProcedures.Items.Add(cmbItem);
                }
                cmbProcedures.Items.Insert(0, new ComboBoxItem(0, "-- SELECT PROCEDURE TO ADD --"));
                cmbProcedures.DisplayMember = "Text";
                cmbProcedures.ValueMember = "Value";
                cmbProcedures.SelectedIndex = 0;
            }
        }
        private void findProcedure(int ProcedureId, bool ignoreError = false)
        {
            using (var db = new clinicDbContext())
            {
                var procedure = db.Procedures.Where(p => p.id == ProcedureId).FirstOrDefault();
                if (procedure != null)
                {
                    lblPrice.Text = string.Format("{0:0.00}", procedure.price);
                    foreach (ComboBoxItem item in cmbProcedures.Items)
                    {
                        if ((int)item.Value == ProcedureId)
                            cmbProcedures.SelectedItem = item;
                    }
                    txtProcedureCode.Text = ProcedureId.ToString();
                    btnAdd.Focus();
                }
                else
                {
                    if (!ignoreError)
                    {
                        MessageBox.Show("Invalid procedure code",
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    cmbProcedures.SelectedIndex = 0;
                    lblPrice.Text = "0.00";
                    txtProcedureCode.Text = "0";
                    txtProcedureCode.Focus();
                    txtProcedureCode.SelectAll();
                }
            }
        }
        private void calculateTotal()
        {
            double sumTotal = 0;
            double sumDiscount = 0;

            foreach (DataGridViewRow row in dgvProcedures.Rows)
            {
                sumTotal += Convert.ToDouble(row.Cells["total"].Value);
                sumDiscount += Convert.ToDouble(row.Cells["DiscountRate"].Value);
            }

            lblGrandTotal.Text = string.Format("{0:0.00}", sumTotal);
            lblTotalDiscount.Text = string.Format("{0:0.00}", sumDiscount);
        }
        private bool verifyBill(int billId)
        {
            bool result = false;
            // Your logic
            return result;
        }
        private void resetForm()
        {
            txtBillId.Text = "0";
            
            txtBillId.Enabled = true;
            txtBillId.Text = "0";

            txtPaidAmount.Text = "0.00";
            lblGrandTotal.Text = "0.00";
            lblTotalDiscount.Text = "0.00";
            lblBillAmount.Text = "0.00";
            lblBalance.Text = "0.00";

            txtPatientId.Text = "0";
            txtPatientName.Text = "";
            txtPatientMobileNumber.Text = "";
            lblGender.Text = "Male/Female";
            cmbBloodGroup.SelectedIndex = 0;

            txtPatientId.Text = "0";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            txtBloodPressureUpper.Text = "0";
            
            dgvProcedures.Rows.Clear();
            dgvProcedures.Refresh();

            this.resetProcedureInput();
        }
        private void resetProcedureInput()
        {
            cmbProcedures.SelectedIndex = 0;
            lblPrice.Text = "0.00";
            txtProcedureCode.Text = "0";
            txtProcedureCode.Focus();
            txtProcedureCode.SelectAll();
        }
        private bool validateForm(bool DisplayMessageBox = false)
        {
            bool _result = false;
            List<string> errorLog = new List<string>();
            if (dgvProcedures.Rows.Count <= 0)
            {
                errorLog.Add("No procedure added, please add procedure to continue.");
                txtProcedureCode.Focus();
                txtProcedureCode.SelectAll();
                _result = true;
            }
            else
            {
                errorLog.Remove("No procedure added, please add procedure to continue.");
            }


            double amount = Convert.ToDouble(string.IsNullOrEmpty(txtPaidAmount.Text) ? "0" : txtPaidAmount.Text);
            if ((amount <= 0 || amount < Convert.ToDouble(lblBillAmount.Text)))
            {
                errorLog.Add("Invalid paid amount.");
                txtPaidAmount.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtPaidAmount.BorderColor = Color.Blue;
                errorLog.Remove("Invalid paid amount.");
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
        private void save()
        {
            if (!this.validateForm(true))
            {
                if (MessageBox.Show("Are you sure to save?", "SAVE?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new clinicDbContext())
                    {
                        var billProcedure = new BillProcedure()
                        {
                            createDate = DateTime.Now,
                            createdBy = auth.currentUser.id,
                            gross = Convert.ToDouble(lblGrandTotal.Text),
                            billAmount = Convert.ToDouble(lblBillAmount.Text),
                            paid = Convert.ToDouble(txtPaidAmount.Text),
                            balance = Convert.ToDouble(lblBalance.Text),
                            discount = Convert.ToDouble(lblTotalDiscount.Text)
                        };
                        if (Convert.ToInt32(txtBillId.Text) > 0)
                            billProcedure.billId = Convert.ToInt32(txtBillId.Text);
                        if (Convert.ToInt32(txtPatientId.Text) > 0)
                            billProcedure.patientId = Convert.ToInt32(txtPatientId.Text);

                        db.BillProcedures.Add(billProcedure);
                        db.SaveChanges();

                        foreach (DataGridViewRow row in dgvProcedures.Rows)
                        {
                            var billProcedureDetail = new BillProcedureDetail();
                            billProcedureDetail.procedureId = (int)row.Cells["id"].Value;
                            billProcedureDetail.actualPrice = Convert.ToDouble(row.Cells["price"].Value);
                            billProcedureDetail.discount = row.Cells["discount"].Value.ToString().Trim();
                            billProcedureDetail.discountRate = Convert.ToDouble(row.Cells["discountRate"].Value);
                            billProcedureDetail.amount = Convert.ToDouble(row.Cells["total"].Value);
                            billProcedureDetail.billProcedureId = billProcedure.id;

                            var cmb = row.Cells["doctorsList"] as DataGridViewComboBoxCell;
                            if (cmb != null && (cmb.Value != DBNull.Value))
                                billProcedureDetail.doctorId = Convert.ToInt32(cmb.Value);

                            db.BillProcedureDetails.Add(billProcedureDetail);
                        }
                        db.SaveChanges();
                    }
                }

                if (MessageBox.Show("Are you sure to generate this invoice?",
                    "SAVE",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // print
                }

                MessageBox.Show("Record saved successfully...",
                        "SUCCESS",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                this.resetForm();
            }
        }

        public frmProcedureBill()
        {
            InitializeComponent();
        }
        private void frmProcedureForm_Load(object sender, EventArgs e)
        {
            dgvProcedures.AutoGenerateColumns = false;
            dgvProcedures.AllowUserToResizeRows = false;
            dgvProcedures.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProcedures.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProcedures.Columns["Discount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProcedures.Columns["Discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProcedures.Columns["DiscountRate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProcedures.Columns["DiscountRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProcedures.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProcedures.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.bindProcedureComboBox();
        }

        private void lblGrandTotal_TextChanged(object sender, EventArgs e)
        {
            lblBillAmount.Text = string.Format("{0:0.00}", lblGrandTotal.Text);
        }
        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double paid = Convert.ToDouble(txtPaidAmount.Text);
                double total = Convert.ToDouble(lblGrandTotal.Text);
                if (paid >= total)
                {
                    lblBalance.Text = string.Format("{0:0.00}", total - paid);
                }
            }
            catch (Exception ex)
            {
                lblBalance.Text = string.Format("{0:0.00}", 0);
            }
        }

        private void dgvProcedures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProcedures.Columns["btnDelete"].Index)
            {
                dgvProcedures.Rows.RemoveAt(e.RowIndex);
                this.calculateTotal();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (var db = new clinicDbContext())
            {
                int billId = Convert.ToInt32(txtBillId.Text);
                var bill = db.Bills.Where(p => p.id == billId).FirstOrDefault();
                if (bill is null)
                {
                    MessageBox.Show("Invalid Bill Id, Please try again...",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtBillId.Text = "0";
                    txtBillId.Focus();
                    txtBillId.SelectAll();
                    return;
                }

                txtBillId.Enabled = false;

                txtPatientId.Text = bill.Patient.id.ToString();
                txtPatientName.Text = bill.Patient.fullName;
                txtPatientMobileNumber.Text = bill.Patient.mobileNumber;
                lblGender.Text = bill.Patient.GenderText;
                rbPrivate.Checked = true;

                txtAge.Text = bill.patientAge.ToString();
                txtHeight.Text = bill.patientHeight.ToString();
                txtWeight.Text = bill.patientWeight.ToString();
                cmbBloodGroup.SelectedText = bill.Patient.bloodGroup;
                txtBloodPressureUpper.Text = bill.bloodPressureUpper.ToString();
                txtBloodPressureLower.Text = bill.bloodPressureLower.ToString();
                btnSave.Enabled = true;
                txtProcedureCode.Focus();
                txtProcedureCode.SelectAll();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.resetForm();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.save();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int procedureId = 0;
            if (!string.IsNullOrEmpty(txtProcedureCode.Text))
            {
                procedureId = Convert.ToInt32(txtProcedureCode.Text);
            }
            if (cmbProcedures.SelectedIndex > 0)
            {
                ComboBoxItem item = cmbProcedures.SelectedItem as ComboBoxItem;
                procedureId = Convert.ToInt32(item.Value);
            }

            using (var db = new clinicDbContext())
            {
                var procedure = db.Procedures.Where(p => p.id == procedureId).FirstOrDefault();
                if (procedure != null)
                {
                    DataGridViewComboBoxCell doctorsListCombobox = new DataGridViewComboBoxCell();
                    foreach (var item in db.Doctors.ToList())
                    {
                        ComboBoxItem comboBoxItem = new ComboBoxItem(item.id, item.name.Trim());
                        doctorsListCombobox.Items.Add(comboBoxItem);
                    }
                    doctorsListCombobox.Items.Insert(0, new ComboBoxItem(DBNull.Value, "-- None --"));
                    doctorsListCombobox.Value = DBNull.Value;
                    doctorsListCombobox.ValueMember = "Value";
                    doctorsListCombobox.DisplayMember = "Text";

                    dgvProcedures.Rows.Add(procedure.id,
                        procedure.title,
                        null,
                        string.Format("{0:0.00}", procedure.price),
                        "0",
                        "0.00",
                        string.Format("{0:0.00}", procedure.price));
                    int index = dgvProcedures.Rows.GetLastRow(DataGridViewElementStates.None);
                    dgvProcedures.Rows[index].Cells["doctorsList"] = doctorsListCombobox;

                    this.resetProcedureInput();
                    this.calculateTotal();
                }
            }
        }
        
        private void cmbProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem item = cmbProcedures.SelectedItem as ComboBoxItem;
            this.findProcedure(Convert.ToInt32(item.Value), true);
        }
        
        private void txtProcedureCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }
        private void txtBillId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }
        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }

        private void txtProcedureCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.findProcedure(Convert.ToInt32(txtProcedureCode.Text));
            }
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.resetProcedureInput();
            }
        }

        private void dgvProcedures_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dgvProcedures.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dgvProcedures.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dgvProcedures.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void dgvProcedures_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var totalCell = dgvProcedures.Rows[e.RowIndex].Cells["Total"];

                var priceCell = dgvProcedures.Rows[e.RowIndex].Cells["Price"];
                double priceCellValue = Convert.ToDouble(priceCell.Value);

                var discountCell = dgvProcedures.Rows[e.RowIndex].Cells["Discount"];
                var discountCellValue = discountCell.Value.ToString();

                double discountValue = discountCellValue.Contains("%") ?
                    (priceCellValue * (Convert.ToDouble(discountCellValue.Substring(0, discountCellValue.IndexOf('%'))) / 100))
                    : Convert.ToDouble(discountCellValue);

                dgvProcedures.Rows[e.RowIndex].Cells["DiscountRate"].Value = string.Format("{0:0.00}", discountValue);

                totalCell.Value = string.Format("{0:0.00}", priceCellValue - discountValue);

                this.calculateTotal();
            }
            catch (Exception ex)
            {
                dgvProcedures.Rows[e.RowIndex].Cells["Discount"].Value = "0";
                MessageBox.Show("Invalid discount value.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPaidAmount_Click(object sender, EventArgs e)
        {
            txtPaidAmount.SelectAll();
        }

        private void txtPaidAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.save();
            }
        }

    }
}
