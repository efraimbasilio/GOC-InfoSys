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

        List<StudentProfile> studProfiles = new List<StudentProfile>();

        public frmSectioning()
        {
            InitializeComponent();
            
        }

        //Functions----------------------------------------------------------------------------------------------------------------------------//

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
                    dgvSectionBefore.Rows.Add(item.StudGOCNo, item.StudLastName, item.StudFirstName, item.StudMiddleName, item.StudStrand, item.StudGradeLevel, item.Section);
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
                    //if (item.StudStrand.Equals(cmbStrand.SelectedItem.ToString()) && item.StudGradeLevel.Equals(cmbGradeLevel.SelectedItem.ToString()) && item.Section != "0")
                    if (item.StudStrand.Equals(cmbStrand.SelectedItem.ToString()) && item.StudGradeLevel.Equals(cmbGradeLevel.SelectedItem.ToString()) && item.Section != "0")
                    {
                        dgvSectionBefore.Rows.Add(item.StudGOCNo, item.StudLastName, item.StudFirstName, item.StudMiddleName, item.StudStrand, item.StudGradeLevel, item.Section);
                    }
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

            section.Strand = cmbStrand.Text;
            //pass value to list
            sections = section.GetPerStrand();

            //loop through load it to list view
            foreach (var item in sections)
            {
                //Load to datagridView
                dgvSectionCount.Rows.Add(item.SectionName);                
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


        Section section = new Section();
        Room room = new Room();

        List<Section> sections = new List<Section>();
        List<Room> rooms = new List<Room>();


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
                    dgvSectionInfo.Rows.Add(item.Strand, item.Room);
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

                    if (item.RoomName == dgvSectionInfo.Rows[i].Cells[1].FormattedValue.ToString())
                    {
                        dgvRoom.Rows.Add(item.RoomName, item.RoomCapacity, item.RoomCeiling);
                        //ssageBox.Show(item.RoomCapacity);                        
                    }
                }
            }

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
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            NoSectionStudents();
            //CountStudPerSection();
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
