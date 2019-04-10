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
        Room room = new Room();
        List<Room> rooms = new List<Room>();
        public frmRoom()
        {
            InitializeComponent();
        }

        public void LoadRecords()
        {
            //clear list

            dgvRoom.Rows.Clear();
            rooms.Clear();

            //pass value to list
            rooms = room.Load();

            //loop through load it to list view
            foreach (var item in rooms)
            {
                //Load to datagridView
                dgvRoom.Rows.Add(item.Id, item.RoomName, item.RoomCapacity, item.RoomLocation, item.RoomCeiling);

            }
        }//End LoadRecords()

        public void Reset()
        {
            txtRoomName.Text = string.Empty;
            txtCapacity.Text = string.Empty;
            cmbLocation.Text = string.Empty;
            txtRoomCeiling.Text = string.Empty;


            txtEditRoom.Text = string.Empty;
            txtEditCapacity.Text = string.Empty;
            cmbEditLocation.Text = string.Empty;
            txtEditRoomCeiling.Text = string.Empty;
        }




        private void label18_Click(object sender, EventArgs e)
        {
            pnlNew.Visible = false;
            RoomLbl.Text = "";
            txtRoomName.Text = "";
            txtCapacity.Text = "";
            cmbLocation.Text = "";
            txtRoomCeiling.Text = string.Empty;

        }//add room close button
        private void label19_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            EditRoomLbl.Text = "";
            txtEditRoom.Text = "";
            txtEditCapacity.Text = "";
            cmbEditLocation.Text = "";
            txtEditRoomCeiling.Text = string.Empty;

        }//edit room close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add room window
            pnlNew.Visible = false;
            RoomLbl.Text = "";
            txtRoomName.Text = "";
            txtCapacity.Text = "";
            cmbLocation.Text = "";
            txtRoomCeiling.Text = string.Empty;

            //clear edit room window
            pnlEdit.Visible = false;
            EditRoomLbl.Text = "";
            txtEditRoom.Text = "";
            txtEditCapacity.Text = "";
            cmbEditLocation.Text = "";
            txtEditRoomCeiling.Text = string.Empty;

        }//room form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlNew.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pnlEdit.Visible = true;
            pnlNew.Visible = false;
            btnAdd.Enabled = false;

            if (dgvRoom.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                rooms.Clear();


                room.Id = Int32.Parse(dgvRoom.CurrentRow.Cells[0].FormattedValue.ToString());
                rooms = room.GetById();

                //loop through load it to list view
                foreach (var item in rooms)
                {
                    //pass value to textboxes
                    txtEditRoom.Text = item.RoomName;
                    txtEditCapacity.Text = item.RoomCapacity;
                    cmbEditLocation.Text = item.RoomLocation;
                    txtEditRoomCeiling.Text = item.RoomCeiling;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomName.Text) || string.IsNullOrEmpty(txtCapacity.Text))
            {
                MessageBox.Show("Please fill up the required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else //Save Method
            {
                //pass values
                room.RoomName = txtRoomName.Text;
                room.RoomCapacity = txtCapacity.Text;
                room.RoomLocation = cmbLocation.Text;
                room.RoomCeiling = txtRoomCeiling.Text;
                // call save method
                room.Save();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditRoom.Text) || string.IsNullOrEmpty(txtEditCapacity.Text))
            {
                MessageBox.Show("Please fill up the required fields");
                return;
            }
            else //Save Method
            {
                room.RoomName = txtEditRoom.Text;
                room.RoomCapacity = txtEditCapacity.Text;
                room.RoomLocation = cmbEditLocation.Text;
                room.RoomCeiling = txtRoomCeiling.Text;

                room.Id = Int32.Parse(dgvRoom.CurrentRow.Cells[0].FormattedValue.ToString());
                room.Update();

                //Load Records
                this.LoadRecords();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this record ", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans.Equals(DialogResult.Yes))
            {

                //get id
                room.Id = Int32.Parse(dgvRoom.CurrentRow.Cells[0].FormattedValue.ToString());
                room.Delete();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();

                pnlEdit.Visible = false;
                pnlNew.Visible = true;
                btnAdd.Enabled = true;
            }
        }

        private void dgvRoom_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlNew.Visible = false;
            btnAdd.Enabled = false;

            if (dgvRoom.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                rooms.Clear();


                room.Id = Int32.Parse(dgvRoom.CurrentRow.Cells[0].FormattedValue.ToString());
                rooms = room.GetById();

                //loop through load it to list view
                foreach (var item in rooms)
                {
                    //pass value to textboxes
                    txtEditRoom.Text = item.RoomName;
                    txtEditCapacity.Text = item.RoomCapacity;
                    cmbEditLocation.Text = item.RoomLocation;
                    txtEditRoomCeiling.Text = item.RoomCeiling;
                }
            }
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            //Load Records
            this.LoadRecords();

            //reset
            this.Reset();
        }
    }
}
