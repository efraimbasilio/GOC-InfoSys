using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class Department
    {
        protected int id;
        protected string deptName;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }

        List<Department> depts = new List<Department>();

        public List<Department> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();


                    string sql = "SELECT * FROM department";
                    
                    
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Department dept = new Department();

                        //prepare properties
                        dept.id = Convert.ToInt32(reader["id"].ToString());
                        dept.deptName = reader["Department_Name"].ToString();

                        depts.Add(dept);

                        
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return depts;

        }//End of Load

    }
}
