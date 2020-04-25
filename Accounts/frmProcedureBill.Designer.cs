namespace ShifaClinic.Accounts
{
    partial class frmProcedureBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtProcedureCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.PROCEDURE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProcedures = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProcedures = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsList = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.gbProcedure = new System.Windows.Forms.GroupBox();
            this.txtPaidAmount = new ShifaClinic.Common.CustomTextBox();
            this.lblPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbPatientDetail = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPatientMobileNumber = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtBloodPressureLower = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.rbPrivate = new System.Windows.Forms.RadioButton();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBloodPressureUpper = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedures)).BeginInit();
            this.gbProcedure.SuspendLayout();
            this.gbPatientDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProcedureCode
            // 
            this.txtProcedureCode.Location = new System.Drawing.Point(166, 33);
            this.txtProcedureCode.Name = "txtProcedureCode";
            this.txtProcedureCode.Size = new System.Drawing.Size(100, 30);
            this.txtProcedureCode.TabIndex = 0;
            this.txtProcedureCode.Text = "0";
            this.txtProcedureCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProcedureCode_KeyDown);
            this.txtProcedureCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcedureCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "MR #: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 684);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 43);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(454, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(442, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(4, 5);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(442, 33);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(904, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(442, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PROCEDURE
            // 
            this.PROCEDURE.BackColor = System.Drawing.Color.RoyalBlue;
            this.PROCEDURE.Dock = System.Windows.Forms.DockStyle.Top;
            this.PROCEDURE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROCEDURE.ForeColor = System.Drawing.Color.White;
            this.PROCEDURE.Location = new System.Drawing.Point(0, 0);
            this.PROCEDURE.Name = "PROCEDURE";
            this.PROCEDURE.Padding = new System.Windows.Forms.Padding(1);
            this.PROCEDURE.Size = new System.Drawing.Size(1350, 40);
            this.PROCEDURE.TabIndex = 50;
            this.PROCEDURE.Text = "PROCEDURE";
            this.PROCEDURE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Procedure Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 23);
            this.label4.TabIndex = 54;
            this.label4.Text = "/";
            // 
            // cmbProcedures
            // 
            this.cmbProcedures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcedures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProcedures.FormattingEnabled = true;
            this.cmbProcedures.Location = new System.Drawing.Point(293, 33);
            this.cmbProcedures.Name = "cmbProcedures";
            this.cmbProcedures.Size = new System.Drawing.Size(410, 31);
            this.cmbProcedures.TabIndex = 1;
            this.cmbProcedures.SelectedIndexChanged += new System.EventHandler(this.cmbProcedures_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(963, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 61;
            this.label7.Text = "Bill ID:";
            // 
            // txtBillId
            // 
            this.txtBillId.Location = new System.Drawing.Point(1024, 67);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(137, 30);
            this.txtBillId.TabIndex = 1;
            this.txtBillId.Text = "0";
            this.txtBillId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillId_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(628, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 25);
            this.label12.TabIndex = 69;
            this.label12.Text = "Gross Total:   Rs.";
            this.label12.Click += new System.EventHandler(this.txtPaidAmount_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(830, 419);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(51, 30);
            this.lblGrandTotal.TabIndex = 68;
            this.lblGrandTotal.Text = "0.00";
            this.lblGrandTotal.TextChanged += new System.EventHandler(this.lblGrandTotal_TextChanged);
            this.lblGrandTotal.Click += new System.EventHandler(this.txtPaidAmount_Click);
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.AutoSize = true;
            this.lblTotalDiscount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiscount.Location = new System.Drawing.Point(830, 453);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(51, 30);
            this.lblTotalDiscount.TabIndex = 70;
            this.lblTotalDiscount.Text = "0.00";
            this.lblTotalDiscount.Click += new System.EventHandler(this.txtPaidAmount_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(601, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 25);
            this.label10.TabIndex = 71;
            this.label10.Text = "Total Discount:   Rs.";
            this.label10.Click += new System.EventHandler(this.txtPaidAmount_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1167, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvProcedures
            // 
            this.dgvProcedures.AllowUserToAddRows = false;
            this.dgvProcedures.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProcedures.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcedures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcedures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProcedures.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.doctorsList,
            this.Price,
            this.Discount,
            this.DiscountRate,
            this.Total,
            this.btnDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcedures.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProcedures.Location = new System.Drawing.Point(17, 69);
            this.dgvProcedures.MultiSelect = false;
            this.dgvProcedures.Name = "dgvProcedures";
            this.dgvProcedures.RowHeadersWidth = 45;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            this.dgvProcedures.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProcedures.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProcedures.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvProcedures.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvProcedures.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProcedures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProcedures.ShowCellErrors = false;
            this.dgvProcedures.ShowCellToolTips = false;
            this.dgvProcedures.ShowEditingIcon = false;
            this.dgvProcedures.ShowRowErrors = false;
            this.dgvProcedures.Size = new System.Drawing.Size(908, 339);
            this.dgvProcedures.TabIndex = 3;
            this.dgvProcedures.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedures_CellContentClick);
            this.dgvProcedures.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedures_CellEndEdit);
            this.dgvProcedures.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProcedures_DataError);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 1F;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.DataPropertyName = "title";
            this.title.FillWeight = 20F;
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // doctorsList
            // 
            this.doctorsList.FillWeight = 35F;
            this.doctorsList.HeaderText = "Dr.";
            this.doctorsList.MinimumWidth = 6;
            this.doctorsList.Name = "doctorsList";
            this.doctorsList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorsList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "fees";
            this.Price.FillWeight = 10F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "discount";
            this.Discount.FillWeight = 10F;
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DiscountRate
            // 
            this.DiscountRate.FillWeight = 10F;
            this.DiscountRate.HeaderText = "Discount Rate";
            this.DiscountRate.MinimumWidth = 6;
            this.DiscountRate.Name = "DiscountRate";
            this.DiscountRate.ReadOnly = true;
            this.DiscountRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            this.Total.FillWeight = 10F;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnDelete
            // 
            this.btnDelete.DataPropertyName = "control";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnDelete.FillWeight = 5F;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.Text = "X";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(678, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 75;
            this.label5.Text = "Paid:   Rs.";
            this.label5.Click += new System.EventHandler(this.txtPaidAmount_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(612, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 25);
            this.label8.TabIndex = 77;
            this.label8.Text = "Bill Amount:   Rs.";
            this.label8.Click += new System.EventHandler(this.txtPaidAmount_Click);
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAmount.ForeColor = System.Drawing.Color.Red;
            this.lblBillAmount.Location = new System.Drawing.Point(826, 487);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(55, 30);
            this.lblBillAmount.TabIndex = 76;
            this.lblBillAmount.Text = "0.00";
            this.lblBillAmount.Click += new System.EventHandler(this.txtPaidAmount_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(649, 558);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 25);
            this.label14.TabIndex = 79;
            this.label14.Text = "Balance:   Rs.";
            this.label14.Click += new System.EventHandler(this.txtPaidAmount_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Green;
            this.lblBalance.Location = new System.Drawing.Point(826, 555);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(55, 30);
            this.lblBalance.TabIndex = 78;
            this.lblBalance.Text = "0.00";
            this.lblBalance.Click += new System.EventHandler(this.txtPaidAmount_Click);
            // 
            // gbProcedure
            // 
            this.gbProcedure.Controls.Add(this.txtPaidAmount);
            this.gbProcedure.Controls.Add(this.lblPrice);
            this.gbProcedure.Controls.Add(this.label6);
            this.gbProcedure.Controls.Add(this.btnAdd);
            this.gbProcedure.Controls.Add(this.label3);
            this.gbProcedure.Controls.Add(this.label14);
            this.gbProcedure.Controls.Add(this.txtProcedureCode);
            this.gbProcedure.Controls.Add(this.lblBalance);
            this.gbProcedure.Controls.Add(this.label4);
            this.gbProcedure.Controls.Add(this.label8);
            this.gbProcedure.Controls.Add(this.cmbProcedures);
            this.gbProcedure.Controls.Add(this.lblBillAmount);
            this.gbProcedure.Controls.Add(this.label5);
            this.gbProcedure.Controls.Add(this.dgvProcedures);
            this.gbProcedure.Controls.Add(this.lblGrandTotal);
            this.gbProcedure.Controls.Add(this.label12);
            this.gbProcedure.Controls.Add(this.label10);
            this.gbProcedure.Controls.Add(this.lblTotalDiscount);
            this.gbProcedure.Location = new System.Drawing.Point(12, 61);
            this.gbProcedure.Name = "gbProcedure";
            this.gbProcedure.Size = new System.Drawing.Size(941, 596);
            this.gbProcedure.TabIndex = 0;
            this.gbProcedure.TabStop = false;
            this.gbProcedure.Text = "Procedure Detail";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BorderColor = System.Drawing.Color.Blue;
            this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(792, 523);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(88, 31);
            this.txtPaidAmount.TabIndex = 83;
            this.txtPaidAmount.Text = "0.00";
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaidAmount.Click += new System.EventHandler(this.txtPaidAmount_Click);
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtPaidAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.lblPrice.Enabled = false;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(739, 21);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(115, 43);
            this.lblPrice.TabIndex = 82;
            this.lblPrice.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(709, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 81;
            this.label6.Text = "Rs.";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(860, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 42);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "&ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAdd_KeyDown);
            // 
            // gbPatientDetail
            // 
            this.gbPatientDetail.Controls.Add(this.textBox1);
            this.gbPatientDetail.Controls.Add(this.txtPatientMobileNumber);
            this.gbPatientDetail.Controls.Add(this.txtPatientName);
            this.gbPatientDetail.Controls.Add(this.txtBloodPressureLower);
            this.gbPatientDetail.Controls.Add(this.label11);
            this.gbPatientDetail.Controls.Add(this.label2);
            this.gbPatientDetail.Controls.Add(this.cmbBloodGroup);
            this.gbPatientDetail.Controls.Add(this.txtHeight);
            this.gbPatientDetail.Controls.Add(this.label1);
            this.gbPatientDetail.Controls.Add(this.label9);
            this.gbPatientDetail.Controls.Add(this.label15);
            this.gbPatientDetail.Controls.Add(this.txtPatientId);
            this.gbPatientDetail.Controls.Add(this.label26);
            this.gbPatientDetail.Controls.Add(this.label16);
            this.gbPatientDetail.Controls.Add(this.label17);
            this.gbPatientDetail.Controls.Add(this.rbStaff);
            this.gbPatientDetail.Controls.Add(this.label19);
            this.gbPatientDetail.Controls.Add(this.rbPrivate);
            this.gbPatientDetail.Controls.Add(this.txtWeight);
            this.gbPatientDetail.Controls.Add(this.label20);
            this.gbPatientDetail.Controls.Add(this.label21);
            this.gbPatientDetail.Controls.Add(this.lblGender);
            this.gbPatientDetail.Controls.Add(this.label22);
            this.gbPatientDetail.Controls.Add(this.txtBloodPressureUpper);
            this.gbPatientDetail.Controls.Add(this.txtAge);
            this.gbPatientDetail.Controls.Add(this.label23);
            this.gbPatientDetail.Controls.Add(this.label24);
            this.gbPatientDetail.Controls.Add(this.label25);
            this.gbPatientDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientDetail.Location = new System.Drawing.Point(959, 103);
            this.gbPatientDetail.Name = "gbPatientDetail";
            this.gbPatientDetail.Size = new System.Drawing.Size(379, 554);
            this.gbPatientDetail.TabIndex = 4;
            this.gbPatientDetail.TabStop = false;
            this.gbPatientDetail.Text = "Patient Info";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(176, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(185, 31);
            this.textBox1.TabIndex = 68;
            this.textBox1.Text = "0";
            // 
            // txtPatientMobileNumber
            // 
            this.txtPatientMobileNumber.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientMobileNumber.Location = new System.Drawing.Point(13, 207);
            this.txtPatientMobileNumber.MaxLength = 4;
            this.txtPatientMobileNumber.Name = "txtPatientMobileNumber";
            this.txtPatientMobileNumber.ReadOnly = true;
            this.txtPatientMobileNumber.Size = new System.Drawing.Size(348, 31);
            this.txtPatientMobileNumber.TabIndex = 67;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(13, 133);
            this.txtPatientName.MaxLength = 4;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(348, 31);
            this.txtPatientName.TabIndex = 67;
            // 
            // txtBloodPressureLower
            // 
            this.txtBloodPressureLower.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodPressureLower.Location = new System.Drawing.Point(176, 508);
            this.txtBloodPressureLower.MaxLength = 4;
            this.txtBloodPressureLower.Name = "txtBloodPressureLower";
            this.txtBloodPressureLower.ReadOnly = true;
            this.txtBloodPressureLower.Size = new System.Drawing.Size(73, 31);
            this.txtBloodPressureLower.TabIndex = 8;
            this.txtBloodPressureLower.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(251, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 21);
            this.label11.TabIndex = 66;
            this.label11.Text = "Lower";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Inches";
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGroup.Enabled = false;
            this.cmbBloodGroup.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(176, 420);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(105, 33);
            this.cmbBloodGroup.TabIndex = 6;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(176, 353);
            this.txtHeight.MaxLength = 4;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(49, 31);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Patient ID# :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(82, 356);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 25);
            this.label15.TabIndex = 63;
            this.label15.Text = "Height:";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.Location = new System.Drawing.Point(176, 63);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(185, 31);
            this.txtPatientId.TabIndex = 12;
            this.txtPatientId.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(31, 424);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(123, 25);
            this.label26.TabIndex = 61;
            this.label26.Text = "Blood Group:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 25);
            this.label16.TabIndex = 43;
            this.label16.Text = "Patient Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 25);
            this.label17.TabIndex = 49;
            this.label17.Text = "Mobile:";
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStaff.Location = new System.Drawing.Point(268, 252);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(67, 29);
            this.rbStaff.TabIndex = 3;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(73, 390);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 25);
            this.label19.TabIndex = 52;
            this.label19.Text = "Weight: ";
            // 
            // rbPrivate
            // 
            this.rbPrivate.AutoSize = true;
            this.rbPrivate.Checked = true;
            this.rbPrivate.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrivate.Location = new System.Drawing.Point(176, 252);
            this.rbPrivate.Name = "rbPrivate";
            this.rbPrivate.Size = new System.Drawing.Size(88, 29);
            this.rbPrivate.TabIndex = 2;
            this.rbPrivate.TabStop = true;
            this.rbPrivate.Text = "Private";
            this.rbPrivate.UseVisualStyleBackColor = true;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(176, 387);
            this.txtWeight.MaxLength = 4;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(36, 31);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 254);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 25);
            this.label20.TabIndex = 58;
            this.label20.Text = "Customer Type:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 458);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(138, 25);
            this.label21.TabIndex = 53;
            this.label21.Text = "Blood Pressure";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(176, 288);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(117, 25);
            this.lblGender.TabIndex = 57;
            this.lblGender.Text = "male/female";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(76, 288);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 25);
            this.label22.TabIndex = 57;
            this.label22.Text = "Gender:";
            // 
            // txtBloodPressureUpper
            // 
            this.txtBloodPressureUpper.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodPressureUpper.Location = new System.Drawing.Point(176, 468);
            this.txtBloodPressureUpper.MaxLength = 4;
            this.txtBloodPressureUpper.Name = "txtBloodPressureUpper";
            this.txtBloodPressureUpper.ReadOnly = true;
            this.txtBloodPressureUpper.Size = new System.Drawing.Size(73, 31);
            this.txtBloodPressureUpper.TabIndex = 7;
            this.txtBloodPressureUpper.Text = "0";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(176, 319);
            this.txtAge.MaxLength = 4;
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(47, 31);
            this.txtAge.TabIndex = 2;
            this.txtAge.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(217, 392);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 21);
            this.label23.TabIndex = 54;
            this.label23.Text = "Kg(s)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(60, 322);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 25);
            this.label24.TabIndex = 56;
            this.label24.Text = "Age/DOB:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(251, 473);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 21);
            this.label25.TabIndex = 55;
            this.label25.Text = "Upper";
            // 
            // frmProcedureBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.gbPatientDetail);
            this.Controls.Add(this.gbProcedure);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBillId);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PROCEDURE);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProcedureBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Procedure Form";
            this.Load += new System.EventHandler(this.frmProcedureForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedures)).EndInit();
            this.gbProcedure.ResumeLayout(false);
            this.gbProcedure.PerformLayout();
            this.gbPatientDetail.ResumeLayout(false);
            this.gbPatientDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcedureCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label PROCEDURE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProcedures;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTotalDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProcedures;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox gbProcedure;
        private System.Windows.Forms.GroupBox gbPatientDetail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPatientMobileNumber;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtBloodPressureLower;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rbPrivate;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBloodPressureUpper;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox lblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewComboBoxColumn doctorsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private Common.CustomTextBox txtPaidAmount;
    }
}