namespace GOCSystem2018
{
    partial class frmOtherFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtherFees));
            this.dgvOtherFee = new System.Windows.Forms.DataGridView();
            this.OFLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFeeAmount = new System.Windows.Forms.TextBox();
            this.txtFeeName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlNewFee = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.EditOFLb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEditFeeComment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEditFeeAmount = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlEditFee = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherFee)).BeginInit();
            this.pnlNewFee.SuspendLayout();
            this.pnlEditFee.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOtherFee
            // 
            this.dgvOtherFee.AllowUserToAddRows = false;
            this.dgvOtherFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtherFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FeeName,
            this.FeeAmount});
            this.dgvOtherFee.Location = new System.Drawing.Point(429, 147);
            this.dgvOtherFee.Name = "dgvOtherFee";
            this.dgvOtherFee.ReadOnly = true;
            this.dgvOtherFee.Size = new System.Drawing.Size(388, 407);
            this.dgvOtherFee.TabIndex = 12;
            this.dgvOtherFee.Click += new System.EventHandler(this.dgvOtherFee_Click);
            // 
            // OFLbl
            // 
            this.OFLbl.AutoSize = true;
            this.OFLbl.Location = new System.Drawing.Point(93, 56);
            this.OFLbl.Name = "OFLbl";
            this.OFLbl.Size = new System.Drawing.Size(65, 13);
            this.OFLbl.TabIndex = 11;
            this.OFLbl.Text = "Fee ID Here";
            this.OFLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Other Fee";
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
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(93, 133);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(191, 51);
            this.txtComment.TabIndex = 6;
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
            this.label6.Location = new System.Drawing.Point(45, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fee ID:";
            this.label6.Visible = false;
            // 
            // txtFeeAmount
            // 
            this.txtFeeAmount.Location = new System.Drawing.Point(93, 107);
            this.txtFeeAmount.Multiline = true;
            this.txtFeeAmount.Name = "txtFeeAmount";
            this.txtFeeAmount.Size = new System.Drawing.Size(100, 20);
            this.txtFeeAmount.TabIndex = 4;
            this.txtFeeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFeeName
            // 
            this.txtFeeName.Location = new System.Drawing.Point(93, 81);
            this.txtFeeName.Name = "txtFeeName";
            this.txtFeeName.Size = new System.Drawing.Size(191, 20);
            this.txtFeeName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fee Name:";
            // 
            // pnlNewFee
            // 
            this.pnlNewFee.BackColor = System.Drawing.Color.White;
            this.pnlNewFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewFee.Controls.Add(this.label18);
            this.pnlNewFee.Controls.Add(this.OFLbl);
            this.pnlNewFee.Controls.Add(this.label2);
            this.pnlNewFee.Controls.Add(this.btnSave);
            this.pnlNewFee.Controls.Add(this.label3);
            this.pnlNewFee.Controls.Add(this.label4);
            this.pnlNewFee.Controls.Add(this.txtComment);
            this.pnlNewFee.Controls.Add(this.label5);
            this.pnlNewFee.Controls.Add(this.label6);
            this.pnlNewFee.Controls.Add(this.txtFeeAmount);
            this.pnlNewFee.Controls.Add(this.txtFeeName);
            this.pnlNewFee.Controls.Add(this.label7);
            this.pnlNewFee.Location = new System.Drawing.Point(73, 175);
            this.pnlNewFee.Name = "pnlNewFee";
            this.pnlNewFee.Size = new System.Drawing.Size(325, 249);
            this.pnlNewFee.TabIndex = 6;
            this.pnlNewFee.Visible = false;
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
            this.label18.TabIndex = 20;
            this.label18.Text = "X";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // EditOFLb
            // 
            this.EditOFLb.AutoSize = true;
            this.EditOFLb.Location = new System.Drawing.Point(93, 58);
            this.EditOFLb.Name = "EditOFLb";
            this.EditOFLb.Size = new System.Drawing.Size(63, 13);
            this.EditOFLb.TabIndex = 11;
            this.EditOFLb.Text = "Fee ID here";
            this.EditOFLb.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Edit Other Fee";
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
            // txtEditFeeComment
            // 
            this.txtEditFeeComment.Location = new System.Drawing.Point(93, 133);
            this.txtEditFeeComment.Multiline = true;
            this.txtEditFeeComment.Name = "txtEditFeeComment";
            this.txtEditFeeComment.Size = new System.Drawing.Size(191, 51);
            this.txtEditFeeComment.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Amount:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Fee ID:";
            this.label13.Visible = false;
            // 
            // txtEditFeeAmount
            // 
            this.txtEditFeeAmount.Location = new System.Drawing.Point(93, 107);
            this.txtEditFeeAmount.Multiline = true;
            this.txtEditFeeAmount.Name = "txtEditFeeAmount";
            this.txtEditFeeAmount.Size = new System.Drawing.Size(100, 20);
            this.txtEditFeeAmount.TabIndex = 4;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(93, 81);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(191, 20);
            this.txtEditName.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Fee Name:";
            // 
            // pnlEditFee
            // 
            this.pnlEditFee.BackColor = System.Drawing.Color.White;
            this.pnlEditFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditFee.Controls.Add(this.label19);
            this.pnlEditFee.Controls.Add(this.EditOFLb);
            this.pnlEditFee.Controls.Add(this.label9);
            this.pnlEditFee.Controls.Add(this.btnCommit);
            this.pnlEditFee.Controls.Add(this.label10);
            this.pnlEditFee.Controls.Add(this.label11);
            this.pnlEditFee.Controls.Add(this.txtEditFeeComment);
            this.pnlEditFee.Controls.Add(this.label12);
            this.pnlEditFee.Controls.Add(this.label13);
            this.pnlEditFee.Controls.Add(this.txtEditFeeAmount);
            this.pnlEditFee.Controls.Add(this.txtEditName);
            this.pnlEditFee.Controls.Add(this.label14);
            this.pnlEditFee.Location = new System.Drawing.Point(77, 171);
            this.pnlEditFee.Name = "pnlEditFee";
            this.pnlEditFee.Size = new System.Drawing.Size(325, 249);
            this.pnlEditFee.TabIndex = 11;
            this.pnlEditFee.Visible = false;
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 565);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(559, 39);
            this.label15.TabIndex = 13;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(17, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(210, 33);
            this.label16.TabIndex = 17;
            this.label16.Text = "OTHER FEES";
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
            this.panel3.TabIndex = 18;
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
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(713, 594);
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
            this.btnEdit.Location = new System.Drawing.Point(607, 594);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 28);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 30;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(607, 560);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 28);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 29;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // FeeName
            // 
            this.FeeName.HeaderText = "Fee Name";
            this.FeeName.Name = "FeeName";
            this.FeeName.ReadOnly = true;
            this.FeeName.Width = 200;
            // 
            // FeeAmount
            // 
            this.FeeAmount.HeaderText = "Amount";
            this.FeeAmount.Name = "FeeAmount";
            this.FeeAmount.ReadOnly = true;
            // 
            // frmOtherFees
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(868, 647);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlNewFee);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlEditFee);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvOtherFee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOtherFees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOtherFees";
            this.Load += new System.EventHandler(this.frmOtherFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherFee)).EndInit();
            this.pnlNewFee.ResumeLayout(false);
            this.pnlNewFee.PerformLayout();
            this.pnlEditFee.ResumeLayout(false);
            this.pnlEditFee.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOtherFee;
        private System.Windows.Forms.Label OFLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFeeAmount;
        private System.Windows.Forms.TextBox txtFeeName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlNewFee;
        private System.Windows.Forms.Label EditOFLb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEditFeeComment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEditFeeAmount;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlEditFee;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeAmount;
    }
}