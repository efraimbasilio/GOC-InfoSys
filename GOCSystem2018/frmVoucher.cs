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
    public partial class frmVoucher : Form
    {
        Voucher voucher = new Voucher();
        List<Voucher> vouchers = new List<Voucher>();
        public frmVoucher()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            pnlNew.Visible = false;
            VoucherLbl.Text = "";
            txtVoucher.Text = "";
            txtAmount.Text = "";
            txtComment.Text = "";
        }//add voucher close button
        private void label19_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            EditVoucherLbl.Text = "";
            txtEditVoucher.Text = "";
            txtEditAmount.Text = "";
            txtEditComment.Text = "";
        }//edit voucher close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add voucher window
            pnlNew.Visible = false;
            VoucherLbl.Text = "";
            txtVoucher.Text = "";
            txtAmount.Text = "";
            txtComment.Text = "";

            //clear edit voucher window
            pnlEdit.Visible = false;
            EditVoucherLbl.Text = "";
            txtEditVoucher.Text = "";
            txtEditAmount.Text = "";
            txtEditComment.Text = "";
        }//voucher form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlNew.Visible = true;
        }//show add voucher window

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlNew.Visible = false;
            btnAdd.Enabled = false;

            if (dgvVoucher.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                vouchers.Clear();


                voucher.Id = Int32.Parse(dgvVoucher.CurrentRow.Cells[0].FormattedValue.ToString());
                vouchers = voucher.GetById();

                //loop through load it to list view
                foreach (var item in vouchers)
                {
                    //pass value to textboxes
                    txtEditVoucher.Text = item.VoucherFrom;
                    txtEditAmount.Text = item.VoucherAmount;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }

            }
        }//show edit voucher window

        public void LoadRecords()
        {
            //clear list

            dgvVoucher.Rows.Clear();
            vouchers.Clear();

            //pass value to list
            vouchers = voucher.Load();

            //loop through load it to list view
            foreach (var item in vouchers)
            {
                //Load to datagridView
                dgvVoucher.Rows.Add(item.Id, item.VoucherFrom, item.VoucherAmount);

            }
        }//End LoadRecords()

        public void Reset()
        {
            txtVoucher.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtComment.Text = string.Empty;

            txtEditVoucher.Text = string.Empty;
            txtEditAmount.Text = string.Empty;
            txtEditComment.Text = string.Empty;
        }

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            //Load Records
            this.LoadRecords();

            //reset
            this.Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text) || string.IsNullOrEmpty(txtVoucher.Text))
            {
                MessageBox.Show("Please fill up the required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else //Save Method
            {
                //pass values
                voucher.VoucherFrom = txtVoucher.Text;
                voucher.VoucherAmount = txtAmount.Text;

                // call save method
                voucher.Save();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditVoucher.Text) || string.IsNullOrEmpty(txtEditAmount.Text))
            {
                MessageBox.Show("Please fill up the required fields");
                return;
            }
            else //Save Method
            {
                voucher.VoucherFrom = txtEditVoucher.Text;
                voucher.VoucherAmount = txtEditAmount.Text;

                voucher.Id = Int32.Parse(dgvVoucher.CurrentRow.Cells[0].FormattedValue.ToString());
                voucher.Update();

                //Load Records
                this.LoadRecords();
            }
        }

        private void dgvVoucher_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlNew.Visible = false;
            btnAdd.Enabled = false;

            if (dgvVoucher.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                vouchers.Clear();


                voucher.Id = Int32.Parse(dgvVoucher.CurrentRow.Cells[0].FormattedValue.ToString());
                vouchers = voucher.GetById();

                //loop through load it to list view
                foreach (var item in vouchers)
                {
                    //pass value to textboxes
                    txtEditVoucher.Text = item.VoucherFrom;
                    txtEditAmount.Text = item.VoucherAmount;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }

            }
        }

        private void dgvVoucher_Click_1(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlNew.Visible = false;
            btnAdd.Enabled = false;

            if (dgvVoucher.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                vouchers.Clear();


                voucher.Id = Int32.Parse(dgvVoucher.CurrentRow.Cells[0].FormattedValue.ToString());
                vouchers = voucher.GetById();

                //loop through load it to list view
                foreach (var item in vouchers)
                {
                    //pass value to textboxes
                    txtEditVoucher.Text = item.VoucherFrom;
                    txtEditAmount.Text = item.VoucherAmount;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this record ", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans.Equals(DialogResult.Yes))
            {

                //get id
                voucher.Id = Int32.Parse(dgvVoucher.CurrentRow.Cells[0].FormattedValue.ToString());
                voucher.Delete();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();

                pnlEdit.Visible = false;
                pnlNew.Visible = true;
                btnAdd.Enabled = true;
            }
        }
    }
}
