namespace ShifaClinic.Accounts
{
    partial class frmCashInForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt50 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt100 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt500 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1000 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt5000 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dgvCashIn = new System.Windows.Forms.DataGridView();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rs5000 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rs1000 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rs500 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rs100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rs50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rs20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rs10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rs5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rs2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rs1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashIn)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 705);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 43);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(1030, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(336, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(688, 6);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(334, 31);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "&PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(346, 6);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(334, 31);
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
            this.btnNew.Location = new System.Drawing.Point(4, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(334, 31);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.RoyalBlue;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1370, 53);
            this.label13.TabIndex = 24;
            this.label13.Text = "Cash In";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(486, 443);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(101, 29);
            this.txtTotal.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 447);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total Cash:";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.txt1);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.txt2);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.txt5);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.txt10);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.txt20);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.txt50);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.txt100);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.txt500);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txt1000);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.txt5000);
            this.groupBox.Location = new System.Drawing.Point(47, 100);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(540, 325);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "CashIn Details ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(412, 275);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 47;
            this.label10.Text = "1";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(439, 271);
            this.txt1.Margin = new System.Windows.Forms.Padding(4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(63, 29);
            this.txt1.TabIndex = 9;
            this.txt1.Text = "0";
            this.txt1.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(412, 222);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 21);
            this.label11.TabIndex = 45;
            this.label11.Text = "2";
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(439, 218);
            this.txt2.Margin = new System.Windows.Forms.Padding(4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(63, 29);
            this.txt2.TabIndex = 8;
            this.txt2.Text = "0";
            this.txt2.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(412, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 21);
            this.label9.TabIndex = 43;
            this.label9.Text = "5";
            // 
            // txt5
            // 
            this.txt5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt5.Location = new System.Drawing.Point(439, 165);
            this.txt5.Margin = new System.Windows.Forms.Padding(4);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(63, 29);
            this.txt5.TabIndex = 7;
            this.txt5.Text = "0";
            this.txt5.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(403, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 21);
            this.label8.TabIndex = 41;
            this.label8.Text = "10";
            // 
            // txt10
            // 
            this.txt10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt10.Location = new System.Drawing.Point(439, 112);
            this.txt10.Margin = new System.Windows.Forms.Padding(4);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(63, 29);
            this.txt10.TabIndex = 6;
            this.txt10.Text = "0";
            this.txt10.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txt10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "20";
            // 
            // txt20
            // 
            this.txt20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt20.Location = new System.Drawing.Point(439, 59);
            this.txt20.Margin = new System.Windows.Forms.Padding(4);
            this.txt20.Name = "txt20";
            this.txt20.Size = new System.Drawing.Size(63, 29);
            this.txt20.TabIndex = 5;
            this.txt20.Text = "0";
            this.txt20.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txt20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "50";
            // 
            // txt50
            // 
            this.txt50.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt50.Location = new System.Drawing.Point(273, 271);
            this.txt50.Margin = new System.Windows.Forms.Padding(4);
            this.txt50.Name = "txt50";
            this.txt50.Size = new System.Drawing.Size(72, 29);
            this.txt50.TabIndex = 4;
            this.txt50.Text = "0";
            this.txt50.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txt50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "100";
            // 
            // txt100
            // 
            this.txt100.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt100.Location = new System.Drawing.Point(273, 218);
            this.txt100.Margin = new System.Windows.Forms.Padding(4);
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(72, 29);
            this.txt100.TabIndex = 3;
            this.txt100.Text = "0";
            this.txt100.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txt100.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "500";
            // 
            // txt500
            // 
            this.txt500.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt500.Location = new System.Drawing.Point(273, 165);
            this.txt500.Margin = new System.Windows.Forms.Padding(4);
            this.txt500.Name = "txt500";
            this.txt500.Size = new System.Drawing.Size(72, 29);
            this.txt500.TabIndex = 2;
            this.txt500.Text = "0";
            this.txt500.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txt500.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "1000";
            // 
            // txt1000
            // 
            this.txt1000.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1000.Location = new System.Drawing.Point(273, 112);
            this.txt1000.Margin = new System.Windows.Forms.Padding(4);
            this.txt1000.Name = "txt1000";
            this.txt1000.Size = new System.Drawing.Size(72, 29);
            this.txt1000.TabIndex = 1;
            this.txt1000.Text = "0";
            this.txt1000.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txt1000.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "5000";
            // 
            // txt5000
            // 
            this.txt5000.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt5000.Location = new System.Drawing.Point(273, 59);
            this.txt5000.Margin = new System.Windows.Forms.Padding(4);
            this.txt5000.Name = "txt5000";
            this.txt5000.Size = new System.Drawing.Size(72, 29);
            this.txt5000.TabIndex = 0;
            this.txt5000.Text = "0";
            this.txt5000.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txt5000.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Location = new System.Drawing.Point(47, 480);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 189);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(13, 30);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(513, 138);
            this.txtRemarks.TabIndex = 26;
            // 
            // dgvCashIn
            // 
            this.dgvCashIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCashIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalAmount,
            this.Rs5000,
            this.Rs1000,
            this.Rs500,
            this.Rs100,
            this.Rs50,
            this.Rs20,
            this.Rs10,
            this.Rs5,
            this.Rs2,
            this.Rs1,
            this.remarks});
            this.dgvCashIn.Location = new System.Drawing.Point(606, 100);
            this.dgvCashIn.Name = "dgvCashIn";
            this.dgvCashIn.Size = new System.Drawing.Size(752, 569);
            this.dgvCashIn.TabIndex = 49;
            // 
            // totalAmount
            // 
            this.totalAmount.HeaderText = "Total Amount";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Width = 114;
            // 
            // Rs5000
            // 
            this.Rs5000.HeaderText = "5000";
            this.Rs5000.Name = "Rs5000";
            this.Rs5000.Width = 66;
            // 
            // Rs1000
            // 
            this.Rs1000.HeaderText = "1000";
            this.Rs1000.Name = "Rs1000";
            this.Rs1000.Width = 66;
            // 
            // Rs500
            // 
            this.Rs500.HeaderText = "500";
            this.Rs500.Name = "Rs500";
            this.Rs500.Width = 58;
            // 
            // Rs100
            // 
            this.Rs100.HeaderText = "100";
            this.Rs100.Name = "Rs100";
            this.Rs100.Width = 58;
            // 
            // Rs50
            // 
            this.Rs50.HeaderText = "50";
            this.Rs50.Name = "Rs50";
            this.Rs50.Width = 50;
            // 
            // Rs20
            // 
            this.Rs20.HeaderText = "20";
            this.Rs20.Name = "Rs20";
            this.Rs20.Width = 50;
            // 
            // Rs10
            // 
            this.Rs10.HeaderText = "10";
            this.Rs10.Name = "Rs10";
            this.Rs10.Width = 50;
            // 
            // Rs5
            // 
            this.Rs5.HeaderText = "5";
            this.Rs5.Name = "Rs5";
            this.Rs5.Width = 42;
            // 
            // Rs2
            // 
            this.Rs2.HeaderText = "2";
            this.Rs2.Name = "Rs2";
            this.Rs2.Width = 42;
            // 
            // Rs1
            // 
            this.Rs1.HeaderText = "1";
            this.Rs1.Name = "Rs1";
            this.Rs1.Width = 42;
            // 
            // remarks
            // 
            this.remarks.HeaderText = "Remarks";
            this.remarks.Name = "remarks";
            this.remarks.Width = 90;
            // 
            // frmCashInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.dgvCashIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCashInForm";
            this.Text = "frmCashInForm";
            this.Load += new System.EventHandler(this.frmCashInForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt50;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt100;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt500;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1000;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt5000;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.DataGridView dgvCashIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rs5000;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rs1000;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rs500;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rs100;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rs50;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rs20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rs10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rs5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rs2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rs1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
    }
}