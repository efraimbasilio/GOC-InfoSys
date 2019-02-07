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
        }

        private void EnrollmentBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            EnrollmentPanel.Visible = true;
            StudentlistPanel.Visible = false;
            MaintenancePanel.Visible = false;
        }

        private void StudlistBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            EnrollmentPanel.Visible = false;
            StudentlistPanel.Visible = true;
            MaintenancePanel.Visible = false;
        }

        private void MaintenanceBtn_Click(object sender, EventArgs e)
        {
            Dashboardpanel.Visible = false;
            EnrollmentPanel.Visible = false;
            StudentlistPanel.Visible = false;
            MaintenancePanel.Visible = true;
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


    
    }
    }

