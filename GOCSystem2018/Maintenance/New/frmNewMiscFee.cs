using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOCSystem2018
{
    public partial class frmNewMiscFee : Form
    {
        MiscFee miscFee = new MiscFee();
        List<MiscFee> listmiscFee = new List<MiscFee>();

        Util_RequiredFields util = new Util_RequiredFields();

        public int id;

        public void AddImageDataGrid(DataGridView dgv)
        {
            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.edit;
            dimg.HeaderText = "Edit";
            dimg.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimg);


            DataGridViewImageColumn dimgDelete = new DataGridViewImageColumn();
            dimgDelete.Image = Properties.Resources.delete;
            dimgDelete.HeaderText = "Delete";
            dimgDelete.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimgDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimgDelete);
        }

        public void HeaderFix(DataGridView dgv)
        {
            #region Header Name
            dgv.Columns["id"].Visible = false;           

            DataGridViewColumn FillSize = dgv.Columns[1];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }

        public void Reset()
        {
            txtMiscName.Text = "";
            txtAmount.Text = "";            
            btnAdd.Text = "&Add New";
        }
      
        public frmNewMiscFee()
        {
            InitializeComponent();
            miscFee.LoadDataTable(dgvMiscFee);
            AddImageDataGrid(dgvMiscFee);
            HeaderFix(dgvMiscFee);
        }

        private void dgvMiscFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvMiscFee.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtMiscName.Text = dgvMiscFee.Rows[e.RowIndex].Cells[3].Value.ToString(); //Name     
                txtAmount.Text = dgvMiscFee.Rows[e.RowIndex].Cells[4].Value.ToString(); //Name    
                         
                btnAdd.Text = "&Update";//set button to Update                
            }

            else if (e.ColumnIndex == 1)
            {
                string message = "Do you want to delete this record?";
                string title = "Enrollment System";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MiscFee miscFee = new MiscFee();
                    miscFee.Id = Convert.ToInt32(dgvMiscFee.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    miscFee.Delete();

                    miscFee.LoadDataTable(dgvMiscFee);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&Update")
            {
                util.ValidateTextBox2(txtAmount, txtMiscName);// Validation before Updating
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    miscFee.Id = id;
                    miscFee.MiscFeeName = txtMiscName.Text;
                    miscFee.MiscFeeAmount = Convert.ToDouble(txtAmount.Text);
                    miscFee.Update();
                    Reset();
                    #endregion              
                }
                else
                {
                    Reset();
                    return;
                }
            }
            else
            {
                util.ValidateTextBox2(txtAmount, txtMiscName);// Validation before saving
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    miscFee.Id = id;
                    miscFee.MiscFeeName = txtMiscName.Text;
                    miscFee.MiscFeeAmount = Convert.ToDouble(txtAmount.Text);
                    miscFee.Update();
                    Reset();
                    #endregion   
                }
                else
                {
                    Reset();
                    return;
                }
            }
            miscFee.LoadDataTable(dgvMiscFee);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }


    }
}
