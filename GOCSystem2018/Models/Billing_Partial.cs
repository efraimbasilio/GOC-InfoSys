using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class Billing_Partial
    {
        /******************************
       * Protected Properties
       * ***************************/
        protected int id;
        protected string enStatus;
        protected string oRNo;
        protected string idNo;
        protected string full_name;
        protected string downPayment;
        protected string p1;
        protected string p2;
        protected string p3;
        protected string p4;
        protected string p5;
        protected string p6;
        protected string p7;
        protected string p8;
        protected string p9;
        protected string p10;
        protected string balance;
        protected string regNo;

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
        public string EnStatus
        {
            get { return enStatus; }
            set { enStatus = value; }
        }

        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        public string IdNo
        {
            get { return idNo; }
            set { idNo = value; }
        }
       
        public string ORNo
        {
            get { return oRNo; }
            set { oRNo = value; }
        }

        public string DownPayment
        {
            get { return downPayment; }
            set { downPayment = value; }
        }

        public string Full_name
        {
            get { return full_name; }
            set { full_name = value; }
        }
        public string P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        public string P2
        {
            get { return p2; }
            set { p2 = value; }
        }
        public string P3
        {
            get { return p3; }
            set { p3 = value; }
        }
        public string P4
        {
            get { return p4; }
            set { p4 = value; }
        }

        public string P5
        {
            get { return p5; }
            set { p5 = value; }
        }

        public string P6
        {
            get { return p6; }
            set { p6 = value; }
        }
        public string P7
        {
            get { return p7; }
            set { p7 = value; }
        }

        public string P8
        {
            get { return p8; }
            set { p8 = value; }
        }

        public string P9
        {
            get { return p9; }
            set { p9 = value; }
        }

        public string P10
        {
            get { return p10; }
            set { p10 = value; }
        }

        public string Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        List<Billing_Partial> billingPartials = new List<Billing_Partial>();

        public void Update()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE billing_partial SET DP=@downPayment,regNo=@regNo,1p=@p1,2p=@p2,3p=@p3,4p=@p4, 5p=@p5, 6p=@p6, 7p=@p7, 8p=@p8, 9p=@p9, 10p=@p10, balance=@balance , Enrollment_Status=@enStatus" +
                                    " WHERE IDNo=@idNo;";
                    //Enrollment_Status,OR_No,IDNo,full_name,DP,1p,2p,3p,4p,5p,6p,7p,8p,9p,10p,balance
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("enStatus", enStatus);
                    cmd.Parameters.AddWithValue("oRNo", oRNo);
                    cmd.Parameters.AddWithValue("idNo", idNo);
                    cmd.Parameters.AddWithValue("full_name", full_name);
                    cmd.Parameters.AddWithValue("downPayment", downPayment);
                    cmd.Parameters.AddWithValue("p1", p1);
                    cmd.Parameters.AddWithValue("p2", p2);
                    cmd.Parameters.AddWithValue("p3", p3);
                    cmd.Parameters.AddWithValue("p4", p4);
                    cmd.Parameters.AddWithValue("p5", p5);
                    cmd.Parameters.AddWithValue("p6", p6);
                    cmd.Parameters.AddWithValue("p7", p7);
                    cmd.Parameters.AddWithValue("p8", p8);
                    cmd.Parameters.AddWithValue("p9", p9);
                    cmd.Parameters.AddWithValue("p10", p10);
                    cmd.Parameters.AddWithValue("regNo", regNo);
                    cmd.Parameters.AddWithValue("balance", balance);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Recorde Updated!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    string sql = "INSERT INTO billing_partial(Enrollment_Status,OR_No,IDNo,full_name,DP,1p,2p,3p,4p,5p,6p,7p,8p,9p,10p,balance,regNo) " +
                    "VALUES (@enStatus,@oRNo,@idNo,@full_name,@downPayment,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@balance,@regno);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    //cmd.Parameters.AddWithValue("regNo", regNo);
                    cmd.Parameters.AddWithValue("enStatus", enStatus);
                    cmd.Parameters.AddWithValue("oRNo", oRNo);
                    cmd.Parameters.AddWithValue("idNo", idNo);                   
                    cmd.Parameters.AddWithValue("full_name", full_name);
                    cmd.Parameters.AddWithValue("downPayment", downPayment);
                    cmd.Parameters.AddWithValue("p1", p1);
                    cmd.Parameters.AddWithValue("p2", p2);
                    cmd.Parameters.AddWithValue("p3", p3);
                    cmd.Parameters.AddWithValue("p4", p4);
                    cmd.Parameters.AddWithValue("p5", p5);
                    cmd.Parameters.AddWithValue("p6", p6);
                    cmd.Parameters.AddWithValue("p7", p7);
                    cmd.Parameters.AddWithValue("p8", p8);
                    cmd.Parameters.AddWithValue("p9", p9);
                    cmd.Parameters.AddWithValue("p10", p10);
                    cmd.Parameters.AddWithValue("regNo", regNo);
                    cmd.Parameters.AddWithValue("balance", balance);      
                                 
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public List<Billing_Partial> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM billing_partial WHERE id =@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Billing_Partial billingPartial = new Billing_Partial();

                        //prepare properties
                        billingPartial.id = Convert.ToInt32(reader["id"].ToString());
                        billingPartial.enStatus = reader["enrollment_status"].ToString();
                        billingPartial.oRNo = reader["or_no"].ToString();
                        billingPartial.idNo = reader["idno"].ToString();
                        billingPartial.full_name = reader["full_name"].ToString();
                        billingPartial.downPayment = reader["dp"].ToString();
                        billingPartial.p1 = reader["1p"].ToString();
                        billingPartial.p2 = reader["2p"].ToString();
                        billingPartial.p3 = reader["3p"].ToString();
                        billingPartial.p4 = reader["4p"].ToString();
                        billingPartial.p5 = reader["5p"].ToString();
                        billingPartial.p6 = reader["6p"].ToString();
                        billingPartial.p7 = reader["7p"].ToString();
                        billingPartial.p8 = reader["8p"].ToString();
                        billingPartial.p9 = reader["9p"].ToString();
                        billingPartial.p10 = reader["10p"].ToString();
                        billingPartial.regNo = reader["regno"].ToString();
                        billingPartial.balance = reader["balance"].ToString();
                        
                        billingPartials.Add(billingPartial);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return billingPartials;
        }

        public List<Billing_Partial> GetPartialBalance()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM billing_partial WHERE IDNo =@idNo;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("idNo", idNo);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Billing_Partial billingPartial = new Billing_Partial();

                        //prepare properties
                        
                        billingPartial.balance = reader["balance"].ToString();
                        billingPartial.downPayment = reader["DP"].ToString();

                        billingPartials.Add(billingPartial);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return billingPartials;
        }

        public List<Billing_Partial> GetMonthlyDue()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM billing_partial WHERE RegNo =@regNo;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("regNo", regNo);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Billing_Partial billingPartial = new Billing_Partial();

                        //prepare properties

                        //billingPartial.id = Convert.ToInt32(reader["id"].ToString());
                        //billingPartial.enStatus = reader["enrollment_status"].ToString();
                        //billingPartial.oRNo = reader["or_no"].ToString();
                        //billingPartial.idNo = reader["idno"].ToString();
                        //billingPartial.full_name = reader["full_name"].ToString();
                        billingPartial.downPayment = reader["dp"].ToString();
                        billingPartial.p1 = reader["1p"].ToString();
                        billingPartial.p2 = reader["2p"].ToString();
                        billingPartial.p3 = reader["3p"].ToString();
                        billingPartial.p4 = reader["4p"].ToString();
                        billingPartial.p5 = reader["5p"].ToString();
                        billingPartial.p6 = reader["6p"].ToString();
                        billingPartial.p7 = reader["7p"].ToString();
                        billingPartial.p8 = reader["8p"].ToString();
                        billingPartial.p9 = reader["9p"].ToString();
                        billingPartial.p10 = reader["10p"].ToString();
                        //billingPartial.balance = reader["balance"].ToString();

                        billingPartials.Add(billingPartial);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return billingPartials;
        }
    }
}
