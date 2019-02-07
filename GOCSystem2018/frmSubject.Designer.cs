namespace GOCSystem2018
{
    partial class frmSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubject));
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.EditSubjectLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.txtEditDesc = new System.Windows.Forms.TextBox();
            this.txtEditSubject = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.SubjectLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(709, 609);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 39;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(603, 609);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 28);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 38;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(603, 575);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 28);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 37;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.White;
            this.pnlEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Controls.Add(this.label3);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Controls.Add(this.label19);
            this.pnlEdit.Controls.Add(this.EditSubjectLbl);
            this.pnlEdit.Controls.Add(this.label10);
            this.pnlEdit.Controls.Add(this.btnCommit);
            this.pnlEdit.Controls.Add(this.txtEditDesc);
            this.pnlEdit.Controls.Add(this.txtEditSubject);
            this.pnlEdit.Location = new System.Drawing.Point(449, 192);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(325, 249);
            this.pnlEdit.TabIndex = 34;
            this.pnlEdit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Desc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Subject ID:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Subject Code";
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
            // EditSubjectLbl
            // 
            this.EditSubjectLbl.AutoSize = true;
            this.EditSubjectLbl.Location = new System.Drawing.Point(107, 88);
            this.EditSubjectLbl.Name = "EditSubjectLbl";
            this.EditSubjectLbl.Size = new System.Drawing.Size(42, 13);
            this.EditSubjectLbl.TabIndex = 11;
            this.EditSubjectLbl.Text = "ID here";
            this.EditSubjectLbl.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Edit Subject";
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
            // txtEditDesc
            // 
            this.txtEditDesc.Location = new System.Drawing.Point(108, 137);
            this.txtEditDesc.Multiline = true;
            this.txtEditDesc.Name = "txtEditDesc";
            this.txtEditDesc.Size = new System.Drawing.Size(191, 20);
            this.txtEditDesc.TabIndex = 4;
            // 
            // txtEditSubject
            // 
            this.txtEditSubject.Location = new System.Drawing.Point(108, 111);
            this.txtEditSubject.Name = "txtEditSubject";
            this.txtEditSubject.Size = new System.Drawing.Size(191, 20);
            this.txtEditSubject.TabIndex = 2;
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
            this.panel3.TabIndex = 32;
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
            this.label16.Size = new System.Drawing.Size(174, 33);
            this.label16.TabIndex = 17;
            this.label16.Text = "SUBJECTS";
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.White;
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Controls.Add(this.label18);
            this.pnlAdd.Controls.Add(this.SubjectLbl);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.btnSave);
            this.pnlAdd.Controls.Add(this.label5);
            this.pnlAdd.Controls.Add(this.label6);
            this.pnlAdd.Controls.Add(this.txtDesc);
            this.pnlAdd.Controls.Add(this.txtSubject);
            this.pnlAdd.Controls.Add(this.label7);
            this.pnlAdd.Location = new System.Drawing.Point(93, 192);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(325, 249);
            this.pnlAdd.TabIndex = 33;
            this.pnlAdd.Visible = false;
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
            // SubjectLbl
            // 
            this.SubjectLbl.AutoSize = true;
            this.SubjectLbl.Location = new System.Drawing.Point(110, 88);
            this.SubjectLbl.Name = "SubjectLbl";
            this.SubjectLbl.Size = new System.Drawing.Size(44, 13);
            this.SubjectLbl.TabIndex = 11;
            this.SubjectLbl.Text = "ID Here";
            this.SubjectLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Subject";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Desc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Subject ID:";
            this.label6.Visible = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(111, 137);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(191, 20);
            this.txtDesc.TabIndex = 4;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(111, 111);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(191, 20);
            this.txtSubject.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Subject Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(559, 39);
            this.label8.TabIndex = 36;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.Column1,
            this.Description});
            this.dgvSubjects.Location = new System.Drawing.Point(368, 162);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(445, 407);
            this.dgvSubjects.TabIndex = 35;
            this.dgvSubjects.Click += new System.EventHandler(this.dgvSubjects_Click);
            // 
            // a
            // 
            this.a.HeaderText = "id";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            this.a.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Subject Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 300;
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(868, 647);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvSubjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSubject";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label EditSubjectLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.TextBox txtEditDesc;
        private System.Windows.Forms.TextBox txtEditSubject;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label SubjectLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}