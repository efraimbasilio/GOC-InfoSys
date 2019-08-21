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
    public partial class frmSectioning : Form
    {
        StudentProfile studProfile = new StudentProfile();

        List<StudentProfile> studProfiles = new List<StudentProfile>();

        public frmSectioning()
        {
            InitializeComponent();
            
        }

        public void LoadSectionBefore()
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
                    dgvSectionBefore.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadSectionAfter()
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
                    dgvSectionAfter.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadUnSectionStudent(ComboBox criteria,ComboBox grade_level)
        {            
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();
                    //string sql = "SELECT * FROM student_profile";
                    //string sql2 = string.Concat("SELECT * FROM student_profile WHERE CONCAT("+ query_field +") LIKE '%" + valueToSearch + "%'");
                    string sql2 = string.Concat("SELECT IdNo,last_name, first_name, middle_name,strand,grade_level,section FROM student_profile WHERE STRAND LIKE '%" + criteria.Text + "%' AND GRADE_LEVEL LIKE '%" + grade_level.Text + "%'");

                    MySqlCommand cmd = new MySqlCommand(sql2, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    //initialize new datatable
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSectionBefore.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        public void LoadStrand(ComboBox cmb, string query_table, string query_field)
        {
            cmb.Items.Clear();
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();
                    //string sql = "SELECT * FROM student_profile";
                    string sql2 = string.Concat("SELECT * FROM " + query_table + "");
                    MySqlCommand cmd = new MySqlCommand(sql2, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //concat and Load
                        string query = string.Concat(cmb.Items.Add(reader["" + query_field + ""].ToString()));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmSectioning_Load(object sender, EventArgs e)
        {
            LoadStrand(cmbStrand, "STRAND", "strand_name");
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            NoSectionStudents();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WithSectionStudents();
        }

        public void NoSectionStudents()
        {          
            //clear list
            studProfiles.Clear();
            dgvSectionBefore.Rows.Clear();

            //pass value to list
            studProfiles = studProfile.Load();
            foreach (var item in studProfiles)
            {               
                if (item.Section == "0" && item.StudStrand.Equals(cmbStrand.SelectedItem.ToString()) && item.StudGradeLevel.Equals(cmbGradeLevel.SelectedItem.ToString()))
                {
                    dgvSectionBefore.Rows.Add(item.StudGOCNo, item.StudLastName, item.StudFirstName, item.StudMiddleName, item.StudStrand, item.StudGradeLevel, item.Section);
                }
                                
                int sum = 0;
                sum = dgvSectionBefore.Rows.Count;
                lblCount.Text = sum.ToString();
            }//End LoadSchedule()           
        }

        public void WithSectionStudents()
        {           
            //clear list
            studProfiles.Clear();
            dgvSectionBefore.Rows.Clear();

            //pass value to list
            studProfiles = studProfile.Load();
            foreach (var item in studProfiles)
            {
                if (item.StudGOCNo.Equals("N/A"))
                {
                    return;
                }
                else
                {
                    //if (item.StudStrand.Equals(cmbStrand.SelectedItem.ToString()) && item.StudGradeLevel.Equals(cmbGradeLevel.SelectedItem.ToString()) && item.Section != "0")
                    if (item.StudStrand.Equals(cmbStrand.SelectedItem.ToString()) && item.StudGradeLevel.Equals(cmbGradeLevel.SelectedItem.ToString()) && item.Section != "0")
                    {
                        dgvSectionBefore.Rows.Add(item.StudGOCNo, item.StudLastName, item.StudFirstName, item.StudMiddleName, item.StudStrand, item.StudGradeLevel, item.Section);
                    }                    
                    //Load to datagridView                   
                }
                int sum = 0;
                sum = dgvSectionBefore.Rows.Count;
                lblCount.Text = sum.ToString();
            }//End LoadSchedule()

            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmSectionAndRoom frm = new frmSectionAndRoom();
            frm.strand = cmbStrand.Text;
            frm.CheckSectionInfo();
            frm.ShowDialog();
        }
    }
}
