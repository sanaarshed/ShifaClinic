using Microsoft.EntityFrameworkCore;
using ShifaClinic.Common;
using ShifaClinic.DataContext;
using ShifaClinic.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Patient
{
    public partial class frmCheckupAndPriscriptionForm : ShifaClinic.Common.BaseForm
    {
        private List<Medicine> cachedMedicineList;
        private System.ComponentModel.BackgroundWorker bgwCacheMedicineList = new BackgroundWorker();

        public frmCheckupAndPriscriptionForm()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            this.cachedMedicineList = new List<Medicine>();
        }
        private void InitializeBackgroundWorker()
        {
            bgwCacheMedicineList.DoWork += new DoWorkEventHandler(bgwCacheMedicineList_DoWork);
            bgwCacheMedicineList.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwCacheMedicineList_RunWorkerCompleted);
        }
        private void bgwCacheMedicineList_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            using (var db = new clinicDbContext())
            {
                Cursor.Current = Cursors.WaitCursor;
                var _list = db.Medicines.ToList();
                e.Result = _list;
            }
        }
        private void bgwCacheMedicineList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            this.cachedMedicineList = (List<Medicine>)e.Result;
            dgvMedicineList.DataSource = this.cachedMedicineList;
        }


        private void frmCheckupAndPriscriptionForm_Load(object sender, EventArgs e)
        {
            dgvMedicineList.Visible = false;
            dgvMedicineList.Top = txtMedicineName.Top + groupBox2.Top + 37;
            dgvMedicineList.Left = txtMedicineName.Left + groupBox2.Left;
            dgvMedicineList.Width = 774;
            dgvMedicineList.Height = 440;
            bgwCacheMedicineList.RunWorkerAsync();
        }

        private void txtMedicineName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down
                || e.KeyCode == Keys.Up
                || e.KeyCode == Keys.PageDown
                || e.KeyCode == Keys.PageUp)
            {
                dgvMedicineList.NavigateGridView(e.KeyCode);
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Enter)
            {
                txtMedicineName.Text = string.Empty;
                dgvMedicineList.Visible = false;
                rdoOnceADay.Focus();
            }
        }

        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {
            #region APIs Sample
            /*
            * This code is written to fetch medicine from External APIs
            if (listFound.Count <= 0)
            {
                //https://dawaai.pk/elasticsearch/curlES.php?q=gluco&f=true
                System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

                // Put the following code where you want to initialize the class
                // It can be the static constructor or a one-time initializer
                client.BaseAddress = new Uri("https://dawaai.pk/elasticsearch/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync(string.Format("curlES.php?q={0}&f=true", cmbMedicine.Text));
                var data = await response.Content.ReadAsAsync<DawaiResponseRootObject>();
                if (data.hits.hits.Count > 0)
                {
                    foreach (var item in data.hits.hits)
                    {
                        var i = item._source;
                        var id = long.Parse(i.id);
                        if (db.Medicines.Where(p => p.dawaiId == id).FirstOrDefault() != null)
                        { continue; }
                        var med = new Medicine();
                        med.dawaiId = id;
                        med.title = i.title;
                        med.mContent = string.IsNullOrEmpty(i.content) ? "" : i.content;
                        med.mType = string.IsNullOrEmpty(i.type) ? "": i.type;
                        med.price = double.Parse(string.IsNullOrEmpty(i.price) ? "0": i.price);
                        med.stripPerPack = int.Parse(string.IsNullOrEmpty(i.stripPerPack) ? "0" : i.stripPerPack);
                        med.alsoKnownAs = string.IsNullOrEmpty(i.alsoKnownAs) ? "" : i.alsoKnownAs;
                        med.brandName = string.IsNullOrEmpty(i.brandName) ? "" : i.brandName;
                        listFound.Add(med);
                    }
                    db.Medicines.AddRange(listFound);
                    await db.SaveChangesAsync();
                }
            }
            */
            #endregion

            Cursor.Current = Cursors.WaitCursor;
            var listFound = this.cachedMedicineList
                .Where(p => p.title.Contains(txtMedicineName.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                .ToList();

            //groupBox2.Text = string.Format("Medicine Detail - ({0})", listFound.Count);
            dgvMedicineList.DataSource = listFound;

            dgvMedicineList.Columns["title"].HeaderText = "Title"; // title
            dgvMedicineList.Columns["title"].FillWeight = 35; // title

            dgvMedicineList.Columns["stripPerPack"].HeaderText = "Per Pack"; // stripPerPack
            dgvMedicineList.Columns["stripPerPack"].FillWeight = 10; // stripPerPack

            dgvMedicineList.Columns["mType"].HeaderText = "Type"; // type
            dgvMedicineList.Columns["mType"].FillWeight = 10; // type

            dgvMedicineList.Columns["mContent"].HeaderText = "Content"; // content
            dgvMedicineList.Columns["mContent"].FillWeight = 10; // content

            dgvMedicineList.Columns["alsoKnownAs"].HeaderText = "AKA"; // alsoKnownAs
            dgvMedicineList.Columns["alsoKnownAs"].FillWeight = 10; // alsoKnownAs


            dgvMedicineList.Columns["brandName"].HeaderText = "Brand Name"; // brandName
            dgvMedicineList.Columns["brandName"].FillWeight = 15; // brandName

            dgvMedicineList.Columns["id"].HeaderText = "#"; // id
            dgvMedicineList.Columns["id"].Width = 0; // id

            dgvMedicineList.Columns["dawaiId"].Visible = false; // dawaiId
            dgvMedicineList.Columns["price"].Visible = false; // brandName

            dgvMedicineList.ScrollBars = ScrollBars.Both;
            dgvMedicineList.AllowUserToResizeRows = false;


            if (!dgvMedicineList.Visible)
                dgvMedicineList.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void rdoOnceADay_Enter(object sender, EventArgs e)
        {
            rdoOnceADay.BackColor = Color.LemonChiffon;
        }

        private void rdoOnceADay_Leave(object sender, EventArgs e)
        {
            rdoOnceADay.BackColor = Color.Transparent;
        }

        private void rdoMorningEvening_Enter(object sender, EventArgs e)
        {
            rdoMorningEvening.BackColor = Color.LemonChiffon;
        }

        private void rdoMorningEvening_Leave(object sender, EventArgs e)
        {
            rdoMorningEvening.BackColor = Color.Transparent;
        }

        private void rdoMorningANEvening_Enter(object sender, EventArgs e)
        {
            rdoMorningANEvening.BackColor = Color.LemonChiffon;
        }

        private void rdoMorningANEvening_Leave(object sender, EventArgs e)
        {
            rdoMorningANEvening.BackColor = Color.Transparent;
        }

        private void rdoMorningFasting_Enter(object sender, EventArgs e)
        {
            rdoMorningFasting.BackColor = Color.LemonChiffon;
        }

        private void rdoMorningFasting_Leave(object sender, EventArgs e)
        {
            rdoMorningFasting.BackColor = Color.Transparent;
        }

        private void rdoBeforeMeal_Enter(object sender, EventArgs e)
        {
            rdoBeforeMeal.BackColor = Color.LemonChiffon;
        }

        private void rdoBeforeMeal_Leave(object sender, EventArgs e)
        {
            rdoBeforeMeal.BackColor = Color.Transparent;
        }

        private void rdoAfterMeal_Enter(object sender, EventArgs e)
        {
            rdoAfterMeal.BackColor = Color.LemonChiffon;
        }

        private void rdoAfterMeal_Leave(object sender, EventArgs e)
        {
            rdoAfterMeal.BackColor = Color.Transparent;
        }

        private void rdoBeforeSleep_Enter(object sender, EventArgs e)
        {
            rdoBeforeSleep.BackColor = Color.LemonChiffon;
        }

        private void rdoBeforeSleep_Leave(object sender, EventArgs e)
        {
            rdoBeforeSleep.BackColor = Color.Transparent;
        }
    }
}
