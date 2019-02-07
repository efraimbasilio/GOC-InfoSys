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
    public partial class frmSched : Form
    {
        public frmSched()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            SchedLbl.Text = "";
            SectionCb.Text = "";
            RoomCb.Text = "";
            TeachCb.Text = "";
            SubjectCb.Text = "";
        }//clear add sched window
        private void label19_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EditSchedLbl.Text = "";
            EditSectionCb.Text = "";
            EditRoomCb.Text = "";
            EditTeachCb.Text = "";
            EditSubjectCb.Text = "";
        }//clear edit sched window
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add sched window
            panel1.Visible = false;
            SchedLbl.Text = "";
            SectionCb.Text = "";
            RoomCb.Text = "";
            TeachCb.Text = "";
            SubjectCb.Text = "";

            //clear edit sched window
            panel2.Visible = false;
            EditSchedLbl.Text = "";
            EditSectionCb.Text = "";
            EditRoomCb.Text = "";
            EditTeachCb.Text = "";
            EditSubjectCb.Text = "";
        }//sched form close button

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
