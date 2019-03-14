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
       
        public string LRN, StudID, StudName, GradeLevel, Track,Strand, Semester, MOP, SY, VoucherType, RegNo;
        public int CTRpayment;


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

        private void frmBilling_Load(object sender, EventArgs e)
        {
            
        }

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
            }
        }//End LoadRecords

        public void Render()
        {
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
                cmbPaymentFor.Items.Clear();
                cmbPaymentFor.Items.Add("Full Payment");
                cmbPaymentFor.Text = "Full Payment";
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

            if (cmbPaymentFor.SelectedItem.Equals("Reservation"))
            {
                toPay.reservation = lblReserve.Text;
                toPay.paymentFor = cmbPaymentFor.SelectedItem.ToString();
                toPay.TotalTuition = Convert.ToDouble(lblTotalPayment.Text);
                toPay.FullName = lblName.Text;
                toPay.VoucherType = Convert.ToDouble(lblVoucherAmount.Text);
                toPay.RegNo = lblRegNo.Text;
                
                toPay.Render();
                toPay.ShowDialog();

            }
        }

    }
}
