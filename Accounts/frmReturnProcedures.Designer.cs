namespace ShifaClinic.Accounts
{
    partial class frmReturnProcedures
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPrintDetails = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReturnByFullname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbPatientDetail = new System.Windows.Forms.GroupBox();
            this.txtPatientMobileNumber = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.rbPrivate = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lblBilledByName = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblBillId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.cmbReasonTemplates = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReturnableAmount = new ShifaClinic.Common.CustomTextBox();
            this.txtPaidAmount = new ShifaClinic.Common.CustomTextBox();
            this.txtReason = new ShifaClinic.Common.CustomTextBox();
            this.txtBillProcedureId = new ShifaClinic.Common.CustomTextBox();
            this.chkService = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbPatientDetail.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.OrangeRed;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(2);
            this.label13.Size = new System.Drawing.Size(1350, 40);
            this.label13.TabIndex = 3;
            this.label13.Text = "RETURN FOR PROCEDURES";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintDetails, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 684);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 43);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(1015, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(331, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(4, 5);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(329, 33);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrintDetails
            // 
            this.btnPrintDetails.AutoSize = true;
            this.btnPrintDetails.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPrintDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintDetails.Enabled = false;
            this.btnPrintDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrintDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDetails.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintDetails.Location = new System.Drawing.Point(678, 5);
            this.btnPrintDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintDetails.Name = "btnPrintDetails";
            this.btnPrintDetails.Size = new System.Drawing.Size(329, 33);
            this.btnPrintDetails.TabIndex = 2;
            this.btnPrintDetails.Text = "&Print Detail";
            this.btnPrintDetails.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(341, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(329, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&SUBMIT";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(293, 122);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(62, 52);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvServices);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(522, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(783, 367);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchased Procedures";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkService,
            this.id,
            this.title,
            this.doctorId,
            this.doctorFullname,
            this.price});
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(5, 20);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowHeadersWidth = 45;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(773, 342);
            this.dgvServices.TabIndex = 0;
            this.dgvServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 77;
            this.label2.Text = "Return By:";
            // 
            // lblReturnByFullname
            // 
            this.lblReturnByFullname.AutoSize = true;
            this.lblReturnByFullname.Location = new System.Drawing.Point(138, 41);
            this.lblReturnByFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnByFullname.Name = "lblReturnByFullname";
            this.lblReturnByFullname.Size = new System.Drawing.Size(177, 21);
            this.lblReturnByFullname.TabIndex = 77;
            this.lblReturnByFullname.Text = "RETURN BY FULL NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(138, 73);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 21);
            this.lblDate.TabIndex = 77;
            this.lblDate.Text = "date";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.gbPatientDetail);
            this.groupBox2.Controls.Add(this.lblBilledByName);
            this.groupBox2.Controls.Add(this.lblBillDate);
            this.groupBox2.Controls.Add(this.lblBillId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(13, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1324, 408);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procedure Details";
            // 
            // gbPatientDetail
            // 
            this.gbPatientDetail.Controls.Add(this.txtPatientMobileNumber);
            this.gbPatientDetail.Controls.Add(this.txtPatientName);
            this.gbPatientDetail.Controls.Add(this.label14);
            this.gbPatientDetail.Controls.Add(this.txtPatientId);
            this.gbPatientDetail.Controls.Add(this.label16);
            this.gbPatientDetail.Controls.Add(this.label17);
            this.gbPatientDetail.Controls.Add(this.rbStaff);
            this.gbPatientDetail.Controls.Add(this.rbPrivate);
            this.gbPatientDetail.Controls.Add(this.label20);
            this.gbPatientDetail.Controls.Add(this.lblGender);
            this.gbPatientDetail.Controls.Add(this.label22);
            this.gbPatientDetail.Controls.Add(this.txtAge);
            this.gbPatientDetail.Controls.Add(this.label24);
            this.gbPatientDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientDetail.Location = new System.Drawing.Point(17, 155);
            this.gbPatientDetail.Name = "gbPatientDetail";
            this.gbPatientDetail.Size = new System.Drawing.Size(489, 236);
            this.gbPatientDetail.TabIndex = 82;
            this.gbPatientDetail.TabStop = false;
            this.gbPatientDetail.Text = "Patient Info";
            // 
            // txtPatientMobileNumber
            // 
            this.txtPatientMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientMobileNumber.Location = new System.Drawing.Point(164, 95);
            this.txtPatientMobileNumber.MaxLength = 4;
            this.txtPatientMobileNumber.Name = "txtPatientMobileNumber";
            this.txtPatientMobileNumber.ReadOnly = true;
            this.txtPatientMobileNumber.Size = new System.Drawing.Size(307, 26);
            this.txtPatientMobileNumber.TabIndex = 67;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(164, 64);
            this.txtPatientName.MaxLength = 4;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(307, 26);
            this.txtPatientName.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Patient ID# :";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.Location = new System.Drawing.Point(164, 31);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(75, 26);
            this.txtPatientId.TabIndex = 12;
            this.txtPatientId.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Patient Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(83, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 20);
            this.label17.TabIndex = 49;
            this.label17.Text = "Mobile:";
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStaff.Location = new System.Drawing.Point(256, 158);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(62, 24);
            this.rbStaff.TabIndex = 3;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // rbPrivate
            // 
            this.rbPrivate.AutoSize = true;
            this.rbPrivate.Checked = true;
            this.rbPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrivate.Location = new System.Drawing.Point(164, 158);
            this.rbPrivate.Name = "rbPrivate";
            this.rbPrivate.Size = new System.Drawing.Size(79, 24);
            this.rbPrivate.TabIndex = 2;
            this.rbPrivate.TabStop = true;
            this.rbPrivate.Text = "Private";
            this.rbPrivate.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 20);
            this.label20.TabIndex = 58;
            this.label20.Text = "Customer Type:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(164, 129);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 20);
            this.lblGender.TabIndex = 57;
            this.lblGender.Text = "male/female";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(77, 129);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 20);
            this.label22.TabIndex = 57;
            this.label22.Text = "Gender:";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(164, 188);
            this.txtAge.MaxLength = 4;
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(47, 26);
            this.txtAge.TabIndex = 2;
            this.txtAge.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(60, 191);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 20);
            this.label24.TabIndex = 56;
            this.label24.Text = "Age/DOB:";
            // 
            // lblBilledByName
            // 
            this.lblBilledByName.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilledByName.Location = new System.Drawing.Point(191, 104);
            this.lblBilledByName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBilledByName.Name = "lblBilledByName";
            this.lblBilledByName.Size = new System.Drawing.Size(315, 48);
            this.lblBilledByName.TabIndex = 77;
            this.lblBilledByName.Text = "BILL OPERATOR NAME/USERNAME";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(191, 68);
            this.lblBillDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(84, 21);
            this.lblBillDate.TabIndex = 77;
            this.lblBillDate.Text = "mm/dd/yy";
            // 
            // lblBillId
            // 
            this.lblBillId.AutoSize = true;
            this.lblBillId.Font = new System.Drawing.Font("Segoe UI", 10.86792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillId.Location = new System.Drawing.Point(191, 32);
            this.lblBillId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillId.Name = "lblBillId";
            this.lblBillId.Size = new System.Drawing.Size(64, 21);
            this.lblBillId.TabIndex = 77;
            this.lblBillId.Text = "000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 21);
            this.label8.TabIndex = 77;
            this.label8.Text = "By:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 21);
            this.label9.TabIndex = 77;
            this.label9.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 21);
            this.label7.TabIndex = 77;
            this.label7.Text = "Procedure Bill #";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 52);
            this.label6.TabIndex = 77;
            this.label6.Text = "PROCEDURE BILL ID #";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblReturnByFullname);
            this.groupBox3.Controls.Add(this.lblDate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtBillProcedureId);
            this.groupBox3.Controls.Add(this.btnFind);
            this.groupBox3.Location = new System.Drawing.Point(13, 54);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(382, 202);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bill Finder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 35);
            this.label3.TabIndex = 77;
            this.label3.Text = "Balance:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblBalanceAmount);
            this.groupBox4.Controls.Add(this.txtReturnableAmount);
            this.groupBox4.Controls.Add(this.txtPaidAmount);
            this.groupBox4.Controls.Add(this.cmbReasonTemplates);
            this.groupBox4.Controls.Add(this.txtReason);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(407, 54);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(930, 202);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Return";
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBalanceAmount.Location = new System.Drawing.Point(259, 144);
            this.lblBalanceAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(147, 35);
            this.lblBalanceAmount.TabIndex = 77;
            this.lblBalanceAmount.Text = "0";
            this.lblBalanceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbReasonTemplates
            // 
            this.cmbReasonTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReasonTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbReasonTemplates.FormattingEnabled = true;
            this.cmbReasonTemplates.Items.AddRange(new object[] {
            "-- SELECT RETURN REASON TEMPLATE --",
            "Doctor is not available.",
            "Customer is not satisfied with service.",
            "Over payment.",
            "Invalid bill.",
            "Other"});
            this.cmbReasonTemplates.Location = new System.Drawing.Point(493, 24);
            this.cmbReasonTemplates.Name = "cmbReasonTemplates";
            this.cmbReasonTemplates.Size = new System.Drawing.Size(429, 29);
            this.cmbReasonTemplates.TabIndex = 2;
            this.cmbReasonTemplates.SelectedIndexChanged += new System.EventHandler(this.cmbReasonTemplates_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(54, 40);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(151, 35);
            this.label29.TabIndex = 77;
            this.label29.Text = "Returnable:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(219, 42);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(40, 30);
            this.label30.TabIndex = 77;
            this.label30.Text = "Rs.";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(219, 144);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 30);
            this.label28.TabIndex = 77;
            this.label28.Text = "Rs.";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(219, 97);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 30);
            this.label32.TabIndex = 77;
            this.label32.Text = "Rs.";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(31, 95);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(174, 35);
            this.label31.TabIndex = 77;
            this.label31.Text = "Amount Paid:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 77;
            this.label5.Text = "Reason:";
            // 
            // txtReturnableAmount
            // 
            this.txtReturnableAmount.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtReturnableAmount.Font = new System.Drawing.Font("Segoe UI Semilight", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnableAmount.Location = new System.Drawing.Point(259, 32);
            this.txtReturnableAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReturnableAmount.Name = "txtReturnableAmount";
            this.txtReturnableAmount.ReadOnly = true;
            this.txtReturnableAmount.Size = new System.Drawing.Size(147, 50);
            this.txtReturnableAmount.TabIndex = 80;
            this.txtReturnableAmount.Text = "0";
            this.txtReturnableAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BorderColor = System.Drawing.Color.Blue;
            this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI Semilight", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(259, 87);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(147, 50);
            this.txtPaidAmount.TabIndex = 1;
            this.txtPaidAmount.Text = "0";
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaidAmount.Click += new System.EventHandler(this.txtPaidAmount_Click);
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtPaidAmount.Enter += new System.EventHandler(this.txtPaidAmount_Enter);
            this.txtPaidAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmount_KeyPress);
            // 
            // txtReason
            // 
            this.txtReason.BorderColor = System.Drawing.Color.Blue;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(421, 64);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(501, 128);
            this.txtReason.TabIndex = 0;
            this.txtReason.Text = "Please provide reason before submitting return...";
            this.txtReason.Enter += new System.EventHandler(this.txtReason_Enter);
            // 
            // txtBillProcedureId
            // 
            this.txtBillProcedureId.BorderColor = System.Drawing.Color.Blue;
            this.txtBillProcedureId.Font = new System.Drawing.Font("Segoe UI Semilight", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillProcedureId.Location = new System.Drawing.Point(142, 123);
            this.txtBillProcedureId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillProcedureId.Name = "txtBillProcedureId";
            this.txtBillProcedureId.Size = new System.Drawing.Size(143, 50);
            this.txtBillProcedureId.TabIndex = 0;
            this.txtBillProcedureId.Text = "0";
            this.txtBillProcedureId.Enter += new System.EventHandler(this.txtBillId_Enter);
            this.txtBillProcedureId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBillId_KeyDown);
            this.txtBillProcedureId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillId_KeyPress);
            // 
            // chkService
            // 
            this.chkService.FalseValue = "false";
            this.chkService.FillWeight = 5F;
            this.chkService.HeaderText = "";
            this.chkService.MinimumWidth = 6;
            this.chkService.Name = "chkService";
            this.chkService.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkService.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkService.TrueValue = "true";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 5F;
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Visible = false;
            // 
            // title
            // 
            this.title.DataPropertyName = "ProcedureTitle";
            this.title.FillWeight = 40F;
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // doctorId
            // 
            this.doctorId.DataPropertyName = "DoctorId";
            this.doctorId.HeaderText = "doctorId";
            this.doctorId.MinimumWidth = 6;
            this.doctorId.Name = "doctorId";
            this.doctorId.ReadOnly = true;
            this.doctorId.Visible = false;
            // 
            // doctorFullname
            // 
            this.doctorFullname.DataPropertyName = "doctorName";
            this.doctorFullname.FillWeight = 40F;
            this.doctorFullname.HeaderText = "Dr.";
            this.doctorFullname.MinimumWidth = 6;
            this.doctorFullname.Name = "doctorFullname";
            this.doctorFullname.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.price.DefaultCellStyle = dataGridViewCellStyle2;
            this.price.FillWeight = 15F;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // frmReturnProcedures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReturnProcedures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Procedures Return";
            this.Load += new System.EventHandler(this.frmReturnServices_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbPatientDetail.ResumeLayout(false);
            this.gbPatientDetail.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPrintDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReturnByFullname;
        private Common.CustomTextBox txtBillProcedureId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private Common.CustomTextBox txtReason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbReasonTemplates;
        private Common.CustomTextBox txtPaidAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblBillId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbPatientDetail;
        private System.Windows.Forms.TextBox txtPatientMobileNumber;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbPrivate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblBalanceAmount;
        private Common.CustomTextBox txtReturnableAmount;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblBilledByName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkService;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}