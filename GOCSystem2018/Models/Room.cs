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
    class Room
    {
        /******************************
         * Protected Properties
         * ***************************/
        protected int id;
        protected string roomName;
        protected string roomLocation;
        protected string roomCapacity;
        private string roomCeiling;

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

        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        public string RoomLocation
        {
            get { return roomLocation; }
            set { roomLocation = value; }
        }

        public string RoomCapacity
        {
            get { return roomCapacity; }
            set { roomCapacity = value; }
        }

        public string RoomCeiling
        {
            get { return roomCeiling; }
            set { roomCeiling = value; }
        }
        //variable name should always to be plural for every list
        //Camel casing
        List<Room> rooms = new List<Room>();
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
                    string sql = "SELECT * FROM room";
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
        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO room(room_name,location,capacity) " +
                                    " VALUES (@roomName,@roomLocation,@roomCapacity);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("roomName", roomName);
                    cmd.Parameters.AddWithValue("roomLocation", roomLocation);
                    cmd.Parameters.AddWithValue("roomCapacity", roomCapacity);
                    cmd.Parameters.AddWithValue("roomCeiling", roomCeiling);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public List<Room> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM room";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                       Room room = new Room();

                        //prepare properties
                        room.id = Convert.ToInt32(reader["id"].ToString());
                        room.roomName = reader["room_name"].ToString();
                        room.roomLocation = reader["location"].ToString();
                        room.roomCapacity = reader["capacity"].ToString();
                        room.roomCeiling = reader["room_ceiling"].ToString();

                        rooms.Add(room);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rooms;
        }//End of Load

        public void Update()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE room SET room_name=@roomName,location=@roomLocation,capacity=@roomCapacity" +
                                    " WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("roomName", roomName);
                    cmd.Parameters.AddWithValue("roomLocation", roomLocation);
                    cmd.Parameters.AddWithValue("roomCapacity", roomCapacity);
                    cmd.Parameters.AddWithValue("roomCeiling", roomCeiling);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Recorde Updated!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Room> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM room WHERE id =@id;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Room room = new Room();

                        //prepare properties
                        room.id = Convert.ToInt32(reader["id"].ToString());
                        room.roomName = reader["room_name"].ToString();
                        room.roomLocation = reader["location"].ToString();
                        room.roomCapacity = reader["capacity"].ToString();
                        room.roomCeiling = reader["room_ceiling"].ToString();

                        rooms.Add(room);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rooms;
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

                    string sql = "DELETE  FROM room WHERE id=@id;";

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

        public List<Room> GetRoomSectionCapacity()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM room WHERE room_Name =@roomName;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("roomName", roomName);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Room room = new Room();

                        //prepare properties
                        //room.id = Convert.ToInt32(reader["id"].ToString());
                        //room.roomName = reader["room_name"].ToString();
                        //room.roomLocation = reader["location"].ToString();
                        room.roomCapacity = reader["capacity"].ToString();
                        room.roomCeiling = reader["room_ceiling"].ToString();

                        //MessageBox.Show(room.roomCapacity);
                        rooms.Add(room);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rooms;
        }
    }
}