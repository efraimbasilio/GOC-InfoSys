namespace GOCSystem2018
{
    partial class frmTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacher));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtESpecial = new System.Windows.Forms.TextBox();
            this.txtELName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtEMName = new System.Windows.Forms.TextBox();
            this.txtEditFName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbAdvisory = new System.Windows.Forms.ComboBox();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Advisory2 = new System.Windows.Forms.ComboBox();
            this.Advisory3 = new System.Windows.Forms.ComboBox();
            this.Advisory4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEAdvisory = new System.Windows.Forms.ComboBox();
            this.EditAdvisory2 = new System.Windows.Forms.ComboBox();
            this.EditAdvisory3 = new System.Windows.Forms.ComboBox();
            this.EditAdvisory4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
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
            this.panel3.TabIndex = 42;
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
            this.label16.Size = new System.Drawing.Size(204, 33);
            this.label16.TabIndex = 17;
            this.label16.Text = "Teachers List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtEmpNo);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Advisory4);
            this.panel2.Controls.Add(this.Advisory3);
            this.panel2.Controls.Add(this.Advisory2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSpecial);
            this.panel2.Controls.Add(this.cmbAdvisory);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtMName);
            this.panel2.Controls.Add(this.txtFName);
            this.panel2.Location = new System.Drawing.Point(73, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 355);
            this.panel2.TabIndex = 36;
            this.panel2.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(327, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 17);
            this.label19.TabIndex = 23;
            this.label19.Text = "X";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(264, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Add new Teacher";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(-1, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(349, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EditAdvisory4);
            this.panel1.Controls.Add(this.EditAdvisory3);
            this.panel1.Controls.Add(this.EditAdvisory2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtESpecial);
            this.panel1.Controls.Add(this.cmbEAdvisory);
            this.panel1.Controls.Add(this.txtELName);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.btnCommit);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtEMName);
            this.panel1.Controls.Add(this.txtEditFName);
            this.panel1.Location = new System.Drawing.Point(454, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 355);
            this.panel1.TabIndex = 37;
            this.panel1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(327, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Advisory Class";
            // 
            // txtESpecial
            // 
            this.txtESpecial.Location = new System.Drawing.Point(116, 163);
            this.txtESpecial.Multiline = true;
            this.txtESpecial.Name = "txtESpecial";
            this.txtESpecial.Size = new System.Drawing.Size(191, 20);
            this.txtESpecial.TabIndex = 16;
            // 
            // txtELName
            // 
            this.txtELName.Location = new System.Drawing.Point(116, 136);
            this.txtELName.Multiline = true;
            this.txtELName.Name = "txtELName";
            this.txtELName.Size = new System.Drawing.Size(191, 20);
            this.txtELName.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(50, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "First Name:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(139, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Edit Teacher Info";
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnCommit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.ForeColor = System.Drawing.Color.White;
            this.btnCommit.Location = new System.Drawing.Point(-1, 327);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(349, 27);
            this.btnCommit.TabIndex = 9;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(32, 166);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Specialization:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(56, 139);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Surname:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(41, 113);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "MiddleName:";
            // 
            // txtEMName
            // 
            this.txtEMName.Location = new System.Drawing.Point(116, 110);
            this.txtEMName.Multiline = true;
            this.txtEMName.Name = "txtEMName";
            this.txtEMName.Size = new System.Drawing.Size(191, 20);
            this.txtEMName.TabIndex = 4;
            // 
            // txtEditFName
            // 
            this.txtEditFName.Location = new System.Drawing.Point(116, 84);
            this.txtEditFName.Name = "txtEditFName";
            this.txtEditFName.Size = new System.Drawing.Size(191, 20);
            this.txtEditFName.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 565);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(559, 39);
            this.label15.TabIndex = 38;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTeacher.Location = new System.Drawing.Point(50, 147);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.Size = new System.Drawing.Size(753, 407);
            this.dgvTeacher.TabIndex = 37;
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
            this.btnEdit.Click += new System.EventHandler(this.pictureBox5_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(116, 84);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(191, 20);
            this.txtFName.TabIndex = 2;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(116, 110);
            this.txtMName.Multiline = true;
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(191, 20);
            this.txtMName.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "MiddleName:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Surname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Specialization:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(116, 136);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(191, 20);
            this.txtLastName.TabIndex = 14;
            // 
            // cmbAdvisory
            // 
            this.cmbAdvisory.FormattingEnabled = true;
            this.cmbAdvisory.Location = new System.Drawing.Point(116, 192);
            this.cmbAdvisory.Name = "cmbAdvisory";
            this.cmbAdvisory.Size = new System.Drawing.Size(117, 21);
            this.cmbAdvisory.TabIndex = 15;
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(116, 163);
            this.txtSpecial.Multiline = true;
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(191, 20);
            this.txtSpecial.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Advisory Class";
            // 
            // Advisory2
            // 
            this.Advisory2.FormattingEnabled = true;
            this.Advisory2.Location = new System.Drawing.Point(116, 219);
            this.Advisory2.Name = "Advisory2";
            this.Advisory2.Size = new System.Drawing.Size(117, 21);
            this.Advisory2.TabIndex = 18;
            this.Advisory2.Visible = false;
            // 
            // Advisory3
            // 
            this.Advisory3.FormattingEnabled = true;
            this.Advisory3.Location = new System.Drawing.Point(116, 246);
            this.Advisory3.Name = "Advisory3";
            this.Advisory3.Size = new System.Drawing.Size(117, 21);
            this.Advisory3.TabIndex = 19;
            this.Advisory3.Visible = false;
            // 
            // Advisory4
            // 
            this.Advisory4.FormattingEnabled = true;
            this.Advisory4.Location = new System.Drawing.Point(116, 273);
            this.Advisory4.Name = "Advisory4";
            this.Advisory4.Size = new System.Drawing.Size(117, 21);
            this.Advisory4.TabIndex = 20;
            this.Advisory4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(239, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "+";
            // 
            // cmbEAdvisory
            // 
            this.cmbEAdvisory.FormattingEnabled = true;
            this.cmbEAdvisory.Location = new System.Drawing.Point(116, 192);
            this.cmbEAdvisory.Name = "cmbEAdvisory";
            this.cmbEAdvisory.Size = new System.Drawing.Size(117, 21);
            this.cmbEAdvisory.TabIndex = 15;
            // 
            // EditAdvisory2
            // 
            this.EditAdvisory2.FormattingEnabled = true;
            this.EditAdvisory2.Location = new System.Drawing.Point(116, 219);
            this.EditAdvisory2.Name = "EditAdvisory2";
            this.EditAdvisory2.Size = new System.Drawing.Size(117, 21);
            this.EditAdvisory2.TabIndex = 18;
            this.EditAdvisory2.Visible = false;
            // 
            // EditAdvisory3
            // 
            this.EditAdvisory3.FormattingEnabled = true;
            this.EditAdvisory3.Location = new System.Drawing.Point(116, 246);
            this.EditAdvisory3.Name = "EditAdvisory3";
            this.EditAdvisory3.Size = new System.Drawing.Size(117, 21);
            this.EditAdvisory3.TabIndex = 19;
            this.EditAdvisory3.Visible = false;
            // 
            // EditAdvisory4
            // 
            this.EditAdvisory4.FormattingEnabled = true;
            this.EditAdvisory4.Location = new System.Drawing.Point(116, 273);
            this.EditAdvisory4.Name = "EditAdvisory4";
            this.EditAdvisory4.Size = new System.Drawing.Size(117, 21);
            this.EditAdvisory4.TabIndex = 20;
            this.EditAdvisory4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(239, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(264, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "GOC Employee No.";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(116, 58);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(191, 20);
            this.txtEmpNo.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Employee No.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Specialization";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Advisory";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(868, 647);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTeacher";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtESpecial;
        private System.Windows.Forms.TextBox txtELName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtEMName;
        private System.Windows.Forms.TextBox txtEditFName;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Advisory4;
        private System.Windows.Forms.ComboBox Advisory3;
        private System.Windows.Forms.ComboBox Advisory2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.ComboBox cmbAdvisory;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EditAdvisory4;
        private System.Windows.Forms.ComboBox EditAdvisory3;
        private System.Windows.Forms.ComboBox EditAdvisory2;
        private System.Windows.Forms.ComboBox cmbEAdvisory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}