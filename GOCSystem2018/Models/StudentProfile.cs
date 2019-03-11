using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace GOCSystem2018
{
    class StudentProfile
    {
        protected int id;
        protected string studLRN;
        protected string studRegistrationNo;
        protected string studGOCNo;
        protected string studLastName;
        protected string studFirstName;
        protected string studMiddleName;
        protected string studGradeLevel;
        protected string voucherType;
        protected string studCourse;
        protected string studStrand;
        protected string track;

        //Billing
        protected string reservee;
        protected string reserveFor;
        protected string partialPayment;
        protected string fullPayment;

        public string Reservee
        {
            get { return reservee; }
            set { reservee = value; }
        }

        public string ReserveFor
        {
            get { return reserveFor; }
            set { reserveFor = value; }
        }
        public string PartialPayment
        {
            get { return partialPayment; }
            set { partialPayment = value; }
        }
        public string FullPayment
        {
            get { return fullPayment; }
            set { fullPayment = value; }
        }

        //FOR REGISTRATION

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string StudLRN
        {
            get { return studLRN; }
            set { studLRN = value; }
        }
        public string StudRegistrationNo
        {
            get { return studRegistrationNo; }
            set { studRegistrationNo = value; }
        }

        public string StudGOCNo
        {
            get { return studGOCNo; }
            set { studGOCNo = value; }
        }
        public string StudLastName
        {
            get { return studLastName; }
            set { studLastName = value; }
        }

        public string StudFirstName
        {
            get { return studFirstName; }
            set { studFirstName = value; }
        }
        public string StudMiddleName
        {
            get { return studMiddleName; }
            set { studMiddleName = value; }
        }
        public string StudGradeLevel
        {
            get { return studGradeLevel; }
            set { studGradeLevel = value; }
        }
        public string StudCourse
        {
            get { return studCourse; }
            set { studCourse = value; }
        }
        public string StudStrand
        {
            get { return studStrand; }
            set { studStrand = value; }
        }
        public string VoucherType
        {
            get { return voucherType; }
            set { voucherType = value; }
        }

        public string Track
        {
            get { return track; }
            set { track = value; }
        }

        List<StudentProfile> studentProfiles = new List<StudentProfile>();


        public List<StudentProfile> GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM student_profile WHERE id =@id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        StudentProfile studentProfile = new StudentProfile();

                        //prepare properties
                        studentProfile.id = Convert.ToInt32(reader["id"].ToString());
                        studentProfile.studLRN = reader["LRN"].ToString();
                        studentProfile.studGOCNo = reader["IDNo"].ToString();
                        studentProfile.studRegistrationNo = reader["regNo"].ToString();
                        studentProfile.studLastName = reader["last_name"].ToString();
                        studentProfile.studFirstName = reader["first_name"].ToString();
                        studentProfile.studMiddleName = reader["middle_name"].ToString();
                        studentProfile.studGradeLevel = reader["grade_level"].ToString();
                        studentProfile.voucherType = reader["voucher_type"].ToString();
                        studentProfile.studStrand = reader["strand"].ToString();
                        studentProfile.track = reader["track"].ToString();

                        studentProfile.reservee = reader["reservee"].ToString();
                        studentProfile.reserveFor = reader["reserve_for"].ToString();
                        studentProfile.partialPayment = reader["partial_payment"].ToString();
                        studentProfile.fullPayment = reader["full_payment"].ToString();
                        //studentProfile.studCourse = reader["stud_course"].ToString();

                        studentProfiles.Add(studentProfile);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return studentProfiles;
        }

        public void ReserveOnly()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE student_profile SET reservee=@reservee, reserve_for=@reserveFor, partial_Payment=@partialPayment, full_Payment=@fullPayment" +
                                    " WHERE regno=@studRegistrationNo;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("studRegistrationNo", studRegistrationNo);
                    cmd.Parameters.AddWithValue("reservee", reservee);
                    cmd.Parameters.AddWithValue("reserveFor", reserveFor);
                    cmd.Parameters.AddWithValue("partialPayment", partialPayment);
                    cmd.Parameters.AddWithValue("fullPayment", fullPayment);
                    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
