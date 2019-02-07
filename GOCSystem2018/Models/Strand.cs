using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class Strand
    {
        /******************************
         * Protected Properties
         * ***************************/
        protected int id;
        protected string strandName;
        protected string strandDesc;

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

        public string StrandName
        {
            get { return strandName; }
            set { strandName = value; }
        }

        public string StrandDesc
        {
            get { return strandDesc; }
            set { strandDesc = value; }
        }

        //variable name should always to be plural for every list
        //Camel casing
        List<Strand> strands = new List<Strand>();
        /******************************
         * Protected Method
         * ***************************/
        /******************************
         * Private Method
         * ***************************/
        /******************************
         * Public Method
         * ***************************/

        public List<Strand> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM strand";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Strand strand = new Strand();

                        //prepare properties
                        strand.id = Convert.ToInt32(reader["id"].ToString());
                        strand.strandName = reader["strand_name"].ToString();
                        strand.strandDesc = reader["strand_desc"].ToString();

                        strands.Add(strand);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return strands;
        }//End of Load

        public List<Strand> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM strand WHERE id =@id;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Strand strand = new Strand();

                        //prepare properties
                        strand.id = Convert.ToInt32(reader["id"].ToString());
                        strand.strandName = reader["strand_name"].ToString();
                        strand.strandDesc = reader["strand_desc"].ToString();

                        strands.Add(strand);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return strands;
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

                    string sql = "INSERT INTO strand(strand_name,strand_desc) " +
                                    " VALUES (@strandName,@strandDesc);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("strandName", strandName);
                    cmd.Parameters.AddWithValue("strandDesc", strandDesc);


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

                    string sql = "UPDATE strand SET strand_name=@strandName, strand_desc=@strandDesc" +
                                    " WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("strandName", strandName);
                    cmd.Parameters.AddWithValue("strandDesc", strandDesc);


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

                    string sql = "DELETE  FROM strand WHERE id=@id;";

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
