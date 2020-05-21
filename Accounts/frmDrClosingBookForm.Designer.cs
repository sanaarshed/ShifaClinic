namespace ShifaClinic.Accounts
{
    partial class frmDrClosingBookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDoctorsPaid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.dgvFinancialDetails = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitCounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAmountPaid = new ShifaClinic.Common.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.hdnDoctorName = new System.Windows.Forms.TextBox();
            this.lblDrId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorsPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialDetails)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.RoyalBlue;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(15);
            this.label13.Size = new System.Drawing.Size(1350, 53);
            this.label13.TabIndex = 23;
            this.label13.Text = "Daily Closing Book";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(20, 36);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(636, 27);
            this.cmbDoctor.TabIndex = 0;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
            this.cmbDoctor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDoctor_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 686);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 43);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(1014, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(333, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(677, 4);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(331, 35);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "&PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(340, 4);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(331, 35);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "&SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(3, 4);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(331, 35);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDoctorsPaid);
            this.groupBox2.Controls.Add(this.lblTodaysDate);
            this.groupBox2.Location = new System.Drawing.Point(699, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(639, 587);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PAID DOCTORS LIST";
            // 
            // dgvDoctorsPaid
            // 
            this.dgvDoctorsPaid.AllowUserToAddRows = false;
            this.dgvDoctorsPaid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDoctorsPaid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoctorsPaid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctorsPaid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvDoctorsPaid.ColumnHeadersHeight = 48;
            this.dgvDoctorsPaid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.doctorName,
            this.paidAmount,
            this.totalAmount});
            this.dgvDoctorsPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctorsPaid.Location = new System.Drawing.Point(10, 30);
            this.dgvDoctorsPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDoctorsPaid.Name = "dgvDoctorsPaid";
            this.dgvDoctorsPaid.ReadOnly = true;
            this.dgvDoctorsPaid.RowHeadersVisible = false;
            this.dgvDoctorsPaid.RowHeadersWidth = 45;
            this.dgvDoctorsPaid.Size = new System.Drawing.Size(619, 547);
            this.dgvDoctorsPaid.TabIndex = 49;
            this.dgvDoctorsPaid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctorsPaid_CellContentClick);
            this.dgvDoctorsPaid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDoctors_DataBindingComplete);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 1F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // doctorName
            // 
            this.doctorName.DataPropertyName = "doctorName";
            this.doctorName.FillWeight = 70F;
            this.doctorName.HeaderText = "Doctor";
            this.doctorName.MinimumWidth = 6;
            this.doctorName.Name = "doctorName";
            this.doctorName.ReadOnly = true;
            // 
            // paidAmount
            // 
            this.paidAmount.DataPropertyName = "paidAmount";
            this.paidAmount.FillWeight = 15F;
            this.paidAmount.HeaderText = "Paid Amount";
            this.paidAmount.MinimumWidth = 6;
            this.paidAmount.Name = "paidAmount";
            this.paidAmount.ReadOnly = true;
            // 
            // totalAmount
            // 
            this.totalAmount.DataPropertyName = "totalAmount";
            this.totalAmount.FillWeight = 15F;
            this.totalAmount.HeaderText = "Total amount";
            this.totalAmount.MinimumWidth = 6;
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysDate.Location = new System.Drawing.Point(532, 0);
            this.lblTodaysDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(44, 20);
            this.lblTodaysDate.TabIndex = 0;
            this.lblTodaysDate.Text = "Date";
            // 
            // dgvFinancialDetails
            // 
            this.dgvFinancialDetails.AllowUserToAddRows = false;
            this.dgvFinancialDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFinancialDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinancialDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinancialDetails.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvFinancialDetails.ColumnHeadersHeight = 48;
            this.dgvFinancialDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.VisitCounts,
            this.Total,
            this.Percentage,
            this.serviceId,
            this.procedureId});
            this.dgvFinancialDetails.Location = new System.Drawing.Point(7, 34);
            this.dgvFinancialDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFinancialDetails.Name = "dgvFinancialDetails";
            this.dgvFinancialDetails.ReadOnly = true;
            this.dgvFinancialDetails.RowHeadersVisible = false;
            this.dgvFinancialDetails.RowHeadersWidth = 45;
            this.dgvFinancialDetails.Size = new System.Drawing.Size(664, 314);
            this.dgvFinancialDetails.TabIndex = 57;
            // 
            // Type
            // 
            this.Type.FillWeight = 48F;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // VisitCounts
            // 
            this.VisitCounts.FillWeight = 13F;
            this.VisitCounts.HeaderText = "Visits";
            this.VisitCounts.MinimumWidth = 6;
            this.VisitCounts.Name = "VisitCounts";
            this.VisitCounts.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 13F;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Percentage
            // 
            this.Percentage.FillWeight = 13F;
            this.Percentage.HeaderText = "Share(%)";
            this.Percentage.MinimumWidth = 6;
            this.Percentage.Name = "Percentage";
            this.Percentage.ReadOnly = true;
            this.Percentage.Visible = false;
            // 
            // serviceId
            // 
            this.serviceId.HeaderText = "ServiceId";
            this.serviceId.Name = "serviceId";
            this.serviceId.ReadOnly = true;
            this.serviceId.Visible = false;
            // 
            // procedureId
            // 
            this.procedureId.HeaderText = "procedureId";
            this.procedureId.Name = "procedureId";
            this.procedureId.ReadOnly = true;
            this.procedureId.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(318, 418);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(152, 25);
            this.label24.TabIndex = 59;
            this.label24.Text = "Paid Amount:";
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(383, 626);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(25, 30);
            this.lblBalance.TabIndex = 62;
            this.lblBalance.Text = "0";
            this.lblBalance.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(188, 420);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 30);
            this.label15.TabIndex = 61;
            this.label15.Text = "Rs.";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(88, 420);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 30);
            this.label16.TabIndex = 60;
            this.label16.Text = "Balance:";
            this.label16.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 60;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 30);
            this.label2.TabIndex = 61;
            this.label2.Text = "Rs.";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(523, 370);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 30);
            this.lblTotal.TabIndex = 62;
            this.lblTotal.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbDoctor);
            this.groupBox3.Location = new System.Drawing.Point(15, 58);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(678, 88);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Doctor For Book Close";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.BorderColor = System.Drawing.Color.Blue;
            this.txtAmountPaid.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(524, 413);
            this.txtAmountPaid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmountPaid.MaxLength = 10;
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(147, 35);
            this.txtAmountPaid.TabIndex = 0;
            this.txtAmountPaid.Text = "0";
            this.txtAmountPaid.Click += new System.EventHandler(this.txtAmountPaid_Click);
            this.txtAmountPaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmountPaid_KeyDown);
            this.txtAmountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountPaid_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 30);
            this.label4.TabIndex = 61;
            this.label4.Text = "Rs.";
            this.label4.Visible = false;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.hdnDoctorName);
            this.gbDetails.Controls.Add(this.lblDrId);
            this.gbDetails.Controls.Add(this.dgvFinancialDetails);
            this.gbDetails.Controls.Add(this.txtAmountPaid);
            this.gbDetails.Controls.Add(this.label16);
            this.gbDetails.Controls.Add(this.label24);
            this.gbDetails.Controls.Add(this.label15);
            this.gbDetails.Controls.Add(this.lblTotal);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Controls.Add(this.lblBalance);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Location = new System.Drawing.Point(15, 154);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetails.Size = new System.Drawing.Size(678, 490);
            this.gbDetails.TabIndex = 63;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // hdnDoctorName
            // 
            this.hdnDoctorName.Location = new System.Drawing.Point(3, 24);
            this.hdnDoctorName.Name = "hdnDoctorName";
            this.hdnDoctorName.Size = new System.Drawing.Size(86, 27);
            this.hdnDoctorName.TabIndex = 64;
            this.hdnDoctorName.Text = "doctorname";
            this.hdnDoctorName.Visible = false;
            // 
            // lblDrId
            // 
            this.lblDrId.AutoSize = true;
            this.lblDrId.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrId.Location = new System.Drawing.Point(88, 390);
            this.lblDrId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrId.Name = "lblDrId";
            this.lblDrId.Size = new System.Drawing.Size(78, 30);
            this.lblDrId.TabIndex = 63;
            this.lblDrId.Text = "lblDrId";
            this.lblDrId.Visible = false;
            // 
            // frmDrClosingBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDrClosingBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Daily Closeout";
            this.Load += new System.EventHandler(this.frmClosingBookForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorsPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialDetails)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvFinancialDetails;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private Common.CustomTextBox txtAmountPaid;
        private System.Windows.Forms.DataGridView dgvDoctorsPaid;
        private System.Windows.Forms.Label lblTodaysDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lblDrId;
        private System.Windows.Forms.TextBox hdnDoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitCounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedureId;
    }
}