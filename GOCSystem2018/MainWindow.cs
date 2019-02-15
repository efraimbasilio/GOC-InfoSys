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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        #region sidebar code
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = true;
            EnrollmentPanel.Visible = false;
            StudentlistPanel.Visible = false;
            MaintenancePanel.Visible = false;
            panel5.Height = pictureBox23.Height;
            panel5.Top = pictureBox23.Top;
        }

        private void EnrollmentBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            EnrollmentPanel.Visible = true;
            StudentlistPanel.Visible = false;
            MaintenancePanel.Visible = false;
            panel5.Height = pictureBox24.Height;
            panel5.Top = pictureBox24.Top;
        }

        private void StudlistBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            EnrollmentPanel.Visible = false;
            StudentlistPanel.Visible = true;
            MaintenancePanel.Visible = false;
            panel5.Height = pictureBox25.Height;
            panel5.Top = pictureBox25.Top;
        }

        private void MaintenanceBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            EnrollmentPanel.Visible = false;
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




        private void LRNtxt_TextChanged(object sender, EventArgs e)
        {
            if (LRNtxt.Text.Equals(""))
            {
                label55.Text = "LRN";
            }
            else
            {
                label55.Text = "";
            }
        }

        private void FNtxt_TextChanged(object sender, EventArgs e)
        {
            if (FNtxt.Text.Equals(""))
            {
                label3.Text = "FIRST NAME";
            }
            else
            {
                label3.Text = "";
            }
        }

        private void MNtxt_TextChanged(object sender, EventArgs e)
        {
            if (MNtxt.Text.Equals(""))
            {
                label4.Text = "MIDDLE NAME";
            }
            else
            {
                label4.Text = "";
            }
        }
        private void LNtxt_TextChanged_1(object sender, EventArgs e)
        {
            if (LNtxt.Text.Equals(""))
            {
                label5.Text = "SURNAME";
            }
            else
            {
                label5.Text = "";
            }
        }

        private void BirthPlacetxt_TextChanged(object sender, EventArgs e)
        {
            if (BirthPlacetxt.Text.Equals(""))
            {
                label110.Text = "BIRTHPLACE";
            }
            else
            {
                label110.Text = "";
            }
        }

        private void Addtxt_TextChanged(object sender, EventArgs e)
        {
            if (Addtxt.Text.Equals(""))
            {
                label64.Text = "ADDRESS";
            }
            else
            {
                label64.Text = "";
            }
        }

        private void MotherTtxt_TextChanged(object sender, EventArgs e)
        {
            if (MotherTtxt.Text.Equals(""))
            {
                label113.Text = "MOTHERTONGUE";
            }
            else
            {
                label113.Text = "";
            }
        }

        private void Ethnicitytxt_TextChanged(object sender, EventArgs e)
        {
            if (Ethnicitytxt.Text.Equals(""))
            {
                label112.Text = "ETHNICITY";
            }
            else
            {
                label112.Text = "";
            }
        }

        private void Reltxt_TextChanged(object sender, EventArgs e)
        {
            if (Reltxt.Text.Equals(""))
            {
                label111.Text = "RELIGION";
            }
            else
            {
                label111.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FNtxt.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MNtxt.Focus();
        }

        private void label110_Click(object sender, EventArgs e)
        {
            BirthPlacetxt.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LNtxt.Focus();
        }

        private void label64_Click(object sender, EventArgs e)
        {
            Addtxt.Focus();
        }

        private void label113_Click(object sender, EventArgs e)
        {
            MotherTtxt.Focus();
        }

        private void label112_Click(object sender, EventArgs e)
        {
            Ethnicitytxt.Focus();
        }

        private void label111_Click(object sender, EventArgs e)
        {
            Reltxt.Focus();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            LRNtxt.Focus();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Me.ScrollControlIntoView(Label6)
            Dashboardpanel.ScrollControlIntoView(label10);
        }

        private void label73_Click(object sender, EventArgs e)
        {
            fathertxt.Focus();
        }

        private void label71_Click(object sender, EventArgs e)
        {
            mothertxt.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            guardiantxt.Focus();
        }

        private void label80_Click(object sender, EventArgs e)
        {
            fcntxt.Focus();
        }

        private void label77_Click(object sender, EventArgs e)
        {
            mcntxt.Focus();
        }

        private void label75_Click(object sender, EventArgs e)
        {
            gcntxt.Focus();
        }

        private void label120_Click(object sender, EventArgs e)
        {
            fotxt.Focus();
        }

        private void label84_Click(object sender, EventArgs e)
        {
            motxt.Focus();
        }

        private void label82_Click(object sender, EventArgs e)
        {
            gotxt.Focus();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.ShowDialog();          
        }
    }
    }

