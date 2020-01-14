namespace GOCSystem2018
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.bntAdd = new System.Windows.Forms.PictureBox();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.EditATCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditConPwTb = new System.Windows.Forms.TextBox();
            this.EditUserLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EditPwTb = new System.Windows.Forms.TextBox();
            this.EditUserTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlNew = new System.Windows.Forms.Panel();
            this.ATCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ConPwTb = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.UserLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PwTb = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntAdd)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(709, 614);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 47;
            this.btnDelete.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(603, 614);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 28);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 46;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Image = ((System.Drawing.Image)(resources.GetObject("bntAdd.Image")));
            this.bntAdd.Location = new System.Drawing.Point(603, 580);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(210, 28);
            this.bntAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntAdd.TabIndex = 45;
            this.bntAdd.TabStop = false;
            this.bntAdd.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.White;
            this.pnlEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdit.Controls.Add(this.EditATCb);
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Controls.Add(this.label3);
            this.pnlEdit.Controls.Add(this.EditConPwTb);
            this.pnlEdit.Controls.Add(this.EditUserLbl);
            this.pnlEdit.Controls.Add(this.label12);
            this.pnlEdit.Controls.Add(this.label13);
            this.pnlEdit.Controls.Add(this.EditPwTb);
            this.pnlEdit.Controls.Add(this.EditUserTb);
            this.pnlEdit.Controls.Add(this.label14);
            this.pnlEdit.Controls.Add(this.label19);
            this.pnlEdit.Controls.Add(this.label10);
            this.pnlEdit.Controls.Add(this.btnCommit);
            this.pnlEdit.Location = new System.Drawing.Point(449, 197);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(325, 249);
            this.pnlEdit.TabIndex = 42;
            this.pnlEdit.Visible = false;
            // 
            // EditATCb
            // 
            this.EditATCb.FormattingEnabled = true;
            this.EditATCb.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Registrar",
            "Clerk"});
            this.EditATCb.Location = new System.Drawing.Point(116, 163);
            this.EditATCb.Name = "EditATCb";
            this.EditATCb.Size = new System.Drawing.Size(121, 21);
            this.EditATCb.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Access Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Confirm Password:";
            // 
            // EditConPwTb
            // 
            this.EditConPwTb.Location = new System.Drawing.Point(116, 137);
            this.EditConPwTb.Name = "EditConPwTb";
            this.EditConPwTb.Size = new System.Drawing.Size(191, 20);
            this.EditConPwTb.TabIndex = 33;
            // 
            // EditUserLbl
            // 
            this.EditUserLbl.AutoSize = true;
            this.EditUserLbl.Location = new System.Drawing.Point(115, 62);
            this.EditUserLbl.Name = "EditUserLbl";
            this.EditUserLbl.Size = new System.Drawing.Size(44, 13);
            this.EditUserLbl.TabIndex = 32;
            this.EditUserLbl.Text = "ID Here";
            this.EditUserLbl.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Password:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "User ID:";
            this.label13.Visible = false;
            // 
            // EditPwTb
            // 
            this.EditPwTb.Location = new System.Drawing.Point(116, 111);
            this.EditPwTb.Name = "EditPwTb";
            this.EditPwTb.Size = new System.Drawing.Size(191, 20);
            this.EditPwTb.TabIndex = 30;
            // 
            // EditUserTb
            // 
            this.EditUserTb.Location = new System.Drawing.Point(116, 85);
            this.EditUserTb.Name = "EditUserTb";
            this.EditUserTb.Size = new System.Drawing.Size(191, 20);
            this.EditUserTb.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Username:";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Edit User";
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
            this.panel3.TabIndex = 40;
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
            this.label16.Size = new System.Drawing.Size(119, 33);
            this.label16.TabIndex = 17;
            this.label16.Text = "USERS";
            // 
            // pnlNew
            // 
            this.pnlNew.BackColor = System.Drawing.Color.White;
            this.pnlNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNew.Controls.Add(this.ATCb);
            this.pnlNew.Controls.Add(this.label11);
            this.pnlNew.Controls.Add(this.label9);
            this.pnlNew.Controls.Add(this.ConPwTb);
            this.pnlNew.Controls.Add(this.label18);
            this.pnlNew.Controls.Add(this.UserLbl);
            this.pnlNew.Controls.Add(this.label2);
            this.pnlNew.Controls.Add(this.btnSave);
            this.pnlNew.Controls.Add(this.label5);
            this.pnlNew.Controls.Add(this.label6);
            this.pnlNew.Controls.Add(this.PwTb);
            this.pnlNew.Controls.Add(this.txt);
            this.pnlNew.Controls.Add(this.label7);
            this.pnlNew.Location = new System.Drawing.Point(93, 197);
            this.pnlNew.Name = "pnlNew";
            this.pnlNew.Size = new System.Drawing.Size(325, 249);
            this.pnlNew.TabIndex = 41;
            this.pnlNew.Visible = false;
            // 
            // ATCb
            // 
            this.ATCb.FormattingEnabled = true;
            this.ATCb.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Registrar",
            "Clerk"});
            this.ATCb.Location = new System.Drawing.Point(114, 159);
            this.ATCb.Name = "ATCb";
            this.ATCb.Size = new System.Drawing.Size(121, 21);
            this.ATCb.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Access Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Confirm Password:";
            // 
            // ConPwTb
            // 
            this.ConPwTb.Location = new System.Drawing.Point(114, 133);
            this.ConPwTb.Name = "ConPwTb";
            this.ConPwTb.Size = new System.Drawing.Size(191, 20);
            this.ConPwTb.TabIndex = 22;
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
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(113, 58);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(44, 13);
            this.UserLbl.TabIndex = 11;
            this.UserLbl.Text = "ID Here";
            this.UserLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "New User";
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "User ID:";
            this.label6.Visible = false;
            // 
            // PwTb
            // 
            this.PwTb.Location = new System.Drawing.Point(114, 107);
            this.PwTb.Name = "PwTb";
            this.PwTb.Size = new System.Drawing.Size(191, 20);
            this.PwTb.TabIndex = 4;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(114, 81);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(191, 20);
            this.txt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Username:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 585);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(559, 39);
            this.label8.TabIndex = 44;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(40, 167);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(773, 407);
            this.dgvUser.TabIndex = 43;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(868, 647);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlNew);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUser";
            this.Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntAdd)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlNew.ResumeLayout(false);
            this.pnlNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox bntAdd;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlNew;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PwTb;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ConPwTb;
        private System.Windows.Forms.ComboBox ATCb;
        private System.Windows.Forms.ComboBox EditATCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EditConPwTb;
        private System.Windows.Forms.Label EditUserLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EditPwTb;
        private System.Windows.Forms.TextBox EditUserTb;
        private System.Windows.Forms.Label label14;
    }
}