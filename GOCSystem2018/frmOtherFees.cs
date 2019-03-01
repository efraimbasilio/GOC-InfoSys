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
    public partial class frmOtherFees : Form
    {
        OtherFee otherFee = new OtherFee();
        List<OtherFee> otherFees = new List<OtherFee>();

        public frmOtherFees()
        {
            InitializeComponent();
        }

        public void LoadRecords()
        {
            //clear list

            dgvOtherFee.Rows.Clear();
            otherFees.Clear();

            //pass value to list
            otherFees = otherFee.Load();

            //loop through load it to list view
            foreach (var item in otherFees)
            {
                //Load to datagridView
                dgvOtherFee.Rows.Add(item.Id, item.OtherFeeName, item.OtherFeeAmount);

            }
        }//End LoadRecords()

        public void Reset()
        {
            txtFeeName.Text = string.Empty;
            txtFeeAmount.Text = string.Empty;
            txtComment.Text = string.Empty;

            txtEditName.Text = string.Empty;
            txtEditFeeAmount.Text = string.Empty;
            txtEditFeeComment.Text = string.Empty;
        }


        private void frmOtherFees_Load(object sender, EventArgs e)
        {
            //Load Records
            this.LoadRecords();
            //reset
            this.Reset();

            this.CenterToScreen();
            this.BackColor = Color.WhiteSmoke;
        }






























        private void label18_Click(object sender, EventArgs e)
        {
            pnlNewFee.Visible = false;
            OFLbl.Text = "";
            txtFeeName.Text = "";
            txtFeeAmount.Text = "";
            txtComment.Text = "";
        }//add other fee close button
        private void label19_Click(object sender, EventArgs e)
        {
            pnlEditFee.Visible = false;
            EditOFLb.Text = "";
            txtEditName.Text = "";
            txtEditFeeComment.Text = "";
            txtEditFeeAmount.Text = "";
        }//edit other fee close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add other fee window
            pnlNewFee.Visible = false;
            OFLbl.Text = "";
            txtFeeName.Text = "";
            txtFeeAmount.Text = "";
            txtComment.Text = "";

            //clear edit other fee window
            pnlEditFee.Visible = false;
            EditOFLb.Text = "";
            txtEditName.Text = "";
            txtEditFeeComment.Text = "";
            txtEditFeeAmount.Text = "";

        }//other fee form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlNewFee.Visible = true;
        }//show OF add window

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlEditFee.Visible = true;
            pnlNewFee.Visible = false;
            btnAdd.Enabled = false;

            if (dgvOtherFee.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                otherFees.Clear();


                otherFee.Id = Int32.Parse(dgvOtherFee.CurrentRow.Cells[0].FormattedValue.ToString());
                otherFees = otherFee.GetById();

                //loop through load it to list view
                foreach (var item in otherFees)
                {
                    //pass value to textboxes
                    txtEditName.Text = item.OtherFeeName;
                    txtEditFeeAmount.Text = item.OtherFeeAmount.ToString();
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }

            }


        }//show edit OF window

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFeeName.Text) || string.IsNullOrEmpty(txtFeeAmount.Text))
            {
                MessageBox.Show("Please fill up the required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else //Save Method
            {
                //pass values
                otherFee.OtherFeeName = txtFeeName.Text;
                otherFee.OtherFeeAmount = Convert.ToDouble(txtFeeAmount.Text); 

                // call save method
                otherFee.Save();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditFeeAmount.Text) || string.IsNullOrEmpty(txtEditName.Text))
            {
                MessageBox.Show("Please fill up the required fields");
                return;
            }
            else //Save Method
            {
                otherFee.OtherFeeName = txtEditName.Text;
                otherFee.OtherFeeAmount = Convert.ToDouble(txtFeeAmount.Text);


                otherFee.Id = Int32.Parse(dgvOtherFee.CurrentRow.Cells[0].FormattedValue.ToString());
                otherFee.Update();

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
                otherFee.Id = Int32.Parse(dgvOtherFee.CurrentRow.Cells[0].FormattedValue.ToString());
                otherFee.Delete();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();

                pnlEditFee.Visible = false;
                pnlNewFee.Visible = true;
                btnAdd.Enabled = true;
            }
        }

        private void dgvOtherFee_Click(object sender, EventArgs e)
        {
            pnlEditFee.Visible = true;
            pnlNewFee.Visible = false;
            btnAdd.Enabled = false;

            if (dgvOtherFee.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                otherFees.Clear();


                otherFee.Id = Int32.Parse(dgvOtherFee.CurrentRow.Cells[0].FormattedValue.ToString());
                otherFees = otherFee.GetById();

                //loop through load it to list view
                foreach (var item in otherFees)
                {
                    //pass value to textboxes
                    txtEditName.Text = item.OtherFeeName;
                    txtEditFeeAmount.Text = item.OtherFeeAmount.ToString();
                    //txtEditMiscComment.Text = item.TuitionFeeDescription;
                }

            }
        }
    }
}
