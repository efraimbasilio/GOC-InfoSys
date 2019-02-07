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
    public partial class frmMiscFees : Form
    {
        MiscFee miscfee = new MiscFee();
        List<MiscFee> miscfees = new List<MiscFee>();
        public frmMiscFees()
        {
            InitializeComponent();
        }

        public void LoadRecords()
        {
            //clear list
           
            dgvMiscFee.Rows.Clear();
            miscfees.Clear();

            //pass value to list
            miscfees = miscfee.Load();

            //loop through load it to list view
            foreach (var item in miscfees)
            {
                //Load to datagridView
                dgvMiscFee.Rows.Add(item.Id, item.MiscFeeName, item.MiscFeeAmount);

            }
        }//End LoadRecords()

        public void Reset()
        {
            txtMiscName.Text = string.Empty;
            txtMiscAmount.Text = string.Empty;
            txtMiscComment.Text = string.Empty;

            txtEditMiscName.Text = string.Empty;
            txtEditMiscAmount.Text = string.Empty;
            txtEditMiscComment.Text = string.Empty;
        }

        private void frmMiscFees_Load(object sender, EventArgs e)
        {
            //Load Records
            this.LoadRecords();

            //reset
            this.Reset();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            pnlNewMisc.Visible = false;
            MiscLbl.Text = "";
            txtMiscName.Text = "";
            txtMiscAmount.Text = "";
            txtMiscComment.Text = "";
        }//Add Misc Close button
        private void label19_Click(object sender, EventArgs e)
        {
            pnlEditMisc.Visible = false;
            EditMiscLbl.Text = "";
            txtEditMiscName.Text = "";
            txtEditMiscComment.Text = "";
            txtEditMiscAmount.Text = "";
        }//edit misc close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add misc window
            pnlNewMisc.Visible = false;
            MiscLbl.Text = "";
            txtMiscName.Text = "";
            txtMiscAmount.Text = "";
            txtMiscComment.Text = "";

            //clear edit misc window
            pnlEditMisc.Visible = false;
            EditMiscLbl.Text = "";
            txtEditMiscName.Text = "";
            txtEditMiscComment.Text = "";
            txtEditMiscAmount.Text = "";
        }//Misc form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlNewMisc.Visible = true;
        }//show add misc window

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlEditMisc.Visible = true;

           
            pnlNewMisc.Visible = false;
            btnAdd.Enabled = false;

            if (dgvMiscFee.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                miscfees.Clear();


                miscfee.Id = Int32.Parse(dgvMiscFee.CurrentRow.Cells[0].FormattedValue.ToString());
                miscfees = miscfee.GetById();

                //loop through load it to list view
                foreach (var item in miscfees)
                {
                    //pass value to textboxes
                    txtEditMiscName.Text = item.MiscFeeName;
                    txtEditMiscAmount.Text = item.MiscFeeAmount;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }
            }
            }//show edit misc window

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMiscName.Text) || string.IsNullOrEmpty(txtMiscAmount.Text))
            {
                MessageBox.Show("Please fill up the required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else //Save Method
            {
                //pass values
                miscfee.MiscFeeName = txtMiscName.Text;
                miscfee.MiscFeeAmount = txtMiscAmount.Text;

                // call save method
                miscfee.Save();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditMiscName.Text) || string.IsNullOrEmpty(txtEditMiscAmount.Text))
            {
                MessageBox.Show("Please fill up the required fields");
                return;
            }
            else //Save Method
            {
                miscfee.MiscFeeName = txtEditMiscName.Text;
                miscfee.MiscFeeAmount = txtEditMiscAmount.Text;

                miscfee.Id = Int32.Parse(dgvMiscFee.CurrentRow.Cells[0].FormattedValue.ToString());
                miscfee.Update();

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
                miscfee.Id = Int32.Parse(dgvMiscFee.CurrentRow.Cells[0].FormattedValue.ToString());
                miscfee.Delete();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();

                pnlEditMisc.Visible = false;
                pnlNewMisc.Visible = true;
                btnAdd.Enabled = true;
            }
        }

        private void dgvMiscFee_Click(object sender, EventArgs e)
        {
            pnlEditMisc.Visible = true;
            pnlNewMisc.Visible = false;
            btnAdd.Enabled = false;

            if (dgvMiscFee.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                miscfees.Clear();


                miscfee.Id = Int32.Parse(dgvMiscFee.CurrentRow.Cells[0].FormattedValue.ToString());
                miscfees = miscfee.GetById();

                //loop through load it to list view
                foreach (var item in miscfees)
                {
                    //pass value to textboxes
                    txtEditMiscName.Text = item.MiscFeeName;
                    txtEditMiscAmount.Text = item.MiscFeeAmount;
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }

            }
        }
    }
}
