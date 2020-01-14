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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            //TeachLbl.Text = "";
            txtFName.Text = "";
            txtMName.Text = "";
            txtLastName.Text = "";
            txtSpecial.Text = "";
            cmbAdvisory.Text = "";
            Advisory2.Text = "";
            Advisory3.Text = "";
            Advisory4.Text = "";
        }//add teacher close button
        private void label4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
           // EditTeachLbl.Text = "";
            txtEditFName.Text = "";
            txtEMName.Text = "";
            txtELName.Text = "";
            txtESpecial.Text = "";
            cmbEAdvisory.Text = "";
            EditAdvisory2.Text = "";
            EditAdvisory3.Text = "";
            EditAdvisory4.Text = "";
        }//edit teacher close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add teacher window
            panel2.Visible = false;
            //TeachLbl.Text = "";
            txtFName.Text = "";
            txtMName.Text = "";
            txtLastName.Text = "";
            txtSpecial.Text = "";
            cmbAdvisory.Text = "";
            Advisory2.Text = "";
            Advisory3.Text = "";
            Advisory4.Text = "";

            //clear edit teacher window
            panel1.Visible = false;
            //EditTeachLbl.Text = "";
            txtEditFName.Text = "";
            txtEMName.Text = "";
            txtELName.Text = "";
            txtESpecial.Text = "";
            cmbEAdvisory.Text = "";
            EditAdvisory2.Text = "";
            EditAdvisory3.Text = "";
            EditAdvisory4.Text = "";
        }//teachers form close button

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }//show add teacher window

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }//show edit teacher window
    }
}
