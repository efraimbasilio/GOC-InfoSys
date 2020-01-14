using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOCSystem2018.Maintenance
{
    public partial class frmNewDiscountFee : Form
    {
        Discount discount = new Discount();
        List<Discount> listDiscount = new List<Discount>();

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
            //dgv.Columns["teacher_id"].HeaderText = "Teacher ID";
            //dgv.Columns["fname"].HeaderText = "First Name";
            //dgv.Columns["mname"].HeaderText = "Middle Name";
            //dgv.Columns["lname"].HeaderText = "Last Name";
            //dgv.Columns["adviser_of"].HeaderText = "Adviser";
            //dgv.Columns["course"].HeaderText = "Course";
            //dgv.Columns["specialize_subject"].HeaderText = "Specialization";

            DataGridViewColumn FillSize = dgv.Columns[1];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }

        public void Reset()
        {
            txtDiscountName.Text = "";
            txtValue.Text = "";
            optAmount.Checked = false;
            optPercent.Checked = false;
            btnAdd.Text = "&Add New";

        }

        public frmNewDiscountFee()
        {
            InitializeComponent();

            discount.LoadDataTable(dgvDiscount);
            AddImageDataGrid(dgvDiscount);
            HeaderFix(dgvDiscount);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&Update")
            {
                util.ValidateTextBox2(txtDiscountName, txtValue);// Validation before Updating

                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    discount.DiscountName = txtDiscountName.Text;
                    if (optAmount.Checked == true)
                    {
                        discount.Id = id;
                        discount.Percentage = "0";
                        discount.DiscountAmount = txtValue.Text;                      
                        discount.Update();
                        Reset();
                    }
                    else
                    {                        
                        if (Convert.ToInt32(txtValue.Text) > 100)//discount to tuition fee
                        {
                            MessageBox.Show("Percentage should be not morethan 100%");
                            txtValue.SelectAll();
                            return;
                        }
                        else
                        {
                            discount.Id = id;
                            discount.Percentage = txtValue.Text;
                            discount.DiscountAmount = "0";
                            discount.Update();
                            Reset();                            
                        }
                    }
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
                util.ValidateTextBox2(txtDiscountName, txtValue);// Validation before saving


                if (util.readyToSave == 1)
                {
                    #region SAVE DISCOUNT
                    discount.DiscountName = txtDiscountName.Text;
                    if (optAmount.Checked == true)
                    {
                        discount.DiscountAmount = txtValue.Text;
                        discount.Percentage = "";
                        discount.Save();
                        Reset();
                    }
                    else
                    {
                        discount.Percentage = txtValue.Text;
                        if (Convert.ToInt32(txtValue.Text) > 100)//discount to tuition fee
                        {
                            MessageBox.Show("Percentage should be not morethan 100%");
                            txtValue.SelectAll();
                            return;
                        }
                        else
                        {
                            discount.DiscountAmount = "";
                            discount.Save();
                            Reset();
                        }
                    }
                    #endregion
                }
                else
                {
                    Reset();
                    return;
                }
            }
            discount.LoadDataTable(dgvDiscount);
        }

        private void dgvDiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {               
                id = Convert.ToInt32(dgvDiscount.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtDiscountName.Text = dgvDiscount.Rows[e.RowIndex].Cells[3].Value.ToString(); //Name

                if (dgvDiscount.Rows[e.RowIndex].Cells[4].Value.ToString() == "" || dgvDiscount.Rows[e.RowIndex].Cells[4].Value.ToString() == "0")
                {
                    txtValue.Text = dgvDiscount.Rows[e.RowIndex].Cells[5].Value.ToString(); //Percentage
                    optPercent.Checked = true;                                      
                }
                else
                {
                    txtValue.Text = dgvDiscount.Rows[e.RowIndex].Cells[4].Value.ToString(); //Amount
                    optAmount.Checked = true;                    
                }
                btnAdd.Text = "&Update";//set button to Update                
            }

            else if (e.ColumnIndex == 1)
            {
                string message = "Do you want to delete this record?";
                string title = "GOC_Grading_System";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Discount discount = new Discount();
                    discount.Id = Convert.ToInt32(dgvDiscount.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    discount.Delete();

                    discount.LoadDataTable(dgvDiscount);
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
