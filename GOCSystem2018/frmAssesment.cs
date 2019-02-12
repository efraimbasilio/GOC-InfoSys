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
    public partial class frmAssesment : Form
    {
        string a = "SPECIALIZED SUBJECTS";
        string b = "APPLIED SUBJECTS";
        string c = "CORE SUBJECTS";
        string allStrand = "All Strand";
        Assesment assesment = new Assesment();
        Registration registration = new Registration();
        Section section = new Section();
        Strand strand = new Strand();
        SchoolYear schoolYear = new SchoolYear();
        Subject subject = new Subject();

        List<Section> sections = new List<Section>();
        List<Strand> strands = new List<Strand>();
        List<Assesment> assesments = new List<Assesment>();
        List<SchoolYear> schoolYears = new List<SchoolYear>();

        List<Subject> subjects = new List<Subject>();


        public string StudName, LRN, Track, GradeLevel, RegNo;


        public frmAssesment()
        {
            InitializeComponent();
        }

        private void frmAssesment_Load(object sender, EventArgs e)
        {
            lblName.Text = StudName;
            lblGradeLevel.Text = GradeLevel;
            lblLRN.Text = LRN;
            lblTrack.Text = Track;
            lblRegNo.Text = RegNo;
        }

        private void Render()
        {
            lblLRN.Text = assesment.StudLRN;
        }
        public void LoadSchoolYear()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            cmbSchoolYear.Items.Clear();
            schoolYears.Clear();

            //pass value to list
            schoolYears = schoolYear.Load();

            //loop through load it to list view
            foreach (var item in schoolYears)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                string School;
                School = (item.YearStart + " - " + item.YearEnd);
                cmbSchoolYear.Items.Add(School);
            }
        }//End LoadRecords()

        public void LoadSection()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            cmbSection.Items.Clear();
            sections.Clear();

            //pass value to list
            sections = section.Load();

            //loop through load it to list view
            foreach (var item in sections)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                cmbSection.Items.Add(item.SectionName);
            }

        }//End LoadRecords()

        public void LoadStrand()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            cmbStrand.Items.Clear();
            strands.Clear();

            //pass value to list
            strands = strand.Load();

            //loop through load it to list view
            foreach (var item in strands)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                cmbStrand.Items.Add(item.StrandName);
            }
        }//End LoadRecords()

        public void LoadRecords2()
        {
            //clear list
            assesments.Clear();

            //pass value to list
            assesments = assesment.Load();

            //loop through load it to list view
            foreach (var item in assesments)
            {
                //Load to datagridView               
                lblLRN.Text = item.StudLRN;
                lblName.Text = item.StudLastName + ", " + item.StudFirstName + " " + item.StudMiddleName;
                lblGradeLevel.Text = item.StudGradeLevel;
                lblTrack.Text = item.StudAcadTrack;
            }
        }//End LoadRecords()//NO

        public void LoadSubjects()
        {
            //clear list
            cmbSchoolYear.Items.Clear();
            schoolYears.Clear();

            //pass value to list
            schoolYears = schoolYear.Load();

            //loop through load it to list view
            foreach (var item in schoolYears)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                string School;
                School = (item.YearStart + " - " + item.YearEnd);
                cmbSchoolYear.Items.Add(School);
            }
        }//End LoadRecords()

        public void RenderStudNo()
        {
            //clear list
            assesments.Clear();

            //pass value to list
            assesments = assesment.Load();

            //loop through load it to list view
            foreach (var item in assesments)
            {
                //Load to datagridView               
                lblGOCNo.Text = "GOC-" + DateTime.Today.ToString("yyyy") + "-" + (item.Id + 1).ToString("0000");
            }
        }

        private void frmAssesment_Load_1(object sender, EventArgs e)
        {

        }


        private void btnAsses_Click(object sender, EventArgs e)
        {
            //string a = "SPECIALIZED SUBJECTS";
            //string b = "APPLIED SUBJECTS";
            //string c = "CORE SUBJECTS";            
            //subjects.Clear();   

            //subject.SubjType = a;          
            //loop();

            subject.SubjType = b;
            ////subject.SubjStrand = allStrand;
            //loop();

            //subject.SubjType = c;
            ////subject.SubjStrand = allStrand;
            //loop();

            loop();
            
        }

        public void loop()
        {   
            subject.SubjGradeLevel = GradeLevel;
            subject.SubjSemester = cmbSemester.Text;
            subject.SubjStrand = cmbStrand.Text;

            subjects.Clear();
            dgvSubject.Rows.Clear();
            subjects = subject.GetSubjectById();

            foreach (var item in subjects)
            {
                //if (item.SubjStrand.Equals(cmbStrand.Text))
                //{
                //    //pass variable 
                //    dgvSubject.Rows.Add(item.SubjectCode, item.SubjectDesc);
                //}

                if (item.SubjType.Equals(b) && item.SubjStrand.Equals(allStrand))
                {
                    //pass variable 
                    dgvSubject.Rows.Add(item.SubjectCode, item.SubjectDesc);
                }

                //if (item.SubjType.Equals(a) && item.SubjStrand.Equals(cmbStrand.Text))
                //{
                //    //pass variable 
                //    dgvSubject.Rows.Add(item.SubjectCode, item.SubjectDesc);
                //}

            }
        }

        private void cmbStrand_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbStrand_SelectedValueChanged(object sender, EventArgs e)
        {
           // loop();
        }

        public void Reset()
        {
            txtSearhAssesment.Text = string.Empty;
            lblLRN.Text = string.Empty;
            lblName.Text = string.Empty;
            lblGradeLevel.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is Working
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            frmStudSearch frmStudSearch = new frmStudSearch();
            frmStudSearch.LoadRecords();

            frmStudSearch.Show();
            this.Dispose();
            

        }


        public void LoadRecordsWithRegno()
        {
            //clear list                      
            assesments.Clear();

            //pass value to list
            assesments = assesment.Load();

            //loop through load it to list view
            foreach (var item in assesments)
            {
                lblLRN.Text = item.StudRegistrationNo;
                lblName.Text = item.StudLastName + ", " + item.StudFirstName + " " + item.StudMiddleName;
                lblGradeLevel.Text = item.StudGradeLevel;
                lblTrack.Text = item.StudAcadTrack;

            }
        }
    }
}
