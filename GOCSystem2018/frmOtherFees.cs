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
    public partial class frmOtherFees : Form
    {
        public frmOtherFees()
        {
            InitializeComponent();
        }

        private void frmOtherFees_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.BackColor = Color.WhiteSmoke;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            OFLbl.Text = "";
            OFTb.Text = "";
            OFAmountTb.Text = "";
            OFCommentTb.Text = "";
        }//add other fee close button
        private void label19_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EditOFLb.Text = "";
            EditOFTb.Text = "";
            EditOFCommentTb.Text = "";
            EditOFAmountTb.Text = "";
        }//edit other fee close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add other fee window
            panel1.Visible = false;
            OFLbl.Text = "";
            OFTb.Text = "";
            OFAmountTb.Text = "";
            OFCommentTb.Text = "";

            //clear edit other fee window
            panel2.Visible = false;
            EditOFLb.Text = "";
            EditOFTb.Text = "";
            EditOFCommentTb.Text = "";
            EditOFAmountTb.Text = "";

        }//other fee form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }//show OF add window

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }//show edit OF window
    }
}
