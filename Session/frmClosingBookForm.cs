
using ShifaClinic.Common;
using ShifaClinic.DataContext;
using ShifaClinic.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Session
{
    public partial class frmClosingBookForm : Form
    {

        Auth auth = new Auth();
        public frmClosingBookForm()
        {
            InitializeComponent();
        }
        private void bindDoctorCombobox()
        {

            using (var db = new clinicDbContext())
            {
                this.cmbDoctor.Items.Insert(0, new ComboBoxItem(0, "--Select Doctor--"));
                foreach (var _n in db.Doctors.ToList())
                {
                    var _item = new ComboBoxItem(_n.id, _n.name);
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
                var _doctors = db.Doctors.ToList();
                List<POCO.DoctorsClosingBook> _docotrsList = new List<DoctorsClosingBook>();
                foreach (var _d in _doctors)
                {

                }
            }

        }

        private void generateInvoice()
        {
            using (var db = new clinicDbContext())
            {
                var _comboboxitem = cmbDoctor.SelectedItem as ComboBoxItem;
                int id = int.Parse(_comboboxitem.Value.ToString());

                if (db.DoctorBookClosings.Where(a => a.docId == id &&
                a.paidAmmount == null).FirstOrDefault() == null)
                {

                    var docClosing = new DoctorBookClosing();
                    docClosing.docId = id;
                    docClosing.paidAmmount = int.Parse(txtAmountPaid.Text.ToString());
                    docClosing.balance = int.Parse(lblBalance.Text.ToString());
                    docClosing.total = int.Parse(lblTotal.Text.ToString());
                    docClosing.createdDate = DateTime.Now;
                    docClosing.createdBy = auth.currentUser;
                    db.DoctorBookClosings.Add(docClosing);
                    db.SaveChanges();
                    MessageBox.Show("Invoice generated", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDoctor.SelectedIndex = 0;
                    resetForm();
                }
            }
        }
        private void resetForm()
        {

            lblSharePercentage.Text = "0";
            lblTotal.Text = "0";
            lblDrFee.Text = "0";
            lblBalance.Text = "0";
            lblVisits.Text = "0";
            lblTotalIncome.Text = "0";
            lblAmount.Text = "0";
        }
        private void generateBook(int id)
        {
            using (var db = new clinicDbContext())
            {
                if (db.DoctorBookClosings.Where(p => p.docId == id &&
                         p.createdDate.Year == DateTime.Now.Year &&
                         p.createdDate.Month == DateTime.Now.Month &&
                         p.createdDate.Day == DateTime.Now.Day).FirstOrDefault() == null)
                {

                    var _billdetails = db.BillDetails
                        .Where(a => a.doctorId == id && !a.serviceId.HasValue &&
                                a.Bill.createDate.Year == DateTime.Now.Year &&
                                a.Bill.createDate.Month == DateTime.Now.Month &&
                                a.Bill.createDate.Day == DateTime.Now.Day)
                        .ToList();
                    int totalIncome = 0;
                    foreach (var item in _billdetails)
                    {
                        totalIncome += item.amount;
                    }
                    lblVisits.Text = _billdetails.Count.ToString();
                    lblTotalIncome.Text = totalIncome.ToString();

                    float share = float.Parse(lblSharePercentage.Text) / 100;
                    float total = float.Parse(totalIncome.ToString()) * share;
                    lblAmount.Text = total.ToString();
                    int _total = int.Parse(lblAmount.Text.ToString()) +
                        int.Parse(lblBalance.Text.ToString());
                    lblTotal.Text = _total.ToString();


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

        private void frmClosingBookForm_Load(object sender, EventArgs e)
        {
            bindDoctorCombobox();
            cmbDoctor.SelectedIndex = 0;
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var db = new clinicDbContext())
            {
                resetForm();
                var item = cmbDoctor.SelectedItem as ComboBoxItem;
                int _id = int.Parse(item.Value.ToString());
                if (_id > 0)
                {
                    lblDrFee.Text = db.Doctors.Where(a => a.id == _id).
                        FirstOrDefault().fees.Value.ToString();
                    lblSharePercentage.Text = db.Doctors.Where(r => r.id == _id).FirstOrDefault().sharePercentage.Value.ToString();
                    generateBook(_id);

                    var _amount = db.DoctorBookClosings.Where(p => p.docId == _id &&
                                p.createdDate.Year == DateTime.Now.Year &&
                                p.createdDate.Month == DateTime.Now.Month &&
                                p.createdDate.Day == DateTime.Now.Day)
                        .FirstOrDefault();

                    if (_amount != null)
                    {
                        lblPaid.Visible = true;
                        btnGenerateInvoice.Enabled = false;
                    }
                    else
                    {
                        lblPaid.Visible = false;
                        btnGenerateInvoice.Enabled = true;
                    }
                }
            }



        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            generateInvoice();
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmountPaid.Text))
            {
                var a = int.Parse(lblAmount.Text.ToString()) - int.Parse(txtAmountPaid.Text.ToString());
                lblBalance.Text = a.ToString();
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}

