using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace GOCSystem2018
{
    public partial class frmAssesment : Form
    {
        string a = "SPECIALIZED SUBJECTS";
        string b = "APPLIED SUBJECTS";
        string c = "CORE SUBJECTS";
        string allStrand = "All Strand";

        //Reports
        
        rptAssesment cr = new rptAssesment();

        Assesment assesment = new Assesment();
        Registration registration = new Registration();
        Section section = new Section();
        Strand strand = new Strand();
        SchoolYear schoolYear = new SchoolYear();
        Subject subject = new Subject();
        Schedule schedule = new Schedule();
        Models.TuitionFee tuitionFee = new Models.TuitionFee();
        MiscFee miscfee = new MiscFee();

        List<Models.TuitionFee> tuitionFees = new List<Models.TuitionFee>();
        List<Section> sections = new List<Section>();
        List<Strand> strands = new List<Strand>();
        List<Assesment> assesments = new List<Assesment>();
        List<SchoolYear> schoolYears = new List<SchoolYear>();
        List<Subject> subjects = new List<Subject>();
        List<Schedule> schedules = new List<Schedule>();
        List<MiscFee> miscFees = new List<MiscFee>();


        public string StudName, LRN, Track, GradeLevel, RegNo, Strand;


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
            lblStrand.Text = Strand;
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

        /// <summary>
        /// Working but need improvement
        /// </summary>
        public void LoadSchedule()
        {
            //clear list

            schedules.Clear();

            //pass value to list
            schedules = schedule.Load();

            //loop through load it to list view
            foreach (var item in schedules)
            {
                //Load to datagridView
                dgvSchedule.Rows.Add(item.TimeStart, item.TimeEnd, item.Day1, item.Day2, item.Day3, item.Day4, item.Day5);
            }//End LoadSchedule()
        }
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
            subject.SubjType = b;           
            loop();     
        }
        private void Schedule_loop()
        {
            schedules.Clear();
            dgvSchedule.Rows.Clear();
            schedules = schedule.GetScheduleById();

            foreach (var item in schedules)
            {
                if (item.Section.Equals(cmbSection.Text))
                {
                    dgvSchedule.Rows.Add(item.TimeStart, item.TimeEnd, item.Day1, item.Day2, item.Day3, item.Day4, item.Day5, item.Section);
                }
            }
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
                if (item.SubjType.Equals(b) && item.SubjStrand.Equals(allStrand))
                {
                    //pass variable 
                    dgvSubject.Rows.Add(item.SubjectCode, item.SubjectDesc);
                }
            }

            foreach (var item in subjects)
            {
                if (item.SubjType.Equals(a) && item.SubjStrand.Equals(cmbStrand.Text))
                {
                    //pass variable 
                    dgvSubject.Rows.Add(item.SubjectCode, item.SubjectDesc);
                }
            }

            foreach (var item in subjects)
            {
                if (item.SubjType.Equals(c) && item.SubjStrand.Equals(allStrand))
                {
                    //pass variable 
                    dgvSubject.Rows.Add(item.SubjectCode, item.SubjectDesc);
                }
            }
        }
        public void loop2()
        {
            subject.SubjGradeLevel = GradeLevel;
            subject.SubjSemester = cmbSemester.Text;
            subject.SubjStrand = cmbStrand.Text;

            subjects.Clear();
            dgvSubject.Rows.Clear();
            subjects = subject.GetSubjectById();

            //foreach (var item in subjects)
            //{
            //    if (item.SubjType.Equals(b) && item.SubjStrand.Equals(allStrand))
            //    {
            //        pass variable
            //        dgvSubject.Rows.Add(item.SubjectCode, item.SubjectDesc);
            //    }
            //}

            foreach (var item in subjects)
            {
                if (item.SubjType.Equals(a) && item.SubjStrand.Equals(cmbStrand.Text))
                {
                    //pass variable 
                    dgvSubject.Rows.Add(item.SubjectCode, item.SubjectDesc);
                }
            }
        }

        private void cmbStrand_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbStrand_SelectedValueChanged(object sender, EventArgs e)
        {
           // loop();
        }

        /// <summary>
        /// Working - Ready to filer by Section // for Printing Code
        /// </summary>
        private void scheduleMain()
        {
            TextObject Start = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Start"];
            TextObject End = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["End"];
            TextObject Mon = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Mon"];
            TextObject Tue = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Tue"];
            TextObject Wed = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Wed"];
            TextObject Thur = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Thur"];
            TextObject Fri = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Fri"];
           
            schedules.Clear();
            dgvSchedule.Rows.Clear();
            schedules = schedule.GetScheduleById();
          
            foreach (var item in schedules)
            {
                if (item.Section.Equals(cmbSection.Text))
                {
                    Start.Text = Start.Text + "\n\n" + item.TimeStart;
                    End.Text = End.Text + "\n\n" + item.TimeEnd;
                    Mon.Text = Mon.Text + "\n\n" + item.Day1;
                    Tue.Text = Tue.Text + "\n\n" + item.Day2;
                    Wed.Text = Wed.Text + "\n\n" + item.Day3;
                    Thur.Text = Thur.Text + "\n\n" + item.Day4;
                    Fri.Text = Fri.Text + "\n\n" + item.Day5;
                }
            }
        }

        private void tuitionFees2()
        {
            tuitionFees.Clear();
            txtTuitionFee.Clear();
            tuitionFee.TuitionFeeName = cmbStrand.Text;

           
            tuitionFees = tuitionFee.GetTuitionFeeById();

            foreach (var item in tuitionFees)
            {
                if (item.TuitionFeeName.Equals(cmbStrand.Text))
                {
                    txtTuitionFee.Text = item.TuitionFeeAmount;
                }               
            }
        }
   
        private void tuitionFeeReport()
        {
            TextObject tuitionFeeRpt = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtTuitionFee"];

            tuitionFees.Clear();
            txtTuitionFee.Clear();
            tuitionFees = tuitionFee.GetTuitionFeeById();

            foreach (var item in tuitionFees)
            {
                if (item.TuitionFeeName.Equals(cmbStrand.Text))
                {
                    tuitionFeeRpt.Text = tuitionFeeRpt.Text + item.TuitionFeeAmount;
                }
            }
        }

        private void miscFeeReport()
        {
            //TextObject miscFeeRpt = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtMiscFee"];
            //TextObject miscDescRpt = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtDesc"];

            //miscFees.Clear();
            ////txtTuitionFee.Clear();
            //miscFees = miscfee.GetMiscFeeById();

            //foreach (var item in miscFees)
            //{
            //    miscDescRpt.Text = miscDescRpt.Text +"\n"+ item.MiscFeeName;
            //    miscFeeRpt.Text = miscFeeRpt.Text +"\n\n"+ item.MiscFeeAmount;
            //}
        }
        
        private void StudInfoRpt()
        {
            TextObject SY = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtSchoolYear"];
            TextObject GOCNo = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtGOCNo"];
            TextObject Strand = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtStrand"];
            TextObject Semester = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtSemester"];
            TextObject StudName = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtStudName"];
            TextObject GradeLevel = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtGradeLevel"];
            TextObject Section = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtSection"];

            SY.Text = lblSY.Text;
            GOCNo.Text = lblGOCNo.Text;
            Strand.Text = lblTrack.Text;
            Semester.Text = lblSem.Text;
            StudName.Text = lblName.Text;
            GradeLevel.Text = lblGradeLevel.Text;
            Section.Text = cmbSection.Text;            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmReports rpt = new frmReports();

            schedules.Clear();
            dgvSchedule.Rows.Clear();
            schedules = schedule.GetScheduleById();

            foreach (var item in schedules)
            {
                rpt.Room = item.Section;
                if (item.Section.Equals(cmbSection.Text))
                {
                    rpt.Start = rpt.Start + "\n\n" + item.TimeStart;
                    rpt.End = rpt.End + "\n\n" + item.TimeEnd;
                    rpt.Mon = rpt.Mon + "\n\n" + item.Day1;
                    rpt.Tue = rpt.Tue + "\n\n" + item.Day2;
                    rpt.Wed = rpt.Wed + "\n\n" + item.Day3;
                    rpt.Thur = rpt.Thur + "\n\n" + item.Day4;
                    rpt.Fri = rpt.Fri + "\n\n" + item.Day5;
                }
            }

            rpt.studName = lblName.Text;
            rpt.SY = lblSY.Text;
            rpt.GOCNO = lblGOCNo.Text;
            rpt.Strand = lblTrack.Text;
            rpt.StudName = lblName.Text;
            rpt.GradeLevel = lblGradeLevel.Text;
            rpt.Section = cmbSection.Text;
            rpt.Semester = lblSem.Text;
            rpt.Tuition = Convert.ToDouble(txtTuitionFee.Text);

            rpt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Parameter.TheID = textBox1.Text;
            frmReports frmReports = new frmReports();
            frmReports.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Schedule_loop();
            tuitionFees2();
           
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

