using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class EnrolledStudents
    {
        protected int id;
        protected string regNo;
        protected string theGOCNo;
        protected string fullName;
        protected string gradeLevel;
        protected string strand;
        protected string section;
        protected string semester;
        protected string syEnroll;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        public string TheGOCNo
        {
            get { return theGOCNo; }
            set { theGOCNo = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string GradeLevel
        {
            get { return gradeLevel; }
            set { gradeLevel = value; }
        }

        public string Strand
        {
            get { return strand; }
            set { strand = value; }
        }
        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        public string SyEnroll
        {
            get { return syEnroll; }
            set { syEnroll = value; }
        }

        List<EnrolledStudents> enrollees = new List<EnrolledStudents>();

        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO enrolled_grade_11(regno,gocno,full_name,grade_level,strand,section,semester,SY_enrolled) " +
                                    " VALUES (@regNo,@theGOCNo,@fullName,@gradeLevel,@strand,@section,@semester,@syEnroll);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("regNo", regNo);
                    cmd.Parameters.AddWithValue("TheGOCNo", theGOCNo);
                    cmd.Parameters.AddWithValue("fullName", fullName);
                    cmd.Parameters.AddWithValue("gradeLevel", gradeLevel);
                    cmd.Parameters.AddWithValue("strand", strand);
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("semester", semester);
                    cmd.Parameters.AddWithValue("syEnroll", syEnroll);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void SaveGrade12()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO enrolled_grade_12(regno,gocno,full_name,grade_level,strand,section,semester,SY_enrolled) " +
                                    " VALUES (@regNo,@theGOCNo,@fullName,@gradeLevel,@strand,@section,@semester,@syEnroll);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("regNo", regNo);
                    cmd.Parameters.AddWithValue("TheGOCNo", theGOCNo);
                    cmd.Parameters.AddWithValue("fullName", fullName);
                    cmd.Parameters.AddWithValue("gradeLevel", gradeLevel);
                    cmd.Parameters.AddWithValue("strand", strand);
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("semester", semester);
                    cmd.Parameters.AddWithValue("syEnroll", syEnroll);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public List<EnrolledStudents> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();


                    string sql = "SELECT * FROM enrolled_grade_11";


                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        EnrolledStudents enroll = new EnrolledStudents();

                        //prepare properties
                        enroll.id = Convert.ToInt32(reader["id"].ToString());
                        enroll.regNo = reader["regno"].ToString();
                        enroll.theGOCNo = reader["gocno"].ToString();
                        enroll.fullName = reader["full_name"].ToString();
                        enroll.gradeLevel = reader["grade_level"].ToString();
                        enroll.strand = reader["strand"].ToString();
                        enroll.section = reader["section"].ToString();
                        enroll.semester = reader["semester"].ToString();
                        enroll.syEnroll = reader["sy_enrolled"].ToString();
                        
                        enrollees.Add(enroll);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return enrollees;

        }//End of Load

        public List<EnrolledStudents> CountStudInSection()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM enrolled_grade_11  WHERE section =@section;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("section", section);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        EnrolledStudents enroll = new EnrolledStudents();

                        //prepare properties
                        enroll.id = Convert.ToInt32(reader["id"].ToString());
                        enroll.regNo = reader["regno"].ToString();
                        enroll.theGOCNo = reader["gocno"].ToString();
                        enroll.fullName = reader["full_name"].ToString();
                        enroll.gradeLevel = reader["grade_level"].ToString();
                        enroll.strand = reader["strand"].ToString();
                        enroll.section = reader["section"].ToString();
                        enroll.semester = reader["semester"].ToString();
                        enroll.syEnroll = reader["sy_enrolled"].ToString();

                      //  MessageBox.Show("sasa");

                        enrollees.Add(enroll);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return enrollees;
        }

        public List<EnrolledStudents> CountStudInSection12()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM enrolled_grade_12 WHERE section =@section;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("section", section);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        EnrolledStudents enroll = new EnrolledStudents();

                        //prepare properties
                        enroll.id = Convert.ToInt32(reader["id"].ToString());
                        enroll.regNo = reader["regno"].ToString();
                        enroll.theGOCNo = reader["gocno"].ToString();
                        enroll.fullName = reader["full_name"].ToString();
                        enroll.gradeLevel = reader["grade_level"].ToString();
                        enroll.strand = reader["strand"].ToString();
                        enroll.section = reader["section"].ToString();
                        enroll.semester = reader["semester"].ToString();
                        enroll.syEnroll = reader["sy_enrolled"].ToString();

                        //  MessageBox.Show("sasa");

                        enrollees.Add(enroll);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return enrollees;
        }

    }
}
