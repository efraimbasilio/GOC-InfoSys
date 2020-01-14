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
    public partial class frmNewOtherFee : Form
    {
        OtherFee otherFee = new OtherFee();
        List<OtherFee> listotherFee = new List<OtherFee>();

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
            txtOtherFeeName.Text = "";
            txtAmount.Text = "";
            cmbStrand.Text = "";
            btnAdd.Text = "&Add New";
        }

        public frmNewOtherFee()
        {
            InitializeComponent();
            otherFee.LoadDataTable(dgvOtherFee);
            AddImageDataGrid(dgvOtherFee);
            HeaderFix(dgvOtherFee);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&Update")
            {
                util.ValidateTextBox2(txtAmount, txtOtherFeeName);// Validation before Updating
                util.ValidateCombobox(cmbStrand);

                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    otherFee.Id = id;
                    otherFee.OtherFeeName = txtOtherFeeName.Text;
                    otherFee.OtherFeeAmount = Convert.ToDouble(txtAmount.Text);
                    otherFee.Strand = cmbStrand.Text;

                    otherFee.Update();
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
                util.ValidateTextBox2(txtAmount, txtOtherFeeName);// Validation before saving
                util.ValidateCombobox(cmbStrand);

                if (util.readyToSave == 1)
                {
                    #region SAVE DISCOUNT
                    otherFee.Id = id;
                    otherFee.OtherFeeName = txtOtherFeeName.Text;
                    otherFee.OtherFeeAmount = Convert.ToDouble(txtAmount.Text);
                    otherFee.Strand = cmbStrand.Text;

                    otherFee.Save();
                    Reset();
                    #endregion   
                }
                else
                {
                    Reset();
                    return;
                }
            }

            otherFee.LoadDataTable(dgvOtherFee);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvOtherFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvOtherFee.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtOtherFeeName.Text = dgvOtherFee.Rows[e.RowIndex].Cells[3].Value.ToString(); //Name     
                txtAmount.Text = dgvOtherFee.Rows[e.RowIndex].Cells[4].Value.ToString(); //Name   
                cmbStrand.Text = dgvOtherFee.Rows[e.RowIndex].Cells[5].Value.ToString(); //Name     

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
                    otherFee.Id = Convert.ToInt32(dgvOtherFee.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    otherFee.Delete();

                    otherFee.LoadDataTable(dgvOtherFee);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
