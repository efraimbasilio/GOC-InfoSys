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
    public partial class frmRegistration : Form
    {
        Registration registration = new Registration();

        Assesment assesment = new Assesment();
       
        List<Assesment> assements = new List<Assesment>();
        frmAssesment frmAssesment = new frmAssesment();

        public void LoadAutoGen()
        {
            //clear list           
            assements.Clear();  
                               
            //pass value to list
            assements = assesment.Load();
                  
            foreach (var item in assements)
            {
                if (assements.Count() < 1)
                {
                    txtRegno.Text = "REG-" + DateTime.Today.ToString("yyyy") + "-" + (item.Id + 1).ToString("0000");                  
                }
                else
                {                    
                    txtRegno.Text = "REG-" + DateTime.Today.ToString("yyyy") + "-" + (item.Id + 1).ToString("0000");
                }                                      
            }
        }//End LoadRecords() OK

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            registration.StudLRN = LRNtxt.Text;
            registration.StudRegistrationNo = txtRegno.Text;
            registration.StudLastName = txtLastName.Text;
            registration.StudMiddleName = txtMName.Text;
            registration.StudFirstName = txtFName.Text;

            registration.StudStrand = cmbCourseStrand.Text;
            registration.StudDateOfBirth = dtBirthday.Value.ToString("yyyy-MM-dd");
            registration.StudBirthPlace = txtBirthPlace.Text;
            registration.StudAddress1 = txtAddress.Text;
            registration.StudType = cmbStudType.Text;
            
            //function to load important filtering
            checkYearLevel();
            CheckTrack();
            checkRequirements();
            checkGender();

            //save the info to database
            registration.Save();

            //clear in assesment
            frmAssesment.Reset();
            assements.Clear();

            frmAssesment.RegNo = txtRegno.Text;
            frmAssesment.StudName = txtLastName.Text + " , " + txtFName.Text + " " + txtMName.Text;
            frmAssesment.LRN = LRNtxt.Text;
                       
            frmAssesment.LoadSection();
            frmAssesment.LoadSchoolYear();
            frmAssesment.LoadStrand();
            frmAssesment.RenderStudNo();



            this.Hide();
            frmAssesment.Show();


        }

        private void checkGender()
        {
            if (optMale.Checked)
            {
                registration.StudGender = optMale.Text;
            }

            else if (optFemale.Checked)
            {
                registration.StudGender = optFemale.Text;
            }
        }
        private void checkYearLevel()
        {
           if (opt1stYear.Checked)
            {
                registration.StudGradeLevel = opt1stYear.Text;
                frmAssesment.GradeLevel = opt1stYear.Text;
            }

            else if (opt2ndYear.Checked)
            {
                registration.StudGradeLevel = opt2ndYear.Text;
                frmAssesment.GradeLevel = opt1stYear.Text;
            }

            else if (opt3rdYear.Checked)
            {
                registration.StudGradeLevel = opt3rdYear.Text;
                frmAssesment.GradeLevel = opt1stYear.Text;
            }
            else if (opt4thYear.Checked)
            {
                registration.StudGradeLevel = opt4thYear.Text;
                frmAssesment.GradeLevel = opt1stYear.Text;
            }
        }

        private void CheckTrack()
        {
            if (optAcademic.Checked)
            {
                registration.StudAcadTrack = optAcademic.Text;
                frmAssesment.Track = optAcademic.Text;
            }

            else if (optTVL.Checked)
            {
                registration.StudAcadTrack = optTVL.Text;
                frmAssesment.Track = optAcademic.Text;
            }
        }

        private void checkRequirements()
        {
            if (chkEntranceExam.Checked)
            {
                registration.ReqAdmissionTest = chkEntranceExam.Text;
            }

            if (chkBirthCertificate.Checked)
            {
                registration.ReqPSA = chkBirthCertificate.Text;
            }

            if (chkDrugtest.Checked)
            {
                registration.ReqDrugTest = chkDrugtest.Text;
            }

            if (chk138.Checked)
            {
                registration.ReqForm138 = chk138.Text;
            }

            
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            LoadAutoGen();
                       
            opt1stYear.Text = "11";
            opt2ndYear.Text = "12";
            opt3rdYear.Visible = false;
            opt4thYear.Visible = false;
            cmbCourseStrand.Text = "";
            LoadCombo();            
        }

        void LoadCombo()
        {
            if (optTVL.Checked)
            {
      
                cmbCourseStrand.Items.Clear();
                cmbCourseStrand.Items.Add("TVL-ICT");
                cmbCourseStrand.Items.Add("TVL-HE");
            }
            else if(optAcademic.Checked)
            {
                
                cmbCourseStrand.Items.Clear();
                cmbCourseStrand.Items.Add("ABM");
                cmbCourseStrand.Items.Add("HUMSS");
                cmbCourseStrand.Items.Add("STEM");
                
            }
            else if(optCollege.Checked)
            {
                
                cmbCourseStrand.Items.Clear();
                cmbCourseStrand.Items.Add("BSHRM");
                cmbCourseStrand.Items.Add("BSA");
                cmbCourseStrand.Items.Add("BSRM");
            }                      
        }

        private void optTVL_CheckedChanged(object sender, EventArgs e)
        {
            opt1stYear.Text = "11";
            opt2ndYear.Text = "12";
            opt3rdYear.Visible = false;
            opt4thYear.Visible = false;
            cmbCourseStrand.Text = "";
            LoadCombo();
        }

        private void optAcademic_CheckedChanged(object sender, EventArgs e)
        {
            opt1stYear.Text = "11";
            opt2ndYear.Text = "12";
            opt3rdYear.Visible = false;
            opt4thYear.Visible = false;
            cmbCourseStrand.Text = "";
            LoadCombo();
        }

        private void optCollege_CheckedChanged(object sender, EventArgs e)
        {
            opt3rdYear.Visible = true;
            opt4thYear.Visible = true;
            opt1stYear.Text = "1";
            opt2ndYear.Text = "2";
            opt3rdYear.Text = "3";
            opt4thYear.Text = "4";
            cmbCourseStrand.Text = "";
            LoadCombo();
        }

        private void chkEntranceExam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmAssesment.Reset();
            frmAssesment.LoadSection();
            frmAssesment.LoadSchoolYear();
            frmAssesment.LoadStrand();
            frmAssesment.RenderStudNo();


            this.Hide();
            frmAssesment.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }
    }
}
