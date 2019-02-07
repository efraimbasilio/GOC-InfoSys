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

        public String theLRN;
        
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            registration.StudLRN = LRNtxt.Text;
            registration.StudRegistrationNo = mtxtRegnoMask.Text;
            registration.StudGOCNo = "";
            registration.StudLastName = txtLastName.Text;
            registration.StudMiddleName = txtMName.Text;
            registration.StudFirstName = txtFName.Text;

            registration.StudStrand = cmbCourseStrand.Text;
            registration.StudDateOfBirth = dtBirthday.Value.ToString("yyyy-MM-dd");
            registration.StudBirthPlace = txtBirthPlace.Text;
            registration.StudAddress1 = txtAddress.Text;
            registration.StudType = cmbStudType.Text;

            checkYearLevel();
            CheckTrack();
            checkRequirements();
            checkGender();

          
            registration.Save();
            this.Hide();

            frmAssesment frmAssesment1 = new frmAssesment();            
            assesment.StudLRN = registration.StudLRN;
            assesment.GetById();
            frmAssesment1.LoadRecords();
            frmAssesment1.LoadSection();
            frmAssesment1.LoadSchoolYear();
            frmAssesment1.LoadStrand();

            frmAssesment1.Show();           
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
            }

            else if (opt2ndYear.Checked)
            {
                registration.StudGradeLevel = opt2ndYear.Text;
            }

            else if (opt3rdYear.Checked)
            {
                registration.StudGradeLevel = opt3rdYear.Text;
            }
            else if (opt4thYear.Checked)
            {
                registration.StudGradeLevel = opt4thYear.Text;
            }
        }

        private void CheckTrack()
        {
            if (optAcademic.Checked)
            {
                registration.StudAcadTrack = optAcademic.Text;
            }

            else if (optTVL.Checked)
            {
                registration.StudAcadTrack = optTVL.Text;
            }
        }

        private void checkRequirements()
        {
            if (chkEntranceExam.Checked)
            {
                registration.ReqAdmissionTest = chkEntranceExam.Text;
            }
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            txtRegno.Text = "REG-" + DateTime.Today.ToString("yyyy")+"-";

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
            frmAssesment frmAssesment = new frmAssesment();
            frmAssesment.Reset();
            frmAssesment.LoadSection();
            frmAssesment.LoadSchoolYear();
            frmAssesment.LoadStrand();
            this.Hide();
            frmAssesment.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
