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
    public partial class frmDiscountFee : Form
    {
        Discount discount = new Discount();
        List<Discount> discounts = new List<Discount>();

        public frmDiscountFee()
        {
            InitializeComponent();
        }

        public void LoadRecords()
        {
            //clear list

            dgvDiscount.Rows.Clear();
            discounts.Clear();

            //pass value to list
            discounts = discount.Load();

            //loop through load it to list view
            foreach (var item in discounts)
            {
                //Load to datagridView
                dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);

            }
        }//End LoadRecords()

        public void Reset()
        {
            txtFeeName.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtComment.Text = string.Empty;

            txtEditName.Text = string.Empty;
            txtEditAmount.Text = string.Empty;
            txtEditComment.Text = string.Empty;
        }






        private void label19_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            DiscountLbl.Text = "";
            txtFeeName.Text = "";
            txtAmount.Text = "";
            txtComment.Text = "";
        }//Add discount close button
        private void label18_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            EditDiscountLbl.Text = "";
            txtEditName.Text = "";
            txtEditAmount.Text = "";
            txtEditComment.Text = "";
        }//Edit discount close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear edit discount window
            pnlEdit.Visible = false;
            EditDiscountLbl.Text = "";
            txtEditName.Text = "";
            txtEditAmount.Text = "";
            txtEditComment.Text = "";

            //clear add discount window
            pnlAdd.Visible = false;
            DiscountLbl.Text = "";
            txtFeeName.Text = "";
            txtAmount.Text = "";
            txtComment.Text = "";

        }//Discount form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }//show add discount window
        

        private void frmDiscountFee_Load(object sender, EventArgs e)
        {
            //Load Records
            this.LoadRecords();

            //reset
            this.Reset();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditName.Text) || string.IsNullOrEmpty(txtEditAmount.Text))
            {
                MessageBox.Show("Please fill up the required fields");
                return;
            }
            else //Save Method
            {
                discount.DiscountName = txtEditName.Text;
                discount.DiscountAmount = txtEditAmount.Text;

                discount.Id = Int32.Parse(dgvDiscount.CurrentRow.Cells[0].FormattedValue.ToString());
                discount.Update();

                //Load Records
                this.LoadRecords();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this record ", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans.Equals(DialogResult.Yes))
            {

                //get id
                discount.Id = Int32.Parse(dgvDiscount.CurrentRow.Cells[0].FormattedValue.ToString());
                discount.Delete();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();

                pnlEdit.Visible = false;
                pnlAdd.Visible = true;
                btnAdd.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFeeName.Text) || string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Please fill up the required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else //Save Method
            {
                //pass values
                discount.DiscountName = txtFeeName.Text;
                discount.DiscountAmount = txtAmount.Text;

                // call save method
                discount.Save();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();
            }
        }

        private void dgvDiscount_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlAdd.Visible = false;
            btnAdd.Enabled = false;

            if (dgvDiscount.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                discounts.Clear();


                discount.Id = Int32.Parse(dgvDiscount.CurrentRow.Cells[0].FormattedValue.ToString());
                discounts = discount.GetById();

                //loop through load it to list view
                foreach (var item in discounts)
                {
                    //pass value to textboxes
                    txtEditName.Text = item.DiscountName;
                    txtEditAmount.Text = item.DiscountAmount;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            pnlEdit.Visible = true;
            pnlAdd.Visible = false;
            btnAdd.Enabled = false;

            if (dgvDiscount.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                discounts.Clear();


                discount.Id = Int32.Parse(dgvDiscount.CurrentRow.Cells[0].FormattedValue.ToString());
                discounts = discount.GetById();

                //loop through load it to list view
                foreach (var item in discounts)
                {
                    //pass value to textboxes
                    txtEditName.Text = item.DiscountName;
                    txtEditAmount.Text = item.DiscountAmount;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }

            }
        }
    }
}
