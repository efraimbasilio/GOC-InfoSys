using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOCSystem2018
{
    public partial class frmStudProf : Form
    {
        Billing_Partial billingPartial = new Billing_Partial();
        StudentProfile studProfile = new StudentProfile();


        List<StudentProfile> studProfiles = new List<StudentProfile>();
        List<Billing_Partial> billingPartials = new List<Billing_Partial>();

        frmRegistration frmReg = new frmRegistration();

        public string Student_Name,GOC_No,REG_No;

        public frmStudProf()
        {
            InitializeComponent();
        }

        
        public void PassToEdit()
        {
            //clear list
            studProfiles.Clear();
            //pass value
            studProfile.StudGOCNo = GOC_No;
            studProfiles = studProfile.GetByGOCNoToEdit();

            foreach (var item in studProfiles)
            {
                //pass variable to form Assesment
                frmReg.RegNo = item.StudRegistrationNo;
                frmReg.LRN = item.StudLRN;
                frmReg.VType = item.VoucherType;
                frmReg.StudType = item.StudType;
                frmReg.Track = item.Track;
                frmReg.Grade_Level = item.StudGradeLevel;
                frmReg.StrandCourse = item.StudStrand;
                frmReg.F_Name = item.StudFirstName;
                frmReg.M_Name = item.StudMiddleName;
                frmReg.L_Name = item.StudLastName;
                frmReg.Religion = item.Religion;
                frmReg.Nationality = item.Nationality;
                frmReg.Gender = item.StudGender;
                frmReg.Birthdate = item.StudDateOfBirth;
                frmReg.Place_of_birth = item.StudBirthPlace;

                //frmReg.House_No = item.StudAddress1;\

                frmReg.Cell_No = item.StudContactNo;
                frmReg.Tel_No = item.StudTelNo;
                frmReg.Last_School = item.StudPrevSchool;
                frmReg.School_Address = item.StudPrevSchoolAddress;

                frmReg.Father = item.FatherName;
                frmReg.F_Occupation = item.FatherWork;
                frmReg.Mother = item.MotherName;
                frmReg.M_Occupation = item.MotherWork;

                frmReg.Guardian = item.GuardianName;
                frmReg.G_CellNo = item.GuardianContactNo;
                frmReg.G_TelNo = item.GuardianTelNo;
                frmReg.G_Occupation = item.GuardianWork;
                frmReg.G_Relationship = item.GuardianRelationship;
                //frmReg.G_House_No = item.GuardianCompleteAddress;
                
                
                
                
                       


            }
            //frm.Render();
            //studProf.Show();
        }

        public void LoadPaymentHistory()
        {
            //clear list
            billingPartials.Clear();
            MessageBox.Show(REG_No);
            //pass value to list                    
            billingPartial.RegNo = REG_No;

            billingPartials = billingPartial.GetMonthlyDue();

            //loop through load it to list view
            foreach (var item in billingPartials)
            {
                string Month_1 = "June      ";
                string Month_2 = "July      ";
                string Month_3 = "August    ";
                string Month_4 = "September ";
                string Month_5 = "October   ";
                string Month_6 = "November  ";
                string Month_7 = "December  ";
                string Month_8 = "January   ";
                string Month_9 = "February  ";
                string Month_10 = "March   ";

                M1txt.Text = Month_1;
                M2txt.Text = Month_2;
                M3txt.Text = Month_3;
                M4txt.Text = Month_4;
                M5txt.Text = Month_5;
                M6txt.Text = Month_6;
                M7txt.Text = Month_7;
                M8txt.Text = Month_8;
                M9txt.Text = Month_9;
                M10txt.Text = Month_10;

                tp1txt.Text = item.P1;
                tp2txt.Text = item.P2;
                tp3txt.Text = item.P3;
                tp4txt.Text = item.P4;
                tp5txt.Text = item.P5;
                tp6txt.Text = item.P6;
                tp7txt.Text = item.P7;
                tp8txt.Text = item.P8;
                tp9txt.Text = item.P9;
                tp10txt.Text = item.P10;

            }
        }

        public void Render()
        {
            lblStudName.Text = Student_Name;
            txtRegNo.Text = REG_No;
            lblGOCNo.Text = GOC_No;

            LoadPaymentHistory();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmRegistration reg = new frmRegistration();
            this.Hide();
            this.Dispose();

            reg.ShowDialog();

        }


    }
}
