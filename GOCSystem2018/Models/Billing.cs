using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GOCSystem2018
{
    class Billing
    {
        /******************************
        * Protected Properties
        * ***************************/
        protected int id;
        protected string studentId;
        protected string orNo;
        protected double amountGiven;
        protected string paymentNo;
        protected string paymentDate;
        protected string mop;
        //protected string paymentDate;

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

        public string PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }
        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string OrNo
        {
            get { return orNo; }
            set { orNo = value; }
        }
        public double AmountGiven
        {
            get { return amountGiven; }
            set { amountGiven = value; }
        }
        public string PaymentNo
        {
            get { return paymentNo; }
            set { paymentNo = value; }
        }
        public string MOP
        {
            get { return mop; }
            set { mop = value; }
        }

        List<Billing> bills = new List<Billing>();

        public List<Billing>Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM billing_or";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Billing bill = new Billing();

                        //prepare properties
                        bill.id = Convert.ToInt32(reader["id"].ToString());
                        bill.studentId = reader["IDNo"].ToString();
                        bill.orNo = reader["OrNo"].ToString();
                        bill.amountGiven =Convert.ToDouble(reader["amount_given"].ToString());
                        bill.paymentNo = reader["payment_no"].ToString();
                        bill.paymentDate = reader["payment_date"].ToString();
                        //bill.mop = reader["MOP"].ToString();

                        bills.Add(bill);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bills;
        }//End of Load

        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO billing_or(IDNo,OrNo,amount_given,payment_no,MOP) " +
                                    " VALUES (@studentId,@orNo,@amountGiven,@paymentNo,@mop);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("studentId", studentId);
                    cmd.Parameters.AddWithValue("orNo", orNo);
                    cmd.Parameters.AddWithValue("amountGiven", amountGiven);
                    cmd.Parameters.AddWithValue("paymentNo", paymentNo);
                    cmd.Parameters.AddWithValue("mop", mop);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
      
        public List<Billing> GetPaymentNo()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM billing_or WHERE IDNo=@studentId;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("studentId", studentId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Billing bill = new Billing();
                        //prepare properties
                        bill.paymentNo = reader["payment_no"].ToString();
                        bills.Add(bill);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return bills;
        }

        public List<Billing> GetReserveFee()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM billing_or WHERE payment_No=@paymentNo and IDNo=@studentId;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("paymentNo", paymentNo);
                    cmd.Parameters.AddWithValue("studentId", studentId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Billing bill = new Billing();
                        //prepare properties
                        bill.amountGiven = Convert.ToDouble(reader["amount_given"].ToString());
                        bills.Add(bill);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return bills;
        }

        public List<Billing> GetPaymentHistory()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM billing_or WHERE IDNo=@studentId;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("studentId", studentId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Billing bill = new Billing();
                        //prepare properties
                        bill.id = Convert.ToInt32(reader["id"].ToString());
                        bill.studentId = reader["IDNo"].ToString();
                        bill.orNo = reader["OrNo"].ToString();
                        bill.amountGiven = Convert.ToDouble(reader["amount_given"].ToString());
                        bill.paymentNo = reader["payment_no"].ToString();
                        bill.paymentDate = reader["payment_date"].ToString();

                        bills.Add(bill);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return bills;
        }
    }
}
