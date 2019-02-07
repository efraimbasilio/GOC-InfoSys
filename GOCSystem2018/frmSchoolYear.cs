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
    public partial class frmSchoolYear : Form
    {
        public frmSchoolYear()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            YSTb.Text = "";
            YETb.Text = "";
        }//add SY close button

        private void label19_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EditYSTb.Text = "";
            EditYETb.Text = "";
        }//edit SY close button

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add SY window
            panel1.Visible = false;
            YSTb.Text = "";
            YETb.Text = "";

            //clear edit SY window
            panel2.Visible = false;
            EditYSTb.Text = "";
            EditYETb.Text = "";

        }//SY form close button

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
