using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GOCSystem2018
{
    class User
    {
        /******************************
         * Protected Properties
         * ***************************/
        protected int id;
        protected string username;
        protected string password;
        protected string userType;
        protected bool status;

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
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        List<User> users = new List<User>();

        //public void AccessGrant()
        //{
        //    try
        //    {
        //        using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
        //        {
        //            con.Open();

        //            string sql = "SELECT * FROM users";
        //            MySqlCommand cmd = new MySqlCommand(sql, con);

        //            MySqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                //instantiate model
        //                Judges judge = new Judges();

        //                //set properties
        //                judge.judgeNumber = Int32.Parse(reader["judge_present"].ToString());

        //                //add object to list
        //                judgepresent.Add(judge);

        //            }
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Error : " + ex.Message.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return judgepresent;
        //}

        public void AccessGrant()
        {

            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();
                    
                    //prepare sql query
                    string sql = "UPDATE users SET username=@username,password=@password WHERE id = @id";
                  
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", 5);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Updated", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // status = true;
                }
            }
            catch (MySqlException ex)
            {
                //status = false;
                MessageBox.Show("Error : " + ex.Message.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void AccessGrant2()
        {

            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM users WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", 5);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);

                        users.Add(this);
                    }
                }
            }
            // MessageBox.Show("Updated", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // status = true;
            catch (MySqlException ex)
            {
                //status = false;
                MessageBox.Show("Error : " + ex.Message.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
