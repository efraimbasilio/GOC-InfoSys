using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GOCSystem2018
{
    public partial class frmSectioning : Form
    {
        StudentProfile studProfile = new StudentProfile();       
        Section section = new Section();
        Room room = new Room();

        List<StudentProfile> studProfiles = new List<StudentProfile>();
        List<Section> sections = new List<Section>();
        List<Room> rooms = new List<Room>();
        int a = 0;
        public int ans;

        public frmSectioning()
        {
            InitializeComponent();            
        }

        //Functions----------------------------------------------------------------------------------------------------------------------------//

        public void LoadSchoolYear()
        {
            SchoolYear schoolYear = new SchoolYear();
            List<SchoolYear> schoolYears = new List<SchoolYear>();
            //clear list           
            schoolYears.Clear();

            //pass value to list
            schoolYears = schoolYear.Load();

            //loop through load it to list view
            foreach (var item in schoolYears)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                //string School;
                //School = (item.YearStart + " - " + item.YearEnd);
                //lblSY.Text = School;
                lblSemester.Text = item.Semester;
                //lblQGrading.Text = item.Quarter;
                //cmbSchoolYear.Items.Add(School);
            }
        }//End LoadRecords()

        private DataTable AutoNumberedTable(DataTable SourceTable)

        {

            DataTable ResultTable = new DataTable();

            DataColumn AutoNumberColumn = new DataColumn();

            AutoNumberColumn.ColumnName = "S.No.";

            AutoNumberColumn.DataType = typeof(int);

            AutoNumberColumn.AutoIncrement = true;

            AutoNumberColumn.AutoIncrementSeed = 1;

            AutoNumberColumn.AutoIncrementStep = 1;

            ResultTable.Columns.Add(AutoNumberColumn);

            ResultTable.Merge(SourceTable);

            return ResultTable;

        }

        public void LoadSectionBefore()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT * FROM student_profile";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    //initialize new datatable
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSectionBefore.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void LoadSectionAfter()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT * FROM student_profile";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    //initialize new datatable
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSectionAfter.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadUnSectionStudent(ComboBox criteria,ComboBox grade_level)
        {            
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();
                    //string sql = "SELECT * FROM student_profile";
                    //string sql2 = string.Concat("SELECT * FROM student_profile WHERE CONCAT("+ query_field +") LIKE '%" + valueToSearch + "%'");
                    string sql2 = string.Concat("SELECT IdNo,last_name, first_name, middle_name,strand,grade_level,section FROM student_profile WHERE STRAND LIKE '%" + criteria.Text + "%' AND GRADE_LEVEL LIKE '%" + grade_level.Text + "%'");

                    MySqlCommand cmd = new MySqlCommand(sql2, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    //initialize new datatable
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSectionBefore.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        public void LoadStrand(ComboBox cmb, string query_table, string query_field)
        {
            cmb.Items.Clear();
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();
                    //string sql = "SELECT * FROM student_profile";
                    string sql2 = string.Concat("SELECT * FROM " + query_table + "");
                    MySqlCommand cmd = new MySqlCommand(sql2, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //concat and Load
                        string query = string.Concat(cmb.Items.Add(reader["" + query_field + ""].ToString()));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NoSectionStudents()
        {
            //clear list
            studProfiles.Clear();
            dgvSectionBefore.Rows.Clear();

            //pass value to list
            studProfiles = studProfile.Load();
            foreach (var item in studProfiles)
            {
                if (item.Section == "0" && item.StudStrand.Equals(cmbStrand.SelectedItem.ToString()) && item.StudGradeLevel.Equals(cmbGradeLevel.SelectedItem.ToString()))
                {
                    dgvSectionBefore.Rows.Add(item.StudGOCNo, item.StudLastName, item.StudFirstName, item.StudMiddleName, item.StudStrand, item.StudGradeLevel, item.Section, item.StudRegistrationNo, item.StudSemEnroll, item.SYEnrolled);
                }

                int sum = 0;
                sum = dgvSectionBefore.Rows.Count;
                lblCount.Text = sum.ToString();
            }//End LoadSchedule()    
                   
        }

        public void WithSectionStudents()
        {
            
            //clear list
            studProfiles.Clear();
            dgvSectionBefore.Rows.Clear();

            //pass value to list
            studProfiles = studProfile.Load();
            foreach (var item in studProfiles)
            {
                
                //dgvSectionBefore.Rows.Add(item.StudGOCNo, item.StudLastName, item.StudFirstName, item.StudMiddleName, item.StudStrand, item.StudGradeLevel, item.Section);
                if (item.StudGOCNo.Equals("N/A"))
                {
                    return;
                }
                else
                {
                    //a = a + 1;
                    if (item.StudStrand.Equals(cmbStrand.SelectedItem.ToString()) && item.StudGradeLevel.Equals(cmbGradeLevel.SelectedItem.ToString()) && item.Section != "0")
                        {
                            //for (int i = 1; i < studProfiles.Count; i++)
                            //{
                            dgvSectionBefore.Rows.Add(item.StudGOCNo, item.StudLastName, item.StudFirstName, item.StudMiddleName, item.StudStrand, item.StudGradeLevel, item.Section, item.StudRegistrationNo,item.StudSemEnroll,item.SYEnrolled);
                            //}
                        }
                    
                    //if (item.StudStrand.Equals(cmbStrand.SelectedItem.ToString()) && item.StudGradeLevel.Equals(cmbGradeLevel.SelectedItem.ToString()) && item.Section != "0")
                   
                    //Load to datagridView                   
                }
                int sum = 0;
                sum = dgvSectionBefore.Rows.Count;
                lblCount.Text = sum.ToString();
            }//End LoadSchedule()
        }

        public void LoadSection()
        {
            Section section = new Section();
            List<Section> sections = new List<Section>();

            //clear list     
            dgvSectionCount.Rows.Clear();
            sections.Clear();
            cmbToAssign.Items.Clear();

            section.Strand = cmbStrand.Text;
            //pass value to list
            sections = section.GetPerStrand();

            //loop through load it to list view
            foreach (var item in sections)
            {
                //Load to datagridView
                dgvSectionCount.Rows.Add(item.SectionName);                
            }

            foreach (var item in sections)
            {
                //Load to datagridView
                cmbToAssign.Items.Add(item.SectionName);
            }

        }//End LoadRecords()

        public void CountStudPerSection()
        {
            this.dgvSectionNumber.Rows.Clear();
            for (int i = 0; i < dgvSectionCount.Rows.Count; i++)
            {
                int sum = 0;
                for (int x = 0; x < dgvSectionBefore.Rows.Count; x++)
                {
                    if (dgvSectionCount.Rows[i].Cells[0].FormattedValue.ToString() == dgvSectionBefore.Rows[x].Cells[6].FormattedValue.ToString())
                    {
                        sum = sum + 1;
                    }
                }
                //MessageBox.Show(dgvSectionCount.Rows[i].Cells[0].FormattedValue.ToString() + " " + sum.ToString());
               
                this.dgvSectionNumber.Rows.Add(sum.ToString());
            }
        }
       
        public string strand;

        public void CheckSectionInfo()
        {
            //clear list
            sections.Clear();
            dgvSectionInfo.Rows.Clear();

            //pass value to list
            sections = section.Load();
            foreach (var item in sections)
            {
                if (item.Strand == strand)
                {
                    dgvSectionInfo.Rows.Add(item.SectionName,item.Strand, item.Room);
                }
            }
        }

        public void CheckRoomInfo()
        {
            rooms.Clear();
            dgvRoom.Rows.Clear();

            rooms = room.Load();

            foreach (var item in rooms)
            {
                for (int i = 0; i < dgvSectionInfo.Rows.Count; i++)
                {

                    if (item.RoomName == dgvSectionInfo.Rows[i].Cells[2].FormattedValue.ToString())
                    {
                        dgvRoom.Rows.Add(item.RoomName, item.RoomCapacity, item.RoomCeiling);                                          
                    }
                }
            }

        }

        public void RoomSection()
        {           
            for (int i = 0; i < dgvSectionInfo.Rows.Count; i++)
            {                                       
                if (cmbToAssign.Text == dgvSectionInfo.Rows[i].Cells[0].FormattedValue.ToString())
                {                       
                    for (int x = 0; x < dgvRoom.Rows.Count; x++)
                    {
                        if(dgvSectionInfo.Rows[i].Cells[2].FormattedValue.ToString() == dgvRoom.Rows[i].Cells[0].FormattedValue.ToString())
                        {
                            lblMAX.Text= dgvRoom.Rows[i].Cells[1].FormattedValue.ToString();
                            lblMin.Text = dgvRoom.Rows[i].Cells[2].FormattedValue.ToString();
                            lblNoStudent.Text = dgvSectionNumber.Rows[i].Cells[0].FormattedValue.ToString();

                        }
                    }
                }
            }            
        }

        public void ClearDGV()
        {
            this.dgvSectionBefore.Columns["id"].Visible = false;
            this.dgvSectionBefore.Columns["id_old_stud"].Visible = false;
            this.dgvSectionBefore.Columns["FatherContactNo"].Visible = false;
            this.dgvSectionBefore.Columns["MotherContactNo"].Visible = false;
            this.dgvSectionBefore.Columns["track"].Visible = false;
            this.dgvSectionBefore.Columns["stud_type"].Visible = false;
            this.dgvSectionBefore.Columns["otherAddress"].Visible = false;
            this.dgvSectionBefore.Columns["Reservee"].Visible = false;
            this.dgvSectionBefore.Columns["Reserve_for"].Visible = false;
            this.dgvSectionBefore.Columns["Full_payment"].Visible = false;
            this.dgvSectionBefore.Columns["Partial_payment"].Visible = false;
            this.dgvSectionBefore.Columns["photo_loc"].Visible = false;
            this.dgvSectionBefore.Columns["voucher_type"].Visible = false;
            this.dgvSectionBefore.Columns["address"].Visible = false;
            this.dgvSectionBefore.Columns["date_of_birth"].Visible = false;
            this.dgvSectionBefore.Columns["place_of_birth"].Visible = false;
            this.dgvSectionBefore.Columns["religion"].Visible = false;
            this.dgvSectionBefore.Columns["nationality"].Visible = false;
            this.dgvSectionBefore.Columns["gender"].Visible = false;
            this.dgvSectionBefore.Columns["stud_contactNo"].Visible = false;
            this.dgvSectionBefore.Columns["stud_telNo"].Visible = false;
            this.dgvSectionBefore.Columns["prev_school"].Visible = false;
            this.dgvSectionBefore.Columns["prev_school_address"].Visible = false;
            this.dgvSectionBefore.Columns["father_name"].Visible = false;
            this.dgvSectionBefore.Columns["father_work"].Visible = false;
            this.dgvSectionBefore.Columns["mother_name"].Visible = false;
            this.dgvSectionBefore.Columns["mother_work"].Visible = false;
            this.dgvSectionBefore.Columns["guardian_name"].Visible = false;
            this.dgvSectionBefore.Columns["guardian_work"].Visible = false;
            this.dgvSectionBefore.Columns["guardian_address"].Visible = false;
            this.dgvSectionBefore.Columns["guardian_relationship"].Visible = false;
            this.dgvSectionBefore.Columns["guardian_contactNo"].Visible = false;
            this.dgvSectionBefore.Columns["guardian_telNo"].Visible = false;
            this.dgvSectionBefore.Columns["bc"].Visible = false;
            this.dgvSectionBefore.Columns["form138"].Visible = false;
            this.dgvSectionBefore.Columns["drugtest"].Visible = false;
            this.dgvSectionBefore.Columns["good_moral"].Visible = false;
            this.dgvSectionBefore.Columns["en_exam"].Visible = false;
            this.dgvSectionBefore.Columns["ncae"].Visible = false;
            this.dgvSectionBefore.Columns["date_enrolled"].Visible = false;
            this.dgvSectionBefore.Columns["sy_enrolled"].Visible = false;
            this.dgvSectionBefore.Columns["1"].Visible = false;
            this.dgvSectionBefore.Columns["2"].Visible = false;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------//

        private void cmbStrand_SelectedIndexChanged(object sender, EventArgs e)
        {            
            LoadSection();
            CheckRoomInfo();
        }

        private void frmSectioning_Load(object sender, EventArgs e)
        {
            LoadStrand(cmbStrand, "STRAND", "strand_name");
            LoadSchoolYear();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            NoSectionStudents();
            
            CountStudPerSection();
            strand = cmbStrand.Text;
            CheckSectionInfo();
            CheckRoomInfo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cmbGradeLevel.Text == "" || cmbStrand.Text == "")
            {
                MessageBox.Show("Please Select Grade Level or Strand");
            }
            else
            {
                a = 0;
                WithSectionStudents();
                CountStudPerSection();
                strand = cmbStrand.Text;
                CheckSectionInfo();
                CheckRoomInfo();
            }            
        }
      
        private void button7_Click(object sender, EventArgs e)
        {            
                       
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
                               
        }

        private void dgvSectionBefore_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void cmbToAssign_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomSection();
            ans = (Convert.ToInt32(lblMin.Text) - Convert.ToInt32(lblNoStudent.Text));
            if (ans >= 0)
            {
                lblAvailable.Text = ans.ToString() + " Slot Available";
            }
            else
            {
                MessageBox.Show("No. of Student reach the minimum room capacity.");
            }

           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Do you want to assign all " + lblCount.Text + " Student(s) to section "+ cmbToAssign.Text+"?";
            string title = "GOC_INFOSYS";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dgvSectionBefore.Rows.Count; i++)
                {
                    studProfile.StudGOCNo = dgvSectionBefore.Rows[i].Cells[0].FormattedValue.ToString();
                    studProfile.Section = cmbToAssign.Text;                    
                    studProfile.UpdateTheSectionWithGOCNO();

                    EnrolledStudents enroll = new EnrolledStudents();
                    enroll.RegNo = dgvSectionBefore.Rows[i].Cells[7].FormattedValue.ToString();
                    enroll.TheGOCNo = dgvSectionBefore.Rows[i].Cells[0].FormattedValue.ToString();
                    enroll.FullName = dgvSectionBefore.Rows[i].Cells[3].FormattedValue.ToString() +", "+ dgvSectionBefore.Rows[i].Cells[1].FormattedValue.ToString() +" "+ dgvSectionBefore.Rows[i].Cells[2].FormattedValue.ToString();
                    enroll.GradeLevel = dgvSectionBefore.Rows[i].Cells[5].FormattedValue.ToString();
                    enroll.Strand = dgvSectionBefore.Rows[i].Cells[4].FormattedValue.ToString();
                    enroll.Section = cmbToAssign.Text;
                    enroll.Semester = lblSemester.Text;
                    enroll.SyEnroll = dgvSectionBefore.Rows[i].Cells[9].FormattedValue.ToString();

                    if (dgvSectionBefore.Rows[i].Cells[5].FormattedValue.ToString() == "11")
                    {
                        enroll.Save();//grade 11    
                        
                    }
                    else
                    {
                        enroll.SaveGrade12();//grade 12                       
                    }                                        
                }
                MessageBox.Show("Section Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a = 0;
                WithSectionStudents();
                CountStudPerSection();
                strand = cmbStrand.Text;
                CheckSectionInfo();
                CheckRoomInfo();
            }
            else
            {                
                string input = Microsoft.VisualBasic.Interaction.InputBox("How many student do you want to assign to section " + cmbToAssign.Text + "?", "GOC_INFOSYS","",-1, -1);
                int listSize;
                bool success = int.TryParse(input, out listSize);

                if (listSize > dgvSectionBefore.Rows.Count)//check if the current no is not greaterthan the input
                {
                    MessageBox.Show("Sorry you cannot assign morethan "+ dgvSectionBefore.Rows.Count + " students.");                    
                }
                else
                {
                    for (int i = 0; i < listSize; i++)
                    {
                        studProfile.StudGOCNo = dgvSectionBefore.Rows[i].Cells[0].FormattedValue.ToString();
                        studProfile.Section = cmbToAssign.Text;
                        studProfile.UpdateTheSectionWithGOCNO();

                        EnrolledStudents enroll = new EnrolledStudents();
                        enroll.RegNo = dgvSectionBefore.Rows[i].Cells[7].FormattedValue.ToString();
                        enroll.TheGOCNo = dgvSectionBefore.Rows[i].Cells[0].FormattedValue.ToString();
                        enroll.FullName = dgvSectionBefore.Rows[i].Cells[3].FormattedValue.ToString() + ", " + dgvSectionBefore.Rows[i].Cells[1].FormattedValue.ToString() + " " + dgvSectionBefore.Rows[i].Cells[2].FormattedValue.ToString();
                        enroll.GradeLevel = dgvSectionBefore.Rows[i].Cells[5].FormattedValue.ToString();
                        enroll.Strand = dgvSectionBefore.Rows[i].Cells[4].FormattedValue.ToString();
                        enroll.Section = cmbToAssign.Text;
                        enroll.Semester = lblSemester.Text;
                        enroll.SyEnroll = dgvSectionBefore.Rows[i].Cells[9].FormattedValue.ToString();

                        if (dgvSectionBefore.Rows[i].Cells[5].FormattedValue.ToString() == "11")
                        {
                            enroll.Save();//grade 11    
                            MessageBox.Show("Section Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            enroll.SaveGrade12();//grade 12
                            MessageBox.Show("Section Saved!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    a = 0;
                    WithSectionStudents();
                    CountStudPerSection();
                    strand = cmbStrand.Text;
                    CheckSectionInfo();
                    CheckRoomInfo();
                }
                return;             
            }
           
        }

        private void dgvSectionBefore_DoubleClick_1(object sender, EventArgs e)
        {
            frmAssesment frmAssesment = new frmAssesment();
            if (dgvSectionBefore.SelectedRows.Count > 0)
            {
                //clear list
                studProfiles.Clear();
                //pass value
                studProfile.StudGOCNo = dgvSectionBefore.CurrentRow.Cells[0].FormattedValue.ToString();
                studProfiles = studProfile.GetByGOCNoToEdit();

                foreach (var item in studProfiles)
                {
                    //pass variable to form Assesment
                    frmAssesment.StudName = item.StudLastName + ", " + item.StudFirstName + " " + item.StudMiddleName;
                    frmAssesment.LRN = item.StudLRN;
                    frmAssesment.GradeLevel = item.StudGradeLevel;
                    frmAssesment.Track = item.Track;
                    frmAssesment.RegNo = item.StudRegistrationNo;
                    frmAssesment.Strand = item.StudStrand;
                    frmAssesment.Voucher = item.VoucherType;
                    frmAssesment.GOCNo = item.StudGOCNo;
                    frmAssesment.partialPay = item.PartialPayment;
                    frmAssesment.theSection = item.Section;

                    frmAssesment.cmbMOP.Visible = false;
                    frmAssesment.label8.Visible = false;

                }
            }

            MainWindow mainwin = (MainWindow)Application.OpenForms["MainWindow"];
            mainwin.dispanel.Controls.Clear();
            frmAssesment.TopLevel = false;
            frmAssesment.AutoScroll = true;
            mainwin.dispanel.Controls.Add(frmAssesment);

            frmAssesment.Reset();

            frmAssesment.LoadSchoolYear();

            frmAssesment.LoadTuitionFee();
            frmAssesment.LoadAssesMiscFees();
            frmAssesment.LoadAssesOtherFees();
            frmAssesment.TotalTuition();

            frmAssesment.ComputeVoucher();
            frmAssesment.GetDownPayment();

            frmAssesment.LoadSubject();
            frmAssesment.EnableMOP();

            frmAssesment.Show();
        }
    }
}
