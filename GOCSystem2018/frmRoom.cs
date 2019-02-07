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
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            RoomLbl.Text = "";
            RoomTb.Text = "";
            RoomCapTb.Text = "";
            RoomLocCb.Text = "";
        }//add room close button
        private void label19_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EditRoomLbl.Text = "";
            EditRoomTb.Text = "";
            EditRoomCapTb.Text = "";
            EditRoomLocCb.Text = "";
        }//edit room close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add room window
            panel1.Visible = false;
            RoomLbl.Text = "";
            RoomTb.Text = "";
            RoomCapTb.Text = "";
            RoomLocCb.Text = "";

            //clear edit room window
            panel2.Visible = false;
            EditRoomLbl.Text = "";
            EditRoomTb.Text = "";
            EditRoomCapTb.Text = "";
            EditRoomLocCb.Text = "";
        }//room form close button

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
