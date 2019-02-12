namespace GOCSystem2018
{
    partial class frmAssesment
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLRN = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearhAssesment = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.cmbStrand = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMOP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTrack = new System.Windows.Forms.Label();
            this.lblGOCNo = new System.Windows.Forms.Label();
            this.btnAsses = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(106, 121);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Student Name";
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Location = new System.Drawing.Point(106, 145);
            this.lblGradeLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(86, 15);
            this.lblGradeLevel.TabIndex = 3;
            this.lblGradeLevel.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Grade Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Section:";
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(697, 234);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(95, 23);
            this.cmbSection.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Strand:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 152);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "School Year:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 168);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Track:";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(106, 94);
            this.lblRegNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(86, 15);
            this.lblRegNo.TabIndex = 13;
            this.lblRegNo.Text = "Student Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Student No:";
            // 
            // lblLRN
            // 
            this.lblLRN.AutoSize = true;
            this.lblLRN.Location = new System.Drawing.Point(57, 14);
            this.lblLRN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLRN.Name = "lblLRN";
            this.lblLRN.Size = new System.Drawing.Size(53, 15);
            this.lblLRN.TabIndex = 15;
            this.lblLRN.Text = "LRN_no";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 14);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "LRN:";
            // 
            // txtSearhAssesment
            // 
            this.txtSearhAssesment.Location = new System.Drawing.Point(553, 41);
            this.txtSearhAssesment.Name = "txtSearhAssesment";
            this.txtSearhAssesment.Size = new System.Drawing.Size(168, 21);
            this.txtSearhAssesment.TabIndex = 16;
            this.txtSearhAssesment.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(739, 22);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 15);
            this.label16.TabIndex = 18;
            this.label16.Text = "Pending";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(691, 22);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 15);
            this.label17.TabIndex = 17;
            this.label17.Text = "Status:";
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchoolYear.FormattingEnabled = true;
            this.cmbSchoolYear.Location = new System.Drawing.Point(697, 148);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(95, 23);
            this.cmbSchoolYear.TabIndex = 19;
            // 
            // cmbStrand
            // 
            this.cmbStrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStrand.FormattingEnabled = true;
            this.cmbStrand.Location = new System.Drawing.Point(697, 176);
            this.cmbStrand.Name = "cmbStrand";
            this.cmbStrand.Size = new System.Drawing.Size(95, 23);
            this.cmbStrand.TabIndex = 20;
            this.cmbStrand.SelectedIndexChanged += new System.EventHandler(this.cmbStrand_SelectedIndexChanged);
            this.cmbStrand.SelectedValueChanged += new System.EventHandler(this.cmbStrand_SelectedValueChanged);
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "First",
            "Second"});
            this.cmbSemester.Location = new System.Drawing.Point(697, 205);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(95, 23);
            this.cmbSemester.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Semester";
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToAddRows = false;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subjects,
            this.Desc});
            this.dgvSubject.Location = new System.Drawing.Point(12, 189);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.ReadOnly = true;
            this.dgvSubject.Size = new System.Drawing.Size(547, 427);
            this.dgvSubject.TabIndex = 24;
            // 
            // Subjects
            // 
            this.Subjects.HeaderText = "Subject Code";
            this.Subjects.Name = "Subjects";
            this.Subjects.ReadOnly = true;
            this.Subjects.Width = 200;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Description";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Width = 300;
            // 
            // cmbMOP
            // 
            this.cmbMOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMOP.FormattingEnabled = true;
            this.cmbMOP.Items.AddRange(new object[] {
            "Full Payment",
            "Partial Payment"});
            this.cmbMOP.Location = new System.Drawing.Point(697, 119);
            this.cmbMOP.Name = "cmbMOP";
            this.cmbMOP.Size = new System.Drawing.Size(95, 23);
            this.cmbMOP.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mode of Payment:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 27);
            this.button1.TabIndex = 28;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(106, 168);
            this.lblTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(58, 15);
            this.lblTrack.TabIndex = 29;
            this.lblTrack.Text = "Tech-Voc";
            // 
            // lblGOCNo
            // 
            this.lblGOCNo.AutoSize = true;
            this.lblGOCNo.Location = new System.Drawing.Point(106, 72);
            this.lblGOCNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGOCNo.Name = "lblGOCNo";
            this.lblGOCNo.Size = new System.Drawing.Size(133, 15);
            this.lblGOCNo.TabIndex = 30;
            this.lblGOCNo.Text = "__________________";
            // 
            // btnAsses
            // 
            this.btnAsses.Location = new System.Drawing.Point(613, 263);
            this.btnAsses.Name = "btnAsses";
            this.btnAsses.Size = new System.Drawing.Size(66, 27);
            this.btnAsses.TabIndex = 31;
            this.btnAsses.Text = "Asses";
            this.btnAsses.UseVisualStyleBackColor = true;
            this.btnAsses.Click += new System.EventHandler(this.btnAsses_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "SPECIALIZED SUBJECTS",
            "CORE SUBJECTS",
            "APPLIED SUBJECTS"});
            this.cmbType.Location = new System.Drawing.Point(697, 263);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(95, 23);
            this.cmbType.TabIndex = 32;
            // 
            // frmAssesment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 628);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnAsses);
            this.Controls.Add(this.lblGOCNo);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbMOP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvSubject);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbStrand);
            this.Controls.Add(this.cmbSchoolYear);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtSearhAssesment);
            this.Controls.Add(this.lblLRN);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGradeLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAssesment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAssesment";
            this.Load += new System.EventHandler(this.frmAssesment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblLRN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearhAssesment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbSchoolYear;
        private System.Windows.Forms.ComboBox cmbStrand;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.ComboBox cmbMOP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Label lblGOCNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.Button btnAsses;
        private System.Windows.Forms.ComboBox cmbType;
    }
}