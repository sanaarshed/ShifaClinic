namespace ShifaClinic.Session
{
    partial class frmDashboardForm
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
            this.formError = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.stsmiDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsmiInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatientInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoctorsClosingBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatientsList = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.formError)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formError
            // 
            this.formError.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiPatientInvoice,
            this.tsmiDoctorsClosingBook,
            this.tsmiProfile,
            this.tsmiLogout,
            this.tsmiUsers,
            this.tsmiDoctors,
            this.tsmiPatientsList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPatients,
            this.stsmiInvoice,
            this.stsmiDoctors,
            this.employeeToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // tsmiPatients
            // 
            this.tsmiPatients.Name = "tsmiPatients";
            this.tsmiPatients.Size = new System.Drawing.Size(180, 22);
            this.tsmiPatients.Text = "Patient";
            this.tsmiPatients.Click += new System.EventHandler(this.tsmiPatients_Click);
            // 
            // stsmiDoctors
            // 
            this.stsmiDoctors.Name = "stsmiDoctors";
            this.stsmiDoctors.Size = new System.Drawing.Size(180, 22);
            this.stsmiDoctors.Text = "Doctor";
            this.stsmiDoctors.Click += new System.EventHandler(this.stsmiDoctors_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // stsmiInvoice
            // 
            this.stsmiInvoice.Name = "stsmiInvoice";
            this.stsmiInvoice.Size = new System.Drawing.Size(180, 22);
            this.stsmiInvoice.Text = "In&voice";
            this.stsmiInvoice.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorRecordToolStripMenuItem,
            this.patientRecordToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // doctorRecordToolStripMenuItem
            // 
            this.doctorRecordToolStripMenuItem.Name = "doctorRecordToolStripMenuItem";
            this.doctorRecordToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.doctorRecordToolStripMenuItem.Text = "Doctor Record";
            // 
            // patientRecordToolStripMenuItem
            // 
            this.patientRecordToolStripMenuItem.Name = "patientRecordToolStripMenuItem";
            this.patientRecordToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.patientRecordToolStripMenuItem.Text = "Patient Record";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(39, 20);
            this.tsmiEdit.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // tsmiPatientInvoice
            // 
            this.tsmiPatientInvoice.Name = "tsmiPatientInvoice";
            this.tsmiPatientInvoice.Size = new System.Drawing.Size(97, 20);
            this.tsmiPatientInvoice.Text = "Patient Invoice";
            this.tsmiPatientInvoice.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // tsmiDoctorsClosingBook
            // 
            this.tsmiDoctorsClosingBook.Name = "tsmiDoctorsClosingBook";
            this.tsmiDoctorsClosingBook.Size = new System.Drawing.Size(133, 20);
            this.tsmiDoctorsClosingBook.Text = "Doctors Closing Book";
            this.tsmiDoctorsClosingBook.Click += new System.EventHandler(this.tsmiDoctorsClosingBook_Click);
            // 
            // tsmiProfile
            // 
            this.tsmiProfile.Name = "tsmiProfile";
            this.tsmiProfile.Size = new System.Drawing.Size(53, 20);
            this.tsmiProfile.Text = "Profile";
            this.tsmiProfile.Click += new System.EventHandler(this.tsmiProfile_Click);
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(54, 20);
            this.tsmiLogout.Text = "logout";
            this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(50, 20);
            this.tsmiUsers.Text = "Users ";
            this.tsmiUsers.Click += new System.EventHandler(this.tsmiUsers_Click);
            // 
            // tsmiDoctors
            // 
            this.tsmiDoctors.Name = "tsmiDoctors";
            this.tsmiDoctors.Size = new System.Drawing.Size(63, 20);
            this.tsmiDoctors.Text = "Doctors ";
            this.tsmiDoctors.Click += new System.EventHandler(this.tsmiDoctors_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addUserToolStripMenuItem.Text = " ";
            // 
            // tsmiPatientsList
            // 
            this.tsmiPatientsList.Name = "tsmiPatientsList";
            this.tsmiPatientsList.Size = new System.Drawing.Size(85, 20);
            this.tsmiPatientsList.Text = "Patient\'s List";
            this.tsmiPatientsList.Click += new System.EventHandler(this.tsmiPatientsList_Click);
            // 
            // frmDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 530);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashboardForm";
            this.Text = "ShifaClinic";
            this.Load += new System.EventHandler(this.frmDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formError)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider formError;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientInvoice;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoctorsClosingBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatients;
        private System.Windows.Forms.ToolStripMenuItem stsmiDoctors;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stsmiInvoice;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoctors;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientsList;
    }
}