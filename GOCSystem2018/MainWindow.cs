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
            studprofpanel.Visible = false;
            StudentlistPanel.Visible = false;
            MaintenancePanel.Visible = false;
            panel5.Height = pictureBox23.Height;
            panel5.Top = pictureBox23.Top;
        }

        private void EnrollmentBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            studprofpanel.Visible = true;
            StudentlistPanel.Visible = false;
            MaintenancePanel.Visible = false;
            panel5.Height = pictureBox24.Height;
            panel5.Top = pictureBox24.Top;
        }

        private void StudlistBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            studprofpanel.Visible = false;
            StudentlistPanel.Visible = true;
            MaintenancePanel.Visible = false;
            panel5.Height = pictureBox25.Height;
            panel5.Top = pictureBox25.Top;
        }

        private void MaintenanceBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            studprofpanel.Visible = false;
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
            frmRegistration frm = new frmRegistration();
            

            frm.Show();



            StudentlistPanel.Visible = false;
            MaintenancePanel.Visible = false;
            studprofpanel.Visible = false;
            Dashboardpanel.Visible = true;



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
            l.ForeColor = Color.Gray;
            l.BackColor = Color.Transparent;
            l.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            l.Location = new Point(start + (2 * 150), end);

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
            lsn.Location = new Point(start + (4 * 150), end);
            return lsn;
        }
        Label addLabel3(int i, int start, int end, int start2, int end2)
        {
            Label lsection = new Label();
            lsection.Name = "ls" + i.ToString();
            lsection.Text = "label" + i.ToString();
            lsection.ForeColor = Color.Gray;
            lsection.BackColor = Color.Transparent;
            lsection.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            lsection.Location = new Point(start + (5 * 150), end);
            return lsection;
        }
        Label addLabel4(int i, int start, int end, int start2, int end2)
        {
            Label lgrade = new Label();
            lgrade.Name = "lg" + i.ToString();
            lgrade.Text = "label" + i.ToString();
            lgrade.ForeColor = Color.Gray;
            lgrade.BackColor = Color.Transparent;
            lgrade.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            lgrade.Location = new Point(start + (3 * 150), end);
            return lgrade;
        }

        Label addLabel5(int i, int start, int end, int start2, int end2)
        {
            Label lstrand = new Label();
            lstrand.Name = "lst" + i.ToString();
            lstrand.Text = "label" + i.ToString();
            lstrand.ForeColor = Color.Gray;
            lstrand.BackColor = Color.Transparent;
            lstrand.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            lstrand.Location = new Point(start + 150, end);
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
            MaintenancePanel.Visible = false;
            studprofpanel.Visible = false;

            int startposition = 45;
            int endposition = 18;

            int startposition2 = 26;
            int endposition2 = 186;

            for (int ldc = 0; ldc< dgvSearch.Rows.Count ; ldc++)
            {
                //PictureBox spb = studPicturebox(ldc, startposition, endposition, startposition2, endposition2);
                Panel ph = placeHolder(ldc, startposition, endposition, startposition2, endposition2);
                String FullName = dgvSearch.Rows[ldc].Cells[9].FormattedValue.ToString() + ", " + dgvSearch.Rows[ldc].Cells[10].FormattedValue.ToString() + " " + dgvSearch.Rows[ldc].Cells[10].FormattedValue.ToString();

                Label l = addLabel(ldc, startposition, endposition, FullName);
                Label l2 = addLabel2(ldc, startposition, endposition, startposition2, endposition2, dgvSearch.Rows[ldc].Cells[2].FormattedValue.ToString());
                Label l3 = addLabel3(ldc, startposition, endposition, startposition2, endposition2);
                Label l4 = addLabel4(ldc, startposition, endposition, startposition2, endposition2);
                Label l5 = addLabel5(ldc, startposition, endposition, startposition2, endposition2);
                //Label l6 = addLabel6(ldc, startposition, endposition, startposition2, endposition2);
                StudentlistPanel.Controls.Add(ph);
                ph.Controls.Add(l);
                ph.Controls.Add(l2);
                ph.Controls.Add(l3);
                ph.Controls.Add(l4);
                ph.Controls.Add(l5);
               // ph.Controls.Add(spb);
                //ph.Controls.Add(l6);
                //endposition += 40;
                endposition2 += 64;
            }
        }

        //search in the student list************************************************************************************************************
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //listBox2.Items.Clear();
            
            for(int sfilter = 0; sfilter < dgvSearch.Rows.Count; sfilter++)
            {
                if (dgvSearch.SelectedCells[sfilter].Value.ToString().Contains(textBox1.Text))
                {
                    //listBox2.Items.Add(listBox1.Items[sfilter]);
                }
            }
        }
        //*************************t************************************************************************************************************
        private void button1_Click_1(object sender, EventArgs e)
        {
            for(int a = 0; a < dgvSearch.Rows.Count; a++)
            {
                
                Label li = this.Controls.Find("li" + a.ToString(), true).FirstOrDefault() as Label;
               
                Label lsn = this.Controls.Find("lsn" + a.ToString(), true).FirstOrDefault() as Label;
               
                Label ls = this.Controls.Find("ls" + a.ToString(), true).FirstOrDefault() as Label;
                
                Label lg = this.Controls.Find("lg" + a.ToString(), true).FirstOrDefault() as Label;
            
                Label ll = this.Controls.Find("ll" + a.ToString(), true).FirstOrDefault() as Label;

                Label lst = this.Controls.Find("lst" + a.ToString(), true).FirstOrDefault() as Label;
                //panel8.Controls.Remove(li);
                //li.Dispose();
                //panel8.Controls.Remove(lsn);
                //lsn.Dispose();
                //panel8.Controls.Remove(ll);
                //ll.Dispose();
                //panel8.Controls.Remove(lg);
                //lg.Dispose();
                //panel8.Controls.Remove(lst);
                //lst.Dispose();
                //panel8.Controls.Remove(ls);
                //ls.Dispose();

            }
            
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                StudentlistPanel.Visible = true;
                //listBox2.Items.Clear();

                for (int sfilter = 0; sfilter < dgvSearch.Rows.Count; sfilter++)
                {
                    if (dgvSearch.SelectedCells[sfilter].Value.ToString().Contains(searchtxt.Text))
                    {
                        //listBox2.Items.Add(listBox1.Items[sfilter]);
                    }
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            StudentlistPanel.Visible = false;
            MaintenancePanel.Visible = false;
            studprofpanel.Visible = false;
            Dashboardpanel.Visible = true;
           
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            MaintenancePanel.Visible = true;
            studprofpanel.Visible = false;
            StudentlistPanel.Visible = false;
            Dashboardpanel.Visible = false;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }
    }
    }

