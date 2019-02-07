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
        public frmVoucher()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            VoucherLbl.Text = "";
            VoucherTb.Text = "";
            VoucherAmountTb.Text = "";
            VoucherCommentTb.Text = "";
        }//add voucher close button
        private void label19_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EditVoucherLbl.Text = "";
            EditVoucherTb.Text = "";
            EditVoucherAmountTb.Text = "";
            EditVoucherCommentTb.Text = "";
        }//edit voucher close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add voucher window
            panel1.Visible = false;
            VoucherLbl.Text = "";
            VoucherTb.Text = "";
            VoucherAmountTb.Text = "";
            VoucherCommentTb.Text = "";

            //clear edit voucher window
            panel2.Visible = false;
            EditVoucherLbl.Text = "";
            EditVoucherTb.Text = "";
            EditVoucherAmountTb.Text = "";
            EditVoucherCommentTb.Text = "";
        }//voucher form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }//show add voucher window

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }//show edit voucher window
    }
}
