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

        public string amountToPay, paymentFor, GOCNo, ctrpay, FullName, RegNo, DP, voucherInfo, reservationFee, paymentNo, toCheckGOCNo;
        public double TotalTuition, TotalMiscFee, TotalOtherFee, VoucherAmount, AmountGiven, BalancePartial , FeeReserve, perMonthFee;
        public int count = 1;

        private bool CheckRequired()
        {
            if (txtORNo.Text == "")
            {                
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    ComputePerMonth();
                    ComputeBalancePayment();
                    SavePayments();

            //studProfile.StudRegistrationNo = RegNo;                            
            bill.StudentId = GOCNo;
            bill.RegNo = RegNo;
            bill.OrNo = txtORNo.Text;
            bill.AmountGiven = Convert.ToDouble(txtAmountGiven.Text);

            CountPayment();
            bill.PaymentNo = count.ToString();

            bill.Save();
        }

       

        public string OrNo,PayNum;

        public string sMonth2 = DateTime.Now.ToString("MM");
        /***********************************************************************************/
        /*Public Methods*/
        /**********************************************************************************/

        public void ComputeBalancePayment()
        {

           // MessageBox.Show(sMonth2);
            double sum1 = 0;
            for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
            {
                sum1 += Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value);
            }
            lblPerMonthAdv.Text = sum1.ToString("n");
        }

        public void ComputePerMonth()
        {                        
            double result = Convert.ToDouble(lblAmountDue.Text) - Convert.ToDouble(txtAmountGiven.Text);
            double sum1 = 0;

            for (int i = 0; i < dgvPerMonth.Rows.Count; i++)// 11 loops
            {
                sum1 += Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value);

                if (i < (Convert.ToInt32(lblpayNumber.Text))- 1)
                {
                    if (result < perMonthFee)
                    {
                        dgvPerMonth.Rows[i].Cells[2].Value = 0.00;
                    }
                }

                //if (i == (Convert.ToInt32(lblpayNumber.Text))
                //{
                //    dgvPerMonth.Rows[i].Cells[2].Value = result;
                //}

                //if (Convert.ToDouble(txtAmountGiven.Text) > sum1 && sum1 < Convert.ToDouble(txtAmountGiven.Text))
                //{
                //    if (result < perMonthFee)
                //    {
                //        dgvPerMonth.Rows[i].Cells[2].Value = 0.00;
                //    }
                //}

                if (i == (Convert.ToInt32(lblpayNumber.Text)) - 1)
                {
                    dgvPerMonth.Rows[i].Cells[2].Value = result;
                }
            }
            // lblPerMonthAdv.Text = sum1.ToString("n");
        }

        public void Render()
        {
            lblAmountDue.Text = amountToPay;
            lblPaymentFor.Text = paymentFor;

            GetPerMonth();

            //June to March SY 
            if (Convert.ToInt32(sMonth2) < 6)
            {
                int result = 0;
                result = Convert.ToInt32(sMonth2) + 8;
                AutoComputePerMonth(result);
            }

            if (Convert.ToInt32(sMonth2) >= 6)
            {
                int result = 0;
                result = Convert.ToInt32(sMonth2) - 4;
                AutoComputePerMonth(result);
            }

           

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

        public void GetPartialBalance()
        {
            //clear list
            billingPartials.Clear();
            //pass value to list
            MessageBox.Show(GOCNo);
            billingPartial.IdNo = GOCNo;
            billingPartials = billingPartial.GetPartialBalance();

            //loop through load it to list view
            foreach (var item in billingPartials)
            {
                double balance, dp = 0;
                balance = Convert.ToDouble(item.Balance);
                dp = Convert.ToDouble(item.DownPayment);

                BalancePartial = balance + dp;
                 MessageBox.Show(BalancePartial.ToString("n"));    
                       
            }
        }//End LoadRecords

        public void GetReserveFee()
        {
            //clear list
            bills.Clear();
            //pass value to list
            MessageBox.Show(GOCNo);
            bill.StudentId = GOCNo;
            bills = bill.GetReserveFee();

            //loop through load it to list view
            foreach (var item in bills)
            {
                FeeReserve = item.AmountGiven;
                Convert.ToDouble(FeeReserve);              
            }
        }//End LoadRecords
        public void CheckGOCNumber()
        {
            //clear list
            studentProfiles.Clear();
            //pass value to list
            MessageBox.Show(GOCNo);
            studentProfile.StudRegistrationNo = RegNo;
            studentProfiles = studentProfile.CheckGOCNo();

            //loop through load it to list view
            foreach (var item in studentProfiles)
            {
                toCheckGOCNo = item.StudGOCNo;
                MessageBox.Show(toCheckGOCNo);


            }
        }//End LoadRecords
        public void GetDownPayment()
        {
            //clear list
            vouchers.Clear();
            //pass value to list
            voucher.VoucherFrom = voucherInfo.ToString();
            vouchers = voucher.GetDownpaymnet();

            //loop through load it to list view
            foreach (var item in vouchers)
            {
                double b =
                b = Convert.ToDouble(item.DpAmount);
                DP = b.ToString("n");
                 MessageBox.Show(DP);           
            }
        }//End LoadRecords

        public void Reservation()
        {
            //if (AmountGiven > Convert.ToDouble(lblAmountDue.Text))//validation for Amount given
            //{
            //    string message = "The amount given is greaterthan the amount to pay,\nReservation Fee: Php" + reservationFee;
            //    string title = "GOC_INFO_SYS";

            //    MessageBoxButtons buttons = MessageBoxButtons.OK;
            //    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

            //    if (result == DialogResult.OK)//responce
            //    {
            //        txtAmountGiven.Focus();
            //        return;
            //    }//ENd responce
            //}
            //else if (AmountGiven < Convert.ToDouble(lblAmountDue.Text))
            //{
            //    MessageBox.Show("Please verify the amount given,\nReservation Fee: Php" + reservationFee, "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtAmountGiven.Focus();
            //    return;
            //}
            //else
            //{                
            //    if (string.IsNullOrWhiteSpace(txtORNo.Text) && string.IsNullOrWhiteSpace(txtAmountGiven.Text))//validate OR
            //    {
            //        MessageBox.Show("Please check the missing details", "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        txtORNo.Focus();
            //        return;
            //    }
            //    else 
            //    {
                    GetDownPayment();
                    //BalancePartial;
                    double ans = 0;
                    double perMonth = 0;
                    AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
                    //Total Tuition Fee
                    //MessageBox.Show(TotalTuition.ToString("n") + "Total Tuitionfee");
                    ans = TotalTuition - AmountGiven;

                    //MessageBox.Show(ans.ToString("n") + "Less amount given");

                    //Compute Voucher
                   // MessageBox.Show(VoucherAmount.ToString("n") + "Voucher Amount");

                    VoucherAmount = ans - VoucherAmount;
                   // MessageBox.Show(VoucherAmount.ToString("n") + "tuition fee - Less Voucher");

                   // MessageBox.Show(DP + "the DP");
                    VoucherAmount = VoucherAmount - Convert.ToDouble(DP);
                   // MessageBox.Show(VoucherAmount + "less DP");
                    perMonth = 0;

                    //For reservation - Public Voucher            
                    billingPartial.IdNo = GOCNo;
                    billingPartial.ORNo = txtORNo.Text;
                    billingPartial.Full_name = FullName;
                    billingPartial.DownPayment = Convert.ToDouble(DP).ToString("n");
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
                    billingPartial.Balance = VoucherAmount.ToString("n");
                    billingPartial.EnStatus = "Reservee";
                    billingPartial.RegNo = RegNo;

                    billingPartial.Save();

                    this.Hide();
                    this.Dispose();
            //    }                
            //}//End validation for Amount given
        }

        public void PartialPayment()
        {            
            double ans = 0;
            double perMonth = 0;
            AmountGiven = Convert.ToDouble(txtAmountGiven.Text); // convert to double
            GetDownPayment();// to get DP amount from DB

            GetPartialBalance();                     
            GetDownPayment();
            GetReserveFee();

            if (AmountGiven <= Convert.ToDouble(DP))//amount is lessthan the amount due
            {
                double result = 0;
                //MessageBox.Show(BalancePartial.ToString("n")+ "Balance");
                result = BalancePartial - AmountGiven;

                //MessageBox.Show(result.ToString("n"));
                
                perMonth = result / 10;
                //MessageBox.Show(perMonth.ToString("n") + "per month");
                                         
                billingPartial.IdNo = GOCNo;
                //MessageBox.Show(GOCNo);

                billingPartial.Balance = result.ToString("n");
                billingPartial.DownPayment = "0";

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
                billingPartial.RegNo = RegNo;
                billingPartial.EnStatus = "Enrolled";
                
                //MessageBox.Show("---to update");
                billingPartial.Update();
            }
            else if(AmountGiven > Convert.ToDouble(DP))//amount given is morethan the amount due
            {
                string message = "Do you want to advance the paymnet?";
                string title = "GOC_INFO_SYS";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);

                if (result == DialogResult.OK)//responce
                {
                    txtAmountGiven.Focus();
                    //check the amount due for first payment
                    //DB field name is 1p and Status is enrolled filter with GOC stud no.
                                       
                    
                 }//ENd responce

                else
                {

                }
            }
        }

        public  void SavePayments()
        {
            billingPartial.IdNo = GOCNo;                                    
            billingPartial.DownPayment = dgvPerMonth.Rows[0].Cells[2].FormattedValue.ToString();
            billingPartial.P1 = dgvPerMonth.Rows[1].Cells[2].FormattedValue.ToString();
            billingPartial.P2 = dgvPerMonth.Rows[2].Cells[2].FormattedValue.ToString();
            billingPartial.P3 = dgvPerMonth.Rows[3].Cells[2].FormattedValue.ToString();
            billingPartial.P4 = dgvPerMonth.Rows[4].Cells[2].FormattedValue.ToString();
            billingPartial.P5 = dgvPerMonth.Rows[5].Cells[2].FormattedValue.ToString();
            billingPartial.P6 = dgvPerMonth.Rows[6].Cells[2].FormattedValue.ToString();
            billingPartial.P7 = dgvPerMonth.Rows[7].Cells[2].FormattedValue.ToString();
            billingPartial.P8 = dgvPerMonth.Rows[8].Cells[2].FormattedValue.ToString();
            billingPartial.P9 = dgvPerMonth.Rows[9].Cells[2].FormattedValue.ToString();
            billingPartial.P10 = dgvPerMonth.Rows[10].Cells[2].FormattedValue.ToString();
            billingPartial.Balance = lblPerMonthAdv.Text;
            

            billingPartial.Update();
            
        }
        public void AutoComputePerMonth(int range)
        {

            //double sum1 = 0;
            //for (int i = 0; i < range; i++)
            //{
            //    sum1 += Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value);
            //}
            //lblPerMonthAdv.Text = sum1.ToString("n");
        }

        public void GetPerMonth()
        {
            //clear list
            billingPartials.Clear();
            //pass value to list                    
            billingPartial.RegNo = RegNo;
            billingPartials = billingPartial.GetMonthlyDue();

            //loop through load it to list view
            foreach (var item in billingPartials)
            {
                //Months will be concat as variables
                string Month_1 = "June      ";
                string Month_2 = "July      ";
                string Month_3 = "August    ";
                string Month_4 = "September ";
                string Month_5 = "October   ";
                string Month_6 = "November  ";
                string Month_7 = "December  ";
                string Month_8 = "January   ";
                string Month_9 = "February  ";
                string Month_10 = "March   ";

                dgvPerMonth.Rows.Add(" Down Payment", item.DownPayment);

                dgvPerMonth.Rows.Add(Month_1, "1st Payment", item.P1);

                dgvPerMonth.Rows.Add(Month_2, "2nd Payment", item.P2);

                dgvPerMonth.Rows.Add(Month_3, "3rd Payment", item.P3);

                dgvPerMonth.Rows.Add(Month_4, "4th Payment", item.P4);

                dgvPerMonth.Rows.Add(Month_5, "5th Payment", item.P5);

                dgvPerMonth.Rows.Add(Month_6, "6th Payment", item.P6);

                dgvPerMonth.Rows.Add(Month_7, "7th Payment", item.P7);

                dgvPerMonth.Rows.Add(Month_8, "8th Payment", item.P8);

                dgvPerMonth.Rows.Add(Month_9, "9th Payment", item.P9);

                dgvPerMonth.Rows.Add(Month_10, "10th Payment", item.P10);

                perMonthFee = Convert.ToDouble(item.P10);
            }
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

            //if (bills.Count() < 1)
            //{
            //    OrNo = "OR-"+ (1).ToString("0000");
            //    count = 1;               
            //}
            foreach (var item in bills)
            {
                //pass variable to form Assesment
                //ctrpay =
                count = 1 + Convert.ToInt32(item.PaymentNo);
                MessageBox.Show(count.ToString());
                //MessageBox.Show(count.ToString("n")+ "para sa count ng payment");
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {                     
            //string message = "Payment for: "+ lblPaymentFor.Text +", Do you want to proceed the payment?" ;
            //string title = "GOC_INFO_SYS";

            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

            //if (result == DialogResult.Yes)
            //{
            if (txtORNo.Text == "")
            {
                //MessageBoxButtons button1 = MessageBoxButtons.OK;
                MessageBox.Show("Please input the OR Number.");
                return;
            }
            else
            {
                if (paymentFor.Equals("Reservation"))
                {
                    CheckGOCNumber();
                    if (toCheckGOCNo.Equals("N/A"))
                    {
                        StudNoGenerate();
                        CountPayment();
                        bill.AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
                        bill.OrNo = txtORNo.Text;
                        bill.StudentId = GOCNo;
                        bill.RegNo = RegNo;
                        bill.PaymentNo = count.ToString();
                        bill.MOP = "Reservation Fee";      
                             
                        bill.Save();

                        //Update GOC Number in Studprofile Table
                        studProfile.StudRegistrationNo = RegNo;
                        studProfile.StudGOCNo = GOCNo;
                        studProfile.Reservee = "0";
                        studProfile.SaveGOCNumber();

                        Reservation();

                        this.Hide();
                        
                    }
                    else
                    {
                        return;
                    }   
                                                      
                   
                }
                else if (paymentFor.Equals("Downpayment"))
                {
                    if (Convert.ToInt32(paymentNo) >= 1)
                    {
                        bill.AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
                        bill.OrNo = txtORNo.Text;
                        bill.StudentId = GOCNo;
                        bill.RegNo = RegNo;
                        bill.MOP = "Enrolled";
                        CountPayment();
                        bill.PaymentNo = count.ToString();                       
                        bill.Save();

                        //update MOP partial triggered to 1
                        studProfile.StudRegistrationNo = RegNo;
                        studentProfile.PartialPayment = "1";

                        studProfile.UpdateMOP();
                    }
                    PartialPayment();

                }
                else if (paymentFor.Equals("1st Payment"))
                {
                    if (Convert.ToInt32(paymentNo) > 1)
                    {
                        bill.AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
                        bill.OrNo = txtORNo.Text;
                        bill.StudentId = GOCNo;
                        studProfile.StudRegistrationNo = RegNo;
                        CountPayment();
                        bill.PaymentNo = count.ToString();
                        bill.Save();


                    }

                    PartialPayment();
                }

                else if (paymentFor.Equals("2nd Payment"))
                {
                    if (Convert.ToInt32(paymentNo) > 1)
                    {
                        bill.AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
                        bill.OrNo = txtORNo.Text;
                        bill.StudentId = GOCNo;
                        studProfile.StudRegistrationNo = RegNo;
                        bill.RegNo = RegNo;
                        CountPayment();
                        bill.PaymentNo = count.ToString();
                        bill.Save();
                    }

                    PartialPayment();
                }

                this.Hide();
                frmBilling frm = new frmBilling();
                frm.LoadBillingHistory();
                frm.Show();
            }                  
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
