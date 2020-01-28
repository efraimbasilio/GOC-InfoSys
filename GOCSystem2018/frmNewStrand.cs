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
    public partial class frmNewStrand : Form
    {
        Strand strand = new Strand();
        List<Strand> listStrand = new List<Strand>();

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
            txtStrandName.Text = "";
            txtDesc.Text = "";            
            btnAdd.Text = "&Add New";
        }

        public frmNewStrand()
        {
            InitializeComponent();
            strand.LoadDataTable(dgvStrand);
            AddImageDataGrid(dgvStrand);
            HeaderFix(dgvStrand);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&Update")
            {
                util.ValidateTextBox2(txtStrandName, txtDesc);// Validation before Updating
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    strand.Id = id;
                    strand.StrandDesc = txtDesc.Text;
                    strand.StrandName = txtStrandName.Text;
                    strand.Update();
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
                util.ValidateTextBox2(txtStrandName, txtDesc);// Validation before saving
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    strand.Id = id;
                    strand.StrandDesc = txtDesc.Text;
                    strand.StrandName = txtStrandName.Text;
                    strand.Save();
                    Reset();
                    #endregion   
                }
                else
                {
                    Reset();
                    return;
                }
            }
            strand.LoadDataTable(dgvStrand);
        }

        private void dgvStrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvStrand.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtStrandName.Text = dgvStrand.Rows[e.RowIndex].Cells[3].Value.ToString(); //Name     
                txtDesc.Text = dgvStrand.Rows[e.RowIndex].Cells[4].Value.ToString(); //Name    

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
                    strand.Id = Convert.ToInt32(dgvStrand.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    strand.Delete();

                    strand.LoadDataTable(dgvStrand);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
