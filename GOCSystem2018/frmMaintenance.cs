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
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSched frmsched = new frmSched();
            frmsched.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSchoolYear frmSchoolYear = new frmSchoolYear();
            frmSchoolYear.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRoom frmRoom = new frmRoom();
            frmRoom.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser();
            frmUser.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmStrand frmStrand = new frmStrand();
            frmStrand.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmTeacher frmTeacher = new frmTeacher();
            frmTeacher.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmSubject frmSubject = new frmSubject();
            frmSubject.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSection frmSection = new frmSection();
            frmSection.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmNewTuitionFee frmTuition = new frmNewTuitionFee();
            frmTuition.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmNewOtherFee frmOtherFees = new frmNewOtherFee();
            frmOtherFees.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmNewMiscFee frmMiscFees = new frmNewMiscFee();
            frmMiscFees.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNewVoucher frmVoucher = new frmNewVoucher();
            frmVoucher.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Maintenance.frmNewDiscountFee frm = new Maintenance.frmNewDiscountFee();
            frm.ShowDialog();
        }
    }
}
