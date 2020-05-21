
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Reporting.WinForms;
using ShifaClinic.Common;
using ShifaClinic.DataContext;
using ShifaClinic.POCO;
using ShifaClinic.Session;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Dynamic;
using System.IdentityModel.Protocols.WSTrust;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Accounts
{
    public partial class frmDrClosingBookForm : BaseForm
    {
        Auth auth = new Auth();
        private enum Services
        {
            OPDVISIT = 1,
            CONSULTANTVISIT = 2,
            OTHERS
        }
        public bool validateForm(bool DisplayMessageBox = false)
        {
            bool _result = false;
            List<string> errorLog = new List<string>();
            if (string.IsNullOrEmpty(txtAmountPaid.Text))
            {
                errorLog.Add("Please enter paid amount");
                txtAmountPaid.BorderColor = Color.Red;
                _result = true;
            }
            else
            {
                txtAmountPaid.BorderColor = Color.Blue;
                errorLog.Remove("Please enter paid amount");
            }
            var total = lblTotal.Text.Split(new[] { '.' });

            if (txtAmountPaid.Text != total[0])
            {
                errorLog.Add("Paid Amount must be equal to Total Amount");
                _result = true;
            }
            else
            {
                errorLog.Remove("Paid Amount must be equal to Total Amount");
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

        private void calculateTotal()
        {
            double sumTotal = 0;
            foreach (DataGridViewRow row in dgvFinancialDetails.Rows)
            {
                sumTotal += Convert.ToDouble(row.Cells["total"].Value);
            }
            lblTotal.Text = string.Format("{0:0.00}", sumTotal);
        }
        private void generateInvoice()
        {
            using (var db = new clinicDbContext())
            {
                var _comboboxitem = cmbDoctor.SelectedItem as ComboBoxItem;
                int id = Convert.ToInt32(_comboboxitem.Value);
                if (db.DoctorBookClosings.Where(a => a.doctorId == id && a.paidAmount == null).FirstOrDefault() == null)
                {
                    var docClosing = new DoctorBookClosing();
                    docClosing.doctorId = id;
                    docClosing.paidAmount = Convert.ToDouble(txtAmountPaid.Text);
                    docClosing.balance = Convert.ToInt32(lblBalance.Text);
                    docClosing.total = Convert.ToDouble(lblTotal.Text);
                    docClosing.createDate = DateTime.Now;
                    docClosing.createdBy = auth.currentUser.id;
                    db.DoctorBookClosings.Add(docClosing);
                    db.SaveChanges();
                    foreach (DataGridViewRow row in dgvFinancialDetails.Rows)
                    {
                        DoctorBookClosingDetail bookclosingDetail = new DoctorBookClosingDetail();
                        bookclosingDetail.drBookClosingId = docClosing.id;
                        
                        bookclosingDetail.serviceId = Convert.ToInt32(row.Cells["ServiceId"].Value);
                        bookclosingDetail.sharePercentage = Convert.ToDouble(row.Cells["Percentage"].Value);
                        bookclosingDetail.totalPrice = Convert.ToDouble(row.Cells["Total"].Value);
                        bookclosingDetail.visits = Convert.ToInt32(row.Cells["VisitCounts"].Value);
                        bookclosingDetail.procedureId = Convert.ToInt32(row.Cells["procedureId"].Value);
                        db.DoctorBookClosingDetails.Add(bookclosingDetail);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Invoice generated successfully...",
                        "SUCCESSFUL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    if (MessageBox.Show("Do you want to generate voucher for this bookClosing?",
                         "QUESTION",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        printReciept(false);
                    }
                    this.bindDoctorsPaidList();
                    this.resetForm();
                }
            }
        }
        private void printReciept(bool isCopy)
        {
            using (var db = new clinicDbContext())
            {
                //Doctor Book Closing
                var dsDrBookClosing = new Reports.Poco.dsDailyDoctorBookClose();
                dsDrBookClosing.RecieverFullname = hdnDoctorName.Text;
                dsDrBookClosing.RecievedAmount = string.Format("{0:0.00}", txtAmountPaid.Text);
                dsDrBookClosing.CreatedDate = string.Format("{0:dd-MMM-yyy}", DateTime.Now);
                dsDrBookClosing.CreatedByFullname = auth.currentUser.fullName;

                //Doctor Book Closing Details
                List<ShifaClinic.Reports.Poco.dsDrBookCloseDetails> dsDrBookClosingDetails =
                    new List<Reports.Poco.dsDrBookCloseDetails>();
                foreach (DataGridViewRow row in dgvFinancialDetails.Rows)
                {
                    var bookCloseDetail = new Reports.Poco.dsDrBookCloseDetails();
                    bookCloseDetail.title = row.Cells["type"].Value.ToString();
                    bookCloseDetail.visits = row.Cells["VisitCounts"].Value.ToString();
                    bookCloseDetail.price = string.Format("{0:0.00}", row.Cells["total"].Value);
                    dsDrBookClosingDetails.Add(bookCloseDetail);
                }


                var dtDrBookClose = Common.Utility.MapToDataTable<Reports.Poco.dsDailyDoctorBookClose>(dsDrBookClosing);
                dtDrBookClose.TableName = "dsDailyDoctorBookClose";

                var dtDrBookCloseDetails = dsDrBookClosingDetails.ToDataTable();
                dtDrBookCloseDetails.TableName = "dsDrBookCloseDetails";

                List<DataTable> dataSources = new List<DataTable>();
                dataSources.Add(dtDrBookClose);
                dataSources.Add(dtDrBookCloseDetails);


                Common.ReportPrint reportPrint = new Common.ReportPrint();
                ReportParameter rp = new ReportParameter();
                if (isCopy)
                {
                    List<ReportParameter> listRP = new List<ReportParameter>();
                    listRP.Add(new ReportParameter("isCopy", "(COPY)"));
                    reportPrint.ReportParameters = listRP;
                }
                reportPrint.Print(dataSources, "voucher_DailyDoctorBookClose.rdlc", "Accounts");
            }
        }

        private void resetForm()
        {
            cmbDoctor.SelectedIndex = 0;
            lblTotal.Text = "0";
            txtAmountPaid.Text = "0";
            dgvFinancialDetails.Rows.Clear();
            lblDrId.Text = "0";
        }

        private void bindDoctorCombobox()
        {
            using (var db = new clinicDbContext())
            {
                this.cmbDoctor.Items.Insert(0, new ComboBoxItem(0, "--Select Doctor--"));

                var drDialyBookClose = db.DoctorBookClosings.Where(p => DbFunctions.TruncateTime(p.createDate)
                == DbFunctions.TruncateTime(DateTime.Now))
                    .Select(a => a.doctorId).ToList();
                var doctors = db.Doctors.ToList();
                foreach (var dr in doctors)
                {
                    if (!drDialyBookClose.Contains(dr.id))
                    {
                        var name = string.Format("{0} ({1})", dr.name.Trim(), dr.DoctorDepartment.title.Trim());
                        var _item = new ComboBoxItem(dr.id, name);
                        cmbDoctor.Items.Add(_item);
                    }
                }
                cmbDoctor.DisplayMember = "Text";
                cmbDoctor.ValueMember = "Value";
            }
        }
        private void bindDoctorsPaidList()
        {
            dgvDoctorsPaid.Rows.Clear();
            using (var db = new clinicDbContext())
            {
                var doctorsPaid = db.DoctorBookClosings
                    .Where(p => DbFunctions.TruncateTime(p.createDate) == DbFunctions.TruncateTime(DateTime.Now))
                    .ToList();

                List<POCO.DoctorsClosingBook> drBookClosingList = new
                List<POCO.DoctorsClosingBook>();
                foreach (var _d in doctorsPaid)
                {
                    dgvDoctorsPaid.Rows.Add(_d.id,
                        _d.Doctor.name,
                        _d.paidAmount,
                        _d.total
                        );
                }
            }
        }

        /**********************************************/
        public frmDrClosingBookForm()
        {
            InitializeComponent();
        }
        private void frmClosingBookForm_Load(object sender, EventArgs e)
        {
            lblTodaysDate.Text = DateTime.Now.ToShortDateString();
            dgvFinancialDetails.Columns["Percentage"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFinancialDetails.Columns["Percentage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvFinancialDetails.Columns["VisitCounts"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFinancialDetails.Columns["VisitCounts"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvFinancialDetails.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFinancialDetails.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // TODO: This line of code loads data into the 'clinicDbDataSet.Users' table. You can move, or remove it, as needed.
            bindDoctorsPaidList();
            bindDoctorCombobox();
            cmbDoctor.SelectedIndex = 0;
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            gbDetails.Enabled = true;
            btnSubmit.Enabled = true;
            lblTotal.Text = "0.00";
            txtAmountPaid.Text = "0";

            using (var db = new clinicDbContext())
            {
                dgvFinancialDetails.Rows.Clear();
                var item = cmbDoctor.SelectedItem as ComboBoxItem;
                int doctorId = Convert.ToInt32(item.Value);
                lblDrId.Text = doctorId.ToString();

                if (doctorId > 0)
                {
                    //check if dr book is already closed or not 
                    var doctorBookClosing = db.DoctorBookClosings
                        .Where(p => p.doctorId == doctorId &&
                                DbFunctions.TruncateTime(p.createDate) == DbFunctions.TruncateTime(DateTime.Now))
                          .FirstOrDefault();
                    if (doctorBookClosing is null)
                    {
                        // Book not yet closed for this doctor.
                        var docRecord = db.Doctors.Where(a => a.id == doctorId).FirstOrDefault();
                        var docShareConfig = db.DoctorShareConfigurations
                            .Include(p => p.Service)
                            .Include(p => p.Doctor)
                            .Include(p => p.Procedure)
                            .Where(a => a.doctorId == doctorId).ToList();
                        double sum = 0.0;
                        int visits = 0;
                        var title = "";
                        foreach (var share in docShareConfig)
                        {
                            if (share.serviceId.HasValue)
                            {
                                var billDetails = db.BillDetails
                                    .Where(p =>
                                        p.doctorId == doctorId &&
                                        p.serviceId == share.serviceId &&
                                        p.isReturnFiled == false &&
                                        DbFunctions.TruncateTime(p.Bill.createDate) == DbFunctions.TruncateTime(DateTime.Now))
                                    .ToList();
                                sum = billDetails.Sum(p => p.amount);
                                visits = billDetails.Count;
                                title = share.Service.title;
                            }
                            else if (share.procedureId.HasValue)
                            {
                                var billDetails = db.BillProcedureDetails
                                    .Where(p =>
                                        p.procedureId == share.procedureId &&
                                        p.doctorId == share.doctorId &&
                                        p.isReturnFiled == false &&
                                        DbFunctions.TruncateTime(p.BillProcedure.createDate) == DbFunctions.TruncateTime(DateTime.Now))
                                    .ToList();
                                sum = billDetails.Sum(p => p.amount);
                                visits = billDetails.Count;
                                title = share.Procedure.title;
                            }

                            int rowIndex = dgvFinancialDetails.Rows.Add(
                                    title,
                                    visits,
                                    string.Format("{0:0.00}", sum * (share.percentage * 0.01)),
                                    share.percentage
                                );

                            if (share.serviceId.HasValue)
                            {
                                dgvFinancialDetails.Rows[rowIndex].Cells["serviceId"].Value = share.serviceId;
                            }
                            else if (share.procedureId.HasValue)
                            {
                                dgvFinancialDetails.Rows[rowIndex].Cells["procedureId"].Value = share.procedureId;
                            }
                        }
                        calculateTotal();
                    }
                }
            }
        }

        private void dgvDoctors_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDoctorsPaid.Rows)
            {
                if (Convert.ToInt32(row.Cells["DoctorId"].Value.ToString()) > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyAllowNumericValue(sender, e);
        }
        private void txtAmountPaid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !this.validateForm(true))
            {
                generateInvoice();
            }
        }
        private void cmbDoctor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAmountPaid.Focus();
            }
        }

        private void dgvDoctorsPaid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvFinancialDetails.Rows.Clear();
            using (var db = new clinicDbContext())
            {
                if (dgvDoctorsPaid.Rows[e.RowIndex].Cells["Id"].Value != null)
                {
                    int drBookClosingId = Convert.ToInt32(dgvDoctorsPaid.Rows[e.RowIndex].Cells["Id"].Value);
                    hdnDoctorName.Text = dgvDoctorsPaid.Rows[e.RowIndex].Cells["DoctorName"].Value.ToString();
                    lblTotal.Text = string.Format("{0:0.00}", dgvDoctorsPaid.Rows[e.RowIndex].Cells["totalAmount"].Value);
                    txtAmountPaid.Text = string.Format("{0:0.00}", dgvDoctorsPaid.Rows[e.RowIndex].Cells["paidAmount"].Value);

                    foreach (var _d in db.DoctorBookClosingDetails
                        .Include("Service")
                        .Where(p => p.drBookClosingId == drBookClosingId)
                        .ToList())
                    {
                        dgvFinancialDetails.Rows.Add(
                                        _d.Service.title,
                                        _d.visits,
                                        string.Format("{0:0.00}", _d.totalPrice));
                    }
                }
            }

            btnPrint.Enabled = true;
            gbDetails.Enabled = false;
            btnSubmit.Enabled = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!this.validateForm(true))
                this.generateInvoice();
            this.bindDoctorCombobox();
        }
        private void txtAmountPaid_Click(object sender, EventArgs e)
        {
            txtAmountPaid.SelectAll();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.resetForm();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printReciept(true);
        }
    }
}