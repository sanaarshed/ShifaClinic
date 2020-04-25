namespace ShifaClinic.Patient
{
    partial class frmCheckupAndPriscriptionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.txtSuggestedMedicine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoBeforeSleep = new System.Windows.Forms.RadioButton();
            this.rdoOnceADay = new System.Windows.Forms.RadioButton();
            this.rdoAfterMeal = new System.Windows.Forms.RadioButton();
            this.rdoMorningEvening = new System.Windows.Forms.RadioButton();
            this.rdoBeforeMeal = new System.Windows.Forms.RadioButton();
            this.rdoMorningANEvening = new System.Windows.Forms.RadioButton();
            this.rdoMorningFasting = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.gbPatientDetail = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBloodPressureLower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
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
            this.dgvMedicineList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbPatientDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Snow;
            this.btnSearch.Location = new System.Drawing.Point(178, 83);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 43);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMedicineName);
            this.groupBox2.Controls.Add(this.btnAddMedicine);
            this.groupBox2.Controls.Add(this.txtSuggestedMedicine);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(24, 247);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1313, 389);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicine Detail";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.Location = new System.Drawing.Point(190, 30);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(706, 39);
            this.txtMedicineName.TabIndex = 0;
            this.txtMedicineName.TextChanged += new System.EventHandler(this.txtMedicineName_TextChanged);
            this.txtMedicineName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMedicineName_KeyDown);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.AutoSize = true;
            this.btnAddMedicine.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddMedicine.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.ForeColor = System.Drawing.Color.Snow;
            this.btnAddMedicine.Location = new System.Drawing.Point(890, 30);
            this.btnAddMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(141, 39);
            this.btnAddMedicine.TabIndex = 1;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            // 
            // txtSuggestedMedicine
            // 
            this.txtSuggestedMedicine.Location = new System.Drawing.Point(30, 84);
            this.txtSuggestedMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSuggestedMedicine.Multiline = true;
            this.txtSuggestedMedicine.Name = "txtSuggestedMedicine";
            this.txtSuggestedMedicine.Size = new System.Drawing.Size(1001, 286);
            this.txtSuggestedMedicine.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Suggested Medicine :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoBeforeSleep);
            this.groupBox5.Controls.Add(this.rdoOnceADay);
            this.groupBox5.Controls.Add(this.rdoAfterMeal);
            this.groupBox5.Controls.Add(this.rdoMorningEvening);
            this.groupBox5.Controls.Add(this.rdoBeforeMeal);
            this.groupBox5.Controls.Add(this.rdoMorningANEvening);
            this.groupBox5.Controls.Add(this.rdoMorningFasting);
            this.groupBox5.Location = new System.Drawing.Point(1039, 30);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(255, 340);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Frequency";
            // 
            // rdoBeforeSleep
            // 
            this.rdoBeforeSleep.AutoSize = true;
            this.rdoBeforeSleep.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBeforeSleep.Location = new System.Drawing.Point(46, 277);
            this.rdoBeforeSleep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoBeforeSleep.Name = "rdoBeforeSleep";
            this.rdoBeforeSleep.Size = new System.Drawing.Size(148, 34);
            this.rdoBeforeSleep.TabIndex = 6;
            this.rdoBeforeSleep.TabStop = true;
            this.rdoBeforeSleep.Text = "سونے سے پہلے";
            this.rdoBeforeSleep.UseVisualStyleBackColor = true;
            this.rdoBeforeSleep.Enter += new System.EventHandler(this.rdoBeforeSleep_Enter);
            this.rdoBeforeSleep.Leave += new System.EventHandler(this.rdoBeforeSleep_Leave);
            // 
            // rdoOnceADay
            // 
            this.rdoOnceADay.AutoSize = true;
            this.rdoOnceADay.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOnceADay.Location = new System.Drawing.Point(46, 31);
            this.rdoOnceADay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoOnceADay.Name = "rdoOnceADay";
            this.rdoOnceADay.Size = new System.Drawing.Size(172, 34);
            this.rdoOnceADay.TabIndex = 0;
            this.rdoOnceADay.TabStop = true;
            this.rdoOnceADay.Text = "دن میں ایک دفع";
            this.rdoOnceADay.UseVisualStyleBackColor = true;
            this.rdoOnceADay.Enter += new System.EventHandler(this.rdoOnceADay_Enter);
            this.rdoOnceADay.Leave += new System.EventHandler(this.rdoOnceADay_Leave);
            // 
            // rdoAfterMeal
            // 
            this.rdoAfterMeal.AutoSize = true;
            this.rdoAfterMeal.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAfterMeal.Location = new System.Drawing.Point(46, 236);
            this.rdoAfterMeal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoAfterMeal.Name = "rdoAfterMeal";
            this.rdoAfterMeal.Size = new System.Drawing.Size(132, 34);
            this.rdoAfterMeal.TabIndex = 5;
            this.rdoAfterMeal.TabStop = true;
            this.rdoAfterMeal.Text = "کہانے کے بعد";
            this.rdoAfterMeal.UseVisualStyleBackColor = true;
            this.rdoAfterMeal.Enter += new System.EventHandler(this.rdoAfterMeal_Enter);
            this.rdoAfterMeal.Leave += new System.EventHandler(this.rdoAfterMeal_Leave);
            // 
            // rdoMorningEvening
            // 
            this.rdoMorningEvening.AutoSize = true;
            this.rdoMorningEvening.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMorningEvening.Location = new System.Drawing.Point(48, 72);
            this.rdoMorningEvening.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoMorningEvening.Name = "rdoMorningEvening";
            this.rdoMorningEvening.Size = new System.Drawing.Size(123, 34);
            this.rdoMorningEvening.TabIndex = 1;
            this.rdoMorningEvening.TabStop = true;
            this.rdoMorningEvening.Text = " صبح، شام";
            this.rdoMorningEvening.UseVisualStyleBackColor = true;
            this.rdoMorningEvening.Enter += new System.EventHandler(this.rdoMorningEvening_Enter);
            this.rdoMorningEvening.Leave += new System.EventHandler(this.rdoMorningEvening_Leave);
            // 
            // rdoBeforeMeal
            // 
            this.rdoBeforeMeal.AutoSize = true;
            this.rdoBeforeMeal.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBeforeMeal.Location = new System.Drawing.Point(46, 195);
            this.rdoBeforeMeal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoBeforeMeal.Name = "rdoBeforeMeal";
            this.rdoBeforeMeal.Size = new System.Drawing.Size(146, 34);
            this.rdoBeforeMeal.TabIndex = 4;
            this.rdoBeforeMeal.TabStop = true;
            this.rdoBeforeMeal.Text = "کہانے سے پہلے";
            this.rdoBeforeMeal.UseVisualStyleBackColor = true;
            this.rdoBeforeMeal.Enter += new System.EventHandler(this.rdoBeforeMeal_Enter);
            this.rdoBeforeMeal.Leave += new System.EventHandler(this.rdoBeforeMeal_Leave);
            // 
            // rdoMorningANEvening
            // 
            this.rdoMorningANEvening.AutoSize = true;
            this.rdoMorningANEvening.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMorningANEvening.Location = new System.Drawing.Point(48, 113);
            this.rdoMorningANEvening.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoMorningANEvening.Name = "rdoMorningANEvening";
            this.rdoMorningANEvening.Size = new System.Drawing.Size(173, 34);
            this.rdoMorningANEvening.TabIndex = 2;
            this.rdoMorningANEvening.TabStop = true;
            this.rdoMorningANEvening.Text = "صبح،دوپہر، شام\r\n";
            this.rdoMorningANEvening.UseVisualStyleBackColor = true;
            this.rdoMorningANEvening.Enter += new System.EventHandler(this.rdoMorningANEvening_Enter);
            this.rdoMorningANEvening.Leave += new System.EventHandler(this.rdoMorningANEvening_Leave);
            // 
            // rdoMorningFasting
            // 
            this.rdoMorningFasting.AutoSize = true;
            this.rdoMorningFasting.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMorningFasting.Location = new System.Drawing.Point(48, 154);
            this.rdoMorningFasting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoMorningFasting.Name = "rdoMorningFasting";
            this.rdoMorningFasting.Size = new System.Drawing.Size(158, 34);
            this.rdoMorningFasting.TabIndex = 3;
            this.rdoMorningFasting.TabStop = true;
            this.rdoMorningFasting.Text = "صبح خالی پیٹ";
            this.rdoMorningFasting.UseVisualStyleBackColor = true;
            this.rdoMorningFasting.Enter += new System.EventHandler(this.rdoMorningFasting_Enter);
            this.rdoMorningFasting.Leave += new System.EventHandler(this.rdoMorningFasting_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtBillId
            // 
            this.txtBillId.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillId.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBillId.Location = new System.Drawing.Point(25, 83);
            this.txtBillId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(155, 43);
            this.txtBillId.TabIndex = 0;
            this.txtBillId.Text = "Enter Bill ID";
            // 
            // gbPatientDetail
            // 
            this.gbPatientDetail.Controls.Add(this.textBox3);
            this.gbPatientDetail.Controls.Add(this.textBox2);
            this.gbPatientDetail.Controls.Add(this.textBox1);
            this.gbPatientDetail.Controls.Add(this.txtBloodPressureLower);
            this.gbPatientDetail.Controls.Add(this.label1);
            this.gbPatientDetail.Controls.Add(this.label3);
            this.gbPatientDetail.Controls.Add(this.txtHight);
            this.gbPatientDetail.Controls.Add(this.label6);
            this.gbPatientDetail.Controls.Add(this.label4);
            this.gbPatientDetail.Controls.Add(this.txtPatientId);
            this.gbPatientDetail.Controls.Add(this.label26);
            this.gbPatientDetail.Controls.Add(this.label7);
            this.gbPatientDetail.Controls.Add(this.panel1);
            this.gbPatientDetail.Controls.Add(this.label8);
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
            this.gbPatientDetail.Location = new System.Drawing.Point(268, 55);
            this.gbPatientDetail.Name = "gbPatientDetail";
            this.gbPatientDetail.Size = new System.Drawing.Size(1069, 184);
            this.gbPatientDetail.TabIndex = 21;
            this.gbPatientDetail.TabStop = false;
            this.gbPatientDetail.Text = "Patient Info";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(138, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(201, 29);
            this.textBox3.TabIndex = 69;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(138, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(428, 29);
            this.textBox2.TabIndex = 68;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(667, 135);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(47, 27);
            this.textBox1.TabIndex = 67;
            this.textBox1.Text = "0";
            // 
            // txtBloodPressureLower
            // 
            this.txtBloodPressureLower.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodPressureLower.Location = new System.Drawing.Point(928, 103);
            this.txtBloodPressureLower.MaxLength = 4;
            this.txtBloodPressureLower.Name = "txtBloodPressureLower";
            this.txtBloodPressureLower.ReadOnly = true;
            this.txtBloodPressureLower.Size = new System.Drawing.Size(73, 27);
            this.txtBloodPressureLower.TabIndex = 65;
            this.txtBloodPressureLower.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1085, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Lower";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(718, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Inches";
            // 
            // txtHight
            // 
            this.txtHight.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHight.Location = new System.Drawing.Point(667, 24);
            this.txtHight.MaxLength = 4;
            this.txtHight.Name = "txtHight";
            this.txtHight.ReadOnly = true;
            this.txtHight.Size = new System.Drawing.Size(49, 27);
            this.txtHight.TabIndex = 9;
            this.txtHight.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Patient ID# :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 63;
            this.label4.Text = "Height:";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.Location = new System.Drawing.Point(138, 21);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(75, 27);
            this.txtPatientId.TabIndex = 12;
            this.txtPatientId.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(560, 138);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 21);
            this.label26.TabIndex = 61;
            this.label26.Text = "Blood Group:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "Patient Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(667, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 29);
            this.panel1.TabIndex = 8;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(3, 3);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 25);
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
            this.rbFemale.Size = new System.Drawing.Size(78, 25);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 49;
            this.label8.Text = "Mobile:";
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStaff.Location = new System.Drawing.Point(510, 22);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(59, 25);
            this.rbStaff.TabIndex = 3;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(586, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 52;
            this.label10.Text = "Weight: ";
            // 
            // rbPrivate
            // 
            this.rbPrivate.AutoSize = true;
            this.rbPrivate.Checked = true;
            this.rbPrivate.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrivate.Location = new System.Drawing.Point(418, 22);
            this.rbPrivate.Name = "rbPrivate";
            this.rbPrivate.Size = new System.Drawing.Size(76, 25);
            this.rbPrivate.TabIndex = 2;
            this.rbPrivate.TabStop = true;
            this.rbPrivate.Text = "Private";
            this.rbPrivate.UseVisualStyleBackColor = true;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(667, 63);
            this.txtWeight.MaxLength = 4;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(36, 27);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(262, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 21);
            this.label16.TabIndex = 58;
            this.label16.Text = "Customer Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(923, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 53;
            this.label9.Text = "Blood Pressure";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(588, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 21);
            this.label15.TabIndex = 57;
            this.label15.Text = "Gender:";
            // 
            // txtBloodPressureUpper
            // 
            this.txtBloodPressureUpper.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodPressureUpper.Location = new System.Drawing.Point(928, 61);
            this.txtBloodPressureUpper.MaxLength = 4;
            this.txtBloodPressureUpper.Name = "txtBloodPressureUpper";
            this.txtBloodPressureUpper.ReadOnly = true;
            this.txtBloodPressureUpper.Size = new System.Drawing.Size(73, 27);
            this.txtBloodPressureUpper.TabIndex = 10;
            this.txtBloodPressureUpper.Text = "0";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(456, 101);
            this.txtAge.MaxLength = 4;
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(47, 27);
            this.txtAge.TabIndex = 6;
            this.txtAge.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(707, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 21);
            this.label11.TabIndex = 54;
            this.label11.Text = "Kg(s)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(359, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 21);
            this.label14.TabIndex = 56;
            this.label14.Text = "Age/DOB:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1085, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 21);
            this.label12.TabIndex = 55;
            this.label12.Text = "Upper";
            // 
            // dgvMedicineList
            // 
            this.dgvMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicineList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMedicineList.Location = new System.Drawing.Point(106, 181);
            this.dgvMedicineList.MultiSelect = false;
            this.dgvMedicineList.Name = "dgvMedicineList";
            this.dgvMedicineList.RowHeadersVisible = false;
            this.dgvMedicineList.RowHeadersWidth = 45;
            this.dgvMedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicineList.Size = new System.Drawing.Size(110, 58);
            this.dgvMedicineList.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(1);
            this.label5.Size = new System.Drawing.Size(1350, 40);
            this.label5.TabIndex = 31;
            this.label5.Text = "Doctor Prescription";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 684);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 43);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.btnNew.Size = new System.Drawing.Size(444, 37);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(453, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(444, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "&SAVE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(903, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(444, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Close";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmCheckupAndPriscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMedicineList);
            this.Controls.Add(this.gbPatientDetail);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBillId);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCheckupAndPriscriptionForm";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.frmCheckupAndPriscriptionForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbPatientDetail.ResumeLayout(false);
            this.gbPatientDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.TextBox txtSuggestedMedicine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoMorningEvening;
        private System.Windows.Forms.RadioButton rdoMorningANEvening;
        private System.Windows.Forms.RadioButton rdoMorningFasting;
        private System.Windows.Forms.RadioButton rdoBeforeMeal;
        private System.Windows.Forms.RadioButton rdoOnceADay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoBeforeSleep;
        private System.Windows.Forms.RadioButton rdoAfterMeal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.GroupBox gbPatientDetail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBloodPressureLower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbPrivate;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBloodPressureUpper;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.DataGridView dgvMedicineList;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNew;
    }
}