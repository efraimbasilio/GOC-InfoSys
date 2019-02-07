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
    public partial class frmSubject : Form
    {
        public frmSubject()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            SubjectLbl.Text = "";
            SubjectTb.Text = "";
            SubjectDescTb.Text = "";
        }//add window close button
        private void label19_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EditSubjectLbl.Text = "";
            EditSubjectTb.Text = "";
            EditSubjectDescTb.Text = "";
        }//edit window close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add subject window
            panel1.Visible = false;
            SubjectLbl.Text = "";
            SubjectTb.Text = "";
            SubjectDescTb.Text = "";

            //clear edit subject window
            panel2.Visible = false;
            EditSubjectLbl.Text = "";
            EditSubjectTb.Text = "";
            EditSubjectDescTb.Text = "";
        }//subject window close button

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
