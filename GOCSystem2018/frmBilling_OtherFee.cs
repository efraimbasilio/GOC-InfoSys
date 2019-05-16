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
    public partial class frmBilling_OtherFee : Form
    {
        #region Models
        /***********************************************************************************/
        /*Instantiate MODELS*/
        /**********************************************************************************/
        Assesment assesment = new Assesment();
        Registration registration = new Registration();
        Section section = new Section();
        Strand strand = new Strand();
        SchoolYear schoolYear = new SchoolYear();
        Subject subject = new Subject();
        Schedule schedule = new Schedule();
        Models.TuitionFee tuitionFee = new Models.TuitionFee();
        MiscFee miscfee = new MiscFee();
        OtherFee otherFee = new OtherFee();
        Voucher voucher = new Voucher();
        Grading grade = new Grading();
        Billing_Partial billingPartial = new Billing_Partial();
        StudentProfile studProfile = new StudentProfile();
        Billing bill = new Billing();
        StudentProfile studentProfile = new StudentProfile();

        List<Models.TuitionFee> tuitionFees = new List<Models.TuitionFee>();
        List<Section> sections = new List<Section>();
        List<Strand> strands = new List<Strand>();
        List<Assesment> assesments = new List<Assesment>();
        List<SchoolYear> schoolYears = new List<SchoolYear>();
        List<Subject> subjects = new List<Subject>();
        List<Schedule> schedules = new List<Schedule>();
        List<MiscFee> miscFees = new List<MiscFee>();
        List<OtherFee> otherFees = new List<OtherFee>();
        List<Voucher> vouchers = new List<Voucher>();
        List<Grading> grades = new List<Grading>();
        List<Billing_Partial> billingPartials = new List<Billing_Partial>();
        List<StudentProfile> studProfiles = new List<StudentProfile>();
        List<Billing> bills = new List<Billing>();
        List<StudentProfile> studentProfiles = new List<StudentProfile>();

        frmBilling frmBilling = new frmBilling();

        public string amount_per_month, payment_status, full_name, voucher_info;
        public double fee_for_reservation, total_tuition, voucher_amount, down_payment, amount_due;
        public int payment_no;
        public string reg_no, enroll_status;

        public string amountToPay, paymentFor, GOCNo, ctrpay, DP, voucherInfo, reservationFee, paymentNo, toCheckGOCNo;
        public double TotalMiscFee, TotalOtherFee, AmountGiven, BalancePartial, perMonthFee;

        public string S_LRN, S_GOC, S_NAME, S_PAYFOR, S_AMOUNT;
        public bool toSave = true;

        public bool toOtherFees = true;
        #endregion

        //public string GOCNo, GLEVEL;
        public string GLEVEL;
        public int count = 1;
        public int DPCheck;
        public string OrNo, PayNum;


        public frmBilling_OtherFee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                     
            double total = 0;
            total = Convert.ToDouble(txtTuitionFee.Text) + Convert.ToDouble(txtUniform.Text) + Convert.ToDouble(txtBooks.Text) + Convert.ToDouble(txtLocker.Text);
            lblAmount_Due.Text = total.ToString("n");
        }

        private void txtTuitionFee_Leave(object sender, EventArgs e)
        {
                
                txtTuitionFee.Text = string.Format("{0:#,##0.00}", double.Parse(txtTuitionFee.Text));
                //textBox1.Text = string.Format("{0:#,##0.00}", double.Parse(textBox1.Text));
                if (txtAmountGiven.Text == "")
                {
                    string defaultNull = "0";
                    txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(defaultNull));
                }
            
          
        }

        private void txtUniform_Leave(object sender, EventArgs e)
        {
            txtUniform.Text = string.Format("{0:#,##0.00}", double.Parse(txtUniform.Text));
            if (txtAmountGiven.Text == "")
            {
                string defaultNull = "0";
                txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(defaultNull));
            }
        }

        private void txtBooks_Leave(object sender, EventArgs e)
        {
            txtBooks.Text = string.Format("{0:#,##0.00}", double.Parse(txtBooks.Text));
            if (txtAmountGiven.Text == "")
            {
                string defaultNull = "0";
                txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(defaultNull));
            }
        }

        private void txtLocker_Leave(object sender, EventArgs e)
        {
            txtLocker.Text = string.Format("{0:#,##0.00}", double.Parse(txtLocker.Text));
            if (txtAmountGiven.Text == "")
            {
                string defaultNull = "0";
                txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(defaultNull));
            }

            double total = 0;
            total = Convert.ToDouble(txtTuitionFee.Text) + Convert.ToDouble(txtUniform.Text) + Convert.ToDouble(txtBooks.Text) + Convert.ToDouble(txtLocker.Text);
            lblAmount_Due.Text = total.ToString("n");
        }

        private void txtAmountGiven_Leave(object sender, EventArgs e)
        {

            //txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(txtAmountGiven.Text));

            //if (txtAmountGiven.Text == "")
            //{
            //    string defaultNull = "0";
            //    txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(defaultNull));
            //}
        }

        private void btnOtherFee_Click(object sender, EventArgs e)
        {         
            if (btnOtherFee.Text == "With Other Fees")
            {
                pnlOtherFee.Visible = true;
                btnOtherFee.Text = "&Cancel";
                txtTuitionFee.Focus();
                txtTuitionFee.SelectAll();
            }
            else
            {
                pnlOtherFee.Visible = false;
                btnOtherFee.Text = "With Other Fees";
                txtTuitionFee.Text = "0.00";
                txtUniform.Text = "0.00";
                txtBooks.Text = "0.00";
                txtLocker.Text = "0.00";
            }

            
        }

        private void txtTuitionFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtUniform_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBooks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLocker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtORNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAmountGiven_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAmountGiven_Enter(object sender, EventArgs e)
        {
            txtAmountGiven.SelectAll();
        }

        private void txtAmountGiven_Click(object sender, EventArgs e)
        {
            txtAmountGiven.SelectAll();
        }

        private void frmBilling_OtherFee_Load(object sender, EventArgs e)
        {
            txtTuitionFee.Text = "0.00";
            txtUniform.Text = "0.00";
            txtBooks.Text = "0.00";
            txtLocker.Text = "0.00";
            lblAmount_Due.Text = "";
        }

        private void txtTuitionFee_Click(object sender, EventArgs e)
        {
            txtTuitionFee.SelectAll();
        }

        private void txtUniform_Click(object sender, EventArgs e)
        {
            txtUniform.SelectAll();
        }

        private void txtBooks_Click(object sender, EventArgs e)
        {
            txtBooks.SelectAll();
        }

        private void txtLocker_Click(object sender, EventArgs e)
        {
            txtLocker.SelectAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (toOtherFees == true)
            {
                if (Convert.ToDouble(txtAmountGiven.Text) < Convert.ToDouble(lblAmount_Due.Text))
                {
                    MessageBox.Show("Please check the payment", "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Billing_Other_Fees fee = new Billing_Other_Fees();
                    fee.GocNumber = GOCNo;
                    fee.OrNo = txtORNo.Text;
                    fee.GLevel = GLEVEL;
                    fee.Uniform = txtUniform.Text;
                    fee.Books = txtBooks.Text;
                    fee.Locker = txtLocker.Text;

                    fee.Save();
                }
            }
            else//for Enrollment Fees
            {

            }
        }
        
    }
}
