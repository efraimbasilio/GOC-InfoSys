namespace GOCSystem2018.Maintenance
{
    partial class frmNewDiscountFee
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
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optPercent = new System.Windows.Forms.RadioButton();
            this.optAmount = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscountName = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AllowUserToAddRows = false;
            this.dgvDiscount.AllowUserToDeleteRows = false;
            this.dgvDiscount.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDiscount.Location = new System.Drawing.Point(0, 0);
            this.dgvDiscount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.ReadOnly = true;
            this.dgvDiscount.RowHeadersVisible = false;
            this.dgvDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscount.Size = new System.Drawing.Size(567, 633);
            this.dgvDiscount.TabIndex = 4;
            this.dgvDiscount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscount_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(575, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 7782;
            this.label1.Text = "Discount Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(579, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 36);
            this.btnAdd.TabIndex = 7791;
            this.btnAdd.Text = "&Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.optPercent);
            this.panel1.Controls.Add(this.optAmount);
            this.panel1.Location = new System.Drawing.Point(670, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 35);
            this.panel1.TabIndex = 7792;
            // 
            // optPercent
            // 
            this.optPercent.AutoSize = true;
            this.optPercent.Location = new System.Drawing.Point(99, 7);
            this.optPercent.Name = "optPercent";
            this.optPercent.Size = new System.Drawing.Size(82, 19);
            this.optPercent.TabIndex = 1;
            this.optPercent.TabStop = true;
            this.optPercent.Text = "Percentage";
            this.optPercent.UseVisualStyleBackColor = true;
            // 
            // optAmount
            // 
            this.optAmount.AutoSize = true;
            this.optAmount.Location = new System.Drawing.Point(8, 7);
            this.optAmount.Name = "optAmount";
            this.optAmount.Size = new System.Drawing.Size(64, 19);
            this.optAmount.TabIndex = 0;
            this.optAmount.TabStop = true;
            this.optAmount.Text = "Amount";
            this.optAmount.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(625, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 7793;
            this.label2.Text = "Value:";
            // 
            // txtDiscountName
            // 
            this.txtDiscountName.Location = new System.Drawing.Point(670, 55);
            this.txtDiscountName.Name = "txtDiscountName";
            this.txtDiscountName.Size = new System.Drawing.Size(176, 23);
            this.txtDiscountName.TabIndex = 7794;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(670, 84);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(104, 23);
            this.txtValue.TabIndex = 7795;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(670, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 36);
            this.btnCancel.TabIndex = 7796;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNewDiscountFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 633);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtDiscountName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDiscount);
            this.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewDiscountFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discount";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton optPercent;
        private System.Windows.Forms.RadioButton optAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscountName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnCancel;
    }
}