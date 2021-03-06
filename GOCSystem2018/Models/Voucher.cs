﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace GOCSystem2018
{
    class Voucher
    {
        /******************************
         * Protected Properties
         * ***************************/
        protected int id;
        protected string voucherFrom;
        protected string voucherAmount;
        protected string dpAmount;

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

        public string VoucherFrom
        {
            get { return voucherFrom; }
            set { voucherFrom = value; }
        }

        public string VoucherAmount
        {
            get { return voucherAmount; }
            set { voucherAmount = value; }
        }
        public string DpAmount
        {
            get { return dpAmount; }
            set { dpAmount = value; }
        }

        //variable name should always to be plural for every list
        //Camel casing
        List<Voucher> vouchers = new List<Voucher>();
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
                    string sql = "SELECT * FROM voucher";
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
        public List<Voucher> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM voucher";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Voucher voucher = new Voucher();

                        //prepare properties
                        voucher.id = Convert.ToInt32(reader["id"].ToString());
                        voucher.voucherFrom = reader["voucher_from"].ToString();
                        voucher.voucherAmount = reader["voucher_amount"].ToString();

                        vouchers.Add(voucher);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return vouchers;
        }//End of Load

        public List<Voucher> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM voucher WHERE id =@id;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Voucher voucher = new Voucher();

                        //prepare properties
                        voucher.id = Convert.ToInt32(reader["id"].ToString());
                        voucher.voucherFrom = reader["voucher_from"].ToString();
                        voucher.voucherAmount = reader["voucher_amount"].ToString();

                        vouchers.Add(voucher);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return vouchers;
        }

        public List<Voucher> GetDownpaymnet()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM voucher WHERE voucher_from =@voucherFrom;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    //this is the criteria for filtering
                    cmd.Parameters.AddWithValue("voucherFrom", voucherFrom);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Voucher voucher = new Voucher();

                        //prepare properties to be send out
                        voucher.DpAmount = reader["DP_amount"].ToString();
                       
                        vouchers.Add(voucher);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return vouchers;
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

                    string sql = "INSERT INTO voucher(voucher_from,voucher_amount,DP_amount) " +
                                    " VALUES (@voucherFrom,@voucherAmount,@dpAmount);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("voucherFrom", voucherFrom);
                    cmd.Parameters.AddWithValue("voucherAmount", voucherAmount);
                    cmd.Parameters.AddWithValue("dpAmount", dpAmount);


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

                    string sql = "UPDATE voucher SET voucher_from=@voucherFrom,voucher_amount=@voucherAmount,DP_amount =@dpAmount" +
                                    " WHERE id=@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", id);

                    cmd.Parameters.AddWithValue("voucherFrom", voucherFrom);
                    cmd.Parameters.AddWithValue("voucherAmount", voucherAmount);
                    cmd.Parameters.AddWithValue("dpAmount", dpAmount);


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

                    string sql = "DELETE  FROM voucher WHERE id=@id;";

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
