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
        public frmDiscountFee()
        {
            InitializeComponent();
        }
        private void label19_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            DiscountLbl.Text = "";
            DiscountTb.Text = "";
            DiscountAmountTb.Text = "";
            DiscountCommentTb.Text = "";
        }//Add discount close button
        private void label18_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EditDiscountLbl.Text = "";
            EditDiscountTb.Text = "";
            EditDiscountAmountTb.Text = "";
            EditDiscountCommentTb.Text = "";
        }//Edit discount close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear edit discount window
            panel2.Visible = false;
            EditDiscountLbl.Text = "";
            EditDiscountTb.Text = "";
            EditDiscountAmountTb.Text = "";
            EditDiscountCommentTb.Text = "";

            //clear add discount window
            panel4.Visible = false;
            DiscountLbl.Text = "";
            DiscountTb.Text = "";
            DiscountAmountTb.Text = "";
            DiscountCommentTb.Text = "";

        }//Discount form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }//show add discount window
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }//show edit discount window
    }
}
