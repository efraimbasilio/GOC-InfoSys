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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }
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

        public string reservation, paymentFor, GOCNo, ctrpay, FullName,RegNo, DP;
        public double TotalTuition, TotalMiscFee, TotalOtherFee, VoucherType, AmountGiven;
        public int count = 0;
        public string OrNo,PayNum;
        /***********************************************************************************/
        /*Public Methods*/
        /**********************************************************************************/
        public void Render()
        {
            lblAmountDue.Text = reservation;
            lblPaymentFor.Text = paymentFor;
        }

        public void StudNoGenerate()
        {
            int ctrGOCNum = 1;
            //clear list           
            bills.Clear();
            //pass value to list
            //MessageBox.Show(assements.Count().ToString());
            if (bills.Count() < 1)
            {
              
                GOCNo = "GOC-" + DateTime.Today.ToString("yyyy") + "-" + (ctrGOCNum).ToString("0000");
            }

            bills = bill.Load();

            foreach (var item in bills)
            {
                //GOCNo = "GOC-" + DateTime.Today.ToString("yyyy") + "-" + (item.Id + 1).ToString("0000");
                ctrGOCNum = ctrGOCNum + 1;
                GOCNo = "GOC-" + DateTime.Today.ToString("yyyy") + "-" + (ctrGOCNum).ToString("0000");
            }
        }//End LoadRecords() OK

        public void GetDownPayment()
        {
            //clear list
            vouchers.Clear();
            //pass value to list
            voucher.VoucherFrom = VoucherType.ToString();
            vouchers = voucher.GetDownpaymnet();

            //loop through load it to list view
            foreach (var item in vouchers)
            {
                double b =
                b = Convert.ToDouble(item.DpAmount);
                DP = b.ToString("n");
                // MessageBox.Show(lblDownpayment.Text);           
            }
        }//End LoadRecords

        public void Reservation()
        {
            double ans = 0;
            double perMonth = 0;
            AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
            //Total Tuition Fee
            ans = TotalTuition - AmountGiven;
            //Compute Voucher
            VoucherType = ans - VoucherType;
            perMonth = VoucherType / 10;

            //For reservation - Public Voucher            
            billingPartial.IdNo = GOCNo;
            billingPartial.ORNo = txtORNo.Text;
            billingPartial.Full_name = FullName;
            billingPartial.DownPayment = DP;
            billingPartial.P1 = perMonth.ToString("n");
            billingPartial.P2 = perMonth.ToString("n");
            billingPartial.P3 = perMonth.ToString("n");
            billingPartial.P4 = perMonth.ToString("n");
            billingPartial.P5 = perMonth.ToString("n");
            billingPartial.P6 = perMonth.ToString("n");
            billingPartial.P7 = perMonth.ToString("n");
            billingPartial.P8 = perMonth.ToString("n");
            billingPartial.P9 = perMonth.ToString("n");
            billingPartial.P10 = perMonth.ToString("n");
            billingPartial.Balance = VoucherType.ToString("n");
            billingPartial.EnStatus = "Reservee";

            billingPartial.Save();
        }

        public void PartialPayment()
        {
            double ans = 0;
            double perMonth = 0;
            AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
            //Total Tuition Fee
            ans = TotalTuition - AmountGiven;
            //Compute Voucher
            VoucherType = ans - VoucherType;
            perMonth = VoucherType / 10;


            if (AmountGiven < Convert.ToDouble(DP) && AmountGiven < Convert.ToDouble(DP))
            {

            }




            //For reservation - Public Voucher 

            billingPartial.DownPayment = DP;

            billingPartial.IdNo = GOCNo;
            billingPartial.ORNo = txtORNo.Text;
            billingPartial.Full_name = FullName;
           
            billingPartial.P1 = perMonth.ToString("n");
            billingPartial.P2 = perMonth.ToString("n");
            billingPartial.P3 = perMonth.ToString("n");
            billingPartial.P4 = perMonth.ToString("n");
            billingPartial.P5 = perMonth.ToString("n");
            billingPartial.P6 = perMonth.ToString("n");
            billingPartial.P7 = perMonth.ToString("n");
            billingPartial.P8 = perMonth.ToString("n");
            billingPartial.P9 = perMonth.ToString("n");
            billingPartial.P10 = perMonth.ToString("n");
            billingPartial.Balance = VoucherType.ToString("n");
            billingPartial.EnStatus = "Reservee";

            billingPartial.Save();
        }

        /***********************************************************************************/
        /*Private Methods*/
        /**********************************************************************************/
        private void CountPayment()
        {
            //clear list
            bills.Clear();
            //pass value
            bill.StudentId = GOCNo ;
            bills = bill.GetPaymentNo();

            if (bills.Count() < 1)
            {
                OrNo = "OR-"+ (1).ToString("0000");
                count = 1;               
            }
            foreach (var item in bills)
            {
                //pass variable to form Assesment
                //ctrpay =
                count = count + Convert.ToInt32(item.PaymentNo);

            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {                     
            string message = "Payment for: "+ lblPaymentFor.Text +", Do you want to proceed the payment?" ;
            string title = "GOC_INFO_SYS";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                if (txtORNo.Text == "")
                {
                    MessageBoxButtons button1 = MessageBoxButtons.OK;
                    MessageBox.Show("Please input the OR Number.", title, button1, MessageBoxIcon.Warning);
                    return;
                }
                else
                {                    
                    StudNoGenerate();
                    CountPayment();
                  
                    bill.AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
                    bill.OrNo = txtORNo.Text;
                    bill.StudentId = GOCNo;                   
                    bill.PaymentNo = count.ToString();
                    bill.Save();

                    //Update GOC Number in Studprofile Table
                    studProfile.StudRegistrationNo = RegNo;
                    studProfile.StudGOCNo = GOCNo;
                    studProfile.SaveGOCNumber();

                    ///////////////////////////////////////////////////to pull out vouchers from maintenanace voucher
                    ///working to filter voucher pri and pub 
                    if (paymentFor.Equals("Reservation"))
                    {
                        Reservation();
                    }                                 
                    this.Dispose();
                }               
            }
            else
            {
                return;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
