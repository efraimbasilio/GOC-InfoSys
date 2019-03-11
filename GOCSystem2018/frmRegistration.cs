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
    public partial class frmRegistration : Form
    {
        Registration registration = new Registration();
        SchoolYear schoolYear = new SchoolYear();
        Assesment assesment = new Assesment();
        Voucher voucher = new Voucher();

        List<Voucher> vouchers = new List<Voucher>();
        List<Assesment> assements = new List<Assesment>();
        frmAssesment frmAssesment = new frmAssesment();
        List<SchoolYear> schoolYears = new List<SchoolYear>();
        public string School;
        public void LoadSchoolYear()
        {
            //clear list

            //dgvDiscount.Rows.Clear();

            schoolYears.Clear();

            //pass value to list
            schoolYears = schoolYear.Load();

            //loop through load it to list view
            foreach (var item in schoolYears)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
               
                School = (item.YearStart + " - " + item.YearEnd);
               
                //cmbSchoolYear.Items.Add(School);
            }
        }//End LoadRecords()


        public void LoadAutoGen()
        {
            //clear list           
            assements.Clear();

            //pass value to list
            //MessageBox.Show(assements.Count().ToString());
            if (assements.Count() < 1)
            {
                txtRegno.Text = "REG-" + DateTime.Today.ToString("yyyy") + "-" + (1).ToString("0000");
            }

            assements = assesment.Load();
                  
            foreach (var item in assements)
            {
                      
                    txtRegno.Text = "REG-" + DateTime.Today.ToString("yyyy") + "-" + (item.Id + 1).ToString("0000");
                                                   
            }
        }//End LoadRecords() OK

        public frmRegistration()
        {
            InitializeComponent();
        }

        private bool CheckRequiredFields()
        {
            if (LRNtxt.Text == "")
            {
                //MessageBox.Show("LRN Missing");
                return false;
            }

            if (cmbStudType.Text == "")
            {
                //MessageBox.Show("Student Missing");
                return false;
            }

            if (cmbCourseStrand.Text == "")
            {
                return false;
            }

            if (txtFName.Text == "")
            {
                return false;
            }

            if (txtMName.Text == "")
            {
                return false;
            }
            if (txtLastName.Text == "")
            {
                return false;
            }
            if (txtAddress.Text == "")
            {
                return false;
            }

            if (txtBarangay.Text == "")
            {
                return false;
            }

            if (cmbMunicipality.Text == "")
            {
                return false;
            }

            if (cmbProvince.Text == "")
            {
                return false;
            }

            if (txtBirthPlace.Text == "")
            {
                return false;
            }

            if (optMale.Checked == false || optFemale.Checked == false)
            {
                if (optFemale.Checked == true)
                {
                    return true;
                }

                if (optMale.Checked == true)
                {
                    return true;
                }

                return false;                           
            }

            if (opt1stYear.Checked == false || opt2ndYear.Checked == false || opt3rdYear.Checked == false || opt4thYear.Checked == false)
            {
                if (opt1stYear.Checked == true)
                {
                    return true;
                }
                if (opt2ndYear.Checked == true)
                {
                    return true;
                }

                if (opt3rdYear.Checked == true)
                {
                    return true;
                }

                if (opt4thYear.Checked == true)
                {
                    return true;
                }
                return false;
            }

            if (optAcademic.Checked == false || optTVL.Checked == false || optCollege.Checked == false)
            {
                if (optAcademic.Checked == true)
                {
                    return true;
                }

                if (optTVL.Checked == true)
                {
                    return true;
                }

                if (optCollege.Checked == true)
                {
                    return true;
                }
                return false;
            }


            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

           
           
        }

        private void checkGender()
        {
            if (optMale.Checked)
            {
                registration.StudGender = optMale.Text;
            }

            else if (optFemale.Checked)
            {
                registration.StudGender = optFemale.Text;
            }
        }
        private void checkYearLevel()
        {
           if (opt1stYear.Checked)
            {
                registration.StudGradeLevel = opt1stYear.Text;
                frmAssesment.GradeLevel = opt1stYear.Text;
            }

            else if (opt2ndYear.Checked)
            {
                registration.StudGradeLevel = opt2ndYear.Text;
                frmAssesment.GradeLevel = opt1stYear.Text;
            }

            else if (opt3rdYear.Checked)
            {
                registration.StudGradeLevel = opt3rdYear.Text;
                frmAssesment.GradeLevel = opt1stYear.Text;
            }
            else if (opt4thYear.Checked)
            {
                registration.StudGradeLevel = opt4thYear.Text;
                frmAssesment.GradeLevel = opt1stYear.Text;
            }
        }

        private void CheckTrack()
        {
            if (optAcademic.Checked)
            {
                registration.StudAcadTrack = optAcademic.Text;
                frmAssesment.Track = optAcademic.Text;
            }

            else if (optTVL.Checked)
            {
                registration.StudAcadTrack = optTVL.Text;
                frmAssesment.Track = optTVL.Text;
            }

            else if (optCollege.Checked)
            {
                registration.StudAcadTrack = optTVL.Text;
                frmAssesment.Track = optCollege.Text;
            }
        }

        private void checkRequirements()
        {
            if (chkEntranceExam.Checked)
            {
                registration.ReqAdmissionTest = chkEntranceExam.Text;
            }

            if (chkBirthCertificate.Checked)
            {
                registration.ReqPSA = chkBirthCertificate.Text;
            }

            if (chkDrugtest.Checked)
            {
                registration.ReqDrugTest = chkDrugtest.Text;
            }

            if (chk138.Checked)
            {
                registration.ReqForm138 = chk138.Text;
            }

            if (chckGM.Checked)
            {
                registration.ReqGoodMoral = chckGM.Text;
            }

            if (chkEntranceExam.Checked)
            {
                registration.ReqAdmissionTest = chkEntranceExam.Text;
            }

            if (chkNCAEResult.Checked)
            {
                registration.ReqNCAE = chkNCAEResult.Text;
            }

        }
        public void LoadVoucher()
        {
            //clear list
            cmbVoucher.Items.Clear();
            vouchers.Clear();

            //pass value to list
            vouchers = voucher.Load();

            //loop through load it to list view
            foreach (var item in vouchers)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                cmbVoucher.Items.Add(item.VoucherFrom);
            }
        }//End LoadRecords(

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            LoadAutoGen();
            LoadSchoolYear();   
            opt1stYear.Text = "11";
            opt2ndYear.Text = "12";
            opt3rdYear.Visible = false;
            opt4thYear.Visible = false;
            cmbCourseStrand.Text = "";
            LoadCombo();
            panel4.Visible = false;
            panel3.Location = new Point(31, 690);
            LoadVoucher();

        }

    void LoadCombo()
        {
            if (optTVL.Checked)
            {
      
                cmbCourseStrand.Items.Clear();
                cmbCourseStrand.Items.Add("TVL - ICT");
                cmbCourseStrand.Items.Add("TVL - HE");
                frmAssesment.Track = optTVL.Text;
            }
            else if(optAcademic.Checked)
            {
                
                cmbCourseStrand.Items.Clear();
                cmbCourseStrand.Items.Add("ABM");
                cmbCourseStrand.Items.Add("HUMSS");
                cmbCourseStrand.Items.Add("STEM");
                frmAssesment.Track = optAcademic.Text;

            }
            else if(optCollege.Checked)
            {
                frmAssesment.Track = optCollege.Text;
                cmbCourseStrand.Items.Clear();
                cmbCourseStrand.Items.Add("BSHRM");
                cmbCourseStrand.Items.Add("BSA");
                cmbCourseStrand.Items.Add("BSRM");
            }                      
        }

        private void optTVL_CheckedChanged(object sender, EventArgs e)
        {
            opt1stYear.Text = "11";
            opt2ndYear.Text = "12";
            opt3rdYear.Visible = false;
            opt4thYear.Visible = false;
            cmbCourseStrand.Text = "";
            LoadCombo();
        }

        private void optAcademic_CheckedChanged(object sender, EventArgs e)
        {
            opt1stYear.Text = "11";
            opt2ndYear.Text = "12";
            opt3rdYear.Visible = false;
            opt4thYear.Visible = false;
            cmbCourseStrand.Text = "";
            LoadCombo();
        }

        private void optCollege_CheckedChanged(object sender, EventArgs e)
        {
            opt3rdYear.Visible = true;
            opt4thYear.Visible = true;
            opt1stYear.Text = "1";
            opt2ndYear.Text = "2";
            opt3rdYear.Text = "3";
            opt4thYear.Text = "4";
            cmbCourseStrand.Text = "";
            LoadCombo();
        }

        private void chkEntranceExam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }

        private void LRNtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLRN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLRN_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void LRNtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtFName_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void txtMName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void cmbProvince_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmbProvince.SelectedItem.Equals("Aurora"))
            {
                cmbMunicipality.Items.Clear();
                cmbMunicipality.Items.Add("Baler");
                cmbMunicipality.Items.Add("Casiguran ");
                cmbMunicipality.Items.Add("Dilasag ");
                cmbMunicipality.Items.Add("Dinalungan ");
                cmbMunicipality.Items.Add("Dingalan ");
                cmbMunicipality.Items.Add("Dipaculao ");
                cmbMunicipality.Items.Add("Maria Aurora ");
                cmbMunicipality.Items.Add("San Luis");



            }
            if (cmbProvince.SelectedItem.Equals("Bataan"))
            {
                cmbMunicipality.Items.Clear();
                cmbMunicipality.Items.Add("Abucay");
                cmbMunicipality.Items.Add("Bagac");
                cmbMunicipality.Items.Add("Dinalupihan");
                cmbMunicipality.Items.Add("Hermosa");
                cmbMunicipality.Items.Add("Limay");
                cmbMunicipality.Items.Add("Mariveles");
                cmbMunicipality.Items.Add("Morong");
                cmbMunicipality.Items.Add("Orani");
                cmbMunicipality.Items.Add("Orion");
                cmbMunicipality.Items.Add("Pilar");
                cmbMunicipality.Items.Add("SamalCity Of Balanga");

            }

            if (cmbProvince.SelectedItem.Equals("Bulacan"))
            {
                cmbMunicipality.Items.Clear();
                cmbMunicipality.Items.Add("Angat ");
                cmbMunicipality.Items.Add("Balagtas ");
                cmbMunicipality.Items.Add("Baliuag ");
                cmbMunicipality.Items.Add("Bocaue ");
                cmbMunicipality.Items.Add("Bulacan ");
                cmbMunicipality.Items.Add("Bustos ");
                cmbMunicipality.Items.Add("Calumpit ");
                cmbMunicipality.Items.Add("Doña Remedios ");
                cmbMunicipality.Items.Add("Trinidad ");
                cmbMunicipality.Items.Add("Guiguinto ");
                cmbMunicipality.Items.Add("Hagonoy ");
                cmbMunicipality.Items.Add("Marilao ");
                cmbMunicipality.Items.Add("Meycauayan City ");
                cmbMunicipality.Items.Add("Norzagaray ");
                cmbMunicipality.Items.Add("Obando ");
                cmbMunicipality.Items.Add("Pandi ");
                cmbMunicipality.Items.Add("Paombong ");
                cmbMunicipality.Items.Add("Plaridel ");
                cmbMunicipality.Items.Add("Pulilan ");
                cmbMunicipality.Items.Add("San Ildefonso ");
                cmbMunicipality.Items.Add("San Miguel ");
                cmbMunicipality.Items.Add("San Rafael ");
                cmbMunicipality.Items.Add("Santa Maria Malolos City");
                cmbMunicipality.Items.Add("San Jose Del Monte City");


            }

            if (cmbProvince.SelectedItem.Equals("Nueva Ecija"))
            {
                cmbMunicipality.Items.Clear();
                cmbMunicipality.Items.Add("Aliaga ");
                cmbMunicipality.Items.Add("Bongabon ");
                cmbMunicipality.Items.Add("Cabiao ");
                cmbMunicipality.Items.Add("Carranglan ");
                cmbMunicipality.Items.Add("Cuyapo ");
                cmbMunicipality.Items.Add("Gabaldon ");
                cmbMunicipality.Items.Add("General Mamerto Natividad ");
                cmbMunicipality.Items.Add("General Tinio ");
                cmbMunicipality.Items.Add("Guimba ");
                cmbMunicipality.Items.Add("Jaen ");
                cmbMunicipality.Items.Add("Laur ");
                cmbMunicipality.Items.Add("Licab ");
                cmbMunicipality.Items.Add("Llanera ");
                cmbMunicipality.Items.Add("Lupao ");
                cmbMunicipality.Items.Add("Nampicuan ");
                cmbMunicipality.Items.Add("Pantabangan ");
                cmbMunicipality.Items.Add("Peñaranda ");
                cmbMunicipality.Items.Add("Quezon ");
                cmbMunicipality.Items.Add("Rizal ");
                cmbMunicipality.Items.Add("San Antonio ");
                cmbMunicipality.Items.Add("San Isidro ");
                cmbMunicipality.Items.Add("San Leonardo ");
                cmbMunicipality.Items.Add("Santa Rosa ");
                cmbMunicipality.Items.Add("Santo Domingo ");
                cmbMunicipality.Items.Add("Talavera ");
                cmbMunicipality.Items.Add("Talugtug ");
                cmbMunicipality.Items.Add("Zaragoza  ");
                cmbMunicipality.Items.Add("Cabanatuan City ");
                cmbMunicipality.Items.Add("Gapan City ");
                cmbMunicipality.Items.Add("Muñoz Science City ");
                cmbMunicipality.Items.Add("Palayan City");
                cmbMunicipality.Items.Add("San Jose City");



            }

            if (cmbProvince.SelectedItem.Equals("Pampanga"))
            {
                cmbMunicipality.Items.Clear();
                cmbMunicipality.Items.Add("Apalit ");
                cmbMunicipality.Items.Add("Arayat ");
                cmbMunicipality.Items.Add("Bacolor ");
                cmbMunicipality.Items.Add("Candaba ");
                cmbMunicipality.Items.Add("Floridablanca ");
                cmbMunicipality.Items.Add("Guagua ");
                cmbMunicipality.Items.Add("Lubao ");
                cmbMunicipality.Items.Add("Macabebe ");
                cmbMunicipality.Items.Add("Magalang ");
                cmbMunicipality.Items.Add("Masantol ");
                cmbMunicipality.Items.Add("Mexico ");
                cmbMunicipality.Items.Add("Minalin ");
                cmbMunicipality.Items.Add("Porac ");
                cmbMunicipality.Items.Add("San Luis ");
                cmbMunicipality.Items.Add("San Simon ");
                cmbMunicipality.Items.Add("Santa Ana ");
                cmbMunicipality.Items.Add("Santa Rita ");
                cmbMunicipality.Items.Add("Santo Tomas ");
                cmbMunicipality.Items.Add("Sasmuan ");
                cmbMunicipality.Items.Add("Angeles City ");
                cmbMunicipality.Items.Add("Mabalacat ");
                cmbMunicipality.Items.Add("San Fernando City");
            }

            if (cmbProvince.SelectedItem.Equals("Tarlac"))
            {
                cmbMunicipality.Items.Clear();
                cmbMunicipality.Items.Add("Anao");
                cmbMunicipality.Items.Add("Bamban ");
                cmbMunicipality.Items.Add("Camiling ");
                cmbMunicipality.Items.Add("Capas ");
                cmbMunicipality.Items.Add("Concepcion ");
                cmbMunicipality.Items.Add("Gerona ");
                cmbMunicipality.Items.Add("La Paz ");
                cmbMunicipality.Items.Add("Mayantoc ");
                cmbMunicipality.Items.Add("Moncada ");
                cmbMunicipality.Items.Add("Paniqui ");
                cmbMunicipality.Items.Add("Pura ");
                cmbMunicipality.Items.Add("Ramos ");
                cmbMunicipality.Items.Add("San Clemente ");
                cmbMunicipality.Items.Add("San Jose ");
                cmbMunicipality.Items.Add("San Manuel ");
                cmbMunicipality.Items.Add("Santa Ignacia ");
                cmbMunicipality.Items.Add("Victoria  ");
                cmbMunicipality.Items.Add("Tarlac City");

            }

            if (cmbProvince.SelectedItem.Equals("Zambales"))
            {
                cmbMunicipality.Items.Clear();
                cmbMunicipality.Items.Add("Botolan ");
                cmbMunicipality.Items.Add("Cabangan ");
                cmbMunicipality.Items.Add("Candelaria ");
                cmbMunicipality.Items.Add("Castillejos ");
                cmbMunicipality.Items.Add("Iba");
                cmbMunicipality.Items.Add("Masinloc ");
                cmbMunicipality.Items.Add("Palauig ");
                cmbMunicipality.Items.Add("San Antonio ");
                cmbMunicipality.Items.Add("San Felipe ");
                cmbMunicipality.Items.Add("San Marcelino ");
                cmbMunicipality.Items.Add("San Narciso ");
                cmbMunicipality.Items.Add("Santa Cruz ");
                cmbMunicipality.Items.Add("Subic  ");
                cmbMunicipality.Items.Add("Olongapo City");
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            panel4.Visible = true;
            panel3.Location = new Point(31, 998);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAssesment.Reset();
            frmAssesment.LoadSection();
            frmAssesment.LoadSchoolYear();
            
            this.Hide();
            frmAssesment.Show();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (this.CheckRequiredFields() == true)
            {
                registration.StudType = cmbStudType.Text;

                registration.StudLRN = LRNtxt.Text;
                registration.StudGOCNo = "GOC";
                registration.StudRegistrationNo = txtRegno.Text;
                registration.StudLastName = txtLastName.Text;
                registration.StudMiddleName = txtMName.Text;
                registration.StudFirstName = txtFName.Text;

                registration.StudStrand = cmbCourseStrand.Text;
                registration.StudVoucher = cmbVoucher.Text;
                registration.StudAddress1 = txtAddress.Text + " " + txtBarangay.Text + " " + cmbMunicipality.Text + " " + cmbProvince.Text;

                registration.StudDateOfBirth = dtBirthday.Value.ToString("yyyy-MM-dd");
                registration.StudBirthPlace = txtBirthPlace.Text;

                registration.Religion = txtReligion.Text;
                registration.Nationality = cmbNationality.Text;
                //registration.StudGender = checkGender.Text;
                registration.StudContactNo = txtStudCell.Text;
                registration.StudTelNo = txtTelNo.Text;
                registration.StudPrevSchool = txtLastSchool.Text;
                registration.StudPrevSchoolAddress = txtLastSchAddress.Text;

                registration.FatherName = txtFatherName.Text;
                registration.MotherName = txtMother.Text;
                registration.MotherWork = txtMotherWork.Text;
                registration.FatherWork = txtFatherWork.Text;

                registration.GuardianName = txtGuardianName.Text;
                registration.GuardianWork = txtGuardianWork.Text;
                registration.GuardianCompleteAddress = txtAddress2.Text + " " + txtBarangay2.Text + " " + cmbMunicipality2.Text + " " + cmbProvince2.Text;
                registration.GuardianRelationship = txtRelation.Text;
                registration.GuardianContactNo = txtGuardianCell.Text;
                registration.GuardianTelNo = txtGuardianTel.Text;
                registration.SYEnrolled = School;
                registration.DateEnrolled = DateTime.Today.ToString("yyyy-mm-dd");
                //////////////////////////////////////
                registration.Reservee = "NA";
                registration.ReserveFor = "NA";
                registration.PartialPayment = "NA";
                registration.FullPayment = "NA";
               
                //function to load important filtering
                checkYearLevel();
                CheckTrack();
                checkRequirements();
                checkGender();

                //save the info to database
                registration.Save();

                //clear in assesment
                frmAssesment.Reset();
                assements.Clear();

                frmAssesment.RegNo = txtRegno.Text;
                frmAssesment.StudName = txtLastName.Text + " , " + txtFName.Text + " " + txtMName.Text;
                frmAssesment.LRN = LRNtxt.Text;
                frmAssesment.Strand = cmbCourseStrand.Text;
                //frmAssesment.tuitionFees2();

                frmAssesment.LoadSection();
                frmAssesment.LoadSchoolYear();
                frmAssesment.Voucher = cmbVoucher.Text;
                frmAssesment.ComputeVoucher();
                //frmAssesment.LoadStrand();
                //frmAssesment.RenderStudNo();

                this.Hide();
                frmAssesment.Show();

            }
            else
            {
                MessageBox.Show("Please fill out all required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
