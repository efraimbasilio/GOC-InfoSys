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
    public partial class frmSection : Form
    {
        public frmSection()
        {
            InitializeComponent();
        }
        private void label18_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            SectionLbl.Text = "";
            SectionTb.Text = "";
            DescTb.Text = "";
        }//add section close button
        private void label19_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            EditSectionLbl.Text = "";
            EditSectionTb.Text = "";
            EditDescTb.Text = "";
        }//edit section close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add section window
            panel1.Visible = true;
            SectionLbl.Text = "";
            SectionTb.Text = "";
            DescTb.Text = "";

            //clear edit section window
            panel2.Visible = true;
            EditSectionLbl.Text = "";
            EditSectionTb.Text = "";
            EditDescTb.Text = "";
        }//section form close button

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
