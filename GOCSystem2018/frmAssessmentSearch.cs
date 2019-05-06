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
    public partial class frmAssessmentSearch : Form
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
        Assesment assesment = new Assesment();
        StudentProfile studProfile = new StudentProfile();

        List<StudentProfile> studProfiles = new List<StudentProfile>();
        List<Assesment> assesments = new List<Assesment>();

        frmAssesment frmAssesment = new frmAssesment();

      


        public frmAssessmentSearch()
        {
            InitializeComponent();
        }

        private void frmStudSearch_Load(object sender, EventArgs e)
        {
            LoadRecords();
            #region header name fix

            dgvSearch.Columns["LRN"].HeaderText = "LRN";
            dgvSearch.Columns["regNo"].HeaderText = "REG No";
            dgvSearch.Columns["IDNo"].HeaderText = "GOC No";
            dgvSearch.Columns["last_name"].HeaderText = "Last Name";
            dgvSearch.Columns["first_name"].HeaderText = "First Name";
            dgvSearch.Columns["middle_name"].HeaderText = "Middle Name";
            dgvSearch.Columns["grade_Level"].HeaderText = "Grade Level";
            dgvSearch.Columns["section"].HeaderText = "Section";
            dgvSearch.Columns["track"].HeaderText = "Track";
            dgvSearch.Columns["strand"].HeaderText = "Strand";
            dgvSearch.Columns["date_enrolled"].HeaderText = "Date Enrolled";
            dgvSearch.Columns["sy_enrolled"].HeaderText = "SY";
            #endregion

            #region removal of unneccessary header
            this.dgvSearch.Columns["id"].Visible = false;
            // this.dgvSearch.Columns["IDNo"].Visible = false;
            // this.dgvSearch.Columns["regNo"].Visible = false;
            this.dgvSearch.Columns["Reservee"].Visible = false;
            this.dgvSearch.Columns["Reserve_for"].Visible = false;
            this.dgvSearch.Columns["Full_payment"].Visible = false;
            this.dgvSearch.Columns["Partial_payment"].Visible = false;
            this.dgvSearch.Columns["photo_loc"].Visible = false;
            this.dgvSearch.Columns["voucher_type"].Visible = false;
            this.dgvSearch.Columns["address"].Visible = false;
            this.dgvSearch.Columns["date_of_birth"].Visible = false;
            this.dgvSearch.Columns["place_of_birth"].Visible = false;
            this.dgvSearch.Columns["religion"].Visible = false;
            this.dgvSearch.Columns["nationality"].Visible = false;
            this.dgvSearch.Columns["gender"].Visible = false;
            this.dgvSearch.Columns["stud_contactNo"].Visible = false;
            this.dgvSearch.Columns["stud_telNo"].Visible = false;
            this.dgvSearch.Columns["prev_school"].Visible = false;
            this.dgvSearch.Columns["prev_school_address"].Visible = false;
            this.dgvSearch.Columns["father_name"].Visible = false;
            this.dgvSearch.Columns["father_work"].Visible = false;
            this.dgvSearch.Columns["mother_name"].Visible = false;
            this.dgvSearch.Columns["mother_work"].Visible = false;
            this.dgvSearch.Columns["guardian_name"].Visible = false;
            this.dgvSearch.Columns["guardian_work"].Visible = false;
            this.dgvSearch.Columns["guardian_address"].Visible = false;
            this.dgvSearch.Columns["guardian_relationship"].Visible = false;
            this.dgvSearch.Columns["guardian_contactNo"].Visible = false;
            this.dgvSearch.Columns["guardian_telNo"].Visible = false;
            this.dgvSearch.Columns["bc"].Visible = false;
            this.dgvSearch.Columns["form138"].Visible = false;
            this.dgvSearch.Columns["drugtest"].Visible = false;
            this.dgvSearch.Columns["good_moral"].Visible = false;
            this.dgvSearch.Columns["en_exam"].Visible = false;
            this.dgvSearch.Columns["ncae"].Visible = false;
            this.dgvSearch.Columns["date_enrolled"].Visible = false;
            // this.dgvSearch.Columns["sy_enrolled"].Visible = false;
            this.dgvSearch.Columns["1"].Visible = false;
            this.dgvSearch.Columns["2"].Visible = false;
            #endregion


            #region designing DVG
            dgvSearch.BorderStyle = BorderStyle.None;
            //dgvSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 244, 246);
            dgvSearch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSearch.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 244, 246);
            dgvSearch.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvSearch.BackgroundColor = Color.White;

            dgvSearch.EnableHeadersVisualStyles = false;
            dgvSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvSearch.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans Light", 14F, GraphicsUnit.Pixel);
            dgvSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(91, 87, 91);
            dgvSearch.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            //DataGridViewColumn gncol = dgvSearch.Columns["GOCNo"];
            //gncol.Width = 220;

            //DataGridViewColumn gncol2 = dgvSearch.Columns["Full_Name"];
            //gncol2.Width = 575;


            #endregion
        }
        /// <summary>
        /// Methods
        /// </summary>
        public void LoadRecords()
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
                    dgvSearch.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchData(string valueToSearch)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM student_profile WHERE CONCAT(`last_name`, `first_name`,`regno`,`LRN`) LIKE '%" + valueToSearch + "%'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    //initialize new datatable
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvSearch.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectData()
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                //clear list
                studProfiles.Clear();
                //pass value
                studProfile.Id = Int32.Parse(dgvSearch.CurrentRow.Cells[0].FormattedValue.ToString());
                studProfiles = studProfile.GetById();

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
                                        
                }

                //set up before form load
               

                //show assesment                             

               


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


        private void dgvSearch_DoubleClick(object sender, EventArgs e)
        {            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SelectData();
            }
        }

        private void dgvSearch_DoubleClick_1(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSearch_DoubleClick_2(object sender, EventArgs e)
        {
        SelectData();
        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string valueToSearch = txtSearch.Text.ToString();
            searchData(valueToSearch);
        }
    }
}

