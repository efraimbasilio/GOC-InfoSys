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
    public partial class frmNewTuitionFee : Form
    {
        Models.TuitionFee tuition = new Models.TuitionFee();
        List<Models.TuitionFee> listTuition = new List<Models.TuitionFee>();

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

            DataGridViewColumn FillSize2 = dgv.Columns[3];
            FillSize2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            #endregion
        }

        public void Reset()
        {
            txtTuitionFeeName.Text = "";
            txtAmount.Text = "";
            txtDesc.Text = "";
            cmbStatus.Text = "";
            cmbDept.Text = "";
            txtReservation.Text = "";

            //optAmount.Checked = false;
            //optPercent.Checked = false;
            btnAdd.Text = "&Add New";

        }

        public frmNewTuitionFee()
        {
            InitializeComponent();
            tuition.LoadDataTable(dgvTuitionFee);
            AddImageDataGrid(dgvTuitionFee);
            HeaderFix(dgvTuitionFee);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&Update")
            {
                util.ValidateTextBox4(txtAmount, txtDesc,txtReservation, txtTuitionFeeName);// Validation before Updating
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    tuition.Id = id;
                    tuition.TuitionFeeName = txtTuitionFeeName.Text;
                    tuition.TuitionFeeDescription = txtDesc.Text;
                    tuition.TuitionFeeAmount = txtAmount.Text;
                    tuition.ReservationFee = txtReservation.Text;
                    tuition.Dept = cmbDept.Text;
                    tuition.Status = cmbStatus.Text;                   
                    tuition.Update();

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
                util.ValidateTextBox4(txtAmount, txtDesc, txtReservation, txtTuitionFeeName);// Validation before saving
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    tuition.Id = id;
                    tuition.TuitionFeeName = txtTuitionFeeName.Text;
                    tuition.TuitionFeeDescription = txtDesc.Text;
                    tuition.TuitionFeeAmount = txtAmount.Text;
                    tuition.ReservationFee = txtReservation.Text;
                    tuition.Dept = cmbDept.Text;
                    tuition.Status = cmbStatus.Text;
                   

                    tuition.Save();
                    Reset();
                    #endregion   
                }
                else
                {
                    Reset();
                    return;
                }
            }
            tuition.LoadDataTable(dgvTuitionFee);
        }

        private void dgvTuitionFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvTuitionFee.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtTuitionFeeName.Text = dgvTuitionFee.Rows[e.RowIndex].Cells[3].Value.ToString(); //Name     
                txtAmount.Text = dgvTuitionFee.Rows[e.RowIndex].Cells[4].Value.ToString(); //Name    
                txtDesc.Text = dgvTuitionFee.Rows[e.RowIndex].Cells[5].Value.ToString(); //Name 
                cmbStatus.Text= dgvTuitionFee.Rows[e.RowIndex].Cells[6].Value.ToString(); //Name 
                cmbDept.Text = dgvTuitionFee.Rows[e.RowIndex].Cells[7].Value.ToString(); //Name 
                txtReservation.Text = dgvTuitionFee.Rows[e.RowIndex].Cells[8].Value.ToString(); //Name 

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
                    tuition.Id = Convert.ToInt32(dgvTuitionFee.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    tuition.Delete();

                    tuition.LoadDataTable(dgvTuitionFee);
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
