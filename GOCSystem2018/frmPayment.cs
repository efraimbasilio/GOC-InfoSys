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

        public string amount_per_month, payment_status, full_name, voucher_info;
        public double fee_for_reservation, total_tuition, voucher_amount, down_payment;
        public int payment_no;
        public string reg_no, enroll_status;

        public string amountToPay, paymentFor, GOCNo, ctrpay,  DP, voucherInfo, reservationFee, paymentNo, toCheckGOCNo;
        public double  TotalMiscFee, TotalOtherFee, AmountGiven, BalancePartial , perMonthFee;
        public int count = 1;
        public int  DPCheck;
        public string OrNo, PayNum;

        /***********************************************************************************/
        /*PUBLIC Methods*/
        /**********************************************************************************/
        public void Render()
        {
            GetPerMonth();// paymernt history to dgv 
            lblAmount_Due.Text = fee_for_reservation.ToString("n");
        }

        //PAYMENT - ENROLLMENT STATUS
        public void EnrollmentStatus()
        {
            //clear list
            billingPartials.Clear();
            //pass value to list

            billingPartial.RegNo = reg_no;
            billingPartials = billingPartial.GetPaymentPartial();

            //loop through load it to list view
            foreach (var item in billingPartials)
            {
                enroll_status = item.EnStatus;
                //MessageBox.Show("sadas");
            }
        }

        public void GetPerMonth()
        {
            //clear list
            billingPartials.Clear();
            //pass value to list                    
            billingPartial.RegNo = reg_no;
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

                dgvPerMonth.Rows.Add("Down Payment" , "Down Payment", item.DownPayment);
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
        } //Display the Amount per month
        
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
        }//StudNoGenerate

        public void CountPayment()
        {
            //clear list
            bills.Clear();
            //pass value
            bill.StudentId = GOCNo;
            bills = bill.GetPaymentNo();

            foreach (var item in bills)
            {
                count = 1 + Convert.ToInt32(item.PaymentNo);
                //MessageBox.Show(count.ToString());
            }                
        } //count the payments

        public void GetDownPayment() // get the downpayment 
        {
            //clear list
            vouchers.Clear();
            //pass value to list
            voucher.VoucherFrom = voucher_info.ToString();
            vouchers = voucher.GetDownpaymnet();

            //loop through load it to list view
            foreach (var item in vouchers)
            {                
               down_payment = Convert.ToDouble(item.DpAmount);                                    
            }
        }

        public void Reservation()
        {
            double ans = 0;
            double balance = 0;
            double perMonth = 0;

            GetDownPayment(); //down_payment           
            AmountGiven = Convert.ToDouble(txtAmountGiven.Text);  //Amount Tendered 
            //voucher_amount depends on voucher

            ans = total_tuition - AmountGiven;
            balance = ans - voucher_amount;
            perMonth = 0.00;

            //For reservation 
            billingPartial.RegNo = reg_no;
            billingPartial.IdNo = GOCNo;
            billingPartial.ORNo = txtORNo.Text;
            billingPartial.Full_name = full_name;

            billingPartial.DownPayment = perMonth.ToString("n"); ;
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

            billingPartial.Balance = balance.ToString("n");
            billingPartial.EnStatus = "Reservee";
            
            billingPartial.Save();   
                 
            this.Hide();
            this.Dispose();         
        } //Computation and Saving the record to Billing Partial

        public void PartialNoReserve()
        {           
            if (payment_status.Equals("PARTIAL PAYMENT") && payment_no == 0)// magbabayad palang for FIRST payment - no reservation
            {
                #if PARTIALPAYMENT_FIRST_PAYMENT_NO_RESERVATION
                AmountGiven = Convert.ToDouble(txtAmountGiven.Text); //Convert to Double               

                if (AmountGiven > Convert.ToDouble(fee_for_reservation))//kapag mas malaki ang binigay na amount kaysa initial reservation fee this will be then divide to 10
                {
                    #region PARTIAL PAYMENT - NO RESERVATION                                 
                    //madidivide ang tutiton sa 10
                    total_tuition = total_tuition - AmountGiven;
                    total_tuition = total_tuition - voucher_amount;
                    total_tuition = total_tuition / 10;

                    StudNoGenerate(); // Generate StudNo
                    CountPayment(); // Count the payment
                    bill.AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
                    bill.OrNo = txtORNo.Text;
                    bill.StudentId = GOCNo;
                    bill.RegNo = reg_no;
                    bill.PaymentNo = count.ToString();
                    bill.MOP = "Partial Payment " + count;
                    bill.Save();

                    //Update the GOC Number in Studprofile Table
                    studProfile.StudRegistrationNo = reg_no;
                    studProfile.StudGOCNo = GOCNo;
                    studProfile.Reservee = "0";
                    studProfile.SaveGOCNumber(); //update GOC number in the student profile table

                    //For reservation - Public Voucher            
                    billingPartial.IdNo = GOCNo;
                    billingPartial.ORNo = txtORNo.Text;
                    billingPartial.Full_name = full_name;

                    billingPartial.DownPayment = Convert.ToDouble(DP).ToString("n");

                    billingPartial.P1 = total_tuition.ToString("n");
                    billingPartial.P2 = total_tuition.ToString("n");
                    billingPartial.P3 = total_tuition.ToString("n");
                    billingPartial.P4 = total_tuition.ToString("n");
                    billingPartial.P5 = total_tuition.ToString("n");
                    billingPartial.P6 = total_tuition.ToString("n");
                    billingPartial.P7 = total_tuition.ToString("n");
                    billingPartial.P8 = total_tuition.ToString("n");
                    billingPartial.P9 = total_tuition.ToString("n");
                    billingPartial.P10 = total_tuition.ToString("n");

                    Double sum = 0;
                    sum = Convert.ToDouble(billingPartial.P1) + Convert.ToDouble(billingPartial.P2) + Convert.ToDouble(billingPartial.P3) + Convert.ToDouble(billingPartial.P4) + Convert.ToDouble(billingPartial.P5) + Convert.ToDouble(billingPartial.P6) + Convert.ToDouble(billingPartial.P7) + Convert.ToDouble(billingPartial.P8) + Convert.ToDouble(billingPartial.P9) + Convert.ToDouble(billingPartial.P10);
                    billingPartial.Balance = sum.ToString("n");
                    billingPartial.EnStatus = "Enrolled";
                    billingPartial.RegNo = reg_no;

                    billingPartial.Save();

                    this.Hide();
                    this.Dispose();
                    #endregion
                }

                else if (AmountGiven < Convert.ToDouble(fee_for_reservation))//mas maliit  sa initial reservation fee this will be tag as reservation fee
                {
                    string message = "The Minimum amount for Reservation is :" + fee_for_reservation +" Pesos.";
                    string title = "GOC_INFO_SYS";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }

                else if (AmountGiven == Convert.ToDouble(fee_for_reservation))// this will be tag as reservation fee
                {
                    string message = "The amount given is for Reservation Fee Only.\n Do you want to proceed to Reservation?";
                    string title = "GOC_INFO_SYS";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)//responce
                    {
#region RESERVATION ONLY
                        // Generate StudNo
                        StudNoGenerate();
                        // Count the payments
                        CountPayment();

                        bill.StudentId = GOCNo;
                        bill.RegNo = reg_no;
                        //Convert amount given
                        bill.AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
                        //tag for the OR number
                        bill.OrNo = txtORNo.Text;
                        //count the payment number                    
                        bill.PaymentNo = count.ToString();
                        //tag for the payment Status
                        bill.MOP = "Reservation Fee";
                        //save for the billing OR table
                        bill.Save();

                        //********************************************************************************//
                        //Update the GOC Number in Studprofile Table
                        studProfile.StudRegistrationNo = reg_no;
                        studProfile.StudGOCNo = GOCNo;

                        studProfile.Reservee = "0";//update the status

                        //update GOC number in the student profile table
                        studProfile.SaveGOCNumber();

                        Reservation();//Computation per month and Balance
#endregion
                    }
                    else
                    {
                        return;
                    }                    
                }
                                 #endif
            }
            
            else
            {
                return;
            }
        }

        /***********************************************************************************/
        /*Private Methods*/
        /**********************************************************************************/

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lblTheAmount.Text = reservationFee;
        }

        //For billing
        private void button1_Click(object sender, EventArgs e)
        {         
            if (payment_status.Equals("RESERVATION"))
            {
                 #region RESERVATION - ASSESSMENT - RESERVE
                            ///Allow Student to pay the exact amount of the reservation fee or else student cannot reserve
                            if (fee_for_reservation == Convert.ToDouble(txtAmountGiven.Text))
                            {
                                // Generate StudNo
                                StudNoGenerate();
                                // Count the payments
                                CountPayment();

                                bill.StudentId = GOCNo;
                                bill.RegNo = reg_no;
                                //Convert amount given
                                bill.AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
                                //tag for the OR number
                                bill.OrNo = txtORNo.Text;
                                //count the payment number                    
                                bill.PaymentNo = count.ToString();
                                //tag for the payment Status
                                bill.MOP = "Reservation Fee";
                                //save for the billing OR table
                                bill.Save();

                                //********************************************************************************//
                                //Update the GOC Number in Studprofile Table
                                studProfile.StudRegistrationNo = reg_no;
                                studProfile.StudGOCNo = GOCNo;

                                studProfile.Reservee = "0";//update the status

                                //update GOC number in the student profile table
                                studProfile.SaveGOCNumber();

                                Reservation();//Computation per month and Balance
                            }
                            else
                            {
                                MessageBox.Show("Please pay the exact reservation fee", "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
            #endregion
            }
            else if (payment_status.Equals("PARTIAL PAYMENT"))
            {
                PartialNoReserve();
            }

            else if (payment_status.Equals("PARTIAL PAYMENT") && enroll_status.Equals("Reservee") && payment_no >= 1) //MAGBABAYAD NG 2nd Payment
            {
                MessageBox.Show("PAY");
                if (Convert.ToDouble(lblAmount_Due.Text) == Convert.ToDouble(txtAmountGiven.Text))
                {
                    #region EXACT PAYMENT

                    double sum2 = 0;
                    double result1 = (Convert.ToDouble(lblAmount_Due.Text) - Convert.ToDouble(txtAmountGiven.Text));

                    for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
                    {
                        sum2 += (Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value));

                        if (i < (Convert.ToInt32(lblpayNumber.Text)))
                        {
                            if (result1 < perMonthFee)
                            {
                                dgvPerMonth.Rows[i].Cells[2].Value = 0.00;
                            }
                        }
                    }
                    #endregion
                }
            }
        }
        
                      
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (fee_for_reservation == Convert.ToDouble(txtAmountGiven.Text))
            {
              //  StudNoGenerate(); // Generate StudNo
               // CountPayment(); // Count the payment
                bill.AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
                bill.OrNo = txtORNo.Text;
                bill.StudentId = GOCNo;
                bill.RegNo = reg_no;
                bill.PaymentNo = count.ToString();
                bill.MOP = "Reservation Fee";
                bill.Save();

                //Update the GOC Number in Studprofile Table
                studProfile.StudRegistrationNo = reg_no;
                studProfile.StudGOCNo = GOCNo;
                studProfile.Reservee = "0";
                studProfile.SaveGOCNumber(); //update GOC number in the student profile table

             //   Reservation();
            }


            //GetDownPayment();
            //BalancePartial;
            double ans = 0;
            double perMonth = 0;
            AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
            //Total Tuition Fee
            //MessageBox.Show(TotalTuition.ToString("n") + "Total Tuitionfee");
            ans = total_tuition - AmountGiven;           
            voucher_amount = ans - voucher_amount;
            voucher_amount = voucher_amount - Convert.ToDouble(DP);
            
            perMonth = 0;

            //For reservation - Public Voucher            
            billingPartial.IdNo = GOCNo;
            billingPartial.ORNo = txtORNo.Text;
            billingPartial.Full_name = full_name;
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
            billingPartial.Balance = voucher_amount.ToString("n");
            billingPartial.EnStatus = "Reservee";
            billingPartial.RegNo = reg_no;

            billingPartial.Save();
                        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
