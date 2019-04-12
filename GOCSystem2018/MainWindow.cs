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
        public MainWindow()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        SchoolYear schoolYear = new SchoolYear();
        List<SchoolYear> schoolYears = new List<SchoolYear>();

        #region sidebar code
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = true;
            StudentlistPanel.Visible = false;
            MaintenancePanel.Visible = false;
            panel5.Height = pictureBox23.Height;
            panel5.Top = pictureBox23.Top;
        }

        private void EnrollmentBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            StudentlistPanel.Visible = false;
            MaintenancePanel.Visible = false;
            panel5.Height = pictureBox24.Height;
            panel5.Top = pictureBox24.Top;
        }

        private void StudlistBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            StudentlistPanel.Visible = true;
            MaintenancePanel.Visible = false;
            panel5.Height = pictureBox25.Height;
            panel5.Top = pictureBox25.Top;
        }

        private void MaintenanceBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            StudentlistPanel.Visible = false;
            MaintenancePanel.Visible = true;
            panel5.Height = pictureBox29.Height;
            panel5.Top = pictureBox29.Top;
        }


        #endregion
        #region hover effect
        private void pictureBox21_MouseHover(object sender, EventArgs e)
        {
            pictureBox21.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/SECTION2.jpg");
        }
        private void pictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox21.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/SECTION.jpg");
        }
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/TUITION2.jpg");
        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/TUITION.jpg");
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/MISC2.jpg");
        }
        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/MISC.jpg");
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/OTHERFEES2.jpg");
        }
        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/OTHERFEES.jpg");
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/DISCOUNTS2.jpg");
        }
        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/DISCOUNTS.jpg");
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/VOUCHER2.jpg");
        }
        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/VOUCHER.jpg");
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            pictureBox14.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/USER2.jpg");
        }
        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/USER.jpg");
        }

        private void pictureBox20_MouseHover(object sender, EventArgs e)
        {
            pictureBox20.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/TEACHERS2.jpg");
        }
        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/TEACHERS.jpg");
        }

        private void pictureBox19_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/STRAND2.jpg");
        }
        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/STRAND.jpg");
        }

        private void pictureBox18_MouseHover(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/ROOMS2.jpg");
        }
        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/ROOMS.jpg");
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/SCHEDULE2.jpg");
        }
        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/SCHEDULE.jpg");
        }

        private void pictureBox17_MouseHover(object sender, EventArgs e)
        {
            pictureBox17.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/SCHOOLYEAR2.jpg");
        }
        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/SCHOOLYEAR.jpg");
        }

        private void pictureBox15_MouseHover(object sender, EventArgs e)
        {
            pictureBox15.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/SUBJECT2.jpg");
        }
        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "/Icons/SUBJECT.jpg");
        }
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
                    dgvSearch.DataSource = dt;

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

            chart3.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart3.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            this.chart3.Series["Performance"].Points.AddXY("STEM", 97);
            this.chart3.Series["Performance"].Points.AddXY("HUMSS", 95);
            this.chart3.Series["Performance"].Points.AddXY("ABM", 96);
            this.chart3.Series["Performance"].Points.AddXY("TVL", 93);
            this.chart3.Series["Performance"].Points.AddXY("TOURISM", 90);
            this.chart3.Series["Performance"].Points.AddXY("REAL ESTATE", 0);
            this.chart3.Series["Performance"].Points.AddXY("ACCOUNTANCY", 0);

            #region removal of unneccessary header
            this.dgvSearch.Columns["id"].Visible = false;
            this.dgvSearch.Columns["IDNo"].Visible = false;
            this.dgvSearch.Columns["regNo"].Visible = false;
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
            this.dgvSearch.Columns["sy_enrolled"].Visible = false;
            this.dgvSearch.Columns["1"].Visible = false;
            this.dgvSearch.Columns["2"].Visible = false;
#endregion
            #region header name fix
            dgvSearch.Columns["LRN"].HeaderText = "LRN";
            dgvSearch.Columns["last_name"].HeaderText = "Last Name";
            dgvSearch.Columns["first_name"].HeaderText = "First Name";
            dgvSearch.Columns["middle_name"].HeaderText = "Middle Name";
            dgvSearch.Columns["grade_Level"].HeaderText = "Grade Level";
            dgvSearch.Columns["section"].HeaderText = "Section";
            dgvSearch.Columns["track"].HeaderText = "Track";
            dgvSearch.Columns["strand"].HeaderText = "Strand";
            #endregion
            #region designing DVG
            dgvSearch.BorderStyle = BorderStyle.None;
            dgvSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSearch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSearch.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvSearch.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSearch.BackgroundColor = Color.White;

            dgvSearch.EnableHeadersVisualStyles = false;
            dgvSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 150, 179);
            dgvSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            #endregion

        }



        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            
            dispanel.Visible = true;
            frmRegistration frm = new frmRegistration();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            
           

            dispanel.Controls.Add(frm);

            frm.Show();
            StudentlistPanel.Visible = false;
  
            Dashboardpanel.Visible = false;



        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            
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
            StudentlistPanel.Visible = true;
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
    }


        
      
    }
    

