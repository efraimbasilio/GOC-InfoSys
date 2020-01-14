namespace GOCSystem2018
{
    partial class frmMiscFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiscFees));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvMiscFee = new System.Windows.Forms.DataGridView();
            this.MiscLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiscComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMiscAmount = new System.Windows.Forms.TextBox();
            this.txtMiscName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlNewMisc = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EditMiscLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEditMiscComment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEditMiscAmount = new System.Windows.Forms.TextBox();
            this.txtEditMiscName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlEditMisc = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnAdd1 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Misc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.misc_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiscFee)).BeginInit();
            this.pnlNewMisc.SuspendLayout();
            this.pnlEditMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd1)).BeginInit();
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
            this.panel3.TabIndex = 19;
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
            this.label17.TabIndex = 20;
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
            this.label16.Size = new System.Drawing.Size(179, 33);
            this.label16.TabIndex = 17;
            this.label16.Text = "MISC FEES";
            // 
            // dgvMiscFee
            // 
            this.dgvMiscFee.AllowUserToAddRows = false;
            this.dgvMiscFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiscFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Misc_Name,
            this.misc_amount});
            this.dgvMiscFee.Location = new System.Drawing.Point(468, 154);
            this.dgvMiscFee.Name = "dgvMiscFee";
            this.dgvMiscFee.ReadOnly = true;
            this.dgvMiscFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMiscFee.Size = new System.Drawing.Size(345, 407);
            this.dgvMiscFee.TabIndex = 26;
            this.dgvMiscFee.Click += new System.EventHandler(this.dgvMiscFee_Click);
            // 
            // MiscLbl
            // 
            this.MiscLbl.AutoSize = true;
            this.MiscLbl.Location = new System.Drawing.Point(92, 58);
            this.MiscLbl.Name = "MiscLbl";
            this.MiscLbl.Size = new System.Drawing.Size(44, 13);
            this.MiscLbl.TabIndex = 11;
            this.MiscLbl.Text = "ID Here";
            this.MiscLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Misc Fee";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(-1, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(325, 27);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // txtMiscComment
            // 
            this.txtMiscComment.Location = new System.Drawing.Point(93, 133);
            this.txtMiscComment.Multiline = true;
            this.txtMiscComment.Name = "txtMiscComment";
            this.txtMiscComment.Size = new System.Drawing.Size(191, 51);
            this.txtMiscComment.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Misc Fee ID:";
            this.label6.Visible = false;
            // 
            // txtMiscAmount
            // 
            this.txtMiscAmount.Location = new System.Drawing.Point(93, 107);
            this.txtMiscAmount.Multiline = true;
            this.txtMiscAmount.Name = "txtMiscAmount";
            this.txtMiscAmount.Size = new System.Drawing.Size(100, 20);
            this.txtMiscAmount.TabIndex = 4;
            // 
            // txtMiscName
            // 
            this.txtMiscName.Location = new System.Drawing.Point(93, 81);
            this.txtMiscName.Name = "txtMiscName";
            this.txtMiscName.Size = new System.Drawing.Size(191, 20);
            this.txtMiscName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Misc Fee Name:";
            // 
            // pnlNewMisc
            // 
            this.pnlNewMisc.BackColor = System.Drawing.Color.White;
            this.pnlNewMisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewMisc.Controls.Add(this.label18);
            this.pnlNewMisc.Controls.Add(this.MiscLbl);
            this.pnlNewMisc.Controls.Add(this.label2);
            this.pnlNewMisc.Controls.Add(this.btnAdd);
            this.pnlNewMisc.Controls.Add(this.label3);
            this.pnlNewMisc.Controls.Add(this.label4);
            this.pnlNewMisc.Controls.Add(this.txtMiscComment);
            this.pnlNewMisc.Controls.Add(this.label5);
            this.pnlNewMisc.Controls.Add(this.label6);
            this.pnlNewMisc.Controls.Add(this.txtMiscAmount);
            this.pnlNewMisc.Controls.Add(this.txtMiscName);
            this.pnlNewMisc.Controls.Add(this.label7);
            this.pnlNewMisc.Location = new System.Drawing.Point(41, 153);
            this.pnlNewMisc.Name = "pnlNewMisc";
            this.pnlNewMisc.Size = new System.Drawing.Size(325, 249);
            this.pnlNewMisc.TabIndex = 24;
            this.pnlNewMisc.Visible = false;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 571);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(559, 39);
            this.label8.TabIndex = 27;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // EditMiscLbl
            // 
            this.EditMiscLbl.AutoSize = true;
            this.EditMiscLbl.Location = new System.Drawing.Point(92, 58);
            this.EditMiscLbl.Name = "EditMiscLbl";
            this.EditMiscLbl.Size = new System.Drawing.Size(53, 13);
            this.EditMiscLbl.TabIndex = 11;
            this.EditMiscLbl.Text = "Misc here";
            this.EditMiscLbl.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Edit Misc Fee";
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
            // txtEditMiscComment
            // 
            this.txtEditMiscComment.Location = new System.Drawing.Point(93, 133);
            this.txtEditMiscComment.Multiline = true;
            this.txtEditMiscComment.Name = "txtEditMiscComment";
            this.txtEditMiscComment.Size = new System.Drawing.Size(191, 51);
            this.txtEditMiscComment.TabIndex = 6;
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
            this.label14.Location = new System.Drawing.Point(19, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Misc Fee ID:";
            this.label14.Visible = false;
            // 
            // txtEditMiscAmount
            // 
            this.txtEditMiscAmount.Location = new System.Drawing.Point(93, 107);
            this.txtEditMiscAmount.Multiline = true;
            this.txtEditMiscAmount.Name = "txtEditMiscAmount";
            this.txtEditMiscAmount.Size = new System.Drawing.Size(100, 20);
            this.txtEditMiscAmount.TabIndex = 4;
            this.txtEditMiscAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEditMiscName
            // 
            this.txtEditMiscName.Location = new System.Drawing.Point(93, 81);
            this.txtEditMiscName.Name = "txtEditMiscName";
            this.txtEditMiscName.Size = new System.Drawing.Size(191, 20);
            this.txtEditMiscName.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Misc Fee Name:";
            // 
            // pnlEditMisc
            // 
            this.pnlEditMisc.BackColor = System.Drawing.Color.White;
            this.pnlEditMisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditMisc.Controls.Add(this.label19);
            this.pnlEditMisc.Controls.Add(this.EditMiscLbl);
            this.pnlEditMisc.Controls.Add(this.label10);
            this.pnlEditMisc.Controls.Add(this.btnCommit);
            this.pnlEditMisc.Controls.Add(this.label11);
            this.pnlEditMisc.Controls.Add(this.label12);
            this.pnlEditMisc.Controls.Add(this.txtEditMiscComment);
            this.pnlEditMisc.Controls.Add(this.label13);
            this.pnlEditMisc.Controls.Add(this.label14);
            this.pnlEditMisc.Controls.Add(this.txtEditMiscAmount);
            this.pnlEditMisc.Controls.Add(this.txtEditMiscName);
            this.pnlEditMisc.Controls.Add(this.label15);
            this.pnlEditMisc.Location = new System.Drawing.Point(45, 149);
            this.pnlEditMisc.Name = "pnlEditMisc";
            this.pnlEditMisc.Size = new System.Drawing.Size(325, 249);
            this.pnlEditMisc.TabIndex = 25;
            this.pnlEditMisc.Visible = false;
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
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(709, 600);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 31;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(603, 600);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 28);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 30;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd1.Image")));
            this.btnAdd1.Location = new System.Drawing.Point(603, 566);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(210, 28);
            this.btnAdd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd1.TabIndex = 29;
            this.btnAdd1.TabStop = false;
            this.btnAdd1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Misc_Name
            // 
            this.Misc_Name.HeaderText = "Miscellaneous Name";
            this.Misc_Name.Name = "Misc_Name";
            this.Misc_Name.ReadOnly = true;
            this.Misc_Name.Width = 200;
            // 
            // misc_amount
            // 
            this.misc_amount.HeaderText = "Amount";
            this.misc_amount.Name = "misc_amount";
            this.misc_amount.ReadOnly = true;
            // 
            // frmMiscFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(868, 647);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.pnlEditMisc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlNewMisc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvMiscFee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMiscFees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMiscFees";
            this.Load += new System.EventHandler(this.frmMiscFees_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiscFee)).EndInit();
            this.pnlNewMisc.ResumeLayout(false);
            this.pnlNewMisc.PerformLayout();
            this.pnlEditMisc.ResumeLayout(false);
            this.pnlEditMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvMiscFee;
        private System.Windows.Forms.Label MiscLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiscComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMiscAmount;
        private System.Windows.Forms.TextBox txtMiscName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlNewMisc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EditMiscLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEditMiscComment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEditMiscAmount;
        private System.Windows.Forms.TextBox txtEditMiscName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlEditMisc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnAdd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Misc_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn misc_amount;
    }
}