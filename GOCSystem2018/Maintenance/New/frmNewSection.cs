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
    public partial class frmNewSection : Form
    {
        Section section = new Section();
        Strand strand = new Strand();
        Department dept = new Department();
        Room room = new Room();

        List<Section> listSection = new List<Section>();
        List<Strand> listStrand = new List<Strand>();
        List<Department> listDept = new List<Department>();
        List<Room> listRoom = new List<Room>();

        Util_RequiredFields util = new Util_RequiredFields();

        public void LoadStrand()
        {            
            listStrand.Clear();           
            listStrand = strand.Load();           
            foreach (var item in listStrand)
            {
                cmbStrand.Items.Add(item.StrandName);
            }
        }

        public void LoadDepartment()
        {
            listDept.Clear();
            listDept = dept.Load();
            foreach (var item in listDept)
            {
                cmbDepartment.Items.Add(item.DeptName);
            }
        }

        public void LoadRoom()
        {
            listRoom.Clear();
            listRoom = room.Load();
            foreach (var item in listRoom)
            {
                cmbRoom.Items.Add(item.RoomName);
            }
        }

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
            txtSectionName.Text = "";
            txtNotes.Text = "";
            cmbDepartment.Text = "";
            cmbStrand.Text = "";
            cmbRoom.Text = "";
            btnAdd.Text = "&Add New";

            LoadDepartment();
            LoadRoom();
            LoadStrand();
        }

        public frmNewSection()
        {
            InitializeComponent();
            section.LoadDataTable(dgvSection);
            AddImageDataGrid(dgvSection);
            HeaderFix(dgvSection);
            LoadDepartment();
            LoadRoom();
            LoadStrand();
        }

        private void dgvSection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvSection.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtSectionName.Text = dgvSection.Rows[e.RowIndex].Cells[3].Value.ToString(); //Name     
                txtNotes.Text = dgvSection.Rows[e.RowIndex].Cells[4].Value.ToString(); //Name    
                cmbStrand.Text = dgvSection.Rows[e.RowIndex].Cells[5].Value.ToString(); //Name   
                cmbDepartment.Text = dgvSection.Rows[e.RowIndex].Cells[6].Value.ToString(); //Name   
                cmbRoom.Text = dgvSection.Rows[e.RowIndex].Cells[7].Value.ToString(); //Name

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
                   
                    section.Id = Convert.ToInt32(dgvSection.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    section.Delete();

                    section.LoadDataTable(dgvSection);
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
                util.ValidateTextBox2(txtNotes, txtSectionName);// Validation before Updating
                util.ValidateCombobox3(cmbRoom, cmbDepartment, cmbStrand);
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    section.Id = id;
                    section.SectionName = txtSectionName.Text;
                    section.SectionDesc = txtNotes.Text;
                    section.Strand = cmbStrand.Text;
                    section.Dept = cmbDepartment.Text;
                    section.Room = cmbRoom.Text;

                    section.Update();
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
                util.ValidateTextBox2(txtNotes, txtSectionName);// Validation before saving
                util.ValidateCombobox3(cmbRoom, cmbDepartment, cmbStrand);
                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    section.Id = id;
                    section.SectionName = txtSectionName.Text;
                    section.SectionDesc = txtNotes.Text;
                    section.Strand = cmbStrand.Text;
                    section.Dept = cmbDepartment.Text;
                    section.Room = cmbRoom.Text;

                    section.Save();
                    Reset();
                    #endregion   
                }
                else
                {
                    Reset();
                    return;
                }
            }
            section.LoadDataTable(dgvSection);
        }

        private void txtSectionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cmbStrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

    }
}
