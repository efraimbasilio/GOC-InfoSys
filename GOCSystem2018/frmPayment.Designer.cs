namespace GOCSystem2018
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label136);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label135);
            this.panel2.Controls.Add(this.pictureBox22);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 54);
            this.panel2.TabIndex = 1014;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(399, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 17);
            this.label10.TabIndex = 1025;
            this.label10.Text = "__";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(423, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 1024;
            this.label12.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(564, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 1023;
            this.label3.Text = "label3";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label136.ForeColor = System.Drawing.Color.DimGray;
            this.label136.Location = new System.Drawing.Point(693, 22);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(98, 16);
            this.label136.TabIndex = 10;
            this.label136.Text = "1st Semester";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(75, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 20);
            this.label18.TabIndex = 1020;
            this.label18.Text = "Payment";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label135.ForeColor = System.Drawing.Color.DimGray;
            this.label135.Location = new System.Drawing.Point(457, 21);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(101, 16);
            this.label135.TabIndex = 9;
            this.label135.Text = "School Year: ";
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(10, 8);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(45, 39);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox22.TabIndex = 18;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.WaitOnLoad = true;
            // 
            // txtORNo
            // 
            this.txtORNo.Location = new System.Drawing.Point(57, 66);
            this.txtORNo.Name = "txtORNo";
            this.txtORNo.Size = new System.Drawing.Size(146, 20);
            this.txtORNo.TabIndex = 1026;
            this.txtORNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtORNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1035;
            this.label2.Text = "OR No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1037;
            this.label1.Text = "Amount Tendered:";
            // 
            // txtAmountGiven
            // 
            this.txtAmountGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountGiven.Location = new System.Drawing.Point(292, 227);
            this.txtAmountGiven.Name = "txtAmountGiven";
            this.txtAmountGiven.Size = new System.Drawing.Size(146, 38);
            this.txtAmountGiven.TabIndex = 1036;
            this.txtAmountGiven.Text = "0.00";
            this.txtAmountGiven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 1039;
            this.label4.Text = "Amount Due:";
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(617, 287);
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
            this.lblAmountDue.Location = new System.Drawing.Point(613, 216);
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
            this.label5.Location = new System.Drawing.Point(549, 181);
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
            this.lblPaymentFor.Location = new System.Drawing.Point(660, 181);
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
            this.dgvPerMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentMonth,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
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
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 68;
            // 
            // lblPerMonthAdv
            // 
            this.lblPerMonthAdv.AutoSize = true;
            this.lblPerMonthAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerMonthAdv.Location = new System.Drawing.Point(670, 376);
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
            this.lblCalc.Location = new System.Drawing.Point(670, 134);
            this.lblCalc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(103, 20);
            this.lblCalc.TabIndex = 1050;
            this.lblCalc.Text = "Payment For:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(292, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 31);
            this.btnSave.TabIndex = 1051;
            this.btnSave.Text = "&Confirm Amount";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblpayNumber
            // 
            this.lblpayNumber.AutoSize = true;
            this.lblpayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayNumber.Location = new System.Drawing.Point(660, 75);
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
            this.label6.Location = new System.Drawing.Point(515, 376);
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
            this.lblTheAmount.Location = new System.Drawing.Point(641, 336);
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
            this.lblEnStatus.Location = new System.Drawing.Point(660, 264);
            this.lblEnStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnStatus.Name = "lblEnStatus";
            this.lblEnStatus.Size = new System.Drawing.Size(91, 20);
            this.lblEnStatus.TabIndex = 1055;
            this.lblEnStatus.Text = "lblEnStatus";
            // 
            // lblAmount_Due
            // 
            this.lblAmount_Due.AutoSize = true;
            this.lblAmount_Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount_Due.Location = new System.Drawing.Point(337, 181);
            this.lblAmount_Due.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount_Due.Name = "lblAmount_Due";
            this.lblAmount_Due.Size = new System.Drawing.Size(103, 20);
            this.lblAmount_Due.TabIndex = 1056;
            this.lblAmount_Due.Text = "Payment For:";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 330);
            this.Controls.Add(this.lblAmount_Due);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmountGiven);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtORNo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.Label label10;
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
    }
}