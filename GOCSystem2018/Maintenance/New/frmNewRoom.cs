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
    public partial class frmNewRoom : Form
    {
        Room room = new Room();
        List<Room> listRoom = new List<Room>();

        Util_RequiredFields util = new Util_RequiredFields();

        public int id;

        public void AddImageDataGrid(DataGridView dgv)
        {
            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.edit;
            dimg.HeaderText = "Edit";
            dimg.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimg);


            DataGridViewImageColumn dimgDelete = new DataGridViewImageColumn();
            dimgDelete.Image = Properties.Resources.delete;
            dimgDelete.HeaderText = "Delete";
            dimgDelete.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimgDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimgDelete);
        }

        public void HeaderFix(DataGridView dgv)
        {
            #region Header Name
            dgv.Columns["id"].Visible = false;

            DataGridViewColumn FillSize = dgv.Columns[1];
            FillSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }

        public void Reset()
        {
            txtRoomName.Text = "";
            txtLocation.Text = "";
            txtCeiling.Text = "";
            txtCapacity.Text = "";
            btnAdd.Text = "&Add New";
        }


        public frmNewRoom()
        {
            InitializeComponent();
            room.LoadDataTable(dgvRoom);
            AddImageDataGrid(dgvRoom);
            HeaderFix(dgvRoom);
        }

        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvRoom.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtRoomName.Text = dgvRoom.Rows[e.RowIndex].Cells[3].Value.ToString(); //Name     
                txtLocation.Text = dgvRoom.Rows[e.RowIndex].Cells[4].Value.ToString(); //Name    
                txtCapacity.Text = dgvRoom.Rows[e.RowIndex].Cells[5].Value.ToString(); //Name  
                txtCeiling.Text = dgvRoom.Rows[e.RowIndex].Cells[6].Value.ToString(); //Name  

                btnAdd.Text = "&Update";//set button to Update                
            }

            else if (e.ColumnIndex == 1)
            {
                string message = "Do you want to delete this record?";
                string title = "Enrollment System";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    
                    room.Id = Convert.ToInt32(dgvRoom.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    room.Delete();

                    room.LoadDataTable(dgvRoom);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "&Update")
            {
                util.ValidateTextBox4(txtCapacity, txtCeiling, txtLocation, txtRoomName);// Validation before Updating
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    room.Id = id;
                    room.RoomCapacity = txtCapacity.Text;
                    room.RoomCeiling = txtCeiling.Text;
                    room.RoomLocation = txtLocation.Text;
                    room.RoomName = txtRoomName.Text;
                    room.Update();
                    Reset();
                    #endregion              
                }
                else
                {
                    Reset();
                    return;
                }
            }
            else
            {
                util.ValidateTextBox4(txtCapacity, txtCeiling, txtLocation, txtRoomName);// Validation before saving
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    room.Id = id;
                    room.RoomCapacity = txtCapacity.Text;
                    room.RoomCeiling = txtCeiling.Text;
                    room.RoomLocation = txtLocation.Text;
                    room.RoomName = txtRoomName.Text;
                    room.Save();
                    Reset();
                    #endregion   
                }
                else
                {
                    Reset();
                    return;
                }
            }
            room.LoadDataTable(dgvRoom);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
