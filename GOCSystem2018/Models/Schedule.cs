using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class Schedule
    {
        /******************************
         * Protected Properties
         * ***************************/
        protected int id;
        protected string timeStart;
        protected string timeEnd;
        protected string day1;
        protected string day2;
        protected string day3;
        protected string day4;
        protected string day5;
        protected string section;
        protected string counter;

        List<Schedule> schedules = new List<Schedule>();

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
        public string TimeStart
        {
            get { return timeStart; }
            set { timeStart = value; }
        }
        public string TimeEnd
        {
            get { return timeEnd; }
            set { timeEnd = value; }
        }
        public string Day1
        {
            get { return day1; }
            set { day1 = value; }
        }
        public string Day2
        {
            get { return day2; }
            set { day2 = value; }
        }
        public string Day3
        {
            get { return day3; }
            set { day3 = value; }
        }
        public string Day4
        {
            get { return day4; }
            set { day4 = value; }
        }
        public string Day5
        {
            get { return day5; }
            set { day5 = value; }
        }
        public string Section
        {
            get { return section; }
            set { section = value; }
        }
        public string Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        public List<Schedule> GetScheduleById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM schedule_main;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    //cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("time_start", timeStart);
                    cmd.Parameters.AddWithValue("time_end", timeEnd);
                    cmd.Parameters.AddWithValue("day_1", day1);
                    cmd.Parameters.AddWithValue("day_2", day2);
                    cmd.Parameters.AddWithValue("day_3", day3);
                    cmd.Parameters.AddWithValue("day_4", day4);
                    cmd.Parameters.AddWithValue("day_5", day5);
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("counter", counter);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Schedule schedule = new Schedule();

                        //prepare properties
                        schedule.id = Convert.ToInt32(reader["id"].ToString());
                        schedule.timeStart = reader["time_start"].ToString();
                        schedule.timeEnd = reader["time_end"].ToString();
                        schedule.day1 = reader["day_1"].ToString();
                        schedule.day2 = reader["day_2"].ToString();
                        schedule.day3 = reader["day_3"].ToString();
                        schedule.day4 = reader["day_4"].ToString();
                        schedule.day5 = reader["day_5"].ToString();
                        schedule.section = reader["section"].ToString();
                        schedule.counter = reader["counter"].ToString();
                        
                        schedules.Add(schedule);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return schedules;
        }


        public List<Schedule>Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM schedule_main";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Schedule schedule = new Schedule();

                        //prepare properties
                        //schedule.id = Convert.ToInt32(reader["id"].ToString());
                        schedule.timeStart = reader["time_start"].ToString();
                        schedule.timeEnd = reader["time_end"].ToString();
                        schedule.day1 = reader["day_1"].ToString();
                        schedule.day2 = reader["day_2"].ToString();
                        schedule.day3 = reader["day_3"].ToString();
                        schedule.day4 = reader["day_4"].ToString();
                        schedule.day5 = reader["day_5"].ToString();
                        schedule.section = reader["section"].ToString();
                        schedule.counter = reader["counter"].ToString();

                        schedules.Add(schedule);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return schedules;
        }//End of Load









    }
}
