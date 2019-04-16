namespace GOCSystem2018
{
    partial class frmSetting
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDSN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveConfiguration = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 141;
            this.button1.Text = "Report Viewer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDSN
            // 
            this.txtDSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDSN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDSN.Location = new System.Drawing.Point(173, 72);
            this.txtDSN.Name = "txtDSN";
            this.txtDSN.Size = new System.Drawing.Size(200, 23);
            this.txtDSN.TabIndex = 129;
            this.txtDSN.Text = "GOCINFOSYS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 140;
            this.label4.Text = "Data Source Name : *";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(202, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(190, 28);
            this.btnClose.TabIndex = 135;
            this.btnClose.Text = "Clos&e";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(173, 139);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 131;
            this.txtName.Text = "goc_info_sys";
            // 
            // txtHost
            // 
            this.txtHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHost.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(173, 105);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(200, 23);
            this.txtHost.TabIndex = 130;
            this.txtHost.Text = "CLABSERVER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 137;
            this.label3.Text = "Database Name : *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 136;
            this.label2.Text = "Host : *";
            // 
            // btnSaveConfiguration
            // 
            this.btnSaveConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfiguration.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfiguration.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveConfiguration.Location = new System.Drawing.Point(-1, 308);
            this.btnSaveConfiguration.Name = "btnSaveConfiguration";
            this.btnSaveConfiguration.Size = new System.Drawing.Size(203, 28);
            this.btnSaveConfiguration.TabIndex = 134;
            this.btnSaveConfiguration.Text = "Save";
            this.btnSaveConfiguration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveConfiguration.UseVisualStyleBackColor = false;
            this.btnSaveConfiguration.Click += new System.EventHandler(this.btnSaveConfiguration_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(173, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 133;
            this.txtPassword.Text = "0332018";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(173, 172);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 23);
            this.txtUser.TabIndex = 132;
            this.txtUser.Text = "emaru04";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 139;
            this.label1.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 138;
            this.label5.Text = "Username : *";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 142;
            this.button2.Text = "MAIN MENU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(146, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 1022;
            this.label6.Text = "Settings";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(390, 335);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDSN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveConfiguration);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSetting_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDSN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveConfiguration;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}