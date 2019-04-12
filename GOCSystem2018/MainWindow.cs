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
    public partial class MainWindow : Form
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
        public MainWindow()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        SchoolYear schoolYear = new SchoolYear();
        List<SchoolYear> schoolYears = new List<SchoolYear>();

        #region sidebar code
        


        #endregion

        #region misc buttons click event
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmTuition frmTuition = new frmTuition();
            frmTuition.ShowDialog();
        }//tuition form

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frmMiscFees frmMiscFees = new frmMiscFees();
            frmMiscFees.ShowDialog();
        }//misc form

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            frmOtherFees frmOtherFees = new frmOtherFees();
            frmOtherFees.ShowDialog();
        }//otherfees form

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            frmDiscountFee frmDiscountFee = new frmDiscountFee();
            frmDiscountFee.ShowDialog();
        }//discount form

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            frmVoucher frmVoucher = new frmVoucher();
            frmVoucher.ShowDialog();
        }// voucher form

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            frmTeacher frmTeacher = new frmTeacher();
            frmTeacher.ShowDialog();
        }//teacher form
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser();
            frmUser.ShowDialog();
        }//user form
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            frmStrand frmStrand = new frmStrand();
            frmStrand.ShowDialog();
        }//strand form
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            frmSection frmSection = new frmSection();
            frmSection.ShowDialog();
        }//section form
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            frmRoom frmRoom = new frmRoom();
            frmRoom.ShowDialog();
        }//room form
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            frmSubject frmSubject = new frmSubject();
            frmSubject.ShowDialog();
        }//subject form
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            frmSchoolYear frmSchoolYear = new frmSchoolYear();
            frmSchoolYear.ShowDialog();
        }// S.Y form
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            frmSched frmSched = new frmSched();
            frmSched.ShowDialog();
        }//sched form
        #endregion



        public void LoadSchoolYear()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
           
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

        private void LoadRecords()
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
                    dt = new DataTable();

                    da.Fill(dt);
      

                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {

            LoadSchoolYear();
            LoadRecords();

            #region dvg design
            Logdgv.BorderStyle = BorderStyle.None;
            Logdgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Logdgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Logdgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(166, 176, 236);
            Logdgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Logdgv.BackgroundColor = Color.White;

            Logdgv.EnableHeadersVisualStyles = false;
            Logdgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Logdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(166, 176, 236);
            Logdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            #endregion

            this.chart2.Series["Population"].Points.AddXY("STEM", label134.Text);
            this.chart2.Series["Population"].Points.AddXY("HUMSS", label133.Text);
            this.chart2.Series["Population"].Points.AddXY("ABM", label132.Text);
            this.chart2.Series["Population"].Points.AddXY("TVL", label131.Text);
            this.chart2.Series["Population"].Points.AddXY("TOURISM", label130.Text);
            this.chart2.Series["Population"].Points.AddXY("REAL ESTATE", label129.Text);
            this.chart2.Series["Population"].Points.AddXY("ACCOUNTANCY", label128.Text);





        }
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
        }

        
        //dynamic label*************************************************************************************************************************
        //**************************************************************************************************************************************
        #region dynamic label
        //PictureBox studPicturebox(int i, int start, int end, int start2, int end2)
        //{
        //    PictureBox spb = new PictureBox();
        //    spb.Name = "spb" + i.ToString();
        //    spb.Image = new Bitmap("E:\\GOC\\Media\\grading system resource\\bgpane.jpg");
        //    spb.BackgroundImageLayout = ImageLayout.Stretch;
        //    spb.BorderStyle = BorderStyle.Fixed3D;
        //    spb.Size = new Size(32,32);
        //    spb.Location = new Point(start-3, end);
            
            
        //    return spb;
        //}

        Panel placeHolder(int i, int start, int end, int start2, int end2)
        {
            Panel ph = new Panel();
            ph.Name = "ph" + i.ToString();
            ph.BackColor = Color.White;
            ph.Size = new Size(1122, 56);
            ph.Location = new Point(start2, end2);
            
            return ph;

        }
        Label addLabel(int i, int start, int end, String studname)
        {
            Label l = new Label();

            l.Name = "li" + i.ToString();
            l.Text = studname;
            l.Size = new Size(250, 19);
            l.ForeColor = Color.Gray;
            l.BackColor = Color.Transparent;
            l.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            l.Location = new Point(start + (2 * 200), end);

            return l;
        }
        Label addLabel2(int i, int start, int end, int start2, int end2, String studNo)
        {
            Label lsn = new Label();
            lsn.Name = "lsn" + i.ToString();
            lsn.Text = studNo;
            lsn.ForeColor = Color.Gray;
            lsn.BackColor = Color.Transparent;
            lsn.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            lsn.Location = new Point(start + (4 * 200), end);
            return lsn;
        }
        Label addLabel3(int i, int start, int end, int start2, int end2, String sec)
        {
            Label lsection = new Label();
            lsection.Name = "ls" + i.ToString();
            lsection.Text = sec;
            lsection.ForeColor = Color.Gray;
            lsection.BackColor = Color.Transparent;
            lsection.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            lsection.Location = new Point(start + (5 * 200), end);
            return lsection;
        }
        Label addLabel4(int i, int start, int end, int start2, int end2, String grade)
        {
            Label lgrade = new Label();
            lgrade.Name = "lg" + i.ToString();
            lgrade.Text = grade;
            lgrade.ForeColor = Color.Gray;
            lgrade.BackColor = Color.Transparent;
            lgrade.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            lgrade.Location = new Point(start + (3 * 200), end);
            return lgrade;
        }

        Label addLabel5(int i, int start, int end, int start2, int end2, String strand)
        {
            Label lstrand = new Label();
            lstrand.Name = "lst" + i.ToString();
            lstrand.Text = strand;
            lstrand.ForeColor = Color.Gray;
            lstrand.BackColor = Color.Transparent;
            lstrand.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            lstrand.Location = new Point(start + 200, end);
            return lstrand;
        }

        Label addLabel6(int i, int start, int end, int start2, int end2)
        {
            Label lline = new Label();
            lline.Name = "ll" + i.ToString();
            lline.Text = "______________________________________________________________________________________________________________________________";
            lline.ForeColor = Color.Gray;
            lline.Width = 750;
            lline.BackColor = Color.Transparent;
            lline.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
            lline.Location = new Point(start2, end2);
            return lline;
        }

        #endregion
        //**************************************************************************************************************************************
        //**************************************************************************************************************************************
        private void pictureBox25_Click_1(object sender, EventArgs e)
        {

            Dashboardpanel.Visible = false;

            dispanel.Refresh();
            dispanel.Visible = false;

            
            }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            frmAssessmentSearch frmAssessmentSearch = new frmAssessmentSearch();
            frmAssessmentSearch.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBillingSearch frmBillingSearch = new frmBillingSearch();
            frmBillingSearch.ShowDialog();
        }

        private void StudentlistPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dispanel.Visible = true;
            frmRegistration frm = new frmRegistration();
            frm.TopLevel = false;
            frm.AutoScroll = true;



            dispanel.Controls.Add(frm);

            frm.Show();


            Dashboardpanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAssessmentSearch frmas = new frmAssessmentSearch();
            frmas.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBillingSearch frmbs = new frmBillingSearch();
            frmbs.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //frmStudlist frmsl = new frmStudlist();
            //frmsl.ShowDialog();
            dispanel.Visible = true;
            frmStudlist frm = new frmStudlist();
            frm.TopLevel = false;
            frm.AutoScroll = true;



            dispanel.Controls.Add(frm);

            frm.Show();

        }
    }


        
      
    }
    

