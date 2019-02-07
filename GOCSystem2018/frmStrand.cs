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
    public partial class frmStrand : Form
    {
        Strand strand = new Strand();
        List<Strand> strands = new List<Strand>();
        public frmStrand()
        {
            InitializeComponent();
        }

        public void LoadRecords()
        {
            //clear list

            dgvStrands.Rows.Clear();
            strands.Clear();

            //pass value to list
            strands = strand.Load();

            //loop through load it to list view
            foreach (var item in strands)
            {
                //Load to datagridView
                dgvStrands.Rows.Add(item.Id, item.StrandName, item.StrandDesc);

            }
        }//End LoadRecords()

        public void Reset()
        {
            txtStrand.Text = string.Empty;
            txtDesc.Text = string.Empty;
           

            txtEditStrand.Text = string.Empty;
            txtEditDesc.Text = string.Empty;
           
        }














        private void label18_Click(object sender, EventArgs e)
        {
            pnlNew.Visible = true;
            StrandLbl.Text = "";
            txtStrand.Text = "";
            txtDesc.Text = "";
        }//add strand window close button
        private void label19_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            EditStrandLbl.Text = "";
            txtEditStrand.Text = "";
            txtEditDesc.Text = "";
        }//edit strand window close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add strand window
            pnlNew.Visible = true;
            StrandLbl.Text = "";
            txtStrand.Text = "";
            txtDesc.Text = "";

            //clear edit strand window
            pnlEdit.Visible = false;
            EditStrandLbl.Text = "";
            txtEditStrand.Text = "";
            txtEditDesc.Text = "";
        }//strand form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlNew.Visible = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlNew.Visible = false;
            btnAdd.Enabled = false;

            if (dgvStrands.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                strands.Clear();


                strand.Id = Int32.Parse(dgvStrands.CurrentRow.Cells[0].FormattedValue.ToString());
                strands = strand.GetById();

                //loop through load it to list view
                foreach (var item in strands)
                {
                    //pass value to textboxes
                    txtEditStrand.Text = item.StrandName;
                    txtEditDesc.Text = item.StrandDesc;
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
                strand.Id = Int32.Parse(dgvStrands.CurrentRow.Cells[0].FormattedValue.ToString());
                strand.Delete();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();

                pnlEdit.Visible = false;
                pnlNew.Visible = true;
                btnAdd.Enabled = true;
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditStrand.Text) || string.IsNullOrEmpty(txtEditDesc.Text))
            {
                MessageBox.Show("Please fill up the required fields");
                return;
            }
            else //Save Method
            {
                strand.StrandName = txtEditStrand.Text;
                strand.StrandDesc = txtEditDesc.Text;

                strand.Id = Int32.Parse(dgvStrands.CurrentRow.Cells[0].FormattedValue.ToString());
                strand.Update();

                //Load Records
                this.LoadRecords();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStrand.Text) || string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Please fill up the required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else //Save Method
            {
                //pass values
                strand.StrandName = txtStrand.Text;
                strand.StrandDesc = txtDesc.Text;

                // call save method
                strand.Save();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();
            }
        }

        private void dgvStrands_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlNew.Visible = false;
            btnAdd.Enabled = false;

            if (dgvStrands.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                strands.Clear();


                strand.Id = Int32.Parse(dgvStrands.CurrentRow.Cells[0].FormattedValue.ToString());
                strands = strand.GetById();

                //loop through load it to list view
                foreach (var item in strands)
                {
                    //pass value to textboxes
                    txtEditStrand.Text = item.StrandName;
                    txtEditDesc.Text = item.StrandDesc;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }

            }
        }

        private void frmStrand_Load(object sender, EventArgs e)
        {
            //Load Records
            this.LoadRecords();

            //reset
            this.Reset();
        }
    }
}
