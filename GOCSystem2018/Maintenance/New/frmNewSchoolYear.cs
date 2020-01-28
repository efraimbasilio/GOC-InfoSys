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
    public partial class frmNewSchoolYear : Form
    {
        SchoolYear schoolYear = new SchoolYear();
        List<SchoolYear> listSchoolYear = new List<SchoolYear>();

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
            txtStart.Text = "";
            txtEnd.Text = "";
            cmbSemester.Text = "";
            cmbQuarter.Text = "";

            cmbQuarter.Items.Clear();
            cmbSemester.Items.Clear();

            cmbSemester.Items.Add("1st Semester");
            cmbSemester.Items.Add("2nd Semester");

            cmbQuarter.Items.Add("1st Quarter");
            cmbQuarter.Items.Add("2nd Quarter");
            cmbQuarter.Items.Add("3rd  Quarter");
            cmbQuarter.Items.Add("4th  Quarter");

            btnAdd.Text = "&Add New";
        }

        public frmNewSchoolYear()
        {
            InitializeComponent();
            schoolYear.LoadDataTable(dgvSchoolYear);
            AddImageDataGrid(dgvSchoolYear);
            HeaderFix(dgvSchoolYear);
        }

        private void dgvSchoolYear_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(dgvSchoolYear.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria

                //pass value to edit mode               
                txtStart.Text = dgvSchoolYear.Rows[e.RowIndex].Cells[3].Value.ToString(); //Name     
                txtEnd.Text = dgvSchoolYear.Rows[e.RowIndex].Cells[4].Value.ToString(); //Name    
                cmbSemester.Text = dgvSchoolYear.Rows[e.RowIndex].Cells[5].Value.ToString(); //Name    
                cmbQuarter.Text = dgvSchoolYear.Rows[e.RowIndex].Cells[6].Value.ToString(); //Name    


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
                    schoolYear.Id = Convert.ToInt32(dgvSchoolYear.Rows[e.RowIndex].Cells[2].Value.ToString());//for editing criteria
                    schoolYear.Delete();

                    schoolYear.LoadDataTable(dgvSchoolYear);
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
                util.ValidateTextBox2(txtStart, txtEnd);// Validation before Updating
                util.ValidateCombobox2(cmbSemester, cmbQuarter);// Validation before Updating

                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    schoolYear.Id = id;
                    schoolYear.YearStart = txtStart.Text;
                    schoolYear.YearEnd = txtEnd.Text;
                    schoolYear.Quarter = cmbQuarter.Text;
                    schoolYear.Semester = cmbSemester.Text;

                    schoolYear.Update();
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
                util.ValidateTextBox2(txtStart, txtEnd);// Validation before Updating
                util.ValidateCombobox2(cmbSemester, cmbQuarter);// Validation before Updating

                if (util.readyToSave == 1)
                {
                    #region UPDATE DISCOUNT
                    schoolYear.Id = id;
                    schoolYear.YearStart = txtStart.Text;
                    schoolYear.YearEnd = txtEnd.Text;
                    schoolYear.Quarter = cmbQuarter.Text;
                    schoolYear.Semester = cmbSemester.Text;

                    schoolYear.Save();
                    Reset();
                    #endregion   
                }
                else
                {
                    Reset();
                    return;
                }
            }
            schoolYear.LoadDataTable(dgvSchoolYear);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
