using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class Teacher
    {
        /******************************
        * Protected Properties
        * ***************************/
        protected int id;
        protected string employeeNo;
        protected string teacherFname;
        protected string teacherLname;
        protected string teacherMname;
        protected string specialization;
        protected string adviser;

        //protected int flag;

        /******************************
         * Private Properties
         * ***************************/
        /******************************
         * Public Properties
         * ***************************/
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string EmployeeNo
        {
            get { return employeeNo; }
            set { employeeNo = value; }
        }
        public string TeacherFname
        {
            get { return teacherFname; }
            set { teacherFname = value; }
        }

        public string TeacherLname
        {
            get { return teacherLname; }
            set { teacherLname = value; }
        }
        public string TeacherMname
        {
            get { return teacherMname; }
            set { teacherMname = value; }
        }

        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }
        public string AdviserOf
        {
            get { return adviser; }
            set { adviser = value; }
        }
        //variable name should always to be plural for every list
        //Camel casing
        List<Teacher> teachers = new List<Teacher>();
        /******************************
         * Protected Method
         * ***************************/
        /******************************
         * Private Method
         * ***************************/
        /******************************
         * Public Method
         * ***************************/
        public List<Teacher> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM teacher";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Teacher teacher = new Teacher();

                        //prepare properties
                        teacher.id = Convert.ToInt32(reader["id"].ToString());
                        teacher.employeeNo = reader["employeeNo"].ToString();
                        teacher.teacherFname = reader["teacher_fname"].ToString();
                        teacher.teacherLname = reader["teacher_lname"].ToString();
                        teacher.teacherMname = reader["teacher_mname"].ToString();
                        teacher.specialization = reader["specialization "].ToString();
                        teacher.adviser = reader["adviser_of "].ToString();

                        teachers.Add(teacher);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return teachers;
        }//End of Load

        public List<Teacher> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM teacher WHERE id =@id;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Teacher teacher = new Teacher();

                        //prepare properties
                        teacher.id = Convert.ToInt32(reader["id"].ToString());
                        teacher.employeeNo = reader["employeeNo"].ToString();
                        teacher.teacherFname = reader["teacher_fname"].ToString();
                        teacher.teacherLname = reader["teacher_lname"].ToString();
                        teacher.teacherMname = reader["teacher_mname"].ToString();
                        teacher.specialization = reader["specialization "].ToString();
                        teacher.adviser = reader["adviser_of "].ToString();


                        teachers.Add(teacher);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return teachers;
        }

        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO teacher(employeeNo,teacher_fname,teacher_mname,teacher_lname,specialization,adviser_of) " +
                                    " VALUES (@employeeNo,@teacherFname,@teacherLname,@teacherMname,@specialization,@adviser);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("employeeNo", employeeNo);
                    cmd.Parameters.AddWithValue("teacherFname", teacherFname);
                    cmd.Parameters.AddWithValue("teacherLname", teacherLname);
                    cmd.Parameters.AddWithValue("teacherMname", teacherMname);
                    cmd.Parameters.AddWithValue("specialization", specialization);
                    cmd.Parameters.AddWithValue("adviser", adviser);
                    


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Update()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE teacher SET teacher_fname=@teacherFname,teacher_mname=@teacherMname,specialization=@specialization,adviser_of=@adviser" +
                                    " WHERE id=@id;";
                    
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);
                    //cmd.Parameters.AddWithValue("employeeNo", employeeNo);
                    cmd.Parameters.AddWithValue("teacherFname", teacherFname);
                    cmd.Parameters.AddWithValue("teacherLname", teacherLname);
                    cmd.Parameters.AddWithValue("teacherMname", teacherMname);
                    cmd.Parameters.AddWithValue("specialization", specialization);
                    cmd.Parameters.AddWithValue("adviser", adviser);
                    


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Recorde Updated!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Delete()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "DELETE  FROM teacher WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record deleted!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }





    }
}
