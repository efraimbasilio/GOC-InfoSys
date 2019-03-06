using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class Config
    {
        protected static string server = "localhost";
        protected static string port = "3306";
        protected static string username = "root";
        protected static string password = "";
        protected static string database = "goc_info_sys";



        public static string GetConnectionString()
        {
            return string.Format("SERVER = {0};PORT= {1};USERNAME = {2};PASSWORD = {3}; DATABASE = {4};", server, port, username, password, database);
        }

        public void TestConnection()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    MessageBox.Show("Connection Success!!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
