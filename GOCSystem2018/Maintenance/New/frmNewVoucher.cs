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
    public partial class frmNewVoucher : Form
    {
        Voucher voucher = new Voucher();
        List<Voucher> listvoucher = new List<Voucher>();

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
            txtVoucherName.Text = "";
            txtAmount.Text = "";
            txtDPAmount.Text = "";
            btnAdd.Text = "&Add New";
        }
        
        public frmNewVoucher()
        {
            InitializeComponent();
            voucher.LoadDataTable(dgvVoucher);
            AddImageDataGrid(dgvVoucher);
            HeaderFix(dgvVoucher);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&Update")
            {
                util.ValidateTextBox3(txtAmount, txtDPAmount, txtVoucherName);// Validation before Updating
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                        voucher.Id = id;
                        voucher.VoucherFrom = txtVoucherName.Text;
                        voucher.VoucherAmount = txtAmount.Text;
                        voucher.DpAmount = txtDPAmount.Text;

                        voucher.Update();
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
                util.ValidateTextBox3(txtAmount, txtDPAmount, txtVoucherName);// Validation before saving
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    voucher.Id = id;
                    voucher.VoucherFrom = txtVoucherName.Text;
                    voucher.VoucherAmount = txtAmount.Text;
                    voucher.DpAmount = txtDPAmount.Text;

                    voucher.Update();
                    Reset();
                    #endregion   
                }
                else
                {
                    Reset();
                    return;
                }
            }
            voucher.LoadDataTable(dgvVoucher);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvVoucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvVoucher.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtVoucherName.Text = dgvVoucher.Rows[e.RowIndex].Cells[3].Value.ToString(); //Name     
                txtAmount.Text = dgvVoucher.Rows[e.RowIndex].Cells[4].Value.ToString(); //Name   
                txtDPAmount.Text = dgvVoucher.Rows[e.RowIndex].Cells[5].Value.ToString(); //Name     

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
                    voucher.Id = Convert.ToInt32(dgvVoucher.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    voucher.Delete();

                    voucher.LoadDataTable(dgvVoucher);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
