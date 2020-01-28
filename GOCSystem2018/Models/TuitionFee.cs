using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add Mysql Reference
using MySql.Data.MySqlClient;
//For Message Box
using System.Windows.Forms;
using System.Data;

namespace GOCSystem2018.Models
{
    class TuitionFee
    {
        /******************************
         * Protected Properties
         * ***************************/
        protected int id;
        protected string tuitionFeeName;
        protected string tuitionFeeAmount;
        protected string tuitionFeeDescription;
        protected string status;
        protected string dept;
        protected string revFee;
        protected string reservationFee;

        public string ReservationFee
        {
            get { return reservationFee; }
            set { reservationFee = value; }
        }

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

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        //Pascal Casing For Every Public Variables
        public string TuitionFeeName
        {
            get { return tuitionFeeName; }
            set { tuitionFeeName = value; }
        }
        public string TuitionFeeAmount
        {
            get { return tuitionFeeAmount; }
            set { tuitionFeeAmount = value; }
        }

        public string TuitionFeeDescription
        {
            get { return tuitionFeeDescription; }
            set { tuitionFeeDescription = value; }
        }

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public string RevFee
        {
            get { return revFee; }
            set { revFee = value; }
        }

        //variable name should always to be plural for every list
        //Camel casing
        List<TuitionFee> tuitionFees = new List<TuitionFee>();
       
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
                    string sql = "SELECT * FROM tuition_fee";
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

                    string sql = "INSERT INTO tuition_fee(tuition_fee_name, tuition_amount, tuition_desc, status, Department, Reservation_Fee) " +
                                    " VALUES (@tuitionFeeName, @tuitionFeeAmount, @tuitionFeeDescription, @status, @dept, @reservationFee);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("tuitionFeeName", tuitionFeeName);
                    cmd.Parameters.AddWithValue("tuitionFeeAmount", tuitionFeeAmount);
                    cmd.Parameters.AddWithValue("tuitionFeeDescription", tuitionFeeDescription);
                    cmd.Parameters.AddWithValue("status", status);
                    cmd.Parameters.AddWithValue("dept", dept );
                    cmd.Parameters.AddWithValue("reservationFee", reservationFee);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public List<TuitionFee> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM tuition_fee";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        TuitionFee tuitionFee = new TuitionFee();

                        //prepare properties
                        tuitionFee.id = Convert.ToInt32(reader["id"].ToString());
                        tuitionFee.tuitionFeeName = reader["tuition_fee_name"].ToString();
                        tuitionFee.tuitionFeeAmount = reader["tuition_amount"].ToString();
                        tuitionFee.tuitionFeeDescription = reader["tuition_desc"].ToString();
                        tuitionFee.status = reader["status"].ToString();
                        tuitionFee.reservationFee = reader["Reservation_Fee"].ToString();
                        tuitionFee.dept = reader["Department"].ToString();

                        tuitionFees.Add(tuitionFee);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tuitionFees;
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

                    string sql = "UPDATE tuition_fee SET tuition_fee_name=@tuitionFeeName,tuition_amount=@tuitionFeeAmount,tuition_desc=@tuitionFeeDescription, Department=@dept, status=@status , Reservation_Fee=@reservationFee" +
                                    " WHERE id=@id;";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("tuitionFeeName", tuitionFeeName);
                    cmd.Parameters.AddWithValue("tuitionFeeAmount", tuitionFeeAmount);
                    cmd.Parameters.AddWithValue("tuitionFeeDescription", tuitionFeeDescription);
                    cmd.Parameters.AddWithValue("dept", dept);
                    cmd.Parameters.AddWithValue("status", status);
                    cmd.Parameters.AddWithValue("reservationFee", reservationFee);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Recorde Updated!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public List<TuitionFee> GetTuitionFeeById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM tuition_fee;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("tuition_fee_name", this.tuitionFeeName);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        TuitionFee tuitionFee = new TuitionFee();

                        //prepare properties
                        tuitionFee.id = Convert.ToInt32(reader["id"].ToString());
                        tuitionFee.tuitionFeeName = reader["tuition_fee_name"].ToString();
                        tuitionFee.tuitionFeeAmount = reader["tuition_amount"].ToString();
                        tuitionFee.tuitionFeeDescription = reader["tuition_desc"].ToString();
                        tuitionFee.status = reader["status"].ToString();
                        tuitionFee.reservationFee = reader["Reservation_Fee"].ToString();
                        tuitionFee.dept = reader["Department"].ToString();

                        tuitionFees.Add(tuitionFee);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return tuitionFees;
        }

        public List<TuitionFee>GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM tuition_fee WHERE id =@id;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        TuitionFee tuitionFee = new TuitionFee();

                        //prepare properties
                        tuitionFee.id = Convert.ToInt32(reader["id"].ToString());
                        tuitionFee.tuitionFeeName = reader["tuition_fee_name"].ToString();
                        tuitionFee.tuitionFeeAmount = reader["tuition_amount"].ToString();
                        tuitionFee.tuitionFeeDescription = reader["tuition_desc"].ToString();
                        tuitionFee.status = reader["status"].ToString();
                        tuitionFee.reservationFee = reader["Reservation_Fee"].ToString();
                        tuitionFee.dept = reader["Department"].ToString();

                        tuitionFees.Add(tuitionFee);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return tuitionFees;
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

                    string sql = "DELETE  FROM tuition_fee WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record deleted!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }        
    }
}


