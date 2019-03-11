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
    public partial class frmBilling : Form
    {
        /***********************************************************************************/
        /*PUBLIC VARIABLES*/
        /**********************************************************************************/
        public double TotalTuition, TotalMiscFee, TotalOtherFee, GrantFee;
        public string LRN, StudID, StudName, GradeLevel, Track,Strand, Semester, MOP, SY, VoucherType, RegNo;

       

        /***********************************************************************************/
        /*PUBLIC METHOD*/
        /**********************************************************************************/
        public void Render()
        {
            //pass value from billing search
            lblLRN.Text = LRN;
            lblGOCNo.Text = StudID;
            lblName.Text = StudName;
            lblGradeLevel.Text = GradeLevel;                        
            lblTrack.Text = Track;
            lblStrand.Text = Strand;
            lblRegNo.Text = RegNo;

            lblVoucher.Text = VoucherType;
        }
        /***********************************************************************************/
        /*PRIVATE METHOD*/
        /**********************************************************************************/

        /***********************************************************************************/
        /*PRINTING METHOD*/
        /**********************************************************************************/

        public frmBilling()
        {
            InitializeComponent();
        }
        /*************************************************************************************/
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmBillingSearch billSearch = new frmBillingSearch();
            billSearch.Show();
        }

        private void cmbPaymentFor_SelectedValueChanged(object sender, EventArgs e)
        {
            frmPayment toPay = new frmPayment();
            //if (cmbPaymentFor.SelectedItem.Equals(""))
            //{
                toPay.ShowDialog();
            //}
        }

    }
}
