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
    public partial class frmBillingSearch : Form
    {
        public int payNo;

        /*Models*/
        StudentProfile studentProfile = new StudentProfile();
        /***************************************************************/

        /*Array List*/
        List<StudentProfile> studentProfiles = new List<StudentProfile>();
        /***************************************************************/
        Billing bill = new Billing();
        /*Forms*/
        frmBilling frmBilling = new frmBilling();
        /***************************************************************/
        List<Billing> billings = new List<Billing>();
        /***********************************************************************************/
        /*PUBLIC VARIABLES*/
        /**********************************************************************************/

        /***********************************************************************************/
        /*PUBLIC METHOD*/
        /**********************************************************************************/
        public void searchData(string valueToSearch)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM student_profile WHERE CONCAT(`last_name`, `first_name`,`regno`,`LRN`) LIKE '%" + valueToSearch + "%'";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    //initialize new datatable
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvSearch.DataSource = dt;

                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CallPaymentNumber()
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
        /***********************************************************************************/
        /*PRIVATE METHOD*/
        /**********************************************************************************/
        private void SelectData()
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                //clear list
                studentProfiles.Clear();
                //pass value
                studentProfile.Id = Int32.Parse(dgvSearch.CurrentRow.Cells[0].FormattedValue.ToString());
                studentProfiles = studentProfile.GetById();
                                          

                foreach (var item in studentProfiles)
                {
                    //pass variable to form Assesment
                    frmBilling.StudName = item.StudLastName + ", " + item.StudFirstName + " " + item.StudMiddleName;
                    frmBilling.StudID = item.StudGOCNo;
                    frmBilling.LRN = item.StudLRN;
                    frmBilling.GradeLevel = item.StudGradeLevel;
                    frmBilling.Track = item.Track;
                    frmBilling.Strand = item.StudStrand;
                    frmBilling.VoucherType = item.VoucherType;
                    frmBilling.RegNo = item.StudRegistrationNo;

                   

                frmBilling.CallPaymentNumber();
                frmBilling.GetPerMonth();


                //set up before form load
                
                frmBilling.Render();

                    if (item.Reservee.Equals("1"))
                    {
                        frmBilling.lblMOPInfo.Text = "RESERVATION";

                        //frmBilling.lblReservationTag.ForeColor = Color.Red;
                        //frmBilling.lblReservationTag.BackColor = Color.Black;
                        frmBilling.CTRpayment = 1;
                        frmBilling.cmbMOP.Enabled = false;

                        //frmBilling.cmbPaymentFor.Items.Clear();
                        //frmBilling.cmbPaymentFor.Items.Add("Reservation");
                        //frmBilling.cmbPaymentFor.Text = "Reservation";
                    }

                    else if (item.PartialPayment.Equals("1"))
                    {
                        frmBilling.RenderMOP();
                    }

                    else if (item.FullPayment.Equals("1"))
                    {
                        frmBilling.RenderFullpayment();
                    }

                    //if (item.FullPayment.Equals("1"))
                    //{
                    //    frmBilling.lblFullPayment.ForeColor = Color.Red;
                    //    frmBilling.lblFullPayment.BackColor = Color.Black;
                    //    frmBilling.cmbMOP.Text = "Full Payment";
                    //    frmBilling.CTRpayment = 3;
                    //}                    
                }

                MainWindow mainwin = (MainWindow)Application.OpenForms["MainWindow"];
                mainwin.dispanel.Controls.Clear();
                frmBilling.TopLevel = false;
                frmBilling.AutoScroll = true;
                mainwin.dispanel.Controls.Add(frmBilling);

                frmBilling.Show();
            }
        }

        public void LoadRecords()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM student_profile";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    //initialize new datatable
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvSearch.DataSource = dt;

                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /***********************************************************************************/
        /*PRINTING METHOD*/
        /**********************************************************************************/

        public frmBillingSearch()
        {
            InitializeComponent();
        }

        private void frmBillingSearch_Load(object sender, EventArgs e)
        {
            //#region Screen_Setting
            //int intX = Screen.PrimaryScreen.Bounds.Width;
            //int intY = Screen.PrimaryScreen.Bounds.Height;
            //this.Width = intX;
            //this.Height = intY;
            //this.Left = 0;
            //this.Top = 0;
            //#endregion 
            LoadRecords();
            #region header name fix

            dgvSearch.Columns["LRN"].HeaderText = "LRN";
            dgvSearch.Columns["regNo"].HeaderText = "REG No";
            dgvSearch.Columns["IDNo"].HeaderText = "GOC No";
            dgvSearch.Columns["last_name"].HeaderText = "Last Name";
            dgvSearch.Columns["first_name"].HeaderText = "First Name";
            dgvSearch.Columns["middle_name"].HeaderText = "Middle Name";
            dgvSearch.Columns["grade_Level"].HeaderText = "Grade Level";
            dgvSearch.Columns["section"].HeaderText = "Section";
            dgvSearch.Columns["track"].HeaderText = "Track";
            dgvSearch.Columns["strand"].HeaderText = "Strand";
            dgvSearch.Columns["date_enrolled"].HeaderText = "Date Enrolled";
            dgvSearch.Columns["sy_enrolled"].HeaderText = "SY";
            #endregion



            #region removal of unneccessary header
            this.dgvSearch.Columns["id"].Visible = false;
            // this.dgvSearch.Columns["IDNo"].Visible = false;
            // this.dgvSearch.Columns["regNo"].Visible = false;
            this.dgvSearch.Columns["Reservee"].Visible = false;
            this.dgvSearch.Columns["Reserve_for"].Visible = false;
            this.dgvSearch.Columns["Full_payment"].Visible = false;
            this.dgvSearch.Columns["Partial_payment"].Visible = false;
            this.dgvSearch.Columns["photo_loc"].Visible = false;
            this.dgvSearch.Columns["voucher_type"].Visible = false;
            this.dgvSearch.Columns["address"].Visible = false;
            this.dgvSearch.Columns["date_of_birth"].Visible = false;
            this.dgvSearch.Columns["place_of_birth"].Visible = false;
            this.dgvSearch.Columns["religion"].Visible = false;
            this.dgvSearch.Columns["nationality"].Visible = false;
            this.dgvSearch.Columns["gender"].Visible = false;
            this.dgvSearch.Columns["stud_contactNo"].Visible = false;
            this.dgvSearch.Columns["stud_telNo"].Visible = false;
            this.dgvSearch.Columns["prev_school"].Visible = false;
            this.dgvSearch.Columns["prev_school_address"].Visible = false;
            this.dgvSearch.Columns["father_name"].Visible = false;
            this.dgvSearch.Columns["father_work"].Visible = false;
            this.dgvSearch.Columns["mother_name"].Visible = false;
            this.dgvSearch.Columns["mother_work"].Visible = false;
            this.dgvSearch.Columns["guardian_name"].Visible = false;
            this.dgvSearch.Columns["guardian_work"].Visible = false;
            this.dgvSearch.Columns["guardian_address"].Visible = false;
            this.dgvSearch.Columns["guardian_relationship"].Visible = false;
            this.dgvSearch.Columns["guardian_contactNo"].Visible = false;
            this.dgvSearch.Columns["guardian_telNo"].Visible = false;
            this.dgvSearch.Columns["bc"].Visible = false;
            this.dgvSearch.Columns["form138"].Visible = false;
            this.dgvSearch.Columns["drugtest"].Visible = false;
            this.dgvSearch.Columns["good_moral"].Visible = false;
            this.dgvSearch.Columns["en_exam"].Visible = false;
            this.dgvSearch.Columns["ncae"].Visible = false;
            this.dgvSearch.Columns["date_enrolled"].Visible = false;
            // this.dgvSearch.Columns["sy_enrolled"].Visible = false;
            this.dgvSearch.Columns["1"].Visible = false;
            this.dgvSearch.Columns["2"].Visible = false;
            #endregion


            #region designing DVG
            dgvSearch.BorderStyle = BorderStyle.None;
            //dgvSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 244, 246);
            dgvSearch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSearch.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 244, 246);
            dgvSearch.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvSearch.BackgroundColor = Color.White;

            dgvSearch.EnableHeadersVisualStyles = false;
            dgvSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvSearch.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans Light", 14F, GraphicsUnit.Pixel);
            dgvSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(91, 87, 91);
            dgvSearch.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            DataGridViewColumn gncol = dgvSearch.Columns["GOCNo"];
            //gncol.Width = 220;

            DataGridViewColumn gncol2 = dgvSearch.Columns["Full_Name"];
            //gncol2.Width = 575;


            #endregion

            txtSearch.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SelectData();
            }
        }

        private void dgvSearch_DoubleClick_1(object sender, EventArgs e)
        {
            
        }

        private void dgvSearch_DoubleClick(object sender, EventArgs e)
        {
SelectData();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string valueToSearch = txtSearch.Text.ToString();
            searchData(valueToSearch);
        }

        private void txtSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SelectData();
            }
        }

        private void dgvSearch_DoubleClick_2(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Proceed to Production Billing?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                SelectData();
            }
            else if (result == DialogResult.No)
            {
                //...
            }
            else
            {
                //...
            }
        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
