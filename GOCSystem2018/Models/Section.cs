using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class Section
    {
        /******************************
         * Protected Properties
         * ***************************/
        protected int id;
        protected string sectionName;
        protected string sectionDesc;
        protected string strand;
        protected string dept;
        protected string room;

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

        public string SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }

        public string SectionDesc
        {
            get { return sectionDesc; }
            set { sectionDesc = value; }
        }

        public string Strand
        {
            get { return strand; }
            set { strand = value; }
        }
        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public string Room
        {
            get { return room; }
            set { room = value; }
        }
        //variable name should always to be plural for every list
        //Camel casing
        List<Section> sections = new List<Section>();
        /******************************
         * Protected Method
         * ***************************/
        /******************************
         * Private Method
         * ***************************/
        /******************************
         * Public Method
         * ***************************/
        public List<Section> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM section";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Section section = new Section();

                        //prepare properties
                        section.id = Convert.ToInt32(reader["id"].ToString());
                        section.sectionName = reader["section_name"].ToString();
                        section.sectionDesc = reader["section_desc"].ToString();
                        section.strand = reader["strand"].ToString();
                        section.dept = reader["dept"].ToString();
                        section.room = reader["rooms"].ToString();
                        sections.Add(section);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sections;
        }//End of Load

        public List<Section> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM section WHERE id =@id;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Section section = new Section();

                        //prepare properties
                        section.id = Convert.ToInt32(reader["id"].ToString());
                        section.sectionName = reader["section_name"].ToString();
                        section.sectionDesc = reader["section_desc"].ToString();
                        section.strand = reader["strand"].ToString();
                        section.dept = reader["dept"].ToString();
                        section.room = reader["room"].ToString();

                        sections.Add(section);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return sections;
        }

        public List<Section> GetPerStrand()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM section WHERE strand =@strand;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("strand", strand);

                    MessageBox.Show(strand);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Section section = new Section();

                        //prepare properties
                        section.id = Convert.ToInt32(reader["id"].ToString());
                        section.sectionName = reader["section_name"].ToString();
                        //section.sectionDesc = reader["section_desc"].ToString();
                        //section.strand = reader["strand"].ToString();
                        //section.dept = reader["dept"].ToString();

                        MessageBox.Show(section.sectionName);

                        sections.Add(section);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return sections;
        }

        public List<Section> GetRoomBySectionRoom()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT rooms FROM section WHERE section_name =@sectionName;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("sectionName", sectionName);

                    //MessageBox.Show(strand);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Section section = new Section();

                        //prepare properties
                        //section.id = Convert.ToInt32(reader["id"].ToString());
                        section.room = reader["rooms"].ToString();
                        //section.sectionDesc = reader["section_desc"].ToString();
                        //section.strand = reader["strand"].ToString();
                        //section.dept = reader["dept"].ToString();

                       MessageBox.Show(section.room);

                        sections.Add(section);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return sections;
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

                    string sql = "INSERT INTO section(section_name,section_desc,strand,dept,room) " +
                                    " VALUES (@sectionName,@sectionDesc,@strand,@dept,@room);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("sectionName", sectionName);
                    cmd.Parameters.AddWithValue("sectionDesc", sectionDesc);
                    cmd.Parameters.AddWithValue("strand", strand);
                    cmd.Parameters.AddWithValue("dept", dept);
                    cmd.Parameters.AddWithValue("room", room);


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

                    string sql = "UPDATE section SET section_name=@sectionName,section_desc=@sectionDesc, ,strand = @strand, dept=@dept" +
                                    " WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("sectionName", sectionName);
                    cmd.Parameters.AddWithValue("sectionDesc", sectionDesc);
                    cmd.Parameters.AddWithValue("strand", strand);
                    cmd.Parameters.AddWithValue("dept", dept);
                    cmd.Parameters.AddWithValue("room", room);

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

                    string sql = "DELETE  FROM section WHERE id=@id;";

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
