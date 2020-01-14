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
    public partial class frmTuition : Form
    {
        //Initialized Method Needed
        Models.TuitionFee tuitionFee= new Models.TuitionFee();

        //list
        List<Models.TuitionFee> tuitionFees = new List<Models.TuitionFee>();

        //Internal Methods
        public void LoadRecords()
        {
            //clear list
            //listView1.Items.Clear();
            dgvTuitionFees.Rows.Clear();

            tuitionFees.Clear();

            //pass value to list
            tuitionFees = tuitionFee.Load();

            //loop through load it to list view
            foreach (var item in tuitionFees)
            {
               //Load to datagridView
               dgvTuitionFees.Rows.Add(item.Id,item.TuitionFeeName,item.TuitionFeeAmount,item.TuitionFeeDescription);

            }
        }//End LoadRecords()

        public void Reset()
        {
            txtTuition.Text = string.Empty;
            txtTuitionAmount.Text = string.Empty;
            txtTuitionComment.Text = string.Empty;

            txtEditTuition.Text = string.Empty;
            txtEditTuitionAmount.Text = string.Empty;
            txtEditTuitionComment.Text = string.Empty;

        }

        public frmTuition()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            pnlNewTuition.Visible = false;
            TuitionLbl.Text = "";
            txtTuition.Text = "";
            txtTuitionAmount.Text = "";
            txtTuitionComment.Text = "";
        }//add tuition close button
        private void label19_Click(object sender, EventArgs e)
        {
            pnlEditVoucher.Visible = false;
            pnlNewTuition.Visible = true;
            EditTuitionLbl.Text = "";
            txtEditTuition.Text = "";
            txtEditTuitionAmount.Text = "";
            txtEditTuitionComment.Text = "";

        }//edit tuition close button
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            //clear add tuition window
            pnlNewTuition.Visible = false;
            TuitionLbl.Text = "";
            txtTuition.Text = "";
            txtTuitionAmount.Text = "";
            txtTuitionComment.Text = "";

            //clear edit tuition window
            pnlEditVoucher.Visible = false;
            EditTuitionLbl.Text = "";
            txtEditTuition.Text = "";
            txtEditTuitionAmount.Text = "";
            txtEditTuitionComment.Text = "";
        }//tuition form close button

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this record ", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans.Equals(DialogResult.Yes))
            {

                //get id
                tuitionFee.Id = Int32.Parse(dgvTuitionFees.CurrentRow.Cells[0].FormattedValue.ToString());
                tuitionFee.Delete();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();

                pnlEditVoucher.Visible = false;
                pnlNewTuition.Visible = true;
                btnAdd.Enabled = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlNewTuition.Visible = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlEditVoucher.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTuition.Text) || string.IsNullOrEmpty(txtTuitionAmount.Text))
            {
                MessageBox.Show("Please fill up the required fields","System Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else //Save Method
            {
                //pass values
                tuitionFee.TuitionFeeName = txtTuition.Text;
                tuitionFee.TuitionFeeAmount = txtTuitionAmount.Text;
                tuitionFee.TuitionFeeDescription = txtTuitionComment.Text;

                // call save method
                tuitionFee.Save();

                //call load record to refresh list
                this.LoadRecords();

                //reset all objects
                this.Reset();
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditTuition.Text) || string.IsNullOrEmpty(txtEditTuitionAmount.Text))
            {
                MessageBox.Show("Please fill up the required fields");
                return;
            }
            else //Save Method
            {
                tuitionFee.TuitionFeeName = txtEditTuition.Text;
                tuitionFee.TuitionFeeAmount = txtEditTuitionAmount.Text;
                tuitionFee.TuitionFeeDescription = txtEditTuitionComment.Text;

                tuitionFee.Id = Int32.Parse(dgvTuitionFees.CurrentRow.Cells[0].FormattedValue.ToString());
                tuitionFee.Update();

                //Load Records
                this.LoadRecords();
            }
        }

        private void frmTuition_Load(object sender, EventArgs e)
        {
            //Load Records
            this.LoadRecords();

            //reset
            this.Reset();
        }

        private void dgvTuitionFees_Click(object sender, EventArgs e)
        {
            pnlNewTuition.Visible = false;
            pnlEditVoucher.Visible = true;
            btnAdd.Enabled = false;

            if (dgvTuitionFees.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //locate record by id
                ////clear list
                tuitionFees.Clear();


                tuitionFee.Id = Int32.Parse(dgvTuitionFees.CurrentRow.Cells[0].FormattedValue.ToString());
                tuitionFees = tuitionFee.GetById();

                //loop through load it to list view
                foreach (var item in tuitionFees)
                {
                    //pass value to textboxes
                    txtEditTuition.Text = item.TuitionFeeName;
                    txtEditTuitionAmount.Text = item.TuitionFeeAmount;
                    txtEditTuitionComment.Text = item.TuitionFeeDescription;
                }

            }
        }
    }
}
