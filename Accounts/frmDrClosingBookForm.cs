
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Reporting.WinForms;
using ShifaClinic.Common;
using ShifaClinic.DataContext;
using ShifaClinic.POCO;
using ShifaClinic.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Dynamic;
using System.IdentityModel.Protocols.WSTrust;
using System.IO;
using System.Linq;
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
        private void applyToAll(Control groupBox)
        {
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
            ctrl.BackColor = Color.Beige;
            ctrl.SelectAll();
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
                if (db.DoctorBookClosings.Where(a => a.docId == id && a.paidAmount == null).FirstOrDefault() == null)
                {
                    var docClosing = new DoctorBookClosing();
                    docClosing.docId = id;
                    docClosing.paidAmount = Convert.ToDouble(txtAmountPaid.Text);
                    docClosing.balance = Convert.ToInt32(lblBalance.Text);
                    docClosing.total = Convert.ToDouble(lblTotal.Text);
                    docClosing.createDate = DateTime.Now;
                    docClosing.createdBy = auth.currentUser.id;
                    db.DoctorBookClosings.Add(docClosing);
                    db.SaveChanges();
                    MessageBox.Show("Invoice generated successfully...",
                        "SUCCESSFUL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    if (MessageBox.Show("Do you want to generate voucher for this bookClosing?",
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
        private void printReciept()
        {
            foreach (DataGridViewRow row in dgvFinancialDetails.Rows)
            {
                MessageBox.Show(row.Cells["title"].Value.ToString());
            }
            List<string> _services = new List<string>();
            var reportSource = new ShifaClinic.Reports.Poco.dsDailyDoctorBookClose()
            {
                RecieverFullname = cmbDoctor.Text.Trim(),
                RecievedAmount = Convert.ToDouble(txtAmountPaid.Text.Trim()),
                ConsultancyTotalVisits = "",
                ConsultancyIncome = "",
                MiscellaneousIncome = "0",
                MiscellaneousPercentage = "0",
                CreatedByFullname = auth.currentUser.ToString(),
                CreatedDate = DateTime.Now
            };
            var dtDrBookClose = Common.Utility.MapToDataTable<Reports.Poco.dsDailyDoctorBookClose>(reportSource);
            Common.ReportPrint report = new Common.ReportPrint();
            report.Print(dtDrBookClose, "dsReturnOPD", "voucher_ReturnOPD2.rdlc", "Accounts");


            //    string reportName = "voucher_DailyDoctorBookClose.rdlc";
            //    var dtValue = new DataTable();
            //    dtValue = Utility.MapToDataTable<Reports.Poco.dsDailyDoctorBookClose>(reportSource);

            //    string p = Path.GetDirectoryName(Application.ExecutablePath);
            //    string path = p.Remove(p.Length - 10) + "\\Patient\\reports\\" + reportName;
            //    LocalReport report = new LocalReport();
            //    report.ReportPath = path;

            //    ReportDataSource ds = new ReportDataSource();
            //    ds.Name = "dsDailyDoctorBookClose";
            //    ds.Value = dtValue;
            //    report.DataSources.Add(ds);

            //    //report.PrintToPrinter();
            //    var print = new ReportPrint();
            //    print.PrintToPrinter(report);
        }
        private void resetForm()
        {
            cmbDoctor.SelectedIndex = 0;
            txtAmountPaid.Text = "0";
            //lblSharePercentage.Text = "0";
            //lblTotal.Text = "0";
            //lblDrFee.Text = "0";
            //lblBalance.Text = "0";
            //lblVisits.Text = "0";
            //lblTotalIncome.Text = "0";
            //lblAmount.Text = "0";
        }

        private void bindDoctorCombobox()
        {
            using (var db = new clinicDbContext())
            {
                this.cmbDoctor.Items.Insert(0, new ComboBoxItem(0, "--Select Doctor--"));
                var doctors = db.Doctors.ToList();
                var drDialyBookClose = db.DoctorBookClosings.Where(p=> p.createDate == DateTime.Now).ToList() ;
                //doctors.j
                foreach (var _n in doctors)
                {
                    var name = string.Format("{0} ({1})", _n.name.Trim(), _n.DoctorDepartment.title.Trim());
                    var _item = new ComboBoxItem(_n.id, name);
                    cmbDoctor.Items.Add(_item);
                }
                cmbDoctor.DisplayMember = "Text";
                cmbDoctor.ValueMember = "Value";
            }
        }
        private void bindDoctorsList()
        {
            using (var db = new clinicDbContext())
            {
                var doctorsPaid = db.DoctorBookClosings
                    .Where(p => DbFunctions.TruncateTime(p.createDate) == DbFunctions.TruncateTime(DateTime.Now))
                    .ToList();

                List<POCO.DoctorsClosingBook> _doctorsList = new
                List<POCO.DoctorsClosingBook>();
                foreach (var _d in doctorsPaid)
                {
                    var _i = new POCO.DoctorsClosingBook();
                    _i.doctorName = _d.Doctor.name;
                    _i.totalAmount = _d.total.Value;
                    _i.paidAmount = _d.paidAmount.Value;

                    _doctorsList.Add(_i);
                }
                dgvDoctorsPaid.DataSource = _doctorsList;


                var doctorsNotPaid = db.BillDetails
                    .Where(p =>
                    DbFunctions.TruncateTime(p.Bill.createDate) == DbFunctions.TruncateTime(DateTime.Now))
                    .ToList();

                List<string> drNames = new
                List<string>();
                foreach (var _d in doctorsNotPaid)
                {
                    var doctorName = "";
                    if (doctorsPaid.Where(p => p.docId == _d.doctorId).FirstOrDefault() == null)
                    {
                        if (drNames.Contains(_d.Doctor.name) == false)
                            doctorName = _d.Doctor.name;
                        drNames.Add(doctorName);
                    }
                }
                dgvDoctorsNotPaid.DataSource = drNames.Select(x => new { Value = x }).ToList();
            }
        }

        public frmDrClosingBookForm()
        {
            InitializeComponent();
        }
        private void frmClosingBookForm_Load(object sender, EventArgs e)
        {
            lblTodaysDate.Text = DateTime.Now.ToString();
            this.applyToAll(this);

            dgvFinancialDetails.Columns["Fees"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFinancialDetails.Columns["Fees"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvFinancialDetails.Columns["Percentage"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFinancialDetails.Columns["Percentage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvFinancialDetails.Columns["VisitCounts"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFinancialDetails.Columns["VisitCounts"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvFinancialDetails.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFinancialDetails.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // TODO: This line of code loads data into the 'clinicDbDataSet.Users' table. You can move, or remove it, as needed.
            bindDoctorsList();
            bindDoctorCombobox();
            cmbDoctor.SelectedIndex = 0;
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotal.Text = "0.00";
            using (var db = new clinicDbContext())
            {
                dgvFinancialDetails.Rows.Clear();
                var item = cmbDoctor.SelectedItem as ComboBoxItem;
                int doctorId = Convert.ToInt32(item.Value);
                if (doctorId > 0)
                {
                    //check if dr book is already closed or not 
                    var doctorBookClosing = db.DoctorBookClosings
                        .Where(p => p.docId == doctorId &&
                                DbFunctions.TruncateTime(p.createDate) == DbFunctions.TruncateTime(DateTime.Now))
                          .FirstOrDefault();
                    if (doctorBookClosing is null)
                    {
                        // Book not yet closed for this doctor.
                        var docRecord = db.Doctors.Where(a => a.id == doctorId).FirstOrDefault();
                        var docShareConfig = db.DoctorShareConfigurations
                            .Include("Service")
                            .Include("Doctor")
                            .Where(a => a.doctorId == doctorId).ToList();
                        foreach (var share in docShareConfig)
                        {
                            // Doctor ID - Service ID ///Procedure ID
                            if (share.serviceId.HasValue)
                            {
                                var billDetails = db.BillDetails.Where(p =>
                                        p.doctorId == doctorId &&
                                        p.serviceId == share.serviceId &&
                                        p.isReturnFiled == false &&
                                        DbFunctions.TruncateTime(p.Bill.createDate) == DbFunctions.TruncateTime(DateTime.Now))
                                    .ToList();

                                double sum = billDetails.Sum(p => p.amount);
                                dgvFinancialDetails.Rows.Add(
                                    share.Service.title.Trim(),
                                    billDetails.Count,
                                    string.Format("{0:0.00}", sum * (share.percentage * 0.01))
                                );
                            }
                            calculateTotal();
                        }
                        return;
                    }
                }
            }
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmountPaid.Text))
            {
                //var a = int.Parse(lblAmount.Text.ToString()) - int.Parse(txtAmountPaid.Text.ToString());
                //lblBalance.Text = a.ToString();
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

        private void dgvDoctors_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDoctorsPaid.Rows)
            {
                if (int.Parse(row.Cells[1].Value.ToString()) > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LimeGreen;
                }
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!this.validateForm(true))
                this.generateInvoice();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.resetForm();
        }
       
    }
}