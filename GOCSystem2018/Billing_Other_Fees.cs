using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class Billing_Other_Fees
    {
        /******************************
         ** Protected Properties
        * ***************************/
        protected string gocNumber;
        protected string orNo;
        protected string gLevel;
        protected string uniform;
        protected string books;
        protected string locker;

        //protected string paymentDate;

        /******************************
         * Private Properties
         * ***************************/
        /******************************
         * Public Properties
         * ***************************/

        public string GocNumber
        {
            get { return gocNumber; }
            set { gocNumber = value; }
        }
        public string OrNo
        {
            get { return orNo; }
            set { orNo = value; }
        }
        public string GLevel
        {
            get { return gLevel; }
            set { gLevel = value; }
        }

        public string Uniform
        {
            get { return uniform; }
            set { uniform = value; }
        }

        public string Books
        {
            get { return books; }
            set { books = value; }
        }

        public string Locker
        {
            get { return locker; }
            set { locker = value; }
        }

        List<Billing_Other_Fees> otherFees = new List<Billing_Other_Fees>();

        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO billing_other_fees(gocnumber,orno, grade_level, uniform, books, locker) " +
                                    " VALUES (@gocNumber,@orNo,@gLevel,@uniform,@books,@locker);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("gocNumber", gocNumber);
                    cmd.Parameters.AddWithValue("orNo", orNo);
                    cmd.Parameters.AddWithValue("gLevel", gLevel);
                    cmd.Parameters.AddWithValue("uniform", uniform);
                    cmd.Parameters.AddWithValue("books", books);
                    cmd.Parameters.AddWithValue("locker", locker);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public List<Billing_Other_Fees> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM billing_other_fees";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Billing_Other_Fees other = new Billing_Other_Fees();

                        //prepare properties                       
                        other.gocNumber = reader["gocNumber"].ToString();
                        other.orNo = reader["orno"].ToString();
                        other.gLevel = reader["grade_level"].ToString();
                        other.uniform = reader["uniform"].ToString();
                        other.books = reader["books"].ToString();
                        other.locker = reader["locker"].ToString();

                        otherFees.Add(other);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return otherFees;
        }//End of Load


        public List<Billing_Other_Fees> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM billing_other_fees WHERE gocNumber =@gocNumber;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("gocNumber", gocNumber);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Billing_Other_Fees other = new Billing_Other_Fees();

                        //prepare properties                       
                        other.gocNumber = reader["gocNumber"].ToString();
                        other.orNo = reader["orno"].ToString();
                        other.gLevel = reader["grade_level"].ToString();
                        other.uniform = reader["uniform"].ToString();
                        other.books = reader["books"].ToString();
                        other.locker = reader["locker"].ToString();

                        otherFees.Add(other);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return otherFees;
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

                    string sql = "UPDATE billing_other_fees SET OrNo=@OrNo, grade_level=@gLevel, uniform=@uniform, books=@books, locker=@locker" +
                                    " WHERE gocNumber=@gocNumber;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("gocNumber", gocNumber);
                    cmd.Parameters.AddWithValue("OrNo", OrNo);
                    cmd.Parameters.AddWithValue("gLevel", gLevel);
                    cmd.Parameters.AddWithValue("uniform", uniform);
                    cmd.Parameters.AddWithValue("books", books);
                    cmd.Parameters.AddWithValue("locker", locker);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Recorde Updated!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
