using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GOCSystem2018
{
    public partial class frmBillingSearch : Form
    {
        public frmBillingSearch()
        {
            InitializeComponent();
        }
      
      private void DataSelected()
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                ////clear list
                //assesments.Clear();
                ////pass value
                //assesment.Id = Int32.Parse(dgvSearch.CurrentRow.Cells[0].FormattedValue.ToString());
                //assesments = assesment.GetById();

                //foreach (var item in assesments)
                //{
                //    //pass variable to form Assesment
                //    frmAssesment.StudName = item.StudLastName + ", " + item.StudFirstName + " " + item.StudMiddleName;
                //    frmAssesment.LRN = item.StudLRN;
                //    frmAssesment.GradeLevel = item.StudGradeLevel;
                //    frmAssesment.Track = item.StudAcadTrack;
                //    frmAssesment.RegNo = item.StudRegistrationNo;
                //    frmAssesment.Strand = item.StudStrand;

                //    frmAssesment.Reset();
                //    frmAssesment.LoadSection();
                //    frmAssesment.LoadSchoolYear();
                //    // frmAssesment.LoadStrand();
                //    frmAssesment.RenderStudNo();
                //    ///frmAssesment.tuitionFees2();
                //}
                ////show assesment                             
                //frmAssesment.Show();
                //this.Dispose();
            }
        }

        private void LoadRecords()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM student_profile";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    //initialize new datatable
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvSearch.DataSource = dt;

                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchData(string valueToSearch)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM student_profile WHERE CONCAT(`last_name`, `first_name`,`regno`) LIKE '%" + valueToSearch + "%'";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    //initialize new datatable
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvSearch.DataSource = dt;

                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBillingSearch_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //DataView dv = new DataView(dt);
            //dv.RowFilter = string.Format("last_name LIKE '%{0}%'", txtSearch.Text);
            //dgvSearch.DataSource = dv;

            string valueToSearch = txtSearch.Text.ToString();
            searchData(valueToSearch);

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
              
            }
        }
    }
}
