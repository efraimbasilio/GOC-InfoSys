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

                    string sql = "SELECT * FROM student_profile WHERE CONCAT(`last_name`, `first_name`,`regno`) LIKE '%" + valueToSearch + "%'";

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

                    //if (item.FullPayment.Equals("1"))
                    //{
                    //    frmBilling.lblFullPayment.ForeColor = Color.Red;
                    //    frmBilling.lblFullPayment.BackColor = Color.Black;
                    //    frmBilling.cmbMOP.Text = "Full Payment";
                    //    frmBilling.CTRpayment = 3;
                    //}                    
                }

                frmBilling.CallPaymentNumber();
                frmBilling.GetPerMonth();


                //set up before form load
                this.Hide();
                frmBilling.Render();
                frmBilling.ShowDialog();
                //this.Dispose();
            }
        }

        private void LoadRecords()
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
            LoadRecords();
            #region designing DVG

            dgvSearch.BorderStyle = BorderStyle.None;
            dgvSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 246, 251);
            dgvSearch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSearch.DefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 236, 240);
            dgvSearch.DefaultCellStyle.SelectionForeColor = Color.Gray;
            dgvSearch.BackgroundColor = Color.White;

            dgvSearch.EnableHeadersVisualStyles = false;
            dgvSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvSearch.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            DataGridViewColumn gncol = dgvSearch.Columns[1];
            gncol.Width = 220;

            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string valueToSearch = txtSearch.Text.ToString();
            searchData(valueToSearch);
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
    }
}
