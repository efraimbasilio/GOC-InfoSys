using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class TempRegNo
    {
        protected int id;
        protected string tempRegNo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Temp_RegNo
        {
            get { return tempRegNo; }
            set { tempRegNo = value; }
        }

        List<TempRegNo> tempRegNos = new List<TempRegNo>();

        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO tempRegNo(RegNo) " +
                                 "VALUES (@tempRegNo); ";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    
                    cmd.Parameters.AddWithValue("tempRegNo", tempRegNo);
                 

                    cmd.ExecuteNonQuery();

                   // MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public List<TempRegNo> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM tempRegNo";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        TempRegNo tempREGNo = new TempRegNo();

                        //prepare properties
                        tempREGNo.id = Convert.ToInt32(reader["id"].ToString());
                        tempREGNo.tempRegNo = reader["Regno"].ToString();

                        tempRegNos.Add(tempREGNo);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tempRegNos;
        }//End of Load


    }
}
