using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class Subject
    {
        /******************************
         * Protected Properties
         * ***************************/
        protected int id;
        protected string subjectCode;
        protected string subjectDesc;

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

        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        public string SubjectDesc
        {
            get { return subjectDesc; }
            set { subjectDesc = value; }
        }
        //variable name should always to be plural for every list
        //Camel casing
        List<Subject> subjects = new List<Subject>();
        /******************************
         * Protected Method
         * ***************************/
        /******************************
         * Private Method
         * ***************************/
        /******************************
         * Public Method
         * ***************************/

        public List<Subject> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM subject";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Subject subject = new Subject();

                        //prepare properties
                        subject.id = Convert.ToInt32(reader["id"].ToString());
                        subject.subjectCode = reader["subject_code"].ToString();
                        subject.subjectDesc = reader["subject_desc"].ToString();

                        subjects.Add(subject);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return subjects;
        }//End of Load

        public List<Subject> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM subject WHERE id =@id;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Subject subject = new Subject();

                        //prepare properties
                        subject.id = Convert.ToInt32(reader["id"].ToString());
                        subject.subjectCode = reader["subject_code"].ToString();
                        subject.subjectDesc = reader["subject_desc"].ToString();

                        subjects.Add(subject);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return subjects;
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

                    string sql = "INSERT INTO subject(subject_code,subject_desc) " +
                                    " VALUES (@subjectCode,@subjectDesc);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("subjectCode", subjectCode);
                    cmd.Parameters.AddWithValue("subjectDesc", subjectDesc);


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

                    string sql = "UPDATE subject SET subject_code=@subjectCode,subject_desc=@subjectDesc" +
                                    " WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("subjectCode", subjectCode);
                    cmd.Parameters.AddWithValue("subjectDesc", subjectDesc);


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

                    string sql = "DELETE  FROM subject WHERE id=@id;";

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
