namespace GOCSystem2018
{
    partial class frmDiscountFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscountFee));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.EditDiscountLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEditComment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEditAmount = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.DiscountLbl = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtFeeName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.pnlAdd.SuspendLayout();
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
            this.panel3.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label16.Size = new System.Drawing.Size(263, 33);
            this.label16.TabIndex = 17;
            this.label16.Text = "DISCOUNT FEES";
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AllowUserToAddRows = false;
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Discount_Name,
            this.AMount});
            this.dgvDiscount.Location = new System.Drawing.Point(480, 151);
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.ReadOnly = true;
            this.dgvDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscount.Size = new System.Drawing.Size(345, 407);
            this.dgvDiscount.TabIndex = 19;
            this.dgvDiscount.Click += new System.EventHandler(this.dgvDiscount_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Discount_Name
            // 
            this.Discount_Name.HeaderText = "Discount Name";
            this.Discount_Name.Name = "Discount_Name";
            this.Discount_Name.ReadOnly = true;
            this.Discount_Name.Width = 200;
            // 
            // AMount
            // 
            this.AMount.HeaderText = "Amount";
            this.AMount.Name = "AMount";
            this.AMount.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(559, 39);
            this.label8.TabIndex = 20;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // EditDiscountLbl
            // 
            this.EditDiscountLbl.AutoSize = true;
            this.EditDiscountLbl.Location = new System.Drawing.Point(92, 58);
            this.EditDiscountLbl.Name = "EditDiscountLbl";
            this.EditDiscountLbl.Size = new System.Drawing.Size(44, 13);
            this.EditDiscountLbl.TabIndex = 11;
            this.EditDiscountLbl.Text = "ID Here";
            this.EditDiscountLbl.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Edit Discount";
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnCommit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.ForeColor = System.Drawing.Color.White;
            this.btnCommit.Location = new System.Drawing.Point(-1, 221);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(325, 27);
            this.btnCommit.TabIndex = 9;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = ".php";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Comment:";
            // 
            // txtEditComment
            // 
            this.txtEditComment.Location = new System.Drawing.Point(93, 133);
            this.txtEditComment.Multiline = true;
            this.txtEditComment.Name = "txtEditComment";
            this.txtEditComment.Size = new System.Drawing.Size(191, 51);
            this.txtEditComment.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Amount:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Discount ID:";
            this.label14.Visible = false;
            // 
            // txtEditAmount
            // 
            this.txtEditAmount.Location = new System.Drawing.Point(93, 107);
            this.txtEditAmount.Multiline = true;
            this.txtEditAmount.Name = "txtEditAmount";
            this.txtEditAmount.Size = new System.Drawing.Size(100, 20);
            this.txtEditAmount.TabIndex = 4;
            this.txtEditAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(93, 81);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(191, 20);
            this.txtEditName.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Discount Name:";
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.White;
            this.pnlEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdit.Controls.Add(this.label18);
            this.pnlEdit.Controls.Add(this.EditDiscountLbl);
            this.pnlEdit.Controls.Add(this.label10);
            this.pnlEdit.Controls.Add(this.btnCommit);
            this.pnlEdit.Controls.Add(this.label11);
            this.pnlEdit.Controls.Add(this.label12);
            this.pnlEdit.Controls.Add(this.txtEditComment);
            this.pnlEdit.Controls.Add(this.label13);
            this.pnlEdit.Controls.Add(this.label14);
            this.pnlEdit.Controls.Add(this.txtEditAmount);
            this.pnlEdit.Controls.Add(this.txtEditName);
            this.pnlEdit.Controls.Add(this.label15);
            this.pnlEdit.Location = new System.Drawing.Point(427, 188);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(325, 249);
            this.pnlEdit.TabIndex = 18;
            this.pnlEdit.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(304, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "X";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.White;
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Controls.Add(this.label19);
            this.pnlAdd.Controls.Add(this.DiscountLbl);
            this.pnlAdd.Controls.Add(this.label21);
            this.pnlAdd.Controls.Add(this.btnSave);
            this.pnlAdd.Controls.Add(this.label22);
            this.pnlAdd.Controls.Add(this.label23);
            this.pnlAdd.Controls.Add(this.txtComment);
            this.pnlAdd.Controls.Add(this.label24);
            this.pnlAdd.Controls.Add(this.label25);
            this.pnlAdd.Controls.Add(this.txtAmount);
            this.pnlAdd.Controls.Add(this.txtFeeName);
            this.pnlAdd.Controls.Add(this.label26);
            this.pnlAdd.Location = new System.Drawing.Point(69, 188);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(325, 249);
            this.pnlAdd.TabIndex = 22;
            this.pnlAdd.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(304, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "X";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // DiscountLbl
            // 
            this.DiscountLbl.AutoSize = true;
            this.DiscountLbl.Location = new System.Drawing.Point(92, 58);
            this.DiscountLbl.Name = "DiscountLbl";
            this.DiscountLbl.Size = new System.Drawing.Size(44, 13);
            this.DiscountLbl.TabIndex = 11;
            this.DiscountLbl.Text = "ID Here";
            this.DiscountLbl.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(132, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "Add Discount";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(-1, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(325, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(199, 110);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = ".php";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(33, 136);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 13);
            this.label23.TabIndex = 7;
            this.label23.Text = "Comment:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(93, 133);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(191, 51);
            this.txtComment.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(41, 110);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "Amount:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 58);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Discount ID:";
            this.label25.Visible = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(93, 107);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFeeName
            // 
            this.txtFeeName.Location = new System.Drawing.Point(93, 81);
            this.txtFeeName.Name = "txtFeeName";
            this.txtFeeName.Size = new System.Drawing.Size(191, 20);
            this.txtFeeName.TabIndex = 2;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 84);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = "Discount Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(721, 598);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 31;
            this.btnDelete.TabStop = false;
            this.btnDelete.WaitOnLoad = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(615, 598);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 28);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 30;
            this.btnEdit.TabStop = false;
            this.btnEdit.WaitOnLoad = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(615, 564);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 28);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 29;
            this.btnAdd.TabStop = false;
            this.btnAdd.WaitOnLoad = true;
            this.btnAdd.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmDiscountFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(868, 647);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvDiscount);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiscountFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDiscountFee";
            this.Load += new System.EventHandler(this.frmDiscountFee_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EditDiscountLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEditComment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEditAmount;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label DiscountLbl;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtFeeName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMount;
    }
}