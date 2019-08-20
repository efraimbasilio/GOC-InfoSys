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
            //cmbStrand.text,dgvBefore,student_profile,grade_level,txtGradelevel.text
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();
                    //string sql = "SELECT * FROM student_profile";
                    //string sql2 = string.Concat("SELECT * FROM student_profile WHERE CONCAT("+ query_field +") LIKE '%" + valueToSearch + "%'");
                    string sql2 = string.Concat("SELECT * FROM student_profile WHERE STRAND LIKE '%" + criteria.Text + "%' AND GRADE_LEVEL LIKE '%" + grade_level.Text + "%'");

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
            LoadUnSectionStudent(cmbStrand,cmbGradeLevel);
        }
    }
}
