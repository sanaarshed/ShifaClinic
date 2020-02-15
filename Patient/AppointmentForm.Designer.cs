namespace ShifaClinic.Patient
{
    partial class AppointmentForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.formError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtPatientINumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAppointment = new System.Windows.Forms.Button();
            this.btnNewAppointment = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientMotherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientHomeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPatientCheckupFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpAppointmentTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpAppointmentTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsultantName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAppointmentNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.formError)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.RoyalBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(10);
            this.label13.Size = new System.Drawing.Size(628, 40);
            this.label13.TabIndex = 19;
            this.label13.Text = "Appointment";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formError
            // 
            this.formError.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Patient Name:";
            // 
            // txtPatientINumber
            // 
            this.txtPatientINumber.Location = new System.Drawing.Point(118, 21);
            this.txtPatientINumber.Name = "txtPatientINumber";
            this.txtPatientINumber.Size = new System.Drawing.Size(75, 20);
            this.txtPatientINumber.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Patient # :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMobileNumber);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCNIC);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPatientINumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(16, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 135);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMobileNumber.Location = new System.Drawing.Point(118, 99);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(170, 20);
            this.txtMobileNumber.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mobile Number :";
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(118, 73);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(170, 20);
            this.txtCNIC.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "CNIC :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPatientName.Location = new System.Drawing.Point(118, 47);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(170, 20);
            this.txtPatientName.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSaveAppointment);
            this.groupBox2.Controls.Add(this.btnNewAppointment);
            this.groupBox2.Location = new System.Drawing.Point(12, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 56);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(398, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSaveAppointment
            // 
            this.btnSaveAppointment.AutoSize = true;
            this.btnSaveAppointment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAppointment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveAppointment.Location = new System.Drawing.Point(268, 19);
            this.btnSaveAppointment.Name = "btnSaveAppointment";
            this.btnSaveAppointment.Size = new System.Drawing.Size(106, 25);
            this.btnSaveAppointment.TabIndex = 1;
            this.btnSaveAppointment.Text = "Save Appointment";
            this.btnSaveAppointment.UseVisualStyleBackColor = false;
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.AutoSize = true;
            this.btnNewAppointment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAppointment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewAppointment.Location = new System.Drawing.Point(159, 19);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Size = new System.Drawing.Size(85, 25);
            this.btnNewAppointment.TabIndex = 0;
            this.btnNewAppointment.Text = "New ";
            this.btnNewAppointment.UseVisualStyleBackColor = false;
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientId,
            this.gvPatientName,
            this.gvPatientAge,
            this.gvPatientGender,
            this.gvPatientCNIC,
            this.gvPatientMobile,
            this.gvPatientFatherName,
            this.gvPatientMotherName,
            this.gvPatientHomeAddress,
            this.gvPatientCheckupFee});
            this.dgvPatients.Location = new System.Drawing.Point(329, 147);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.Size = new System.Drawing.Size(308, 221);
            this.dgvPatients.TabIndex = 28;
            // 
            // PatientId
            // 
            this.PatientId.HeaderText = "Id";
            this.PatientId.Name = "PatientId";
            // 
            // gvPatientName
            // 
            this.gvPatientName.HeaderText = "Patient Name ";
            this.gvPatientName.Name = "gvPatientName";
            // 
            // gvPatientAge
            // 
            this.gvPatientAge.HeaderText = "DOB/Age";
            this.gvPatientAge.Name = "gvPatientAge";
            // 
            // gvPatientGender
            // 
            this.gvPatientGender.HeaderText = "Gender";
            this.gvPatientGender.Name = "gvPatientGender";
            // 
            // gvPatientCNIC
            // 
            this.gvPatientCNIC.HeaderText = "CNIC";
            this.gvPatientCNIC.Name = "gvPatientCNIC";
            // 
            // gvPatientMobile
            // 
            this.gvPatientMobile.HeaderText = "Mobile";
            this.gvPatientMobile.Name = "gvPatientMobile";
            // 
            // gvPatientFatherName
            // 
            this.gvPatientFatherName.HeaderText = "Father Name";
            this.gvPatientFatherName.Name = "gvPatientFatherName";
            // 
            // gvPatientMotherName
            // 
            this.gvPatientMotherName.HeaderText = "Mother Name ";
            this.gvPatientMotherName.Name = "gvPatientMotherName";
            // 
            // gvPatientHomeAddress
            // 
            this.gvPatientHomeAddress.HeaderText = "Home Address";
            this.gvPatientHomeAddress.Name = "gvPatientHomeAddress";
            // 
            // gvPatientCheckupFee
            // 
            this.gvPatientCheckupFee.HeaderText = "Checkup Fee";
            this.gvPatientCheckupFee.Name = "gvPatientCheckupFee";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpAppointmentTimeEnd);
            this.groupBox3.Controls.Add(this.dtpAppointmentTimeStart);
            this.groupBox3.Controls.Add(this.dtpAppointmentDate);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtConsultantName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(16, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 135);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal Info";
            // 
            // dtpAppointmentTimeEnd
            // 
            this.dtpAppointmentTimeEnd.Location = new System.Drawing.Point(118, 99);
            this.dtpAppointmentTimeEnd.Name = "dtpAppointmentTimeEnd";
            this.dtpAppointmentTimeEnd.Size = new System.Drawing.Size(77, 20);
            this.dtpAppointmentTimeEnd.TabIndex = 14;
            // 
            // dtpAppointmentTimeStart
            // 
            this.dtpAppointmentTimeStart.Location = new System.Drawing.Point(118, 73);
            this.dtpAppointmentTimeStart.Name = "dtpAppointmentTimeStart";
            this.dtpAppointmentTimeStart.Size = new System.Drawing.Size(77, 20);
            this.dtpAppointmentTimeStart.TabIndex = 13;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CalendarMonthBackground = System.Drawing.Color.RoyalBlue;
            this.dtpAppointmentDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(118, 47);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(170, 20);
            this.dtpAppointmentDate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "End Time :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Appointment Date:";
            // 
            // txtConsultantName
            // 
            this.txtConsultantName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtConsultantName.Location = new System.Drawing.Point(118, 21);
            this.txtConsultantName.Name = "txtConsultantName";
            this.txtConsultantName.Size = new System.Drawing.Size(170, 20);
            this.txtConsultantName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Consultant Name :";
            // 
            // txtAppointmentNumber
            // 
            this.txtAppointmentNumber.Location = new System.Drawing.Point(123, 67);
            this.txtAppointmentNumber.Name = "txtAppointmentNumber";
            this.txtAppointmentNumber.Size = new System.Drawing.Size(75, 20);
            this.txtAppointmentNumber.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Appointment # :";
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(122, 16);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(180, 20);
            this.txtSearchPatient.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Search Patient :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtSearchPatient);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(329, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 44);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Patient";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtAppointmentNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.formError)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider formError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPatientINumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAppointment;
        private System.Windows.Forms.Button btnNewAppointment;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAppointmentNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTimeEnd;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTimeStart;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsultantName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientMotherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientHomeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPatientCheckupFee;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}