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
    public partial class frmMiscFees : Form
    {
        public frmMiscFees()
        {
            InitializeComponent();
        }

        private void frmMiscFees_Load(object sender, EventArgs e)
        {
           
        }

        private void label18_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            MiscLbl.Text = "";
            MiscTb.Text = "";
            MiscAmountTb.Text = "";
            MiscCommentTb.Text = "";
        }//Add Misc Close button
        private void label19_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EditMiscLbl.Text = "";
            EditMiscTb.Text = "";
            EditMiscCommentTb.Text = "";
            EditMiscAmountTb.Text = "";
        }//edit misc close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add misc window
            panel1.Visible = false;
            MiscLbl.Text = "";
            MiscTb.Text = "";
            MiscAmountTb.Text = "";
            MiscCommentTb.Text = "";

            //clear edit misc window
            panel2.Visible = false;
            EditMiscLbl.Text = "";
            EditMiscTb.Text = "";
            EditMiscCommentTb.Text = "";
            EditMiscAmountTb.Text = "";
        }//Misc form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }//show add misc window

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }//show edit misc window
    }
}
