﻿namespace GOCSystem2018
{
    partial class frmPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtORNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountGiven = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPaymentFor = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvPerMonth = new System.Windows.Forms.DataGridView();
            this.PaymentMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPerMonthAdv = new System.Windows.Forms.Label();
            this.lblCalc = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblpayNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTheAmount = new System.Windows.Forms.Label();
            this.lblEnStatus = new System.Windows.Forms.Label();
            this.lblAmount_Due = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblGOCNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLRN = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPAYFOR = new System.Windows.Forms.Label();
            this.dgvORCheck = new System.Windows.Forms.DataGridView();
            this.dgvORCheckPartial = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerMonth)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORCheckPartial)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(427, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 16);
            this.label12.TabIndex = 1024;
            this.label12.Text = "X";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.label18.Location = new System.Drawing.Point(12, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 25);
            this.label18.TabIndex = 1020;
            this.label18.Text = "Payment";
            // 
            // txtORNo
            // 
            this.txtORNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtORNo.Location = new System.Drawing.Point(16, 161);
            this.txtORNo.Name = "txtORNo";
            this.txtORNo.Size = new System.Drawing.Size(412, 24);
            this.txtORNo.TabIndex = 1;
            this.txtORNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtORNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1035;
            this.label2.Text = "Summary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 399);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1037;
            this.label1.Text = "Amount Tendered:";
            // 
            // txtAmountGiven
            // 
            this.txtAmountGiven.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountGiven.Location = new System.Drawing.Point(11, 6);
            this.txtAmountGiven.Name = "txtAmountGiven";
            this.txtAmountGiven.Size = new System.Drawing.Size(433, 31);
            this.txtAmountGiven.TabIndex = 2;
            this.txtAmountGiven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountGiven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountGiven_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 1039;
            this.label4.Text = "Amount Due:";
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(617, 234);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(146, 31);
            this.btnProcess.TabIndex = 1040;
            this.btnProcess.Text = "&Confirm Amount";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(613, 163);
            this.lblAmountDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(150, 20);
            this.lblAmountDue.TabIndex = 1041;
            this.lblAmountDue.Text = "0.00";
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(549, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 1042;
            this.label5.Text = "Payment For:";
            // 
            // lblPaymentFor
            // 
            this.lblPaymentFor.AutoSize = true;
            this.lblPaymentFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentFor.Location = new System.Drawing.Point(660, 128);
            this.lblPaymentFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentFor.Name = "lblPaymentFor";
            this.lblPaymentFor.Size = new System.Drawing.Size(103, 20);
            this.lblPaymentFor.TabIndex = 1043;
            this.lblPaymentFor.Text = "Payment For:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPerMonth);
            this.groupBox4.Location = new System.Drawing.Point(780, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 342);
            this.groupBox4.TabIndex = 1048;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Breakdown for Partial Payment";
            // 
            // dgvPerMonth
            // 
            this.dgvPerMonth.AllowUserToAddRows = false;
            this.dgvPerMonth.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvPerMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPerMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentMonth,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerMonth.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPerMonth.GridColor = System.Drawing.Color.White;
            this.dgvPerMonth.Location = new System.Drawing.Point(-39, 15);
            this.dgvPerMonth.Name = "dgvPerMonth";
            this.dgvPerMonth.ReadOnly = true;
            this.dgvPerMonth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerMonth.Size = new System.Drawing.Size(342, 321);
            this.dgvPerMonth.TabIndex = 1014;
            // 
            // PaymentMonth
            // 
            this.PaymentMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PaymentMonth.HeaderText = "Payment Month";
            this.PaymentMonth.Name = "PaymentMonth";
            this.PaymentMonth.ReadOnly = true;
            this.PaymentMonth.Width = 97;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Payment  No.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 68;
            // 
            // lblPerMonthAdv
            // 
            this.lblPerMonthAdv.AutoSize = true;
            this.lblPerMonthAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerMonthAdv.Location = new System.Drawing.Point(670, 323);
            this.lblPerMonthAdv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerMonthAdv.Name = "lblPerMonthAdv";
            this.lblPerMonthAdv.Size = new System.Drawing.Size(103, 20);
            this.lblPerMonthAdv.TabIndex = 1049;
            this.lblPerMonthAdv.Text = "Payment For:";
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalc.Location = new System.Drawing.Point(670, 81);
            this.lblCalc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(103, 20);
            this.lblCalc.TabIndex = 1050;
            this.lblCalc.Text = "Payment For:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(156, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 47);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Confirm Amount";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblpayNumber
            // 
            this.lblpayNumber.AutoSize = true;
            this.lblpayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayNumber.Location = new System.Drawing.Point(660, 22);
            this.lblpayNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpayNumber.Name = "lblpayNumber";
            this.lblpayNumber.Size = new System.Drawing.Size(103, 20);
            this.lblpayNumber.TabIndex = 1052;
            this.lblpayNumber.Text = "Payment For:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(515, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 1053;
            this.label6.Text = "Remaining Balance";
            // 
            // lblTheAmount
            // 
            this.lblTheAmount.AutoSize = true;
            this.lblTheAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheAmount.Location = new System.Drawing.Point(641, 283);
            this.lblTheAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheAmount.Name = "lblTheAmount";
            this.lblTheAmount.Size = new System.Drawing.Size(122, 24);
            this.lblTheAmount.TabIndex = 1054;
            this.lblTheAmount.Text = "Payment For:";
            this.lblTheAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnStatus
            // 
            this.lblEnStatus.AutoSize = true;
            this.lblEnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnStatus.Location = new System.Drawing.Point(660, 211);
            this.lblEnStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnStatus.Name = "lblEnStatus";
            this.lblEnStatus.Size = new System.Drawing.Size(91, 20);
            this.lblEnStatus.TabIndex = 1055;
            this.lblEnStatus.Text = "lblEnStatus";
            // 
            // lblAmount_Due
            // 
            this.lblAmount_Due.AutoSize = true;
            this.lblAmount_Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount_Due.ForeColor = System.Drawing.Color.White;
            this.lblAmount_Due.Location = new System.Drawing.Point(364, 10);
            this.lblAmount_Due.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount_Due.Name = "lblAmount_Due";
            this.lblAmount_Due.Size = new System.Drawing.Size(64, 25);
            this.lblAmount_Due.TabIndex = 1056;
            this.lblAmount_Due.Text = "2000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtAmountGiven);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 45);
            this.panel1.TabIndex = 1057;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1058;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(87)))));
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lblRegNo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(16, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 25);
            this.panel3.TabIndex = 1058;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.label13.Location = new System.Drawing.Point(106, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 1072;
            this.label13.Text = "Registration No:";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.lblRegNo.Location = new System.Drawing.Point(230, 5);
            this.lblRegNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(157, 13);
            this.lblRegNo.TabIndex = 1073;
            this.lblRegNo.Text = "_________________________";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(87)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.lblAmount_Due);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(2, 351);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 45);
            this.panel4.TabIndex = 1059;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(13, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 1060;
            this.label7.Text = "Receipt number:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.label15.Location = new System.Drawing.Point(29, 209);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 1074;
            this.label15.Text = "LRN:";
            // 
            // lblGOCNo
            // 
            this.lblGOCNo.AutoSize = true;
            this.lblGOCNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.lblGOCNo.Location = new System.Drawing.Point(153, 237);
            this.lblGOCNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGOCNo.Name = "lblGOCNo";
            this.lblGOCNo.Size = new System.Drawing.Size(115, 13);
            this.lblGOCNo.TabIndex = 1076;
            this.lblGOCNo.Text = "__________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(29, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1077;
            this.label3.Text = "ID No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(29, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1070;
            this.label8.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.lblName.Location = new System.Drawing.Point(153, 273);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 13);
            this.lblName.TabIndex = 1071;
            this.lblName.Text = "_________________________";
            // 
            // lblLRN
            // 
            this.lblLRN.AutoSize = true;
            this.lblLRN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.lblLRN.Location = new System.Drawing.Point(153, 209);
            this.lblLRN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLRN.Name = "lblLRN";
            this.lblLRN.Size = new System.Drawing.Size(47, 13);
            this.lblLRN.TabIndex = 1075;
            this.lblLRN.Text = "LRN_no";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.label9.Location = new System.Drawing.Point(29, 303);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 1078;
            this.label9.Text = "Payment for:";
            // 
            // lblPAYFOR
            // 
            this.lblPAYFOR.AutoSize = true;
            this.lblPAYFOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.lblPAYFOR.Location = new System.Drawing.Point(153, 303);
            this.lblPAYFOR.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPAYFOR.Name = "lblPAYFOR";
            this.lblPAYFOR.Size = new System.Drawing.Size(157, 13);
            this.lblPAYFOR.TabIndex = 1079;
            this.lblPAYFOR.Text = "_________________________";
            // 
            // dgvORCheck
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvORCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvORCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvORCheck.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvORCheck.Location = new System.Drawing.Point(513, 408);
            this.dgvORCheck.Name = "dgvORCheck";
            this.dgvORCheck.Size = new System.Drawing.Size(139, 150);
            this.dgvORCheck.TabIndex = 1080;
            // 
            // dgvORCheckPartial
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvORCheckPartial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvORCheckPartial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvORCheckPartial.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvORCheckPartial.Location = new System.Drawing.Point(664, 408);
            this.dgvORCheckPartial.Name = "dgvORCheckPartial";
            this.dgvORCheckPartial.Size = new System.Drawing.Size(139, 150);
            this.dgvORCheckPartial.TabIndex = 1081;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(453, 573);
            this.Controls.Add(this.dgvORCheckPartial);
            this.Controls.Add(this.dgvORCheck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPAYFOR);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblGOCNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblLRN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtORNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblEnStatus);
            this.Controls.Add(this.lblTheAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblpayNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.lblPerMonthAdv);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblPaymentFor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerMonth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORCheckPartial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtORNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountGiven;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPaymentFor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvPerMonth;
        private System.Windows.Forms.Label lblPerMonthAdv;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblpayNumber;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblAmountDue;
        public System.Windows.Forms.Label lblTheAmount;
        private System.Windows.Forms.Label lblEnStatus;
        private System.Windows.Forms.Label lblAmount_Due;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblGOCNo;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLRN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPAYFOR;
        private System.Windows.Forms.DataGridView dgvORCheck;
        private System.Windows.Forms.DataGridView dgvORCheckPartial;
    }
}