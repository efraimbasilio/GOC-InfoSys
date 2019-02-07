namespace GOCSystem2018
{
    partial class frmSchoolYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchoolYear));
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EditSYLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEditEnd = new System.Windows.Forms.TextBox();
            this.txtEditStart = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SYLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYearEnd = new System.Windows.Forms.TextBox();
            this.txtYearStart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSchoolYear = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Misc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.misc_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolYear)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(709, 616);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 55;
            this.btnDelete.TabStop = false;
            this.btnDelete.WaitOnLoad = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(603, 616);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 28);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 54;
            this.btnEdit.TabStop = false;
            this.btnEdit.WaitOnLoad = true;
            this.btnEdit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(603, 582);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 28);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 53;
            this.btnAdd.TabStop = false;
            this.btnAdd.WaitOnLoad = true;
            this.btnAdd.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.White;
            this.pnlEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Controls.Add(this.EditSYLbl);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Controls.Add(this.label11);
            this.pnlEdit.Controls.Add(this.txtEditEnd);
            this.pnlEdit.Controls.Add(this.txtEditStart);
            this.pnlEdit.Controls.Add(this.label12);
            this.pnlEdit.Controls.Add(this.label19);
            this.pnlEdit.Controls.Add(this.label10);
            this.pnlEdit.Controls.Add(this.btnCommit);
            this.pnlEdit.Location = new System.Drawing.Point(19, 378);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(325, 249);
            this.pnlEdit.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Year End";
            // 
            // EditSYLbl
            // 
            this.EditSYLbl.AutoSize = true;
            this.EditSYLbl.Location = new System.Drawing.Point(179, 88);
            this.EditSYLbl.Name = "EditSYLbl";
            this.EditSYLbl.Size = new System.Drawing.Size(44, 13);
            this.EditSYLbl.TabIndex = 28;
            this.EditSYLbl.Text = "ID Here";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "School Year ID:";
            // 
            // txtEditEnd
            // 
            this.txtEditEnd.Location = new System.Drawing.Point(179, 123);
            this.txtEditEnd.Multiline = true;
            this.txtEditEnd.Name = "txtEditEnd";
            this.txtEditEnd.Size = new System.Drawing.Size(92, 20);
            this.txtEditEnd.TabIndex = 26;
            // 
            // txtEditStart
            // 
            this.txtEditStart.Location = new System.Drawing.Point(60, 123);
            this.txtEditStart.Name = "txtEditStart";
            this.txtEditStart.Size = new System.Drawing.Size(92, 20);
            this.txtEditStart.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(81, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Year Start";
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
            this.label10.Location = new System.Drawing.Point(126, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Edit School Year";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 117);
            this.panel3.TabIndex = 48;
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
            this.label16.Size = new System.Drawing.Size(236, 33);
            this.label16.TabIndex = 17;
            this.label16.Text = "SCHOOL YEAR";
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.White;
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Controls.Add(this.label9);
            this.pnlAdd.Controls.Add(this.label18);
            this.pnlAdd.Controls.Add(this.SYLbl);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.btnSave);
            this.pnlAdd.Controls.Add(this.label5);
            this.pnlAdd.Controls.Add(this.label6);
            this.pnlAdd.Controls.Add(this.txtYearEnd);
            this.pnlAdd.Controls.Add(this.txtYearStart);
            this.pnlAdd.Controls.Add(this.label7);
            this.pnlAdd.Location = new System.Drawing.Point(23, 123);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(325, 249);
            this.pnlAdd.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(201, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Year End";
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
            // SYLbl
            // 
            this.SYLbl.AutoSize = true;
            this.SYLbl.Location = new System.Drawing.Point(182, 88);
            this.SYLbl.Name = "SYLbl";
            this.SYLbl.Size = new System.Drawing.Size(44, 13);
            this.SYLbl.TabIndex = 11;
            this.SYLbl.Text = "ID Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "New School Year";
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "School Year ID:";
            // 
            // txtYearEnd
            // 
            this.txtYearEnd.Location = new System.Drawing.Point(182, 123);
            this.txtYearEnd.Multiline = true;
            this.txtYearEnd.Name = "txtYearEnd";
            this.txtYearEnd.Size = new System.Drawing.Size(92, 20);
            this.txtYearEnd.TabIndex = 4;
            // 
            // txtYearStart
            // 
            this.txtYearStart.Location = new System.Drawing.Point(63, 123);
            this.txtYearStart.Name = "txtYearStart";
            this.txtYearStart.Size = new System.Drawing.Size(92, 20);
            this.txtYearStart.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Year Start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 587);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(559, 39);
            this.label8.TabIndex = 52;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // dgvSchoolYear
            // 
            this.dgvSchoolYear.AllowUserToAddRows = false;
            this.dgvSchoolYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchoolYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Misc_Name,
            this.misc_amount});
            this.dgvSchoolYear.Location = new System.Drawing.Point(468, 144);
            this.dgvSchoolYear.Name = "dgvSchoolYear";
            this.dgvSchoolYear.ReadOnly = true;
            this.dgvSchoolYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchoolYear.Size = new System.Drawing.Size(345, 407);
            this.dgvSchoolYear.TabIndex = 56;
            this.dgvSchoolYear.Click += new System.EventHandler(this.dgvSchoolYear_Click);
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
            this.Misc_Name.HeaderText = "Year Start";
            this.Misc_Name.Name = "Misc_Name";
            this.Misc_Name.ReadOnly = true;
            this.Misc_Name.Width = 200;
            // 
            // misc_amount
            // 
            this.misc_amount.HeaderText = "Year End";
            this.misc_amount.Name = "misc_amount";
            this.misc_amount.ReadOnly = true;
            // 
            // frmSchoolYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(868, 647);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.dgvSchoolYear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSchoolYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSchoolYear";
            this.Load += new System.EventHandler(this.frmSchoolYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label SYLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYearEnd;
        private System.Windows.Forms.TextBox txtYearStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EditSYLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEditEnd;
        private System.Windows.Forms.TextBox txtEditStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvSchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Misc_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn misc_amount;
    }
}