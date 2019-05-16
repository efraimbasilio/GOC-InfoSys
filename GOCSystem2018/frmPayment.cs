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
    public partial class frmPayment : Form
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

        frmBilling frmBilling = new frmBilling();

        public string amount_per_month, payment_status, full_name, voucher_info;
        public double fee_for_reservation, total_tuition, voucher_amount, down_payment, amount_due;
        public int payment_no;
        public string reg_no, enroll_status;

        public string amountToPay, paymentFor, GOCNo, ctrpay,  DP, voucherInfo, reservationFee, paymentNo, toCheckGOCNo;
        public double TotalMiscFee, TotalOtherFee, AmountGiven, BalancePartial, perMonthFee;

        public string S_LRN, S_GOC, S_NAME,S_PAYFOR,S_AMOUNT,level;
        public bool toSave = true;
        public bool toOtherFees = false;

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

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void txtUniform_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBooks_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLocker_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnOtherFee_Click(object sender, EventArgs e)
        {
            pnlOtherFee.Visible = true;
        }

        private void btnOtherFee_Click_1(object sender, EventArgs e)
        {
            if (btnOtherFee.Text == "With Other Fees")
            {
                pnlOtherFee.Visible = true;
                btnOtherFee.Text = "&Cancel";

                txtTuitionFee.Focus();
                txtTuitionFee.SelectAll();

                toOtherFees = true;
            }
            else
            {
                pnlOtherFee.Visible = false;
                btnOtherFee.Text = "With Other Fees";
                txtTuitionFee.Text = "0.00";
                txtUniform.Text = "0.00";
                txtBooks.Text = "0.00";
                txtLocker.Text = "0.00";
                lblAmountDue.Text = "0.00";

                toOtherFees = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double total = 0;
            total = Convert.ToDouble(txtTuitionFee.Text) + Convert.ToDouble(txtUniform.Text) + Convert.ToDouble(txtBooks.Text) + Convert.ToDouble(txtLocker.Text);
            lblAmount_Due.Text = total.ToString("n");
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

        private void txtBooks_Leave(object sender, EventArgs e)
        {
            txtBooks.Text = string.Format("{0:#,##0.00}", double.Parse(txtBooks.Text));
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

        private void txtAmountGiven_Click(object sender, EventArgs e)
        {
            txtAmountGiven.SelectAll();
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
            label17.Text = level;
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
        
        //public void StudNoGenerate()
        //{
        //    int ctrGOCNum = 1;
        //    //clear list           
        //    bills.Clear();
        //    //pass value to list
        //    //MessageBox.Show(assements.Count().ToString());
        //    if (bills.Count() < 1)
        //    {
        //        GOCNo = "GOC-" + DateTime.Today.ToString("yyyy") + "-" + (ctrGOCNum).ToString("0000");
        //    }

        //    bills = bill.Load();

        //    foreach (var item in bills)
        //    {
        //        //GOCNo = "GOC-" + DateTime.Today.ToString("yyyy") + "-" + (item.Id + 1).ToString("0000");
        //        ctrGOCNum = ctrGOCNum + 1;
        //        GOCNo = "GOC-" + DateTime.Today.ToString("yyyy") + "-" + (ctrGOCNum).ToString("0000");
        //    }
        //}//StudNoGenerate

        public void StudNoGenerate()
        {
            bool OldStud = false;

            studentProfiles.Clear();
            studentProfile.StudRegistrationNo = reg_no;
            studentProfiles = studentProfile.GetByRegNo();


            foreach (var item in studentProfiles)
            {
                if (item.StudType.Equals("Old Student"))
                {
                    OldStud = true;
                }
                else
                {
                    OldStud = false;
                }
            }

            if (OldStud == true)
            {
                studentProfiles.Clear();
                studentProfile.StudRegistrationNo = reg_no;
                studentProfiles = studentProfile.GetByRegNo();

                foreach (var item in studentProfiles)
                {
                    GOCNo = item.OldStudentNo;
                }               
            }
            else//OLD way
            {
                //MessageBox.Show("Old Way");
                int ctrGOCNum = 1;
                //clear list           
                billingPartials.Clear();
                //pass value to list
                //MessageBox.Show(assements.Count().ToString());
                if (billingPartials.Count() < 1)
                {
                    GOCNo = "GOC-" + DateTime.Today.ToString("yyyy") + "-" + (ctrGOCNum).ToString("0000");
                }

                billingPartials = billingPartial.Load();

                foreach (var item in billingPartials)
                {
                    //GOCNo = "GOC-" + DateTime.Today.ToString("yyyy") + "-" + (item.Id + 1).ToString("0000");
                    ctrGOCNum = ctrGOCNum + 1;
                    GOCNo = "GOC-" + DateTime.Today.ToString("yyyy") + "-" + (ctrGOCNum).ToString("0000");
                }
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

        public void SavePaymentHistory()
        {
            CountPayment(); // Count the payment
            bill.AmountGiven = Convert.ToDouble(txtAmountGiven.Text);
            bill.OrNo = txtORNo.Text;
            bill.StudentId = GOCNo;
            bill.RegNo = reg_no;
            bill.PaymentNo = count.ToString();
            bill.MOP = "Partial Payment " + count;
            bill.Save();
        }

        public void SavePaymentHistory_2(TextBox AmountGiven_2)
        {
            CountPayment(); // Count the payment
            bill.AmountGiven = Convert.ToDouble(AmountGiven_2.Text);
            bill.OrNo = txtORNo.Text;
            bill.StudentId = GOCNo;
            bill.RegNo = reg_no;
            bill.PaymentNo = count.ToString();
            bill.MOP = "Partial Payment " + count;
            bill.Save();
        }

        public void PartialSecondPay()
        {           
            if (enroll_status == null)
            {
                return;
            }

            if (enroll_status.Equals("Reservee"))//MAGBABAYAD NG 2nd Payment - For Reservee
            {
              //  MessageBox.Show(enroll_status + " " + payment_status + " " + payment_no);

                double Tuition_Monthly = 0;

                Tuition_Monthly = Convert.ToDouble(lblAmount_Due.Text) - Convert.ToDouble(txtAmountGiven.Text);
                Tuition_Monthly = Tuition_Monthly / 10;

                billingPartial.IdNo = GOCNo;
                billingPartial.ORNo = txtORNo.Text;
                billingPartial.Full_name = full_name;
                billingPartial.DownPayment = "0.00";
                billingPartial.P1 = Tuition_Monthly.ToString("n");
                billingPartial.P2 = Tuition_Monthly.ToString("n");
                billingPartial.P3 = Tuition_Monthly.ToString("n");
                billingPartial.P4 = Tuition_Monthly.ToString("n");
                billingPartial.P5 = Tuition_Monthly.ToString("n");
                billingPartial.P6 = Tuition_Monthly.ToString("n");
                billingPartial.P7 = Tuition_Monthly.ToString("n");
                billingPartial.P8 = Tuition_Monthly.ToString("n");
                billingPartial.P9 = Tuition_Monthly.ToString("n");
                billingPartial.P10 = Tuition_Monthly.ToString("n");

                Double sum = 0;
                sum = Convert.ToDouble(billingPartial.P1) + Convert.ToDouble(billingPartial.P2) + Convert.ToDouble(billingPartial.P3) + Convert.ToDouble(billingPartial.P4) + Convert.ToDouble(billingPartial.P5) + Convert.ToDouble(billingPartial.P6) + Convert.ToDouble(billingPartial.P7) + Convert.ToDouble(billingPartial.P8) + Convert.ToDouble(billingPartial.P9) + Convert.ToDouble(billingPartial.P10);
                billingPartial.Balance = sum.ToString("n");

                billingPartial.EnStatus = "Enrolled";
                billingPartial.RegNo = reg_no;

                billingPartial.Update(); //update the Reservee partial payment


                //insert another payment from this GOC No.
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
                bill.MOP = "Partial Payment No: " + count;
                //save for the billing OR table
                bill.Save();

                this.Hide();
            }

            else if (enroll_status.Equals("Enrolled"))
            {
                if (Convert.ToDouble(lblAmount_Due.Text) >= Convert.ToDouble(txtAmountGiven.Text))
                {
                    #region LESS PAYMENT 

                    double TotalFee = 0;
                    double Payments;
                    double result = (Convert.ToDouble(lblAmount_Due.Text) - Convert.ToDouble(txtAmountGiven.Text));

                    //get the sum of all amount in dgv
                    for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
                    {
                        TotalFee += (Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value));
                    }

                    Payments = TotalFee - Convert.ToDouble(txtAmountGiven.Text);

                    double toLoop = 0;
                    toLoop = Payments / perMonthFee;

                    double remainingAfter = 0;
                    remainingAfter = Payments % perMonthFee;

                    if (remainingAfter < perMonthFee)
                    {
                        int loop;
                        loop = Convert.ToInt32(Math.Floor(toLoop) + 1);
                        loop = dgvPerMonth.Rows.Count - loop;

                        //lagyan lahat ng default
                        for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
                        {
                            dgvPerMonth.Rows[i].Cells[2].Value = 0.00;
                        }

                        for (int i = dgvPerMonth.Rows.Count - 1; i > loop - 1; i--)
                        {
                            //TotalFee += (Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value));
                            //MessageBox.Show(i.ToString());
                            dgvPerMonth.Rows[i].Cells[2].Value = perMonthFee;
                        }
                        dgvPerMonth.Rows[loop].Cells[2].Value = remainingAfter;
                    }

                    UpdateMonthlyPayment();
                    SavePaymentHistory();
                    #endregion
                }
                else if (Convert.ToDouble(txtAmountGiven.Text) > Convert.ToDouble(lblAmountDue.Text))
                {
                    #region ADVANCE PAYMENT 

                    double TotalFee = 0;
                    double Payments;
                    double result = (Convert.ToDouble(lblAmountDue.Text) - Convert.ToDouble(txtAmountGiven.Text));


                    //This will count  the remaining balance before computation
                    double Total_Amount = 0;
                    for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
                    {
                        Total_Amount += Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value);
                    }

                    if (Total_Amount > Convert.ToDouble(txtAmountGiven.Text))
                    {
                        //get the sum of all amount in dgv
                        for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
                        {
                            TotalFee += (Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value));
                        }

                        Payments = TotalFee - Convert.ToDouble(txtAmountGiven.Text);

                        double toLoop = 0;
                        toLoop = Payments / perMonthFee;

                        double remainingAfter = 0;
                        remainingAfter = Payments % perMonthFee;

                        if (remainingAfter < perMonthFee)
                        {
                            int loop;
                            loop = Convert.ToInt32(Math.Floor(toLoop) + 1);
                            loop = dgvPerMonth.Rows.Count - loop;

                            //lagyan lahat ng default
                            for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
                            {
                                dgvPerMonth.Rows[i].Cells[2].Value = 0.00;
                            }

                            for (int i = dgvPerMonth.Rows.Count - 1; i > loop - 1; i--)
                            {
                                //TotalFee += (Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value));
                                //MessageBox.Show(i.ToString());
                                dgvPerMonth.Rows[i].Cells[2].Value = perMonthFee;
                            }

                            dgvPerMonth.Rows[loop].Cells[2].Value = remainingAfter;
                        }
                        else
                        {
                            return;
                        }
                        UpdateMonthlyPayment();
                        SavePaymentHistory();
                    }
                    else
                    {
                        MessageBox.Show("Please check the amount given is morethan the Total Balance", "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    #endregion
                }

            }
            //else if(enroll_status == null)
            //{
            //    return;
            //}
        }

        public void PartialSecondPay_2(TextBox AmountGiven_2)
        {
            if (enroll_status == null)
            {
                return;
            }

            if (enroll_status.Equals("Reservee"))//MAGBABAYAD NG 2nd Payment - For Reservee
            {
                //  MessageBox.Show(enroll_status + " " + payment_status + " " + payment_no);

                double Tuition_Monthly = 0;

                Tuition_Monthly = Convert.ToDouble(lblAmount_Due.Text) - Convert.ToDouble(AmountGiven_2.Text);
                Tuition_Monthly = Tuition_Monthly / 10;

                billingPartial.IdNo = GOCNo;
                billingPartial.ORNo = txtORNo.Text;
                billingPartial.Full_name = full_name;
                billingPartial.DownPayment = "0.00";
                billingPartial.P1 = Tuition_Monthly.ToString("n");
                billingPartial.P2 = Tuition_Monthly.ToString("n");
                billingPartial.P3 = Tuition_Monthly.ToString("n");
                billingPartial.P4 = Tuition_Monthly.ToString("n");
                billingPartial.P5 = Tuition_Monthly.ToString("n");
                billingPartial.P6 = Tuition_Monthly.ToString("n");
                billingPartial.P7 = Tuition_Monthly.ToString("n");
                billingPartial.P8 = Tuition_Monthly.ToString("n");
                billingPartial.P9 = Tuition_Monthly.ToString("n");
                billingPartial.P10 = Tuition_Monthly.ToString("n");

                Double sum = 0;
                sum = Convert.ToDouble(billingPartial.P1) + Convert.ToDouble(billingPartial.P2) + Convert.ToDouble(billingPartial.P3) + Convert.ToDouble(billingPartial.P4) + Convert.ToDouble(billingPartial.P5) + Convert.ToDouble(billingPartial.P6) + Convert.ToDouble(billingPartial.P7) + Convert.ToDouble(billingPartial.P8) + Convert.ToDouble(billingPartial.P9) + Convert.ToDouble(billingPartial.P10);
                billingPartial.Balance = sum.ToString("n");

                billingPartial.EnStatus = "Enrolled";
                billingPartial.RegNo = reg_no;

                billingPartial.Update(); //update the Reservee partial payment


                //insert another payment from this GOC No.
                CountPayment();
                bill.StudentId = GOCNo;
                bill.RegNo = reg_no;
                //Convert amount given
                bill.AmountGiven = Convert.ToDouble(AmountGiven_2.Text);
                //tag for the OR number
                bill.OrNo = txtORNo.Text;
                //count the payment number                    
                bill.PaymentNo = count.ToString();
                //tag for the payment Status
                bill.MOP = "Partial Payment No: " + count;
                //save for the billing OR table
                bill.Save();

                this.Hide();
            }

            else if (enroll_status.Equals("Enrolled"))
            {
                if (Convert.ToDouble(lblAmount_Due.Text) >= Convert.ToDouble(AmountGiven_2.Text))
                {
                    #region LESS PAYMENT 

                    double TotalFee = 0;
                    double Payments;
                    double result = (Convert.ToDouble(lblAmount_Due.Text) - Convert.ToDouble(AmountGiven_2.Text));

                    //get the sum of all amount in dgv
                    for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
                    {
                        TotalFee += (Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value));
                    }

                    Payments = TotalFee - Convert.ToDouble(AmountGiven_2.Text);

                    double toLoop = 0;
                    toLoop = Payments / perMonthFee;

                    double remainingAfter = 0;
                    remainingAfter = Payments % perMonthFee;

                    if (remainingAfter < perMonthFee)
                    {
                        int loop;
                        loop = Convert.ToInt32(Math.Floor(toLoop) + 1);
                        loop = dgvPerMonth.Rows.Count - loop;

                        //lagyan lahat ng default
                        for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
                        {
                            dgvPerMonth.Rows[i].Cells[2].Value = 0.00;
                        }

                        for (int i = dgvPerMonth.Rows.Count - 1; i > loop - 1; i--)
                        {
                            //TotalFee += (Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value));
                            //MessageBox.Show(i.ToString());
                            dgvPerMonth.Rows[i].Cells[2].Value = perMonthFee;
                        }
                        dgvPerMonth.Rows[loop].Cells[2].Value = remainingAfter;
                    }

                    UpdateMonthlyPayment();
                    SavePaymentHistory_2(txtTuitionFee);
                    #endregion
                }
                else if (Convert.ToDouble(AmountGiven_2.Text) > Convert.ToDouble(lblAmountDue.Text))
                {
                    #region ADVANCE PAYMENT 

                    double TotalFee = 0;
                    double Payments;
                    double result = (Convert.ToDouble(lblAmountDue.Text) - Convert.ToDouble(AmountGiven_2.Text));


                    //This will count  the remaining balance before computation
                    double Total_Amount = 0;
                    for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
                    {
                        Total_Amount += Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value);
                    }

                    if (Total_Amount > Convert.ToDouble(AmountGiven_2.Text))
                    {
                        //get the sum of all amount in dgv
                        for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
                        {
                            TotalFee += (Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value));
                        }

                        Payments = TotalFee - Convert.ToDouble(AmountGiven_2.Text);

                        double toLoop = 0;
                        toLoop = Payments / perMonthFee;

                        double remainingAfter = 0;
                        remainingAfter = Payments % perMonthFee;

                        if (remainingAfter < perMonthFee)
                        {
                            int loop;
                            loop = Convert.ToInt32(Math.Floor(toLoop) + 1);
                            loop = dgvPerMonth.Rows.Count - loop;

                            //lagyan lahat ng default
                            for (int i = 0; i < dgvPerMonth.Rows.Count; i++)
                            {
                                dgvPerMonth.Rows[i].Cells[2].Value = 0.00;
                            }

                            for (int i = dgvPerMonth.Rows.Count - 1; i > loop - 1; i--)
                            {
                                //TotalFee += (Convert.ToDouble(dgvPerMonth.Rows[i].Cells[2].Value));
                                //MessageBox.Show(i.ToString());
                                dgvPerMonth.Rows[i].Cells[2].Value = perMonthFee;
                            }

                            dgvPerMonth.Rows[loop].Cells[2].Value = remainingAfter;
                        }
                        else
                        {
                            return;
                        }
                        UpdateMonthlyPayment();
                        SavePaymentHistory_2(txtTuitionFee);
                    }
                    else
                    {
                        MessageBox.Show("Please check the amount given is morethan the Total Balance", "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    #endregion
                }

            }
            //else if(enroll_status == null)
            //{
            //    return;
            //}
        }

        public void PartialNoReserve()
        {
            if (payment_status.Equals("PARTIAL PAYMENT") && payment_no == 0)// magbabayad palang for FIRST payment - no reservation
            {

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

                    studProfile.StudRegistrationNo = reg_no;
                    studProfile.PartialPayment = "1";
                    studProfile.PartialOnly();

                    #endregion
                }

                else if (AmountGiven < Convert.ToDouble(fee_for_reservation))//mas maliit  sa initial reservation fee this will be tag as reservation fee
                {
                    string message = "The Minimum amount for Reservation is :" + fee_for_reservation + " Pesos.";
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
                        studProfile.PartialPayment = "1";
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

            }

            else
            {
                return;
            }
        }

        public void PartialNoReserve_2(TextBox AmountGiven_2)
        {
            if (payment_status.Equals("PARTIAL PAYMENT") && payment_no == 0)// magbabayad palang for FIRST payment - no reservation
            {

                AmountGiven = Convert.ToDouble(AmountGiven_2.Text); //Convert to Double               

                if (AmountGiven > Convert.ToDouble(fee_for_reservation))//kapag mas malaki ang binigay na amount kaysa initial reservation fee this will be then divide to 10
                {
                    #region PARTIAL PAYMENT - NO RESERVATION                                 
                    //madidivide ang tutiton sa 10
                    total_tuition = total_tuition - AmountGiven;
                    total_tuition = total_tuition - voucher_amount;
                    total_tuition = total_tuition / 10;

                    StudNoGenerate(); // Generate StudNo
                    CountPayment(); // Count the payment
                    bill.AmountGiven = Convert.ToDouble(AmountGiven_2.Text);
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

                    studProfile.StudRegistrationNo = reg_no;
                    studProfile.PartialPayment = "1";
                    studProfile.PartialOnly();

                    #endregion
                }

                else if (AmountGiven < Convert.ToDouble(fee_for_reservation))//mas maliit  sa initial reservation fee this will be tag as reservation fee
                {
                    string message = "The Minimum amount for Reservation is :" + fee_for_reservation + " Pesos.";
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
                        bill.AmountGiven = Convert.ToDouble(AmountGiven_2.Text);
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
                        studProfile.PartialPayment = "1";
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

            }

            else
            {
                return;
            }
        }

        public void Reservations()
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
                    studProfile.PartialPayment = "1";//update the status
                    //update GOC number in the student profile table
                    studProfile.SaveGOCNumber();

                    Reservation();//Computation per month and Balance
                    return;
                }
                else
                {
                    MessageBox.Show("Please pay the exact reservation fee", "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #endregion
            }
        }

        public void Reservations_2(TextBox AmountGiven_2)
        {
            if (payment_status.Equals("RESERVATION"))
            {
                #region RESERVATION - ASSESSMENT - RESERVE
                ///Allow Student to pay the exact amount of the reservation fee or else student cannot reserve
                if (fee_for_reservation == Convert.ToDouble(AmountGiven_2.Text))
                {
                    // Generate StudNo
                    StudNoGenerate();
                    // Count the payments
                    CountPayment();

                    bill.StudentId = GOCNo;
                    bill.RegNo = reg_no;
                    //Convert amount given
                    bill.AmountGiven = Convert.ToDouble(AmountGiven_2.Text);
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
                    studProfile.PartialPayment = "1";//update the status
                    //update GOC number in the student profile table
                    studProfile.SaveGOCNumber();

                    Reservation();//Computation per month and Balance
                    return;
                }
                else
                {
                    MessageBox.Show("Please pay the exact reservation fee", "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #endregion
            }
        }

        public void UpdateMonthlyPayment()
        {
            //string a,b;

            billingPartial.ORNo = txtORNo.Text;
            billingPartial.RegNo = reg_no;
            billingPartial.IdNo = GOCNo;
            billingPartial.Full_name = full_name;
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

               
                double TotalFee = 0;                //get the sum of all amount in dgv
                for (int x = 0; x < dgvPerMonth.Rows.Count; x++)
                {
                    TotalFee += (Convert.ToDouble(dgvPerMonth.Rows[x].Cells[2].Value));
                }

                billingPartial.Balance = TotalFee.ToString("n");
                billingPartial.EnStatus ="Enrolled";

                billingPartial.Update();
            
           
            MessageBox.Show("Bill Updated!", "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /***********************************************************************************/
        /*Private Methods*/
        /**********************************************************************************/

        private void frmPayment_Load(object sender, EventArgs e)
        {           
            lblAmount_Due.Text = amount_due.ToString("n");

            txtTuitionFee.Text = "0.00";
            txtUniform.Text = "0.00";
            txtBooks.Text = "0.00";
            txtLocker.Text = "0.00";
          

            lblLRN.Text = S_LRN;
            lblGOCNo.Text = GOCNo;
            lblName.Text = full_name;
            lblPAYFOR.Text = S_PAYFOR;


            LoadRecordsORPartial();
            LoadRecordsOR();
        }

        //For billing
        private void button1_Click(object sender, EventArgs e)
        {
            toSave = true;
            checkdup();
           // checkdupPartial();

            if (txtORNo.Text == "" || txtAmountGiven.Text == "")
            {
                MessageBox.Show("Please check the OR Number or the Payment", "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (toOtherFees == true)
            {
                if (Convert.ToDouble(txtAmountGiven.Text) < Convert.ToDouble(lblAmount_Due.Text))
                {
                    MessageBox.Show("Please check the payment", "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("with other Fee");
                   

                    if (toSave == true)
                    {
                        Reservations_2(txtTuitionFee);
                        PartialNoReserve_2(txtTuitionFee);
                        PartialSecondPay_2(txtTuitionFee);

                        Billing_Other_Fees fee = new Billing_Other_Fees();

                        MessageBox.Show(GOCNo);

                        fee.GocNumber = GOCNo;
                        fee.OrNo = txtORNo.Text;
                        fee.GLevel = label17.Text;
                        fee.Uniform = txtUniform.Text;
                        fee.Books = txtBooks.Text;
                        fee.Locker = txtLocker.Text;

                        fee.Save();
                    }
                    else
                    {
                        return;
                    }
                      
                }
            }
            else if (toOtherFees == false)          
            {
             

                if (toSave == true)
                {

                    Reservations();
                    PartialNoReserve();
                    PartialSecondPay();

                    MainWindow mainwin = (MainWindow)Application.OpenForms["MainWindow"];
                    mainwin.dispanel.Controls.Clear();
                    mainwin.dispanel.Visible = false;

                    mainwin.Dashboardpanel.Visible = true;
                    this.Close();
                }
                else
                {
                    return;
                }
            }

            //try
            //{
            //    if (txtORNo.Text == "" || txtAmountGiven.Text == "")
            //    {
            //        MessageBox.Show("Please check the OR Number or the Payment","GOC_INFO_SYS",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //        return;
            //    }
            //    else
            //    {
            //        //checkdup();
            //        //checkdupPartial();
            //        if (toSave == true)
            //        {

            //            Reservations();
            //            PartialNoReserve();
            //            PartialSecondPay();

            //            MainWindow mainwin = (MainWindow)Application.OpenForms["MainWindow"];
            //            mainwin.dispanel.Controls.Clear();
            //            mainwin.dispanel.Visible = false;

            //            mainwin.Dashboardpanel.Visible = true;
            //            this.Close();
            //        }
            //        else
            //        {
            //            return;
            //        }




            //    }
            //}
            //catch (Exception ex)
            //{               
            //    MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}                              
        }


        public void LoadRecordsOR()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM billing_or";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    //initialize new datatable
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvORCheck.DataSource = dt;

                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadRecordsORPartial()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM billing_partial";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    //initialize new datatable
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvORCheckPartial.DataSource = dt;

                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void checkdup()
        {

            for (int i = 0; i < dgvORCheck.Rows.Count; i++)
            {
                if (dgvORCheck.Rows[i].Cells[3].FormattedValue.ToString() == txtORNo.Text)  //GOC NO
                {
                    MessageBox.Show("Duplicate OR Number Detected, Please check the OR Number","GOC_INFO_SYS",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    toSave = false;
                    txtORNo.Focus();
                    
                }                             
            }
            return;
        }

        public void checkdupPartial()
        {
            //for (int i = 0; i < dgvORCheck.Rows.Count; i++)
            //{
            //    if (dgvORCheckPartial.Rows[i].Cells[1].FormattedValue.ToString() == txtORNo.Text)  //GOC NO
            //    {
            //        MessageBox.Show("Duplicate OR Number Detected, Please check the OR Number", "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        toSave = false;
            //        txtORNo.Focus();
            //        return;
            //    }
            //}
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
