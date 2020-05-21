using ShifaClinic.Common;

namespace ShifaClinic.Accounts
{
    partial class frmBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.gbPatientDetail = new System.Windows.Forms.GroupBox();
            this.txtBloodPressureLower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.txtMobile = new ShifaClinic.Common.CustomTextBox();
            this.txtHight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.txtPatientName = new ShifaClinic.Common.CustomTextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.rbPrivate = new System.Windows.Forms.RadioButton();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBloodPressureUpper = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDocFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbDoctorDepartment = new System.Windows.Forms.ComboBox();
            this.dgvVisit = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblBanalce = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new ShifaClinic.Common.CustomTextBox();
            this.gvPatientList = new System.Windows.Forms.DataGridView();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.btnSearchPanelClose = new System.Windows.Forms.Button();
            this.txtSearchCriteria = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPrintDetails = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbPatientDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.RoyalBlue;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(-5, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(1);
            this.label13.Size = new System.Drawing.Size(1363, 40);
            this.label13.TabIndex = 0;
            this.label13.Text = "BILL INVOICE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbPatientDetail
            // 
            this.gbPatientDetail.Controls.Add(this.txtBloodPressureLower);
            this.gbPatientDetail.Controls.Add(this.label2);
            this.gbPatientDetail.Controls.Add(this.label1);
            this.gbPatientDetail.Controls.Add(this.cmbBloodGroup);
            this.gbPatientDetail.Controls.Add(this.txtMobile);
            this.gbPatientDetail.Controls.Add(this.txtHight);
            this.gbPatientDetail.Controls.Add(this.label6);
            this.gbPatientDetail.Controls.Add(this.label3);
            this.gbPatientDetail.Controls.Add(this.txtPatientId);
            this.gbPatientDetail.Controls.Add(this.label26);
            this.gbPatientDetail.Controls.Add(this.label7);
            this.gbPatientDetail.Controls.Add(this.panel1);
            this.gbPatientDetail.Controls.Add(this.txtPatientName);
            this.gbPatientDetail.Controls.Add(this.dtpDOB);
            this.gbPatientDetail.Controls.Add(this.label8);
            this.gbPatientDetail.Controls.Add(this.label17);
            this.gbPatientDetail.Controls.Add(this.btnSearch);
            this.gbPatientDetail.Controls.Add(this.rbStaff);
            this.gbPatientDetail.Controls.Add(this.label10);
            this.gbPatientDetail.Controls.Add(this.rbPrivate);
            this.gbPatientDetail.Controls.Add(this.txtWeight);
            this.gbPatientDetail.Controls.Add(this.label16);
            this.gbPatientDetail.Controls.Add(this.label9);
            this.gbPatientDetail.Controls.Add(this.label15);
            this.gbPatientDetail.Controls.Add(this.txtBloodPressureUpper);
            this.gbPatientDetail.Controls.Add(this.txtAge);
            this.gbPatientDetail.Controls.Add(this.label11);
            this.gbPatientDetail.Controls.Add(this.label14);
            this.gbPatientDetail.Controls.Add(this.label12);
            this.gbPatientDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientDetail.Location = new System.Drawing.Point(12, 53);
            this.gbPatientDetail.Name = "gbPatientDetail";
            this.gbPatientDetail.Size = new System.Drawing.Size(1202, 145);
            this.gbPatientDetail.TabIndex = 0;
            this.gbPatientDetail.TabStop = false;
            this.gbPatientDetail.Text = "Patient Info";
            // 
            // txtBloodPressureLower
            // 
            this.txtBloodPressureLower.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodPressureLower.Location = new System.Drawing.Point(1064, 96);
            this.txtBloodPressureLower.MaxLength = 4;
            this.txtBloodPressureLower.Name = "txtBloodPressureLower";
            this.txtBloodPressureLower.Size = new System.Drawing.Size(73, 29);
            this.txtBloodPressureLower.TabIndex = 8;
            this.txtBloodPressureLower.Text = "0";
            this.txtBloodPressureLower.Click += new System.EventHandler(this.txtControls_Click);
            this.txtBloodPressureLower.TextChanged += new System.EventHandler(this.txtControls_Click);
            this.txtBloodPressureLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControls_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1139, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Lower";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(990, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Inches";
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbBloodGroup.Location = new System.Drawing.Point(939, 98);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(73, 29);
            this.cmbBloodGroup.TabIndex = 6;
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMobile.BorderColor = System.Drawing.Color.Blue;
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(161, 99);
            this.txtMobile.MaxLength = 16;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(273, 29);
            this.txtMobile.TabIndex = 1;
            this.txtMobile.Click += new System.EventHandler(this.txtControls_Click);
            this.txtMobile.TextChanged += new System.EventHandler(this.txtControls_Click);
            this.txtMobile.Leave += new System.EventHandler(this.txtControl_Leave);
            // 
            // txtHight
            // 
            this.txtHight.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHight.Location = new System.Drawing.Point(939, 21);
            this.txtHight.MaxLength = 4;
            this.txtHight.Name = "txtHight";
            this.txtHight.Size = new System.Drawing.Size(49, 29);
            this.txtHight.TabIndex = 4;
            this.txtHight.Text = "0";
            this.txtHight.Click += new System.EventHandler(this.txtControls_Click);
            this.txtHight.TextChanged += new System.EventHandler(this.txtControls_Click);
            this.txtHight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControls_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Patient ID# :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(861, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 63;
            this.label3.Text = "Height:";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.Location = new System.Drawing.Point(161, 21);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(75, 29);
            this.txtPatientId.TabIndex = 12;
            this.txtPatientId.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(810, 102);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 23);
            this.label26.TabIndex = 61;
            this.label26.Text = "Blood Group:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "Patient Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(564, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 36);
            this.panel1.TabIndex = 3;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(3, 3);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(65, 27);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(92, 3);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(82, 27);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPatientName.BorderColor = System.Drawing.Color.Blue;
            this.txtPatientName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(161, 60);
            this.txtPatientName.MaxLength = 55;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(273, 29);
            this.txtPatientName.TabIndex = 0;
            this.txtPatientName.Click += new System.EventHandler(this.txtControls_Click);
            this.txtPatientName.TextChanged += new System.EventHandler(this.txtControls_Click);
            this.txtPatientName.Leave += new System.EventHandler(this.txtControl_Leave);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(629, 99);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(167, 29);
            this.dtpDOB.TabIndex = 7;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = "Mobile:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(613, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 23);
            this.label17.TabIndex = 60;
            this.label17.Text = "/";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(241, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 33);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search (F3)";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStaff.Location = new System.Drawing.Point(656, 22);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(61, 27);
            this.rbStaff.TabIndex = 3;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(852, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 23);
            this.label10.TabIndex = 52;
            this.label10.Text = "Weight: ";
            // 
            // rbPrivate
            // 
            this.rbPrivate.AutoSize = true;
            this.rbPrivate.Checked = true;
            this.rbPrivate.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrivate.Location = new System.Drawing.Point(564, 22);
            this.rbPrivate.Name = "rbPrivate";
            this.rbPrivate.Size = new System.Drawing.Size(80, 27);
            this.rbPrivate.TabIndex = 2;
            this.rbPrivate.TabStop = true;
            this.rbPrivate.Text = "Private";
            this.rbPrivate.UseVisualStyleBackColor = true;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(939, 60);
            this.txtWeight.MaxLength = 4;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(36, 29);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.Text = "0";
            this.txtWeight.Click += new System.EventHandler(this.txtControls_Click);
            this.txtWeight.TextChanged += new System.EventHandler(this.txtControls_Click);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControls_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(419, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 23);
            this.label16.TabIndex = 58;
            this.label16.Text = "Customer Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1059, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 23);
            this.label9.TabIndex = 53;
            this.label9.Text = "Blood Pressure";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(482, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 57;
            this.label15.Text = "Gender:";
            // 
            // txtBloodPressureUpper
            // 
            this.txtBloodPressureUpper.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodPressureUpper.Location = new System.Drawing.Point(1064, 60);
            this.txtBloodPressureUpper.MaxLength = 4;
            this.txtBloodPressureUpper.Name = "txtBloodPressureUpper";
            this.txtBloodPressureUpper.Size = new System.Drawing.Size(73, 29);
            this.txtBloodPressureUpper.TabIndex = 7;
            this.txtBloodPressureUpper.Text = "0";
            this.txtBloodPressureUpper.Click += new System.EventHandler(this.txtControls_Click);
            this.txtBloodPressureUpper.TextChanged += new System.EventHandler(this.txtControls_Click);
            this.txtBloodPressureUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControls_KeyPress);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(565, 99);
            this.txtAge.MaxLength = 4;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(47, 29);
            this.txtAge.TabIndex = 2;
            this.txtAge.Text = "0";
            this.txtAge.Click += new System.EventHandler(this.txtControls_Click);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControls_KeyPress);
            this.txtAge.SystemColorsChanged += new System.EventHandler(this.txtControls_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(979, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Kg(s)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(466, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 23);
            this.label14.TabIndex = 56;
            this.label14.Text = "Age/DOB:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1139, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 55;
            this.label12.Text = "Upper";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDocFee);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.lblTotalDiscount);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbDoctor);
            this.groupBox3.Controls.Add(this.cmbDoctorDepartment);
            this.groupBox3.Controls.Add(this.dgvVisit);
            this.groupBox3.Controls.Add(this.cmbServices);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.lblGrandTotal);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(15, 8, 8, 5);
            this.groupBox3.Size = new System.Drawing.Size(962, 409);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Particulars";
            // 
            // lblDocFee
            // 
            this.lblDocFee.BackColor = System.Drawing.SystemColors.Menu;
            this.lblDocFee.Enabled = false;
            this.lblDocFee.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocFee.Location = new System.Drawing.Point(806, 19);
            this.lblDocFee.Name = "lblDocFee";
            this.lblDocFee.Size = new System.Drawing.Size(92, 40);
            this.lblDocFee.TabIndex = 73;
            this.lblDocFee.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(784, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 28);
            this.label4.TabIndex = 71;
            this.label4.Text = "Rs.";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(618, 371);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(154, 28);
            this.label18.TabIndex = 70;
            this.label18.Text = "Total Discount:";
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDiscount.AutoSize = true;
            this.lblTotalDiscount.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiscount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalDiscount.Location = new System.Drawing.Point(825, 371);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(53, 28);
            this.lblTotalDiscount.TabIndex = 72;
            this.lblTotalDiscount.Text = "0.00";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Black", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(901, 19);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 44);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(777, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Rs.";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.ItemHeight = 21;
            this.cmbDoctor.Location = new System.Drawing.Point(452, 23);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(319, 29);
            this.cmbDoctor.TabIndex = 2;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
            // 
            // cmbDoctorDepartment
            // 
            this.cmbDoctorDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDoctorDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDoctorDepartment.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctorDepartment.FormattingEnabled = true;
            this.cmbDoctorDepartment.Location = new System.Drawing.Point(215, 23);
            this.cmbDoctorDepartment.Name = "cmbDoctorDepartment";
            this.cmbDoctorDepartment.Size = new System.Drawing.Size(231, 29);
            this.cmbDoctorDepartment.TabIndex = 1;
            this.cmbDoctorDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDoctorDepartment_SelectedIndexChanged);
            // 
            // dgvVisit
            // 
            this.dgvVisit.AllowUserToAddRows = false;
            this.dgvVisit.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Azure;
            this.dgvVisit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvVisit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.doctorId,
            this.doctorName,
            this.Price,
            this.Discount,
            this.DiscountRate,
            this.Total,
            this.btnDelete});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisit.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVisit.Location = new System.Drawing.Point(13, 71);
            this.dgvVisit.MultiSelect = false;
            this.dgvVisit.Name = "dgvVisit";
            this.dgvVisit.RowHeadersWidth = 45;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            this.dgvVisit.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVisit.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVisit.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvVisit.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvVisit.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVisit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVisit.ShowCellErrors = false;
            this.dgvVisit.ShowCellToolTips = false;
            this.dgvVisit.ShowEditingIcon = false;
            this.dgvVisit.ShowRowErrors = false;
            this.dgvVisit.Size = new System.Drawing.Size(938, 262);
            this.dgvVisit.TabIndex = 4;
            this.dgvVisit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisit_CellContentClick);
            this.dgvVisit.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisit_CellEndEdit);
            this.dgvVisit.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvVisit_RowsAdded);
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
            // doctorId
            // 
            this.doctorId.DataPropertyName = "doctorId";
            this.doctorId.HeaderText = "DoctorID";
            this.doctorId.MinimumWidth = 6;
            this.doctorId.Name = "doctorId";
            this.doctorId.Visible = false;
            // 
            // doctorName
            // 
            this.doctorName.FillWeight = 35F;
            this.doctorName.HeaderText = "Dr.";
            this.doctorName.MinimumWidth = 6;
            this.doctorName.Name = "doctorName";
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle8;
            this.btnDelete.FillWeight = 5F;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.Text = "X";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // cmbServices
            // 
            this.cmbServices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbServices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbServices.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(13, 23);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(196, 29);
            this.cmbServices.TabIndex = 0;
            this.cmbServices.SelectedIndexChanged += new System.EventHandler(this.cmbServices_SelectedIndexChanged);
            this.cmbServices.Leave += new System.EventHandler(this.cmbServices_Leave);
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(784, 338);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 28);
            this.label24.TabIndex = 60;
            this.label24.Text = "Rs.";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(645, 338);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(127, 28);
            this.label22.TabIndex = 54;
            this.label22.Text = "Grand Total:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.lblGrandTotal.Location = new System.Drawing.Point(825, 338);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(53, 28);
            this.lblGrandTotal.TabIndex = 65;
            this.lblGrandTotal.Text = "0.00";
            this.lblGrandTotal.TextChanged += new System.EventHandler(this.lblGrandTotal_TextChanged);
            // 
            // lblBanalce
            // 
            this.lblBanalce.AutoSize = true;
            this.lblBanalce.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanalce.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBanalce.Location = new System.Drawing.Point(199, 150);
            this.lblBanalce.Name = "lblBanalce";
            this.lblBanalce.Size = new System.Drawing.Size(58, 30);
            this.lblBanalce.TabIndex = 64;
            this.lblBanalce.Text = "0.00";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DarkGreen;
            this.label27.Location = new System.Drawing.Point(149, 150);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(43, 30);
            this.label27.TabIndex = 63;
            this.label27.Text = "Rs.";
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAmount.ForeColor = System.Drawing.Color.Red;
            this.lblBillAmount.Location = new System.Drawing.Point(203, 32);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(64, 35);
            this.lblBillAmount.TabIndex = 62;
            this.lblBillAmount.Text = "0.00";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(143, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 35);
            this.label25.TabIndex = 61;
            this.label25.Text = "Rs.";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(59, 32);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 35);
            this.label28.TabIndex = 57;
            this.label28.Text = "BILL:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(66, 93);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 30);
            this.label29.TabIndex = 58;
            this.label29.Text = "Paid:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(25, 150);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(99, 30);
            this.label30.TabIndex = 59;
            this.label30.Text = "Balance:";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPaidAmount.BorderColor = System.Drawing.Color.Blue;
            this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(149, 90);
            this.txtPaidAmount.MaxLength = 7;
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(128, 42);
            this.txtPaidAmount.TabIndex = 0;
            this.txtPaidAmount.Text = "0.00";
            this.txtPaidAmount.Click += new System.EventHandler(this.txtControls_Click);
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtPaidAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControls_KeyPress);
            this.txtPaidAmount.Leave += new System.EventHandler(this.txtControl_Leave);
            // 
            // gvPatientList
            // 
            this.gvPatientList.AllowUserToAddRows = false;
            this.gvPatientList.AllowUserToDeleteRows = false;
            this.gvPatientList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientId,
            this.gvPatientName,
            this.gvPatientAge,
            this.gvPatientGender,
            this.gvPatientCNIC,
            this.gvPatientMobile,
            this.gvPatientFatherName});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPatientList.DefaultCellStyle = dataGridViewCellStyle12;
            this.gvPatientList.Location = new System.Drawing.Point(6, 38);
            this.gvPatientList.MultiSelect = false;
            this.gvPatientList.Name = "gvPatientList";
            this.gvPatientList.ReadOnly = true;
            this.gvPatientList.RowHeadersVisible = false;
            this.gvPatientList.RowHeadersWidth = 45;
            this.gvPatientList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPatientList.Size = new System.Drawing.Size(312, 55);
            this.gvPatientList.TabIndex = 64;
            this.gvPatientList.Visible = false;
            this.gvPatientList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvPatientList_CellMouseDoubleClick);
            this.gvPatientList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvPatientList_DataBindingComplete);
            this.gvPatientList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPatientList_RowEnter);
            this.gvPatientList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvPatientList_KeyDown);
            // 
            // PatientId
            // 
            this.PatientId.DataPropertyName = "id";
            this.PatientId.FillWeight = 10F;
            this.PatientId.HeaderText = "Id";
            this.PatientId.MinimumWidth = 6;
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            // 
            // gvPatientName
            // 
            this.gvPatientName.DataPropertyName = "fullName";
            this.gvPatientName.FillWeight = 20F;
            this.gvPatientName.HeaderText = "Patient Name ";
            this.gvPatientName.MinimumWidth = 6;
            this.gvPatientName.Name = "gvPatientName";
            this.gvPatientName.ReadOnly = true;
            // 
            // gvPatientAge
            // 
            this.gvPatientAge.DataPropertyName = "age";
            this.gvPatientAge.FillWeight = 10F;
            this.gvPatientAge.HeaderText = "DOB/Age";
            this.gvPatientAge.MinimumWidth = 6;
            this.gvPatientAge.Name = "gvPatientAge";
            this.gvPatientAge.ReadOnly = true;
            // 
            // gvPatientGender
            // 
            this.gvPatientGender.DataPropertyName = "gender";
            this.gvPatientGender.FillWeight = 10F;
            this.gvPatientGender.HeaderText = "Gender";
            this.gvPatientGender.MinimumWidth = 6;
            this.gvPatientGender.Name = "gvPatientGender";
            this.gvPatientGender.ReadOnly = true;
            // 
            // gvPatientCNIC
            // 
            this.gvPatientCNIC.DataPropertyName = "CNIC";
            this.gvPatientCNIC.FillWeight = 20F;
            this.gvPatientCNIC.HeaderText = "CNIC";
            this.gvPatientCNIC.MinimumWidth = 6;
            this.gvPatientCNIC.Name = "gvPatientCNIC";
            this.gvPatientCNIC.ReadOnly = true;
            // 
            // gvPatientMobile
            // 
            this.gvPatientMobile.DataPropertyName = "mobileNumber";
            this.gvPatientMobile.FillWeight = 20F;
            this.gvPatientMobile.HeaderText = "Mobile";
            this.gvPatientMobile.MinimumWidth = 6;
            this.gvPatientMobile.Name = "gvPatientMobile";
            this.gvPatientMobile.ReadOnly = true;
            // 
            // gvPatientFatherName
            // 
            this.gvPatientFatherName.FillWeight = 20F;
            this.gvPatientFatherName.HeaderText = "Father Name";
            this.gvPatientFatherName.MinimumWidth = 6;
            this.gvPatientFatherName.Name = "gvPatientFatherName";
            this.gvPatientFatherName.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(990, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(350, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remarks / Symptoms";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(10, 24);
            this.txtRemarks.MaxLength = 1000;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(330, 157);
            this.txtRemarks.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPaidAmount);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.lblBanalce);
            this.groupBox4.Controls.Add(this.lblBillAmount);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(990, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 212);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bill";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchPanel.Controls.Add(this.btnSearchPanelClose);
            this.searchPanel.Controls.Add(this.txtSearchCriteria);
            this.searchPanel.Controls.Add(this.gvPatientList);
            this.searchPanel.Location = new System.Drawing.Point(86, -9);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(324, 100);
            this.searchPanel.TabIndex = 65;
            this.searchPanel.Visible = false;
            // 
            // btnSearchPanelClose
            // 
            this.btnSearchPanelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPanelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPanelClose.Location = new System.Drawing.Point(256, 6);
            this.btnSearchPanelClose.Name = "btnSearchPanelClose";
            this.btnSearchPanelClose.Size = new System.Drawing.Size(62, 29);
            this.btnSearchPanelClose.TabIndex = 66;
            this.btnSearchPanelClose.Text = "Close";
            this.btnSearchPanelClose.UseVisualStyleBackColor = true;
            this.btnSearchPanelClose.Click += new System.EventHandler(this.btnSearchPanelClose_Click);
            // 
            // txtSearchCriteria
            // 
            this.txtSearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCriteria.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCriteria.Location = new System.Drawing.Point(6, 6);
            this.txtSearchCriteria.Name = "txtSearchCriteria";
            this.txtSearchCriteria.Size = new System.Drawing.Size(247, 27);
            this.txtSearchCriteria.TabIndex = 65;
            this.txtSearchCriteria.Text = "Enter search criteria e.g. (Patient name, or mobile number)";
            this.txtSearchCriteria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchCriteria_KeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1230, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 31);
            this.label20.TabIndex = 72;
            this.label20.Text = "Token";
            // 
            // lblToken
            // 
            this.lblToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.Location = new System.Drawing.Point(1227, 99);
            this.lblToken.Margin = new System.Windows.Forms.Padding(0);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(113, 84);
            this.lblToken.TabIndex = 73;
            this.lblToken.Text = "0";
            this.lblToken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 678);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 49);
            this.tableLayoutPanel1.TabIndex = 75;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(1014, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(333, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(331, 43);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnPrintDetails
            // 
            this.btnPrintDetails.AutoSize = true;
            this.btnPrintDetails.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrintDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintDetails.Enabled = false;
            this.btnPrintDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrintDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDetails.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintDetails.Location = new System.Drawing.Point(677, 3);
            this.btnPrintDetails.Name = "btnPrintDetails";
            this.btnPrintDetails.Size = new System.Drawing.Size(331, 43);
            this.btnPrintDetails.TabIndex = 2;
            this.btnPrintDetails.Text = "&Print Detail";
            this.btnPrintDetails.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(340, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(331, 43);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbPatientDetail);
            this.Controls.Add(this.label13);
            this.Name = "frmBill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.frmPatientInvoiceForm_Load);
            this.gbPatientDetail.ResumeLayout(false);
            this.gbPatientDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbPatientDetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvVisit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbDoctorDepartment;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.Label lblBanalce;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private ShifaClinic.Common.CustomTextBox txtPaidAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gvPatientList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private ShifaClinic.Common.CustomTextBox txtMobile;
        private System.Windows.Forms.TextBox txtHight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private ShifaClinic.Common.CustomTextBox txtPatientName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbPrivate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBloodPressureUpper;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox txtSearchCriteria;
        private System.Windows.Forms.Button btnSearchPanelClose;
        private System.Windows.Forms.TextBox txtBloodPressureLower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTotalDiscount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox lblDocFee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPrintDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}