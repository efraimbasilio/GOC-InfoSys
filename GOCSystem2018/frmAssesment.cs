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
        string specialized = "SPECIALIZED SUBJECTS";
        string applied = "APPLIED SUBJECTS";
        string core = "CORE SUBJECTS";
        string allStrand = "All Strand";

        //Reports
        frmReports rpt = new frmReports();
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
        OtherFee otherFee = new OtherFee();
        Voucher voucher = new Voucher();
        

        List<Models.TuitionFee> tuitionFees = new List<Models.TuitionFee>();
        List<Section> sections = new List<Section>();
        List<Strand> strands = new List<Strand>();
        List<Assesment> assesments = new List<Assesment>();
        List<SchoolYear> schoolYears = new List<SchoolYear>();
        List<Subject> subjects = new List<Subject>();
        List<Schedule> schedules = new List<Schedule>();
        List<MiscFee> miscFees = new List<MiscFee>();
        List<OtherFee> otherFees = new List<OtherFee>();
        List<Voucher> vouchers = new List<Voucher>();

        public string StudName, LRN, Track, GradeLevel, RegNo, Strand,Voucher;


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
            lblVoucher.Text = Voucher;

            LoadAssesMiscFees();
            Downpayment();
            LoadAssesOtherFees();
            
           
            LoadTuitionFee();
            TotalTuition();


        }
        public void ComputeVoucher()
        {
            //clear list
            vouchers.Clear();
            //pass value to list
            vouchers = voucher.Load();

            //loop through load it to list view
            foreach (var item in vouchers)
            {
                if (item.VoucherFrom.Equals(Voucher))
                {
                    double b=
                    b = Convert.ToDouble(item.VoucherAmount);
                    lblDP.Text = b.ToString("n");
                }
            }
        }//End LoadRecords

        public void LoadTuitionFee()
        {
            //clear list
            tuitionFees.Clear();
            //pass value to list
            tuitionFees = tuitionFee.Load();

            //loop through load it to list view
            foreach (var item in tuitionFees)
            {
                if (item.Status.Equals("1"))
                {
                    double a;
                     a = Convert.ToDouble(item.TuitionFeeAmount);
                    lblTuition.Text = a.ToString("n");
                }
            }
        }//End LoadRecords

        private void TotalTuition()
        {
            double total = Convert.ToDouble(lblTuition.Text) + Convert.ToDouble(lblOther.Text) + Convert.ToDouble(lblTotalMiscFee.Text);
            lbl.Text = total.ToString("n");
        }

        public void LoadAssesMiscFees()
        {
            //clear list                      
            miscFees.Clear();
            dgvSubjectLoad.Rows.Clear();
            //pass value to list
            miscFees = miscfee.Load();

            //loop through load it to list view
            foreach (var item in miscFees)
            {
                // int a = Convert.ToInt16(item.MiscFeeAmount);
                dgvSubjectLoad.Rows.Add(item.MiscFeeName, item.MiscFeeAmount);
                // dgvSubjectLoad.Rows.Add(item.MiscFeeName, a);
                //Convert.ToInt32(dgvSubjectLoad.Rows[i].Cells[1].Value);
            }

            double sum1 = 0;
            for (int i = 0; i < dgvSubjectLoad.Rows.Count; i++)
            {
                sum1 += Convert.ToDouble(dgvSubjectLoad.Rows[i].Cells[1].Value);
            }

            lblTotalMiscFee.Text = sum1.ToString("n");
            
        }

        public void LoadAssesOtherFees()
        {
            //clear list                      
            otherFees.Clear();
            dgvOtherFee.Rows.Clear();
            //pass value to list
            otherFees = otherFee.Load();

            //loop through load it to list view
            foreach (var item in otherFees)
            {
                if (item.Strand.Equals(Strand))
                {
                    dgvOtherFee.Rows.Add(item.OtherFeeName, item.OtherFeeAmount);

                    foreach (var item2 in otherFees)
                    {
                        if (item.Strand.Equals("Non-STEM"))
                        {
                            dgvOtherFee.Rows.Add(item2.OtherFeeName, item2.OtherFeeAmount);
                        }
                    }
                }

                if (item.Strand.Equals("Non-STEM"))
                {
                    dgvOtherFee.Rows.Add(item.OtherFeeName, item.OtherFeeAmount);
                }
            }

            double sum = 0;
            for (int i = 0; i < dgvOtherFee.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvOtherFee.Rows[i].Cells[1].Value);
            }
            lblOther.Text = sum.ToString("n");           
        }

        
        public void Downpayment()
        {
            //50000 pub
            //30000 pri
            //10000 non
            //Public Voucher
            //Private Voucher
            //Non Voucher

            
        }
               
        private void Render()
        {
            lblLRN.Text = assesment.StudLRN;
        }
        public void LoadSchoolYear()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            //cmbSchoolYear.Items.Clear();
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
                lblSY.Text = School;
                //cmbSchoolYear.Items.Add(School);
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

        public void LoadSubject()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            //cmbSection.Items.Clear();
            subjects.Clear();

            //pass value to list
            subjects = subject.Load();

            //loop through load it to list view
            foreach (var item in subjects)
            {
                //Load to datagridView
                dgvSubject.Rows.Add(item.Id, item.SubjectCode, item.SubjectDesc);
            }

            foreach (var item in subjects)
            {
                if (item.SubjType.Equals(core) && item.SubjSemester.Equals(lblSubjSemester.Text))
                {
                    //Load to datagridView
                    dgvSubject.Rows.Add(item.Id, item.SubjectCode, item.SubjectDesc);
                }
                
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
            //loop();     
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

        private void tuitionFeeReport()
        {
            TextObject tuitionFeeRpt = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtTuitionFee"];

            tuitionFees.Clear();
            txtTuitionFee.Clear();
            tuitionFees = tuitionFee.GetTuitionFeeById();

            foreach (var item in tuitionFees)
            {
                if (item.TuitionFeeName.Equals(lblStrand.Text))
                {
                    tuitionFeeRpt.Text = tuitionFeeRpt.Text + item.TuitionFeeAmount;
                }
            }
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
            Schedule_loop();
            //tuitionFees2();

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


            //TextObject SY = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtSchoolYear"];
            //TextObject GOCNo = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtGOCNo"];
            //TextObject Strand = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtStrand"];
            //TextObject Semester = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtSemester"];
            //TextObject StudName = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtStudName"];
            //TextObject GradeLevel = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtGradeLevel"];
            //TextObject Section = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["txtSection"];

            //SY.Text = lblSY.Text;
            //GOCNo.Text = lblGOCNo.Text;
            //Strand.Text = lblTrack.Text;
            //Semester.Text = lblSem.Text;
            //StudName.Text = lblName.Text;
            //GradeLevel.Text = lblGradeLevel.Text;
            //Section.Text = cmbSection.Text;


            



            rpt.studName = lblName.Text;
            rpt.SY = lblSY.Text;
            rpt.GOCNO = lblGOCNo.Text;
            
            rpt.Strand = lblTrack.Text;
            rpt.StudName = lblName.Text;
            rpt.GradeLevel = lblGradeLevel.Text;
            rpt.Section = cmbSection.Text;
            rpt.Semester = lblSem.Text;
            rpt.Strand2 = lblStrand.Text;
            rpt.Tuition = Convert.ToDouble(lblTuition.Text);
            rpt.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports();
            frmReports.Show();
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Schedule_loop();
            //tuitionFees2();           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbSection_SelectedValueChanged(object sender, EventArgs e)
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

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmbMOP_SelectedValueChanged(object sender, EventArgs e)
        {
            //Full Payment
            //Partial Payment
            if (cmbMOP.Text == "Partial Payment")
            {

            }
            else
            {

            }
        }

        public void LoadPerMonth()
        {
            //clear list                      
            otherFees.Clear();
            dgvOtherFee.Rows.Clear();
            //pass value to list
            otherFees = otherFee.Load();

            //loop through load it to list view
            foreach (var item in otherFees)
            {
                // int a = Convert.ToInt16(item.MiscFeeAmount);
                dgvOtherFee.Rows.Add(item.OtherFeeName, item.OtherFeeAmount);
                // dgvSubjectLoad.Rows.Add(item.MiscFeeName, a);
                //Convert.ToInt32(dgvSubjectLoad.Rows[i].Cells[1].Value);
            }

            double sum = 0;
            for (int i = 0; i < dgvOtherFee.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvOtherFee.Rows[i].Cells[1].Value);
            }

            lblOther.Text = sum.ToString("n");

        }

        private void dgvOtherFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Schedule_loop();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dgvSubjectLoad.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvSubjectLoad.Rows[i].Cells[1].Value);
            }
            MessageBox.Show(sum.ToString());
        }

        public void Reset()
        {
            //txtSearhAssesment.Text = string.Empty;
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

