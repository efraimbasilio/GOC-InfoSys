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
    public partial class frmStrand : Form
    {
        public frmStrand()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            StrandLbl.Text = "";
            StrandTb.Text = "";
            StrandDescTb.Text = "";
        }//add strand window close button
        private void label19_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EditStrandLbl.Text = "";
            EditStrandTb.Text = "";
            EditStrandDescTb.Text = "";
        }//edit strand window close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add strand window
            panel1.Visible = true;
            StrandLbl.Text = "";
            StrandTb.Text = "";
            StrandDescTb.Text = "";

            //clear edit strand window
            panel2.Visible = false;
            EditStrandLbl.Text = "";
            EditStrandTb.Text = "";
            EditStrandDescTb.Text = "";
        }//strand form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
