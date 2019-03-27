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
    public partial class frmBilling : Form
    {
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
        List<Billing> billings = new List<Billing>();

        /***********************************************************************************/
        /*PUBLIC VARIABLES*/
        /**********************************************************************************/
       
        public string LRN, StudID, StudName, GradeLevel, Track,Strand, Semester, MOP, SY, VoucherType, RegNo, DP;
        public int CTRpayment,perMonthRange;
        public double BalancePartial;
        int MonthNumber = 0;
        public string partialCTR;

        public string sMonth2 = DateTime.Now.ToString("MM");
       

        /***********************************************************************************/
        /*PUBLIC METHOD*/
        /**********************************************************************************/
        public void LoadTuitionFee()
        {
            //clear list
           tuitionFees.Clear();
            //pass value to list
            tuitionFees = tuitionFee.Load();
            
            //loop through load it to list view
            foreach (var item in tuitionFees)
            {
                if (item.Status.Equals("1"))
                {
                    double a;
                    a = Convert.ToDouble(item.TuitionFeeAmount);
                    lblTuition.Text = a.ToString("n");
                }
            }
        }//End LoadRecords

        public void CallPaymentNumber()
        {
            //clear list
            billings.Clear();
            //pass value to list
            billings = bill.Load();

            //loop through load it to list view
            foreach (var item in billings)
            {
                txtPayNumber.Text = item.PaymentNo;
            }
        }//End LoadRecords
       
        public void LoadReservationFee()
        {
            //clear list
            tuitionFees.Clear();
            //pass value to list
            tuitionFees = tuitionFee.Load();

            //loop through load it to list view
            foreach (var item in tuitionFees)
            {
                if (item.Status.Equals("1"))
                {
                    double a;
                    a = Convert.ToDouble(item.ReservationFee);
                    lblReserve.Text = a.ToString("n");
                }
            }
        }//End LoadRecords
       
        public void LoadAssesMiscFees()
        {
            
            //clear list                      
            miscFees.Clear();
            //dgvSubjectLoad.Rows.Clear();
            //pass value to list
            miscFees = miscfee.Load();
            double sum1 =0;
            //loop through load it to list view
            foreach (var item in miscFees)
            {
                // dgvSubjectLoad.Rows.Add(item.MiscFeeName, item.MiscFeeAmount);.
                 sum1 =sum1+ Convert.ToDouble(item.MiscFeeAmount);
            }
            // double sum;
            lblTotalMiscFee.Text = sum1.ToString("n");

        }

        public void LoadAssesOtherFees()
        {
            //clear list                      
            otherFees.Clear();
            dgvFeeHistory.Rows.Clear();
            //pass value to list
            otherFees = otherFee.Load();

            //loop through load it to list view
            foreach (var item in otherFees)
            {
                if (item.Strand.Equals(Strand))
                {
                    dgvOtherFees.Rows.Add(item.OtherFeeName, item.OtherFeeAmount);

                    foreach (var item2 in otherFees)
                    {
                        if (item.Strand.Equals("Non-STEM"))
                        {
                            dgvOtherFees.Rows.Add(item2.OtherFeeName, item2.OtherFeeAmount);
                        }
                    }
                }

                if (item.Strand.Equals("Non-STEM"))
                {
                    dgvOtherFees.Rows.Add(item.OtherFeeName, item.OtherFeeAmount);
                }
            }

            double sum = 0;
            for (int i = 0; i < dgvOtherFees.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvOtherFees.Rows[i].Cells[1].Value);
            }
            lblOther.Text = sum.ToString("n");
        }

        public void ComputeVoucher()
        {
            //clear list
            vouchers.Clear();
            //pass value to list
            vouchers = voucher.Load();

            //loop through load it to list view
            foreach (var item in vouchers)
            {
                if (item.VoucherFrom.Equals(VoucherType))
                {
                    double b =
                    b = Convert.ToDouble(item.VoucherAmount);
                    lblVoucherAmount.Text = b.ToString("n");
                }
            }
        }//End LoadRecords

        public void TheTotalTuition()
        {
            double total = Convert.ToDouble(lblTuition.Text) + Convert.ToDouble(lblOther.Text) + Convert.ToDouble(lblTotalMiscFee.Text);
            lblTotalPayment.Text = total.ToString("n");
        }

        public void GetDownPayment()
        {
            //clear list
            vouchers.Clear();
            //pass value to list
            voucher.VoucherFrom = VoucherType;
            vouchers = voucher.GetDownpaymnet();

            //loop through load it to list view
            foreach (var item in vouchers)
            {
                double b =
                b = Convert.ToDouble(item.DpAmount);
                lblDownpayment.Text = b.ToString("n");
                // MessageBox.Show(lblDownpayment.Text); 
                DP = b.ToString("n");

            }
        }//End LoadRecords

        public void ComputePerMonth(int range)
        {
            
           // MessageBox.Show(sMonth2);
            double sum1 = 0;
            for (int i = 0; i < range; i++)
            {
                sum1 += Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value);
            }
            lblPerMonthAdv.Text = sum1.ToString("n");
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment pay = new frmPayment();
            //MessageBox.Show(lblPerMonthAdv.Text);


            // ComputePerMonth(MonthNumber);
            ////pay.GOCNo = lblGOCNo.Text;          

            ////pay.lblpayNumber.Text = perMonthRange.ToString();
            //pay.RegNo = lblRegNo.Text;
            //pay.Render();
            //pay.ShowDialog();

            
            if (lblMOPInfo.Text == "RESERVATION")
            {
                pay.lblTheAmount.Text = lblPerMonthAdv.Text;
                pay.amountToPay = lblReserve.Text;
                pay.FeeReserve = Convert.ToDouble(lblReserve.Text);
               //pay.paymentFor = cmbPaymentFor.SelectedItem.ToString();
                pay.TotalTuition = Convert.ToDouble(lblTotalPayment.Text);
                pay.FullName = lblName.Text;
                pay.voucherInfo = lblVoucher.Text;
                pay.VoucherAmount = Convert.ToDouble(lblVoucherAmount.Text);
                pay.RegNo = lblRegNo.Text;
               

                pay.MOPInfo = lblMOPInfo.Text;

                pay.Render();

                pay.ShowDialog();

            }

            else if (lblMOPInfo.Text == "PARTIAL PAYMENT")
            {
                pay.lblTheAmount.Text = lblPerMonthAdv.Text;
                pay.amountToPay = lblReserve.Text;

                // pay.FeeReserve = Convert.ToDouble(lblReserve.Text);
                //pay.paymentFor = cmbPaymentFor.SelectedItem.ToString();
                //pay.reservationFee = lblReserve.Text;

                pay.reservationFee = lblReserve.Text;
                pay.TotalTuition = Convert.ToDouble(lblTotalPayment.Text);
                pay.FullName = lblName.Text;
                pay.voucherInfo = lblVoucher.Text;
                pay.VoucherAmount = Convert.ToDouble(lblVoucherAmount.Text);
                pay.RegNo = lblRegNo.Text;
                

                pay.MOPInfo = lblMOPInfo.Text;
                pay.Render();
                pay.ShowDialog();

            }

            //else if (cmbPaymentFor.SelectedItem.Equals("Downpayment"))
            //{
            //    pay.amountToPay = DP;//view of payment
            //    //create a maintenance
            //    //for late payment of the downpaymnet
            //    //June = 10;
            //    //July =9;
            //    //aug =8
            //    //sep=7
            //    //oct=6
            //    //nov=5
            //    //dec=4
            //    //jan=3
            //    //feb=2
            //    //march=1

            //    pay.GOCNo = lblGOCNo.Text;
            //    pay.paymentNo = txtPayNumber.Text;
            //    pay.paymentFor = cmbPaymentFor.SelectedItem.ToString();
            //    pay.TotalTuition = Convert.ToDouble(lblTotalPayment.Text);
            //    pay.FullName = lblName.Text;
            //    pay.voucherInfo = lblVoucher.Text;
            //    pay.VoucherAmount = Convert.ToDouble(lblVoucherAmount.Text);
            //    pay.RegNo = lblRegNo.Text;
            //    pay.reservationFee = lblReserve.Text;
            //    pay.BalancePartial = BalancePartial;
            //    pay.Render();
            //    pay.ShowDialog();
            //    pay.amountToPay = lblAmountDue.Text;
            //}


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Checking amount to pay per month
        /// </summary>
        /// <param name="range"></param>
        public void AutoComputePerMonth(int range)
        {
            if (dgvPerMonth.Rows.Count > 1)
            {
                double sum1 = 0;
                for (int i = 0; i < range; i++)
                {
                    sum1 += Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value);
                }
                lblPerMonthAdv.Text = sum1.ToString("n");
            }
            else
            {
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadBillingHistory()
        {
            //clear list
            billings.Clear();
            dgvFeeHistory.Rows.Clear();
            //pass value to list
            bill.StudentId = lblGOCNo.Text;
            billings = bill.GetPaymentHistory();

            //loop through load it to list view
            foreach (var item in billings)
            {
                dgvFeeHistory.Rows.Add(Convert.ToInt32(item.OrNo), item.StudentId, Convert.ToDouble(item.AmountGiven),Convert.ToInt32(item.PaymentNo),item.PaymentDate);
                
            }
        }

       

        /// <summary>
        /// Load Payments
        /// </summary>
        public void GetPerMonth()
        {          
            //clear list
            billingPartials.Clear();
            dgvPerMonth.Rows.Clear();
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

                lblDPCheck.Text = item.DownPayment;

                dgvPerMonth.Rows.Add("", " Down Payment", item.DownPayment);
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

            }                       
        }

        public void LoadPaymentNo()
        {
            //clear list
            billings.Clear();
            //pass value to list
            bill.StudentId = StudID;
            billings = bill.GetPaymentNo();

            //loop through load it to list view
            foreach (var item in billings)
            {
                CTRpayment = Convert.ToInt32(item.PaymentNo);
            }
        }

        public void LoadGetPaymentNo()
        {
            //clear list
            billings.Clear();
            //pass value to list
            
            bill.RegNo = RegNo;
            billings = bill.GetPaymentNo2();

            //loop through load it to list view
            foreach (var item in billings)
            {
                CTRpayment = Convert.ToInt32(item.PaymentNo);
                lblPaymentNoCheck.Text = item.PaymentNo;
                //MessageBox.Show("sadas");
            }
        }

        public void GetPartialBalance()
        {
            //clear list
            billingPartials.Clear();
            //pass value to list
            MessageBox.Show(lblGOCNo.Text);
            billingPartial.IdNo = lblGOCNo.Text;
            billingPartials = billingPartial.GetPartialBalance();

            //loop through load it to list view
            foreach (var item in billingPartials)
            {
                double balance, dp = 0;
                balance = Convert.ToDouble(item.Balance);
                dp = Convert.ToDouble(item.DownPayment);

                BalancePartial = balance + dp;
                MessageBox.Show(BalancePartial.ToString("n"));
                lblBalance.Text = BalancePartial.ToString("n");
                lblAmountDue.Text = dp.ToString("n");
            }
        }//End LoadRecords

        public void Render()
        {

            #region For validating amount due anutomatic per month catching

            //June to March SY 
            if (Convert.ToInt32(sMonth2) < 6)
            {
                
                MonthNumber = Convert.ToInt32(sMonth2) + 8;
                AutoComputePerMonth(MonthNumber);
            }

            
            if (Convert.ToInt32(sMonth2) >= 6)
            {
                
                MonthNumber = Convert.ToInt32(sMonth2) - 4;
                AutoComputePerMonth(MonthNumber);
            }

            #endregion



            if (CTRpayment == 1)
            {
                cmbPaymentFor.Items.Clear();
                cmbPaymentFor.Items.Add("Reservation");
                //cmbPaymentFor.Text = "Reservation";
            }
            else if (CTRpayment == 2)
            {
                cmbPaymentFor.Items.Clear();
                cmbPaymentFor.Items.Add("Downpayment");           
                cmbPaymentFor.Items.Add("1st Payment");
                cmbPaymentFor.Items.Add("2nd Payment");
                cmbPaymentFor.Items.Add("3rd Payment");
                cmbPaymentFor.Items.Add("4th Payment");
                cmbPaymentFor.Items.Add("5th Payment");
                cmbPaymentFor.Items.Add("6th Payment");
                cmbPaymentFor.Items.Add("7th Payment");
                cmbPaymentFor.Items.Add("8th Payment");
                cmbPaymentFor.Items.Add("9th Payment");
                cmbPaymentFor.Items.Add("10th Payment");
            }
            else
            {
                //cmbPaymentFor.Items.Clear();
                //cmbPaymentFor.Items.Add("Full Payment");
                //cmbPaymentFor.Text = "Full Payment";
            }

            //pass value from billing search
            lblLRN.Text = LRN;
            lblGOCNo.Text = StudID;
            lblName.Text = StudName;
            lblGradeLevel.Text = GradeLevel;
            lblTrack.Text = Track;
            lblStrand.Text = Strand;
            lblRegNo.Text = RegNo;
            lblVoucher.Text = VoucherType;
            
            //get tuitionFee
            LoadTuitionFee();
            LoadAssesMiscFees();
            LoadAssesOtherFees();
            ComputeVoucher();
            TheTotalTuition();
            GetDownPayment();
            LoadReservationFee();

            LoadBillingHistory(); //get Billing History
            LoadPaymentNo(); //payment count
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
        private void frmBilling_Load(object sender, EventArgs e)
        {           
            LoadBillingHistory();

            #region designing DVG
            dgvFeeHistory.BorderStyle = BorderStyle.None;
            dgvFeeHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvFeeHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFeeHistory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(166, 176, 236);
            dgvFeeHistory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvFeeHistory.BackgroundColor = Color.White;

            dgvFeeHistory.EnableHeadersVisualStyles = false;
            dgvFeeHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFeeHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(166, 176, 236);
            dgvFeeHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvPerMonth.BorderStyle = BorderStyle.None;
            dgvPerMonth.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPerMonth.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPerMonth.DefaultCellStyle.SelectionBackColor = Color.FromArgb(166, 176, 236);
            dgvPerMonth.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPerMonth.BackgroundColor = Color.White;

            dgvPerMonth.EnableHeadersVisualStyles = false;
            dgvPerMonth.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPerMonth.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(166, 176, 236);
            dgvPerMonth.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            #endregion
        }

        private void cmbMOP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbMOP.SelectedItem.Equals("Partial Payment"))
            {
                string message = "Do you want to proceed to Partial Payment";
                string title = "GOC_INFO_SYS";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.OK)//responce
                {
                    frmPayment toPay = new frmPayment();

                    lblMOPInfo.Text = "PARTIAL PAYMENT";
                    //LoadBillingHistory();

                    LoadGetPaymentNo();

                    if (Convert.ToInt32(lblPaymentNoCheck.Text) > 0)
                    {
                        toPay.DPCheck = Convert.ToInt32(lblPaymentNoCheck.Text);                        
                    }
                    else if(Convert.ToInt32(lblPaymentNoCheck.Text) == 0)//first time to pay
                    {
                        toPay.DPCheck = Convert.ToInt32(lblPaymentNoCheck.Text);
                    }                   
                }
                else
                {
                    return;
                }//ENd responce
                



                //GetPartialBalance();
                //cmbPaymentFor.Items.Clear();
                //cmbPaymentFor.Items.Add("Downpayment");
                //cmbPaymentFor.Items.Add("1st Payment");
                //cmbPaymentFor.Items.Add("2nd Payment");
                //cmbPaymentFor.Items.Add("3rd Payment");
                //cmbPaymentFor.Items.Add("4th Payment");
                //cmbPaymentFor.Items.Add("5th Payment");
                //cmbPaymentFor.Items.Add("6th Payment");
                //cmbPaymentFor.Items.Add("7th Payment");
                //cmbPaymentFor.Items.Add("8th Payment");
                //cmbPaymentFor.Items.Add("9th Payment");
                //cmbPaymentFor.Items.Add("10th Payment");                

            }
            else
            {
                cmbPaymentFor.Items.Clear();
                cmbPaymentFor.Text = "Full Payment";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmBillingSearch billSearch = new frmBillingSearch();
            billSearch.Show();
        }

        /// <summary>
        /// Payment Module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPaymentFor_SelectedValueChanged(object sender, EventArgs e)
        {
            //frmPayment toPay = new frmPayment();

            //if (cmbPaymentFor.SelectedItem.Equals("Reservation"))
            //{
            //    toPay.amountToPay = lblReserve.Text;
            //    toPay.paymentFor = cmbPaymentFor.SelectedItem.ToString();
            //    toPay.TotalTuition = Convert.ToDouble(lblTotalPayment.Text);
            //    toPay.FullName = lblName.Text;
            //    toPay.voucherInfo = lblVoucher.Text;
            //    toPay.VoucherAmount = Convert.ToDouble(lblVoucherAmount.Text);
            //    toPay.RegNo = lblRegNo.Text;
            //    toPay.reservationFee = lblReserve.Text;
            //    toPay.Render();
            //    toPay.ShowDialog();

            //}
            //else if (cmbPaymentFor.SelectedItem.Equals("Downpayment"))
            //{               
            //    toPay.amountToPay = DP;//view of payment
            //    //create a maintenance
            //    //for late payment of the downpaymnet
            //    //June = 10;
            //    //July =9;
            //    //aug =8
            //    //sep=7
            //    //oct=6
            //    //nov=5
            //    //dec=4
            //    //jan=3
            //    //feb=2
            //    //march=1



            //    toPay.GOCNo = lblGOCNo.Text;
            //    toPay.paymentNo = txtPayNumber.Text;
            //    toPay.paymentFor = cmbPaymentFor.SelectedItem.ToString();
            //    toPay.TotalTuition = Convert.ToDouble(lblTotalPayment.Text);
            //    toPay.FullName = lblName.Text;
            //    toPay.voucherInfo = lblVoucher.Text;
            //    toPay.VoucherAmount = Convert.ToDouble(lblVoucherAmount.Text);
            //    toPay.RegNo = lblRegNo.Text;
            //    toPay.reservationFee = lblReserve.Text;

            //    toPay.BalancePartial = BalancePartial;

            //    toPay.Render();
            //    toPay.ShowDialog();
            //    toPay.amountToPay = lblAmountDue.Text;
            //}

            //else if (cmbPaymentFor.SelectedItem.Equals("1st Payment"))
            //{
            //    perMonthRange = 2;
            //    ComputePerMonth(perMonthRange);
            //    toPay.GOCNo = lblGOCNo.Text;
            //    toPay.amountToPay = lblPerMonthAdv.Text;
            //    toPay.RegNo = lblRegNo.Text;

            //    toPay.Render();
            //    toPay.lblpayNumber.Text = perMonthRange.ToString();
            //    toPay.ShowDialog();
                
            //}
            //else if (cmbPaymentFor.SelectedItem.Equals("2nd Payment"))
            //{
            //    perMonthRange = 3;
            //    ComputePerMonth(perMonthRange);
            //    toPay.GOCNo = lblGOCNo.Text;
            //    toPay.RegNo = lblRegNo.Text;
            //    toPay.amountToPay = lblPerMonthAdv.Text;
            //    toPay.lblpayNumber.Text = perMonthRange.ToString();
            //    toPay.Render();

            //    toPay.ShowDialog();
            //}
            //else if (cmbPaymentFor.SelectedItem.Equals("3rd Payment"))
            //{
            //    perMonthRange = 4;
            //    ComputePerMonth(perMonthRange);
            //    toPay.GOCNo = lblGOCNo.Text;
            //    toPay.RegNo = lblRegNo.Text;
            //    toPay.amountToPay = lblPerMonthAdv.Text;
            //    toPay.lblpayNumber.Text = perMonthRange.ToString();
            //    toPay.Render();
            //    toPay.ShowDialog();
            //}
            //else if (cmbPaymentFor.SelectedItem.Equals("4th Payment"))
            //{
            //    perMonthRange = 5;
            //    ComputePerMonth(perMonthRange);
            //    toPay.GOCNo = lblGOCNo.Text;
            //    toPay.RegNo = lblRegNo.Text;
            //    toPay.amountToPay = lblPerMonthAdv.Text;
            //    toPay.lblpayNumber.Text = perMonthRange.ToString();
            //    toPay.Render();
            //    toPay.ShowDialog();
            
            //}
            //else if (cmbPaymentFor.SelectedItem.Equals("5th Payment"))
            //{
            //    perMonthRange = 6;
            //    ComputePerMonth(perMonthRange);
            //    toPay.GOCNo = lblGOCNo.Text;
            //    toPay.RegNo = lblRegNo.Text;
            //    toPay.amountToPay = lblPerMonthAdv.Text;
            //    toPay.lblpayNumber.Text = perMonthRange.ToString();
            //    toPay.Render();
            //    toPay.ShowDialog();
            //}
            //else if (cmbPaymentFor.SelectedItem.Equals("6th Payment"))
            //{
            //    perMonthRange = 7;
            //    ComputePerMonth(perMonthRange);
            //    toPay.GOCNo = lblGOCNo.Text;
            //    toPay.RegNo = lblRegNo.Text;
            //    toPay.amountToPay = lblPerMonthAdv.Text;
            //    toPay.lblpayNumber.Text = perMonthRange.ToString();
            //    toPay.Render();
            //    toPay.ShowDialog();
            //}
            //else if (cmbPaymentFor.SelectedItem.Equals("7th Payment"))
            //{
            //    perMonthRange = 8;
            //    ComputePerMonth(perMonthRange);
            //    toPay.GOCNo = lblGOCNo.Text;
            //    toPay.RegNo = lblRegNo.Text;
            //    toPay.amountToPay = lblPerMonthAdv.Text;
            //    toPay.lblpayNumber.Text = perMonthRange.ToString();
            //    toPay.Render();
            //    toPay.ShowDialog();
            //}
            //else if (cmbPaymentFor.SelectedItem.Equals("8th Payment"))
            //{
            //    perMonthRange = 9;
            //    ComputePerMonth(perMonthRange);
            //    toPay.GOCNo = lblGOCNo.Text;
            //    toPay.RegNo = lblRegNo.Text;
            //    toPay.amountToPay = lblPerMonthAdv.Text;
            //    toPay.lblpayNumber.Text = perMonthRange.ToString();
            //    toPay.Render();
            //    toPay.ShowDialog();
            //}
            //else if (cmbPaymentFor.SelectedItem.Equals("9th Payment"))
            //{
            //    perMonthRange = 10;
            //    ComputePerMonth(perMonthRange);
            //    toPay.GOCNo = lblGOCNo.Text;
            //    toPay.RegNo = lblRegNo.Text;
            //    toPay.amountToPay = lblPerMonthAdv.Text;
            //    toPay.lblpayNumber.Text = perMonthRange.ToString();
            //    toPay.Render();
            //    toPay.ShowDialog();
            //}
            //else if (cmbPaymentFor.SelectedItem.Equals("10th Payment"))
            //{
            //    perMonthRange = 11;
            //    ComputePerMonth(perMonthRange);
            //    toPay.GOCNo = lblGOCNo.Text;
            //    toPay.RegNo = lblRegNo.Text;
            //    toPay.amountToPay = lblPerMonthAdv.Text;
            //    toPay.lblpayNumber.Text = perMonthRange.ToString();
            //    toPay.Render();
            //    toPay.ShowDialog();
            //}
        }

    }
}
