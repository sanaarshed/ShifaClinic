namespace ShifaClinic.Patient
{
    partial class ListOfPatients
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSearchByName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.label13.Size = new System.Drawing.Size(750, 40);
            this.label13.TabIndex = 18;
            this.label13.Text = "List of Patients";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSearchByName);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 72);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By: Patient Name , Mobile Number, CNIC";
            // 
            // tbSearchByName
            // 
            this.tbSearchByName.Location = new System.Drawing.Point(10, 36);
            this.tbSearchByName.Name = "tbSearchByName";
            this.tbSearchByName.Size = new System.Drawing.Size(235, 20);
            this.tbSearchByName.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Location = new System.Drawing.Point(275, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 72);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(9, 31);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(90, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpTo);
            this.groupBox3.Controls.Add(this.dtpFrom);
            this.groupBox3.Controls.Add(this.btnSearchByDate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(465, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 72);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search By Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.AutoSize = true;
            this.btnSearchByDate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchByDate.Location = new System.Drawing.Point(206, 31);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(75, 25);
            this.btnSearchByDate.TabIndex = 2;
            this.btnSearchByDate.Text = "Search";
            this.btnSearchByDate.UseVisualStyleBackColor = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(6, 36);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(93, 20);
            this.dtpFrom.TabIndex = 5;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(105, 36);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(95, 20);
            this.dtpTo.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 297);
            this.dataGridView1.TabIndex = 21;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListOfPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Name = "ListOfPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListOfPatients";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSearchByName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}