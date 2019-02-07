using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GOCSystem2018
{
    class Assesment
    {

        protected int ctrAssesment;
        protected int id;
        protected string studLRN;
        protected string studRegistrationNo;
        protected string studGOCNo;
        protected string studLastName;
        protected string studFirstName;
        protected string studMiddleName;
        protected string studGradeLevel;
        protected string studType;
        protected string studCourse;
        protected string studStrand;
        protected string studAcadTrack;
        protected string studSemEnroll;
        protected string studGWA;
        protected string studPrevSchool;

        protected string studPublicVoucher;
        protected string studPrivateVoucher;

        protected string reqPSA;
        protected string reqGoodMoral;
        protected string reqDrugTest;
        protected string reqAdmissionTest;
        protected string reqClassCard;
        protected string reqForm138;

        protected string studDateOfBirth;
        protected string studBirthPlace;
        protected string studGender;
        protected string studAddress1;
        protected string studAddress2;
        protected string studEmail;
        protected string studCivilStatus;

        protected string guardianName;
        protected string guardianContactNo;
        protected string guardianCompleteAddress;
        protected string guardianEmail;
        protected string relationshipToGuardian;


        public int CtrAssesment
        {
            get { return ctrAssesment; }
            set { ctrAssesment = value; }
        }

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
        public string StudAcadTrack
        {
            get { return studAcadTrack; }
            set { studAcadTrack = value; }
        }
        public string StudSemEnroll
        {
            get { return studSemEnroll; }
            set { studSemEnroll = value; }
        }
        public string StudBirthPlace
        {
            get { return studBirthPlace; }
            set { studBirthPlace = value; }
        }
        public string StudGWA
        {
            get { return studGWA; }
            set { studGWA = value; }
        }
        public string StudPrevSchool
        {
            get { return studPrevSchool; }
            set { studPrevSchool = value; }
        }

        public string StudPublicVoucher
        {
            get { return studPublicVoucher; }
            set { studPublicVoucher = value; }
        }
        public string StudPrivateVoucher
        {
            get { return studPrivateVoucher; }
            set { studPrivateVoucher = value; }
        }

        public string StudType
        {
            get { return studType; }
            set { studType = value; }
        }

        public string ReqPSA
        {
            get { return reqPSA; }
            set { reqPSA = value; }
        }

        public string ReqForm138
        {
            get { return reqForm138; }
            set { reqForm138 = value; }
        }
        public string ReqGoodMoral
        {
            get { return reqGoodMoral; }
            set { reqGoodMoral = value; }
        }
        public string ReqDrugTest
        {
            get { return reqDrugTest; }
            set { reqDrugTest = value; }
        }
        public string ReqAdmissionTest
        {
            get { return reqAdmissionTest; }
            set { reqAdmissionTest = value; }
        }
        public string ReqClassCard
        {
            get { return reqClassCard; }
            set { reqClassCard = value; }
        }

        public string StudDateOfBirth
        {
            get { return studDateOfBirth; }
            set { studDateOfBirth = value; }
        }
        public string StudGender
        {
            get { return studGender; }
            set { studGender = value; }
        }
        public string StudAddress1
        {
            get { return studAddress1; }
            set { studAddress1 = value; }
        }
        public string StudAddress
        {
            get { return studAddress2; }
            set { studAddress2 = value; }
        }
        public string StudEmail
        {
            get { return studEmail; }
            set { studEmail = value; }
        }

        public string StudCivilStatus
        {
            get { return studCivilStatus; }
            set { studCivilStatus = value; }
        }
        public string GuardianName
        {
            get { return guardianName; }
            set { guardianName = value; }
        }

        public string GuardianContactNo
        {
            get { return guardianContactNo; }
            set { guardianContactNo = value; }
        }

        public string GuardianCompleteAddress
        {
            get { return guardianCompleteAddress; }
            set { guardianCompleteAddress = value; }
        }
        public string GuardianEmail
        {
            get { return guardianEmail; }
            set { guardianEmail = value; }
        }

        public string RelationshipToGuardian
        {
            get { return relationshipToGuardian; }
            set { relationshipToGuardian = value; }
        }
        List<Assesment> assesments = new List<Assesment>();

        public void passValue()
        {
            Assesment assesment = new Assesment();
            assesments.Add(assesment);
        }

        public List<Assesment> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM stud_registration";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Assesment assesment = new Assesment();

                        //prepare properties
                        //assesment.id = Convert.ToInt32(reader["studLRN"].ToString());
                        assesment.studLRN = reader["stud_LRN"].ToString();
                        assesment.studLastName = reader["stud_lastName"].ToString();
                        assesment.studFirstName = reader["stud_firstName"].ToString();
                        assesment.studMiddleName = reader["stud_middleName"].ToString();
                        assesment.studAcadTrack = reader["stud_acad_track"].ToString();
                        assesment.studStrand = reader["stud_strand"].ToString();
                        assesment.studGradeLevel = reader["stud_grade_level"].ToString();
                        assesments.Add(assesment);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return assesments;
        }//End of Load


        public List<Assesment>GetById()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM stud_registration WHERE stud_LRN =@studLRN;";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("studLRN", studLRN);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Assesment assesment = new Assesment();

                        //prepare properties
                        //assesment.id = Convert.ToInt32(reader["id"].ToString());
                        assesment.studLRN = reader["stud_LRN"].ToString();
                       
                        assesments.Add(assesment);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return assesments;
        }

    }
}
