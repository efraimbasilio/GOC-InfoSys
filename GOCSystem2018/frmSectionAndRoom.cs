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
    public partial class frmSectionAndRoom : Form
    {
        public frmSectionAndRoom()
        {
            InitializeComponent();
        }

        Section section = new Section();
        Room room = new Room();

        List<Section> sections = new List<Section>();
        List<Room> rooms = new List<Room>();


        public string strand;

        public void CheckSectionInfo()
        {
            //clear list
            sections.Clear();
            dgvSectionInfo.Rows.Clear();

            //pass value to list
            sections = section.Load();
            foreach (var item in sections)
            {
                if (item.Strand == strand)
                {
                    dgvSectionInfo.Rows.Add(item.Strand, item.Room);
                }                          
            }           
        }

        public void CheckRoomInfo()
        {
            rooms.Clear();
            dgvRoom.Rows.Clear();            
                            
               rooms = room.Load();

            foreach (var item in rooms)
            {
                for (int i = 0; i < dgvSectionInfo.Rows.Count; i++)
                {

                    if (item.RoomName == dgvSectionInfo.Rows[i].Cells[1].FormattedValue.ToString())
                    {
                        dgvRoom.Rows.Add(item.RoomName, item.RoomCapacity);
                        //ssageBox.Show(item.RoomCapacity);                        
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
