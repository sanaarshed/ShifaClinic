﻿namespace ShifaClinic.Patient
{
    partial class InvoiceForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbDoctorCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPatientDetail = new System.Windows.Forms.GroupBox();
            this.txtHight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.rbPrivate = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBloodPressure = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gvPatientList = new System.Windows.Forms.DataGridView();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtPaidAmmount = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtDiscountInPercentage = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblBanalce = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblBillAmmount = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.gbPatientDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.lblToken);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbDoctor);
            this.groupBox2.Controls.Add(this.cmbDoctorCategory);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFee);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Detail";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(178, 79);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 13);
            this.label30.TabIndex = 19;
            this.label30.Text = "Token:";
            // 
            // lblToken
            // 
            this.lblToken.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.ForeColor = System.Drawing.Color.Yellow;
            this.lblToken.Location = new System.Drawing.Point(221, 76);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(77, 41);
            this.lblToken.TabIndex = 18;
            this.lblToken.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(107, 52);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(191, 21);
            this.cmbDoctor.TabIndex = 1;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
            // 
            // cmbDoctorCategory
            // 
            this.cmbDoctorCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctorCategory.FormattingEnabled = true;
            this.cmbDoctorCategory.Location = new System.Drawing.Point(107, 26);
            this.cmbDoctorCategory.Name = "cmbDoctorCategory";
            this.cmbDoctorCategory.Size = new System.Drawing.Size(191, 21);
            this.cmbDoctorCategory.TabIndex = 0;
            this.cmbDoctorCategory.SelectedIndexChanged += new System.EventHandler(this.cmbDoctorCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Doctor: ";
            // 
            // txtFee
            // 
            this.txtFee.Enabled = false;
            this.txtFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(107, 79);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(47, 29);
            this.txtFee.TabIndex = 2;
            this.txtFee.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "FEE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category:";
            // 
            // gbPatientDetail
            // 
            this.gbPatientDetail.Controls.Add(this.cmbBloodGroup);
            this.gbPatientDetail.Controls.Add(this.txtHight);
            this.gbPatientDetail.Controls.Add(this.label3);
            this.gbPatientDetail.Controls.Add(this.label26);
            this.gbPatientDetail.Controls.Add(this.panel1);
            this.gbPatientDetail.Controls.Add(this.dtpDOB);
            this.gbPatientDetail.Controls.Add(this.label17);
            this.gbPatientDetail.Controls.Add(this.rbStaff);
            this.gbPatientDetail.Controls.Add(this.rbPrivate);
            this.gbPatientDetail.Controls.Add(this.label16);
            this.gbPatientDetail.Controls.Add(this.label15);
            this.gbPatientDetail.Controls.Add(this.txtAge);
            this.gbPatientDetail.Controls.Add(this.label14);
            this.gbPatientDetail.Controls.Add(this.label12);
            this.gbPatientDetail.Controls.Add(this.label11);
            this.gbPatientDetail.Controls.Add(this.txtBloodPressure);
            this.gbPatientDetail.Controls.Add(this.label9);
            this.gbPatientDetail.Controls.Add(this.txtWeight);
            this.gbPatientDetail.Controls.Add(this.label10);
            this.gbPatientDetail.Controls.Add(this.btnSearch);
            this.gbPatientDetail.Controls.Add(this.txtMobile);
            this.gbPatientDetail.Controls.Add(this.label8);
            this.gbPatientDetail.Controls.Add(this.txtPatientName);
            this.gbPatientDetail.Controls.Add(this.label7);
            this.gbPatientDetail.Controls.Add(this.txtPatientId);
            this.gbPatientDetail.Controls.Add(this.label6);
            this.gbPatientDetail.Location = new System.Drawing.Point(16, 64);
            this.gbPatientDetail.Name = "gbPatientDetail";
            this.gbPatientDetail.Size = new System.Drawing.Size(626, 158);
            this.gbPatientDetail.TabIndex = 1;
            this.gbPatientDetail.TabStop = false;
            this.gbPatientDetail.Text = "Patient Detail";
            // 
            // txtHight
            // 
            this.txtHight.Location = new System.Drawing.Point(494, 123);
            this.txtHight.Name = "txtHight";
            this.txtHight.Size = new System.Drawing.Size(73, 20);
            this.txtHight.TabIndex = 36;
            this.txtHight.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Height:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(403, 80);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 13);
            this.label26.TabIndex = 35;
            this.label26.Text = "Blood Group:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Location = new System.Drawing.Point(108, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 23);
            this.panel1.TabIndex = 7;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(3, 3);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(65, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(171, 100);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(203, 20);
            this.dtpDOB.TabIndex = 3;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(156, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "/";
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Location = new System.Drawing.Point(558, 21);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(47, 17);
            this.rbStaff.TabIndex = 32;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // rbPrivate
            // 
            this.rbPrivate.AutoSize = true;
            this.rbPrivate.Checked = true;
            this.rbPrivate.Location = new System.Drawing.Point(494, 21);
            this.rbPrivate.Name = "rbPrivate";
            this.rbPrivate.Size = new System.Drawing.Size(58, 17);
            this.rbPrivate.TabIndex = 4;
            this.rbPrivate.TabStop = true;
            this.rbPrivate.Text = "Private";
            this.rbPrivate.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(403, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Customer Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Gender:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(107, 100);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(47, 20);
            this.txtAge.TabIndex = 2;
            this.txtAge.Text = "0";
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Age/DOB: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(573, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "mmHg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(536, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Kg(s)";
            // 
            // txtBloodPressure
            // 
            this.txtBloodPressure.Location = new System.Drawing.Point(494, 97);
            this.txtBloodPressure.Name = "txtBloodPressure";
            this.txtBloodPressure.Size = new System.Drawing.Size(73, 20);
            this.txtBloodPressure.TabIndex = 6;
            this.txtBloodPressure.Text = "0";
            this.txtBloodPressure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBloodPressure_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Blood Pressure:";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.AliceBlue;
            this.txtWeight.Location = new System.Drawing.Point(494, 44);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(36, 20);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(403, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Weight: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(188, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 21);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search (F3)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMobile.Location = new System.Drawing.Point(107, 73);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(153, 20);
            this.txtMobile.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mobile:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPatientName.Location = new System.Drawing.Point(107, 47);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(153, 20);
            this.txtPatientName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Patient Name:";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(107, 21);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(75, 20);
            this.txtPatientId.TabIndex = 1;
            this.txtPatientId.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Patient ID# :";
            // 
            // gvPatientList
            // 
            this.gvPatientList.AllowUserToAddRows = false;
            this.gvPatientList.AllowUserToDeleteRows = false;
            this.gvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientId,
            this.gvPatientName,
            this.gvPatientAge,
            this.gvPatientGender,
            this.gvPatientCNIC,
            this.gvPatientMobile,
            this.gvPatientFatherName});
            this.gvPatientList.Location = new System.Drawing.Point(381, 3);
            this.gvPatientList.MultiSelect = false;
            this.gvPatientList.Name = "gvPatientList";
            this.gvPatientList.ReadOnly = true;
            this.gvPatientList.RowHeadersVisible = false;
            this.gvPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPatientList.Size = new System.Drawing.Size(131, 55);
            this.gvPatientList.TabIndex = 27;
            this.gvPatientList.Visible = false;
            this.gvPatientList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPatientList_RowEnter);
            this.gvPatientList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvPatientList_KeyDown);
            // 
            // PatientId
            // 
            this.PatientId.DataPropertyName = "id";
            this.PatientId.HeaderText = "Id";
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            // 
            // gvPatientName
            // 
            this.gvPatientName.DataPropertyName = "fullName";
            this.gvPatientName.HeaderText = "Patient Name ";
            this.gvPatientName.Name = "gvPatientName";
            this.gvPatientName.ReadOnly = true;
            // 
            // gvPatientAge
            // 
            this.gvPatientAge.DataPropertyName = "age";
            this.gvPatientAge.HeaderText = "DOB/Age";
            this.gvPatientAge.Name = "gvPatientAge";
            this.gvPatientAge.ReadOnly = true;
            // 
            // gvPatientGender
            // 
            this.gvPatientGender.DataPropertyName = "gender";
            this.gvPatientGender.HeaderText = "Gender";
            this.gvPatientGender.Name = "gvPatientGender";
            this.gvPatientGender.ReadOnly = true;
            // 
            // gvPatientCNIC
            // 
            this.gvPatientCNIC.DataPropertyName = "CNIC";
            this.gvPatientCNIC.HeaderText = "CNIC";
            this.gvPatientCNIC.Name = "gvPatientCNIC";
            this.gvPatientCNIC.ReadOnly = true;
            // 
            // gvPatientMobile
            // 
            this.gvPatientMobile.DataPropertyName = "mobileNumber";
            this.gvPatientMobile.HeaderText = "Mobile";
            this.gvPatientMobile.Name = "gvPatientMobile";
            this.gvPatientMobile.ReadOnly = true;
            // 
            // gvPatientFatherName
            // 
            this.gvPatientFatherName.HeaderText = "Father Name";
            this.gvPatientFatherName.Name = "gvPatientFatherName";
            this.gvPatientFatherName.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.RoyalBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 11);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(10);
            this.label13.Size = new System.Drawing.Size(630, 40);
            this.label13.TabIndex = 0;
            this.label13.Text = "Patient Bill";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.AutoSize = true;
            this.btnNewInvoice.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewInvoice.Location = new System.Drawing.Point(64, 19);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(85, 25);
            this.btnNewInvoice.TabIndex = 0;
            this.btnNewInvoice.Text = "New Invoice";
            this.btnNewInvoice.UseVisualStyleBackColor = false;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.AutoSize = true;
            this.btnSaveInvoice.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveInvoice.Location = new System.Drawing.Point(161, 19);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(85, 25);
            this.btnSaveInvoice.TabIndex = 1;
            this.btnSaveInvoice.Text = "Save Invoice";
            this.btnSaveInvoice.UseVisualStyleBackColor = false;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.AutoSize = true;
            this.btnPrintInvoice.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintInvoice.Location = new System.Drawing.Point(355, 19);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(85, 25);
            this.btnPrintInvoice.TabIndex = 3;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(452, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnPrintInvoice);
            this.groupBox3.Controls.Add(this.btnSaveInvoice);
            this.groupBox3.Controls.Add(this.btnNewInvoice);
            this.groupBox3.Location = new System.Drawing.Point(16, 476);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 56);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtRemarks);
            this.groupBox4.Location = new System.Drawing.Point(16, 361);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 115);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(16, 19);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(282, 89);
            this.txtRemarks.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(52, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "Gross:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(32, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "Discount:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(187, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 20);
            this.label20.TabIndex = 37;
            this.label20.Text = "%Disc:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 118);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 20);
            this.label21.TabIndex = 38;
            this.label21.Text = "Bill Amount:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(64, 160);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 20);
            this.label23.TabIndex = 40;
            this.label23.Text = "Paid:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(41, 202);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 20);
            this.label24.TabIndex = 41;
            this.label24.Text = "Balance:";
            // 
            // txtPaidAmmount
            // 
            this.txtPaidAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmmount.Location = new System.Drawing.Point(111, 157);
            this.txtPaidAmmount.MaxLength = 7;
            this.txtPaidAmmount.Name = "txtPaidAmmount";
            this.txtPaidAmmount.Size = new System.Drawing.Size(128, 26);
            this.txtPaidAmmount.TabIndex = 2;
            this.txtPaidAmmount.Text = "0";
            this.txtPaidAmmount.TextChanged += new System.EventHandler(this.txtPaidAmmount_TextChanged);
            this.txtPaidAmmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmmount_KeyDown);
            this.txtPaidAmmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmmount_KeyPress);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(111, 73);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(60, 26);
            this.txtDiscount.TabIndex = 0;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // txtDiscountInPercentage
            // 
            this.txtDiscountInPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountInPercentage.Location = new System.Drawing.Point(248, 73);
            this.txtDiscountInPercentage.Name = "txtDiscountInPercentage";
            this.txtDiscountInPercentage.Size = new System.Drawing.Size(50, 26);
            this.txtDiscountInPercentage.TabIndex = 1;
            this.txtDiscountInPercentage.Text = "0";
            this.txtDiscountInPercentage.TextChanged += new System.EventHandler(this.txtDiscountInPercentage_TextChanged);
            this.txtDiscountInPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountInPercentage_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(114, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 23);
            this.label22.TabIndex = 44;
            this.label22.Text = "Rs.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(114, 115);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 23);
            this.label25.TabIndex = 45;
            this.label25.Text = "Rs.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblGross);
            this.groupBox5.Controls.Add(this.lblBanalce);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.lblBillAmmount);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.txtDiscountInPercentage);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.txtDiscount);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.txtPaidAmmount);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(330, 228);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 248);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "B I L L";
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.ForeColor = System.Drawing.Color.Black;
            this.lblGross.Location = new System.Drawing.Point(160, 31);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(22, 23);
            this.lblGross.TabIndex = 50;
            this.lblGross.Text = "0";
            this.lblGross.TextChanged += new System.EventHandler(this.lblGross_TextChanged);
            // 
            // lblBanalce
            // 
            this.lblBanalce.AutoSize = true;
            this.lblBanalce.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanalce.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBanalce.Location = new System.Drawing.Point(163, 199);
            this.lblBanalce.Name = "lblBanalce";
            this.lblBanalce.Size = new System.Drawing.Size(24, 23);
            this.lblBanalce.TabIndex = 49;
            this.lblBanalce.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DarkGreen;
            this.label27.Location = new System.Drawing.Point(114, 199);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(43, 23);
            this.label27.TabIndex = 48;
            this.label27.Text = "Rs.";
            // 
            // lblBillAmmount
            // 
            this.lblBillAmmount.AutoSize = true;
            this.lblBillAmmount.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAmmount.ForeColor = System.Drawing.Color.Red;
            this.lblBillAmmount.Location = new System.Drawing.Point(163, 115);
            this.lblBillAmmount.Name = "lblBillAmmount";
            this.lblBillAmmount.Size = new System.Drawing.Size(24, 23);
            this.lblBillAmmount.TabIndex = 47;
            this.lblBillAmmount.Text = "0";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(258, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 25);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbBloodGroup.Location = new System.Drawing.Point(494, 71);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(73, 21);
            this.cmbBloodGroup.TabIndex = 38;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 544);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gvPatientList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPatientDetail);
            this.Controls.Add(this.label13);
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paient Bill";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbPatientDetail.ResumeLayout(false);
            this.gbPatientDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbPatientDetail;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gvPatientList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBloodPressure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbPrivate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbDoctorCategory;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblBanalce;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblBillAmmount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDiscountInPercentage;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtPaidAmmount;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientFatherName;
        private System.Windows.Forms.TextBox txtHight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
    }
}