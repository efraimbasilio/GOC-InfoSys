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
    public partial class frmSchoolYear : Form
    {
        SchoolYear schoolYear = new SchoolYear();
        List<SchoolYear> schoolYears = new List<SchoolYear>();

        public frmSchoolYear()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            txtYearStart.Text = "";
            txtYearEnd.Text = "";
        }//add SY close button

        private void label19_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            txtEditStart.Text = "";
            txtEditEnd.Text = "";
        }//edit SY close button

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add SY window
            pnlAdd.Visible = false;
            txtYearStart.Text = "";
            txtYearEnd.Text = "";

            //clear edit SY window
            pnlEdit.Visible = false;
            txtEditStart.Text = "";
            txtEditEnd.Text = "";

        }//SY form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlAdd.Visible = false;
            btnAdd.Enabled = false;

            if (dgvSchoolYear.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                schoolYears.Clear();


                schoolYear.Id = Int32.Parse(dgvSchoolYear.CurrentRow.Cells[0].FormattedValue.ToString());
                schoolYears = schoolYear.GetById();

                //loop through load it to list view
                foreach (var item in schoolYears)
                {
                    //pass value to textboxes
                    txtEditStart.Text = item.YearStart;
                    txtEditEnd.Text = item.YearEnd;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtYearStart.Text) || string.IsNullOrEmpty(txtYearEnd.Text))
            {
                MessageBox.Show("Please fill up the required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else //Save Method
            {
                //pass values
                schoolYear.YearStart = txtYearStart.Text;
                schoolYear.YearEnd = txtYearEnd.Text;

                // call save method
                schoolYear.Save();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();
            }
        }

        public void LoadRecords()
        {
            //clear list

            dgvSchoolYear.Rows.Clear();
            schoolYears.Clear();

            //pass value to list
            schoolYears = schoolYear.Load();

            //loop through load it to list view
            foreach (var item in schoolYears)
            {
                //Load to datagridView
                dgvSchoolYear.Rows.Add(item.Id, item.YearStart, item.YearEnd);

            }
        }//End LoadRecords()

        public void Reset()
        {
            txtYearStart.Text = string.Empty;
            txtYearEnd.Text = string.Empty;
            //txtMiscComment.Text = string.Empty;

            txtEditStart.Text = string.Empty;
            txtEditEnd.Text = string.Empty;
            //txtEditMiscComment.Text = string.Empty;
        }


        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditStart.Text) || string.IsNullOrEmpty(txtEditEnd.Text))
            {
                MessageBox.Show("Please fill up the required fields");
                return;
            }
            else //Save Method
            {
                schoolYear.YearStart = txtEditStart.Text;
                schoolYear.YearEnd = txtEditEnd.Text;

                schoolYear.Id = Int32.Parse(dgvSchoolYear.CurrentRow.Cells[0].FormattedValue.ToString());
                schoolYear.Update();

                //Load Records
                this.LoadRecords();
            }
        }

        private void frmSchoolYear_Load(object sender, EventArgs e)
        {
            //Load Records
            this.LoadRecords();

            //reset
            this.Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this record ", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans.Equals(DialogResult.Yes))
            {

                //get id
                schoolYear.Id = Int32.Parse(dgvSchoolYear.CurrentRow.Cells[0].FormattedValue.ToString());
                schoolYear.Delete();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();

                pnlEdit.Visible = false;
                pnlEdit.Visible = true;
                btnAdd.Enabled = true;
            }
        }

        private void dgvSchoolYear_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            btnAdd.Enabled = false;

            if (dgvSchoolYear.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                schoolYears.Clear();


                schoolYear.Id = Int32.Parse(dgvSchoolYear.CurrentRow.Cells[0].FormattedValue.ToString());
                schoolYears = schoolYear.GetById();

                //loop through load it to list view
                foreach (var item in schoolYears)
                {
                    //pass value to textboxes
                    txtEditStart.Text = item.YearStart;
                    txtEditEnd.Text = item.YearEnd;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }
            }
        }
    }
}
