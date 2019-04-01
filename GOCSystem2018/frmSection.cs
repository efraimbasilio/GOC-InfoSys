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
    public partial class frmSection : Form
    {
        Section section = new Section();
        Strand strand = new Strand();
        Department dept = new Department();


        List<Section> sections = new List<Section>();
        List<Strand> strands = new List<Strand>();
        List<Department> depts = new List<Department>();

        public void LoadStrand()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            cmbStrand.Items.Clear();
            strands.Clear();

            //pass value to list
            strands = strand.Load();

            //loop through load it to list view
            foreach (var item in strands)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                cmbStrand.Items.Add(item.StrandName);
            }

        }//End LoadRecords()

        public void LoadDept()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            cmbDept.Items.Clear();
            depts.Clear();

            //pass value to list
            depts = dept.Load();

            //loop through load it to list view
            foreach (var item in depts)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                cmbDept.Items.Add(item.DeptName);
            }

        }//End LoadRecords()

        public frmSection()
        {
            InitializeComponent();
        }
        private void label18_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            SectionLbl.Text = "";
            txtSection.Text = "";
            txtDesc.Text = "";
        }//add section close button
        private void label19_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            EditSectionLbl.Text = "";
            txtEditSection.Text = "";
            txtEditDesc.Text = "";
        }//edit section close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add section window
            pnlAdd.Visible = true;
            SectionLbl.Text = "";
            txtSection.Text = "";
            txtDesc.Text = "";

            //clear edit section window
            pnlEdit.Visible = true;
            EditSectionLbl.Text = "";
            txtEditSection.Text = "";
            txtEditDesc.Text = "";
        }//section form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            pnlEdit.Visible = true;
            pnlAdd.Visible = false;
            btnAdd.Enabled = false;

            if (dgvSection.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                sections.Clear();


                section.Id = Int32.Parse(dgvSection.CurrentRow.Cells[0].FormattedValue.ToString());
                sections = section.GetById();

                //loop through load it to list view
                foreach (var item in sections)
                {
                    //pass value to textboxes
                    txtEditSection.Text = item.SectionName;
                    txtEditDesc.Text = item.SectionDesc;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }
            }
        }

        public void LoadRecords()
        {
            //clear list

            dgvSection.Rows.Clear();
            sections.Clear();

            //pass value to list
            sections = section.Load();

            //loop through load it to list view
            foreach (var item in sections)
            {
                //Load to datagridView
                dgvSection.Rows.Add(item.Id, item.SectionName, item.SectionDesc,item.Strand, item.Dept);

            }
        }//End LoadRecords()

        public void Reset()
        {
            txtSection.Text = string.Empty;
            txtDesc.Text = string.Empty;

            txtEditSection.Text = string.Empty;
            txtEditDesc.Text = string.Empty;
        }


        private void frmSection_Load(object sender, EventArgs e)
        {
            //Load Records
            this.LoadRecords();
            this.LoadStrand();
            this.LoadDept();

            //reset
            this.Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSection.Text) || string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Please fill up the required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else //Save Method
            {
                //pass values
                section.SectionName = txtSection.Text.ToUpper();
                section.SectionDesc = txtDesc.Text.ToUpper();
                section.Dept = cmbDept.Text;
                section.Strand = cmbStrand.Text;

                // call save method
                section.Save();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditSection.Text) || string.IsNullOrEmpty(txtEditDesc.Text))
            {
                MessageBox.Show("Please fill up the required fields");
                return;
            }
            else //Save Method
            {
                section.SectionName = txtEditSection.Text.ToUpper();
                section.SectionDesc = txtEditDesc.Text.ToUpper();
                section.Dept = cmbEditDept.Text;
                section.Strand = cmbStrand.Text;

                section.Id = Int32.Parse(dgvSection.CurrentRow.Cells[0].FormattedValue.ToString());
                section.Update();

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
                section.Id = Int32.Parse(dgvSection.CurrentRow.Cells[0].FormattedValue.ToString());
                section.Delete();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();

                pnlEdit.Visible = false;
                pnlAdd.Visible = true;
                btnAdd.Enabled = true;
            }
        }

        private void dgvSection_Click(object sender, EventArgs e)
        {

            pnlEdit.Visible = true;
            pnlAdd.Visible = false;
            btnAdd.Enabled = false;

            if (dgvSection.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                sections.Clear();


                section.Id = Int32.Parse(dgvSection.CurrentRow.Cells[0].FormattedValue.ToString());
                sections = section.GetById();

                //loop through load it to list view
                foreach (var item in sections)
                {
                    //pass value to textboxes
                    txtEditSection.Text = item.SectionName;
                    txtEditDesc.Text = item.SectionDesc;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }
            }
        }
    }
}
