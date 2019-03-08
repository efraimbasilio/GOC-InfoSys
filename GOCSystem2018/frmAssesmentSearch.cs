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
    public partial class frmStudSearch : Form
    {
        Assesment assesment = new Assesment();
        StudentProfile studProfile = new StudentProfile();

        List<StudentProfile> studProfiles = new List<StudentProfile>();
        List<Assesment> assesments = new List<Assesment>();

        frmAssesment frmAssesment = new frmAssesment();

        public frmStudSearch()
        {
            InitializeComponent();
        }

        private void frmStudSearch_Load(object sender, EventArgs e)
        {
            LoadRecords();
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

        private void SelectData()
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                //clear list
                studProfiles.Clear();
                //pass value
                studProfile.Id = Int32.Parse(dgvSearch.CurrentRow.Cells[0].FormattedValue.ToString());
                studProfiles = studProfile.GetById();

                foreach (var item in studProfiles)
                {
                    //pass variable to form Assesment
                    frmAssesment.StudName = item.StudLastName + ", " + item.StudFirstName + " " + item.StudMiddleName;
                    frmAssesment.LRN = item.StudLRN;
                    frmAssesment.GradeLevel = item.StudGradeLevel;
                    frmAssesment.Track = item.Track;
                    frmAssesment.RegNo = item.StudRegistrationNo;
                    frmAssesment.Strand = item.StudStrand;
                }

                //set up before form load
                frmAssesment.Reset();
                frmAssesment.LoadSection();
                frmAssesment.LoadSchoolYear();
                frmAssesment.RenderStudNo();
                frmAssesment.LoadAssesMiscFees();
                frmAssesment.Downpayment();
                frmAssesment.LoadAssesOtherFees();

                //show assesment                             
                frmAssesment.Show();
                //this.Dispose();
            }
        }


        private void dgvSearch_DoubleClick(object sender, EventArgs e)
        {            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dgvSearch.Visible = true;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string valueToSearch = txtSearch.Text.ToString();
            searchData(valueToSearch);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SelectData();
            }
        }
    }
}

