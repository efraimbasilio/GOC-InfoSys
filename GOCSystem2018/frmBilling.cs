﻿using System;
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
        #region shadow
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }
        #endregion
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
       
        public string LRN, StudID, StudName, GradeLevel, Track,Strand, Semester, SY, VoucherType, RegNo, DP;
        public int CTRpayment,perMonthRange;
        public double BalancePartial, Balance_Amount;
        int MonthNumber = 0;
        public string partialCTR, EnStatus, MOP, MOP_stat;

        public string sMonth2 = DateTime.Now.ToString("MM");
        public int payNo;
        public void CallPaymentNumber2()
        {
            //clear list
            billings.Clear();
            //pass value to list
            billings = bill.Load();

            //loop through load it to list view
            foreach (var item in billings)
            {
                payNo = Convert.ToInt32(item.PaymentNo);
            }
        }//End LoadRecords

        public void RenderMOP()
        {
            CallPaymentNumber2();
            lblMOPInfo.Text = "PARTIAL PAYMENT";
            cmbMOP.Text = "Partial Payment";

            cmbMOP.Enabled = true;
            if (payNo >= 2)
            {   
               cmbMOP.Enabled = false;
            }
        }

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
                dgvFeeHistory.Rows.Add(Convert.ToInt32(item.OrNo), item.StudentId, Convert.ToDouble(item.AmountGiven), Convert.ToInt32(item.PaymentNo), item.PaymentDate);

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

                EnStatus = item.EnStatus;
                if (item.EnStatus.Equals("Reservee"))
                {
                    dgvPerMonth.Rows.Clear();
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
                    dgvPerMonth.Rows.Add("Balance", "Balance", item.Balance);

                    lblAmountDues.Visible = true;
                    lblPerMonthAdv.Visible = false;
                    lblAmountDues.Text = item.Balance;
                }
                else
                {
                    dgvPerMonth.Rows.Clear();
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

                    lblPerMonthAdv.Visible = true;
                   // MessageBox.Show(lblPerMonthAdv.Text);
                    lblAmountDues.Visible = false;
                }              
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
           // MessageBox.Show(lblGOCNo.Text);
            billingPartial.IdNo = lblGOCNo.Text;
            billingPartials = billingPartial.GetPartialBalance();

            //loop through load it to list view
            foreach (var item in billingPartials)
            {
                double balance, dp = 0;
                balance = Convert.ToDouble(item.Balance);
                dp = Convert.ToDouble(item.DownPayment);

                BalancePartial = balance;
                //+dp;
                //MessageBox.Show(BalancePartial.ToString("n"));
                //lblBalance.Text = BalancePartial.ToString("n");
                //lblAmountDue.Text = dp.ToString("n");
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

        private void label12_Click(object sender, EventArgs e)
        {
            frmBillingSearch bill = new frmBillingSearch();
            bill.Show();
            this.Hide();
            this.Dispose();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            
            MainWindow main = new MainWindow();
            main.dispanel.Controls.Clear();

            frmBillingSearch frmBillingSearch = new frmBillingSearch();
            frmBillingSearch.TopLevel = false;
            frmBillingSearch.AutoScroll = true;

            main.dispanel.Controls.Add(frmBillingSearch);
            main.Dashboardpanel.Visible = false;
            
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

        public void Criterias()
        {

        }


        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment pay = new frmPayment();
                  
            if (lblMOPInfo.Text == "RESERVATION")
            {
                //PAYMENT INFOS
                pay.fee_for_reservation = Convert.ToDouble(lblReserve.Text);
                pay.amount_due = Convert.ToDouble(lblReserve.Text);
                pay.amount_per_month = lblPerMonthAdv.Text;                                            
                pay.total_tuition = Convert.ToDouble(lblTotalPayment.Text);
                pay.voucher_info = lblVoucher.Text;
                pay.voucher_amount = Convert.ToDouble(lblVoucherAmount.Text);

                //STUDENT INFORMATION
                pay.full_name = lblName.Text;
                pay.S_LRN = lblLRN.Text;
                pay.reg_no = lblRegNo.Text;
                pay.GOCNo = lblGOCNo.Text;
                pay.S_PAYFOR = lblMOPInfo.Text;

                //if Reservation or Partial
                pay.payment_status = lblMOPInfo.Text;

                //Call Method to load info before transaction
                pay.Render();
                //to show the form
                pay.ShowDialog();
            }

            else if (lblMOPInfo.Text == "PARTIAL PAYMENT")
            {

                //PAYMENT INFOS                               
                if (Convert.ToInt32(lblPaymentNoCheck.Text) == 0)
                {
                    pay.fee_for_reservation = Convert.ToDouble(lblReserve.Text);
                }
                else
                {
                    if (EnStatus.Equals("Reservee"))
                    {
                        pay.amount_due = Convert.ToDouble(lblAmountDues.Text);
                    }
                    else
                    {
                        pay.amount_due = Convert.ToDouble(lblPerMonthAdv.Text);
                    }
                    
                }

                pay.amount_per_month = lblPerMonthAdv.Text;
                pay.total_tuition = Convert.ToDouble(lblTotalPayment.Text);
                pay.voucher_info = lblVoucher.Text;
                pay.voucher_amount = Convert.ToDouble(lblVoucherAmount.Text);
                

                //STUDENT INFORMATION
                pay.full_name = lblName.Text;
                pay.S_LRN = lblLRN.Text;
                pay.reg_no = lblRegNo.Text;
                pay.GOCNo = lblGOCNo.Text;

                pay.S_PAYFOR = lblAmountDues.Text;

                //if Reservation or Partial
                pay.payment_status = lblMOPInfo.Text;
                pay.payment_no = Convert.ToInt32(lblPaymentNoCheck.Text);

                //Call Method to load info before transaction
                pay.EnrollmentStatus(); //to check the payment if this is the second payment, check by the Enrollment Status tag
                pay.Render();
                //to show the form
                pay.ShowDialog();

            }

            else if (lblMOPInfo.Text == "FULL PAYMENT")
            {

                //PAYMENT INFOS                               
                if (Convert.ToInt32(lblPaymentNoCheck.Text) == 0)
                {
                    pay.fee_for_reservation = Convert.ToDouble(lblReserve.Text);
                }
                else
                {
                    if (EnStatus.Equals("Reservee"))
                    {
                        pay.amount_due = Convert.ToDouble(lblAmountDues.Text);
                    }
                    else
                    {
                        pay.amount_due = Convert.ToDouble(lblPerMonthAdv.Text);
                    }

                }

                pay.amount_per_month = lblPerMonthAdv.Text;
                pay.total_tuition = Convert.ToDouble(lblTotalPayment.Text);
                pay.voucher_info = lblVoucher.Text;
                pay.voucher_amount = Convert.ToDouble(lblVoucherAmount.Text);

                //STUDENT INFORMATION
                pay.full_name = lblName.Text;
                pay.S_LRN = lblLRN.Text;
                pay.reg_no = lblRegNo.Text;
                pay.GOCNo = lblGOCNo.Text;
                //if Reservation or Partial
                pay.payment_status = lblMOPInfo.Text;
                pay.payment_no = Convert.ToInt32(lblPaymentNoCheck.Text);

                //Call Method to load info before transaction
                pay.EnrollmentStatus(); //to check the payment if this is the second payment, check by the Enrollment Status tag
                pay.Render();
                //to show the form
                pay.ShowDialog();

            }
            this.Hide();
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

  

        public void Render()
        {

            #region For validating amount due anutomatic per month catching

            //June to March SY 
            if (Convert.ToInt32(sMonth2) < 6)
            {                
                MonthNumber = Convert.ToInt32(sMonth2) + 8;

                if (MonthNumber > 11)
                {
                    MonthNumber = 11;
                    AutoComputePerMonth(MonthNumber);
                }
                else { AutoComputePerMonth(MonthNumber); }
               
               
            }

            
            if (Convert.ToInt32(sMonth2) >= 6)
            {
                
                MonthNumber = Convert.ToInt32(sMonth2) - 4;
                if (MonthNumber > 11)
                {
                    MonthNumber = 11;
                    AutoComputePerMonth(MonthNumber);
                }
                else { AutoComputePerMonth(MonthNumber); }
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
            GetPartialBalance();
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
            frmPayment toPay = new frmPayment();

            if (cmbMOP.SelectedItem.Equals("Partial Payment"))
            {
                studProfile.StudRegistrationNo = RegNo;
                studProfile.PartialPayment = "1";
                studProfile.PartialOnly();
                                               
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