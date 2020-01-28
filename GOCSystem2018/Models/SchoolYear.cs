using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace GOCSystem2018
{
    class SchoolYear
    {
        /******************************
         * Protected Properties
         * ***************************/
        protected int id;
        protected string yearStart;
        protected string yearEnd;
        protected string semester;
        protected string quaterGrading;

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

        public string YearStart
        {
            get { return yearStart ; }
            set { yearStart = value; }
        }

        public string YearEnd
        {
            get { return yearEnd; }
            set { yearEnd = value; }
        }

        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        public string Quarter
        {
            get { return quaterGrading; }
            set { quaterGrading = value; }
        }

        //variable name should always to be plural for every list
        //Camel casing
        List<SchoolYear> schoolYears = new List<SchoolYear>();
        /******************************
         * Protected Method
         * ***************************/
        /******************************
         * Private Method
         * ***************************/
        /******************************
         * Public Method
         * ***************************/

        public void LoadDataTable(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT * FROM school_year";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    //initialize new datatable
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public List<SchoolYear> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM school_year";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        SchoolYear schoolYear = new SchoolYear();

                        //prepare properties
                        schoolYear.id = Convert.ToInt32(reader["id"].ToString());
                        schoolYear.yearStart = reader["year_start"].ToString();
                        schoolYear.yearEnd = reader["year_end"].ToString();
                        schoolYear.semester = reader["semester"].ToString();
                        schoolYear.quaterGrading = reader["quarter_grading"].ToString();

                        schoolYears.Add(schoolYear);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return schoolYears;
        }//End of Load

        public List<SchoolYear> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM school_year WHERE id =@id;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        SchoolYear schoolYear = new SchoolYear();

                        //prepare properties
                        schoolYear.id = Convert.ToInt32(reader["id"].ToString());
                        schoolYear.yearStart = reader["year_start"].ToString();
                        schoolYear.yearEnd = reader["year_end"].ToString();
                        schoolYear.semester = reader["semster"].ToString();
                        schoolYear.quaterGrading = reader["quarter_grading"].ToString();

                        schoolYears.Add(schoolYear);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return schoolYears;
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

                    string sql = "INSERT INTO school_year(year_start,year_end,semester,quater_grading) " +
                                    " VALUES (@yearStart,@yearEnd,@semester,@quaterGrading);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("yearStart", yearStart);
                    cmd.Parameters.AddWithValue("yearEnd", yearEnd);
                    cmd.Parameters.AddWithValue("semester", semester);
                    cmd.Parameters.AddWithValue("quaterGrading", quaterGrading);



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

                    string sql = "UPDATE school_year SET year_start=@yearStart,year_end=@yearEnd,semester=@semester,quarter=@quater_grading" +
                                    " WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("yearStart", yearStart);
                    cmd.Parameters.AddWithValue("yearEnd", yearEnd);
                    cmd.Parameters.AddWithValue("quaterGrading", quaterGrading);
                    cmd.Parameters.AddWithValue("semester", semester);

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

                    string sql = "DELETE  FROM school_year WHERE id=@id;";

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
