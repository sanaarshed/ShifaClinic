namespace ShifaClinic.Patient
{
    partial class frmEntryForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMobileNumber = new ShifaClinic.Common.CustomTextBox();
            this.txtPatientName = new ShifaClinic.Common.CustomTextBox();
            this.txtCNIC = new System.Windows.Forms.MaskedTextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAge = new ShifaClinic.Common.CustomTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPatientId = new ShifaClinic.Common.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHomeAddress = new ShifaClinic.Common.CustomTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFatherMobile = new ShifaClinic.Common.CustomTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFatherName = new ShifaClinic.Common.CustomTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.formError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSearchStaff = new ShifaClinic.Common.CustomTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrintDetails = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblFormMode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFormMode);
            this.groupBox1.Controls.Add(this.txtMobileNumber);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.txtCNIC);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPatientId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.BorderColor = System.Drawing.Color.Blue;
            this.txtMobileNumber.Location = new System.Drawing.Point(164, 198);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(356, 29);
            this.txtMobileNumber.TabIndex = 6;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BorderColor = System.Drawing.Color.Blue;
            this.txtPatientName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatientName.Location = new System.Drawing.Point(164, 58);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(356, 29);
            this.txtPatientName.TabIndex = 0;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(164, 159);
            this.txtCNIC.Mask = "00000-0000000-0";
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(356, 29);
            this.txtCNIC.TabIndex = 5;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(251, 93);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(269, 29);
            this.dtpDOB.TabIndex = 2;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "/";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(232, 128);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(78, 25);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(164, 128);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 25);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mobile Number :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "CNIC :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Gender :";
            // 
            // txtAge
            // 
            this.txtAge.BorderColor = System.Drawing.Color.Blue;
            this.txtAge.Location = new System.Drawing.Point(164, 93);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(62, 29);
            this.txtAge.TabIndex = 1;
            this.txtAge.Text = "0";
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Age / Date of Birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Patient Name:";
            // 
            // txtPatientId
            // 
            this.txtPatientId.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPatientId.Location = new System.Drawing.Point(164, 23);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(121, 29);
            this.txtPatientId.TabIndex = 0;
            this.txtPatientId.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Patient ID# :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHomeAddress);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtFatherMobile);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtFatherName);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(16, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra Info";
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtHomeAddress.Location = new System.Drawing.Point(162, 95);
            this.txtHomeAddress.Multiline = true;
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(358, 127);
            this.txtHomeAddress.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 21);
            this.label15.TabIndex = 8;
            this.label15.Text = "Home Address :";
            // 
            // txtFatherMobile
            // 
            this.txtFatherMobile.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtFatherMobile.Location = new System.Drawing.Point(162, 60);
            this.txtFatherMobile.Name = "txtFatherMobile";
            this.txtFatherMobile.Size = new System.Drawing.Size(358, 29);
            this.txtFatherMobile.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 21);
            this.label17.TabIndex = 4;
            this.label17.Text = "Father\'s Mobile  :";
            // 
            // txtFatherName
            // 
            this.txtFatherName.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtFatherName.Location = new System.Drawing.Point(162, 25);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(358, 29);
            this.txtFatherName.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "Father\'s Name :";
            // 
            // formError
            // 
            this.formError.ContainerControl = this;
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchStaff.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearchStaff.Location = new System.Drawing.Point(576, 86);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(913, 29);
            this.txtSearchStaff.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(572, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(357, 21);
            this.label12.TabIndex = 36;
            this.label12.Text = "Search By Patient ID/Mobile#/Name/Father Name:";
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.AllowUserToAddRows = false;
            this.dgvPatientList.AllowUserToDeleteRows = false;
            this.dgvPatientList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullName,
            this.mobileNumber,
            this.cnic,
            this.age,
            this.dob,
            this.gender,
            this.FatherName,
            this.FatherMobileNumber,
            this.Address});
            this.dgvPatientList.Location = new System.Drawing.Point(576, 121);
            this.dgvPatientList.MultiSelect = false;
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.ReadOnly = true;
            this.dgvPatientList.RowHeadersWidth = 45;
            this.dgvPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPatientList.Size = new System.Drawing.Size(913, 422);
            this.dgvPatientList.TabIndex = 4;
            this.dgvPatientList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPatientList_CellMouseDoubleClick);
            this.dgvPatientList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientList_RowEnter);
            this.dgvPatientList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPatientList_KeyDown);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.Frozen = true;
            this.id.HeaderText = "Patient ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 108;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.Frozen = true;
            this.fullName.HeaderText = "Name";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 109;
            // 
            // mobileNumber
            // 
            this.mobileNumber.DataPropertyName = "mobileNumber";
            this.mobileNumber.HeaderText = "Mobile No.";
            this.mobileNumber.MinimumWidth = 6;
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.ReadOnly = true;
            this.mobileNumber.Width = 108;
            // 
            // cnic
            // 
            this.cnic.DataPropertyName = "cnic";
            this.cnic.HeaderText = "CNIC";
            this.cnic.MinimumWidth = 6;
            this.cnic.Name = "cnic";
            this.cnic.ReadOnly = true;
            this.cnic.Width = 110;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 108;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "dob";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Visible = false;
            this.dob.Width = 110;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "getGenderText";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 108;
            // 
            // FatherName
            // 
            this.FatherName.DataPropertyName = "fatherName";
            this.FatherName.HeaderText = "Father\'s Name";
            this.FatherName.MinimumWidth = 6;
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            this.FatherName.Width = 109;
            // 
            // FatherMobileNumber
            // 
            this.FatherMobileNumber.DataPropertyName = "fatherMobileNumber";
            this.FatherMobileNumber.HeaderText = "Father\'s Mobile No.";
            this.FatherMobileNumber.MinimumWidth = 6;
            this.FatherMobileNumber.Name = "FatherMobileNumber";
            this.FatherMobileNumber.ReadOnly = true;
            this.FatherMobileNumber.Width = 108;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 108;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.RoyalBlue;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(1);
            this.label16.Size = new System.Drawing.Size(1492, 40);
            this.label16.TabIndex = 40;
            this.label16.Text = "Patient Entry Form";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintDetails, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 568);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1492, 43);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(1122, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(367, 37);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnPrintDetails
            // 
            this.btnPrintDetails.AutoSize = true;
            this.btnPrintDetails.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrintDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintDetails.Location = new System.Drawing.Point(749, 3);
            this.btnPrintDetails.Name = "btnPrintDetails";
            this.btnPrintDetails.Size = new System.Drawing.Size(367, 37);
            this.btnPrintDetails.TabIndex = 2;
            this.btnPrintDetails.Text = "&Print Detail";
            this.btnPrintDetails.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(376, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(367, 37);
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
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(367, 37);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblFormMode
            // 
            this.lblFormMode.AutoSize = true;
            this.lblFormMode.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormMode.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFormMode.Location = new System.Drawing.Point(469, 22);
            this.lblFormMode.Name = "lblFormMode";
            this.lblFormMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFormMode.Size = new System.Drawing.Size(56, 25);
            this.lblFormMode.TabIndex = 12;
            this.lblFormMode.Text = "NEW";
            // 
            // frmEntryForm
            // 
            this.ClientSize = new System.Drawing.Size(1492, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSearchStaff);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvPatientList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient Entry Form";
            this.Load += new System.EventHandler(this.frmEntryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ErrorProvider formError;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvPatientList;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrintDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtCNIC;
        private Common.CustomTextBox txtPatientId;
        private Common.CustomTextBox txtAge;
        private Common.CustomTextBox txtHomeAddress;
        private Common.CustomTextBox txtFatherMobile;
        private Common.CustomTextBox txtFatherName;
        private Common.CustomTextBox txtSearchStaff;
        private Common.CustomTextBox txtPatientName;
        private Common.CustomTextBox txtMobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherMobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Label lblFormMode;
    }
}