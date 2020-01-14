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
        Subject subject = new Subject();
        List<Subject> subjects = new List<Subject>();
        public frmSubject()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            SubjectLbl.Text = "";
            txtSubject.Text = "";
            txtDesc.Text = "";
        }//add window close button
        private void label19_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            EditSubjectLbl.Text = "";
            txtEditSubject.Text = "";
            txtEditDesc.Text = "";
        }//edit window close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add subject window
            pnlAdd.Visible = false;
            SubjectLbl.Text = "";
            txtSubject.Text = "";
            txtDesc.Text = "";

            //clear edit subject window
            pnlEdit.Visible = false;
            EditSubjectLbl.Text = "";
            txtEditSubject.Text = "";
            txtEditDesc.Text = "";
        }//subject window close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            pnlEdit.Visible = true;
            pnlAdd.Visible = false;
            btnAdd.Enabled = false;

            if (dgvSubjects.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                subjects.Clear();


                subject.Id = Int32.Parse(dgvSubjects.CurrentRow.Cells[0].FormattedValue.ToString());
                subjects = subject.GetById();

                //loop through load it to list view
                foreach (var item in subjects)
                {
                    //pass value to textboxes
                    txtEditSubject.Text = item.SubjectCode;
                    txtEditDesc.Text = item.SubjectDesc;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }
            }
        }



        public void LoadRecords()
        {
            //clear list

            dgvSubjects.Rows.Clear();
            subjects.Clear();

            //pass value to list
            subjects = subject.Load();

            //loop through load it to list view
            foreach (var item in subjects)
            {
                //Load to datagridView
                dgvSubjects.Rows.Add(item.Id, item.SubjectCode, item.SubjectDesc);

            }
        }//End LoadRecords()

        public void Reset()
        {
            txtSubject.Text = string.Empty;
            txtDesc.Text = string.Empty;


            txtEditSubject.Text = string.Empty;
            txtEditDesc.Text = string.Empty;

        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            //Load Records
            this.LoadRecords();

            //reset
            this.Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubject.Text) || string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Please fill up the required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else //Save Method
            {
                //pass values
                subject.SubjectCode = txtSubject.Text;
                subject.SubjectDesc = txtDesc.Text;

                // call save method
                subject.Save();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditSubject.Text) || string.IsNullOrEmpty(txtEditDesc.Text))
            {
                MessageBox.Show("Please fill up the required fields");
                return;
            }
            else //Save Method
            {
                subject.SubjectCode = txtEditSubject.Text;
                subject.SubjectDesc = txtEditDesc.Text;

                subject.Id = Int32.Parse(dgvSubjects.CurrentRow.Cells[0].FormattedValue.ToString());
                subject.Update();

                //Load Records
                this.LoadRecords();
            }
        }

        private void dgvSubjects_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlAdd.Visible = false;
            btnAdd.Enabled = false;

            if (dgvSubjects.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                subjects.Clear();


                subject.Id = Int32.Parse(dgvSubjects.CurrentRow.Cells[0].FormattedValue.ToString());
                subjects = subject.GetById();

                //loop through load it to list view
                foreach (var item in subjects)
                {
                    //pass value to textboxes
                    txtEditSubject.Text = item.SubjectCode;
                    txtEditDesc.Text = item.SubjectDesc;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this record ", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans.Equals(DialogResult.Yes))
            {

                //get id
                subject.Id = Int32.Parse(dgvSubjects.CurrentRow.Cells[0].FormattedValue.ToString());
                subject.Delete();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();

                pnlEdit.Visible = false;
                pnlAdd.Visible = true;
                btnAdd.Enabled = true;
            }
        }
    }
}
