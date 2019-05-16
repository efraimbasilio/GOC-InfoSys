namespace GOCSystem2018
{
    partial class frmBilling_OtherFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilling_OtherFee));
            this.txtAmountGiven = new System.Windows.Forms.TextBox();
            this.btnOtherFee = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtORNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlOtherFee = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTuitionFee = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLocker = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUniform = new System.Windows.Forms.TextBox();
            this.lblAmount_Due = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlOtherFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAmountGiven
            // 
            this.txtAmountGiven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountGiven.Location = new System.Drawing.Point(7, 490);
            this.txtAmountGiven.Name = "txtAmountGiven";
            this.txtAmountGiven.Size = new System.Drawing.Size(418, 38);
            this.txtAmountGiven.TabIndex = 19;
            this.txtAmountGiven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountGiven.Click += new System.EventHandler(this.txtAmountGiven_Click);
            this.txtAmountGiven.Enter += new System.EventHandler(this.txtAmountGiven_Enter);
            this.txtAmountGiven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountGiven_KeyPress);
            this.txtAmountGiven.Leave += new System.EventHandler(this.txtAmountGiven_Leave);
            // 
            // btnOtherFee
            // 
            this.btnOtherFee.Location = new System.Drawing.Point(320, 100);
            this.btnOtherFee.Name = "btnOtherFee";
            this.btnOtherFee.Size = new System.Drawing.Size(101, 30);
            this.btnOtherFee.TabIndex = 11;
            this.btnOtherFee.Text = "With Other Fees";
            this.btnOtherFee.UseVisualStyleBackColor = true;
            this.btnOtherFee.Click += new System.EventHandler(this.btnOtherFee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(6, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 1097;
            this.label7.Text = "Receipt number:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(87)))));
            this.panel4.Controls.Add(this.lblAmount_Due);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(7, 422);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 45);
            this.panel4.TabIndex = 1096;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1058;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 1039;
            this.label4.Text = "Total Fee:";
            // 
            // txtORNo
            // 
            this.txtORNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtORNo.Location = new System.Drawing.Point(9, 133);
            this.txtORNo.Name = "txtORNo";
            this.txtORNo.Size = new System.Drawing.Size(412, 26);
            this.txtORNo.TabIndex = 10;
            this.txtORNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtORNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtORNo_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.label18.Location = new System.Drawing.Point(5, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 25);
            this.label18.TabIndex = 1093;
            this.label18.Text = "Payment";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(258, 534);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 47);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Confirm Amount";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(6, 474);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1094;
            this.label1.Text = "Amount Tendered:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(87)))));
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lblRegNo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(9, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 25);
            this.panel3.TabIndex = 1095;
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
            // pnlOtherFee
            // 
            this.pnlOtherFee.Controls.Add(this.button1);
            this.pnlOtherFee.Controls.Add(this.label16);
            this.pnlOtherFee.Controls.Add(this.txtTuitionFee);
            this.pnlOtherFee.Controls.Add(this.label14);
            this.pnlOtherFee.Controls.Add(this.txtLocker);
            this.pnlOtherFee.Controls.Add(this.label11);
            this.pnlOtherFee.Controls.Add(this.txtBooks);
            this.pnlOtherFee.Controls.Add(this.label10);
            this.pnlOtherFee.Controls.Add(this.txtUniform);
            this.pnlOtherFee.Location = new System.Drawing.Point(9, 166);
            this.pnlOtherFee.Name = "pnlOtherFee";
            this.pnlOtherFee.Size = new System.Drawing.Size(412, 250);
            this.pnlOtherFee.TabIndex = 12;
            this.pnlOtherFee.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(199, 21);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 1096;
            this.label16.Text = "Tuition Fee:";
            // 
            // txtTuitionFee
            // 
            this.txtTuitionFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuitionFee.ForeColor = System.Drawing.Color.Black;
            this.txtTuitionFee.Location = new System.Drawing.Point(204, 37);
            this.txtTuitionFee.Name = "txtTuitionFee";
            this.txtTuitionFee.Size = new System.Drawing.Size(202, 24);
            this.txtTuitionFee.TabIndex = 13;
            this.txtTuitionFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTuitionFee.Click += new System.EventHandler(this.txtTuitionFee_Click);
            this.txtTuitionFee.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtTuitionFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTuitionFee_KeyPress);
            this.txtTuitionFee.Leave += new System.EventHandler(this.txtTuitionFee_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(201, 160);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 1094;
            this.label14.Text = "Locker:";
            // 
            // txtLocker
            // 
            this.txtLocker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocker.ForeColor = System.Drawing.Color.Black;
            this.txtLocker.Location = new System.Drawing.Point(204, 176);
            this.txtLocker.Name = "txtLocker";
            this.txtLocker.Size = new System.Drawing.Size(202, 24);
            this.txtLocker.TabIndex = 16;
            this.txtLocker.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLocker.Click += new System.EventHandler(this.txtLocker_Click);
            this.txtLocker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocker_KeyPress);
            this.txtLocker.Leave += new System.EventHandler(this.txtLocker_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(201, 113);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 1092;
            this.label11.Text = "Books:";
            // 
            // txtBooks
            // 
            this.txtBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooks.ForeColor = System.Drawing.Color.Black;
            this.txtBooks.Location = new System.Drawing.Point(204, 129);
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.Size = new System.Drawing.Size(202, 24);
            this.txtBooks.TabIndex = 15;
            this.txtBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBooks.Click += new System.EventHandler(this.txtBooks_Click);
            this.txtBooks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBooks_KeyPress);
            this.txtBooks.Leave += new System.EventHandler(this.txtBooks_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(201, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 1090;
            this.label10.Text = "Uniform:";
            // 
            // txtUniform
            // 
            this.txtUniform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniform.ForeColor = System.Drawing.Color.Black;
            this.txtUniform.Location = new System.Drawing.Point(204, 80);
            this.txtUniform.Name = "txtUniform";
            this.txtUniform.Size = new System.Drawing.Size(202, 24);
            this.txtUniform.TabIndex = 14;
            this.txtUniform.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUniform.Click += new System.EventHandler(this.txtUniform_Click);
            this.txtUniform.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUniform_KeyPress);
            this.txtUniform.Leave += new System.EventHandler(this.txtUniform_Leave);
            // 
            // lblAmount_Due
            // 
            this.lblAmount_Due.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(87)))));
            this.lblAmount_Due.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAmount_Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount_Due.ForeColor = System.Drawing.Color.White;
            this.lblAmount_Due.Location = new System.Drawing.Point(131, 7);
            this.lblAmount_Due.Name = "lblAmount_Due";
            this.lblAmount_Due.ReadOnly = true;
            this.lblAmount_Due.Size = new System.Drawing.Size(284, 31);
            this.lblAmount_Due.TabIndex = 18;
            this.lblAmount_Due.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmBilling_OtherFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 592);
            this.Controls.Add(this.txtAmountGiven);
            this.Controls.Add(this.btnOtherFee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtORNo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlOtherFee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBilling_OtherFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBilling_OtherFee";
            this.Load += new System.EventHandler(this.frmBilling_OtherFee_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlOtherFee.ResumeLayout(false);
            this.pnlOtherFee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmountGiven;
        private System.Windows.Forms.Button btnOtherFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtORNo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlOtherFee;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTuitionFee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLocker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUniform;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lblAmount_Due;
    }
}