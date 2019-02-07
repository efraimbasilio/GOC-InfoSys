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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            UserLbl.Text = "";
            UserTb.Text = "";
            PwTb.Text = "";
            ConPwTb.Text = "";
            ATCb.Text = "";
        }//add user close window
        private void label19_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EditUserLbl.Text = "";
            EditUserTb.Text = "";
            EditPwTb.Text = "";
            EditConPwTb.Text = "";
            EditATCb.Text = "";
        }//edit user close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add user window
            panel1.Visible = false;
            UserLbl.Text = "";
            UserTb.Text = "";
            PwTb.Text = "";
            ConPwTb.Text = "";
            ATCb.Text = "";

            //clear edit user window
            panel2.Visible = false;
            EditUserLbl.Text = "";
            EditUserTb.Text = "";
            EditPwTb.Text = "";
            EditConPwTb.Text = "";
            EditATCb.Text = "";
        }//user form close button

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
