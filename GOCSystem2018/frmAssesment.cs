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
        #region shadow
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }
        #endregion
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
        Grading grade = new Grading();
        Billing_Partial billingPartial = new Billing_Partial();
        StudentProfile studProfile = new StudentProfile();
        Billing bill = new Billing();
        EnrolledStudents enrollee = new EnrolledStudents();
        Room room = new Room();

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
        List<Grading> grades = new List<Grading>();
        List<Billing_Partial> billingPartials = new List<Billing_Partial>();
        List<StudentProfile> studProfiles = new List<StudentProfile>();
        List<Billing> billings = new List<Billing>();
        List<EnrolledStudents> enrollees = new List<EnrolledStudents>();
        List<Room> rooms = new List<Room>();
       

        public string StudName,GOCNo, LRN, Track, GradeLevel, RegNo, Strand,Voucher,theSection;
        public string partialPay, roomName,sectionThis;
        public bool toSave = true;

        public frmAssesment()
        {
            InitializeComponent();
        }

        private void frmAssesment_Load(object sender, EventArgs e)
        {
            

            #region DGV Design

            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(166, 176, 236);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(166, 176, 236);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvSubject.BorderStyle = BorderStyle.None;
            dgvSubject.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSubject.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSubject.DefaultCellStyle.SelectionBackColor = Color.FromArgb(166, 176, 236);
            dgvSubject.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSubject.BackgroundColor = Color.White;

            dgvSubject.EnableHeadersVisualStyles = false;
            dgvSubject.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSubject.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(166, 176, 236);
            dgvSubject.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvSchedule.BorderStyle = BorderStyle.None;
            dgvSchedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSchedule.DefaultCellStyle.SelectionBackColor = Color.FromArgb(166, 176, 236);
            dgvSchedule.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSchedule.BackgroundColor = Color.White;

            dgvSchedule.EnableHeadersVisualStyles = false;
            dgvSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(166, 176, 236);
            dgvSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvPerMonth.BorderStyle = BorderStyle.None;
            dgvPerMonth.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPerMonth.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPerMonth.DefaultCellStyle.SelectionBackColor = Color.FromArgb(166, 176, 236);
            dgvPerMonth.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPerMonth.BackgroundColor = Color.White;

            dgvPerMonth.EnableHeadersVisualStyles = false;
            dgvPerMonth.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPerMonth.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(166, 176, 236);
            dgvPerMonth.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvSubjectLoad.BorderStyle = BorderStyle.None;
            dgvSubjectLoad.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSubjectLoad.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSubjectLoad.DefaultCellStyle.SelectionBackColor = Color.FromArgb(166, 176, 236);
            dgvSubjectLoad.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSubjectLoad.BackgroundColor = Color.White;

            dgvSubjectLoad.EnableHeadersVisualStyles = false;
            dgvSubjectLoad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSubjectLoad.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(166, 176, 236);
            dgvSubjectLoad.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvOtherFee.BorderStyle = BorderStyle.None;
            dgvOtherFee.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvOtherFee.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOtherFee.DefaultCellStyle.SelectionBackColor = Color.FromArgb(166, 176, 236);
            dgvOtherFee.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvOtherFee.BackgroundColor = Color.White;

            dgvOtherFee.EnableHeadersVisualStyles = false;
            dgvOtherFee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOtherFee.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(166, 176, 236);
            dgvOtherFee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            #endregion

            lblName.Text = StudName;
            lblGradeLevel.Text = GradeLevel;
            lblLRN.Text = LRN;
            lblTrack.Text = Track;
            lblGOCNo.Text = GOCNo;
            lblRegNo.Text = RegNo;
            lblStrand.Text = Strand;
            lblVoucher.Text = Voucher;
            

            //LoadEnrolledStudents();
            //LoadEnrolledStudents12();

            //if (partialPay == null)
            //{
            //    return;
            //}


            //if (Convert.ToInt32(partialPay) > 0)
            //{
            //    cmbMOP.Text = "Partial Payment";
            //    cmbMOP.Enabled = false;
            //}
            //else
            //{
            //    //cmbMOP.Text = "Partial Payment";
            //    cmbMOP.Enabled = true;
            //}


            LoadSection();
            EnrollmentStatus();
            LoadBillingHistory();


            //if (Convert.ToInt32((lblGradeLevel.Text)) == 11)
            //{
            //    LoadEnrolledStudents();
            //}else
            //{
            //    LoadEnrolledStudents12();
            //}
            LoadEnrolledStudents();
            sectionThis = cmbSection.Text;
            LoadEnrolledStudents12();



            if (Convert.ToInt32(partialPay) > 0)
            {
                cmbMOP.Text = "Partial Payment";
                cmbMOP.Enabled = false;
            }

            if (theSection == null)
            {
                cmbSection.Text = "";
            }
            else
            {
                //MessageBox.Show(theSection);
                cmbSection.Text = theSection;
            }

            if (lblEnStatus.Text == "Pending")
            {
                cmbSection.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                cmbSection.Enabled = true;
                button4.Enabled = true;
            }

            
        }

        public void LoadBillingHistory()
        {
            //clear list
            billings.Clear();
            dgvFeeHistory.Rows.Clear();
            //pass value to list
            bill.StudentId = lblGOCNo.Text;
            billings = bill.GetPaymentHistory();

            //loop through load it to list view
            foreach (var item in billings)
            {
                dgvFeeHistory.Rows.Add(Convert.ToInt32(item.OrNo), item.StudentId, Convert.ToDouble(item.AmountGiven), Convert.ToInt32(item.PaymentNo), item.PaymentDate);

            }
        }

        public void LoadSectionCapacity()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            //bRoom.Items.Clear();
            rooms.Clear();

            room.RoomName = roomName;
            //pass value to list
            rooms = room.GetRoomSectionCapacity();

            //loop through load it to list view
            foreach (var item in rooms)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                lblRoomCapacity.Text= item.RoomCapacity;
            }

        }//End LoadRecords()

        /// <summary>
        /// Working to filter the Downpayment per department
        /// </summary>
        public void GetDownPayment()
        {
            //clear list
            vouchers.Clear();
            //pass value to list
            voucher.VoucherFrom = Voucher;
            vouchers = voucher.GetDownpaymnet();

            //loop through load it to list view
            foreach (var item in vouchers)
            {               
                    double b =
                    b = Convert.ToDouble(item.DpAmount);
                lblDownpayment.Text = b.ToString("n");
               // MessageBox.Show(lblDownpayment.Text);           
            }
        }//End LoadRecords

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
                    lblVoucherAmount.Text = b.ToString("n");
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

        public void TotalTuition()
        {          
                double total = Convert.ToDouble(lblTuition.Text) + Convert.ToDouble(lblTotalOtherFee.Text) + Convert.ToDouble(lblTotalMiscFee.Text);
                lblTotalFees.Text = total.ToString("n");            
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

        public void SaveForGrading()
        {
            //string a,b;

            for (int i = 0; i < dgvSubject.Rows.Count; i++)
            {
                grade.StudentId = lblGOCNo.Text;
                grade.Fullname = lblName.Text;
                grade.SubjectCode = dgvSubject.Rows[i].Cells[0].FormattedValue.ToString();
                grade.SubjectDesc = dgvSubject.Rows[i].Cells[1].FormattedValue.ToString();
                grade.Units = "";
                grade.FirstQ = 0;
                grade.SecondQ = 0;
                grade.Average = 0;
                grade.Remarks = "";
                grade.Term = lblSem.Text;
                grade.GradeLevel = lblGradeLevel.Text;
                grade.Section = cmbSection.Text;
                grade.Strand = lblStrand.Text;

                grade.Save();

            }
            MessageBox.Show("Subject Saved to grading!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //lblGradeLevel.Text;
            //lblSem.Text;
            //cmbSection.Text;
            //lblStrand.Text;
            //lblName.Text;
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
            lblTotalOtherFee.Text = sum.ToString("n");           
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

        public void EnrollmentStatus()
        {
            //clear list
            billingPartials.Clear();
            //pass value to list

            billingPartial.RegNo = lblRegNo.Text;
            billingPartials = billingPartial.GetPaymentPartial();

            //loop through load it to list view
            foreach (var item in billingPartials)
            {
                lblEnStatus.Text = item.EnStatus;
                //MessageBox.Show("sadas");
            }
        }


        public void LoadSection()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            cmbSection.Items.Clear();
            sections.Clear();

            section.Strand = lblStrand.Text;
            //pass value to list
            sections = section.GetPerStrand();

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
            dgvSubject.Rows.Clear();
            //cmbSection.Items.Clear();
            subjects.Clear();

            //pass value to list
            subjects = subject.Load();
         
            foreach (var item in subjects)
            {
                if (item.SubjType.Equals(core) && item.SubjSemester.Equals(lblSubjSemester.Text) && item.SubjGradeLevel.Equals(GradeLevel))
                {
                    //Load to datagridView
                    dgvSubject.Rows.Add(item.SubjectCode, item.SubjectDesc);
                }
            }

            foreach (var item in subjects)
            {
                if (item.SubjType.Equals(applied) && item.SubjSemester.Equals(lblSubjSemester.Text) && item.SubjGradeLevel.Equals(GradeLevel) && item.SubjStrand.Equals(allStrand))
                {
                    //Load to datagridView
                    dgvSubject.Rows.Add(item.SubjectCode, item.SubjectDesc);
                }
            }

            foreach (var item in subjects)
            {
                if (item.SubjType.Equals(specialized) && item.SubjSemester.Equals(lblSubjSemester.Text) && item.SubjGradeLevel.Equals(GradeLevel) && item.SubjStrand.Equals(Strand))
                {
                    //Load to datagridView
                    dgvSubject.Rows.Add(item.SubjectCode, item.SubjectDesc);
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

        public void LoadEnrolledStudents()
        {
            //clear list
            enrollees.Clear();


            enrollee.Section = sectionThis;
            //pass value to list
            enrollees = enrollee.CountStudInSection();
            //MessageBox.Show("sasa");
            //loop through load it to list view
            foreach (var item in enrollees)
            {
                //Load to datagridView
                dgvStudents.Rows.Add(item.RegNo, item.TheGOCNo, item.FullName, item.GradeLevel, item.Strand, item.Section, item.Section, item.Semester, item.SyEnroll);
            }//End LoadSchedule()
        }

      

        private void frmAssesment_Load_1(object sender, EventArgs e)
        {

        }
        private void btnAsses_Click(object sender, EventArgs e)
        {            
            subject.SubjType = applied;           
            //loop();     
        }
        private void cmbStrand_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbStrand_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        ////////////////////////////FOR REPORTS ///////////////////
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
            if (dgvSchedule.Rows.Count < 1)
            {
                MessageBox.Show("No Schedule Assign Yet");
                return;
            }

            frmAssesment frm = new frmAssesment();
            frm.Hide();

            Schedule_loop();
           
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
            rpt.Strand2 = lblStrand.Text;
            rpt.Tuition = Convert.ToDouble(lblTuition.Text);

            frmAssesment frm1 = new frmAssesment();
            frm1.Hide();

            rpt.ShowDialog();                     
        }

        ////////////////////////////FOR REPORTS ///////////////////


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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbSection_SelectedValueChanged(object sender, EventArgs e)
        {
           
           
        }

        public  void LoadRoomCapacity()
        {

            sections.Clear();
            lblRoomName.Text = "";

            section.SectionName = cmbSection.Text;

            // MessageBox.Show(theSection);           
            sections = section.GetRoomBySectionRoom();
            foreach (var item in sections)
            {
                lblRoomName.Text = item.Room;
               // MessageBox.Show(lbltest.Text);   
            }

            rooms.Clear();
            //lblRoomName.Text = "";

            room.RoomName = lblRoomName.Text;
            rooms = room.GetRoomSectionCapacity();
            foreach (var item in rooms)
            {
                lblRoomCapacity.Text = item.RoomCapacity;
                lblCeiling.Text = item.RoomCeiling;
            }            
        }

        private void checkEnroleeCapacity()
        {
            int students =0;

            for (int i = 0; i < dgvEnrolledList.Rows.Count; i++)
            {
                 students = students + 1;                 
            }

            if (Convert.ToInt32(lblCeiling.Text) == students)
            {
                MessageBox.Show("No more slot, Please Check or add new Section, Enrolled Students are:" + students);//option to add or create new section+
                toSave = false;
                button4.Visible = true;
                return;
            }            
        }

       

        private void CheckDuplicateRecords()
        {
            for (int i = 0; i < dgvStudents.Rows.Count; i++)
            {
                if (dgvStudents.Rows[i].Cells[0].FormattedValue.ToString() == lblGOCNo.Text && dgvStudents.Rows[i].Cells[4].FormattedValue.ToString() == lblSem.Text)  //GOC NO
                {
                    MessageBox.Show("Duplicate Detected");
                    toSave = false;
                    return;
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
            this.Hide();
            this.Dispose();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void cmbMOP_SelectedValueChanged(object sender, EventArgs e)
        {
            
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
                dgvOtherFee.Rows.Add(item.OtherFeeName, item.OtherFeeAmount);
                
            }

            double sum = 0;
            for (int i = 0; i < dgvOtherFee.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvOtherFee.Rows[i].Cells[1].Value);
            }

            lblTotalOtherFee.Text = sum.ToString("n");

        }

        private void dgvOtherFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (btnEnroll.Text == "&Next" && cmbSection.Text == "")
            {
                if (cmbSection.Text == "" && lblEnStatus.Text =="Reservee")
                {
                    //pnlRES.Visible = false;
                    string message = "Please choose the desired section.";
                    string title = "GOC_INFO_SYS";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                   // cmbSection.Focus();
                    return;
                }
                
                //Full Payment
                //Partial Payment
                if (cmbMOP.Text == "Partial Payment")
                {
                    //pnlRES.Visible = false;
                    string message = "Do you want to proceed to payment ?";
                    string title = "GOC_INFO_SYS";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        billingPartial.IdNo = lblGOCNo.Text;
                        billingPartial.Full_name = lblName.Text;
                        billingPartial.DownPayment = lblDownpayment.Text;

                        //lblTotalFees.Text;
                        double ans = Convert.ToDouble(lblTotalFees.Text) - Convert.ToDouble(lblVoucherAmount.Text);
                       // MessageBox.Show(ans.ToString("n"));

                        studProfile.StudRegistrationNo = RegNo;
                        studProfile.PartialPayment = "1";
                        studProfile.PartialOnly();
                                            
                    }
                    frmBillingSearch bill = new frmBillingSearch();
                    MainWindow mainwin2 = (MainWindow)Application.OpenForms["MainWindow"];
                    mainwin2.dispanel.Controls.Clear();
                    bill.TopLevel = false;
                    bill.AutoScroll = true;
                    mainwin2.dispanel.Controls.Add(bill);

                    bill.Show();

                }

                else if (cmbMOP.Text == "Full Payment")
                {
                    frmBillingSearch bill = new frmBillingSearch();
                    bill.Show();                  
                }

                else if (cmbMOP.Text == "Reservation")
                {
                    //pnlRES.Visible = true;

                    string message = "Do you want to proceed the Reservation?";
                    string title = "GOC_INFO_SYS";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // this.optYES.Checked = true;
                        if (cmbMOP.SelectedItem.Equals("Reservation"))
                        {
                            //if (optYES.Checked == true && GradeLevel.Equals("11"))
                            //{
                            studProfile.ReserveFor = lblGradeLevel.Text;
                           // MessageBox.Show(studProfile.ReserveFor);
                            studProfile.StudRegistrationNo = RegNo;
                            studProfile.Reservee = "1";
                            studProfile.ReserveOnly();

                            //frmBillingSearch frmBillingSearch = new frmBillingSearch();
                            //this.Hide();
                            this.Close();
                            //frmBillingSearch.Show();                            
                        }
                    }
                    else
                    {
                        optNO.Checked = true;
                        pnlRES.Visible = false;
                        cmbMOP.Text = "";
                    }
                }
            }
            else
            {
                if (Convert.ToInt32(lblGradeLevel.Text) == 11)
                {
                    checkEnroleeCapacity();
                    CheckDuplicateRecords();
                }
                else
                {
                   
                    checkEnroleeCapacity12();
               
                    CheckDuplicateRecords12();

                }

                if (toSave == true && Convert.ToInt32(lblGradeLevel.Text) == 11)
                    {                     
                       // MessageBox.Show("To save records");
                        //for grade 11 Student Enrollment Module

                       // MessageBox.Show("section ----------- sectioning module 1");
                        studProfile.StudRegistrationNo = lblRegNo.Text;
                        studProfile.Section = cmbSection.Text;
                       // MessageBox.Show("section ----------- sectioning module 1 - pass" + studProfile.Section);
                        studProfile.UpdateTheSection();

                        EnrolledStudents enroll = new EnrolledStudents();
                        enroll.RegNo = lblRegNo.Text;
                        enroll.TheGOCNo = lblGOCNo.Text;
                        enroll.FullName = lblName.Text;
                        enroll.GradeLevel = lblGradeLevel.Text;
                        enroll.Strand = lblStrand.Text;
                        enroll.Section = cmbSection.Text;
                        enroll.Semester = lblSem.Text;//semester
                        enroll.SyEnroll = lblSY.Text;

                        enroll.Save();//grade 11

                        SaveForGrading();
                    MainWindow mainwin = (MainWindow)Application.OpenForms["MainWindow"];
                    mainwin.dispanel.Controls.Clear();
                    mainwin.dispanel.Visible = false;

                    mainwin.Dashboardpanel.Visible = true;


                    this.Close();

                }

                else if (toSave == true && Convert.ToInt32(lblGradeLevel.Text) == 12)
                    {
                        
                        // MessageBox.Show("To save records");
                        //for grade 11 Student Enrollment Module

                        // MessageBox.Show("section ----------- sectioning module 1");
                        studProfile.StudRegistrationNo = lblRegNo.Text;
                        studProfile.Section = cmbSection.Text;
                        // MessageBox.Show("section ----------- sectioning module 1 - pass" + studProfile.Section);
                        studProfile.UpdateTheSection();

                        EnrolledStudents enroll = new EnrolledStudents();
                        enroll.RegNo = lblRegNo.Text;
                        enroll.TheGOCNo = lblGOCNo.Text;
                        enroll.FullName = lblName.Text;
                        enroll.GradeLevel = lblGradeLevel.Text;
                        enroll.Strand = lblStrand.Text;
                        enroll.Section = cmbSection.Text;
                        enroll.Semester = lblSem.Text;//semester
                        enroll.SyEnroll = lblSY.Text;

                        enroll.SaveGrade12();//grade 12

                    MainWindow mainwin = (MainWindow)Application.OpenForms["MainWindow"];
                    mainwin.dispanel.Controls.Clear();
                    mainwin.dispanel.Visible = false;

                    mainwin.Dashboardpanel.Visible = true;


                    this.Close();

                }

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetDownPayment();
        }

        private void cmbMOP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Schedule_loop();
        }

        private void optRGrade12_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = "Do you want to proceed the Reservation?";
            string title = "GOC_INFO_SYS";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
               // this.optYES.Checked = true;
                if (cmbMOP.SelectedItem.Equals("Reservation"))
                {
                    //if (optYES.Checked == true && GradeLevel.Equals("11"))
                    //{
                        studProfile.ReserveFor = lblGradeLevel.Text;
                      //  MessageBox.Show(studProfile.ReserveFor);
                        studProfile.StudRegistrationNo = RegNo;
                        studProfile.Reservee = "1";
                        studProfile.ReserveOnly();

                        frmBillingSearch frmBillingSearch = new frmBillingSearch();
                        this.Hide();
                        this.Dispose();
                        frmBillingSearch.Show();                  
                }
            }
            else
            {
                optNO.Checked = true;
                pnlRES.Visible = false;
                cmbMOP.Text = "";
            }                         
        }

        private void lblRoomName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbMOP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbMOP.Text.ToString().Equals("Partial Payment")){

                pictureBox2.Visible = false;
                label26.Visible = false;

                pictureBox1.Visible = true;
                label18.Visible = true;

            }else if (cmbMOP.Text.ToString().Equals("Reservation"))
            {
                pictureBox2.Visible = true;
                label26.Visible = true;

                pictureBox1.Visible = false;
                label18.Visible = false;
            }
        }

        private void label37_Click(object sender, EventArgs e)
        {
           
            this.Close();
            frmAssessmentSearch frmAssessmentSearch = new frmAssessmentSearch();
            frmAssessmentSearch.LoadRecords();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            

            frmBillingSearch frmBillingSearch = new frmBillingSearch();
            this.Hide();
            this.Dispose();

            frmBillingSearch.ShowDialog();
        }

        private void cmbSection_SelectedValueChanged_1(object sender, EventArgs e)
        {
            toSave = true;
            LoadRoomCapacity();
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

            enrollees.Clear();
            dgvEnrolledList.Rows.Clear();

            enrollee.Section = cmbSection.Text;
            enrollees = enrollee.CountStudInSection();

            foreach (var item in enrollees)
            {
                dgvEnrolledList.Rows.Add(item.TheGOCNo, item.GradeLevel, item.Strand, item.Section, item.Semester);
            }


            enrollees.Clear();
            dgvStudents.Rows.Clear();
            enrollees = enrollee.Load();

            foreach (var item in enrollees)
            {
                dgvStudents.Rows.Add(item.TheGOCNo, item.GradeLevel, item.Strand, item.Section, item.Semester);
            }

            /////////////////////////////////////12///////////////////////////////////////////////////////////
            enrollees.Clear();
            dgvEnrolled12.Rows.Clear();

            enrollee.Section2 = cmbSection.Text;
            enrollees = enrollee.CountStudInSection12();

            foreach (var item in enrollees)
            {
                dgvEnrolled12.Rows.Add(item.TheGOCNo, item.GradeLevel, item.Strand, item.Section, item.Semester);
            }


            enrollees.Clear();
            dgvStudent12.Rows.Clear();
            enrollees = enrollee.Load12();

            foreach (var item in enrollees)
            {
                dgvStudent12.Rows.Add(item.TheGOCNo, item.GradeLevel, item.Strand, item.Section, item.Semester);
            }
            /////////////////////////////////////12///////////////////////////////////////////////////////////


            btnEnroll.Enabled = true;
            if (btnEnroll.Text != "")
            {
                btnEnroll.Text = "&Enroll";
            }

        }

        private void button4_Click_4(object sender, EventArgs e)
        {
            frmSection frmSection = new frmSection();
            frmSection.ShowDialog();
        }

        private void cmbMOP_SelectedValueChanged_1(object sender, EventArgs e)
        {
            btnEnroll.Enabled = true;
        }

        private void optYES_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dgvSubjectLoad.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvSubjectLoad.Rows[i].Cells[1].Value);
            }
          //  MessageBox.Show(sum.ToString());
        }

        public void Reset()
        {
            //txtSearhAssesment.Text = string.Empty;
            lblLRN.Text = string.Empty;
            lblName.Text = string.Empty;
            lblGradeLevel.Text = string.Empty;

            cmbMOP.Enabled = false;
            cmbSection.Enabled = false;

            if (lblEnStatus.Text == "Enrolled")
            {
                btnEnroll.Text = "&Enroll";
            }
            else
            {
                btnEnroll.Text = "&Next";
            }
            
            
        }

        public void EnableMOP()
        {
          
            cmbMOP.Enabled = true;
            cmbSection.Enabled = true;
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            frmAssessmentSearch frmAssessmentSearch = new frmAssessmentSearch();
            //frmStudSearch.LoadRecords();

            frmAssessmentSearch.Show();
            //this.Dispose();           
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



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void LoadEnrolledStudents12()
        {
            //clear list
            enrollees.Clear();


            enrollee.Section = sectionThis;
            //pass value to list
            enrollees = enrollee.CountStudInSection12();
            MessageBox.Show("sasa");
            //loop through load it to list view
            foreach (var item in enrollees)
            {
                MessageBox.Show("sasa222");
                //Load to datagridView
                dgvStudent12.Rows.Add(item.RegNo, item.TheGOCNo, item.FullName, item.GradeLevel, item.Strand, item.Section, item.Section, item.Semester, item.SyEnroll);
            }//End LoadSchedule()
        }

        private void checkEnroleeCapacity12()
        {
           // MessageBox.Show("this Detected4444444444444444444444444444");
            int students = 0;

            for (int i = 0; i < dgvEnrolled12.Rows.Count; i++)
            {
                students = students + 1;
            }

            if (Convert.ToInt32(lblCeiling.Text) == students)
            {
                MessageBox.Show("No more slot, Please Check or add new Section, Enrolled Students are:" + students);//option to add or create new section+
                toSave = false;
                button4.Visible = true;
                return;
            }
        }

        private void CheckDuplicateRecords12()
        {
            //MessageBox.Show("this Detected4444444444444444444444444444");
            for (int i = 0; i < dgvStudent12.Rows.Count; i++)
            {
                if (dgvStudent12.Rows[i].Cells[0].FormattedValue.ToString() == lblGOCNo.Text && dgvStudent12.Rows[i].Cells[4].FormattedValue.ToString() == lblSem.Text)  //GOC NO
                {
                    MessageBox.Show("Duplicate Detected");
                    toSave = false;
                    return;
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

