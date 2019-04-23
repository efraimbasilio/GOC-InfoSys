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

        #region StudentProfile
        protected int id;
        protected string photoLoc;//*
        protected string studLRN;
        protected string studRegistrationNo;
        protected string studGOCNo;

        protected string studLastName;
        protected string studFirstName;
        protected string studMiddleName;

        protected string studGradeLevel;
        protected string studAcadTrack;//ACADEMIC / TECHVOC
        protected string studType;//SHS or College
        protected string studCourse; //FOR College
        protected string studStrand;//ABM, STEM
        protected string studVoucher;//*OK
        protected string section;//*OK

        protected string studAddress1;
        protected string studDateOfBirth;
        protected string studBirthPlace;
        protected string religion;//*OK
        protected string nationality;//*OK
        protected string studGender;

        protected string studContactNo;//*
        protected string studTelNo;//*
        protected string studPrevSchool;
        protected string studPrevSchoolAddress;

        //Additional
        protected string fatherName;//*
        protected string motherName;//*
        protected string fatherWork;//*
        protected string motherWork;//*
        protected string guardianName;
        protected string guardianWork;//*
        protected string guardianRelationship;//*
        protected string guardianContactNo;//*ok
        protected string guardianCompleteAddress;
        protected string guardianTelNo;//*
        //REQ
        protected string reqPSA;
        protected string reqGoodMoral;
        protected string reqDrugTest;
        protected string reqForm138;
        protected string reqNCAE;//OK
        protected string dateEnrolled;//*
        protected string syEnrolled;//*

        //Billing
        protected string reservee;
        protected string reserveFor;
        protected string partialPayment;
        protected string fullPayment;

        public string Section
        {
            get { return section; }
            set { section = value; }
        }


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
        //public string PartialPayment
        //{
        //    get { return partialPayment; }
        //    set { partialPayment = value; }
        //}
        //public string FullPayment
        //{
        //    get { return fullPayment; }
        //    set { fullPayment = value; }
        //}

        protected string fatherContactNo;//*
        protected string motherContactNo;//*
        ///
        protected string guardianEmail;
        protected string relationshipToGuardian;
        protected string studSemEnroll;
        protected string studGWA;
        protected string studAddress2;
        protected string studPublicVoucher;
        protected string studPrivateVoucher;
        protected string reqAdmissionTest;
        protected string reqClassCard;
        protected string studEmail;
        protected string studCivilStatus;
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

        public string DateEnrolled
        {
            get { return dateEnrolled; }
            set { dateEnrolled = value; }
        }

        public string StudPrevSchool
        {
            get { return studPrevSchool; }
            set { studPrevSchool = value; }
        }

        public string StudPrevSchoolAddress
        {
            get { return studPrevSchoolAddress; }
            set { studPrevSchoolAddress = value; }
        }

        public string SYEnrolled
        {
            get { return syEnrolled; }
            set { syEnrolled = value; }
        }

        public string GuardianTelNo
        {
            get { return guardianTelNo; }
            set { guardianTelNo = value; }
        }

        public string GuardianWork
        {
            get { return guardianWork; }
            set { guardianWork = value; }
        }

        public string MotherWork
        {
            get { return motherWork; }
            set { motherWork = value; }
        }

        public string FatherWork
        {
            get { return fatherWork; }
            set { fatherWork = value; }
        }

        public string MotherName
        {
            get { return motherName; }
            set { motherName = value; }
        }

        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }

        public string GuardianRelationship
        {
            get { return guardianRelationship; }
            set { guardianRelationship = value; }
        }


        public string StudTelNo
        {
            get { return studTelNo; }
            set { studTelNo = value; }
        }


        public string StudContactNo
        {
            get { return studContactNo; }
            set { studContactNo = value; }
        }

        public string Religion
        {
            get { return religion; }
            set { religion = value; }
        }

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public string StudVoucher
        {
            get { return studVoucher; }
            set { studVoucher = value; }
        }

        public string ReqNCAE
        {
            get { return reqNCAE; }
            set { reqNCAE = value; }
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

        public string FatherContactNo
        {
            get { return fatherContactNo; }
            set { fatherContactNo = value; }
        }

        public string MotherContactNo
        {
            get { return motherContactNo; }
            set { motherContactNo = value; }
        }

        #endregion

        //protected int id;
        //protected string studLRN;
        //protected string studRegistrationNo;
        //protected string studGOCNo;
        //protected string studLastName;
        //protected string studFirstName;
        //protected string studMiddleName;
        //protected string studGradeLevel;
        protected string voucherType;
        //protected string studCourse;
        //protected string studStrand;
        protected string track;
        //protected string section;

        ////Billing
        //protected string reservee;
        //protected string reserveFor;
        //protected string partialPayment;
        //protected string fullPayment;

        //public string Section
        //{
        //    get { return section; }
        //    set { section = value; }
        //}

        //public string Reservee
        //{
        //    get { return reservee; }
        //    set { reservee = value; }
        //}

        //public string ReserveFor
        //{
        //    get { return reserveFor; }
        //    set { reserveFor = value; }
        //}
        public string PartialPayment
        {
            get { return partialPayment; }
            set { partialPayment = value; }
        }
        //public string FullPayment
        //{
        //    get { return fullPayment; }
        //    set { fullPayment = value; }
        //}

        ////FOR REGISTRATION

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //public string StudLRN
        //{
        //    get { return studLRN; }
        //    set { studLRN = value; }
        //}
        //public string StudRegistrationNo
        //{
        //    get { return studRegistrationNo; }
        //    set { studRegistrationNo = value; }
        //}

        //public string StudGOCNo
        //{
        //    get { return studGOCNo; }
        //    set { studGOCNo = value; }
        //}
        //public string StudLastName
        //{
        //    get { return studLastName; }
        //    set { studLastName = value; }
        //}

        //public string StudFirstName
        //{
        //    get { return studFirstName; }
        //    set { studFirstName = value; }
        //}
        //public string StudMiddleName
        //{
        //    get { return studMiddleName; }
        //    set { studMiddleName = value; }
        //}
        //public string StudGradeLevel
        //{
        //    get { return studGradeLevel; }
        //    set { studGradeLevel = value; }
        //}
        //public string StudCourse
        //{
        //    get { return studCourse; }
        //    set { studCourse = value; }
        //}
        //public string StudStrand
        //{
        //    get { return studStrand; }
        //    set { studStrand = value; }
        //}
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
                        StudentProfile SP = new StudentProfile();

                        //prepare properties
                        //prepare properties
                        SP.id = Convert.ToInt32(reader["id"].ToString());
                        SP.studGOCNo = reader["IDNo"].ToString();
                        SP.StudLRN = reader["LRN"].ToString();
                        SP.studRegistrationNo = reader["regNo"].ToString();
                        SP.reservee = reader["Reservee"].ToString();
                        SP.reserveFor = reader["Reserve_for"].ToString();
                        SP.fullPayment = reader["Full_payment"].ToString();
                        SP.partialPayment = reader["Partial_payment"].ToString();
                        SP.studLastName = reader["last_name"].ToString();
                        SP.studFirstName = reader["first_name"].ToString();
                        SP.studMiddleName = reader["middle_name"].ToString();
                        SP.studGradeLevel = reader["grade_Level"].ToString();

                        SP.section = reader["section"].ToString();
                        SP.track = reader["track"].ToString();
                        SP.studStrand = reader["strand"].ToString();
                        SP.voucherType = reader["voucher_type"].ToString();
                        SP.studAddress1 = reader["address"].ToString();
                        SP.studDateOfBirth = reader["date_of_birth"].ToString();
                        SP.religion = reader["religion"].ToString();
                        SP.nationality = reader["nationality"].ToString();
                        SP.studGender = reader["gender"].ToString();
                        SP.studContactNo = reader["stud_contactNo"].ToString();
                        SP.StudTelNo = reader["stud_telNo"].ToString();
                        SP.studPrevSchool = reader["prev_school"].ToString();
                        SP.studPrevSchoolAddress = reader["prev_school_address"].ToString();
                        SP.fatherName = reader["father_name"].ToString();
                        SP.fatherWork = reader["father_work"].ToString();
                        SP.studBirthPlace = reader["place_of_birth"].ToString();

                        SP.guardianName = reader["guardian_name"].ToString();
                        SP.guardianWork = reader["guardian_work"].ToString();
                        SP.guardianCompleteAddress = reader["guardian_address"].ToString();
                        SP.guardianRelationship = reader["guardian_relationship"].ToString();
                        SP.guardianContactNo = reader["guardian_contactNo"].ToString();
                        SP.guardianTelNo = reader["guardian_telNo"].ToString();

                        SP.reqPSA = reader["bc"].ToString();
                        SP.reqForm138 = reader["form138"].ToString();
                        SP.reqDrugTest = reader["drugtest"].ToString();
                        SP.reqGoodMoral = reader["good_moral"].ToString();
                        SP.reqAdmissionTest = reader["en_exam"].ToString();
                        SP.reqNCAE = reader["ncae"].ToString();
                        //SP.dateEnrolled = reader["date_enrolled"].ToString();
                        //SP.syEnrolled = reader["sy_enrolled"].ToString();

                        studentProfiles.Add(SP);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return studentProfiles;
        }

        public List<StudentProfile> GetByGOCNoToEdit()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM student_profile WHERE IDNo =@studGOCNo;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("studGOCNo", studGOCNo);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        StudentProfile SP = new StudentProfile();

                        //prepare properties
                        SP.id = Convert.ToInt32(reader["id"].ToString());
                        SP.studGOCNo = reader["IDNo"].ToString();
                        SP.StudLRN = reader["LRN"].ToString();
                        SP.studRegistrationNo = reader["regNo"].ToString();
                        //SP.reservee = reader["Reservee"].ToString();
                        //SP.reserveFor = reader["Reserve_for"].ToString();
                        //SP.fullPayment = reader["Full_payment"].ToString();
                        //SP.partialPayment = reader["Partial_payment"].ToString();
                        SP.studLastName = reader["last_name"].ToString();
                        SP.studFirstName = reader["first_name"].ToString();
                        SP.studMiddleName = reader["middle_name"].ToString();
                        SP.studGradeLevel = reader["grade_Level"].ToString();

                        SP.studAddress1 = reader["address"].ToString();

                        SP.section = reader["section"].ToString();
                        SP.track = reader["track"].ToString();
                        SP.studStrand = reader["strand"].ToString();
                        SP.voucherType = reader["voucher_type"].ToString();
                        SP.studAddress1 = reader["address"].ToString();
                        SP.studDateOfBirth = reader["date_of_birth"].ToString();
                        SP.religion = reader["religion"].ToString();
                        SP.nationality = reader["nationality"].ToString();
                        SP.studGender = reader["gender"].ToString();
                        SP.studContactNo = reader["stud_contactNo"].ToString();
                        SP.StudTelNo = reader["stud_telNo"].ToString();
                        SP.studPrevSchool = reader["prev_school"].ToString();
                        SP.studPrevSchoolAddress = reader["prev_school_address"].ToString();
                        SP.fatherName = reader["father_name"].ToString();
                        SP.fatherWork = reader["father_work"].ToString();

                        SP.guardianName = reader["guardian_name"].ToString();
                        SP.guardianWork = reader["guardian_work"].ToString();
                        SP.guardianCompleteAddress = reader["guardian_address"].ToString();
                        SP.guardianRelationship = reader["guardian_relationship"].ToString();
                        SP.guardianContactNo = reader["guardian_contactNo"].ToString();
                        SP.guardianTelNo = reader["guardian_telNo"].ToString();

                        SP.reqPSA = reader["bc"].ToString();
                        SP.reqForm138 = reader["form138"].ToString();
                        SP.reqDrugTest = reader["drugtest"].ToString();
                        SP.reqGoodMoral = reader["good_moral"].ToString();
                        SP.reqAdmissionTest = reader["en_exam"].ToString();
                        SP.reqNCAE = reader["ncae"].ToString();
                        //SP.dateEnrolled = reader["date_enrolled"].ToString();
                        //SP.syEnrolled = reader["sy_enrolled"].ToString();


                        studentProfiles.Add(SP);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return studentProfiles;
        }

        public List<StudentProfile> CheckGOCNo()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM student_profile WHERE regNo =@studRegistrationNo;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("studRegistrationNo", studRegistrationNo);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        StudentProfile studentProfile = new StudentProfile();
                        //prepare properties                        
                        studentProfile.studGOCNo = reader["IDNo"].ToString();                       
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

                    string sql = "UPDATE student_profile SET reservee=@reservee, reserve_for=@reserveFor" +
                                    " WHERE regno=@studRegistrationNo;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("studRegistrationNo", studRegistrationNo);
                    cmd.Parameters.AddWithValue("reservee", reservee);
                    cmd.Parameters.AddWithValue("reserveFor", reserveFor);
                    
                    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void PartialOnly()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE student_profile SET partial_Payment=@partialPayment" +
                                    " WHERE regno=@studRegistrationNo;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("studRegistrationNo", studRegistrationNo);
                    cmd.Parameters.AddWithValue("partialPayment", partialPayment);
                    //cmd.Parameters.AddWithValue("reserveFor", reserveFor);


                    cmd.ExecuteNonQuery();

                //    MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void UpdateTheSection()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE student_profile SET  section=@section" +
                                    " WHERE regno=@studRegistrationNo;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("studRegistrationNo", studRegistrationNo);
                    cmd.Parameters.AddWithValue("section", section);



                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void UpdateMOP()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE student_profile SET  partial_Payment=@partialPayment, full_Payment=@fullPayment" +
                                    " WHERE regno=@studRegistrationNo;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("studRegistrationNo", studRegistrationNo);                    
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

        //public void UpdateSection()
        //{
        //    try
        //    {
        //        //prepare connection string 
        //        using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
        //        {

        //            //try to open connection
        //            con.Open();

        //            string sql = "UPDATE student_profile SET section=@section" +
        //                            "WHERE regno=@studRegistrationNo;";

        //            MySqlCommand cmd = new MySqlCommand(sql, con);
        //            MessageBox.Show("section ----------- sectioning module2" );
        //            cmd.Parameters.AddWithValue("studRegistrationNo", studRegistrationNo);
        //            //MessageBox.Show(section);
        //            cmd.Parameters.AddWithValue("section", section);
        //            //cmd.Parameters.AddWithValue("reserveFor", reserveFor);


        //            cmd.ExecuteNonQuery();

        //            MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //}

        public List<StudentProfile> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM student_profile";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        StudentProfile SP = new StudentProfile();

                        //prepare properties
                        SP.id = Convert.ToInt32(reader["id"].ToString());
                        SP.studGOCNo = reader["IDNo"].ToString();
                        SP.StudLRN = reader["LRN"].ToString();
                        SP.studRegistrationNo = reader["regNo"].ToString();
                        //SP.reservee = reader["Reservee"].ToString();
                        //SP.reserveFor = reader["Reserve_for"].ToString();
                        //SP.fullPayment = reader["Full_payment"].ToString();
                        //SP.partialPayment = reader["Partial_payment"].ToString();
                        SP.studLastName = reader["last_name"].ToString();
                        SP.studFirstName = reader["first_name"].ToString();
                        SP.studMiddleName = reader["middle_name"].ToString();
                        SP.studGradeLevel = reader["grade_Level"].ToString();
                        SP.section = reader["section"].ToString();
                        SP.track = reader["track"].ToString();
                        SP.studStrand = reader["strand"].ToString();
                        SP.voucherType = reader["voucher_type"].ToString();
                        SP.studAddress1 = reader["address"].ToString();
                        SP.studDateOfBirth = reader["date_of_birth"].ToString();
                        SP.religion = reader["religion"].ToString();
                        SP.nationality = reader["nationality"].ToString();
                        SP.studGender = reader["gender"].ToString();
                        SP.studContactNo = reader["stud_contactNo"].ToString();
                        SP.StudTelNo = reader["stud_telNo"].ToString();
                        SP.studPrevSchool = reader["prev_school"].ToString();
                        SP.studPrevSchoolAddress = reader["prev_school_address"].ToString();
                        SP.fatherName = reader["father_name"].ToString();
                        SP.fatherWork = reader["father_work"].ToString();

                        SP.guardianName = reader["guardian_name"].ToString();
                        SP.guardianWork = reader["guardian_work"].ToString();
                        SP.guardianCompleteAddress = reader["guardian_address"].ToString();
                        SP.guardianRelationship = reader["guardian_relationship"].ToString();
                        SP.guardianContactNo = reader["guardian_contactNo"].ToString();
                        SP.guardianTelNo = reader["guardian_telNo"].ToString();

                        SP.reqPSA = reader["bc"].ToString();
                        SP.reqForm138 = reader["form138"].ToString();
                        SP.reqDrugTest = reader["drugtest"].ToString();
                        SP.reqGoodMoral = reader["good_moral"].ToString();
                        SP.reqAdmissionTest = reader["en_exam"].ToString();
                        SP.reqNCAE = reader["ncae"].ToString();
                        //SP.dateEnrolled = reader["date_enrolled"].ToString();
                        //SP.syEnrolled = reader["sy_enrolled"].ToString();

                        //add object to list
                        studentProfiles.Add(SP);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return studentProfiles;
        }//End of Load

        public void SaveGOCNumber()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE student_profile SET IdNo=@studGOCNo, reservee=@reservee , partial_Payment=@partialPayment" +
                                    " WHERE regno=@studRegistrationNo;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("studRegistrationNo", studRegistrationNo);
                    cmd.Parameters.AddWithValue("studGOCNo", studGOCNo);
                    cmd.Parameters.AddWithValue("reservee",reservee);
                    cmd.Parameters.AddWithValue("partialPayment", partialPayment);



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
