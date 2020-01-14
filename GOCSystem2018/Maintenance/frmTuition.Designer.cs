namespace GOCSystem2018
{
    partial class frmTuition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTuition));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlNewTuition = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.TuitionLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTuitionComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTuitionAmount = new System.Windows.Forms.TextBox();
            this.txtTuition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlEditVoucher = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.EditTuitionLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEditTuitionComment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEditTuitionAmount = new System.Windows.Forms.TextBox();
            this.txtEditTuition = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvTuitionFees = new System.Windows.Forms.DataGridView();
            this.Col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TuitionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.pnlNewTuition.SuspendLayout();
            this.pnlEditVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuitionFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 117);
            this.panel3.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(837, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 18);
            this.label17.TabIndex = 19;
            this.label17.Text = "X";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(17, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(207, 33);
            this.label16.TabIndex = 17;
            this.label16.Text = "TUITION FEE";
            // 
            // pnlNewTuition
            // 
            this.pnlNewTuition.BackColor = System.Drawing.Color.White;
            this.pnlNewTuition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewTuition.Controls.Add(this.label18);
            this.pnlNewTuition.Controls.Add(this.TuitionLbl);
            this.pnlNewTuition.Controls.Add(this.label2);
            this.pnlNewTuition.Controls.Add(this.btnSave);
            this.pnlNewTuition.Controls.Add(this.label3);
            this.pnlNewTuition.Controls.Add(this.label4);
            this.pnlNewTuition.Controls.Add(this.txtTuitionComment);
            this.pnlNewTuition.Controls.Add(this.label5);
            this.pnlNewTuition.Controls.Add(this.label6);
            this.pnlNewTuition.Controls.Add(this.txtTuitionAmount);
            this.pnlNewTuition.Controls.Add(this.txtTuition);
            this.pnlNewTuition.Controls.Add(this.label7);
            this.pnlNewTuition.Location = new System.Drawing.Point(86, 155);
            this.pnlNewTuition.Name = "pnlNewTuition";
            this.pnlNewTuition.Size = new System.Drawing.Size(325, 249);
            this.pnlNewTuition.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(304, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 16);
            this.label18.TabIndex = 21;
            this.label18.Text = "X";
            this.label18.Visible = false;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // TuitionLbl
            // 
            this.TuitionLbl.AutoSize = true;
            this.TuitionLbl.Location = new System.Drawing.Point(93, 56);
            this.TuitionLbl.Name = "TuitionLbl";
            this.TuitionLbl.Size = new System.Drawing.Size(44, 13);
            this.TuitionLbl.TabIndex = 11;
            this.TuitionLbl.Text = "ID Here";
            this.TuitionLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Tuition Fee";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(-1, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(325, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = ".php";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comment:";
            // 
            // txtTuitionComment
            // 
            this.txtTuitionComment.Location = new System.Drawing.Point(93, 133);
            this.txtTuitionComment.Multiline = true;
            this.txtTuitionComment.Name = "txtTuitionComment";
            this.txtTuitionComment.Size = new System.Drawing.Size(191, 51);
            this.txtTuitionComment.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "* Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tuition ID:";
            this.label6.Visible = false;
            // 
            // txtTuitionAmount
            // 
            this.txtTuitionAmount.Location = new System.Drawing.Point(93, 107);
            this.txtTuitionAmount.MaxLength = 10;
            this.txtTuitionAmount.Multiline = true;
            this.txtTuitionAmount.Name = "txtTuitionAmount";
            this.txtTuitionAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTuitionAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTuitionAmount.TabIndex = 4;
            // 
            // txtTuition
            // 
            this.txtTuition.Location = new System.Drawing.Point(93, 81);
            this.txtTuition.Name = "txtTuition";
            this.txtTuition.Size = new System.Drawing.Size(191, 20);
            this.txtTuition.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "* Tuition Fee:";
            // 
            // pnlEditVoucher
            // 
            this.pnlEditVoucher.BackColor = System.Drawing.Color.White;
            this.pnlEditVoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditVoucher.Controls.Add(this.label19);
            this.pnlEditVoucher.Controls.Add(this.label13);
            this.pnlEditVoucher.Controls.Add(this.label14);
            this.pnlEditVoucher.Controls.Add(this.EditTuitionLbl);
            this.pnlEditVoucher.Controls.Add(this.label9);
            this.pnlEditVoucher.Controls.Add(this.btnCommit);
            this.pnlEditVoucher.Controls.Add(this.label10);
            this.pnlEditVoucher.Controls.Add(this.label11);
            this.pnlEditVoucher.Controls.Add(this.txtEditTuitionComment);
            this.pnlEditVoucher.Controls.Add(this.label12);
            this.pnlEditVoucher.Controls.Add(this.txtEditTuitionAmount);
            this.pnlEditVoucher.Controls.Add(this.txtEditTuition);
            this.pnlEditVoucher.Location = new System.Drawing.Point(90, 154);
            this.pnlEditVoucher.Name = "pnlEditVoucher";
            this.pnlEditVoucher.Size = new System.Drawing.Size(325, 249);
            this.pnlEditVoucher.TabIndex = 28;
            this.pnlEditVoucher.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(304, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 16);
            this.label19.TabIndex = 21;
            this.label19.Text = "X";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tuition ID:";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "* Tuition Fee:";
            // 
            // EditTuitionLbl
            // 
            this.EditTuitionLbl.AutoSize = true;
            this.EditTuitionLbl.Location = new System.Drawing.Point(93, 58);
            this.EditTuitionLbl.Name = "EditTuitionLbl";
            this.EditTuitionLbl.Size = new System.Drawing.Size(42, 13);
            this.EditTuitionLbl.TabIndex = 11;
            this.EditTuitionLbl.Text = "ID here";
            this.EditTuitionLbl.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Edit Voucher";
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnCommit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.ForeColor = System.Drawing.Color.White;
            this.btnCommit.Location = new System.Drawing.Point(-1, 221);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(325, 27);
            this.btnCommit.TabIndex = 9;
            this.btnCommit.Text = "&Commit";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = ".php";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Comment:";
            // 
            // txtEditTuitionComment
            // 
            this.txtEditTuitionComment.Location = new System.Drawing.Point(93, 133);
            this.txtEditTuitionComment.Multiline = true;
            this.txtEditTuitionComment.Name = "txtEditTuitionComment";
            this.txtEditTuitionComment.Size = new System.Drawing.Size(191, 51);
            this.txtEditTuitionComment.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "* Amount:";
            // 
            // txtEditTuitionAmount
            // 
            this.txtEditTuitionAmount.Location = new System.Drawing.Point(93, 107);
            this.txtEditTuitionAmount.Multiline = true;
            this.txtEditTuitionAmount.Name = "txtEditTuitionAmount";
            this.txtEditTuitionAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEditTuitionAmount.Size = new System.Drawing.Size(100, 20);
            this.txtEditTuitionAmount.TabIndex = 4;
            // 
            // txtEditTuition
            // 
            this.txtEditTuition.Location = new System.Drawing.Point(93, 81);
            this.txtEditTuition.Name = "txtEditTuition";
            this.txtEditTuition.Size = new System.Drawing.Size(191, 20);
            this.txtEditTuition.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 572);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(559, 39);
            this.label15.TabIndex = 30;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // dgvTuitionFees
            // 
            this.dgvTuitionFees.AllowUserToAddRows = false;
            this.dgvTuitionFees.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTuitionFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuitionFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_id,
            this.col_TuitionName,
            this.Amount,
            this.Comment});
            this.dgvTuitionFees.GridColor = System.Drawing.Color.DimGray;
            this.dgvTuitionFees.Location = new System.Drawing.Point(444, 154);
            this.dgvTuitionFees.Name = "dgvTuitionFees";
            this.dgvTuitionFees.ReadOnly = true;
            this.dgvTuitionFees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTuitionFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuitionFees.Size = new System.Drawing.Size(412, 407);
            this.dgvTuitionFees.TabIndex = 29;
            this.dgvTuitionFees.Click += new System.EventHandler(this.dgvTuitionFees_Click);
            // 
            // Col_id
            // 
            this.Col_id.HeaderText = "id";
            this.Col_id.Name = "Col_id";
            this.Col_id.ReadOnly = true;
            this.Col_id.Visible = false;
            this.Col_id.Width = 5;
            // 
            // col_TuitionName
            // 
            this.col_TuitionName.HeaderText = "Tuition Fee";
            this.col_TuitionName.Name = "col_TuitionName";
            this.col_TuitionName.ReadOnly = true;
            this.col_TuitionName.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 75;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(714, 601);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 37;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(608, 601);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 28);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 36;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(608, 567);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 28);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 35;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmTuition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(868, 647);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlNewTuition);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlEditVoucher);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTuitionFees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTuition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTuition";
            this.Load += new System.EventHandler(this.frmTuition_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlNewTuition.ResumeLayout(false);
            this.pnlNewTuition.PerformLayout();
            this.pnlEditVoucher.ResumeLayout(false);
            this.pnlEditVoucher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuitionFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlNewTuition;
        private System.Windows.Forms.Label TuitionLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTuitionComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTuitionAmount;
        private System.Windows.Forms.TextBox txtTuition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlEditVoucher;
        private System.Windows.Forms.Label EditTuitionLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEditTuitionComment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEditTuitionAmount;
        private System.Windows.Forms.TextBox txtEditTuition;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvTuitionFees;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TuitionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}