namespace GOCSystem2018
{
    partial class frmNewStrand
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStrand = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtStrandName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrand)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(670, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 42);
            this.btnAdd.TabIndex = 7799;
            this.btnAdd.Text = "&Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(575, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 7798;
            this.label1.Text = "Strand Name:";
            // 
            // dgvStrand
            // 
            this.dgvStrand.AllowUserToAddRows = false;
            this.dgvStrand.AllowUserToDeleteRows = false;
            this.dgvStrand.BackgroundColor = System.Drawing.Color.White;
            this.dgvStrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvStrand.Location = new System.Drawing.Point(0, 0);
            this.dgvStrand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvStrand.Name = "dgvStrand";
            this.dgvStrand.ReadOnly = true;
            this.dgvStrand.RowHeadersVisible = false;
            this.dgvStrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStrand.Size = new System.Drawing.Size(567, 627);
            this.dgvStrand.TabIndex = 7797;
            this.dgvStrand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStrand_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(761, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 42);
            this.btnCancel.TabIndex = 7804;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(670, 39);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(176, 23);
            this.txtDesc.TabIndex = 7803;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStrandName
            // 
            this.txtStrandName.Location = new System.Drawing.Point(670, 5);
            this.txtStrandName.Name = "txtStrandName";
            this.txtStrandName.Size = new System.Drawing.Size(176, 23);
            this.txtStrandName.TabIndex = 7802;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(583, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 7801;
            this.label2.Text = "Description:";
            // 
            // frmNewStrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 627);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStrand);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtStrandName);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewStrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strand";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStrand;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtStrandName;
        private System.Windows.Forms.Label label2;
    }
}