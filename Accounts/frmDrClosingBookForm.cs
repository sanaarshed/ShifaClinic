
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

        private void bindDoctorCombobox()
        {
            using (var db = new clinicDbContext())
            {
                this.cmbDoctor.Items.Insert(0, new ComboBoxItem(0, "--Select Doctor--"));
                foreach (var _n in db.Doctors.ToList())
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
                var _doctors = db.DoctorBookClosings
                    .Where(p => DbFunctions.TruncateTime(p.createdDate) == DbFunctions.TruncateTime(DateTime.Now))
                    .ToList();

                List<POCO.DoctorsClosingBook> _doctorsList = new
                List<POCO.DoctorsClosingBook>();
                foreach (var _d in _doctors)
                {
                    var _i = new POCO.DoctorsClosingBook();
                    _i.doctorName = _d.Doctor.name;
                    _i.totalAmount = _d.total.Value;
                    _i.paidAmount = _d.paidAmmount.Value;

                    _doctorsList.Add(_i);
                }
                dgvDoctors.DataSource = _doctorsList;
            }
        }

        private void generateInvoice()
        {
            using (var db = new clinicDbContext())
            {
                var _comboboxitem = cmbDoctor.SelectedItem as ComboBoxItem;
                int id = Convert.ToInt32(_comboboxitem.Value);

                if (db.DoctorBookClosings
                    .Where(a => a.docId == id && a.paidAmmount == null).FirstOrDefault() == null)
                {

                    var docClosing = new DoctorBookClosing();
                    docClosing.docId = id;
                    docClosing.paidAmmount = Convert.ToInt32(txtAmountPaid.Text);
                    docClosing.balance = Convert.ToInt32(lblBalance.Text);
                    //docClosing.total = Convert.ToInt32(lblTotal.Text);
                    docClosing.createdDate = DateTime.Now;
                    docClosing.createdBy = auth.currentUser.id;
                    db.DoctorBookClosings.Add(docClosing);
                    db.SaveChanges();
                    MessageBox.Show("Invoice generated successfully...",
                        "SUCCESSFUL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.resetForm();
                }
            }
        }
        private void prepareAndPrintInvoice()
        {
            List<string> _services = new List<string>();
            using (var db = new clinicDbContext())
            {
                var reportSource = new ShifaClinic.Reports.Poco.dsDailyDoctorBookClose();
                reportSource.RecieverFullname = cmbDoctor.Text.Trim();
                reportSource.RecievedAmount = Convert.ToDouble(txtAmountPaid.Text.Trim());
                //reportSource.ConsultancyPercentage = lblSharePercentage.Text.Trim();
                //reportSource.ConsultancyTotalVisits = lblVisits.Text;
                //reportSource.ConsultancyIncome = lblTotalIncome.Text;
                reportSource.MiscellaneousIncome = "0";
                reportSource.MiscellaneousPercentage = "0";
                reportSource.CreatedByFullname = auth.currentUser.ToString();
                reportSource.CreatedDate = DateTime.Now;

                this.printReciept(reportSource);
            }
        }
        private void printReciept(ShifaClinic.Reports.Poco.dsDailyDoctorBookClose reportSource)
        {
            string reportName = "voucher_DailyDoctorBookClose.rdlc";
            var dtValue = new DataTable();
            dtValue = Utility.MapToDataTable<Reports.Poco.dsDailyDoctorBookClose>(reportSource);

            string p = Path.GetDirectoryName(Application.ExecutablePath);
            string path = p.Remove(p.Length - 10) + "\\Patient\\reports\\" + reportName;
            LocalReport report = new LocalReport();
            report.ReportPath = path;

            ReportDataSource ds = new ReportDataSource();
            ds.Name = "dsDailyDoctorBookClose";
            ds.Value = dtValue;
            report.DataSources.Add(ds);

            //report.PrintToPrinter();
            var print = new ReportPrint();
            print.PrintToPrinter(report);
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
        private void generateBook(int id)
        {
            using (var db = new clinicDbContext())
            {
                if (db.DoctorBookClosings.Where(p => p.docId == id && 
                DbFunctions.TruncateTime(p.createdDate)== DbFunctions.TruncateTime(DateTime.Now)
                ).FirstOrDefault() == null)
                {

                    var _billdetails = db.BillDetails
                        .Where(a => a.doctorId == id &&
                                DbFunctions.TruncateTime(a.Bill.createDate)== DbFunctions.TruncateTime(DateTime.Now)
                )
                        .ToList();
                    double totalIncome = 0;
                    //foreach (var item in _billdetails)
                    //{
                    //    totalIncome += item.amount;
                    //}
                    //lblVisits.Text = _billdetails.Count.ToString();
                    //lblTotalIncome.Text = totalIncome.ToString();

                    //double share = Convert.ToDouble(lblSharePercentage.Text) / 100;
                    //double total = totalIncome * share;
                    //double balance = Convert.ToDouble(lblBalance.Text);
                    //lblAmount.Text = total.ToString();
                    //double _total = total + balance;
                    //lblTotal.Text = _total.ToString();


                    /*
                    Dr. Fees: 2000
                    Total Visit: 12
                    Total Income: 12000 (fees * visit)
                    Dr. Percentage: 40%
                    Balance: 300
                    Amount: 4800 (totalIncome * share)
                    Total: 5100 (Amount + balance)
                    ------------------------
                    Amount Paid to Dr: 5,100
                    ------------------------    
                    */

                }

            }


        }

        public frmDrClosingBookForm()
        {
            InitializeComponent();
        }
        private void frmClosingBookForm_Load(object sender, EventArgs e)
        {
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
            using (var db = new clinicDbContext())
            {
                //resetForm();
                //generateBook(_id);

                var item = cmbDoctor.SelectedItem as ComboBoxItem;
                int doctorId = Convert.ToInt32(item.Value);
                if (doctorId > 0)
                {
                    // calculate seprate for consultancy fee
                    // lblSharePercentage.Text = db.Doctors.Where(r => r.id == _id).FirstOrDefault().sharePercentage.Value.ToString();

                    var doctorBookClosing = db.DoctorBookClosings
                        .Where(p => p.docId == doctorId &&
                                p.createdDate.Year == DateTime.Now.Year &&
                                p.createdDate.Month == DateTime.Now.Month &&
                                p.createdDate.Day == DateTime.Now.Day)
                          .FirstOrDefault();

                    if (doctorBookClosing is null)
                    {
                        // Book not yet closed for this doctor.
                        var billDetails = db.BillDetails.Where(p => p.doctorId == doctorId &&
                                p.Bill.createDate.Year == DateTime.Now.Year &&
                                p.Bill.createDate.Month == DateTime.Now.Month &&
                                p.Bill.createDate.Day == DateTime.Now.Day);

                        var procedureBillDetails = db.BillProcedureDetails.Where(p => p.doctorId == doctorId &&
                                p.BillProcedure.createDate.Year == DateTime.Now.Year &&
                                p.BillProcedure.createDate.Month == DateTime.Now.Month &&
                                p.BillProcedure.createDate.Day == DateTime.Now.Day);

                        txtAmountPaid.Enabled = true;
                        btnSubmit.Enabled = true;
                    }
                    else
                    {
                        txtAmountPaid.Enabled = false;
                        btnSubmit.Enabled = false;
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
            if (e.KeyCode == Keys.Enter)
            {
                //validate if the field is not empty 
                generateInvoice();

            }
        }

        private void dgvDoctors_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvDoctors.Rows)
            {
                if (int.Parse(dgvr.Cells[1].Value.ToString()) > 0)
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.generateInvoice();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.bindDoctorsList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.resetForm();
        }
    }
}