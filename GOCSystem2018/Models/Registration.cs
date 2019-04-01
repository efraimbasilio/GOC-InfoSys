using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GOCSystem2018
{
    class Registration
    {
        /******************************
         * Protected Properties
         * ***************************/

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

        /// <summary>
        /// For Senior High School Registration
        /// </summary>
        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO student_profile(IDNo,LRN,regNo,last_name,middle_name,first_name,grade_Level,strand,track,voucher_type,address,date_of_birth,place_of_birth,religion,nationality,gender,stud_contactNo,stud_telNo,prev_school,prev_school_address,father_name,mother_name,mother_work,father_work,guardian_name,guardian_work,guardian_address,guardian_relationship,guardian_contactNo,guardian_telNo,bc,form138,drugtest,good_moral,en_exam,ncae,date_enrolled,sy_enrolled,reservee,reserve_for,partial_Payment,full_Payment,section) " +
                                 "VALUES (@studGOCNo,@studLRN,@studRegistrationNo,@studLastName,@studMiddleName,@studFirstName,@studGradeLevel, @studStrand, @studAcadTrack, @studVoucher, @studAddress1, @studDateOfBirth,@studBirthPlace, @religion, @nationality, @studGender, @studContactNo, @studTelNo, @studPrevSchool, @studPrevSchoolAddress, @fatherName,@motherName, @motherWork, @fatherWork, @guardianName, @guardianWork, @guardianCompleteAddress, @guardianRelationship,@guardianContactNo,@guardianTelNo,@reqPSA, @reqForm138, @reqDrugTest,@reqAdmissionTest,@reqNCAE,@reqGoodMoral,@dateEnrolled,@syEnrolled,@reservee,@reserveFor,@partialPayment,@fullPayment,@section); ";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    //reservee,reserve_for,partial_Payment,full_Payment
                    //,@reservee,@reserveFor,@partialPayment,@fullPayment

                    //Billing
                    cmd.Parameters.AddWithValue("reservee", reservee);
                    cmd.Parameters.AddWithValue("reserveFor", reserveFor);
                    cmd.Parameters.AddWithValue("partialPayment", partialPayment);
                    cmd.Parameters.AddWithValue("fullPayment", fullPayment);
                    //Registration
                    cmd.Parameters.AddWithValue("studRegistrationNo", studRegistrationNo);
                    cmd.Parameters.AddWithValue("studGOCNo", studGOCNo);
                    cmd.Parameters.AddWithValue("studLRN", studLRN);

                    cmd.Parameters.AddWithValue("studLastName", studLastName);
                    cmd.Parameters.AddWithValue("studMiddleName", studMiddleName);
                    cmd.Parameters.AddWithValue("studFirstName", studFirstName);

                    cmd.Parameters.AddWithValue("studGradeLevel", studGradeLevel);
                    cmd.Parameters.AddWithValue("studStrand", studStrand);
                    cmd.Parameters.AddWithValue("studAcadTrack", studAcadTrack);
                    cmd.Parameters.AddWithValue("studVoucher", studVoucher);
                    cmd.Parameters.AddWithValue("studAddress1", studAddress1);
                    cmd.Parameters.AddWithValue("studDateOfBirth", studDateOfBirth);

                    cmd.Parameters.AddWithValue("section", section);

                    cmd.Parameters.AddWithValue("studBirthPlace", studBirthPlace);
                    cmd.Parameters.AddWithValue("religion", religion);
                    cmd.Parameters.AddWithValue("nationality", nationality);
                    cmd.Parameters.AddWithValue("studGender", studGender);
                    cmd.Parameters.AddWithValue("studContactNo", studContactNo);

                    cmd.Parameters.AddWithValue("studTelNo", studTelNo);
                    cmd.Parameters.AddWithValue("studPrevSchool", studPrevSchool);
                    cmd.Parameters.AddWithValue("studPrevSchoolAddress", studPrevSchoolAddress);
                    cmd.Parameters.AddWithValue("fatherName", fatherName);
                    cmd.Parameters.AddWithValue("motherName", motherName);
                    cmd.Parameters.AddWithValue("motherWork", motherWork);
                    cmd.Parameters.AddWithValue("fatherWork", fatherWork);

                    cmd.Parameters.AddWithValue("guardianName", guardianName);
                    cmd.Parameters.AddWithValue("guardianWork", guardianWork);
                    cmd.Parameters.AddWithValue("guardianCompleteAddress", guardianCompleteAddress);
                    cmd.Parameters.AddWithValue("guardianRelationship", guardianRelationship);
                    cmd.Parameters.AddWithValue("guardianContactNo", guardianContactNo);
                    cmd.Parameters.AddWithValue("guardianTelNo", guardianTelNo);

                    cmd.Parameters.AddWithValue("reqPSA", reqPSA);
                    cmd.Parameters.AddWithValue("reqForm138", reqForm138);
                    cmd.Parameters.AddWithValue("reqDrugTest", reqDrugTest);
                    cmd.Parameters.AddWithValue("reqGoodMoral", reqGoodMoral);
                    cmd.Parameters.AddWithValue("reqAdmissionTest", reqAdmissionTest);
                    cmd.Parameters.AddWithValue("reqNCAE", reqNCAE);

                    cmd.Parameters.AddWithValue("dateEnrolled", dateEnrolled);
                    cmd.Parameters.AddWithValue("syEnrolled", syEnrolled);

                    

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        /**************************************************************************************************************/
        //For Billing Status

        /**************************************************************************************************************/





    }
}
