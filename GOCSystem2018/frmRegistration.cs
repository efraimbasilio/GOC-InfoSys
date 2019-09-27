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
    public partial class frmRegistration : Form
    {
        Registration registration = new Registration();
        SchoolYear schoolYear = new SchoolYear();
        Assesment assesment = new Assesment();
        Voucher voucher = new Voucher();
        StudentProfile sp = new StudentProfile();
        TempRegNo tempRegno = new TempRegNo();

        List<Voucher> vouchers = new List<Voucher>();
        List<Assesment> assements = new List<Assesment>();
        frmAssesment frmAssesment = new frmAssesment();
        List<SchoolYear> schoolYears = new List<SchoolYear>();
        List<StudentProfile> sps = new List<StudentProfile>();

        List<TempRegNo> tempRegNos = new List<TempRegNo>();


        public string RegNo, LRN, VType, StudType, Track, Grade_Level, StrandCourse, F_Name, M_Name, L_Name, Religion, Nationality, Gender, Birthdate, Place_of_birth;
        public string House_No, Barangay, Provice, Municipality, Cell_No, Tel_No,Last_School, School_Address, Father,Mother, Guardian, F_Contact, M_Contact, F_Occupation,M_Occupation,G_Occupation,G_House_No, G_Barangay;
        public string G_Municipality,G_Province,G_Relationship,G_CellNo,G_TelNo;
        public string Edit_Address, Edit_GuardianAddress, The_GOC_No, OLD_IDNO;

        public string _PSA, _FORM_138, _MD, _GM, _ESV, _NCAE;

        public bool toEdit = false;
        public bool Profile_edit = false;
        public bool other_address;

        public string School, RegistrationNumber , TempRegNumber;



        public void UpdateAssess()
        {
            LRNtxt.Text = LRN;
            txtRegno.Text = RegNo;
            txtFName.Text = F_Name;
            txtMName.Text = M_Name;
            txtLastName.Text = L_Name;
        }


        public void EditRender()
        {
            LoadVoucher();
            

            //pass variable to form Assesment
            txtRegno.Text = RegNo;
            LRNtxt.Text = LRN;
            txtOldStudNo.Text = OLD_IDNO;
            //MessageBox.Show(VType.ToString());
            cmbVoucher.Text = VType.ToString();
            cmbStudType.Text = StudType;

            txtEditTrack.Text = Track;
            txtEditGLevel.Text = Grade_Level;
            txtGender.Text = Gender;

            txtEditGM.Text = _GM;
            txtEditMC.Text = _MD;
            txtEditNCAE.Text = _NCAE;
            txtEditPSA.Text = _PSA;
            txtEdit138.Text = _FORM_138;
            txtESC.Text = _ESV;


            if (txtEditTrack.Text.Equals("ACADEMIC"))
            {
                optAcademic.Checked = true;
            }

            if (txtEditTrack.Text.Equals("TECH-VOC"))
            {
                optTVL.Checked = true;
            }

            if (txtEditTrack.Text.Equals("COLLEGE"))
            {
                optCollege.Checked = true;
            }


            if (txtEditGLevel.Text.Equals("11"))
            {
                opt1stYear.Checked = true;
            }

            if (txtEditGLevel.Text.Equals("12"))
            {
                opt2ndYear.Checked = true;
            }


            if (txtGender.Text.Equals("Male"))
            {
                optMale.Checked = true;
            }

            if (txtGender.Text.Equals("Female"))
            {
                optFemale.Checked = true;
            }

            if (txtEditPSA.Text.Equals("PSA / Birth Certificate"))
            {
                chkBirthCertificate.Checked = true;
            }

            if (txtEdit138.Text.Equals("Form 138"))
            {
                chk138.Checked = true;
            }

            if (txtEditMC.Text.Equals("Medical Certificate"))
            {
                chkDrugtest.Checked = true;
            }

            if (txtEditGM.Text.Equals("Good Moral"))
            {
                chckGM.Checked = true;
            }
            if (txtESC.Text.Equals("ESC Voucher"))
            {
                chkEntranceExam.Checked = true;
            }
            if (txtEditNCAE.Text.Equals("NCAE Result"))
            {
                chkNCAEResult.Checked = true;
            }


            cmbCourseStrand.Text = StrandCourse;
            txtFName.Text = F_Name;
            txtMName.Text = M_Name;
            txtLastName.Text = L_Name;
            txtReligion.Text = Religion;
            cmbNationality.Text = Nationality;
          
            dtBirthday.Text = Birthdate;
            txtBirthPlace.Text = Place_of_birth;

            txtEditAddress.Text = Edit_Address;

            txtStudCell.Text = Cell_No;
            txtTelNo.Text = Tel_No;
            txtLastSchool.Text = Last_School;
            txtLastSchAddress.Text = School_Address;

            txtFatherName.Text = Father;
            txtFatherWork.Text = F_Occupation;
            txtMother.Text = Mother;
            txtMotherWork.Text = M_Occupation;

            txtMotherContact.Text = M_Contact;
            txtFatherContact.Text = F_Contact;

            txtGuardianName.Text = Guardian;
            txtGuardianCell.Text = G_CellNo;
            txtGuardianTel.Text = G_TelNo;

            txtGuardianWork.Text = G_Occupation;
            txtRelation.Text = G_Relationship;

            txtEditAddressGuardian.Text = Edit_GuardianAddress;
           
        }


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
            sps.Clear();
            MessageBox.Show(sps.Count().ToString());
            
            //pass value to list
            //MessageBox.Show(assements.Count().ToString());
            if (sps.Count() < 1)
            {
                txtRegno.Text = "REG-" + DateTime.Today.ToString("yyyy") + "-" + (1).ToString("0000");
            }

            sps = sp.Load();

            foreach (var item in sps)
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
            if (cmbStudType.Text.Equals("Old Student"))
            {
                if (txtOldStudNo.Text == "")
                {
                    //MessageBox.Show("LRN Missing");
                    return false;
                }
            }

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

            //if (txtMName.Text == "")
            //{
            //    return false;
            //}
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

            if (txtStudCell.Text == "")
            {
                return false;
            }

            if (txtLastSchool.Text == "")
            {
                return false;
            }

            if (txtLastSchAddress.Text == "")
            {
                return false;
            }

            if (txtFatherContact.Text == "")
            {
                return false;
            }

            if (txtMotherContact.Text == "")
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
                sp.StudGender = optMale.Text;
            }

            else if (optFemale.Checked)
            {
                registration.StudGender = optFemale.Text;
                sp.StudGender = optFemale.Text;
            }
        }
        private void checkYearLevel()
        {
           if (opt1stYear.Checked)
            {
                registration.StudGradeLevel = opt1stYear.Text;
                sp.StudGradeLevel = opt1stYear.Text;
                frmAssesment.GradeLevel = opt1stYear.Text;

            }

            else if (opt2ndYear.Checked)
            {
                registration.StudGradeLevel = opt2ndYear.Text;
                sp.StudGradeLevel = opt2ndYear.Text;
                frmAssesment.GradeLevel = opt2ndYear.Text;
            }

            else if (opt3rdYear.Checked)
            {
                sp.StudGradeLevel = opt3rdYear.Text;
                registration.StudGradeLevel = opt3rdYear.Text;
                frmAssesment.GradeLevel = opt3rdYear.Text;
            }
            else if (opt4thYear.Checked)
            {
                registration.StudGradeLevel = opt4thYear.Text;
                sp.StudGradeLevel = opt4thYear.Text;
                frmAssesment.GradeLevel = opt4thYear.Text;
            }
        }

        private void CheckTrack()
        {
            if (optAcademic.Checked)
            {
                registration.StudAcadTrack = optAcademic.Text;
                sp.StudAcadTrack = optAcademic.Text;
                frmAssesment.Track = optAcademic.Text;
            }

            else if (optTVL.Checked)
            {
                registration.StudAcadTrack = optTVL.Text;
                sp.StudAcadTrack = optTVL.Text;
                frmAssesment.Track = optTVL.Text;
            }

            else if (optCollege.Checked)
            {
                registration.StudAcadTrack = optCollege.Text;
                sp.StudAcadTrack = optCollege.Text;
                frmAssesment.Track = optCollege.Text;
            }
        }

        private void checkRequirements()
        {
            if (chkEntranceExam.Checked)
            {
                registration.ReqAdmissionTest = chkEntranceExam.Text;
                sp.ReqAdmissionTest = chkEntranceExam.Text;
            }
            else
            {
                registration.ReqAdmissionTest = "NA";
                sp.ReqAdmissionTest = "NA";
            }

            if (chkBirthCertificate.Checked)
            {
                registration.ReqPSA = chkBirthCertificate.Text;
                sp.ReqPSA = chkBirthCertificate.Text;
            }
            else
            {
                registration.ReqPSA = "NA";
                sp.ReqPSA = "NA";
            }


            if (chkDrugtest.Checked)
            {
                registration.ReqDrugTest = chkDrugtest.Text;
                sp.ReqDrugTest = chkDrugtest.Text;
            }
            else
            {
                registration.ReqDrugTest = "NA";
                sp.ReqDrugTest = "NA";
            }

            if (chk138.Checked)
            {
                registration.ReqForm138 = chk138.Text;
                sp.ReqForm138 = chk138.Text;
            }
            else
            {
                registration.ReqForm138 = "NA";
                sp.ReqForm138 = "NA";
            }

            if (chckGM.Checked)
            {
                registration.ReqGoodMoral = chckGM.Text;
                sp.ReqGoodMoral = chckGM.Text;
            }
            else
            {
                registration.ReqGoodMoral = "NA";
                sp.ReqGoodMoral = "NA";
            }


            if (chkEntranceExam.Checked)
            {
                registration.ReqAdmissionTest = chkEntranceExam.Text;
                sp.ReqAdmissionTest = chkEntranceExam.Text;
            }
            else
            {
                registration.ReqAdmissionTest = "NA";
                sp.ReqAdmissionTest = "NA";
            }

            if (chkNCAEResult.Checked)
            {
                registration.ReqNCAE = chkNCAEResult.Text;
                sp.ReqNCAE = chkNCAEResult.Text;
            }
            else
            {
                registration.ReqNCAE = "NA";
                sp.ReqNCAE = "NA";
            }

        }

        private void txtFatherWork_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMotherWork_TextChanged(object sender, EventArgs e)
        {

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

        public void CheckRegNo()
        {
            LoadTempRegNo();
                //LoadRecordsTempRegNo();
                RegNoCount();
                CheckRegNoCount();

                LoadSchoolYear();
                opt1stYear.Text = "11";
                opt2ndYear.Text = "12";
                opt3rdYear.Visible = false;
                opt4thYear.Visible = false;
                cmbCourseStrand.Text = "";
                LoadCombo();
                LoadVoucher();
            
           
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            #region Screen_Setting
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            this.Width = intX;
            this.Height = intY;
            this.Left = 0;
            this.Top = 0;
            #endregion







        }

        public void TempRegNo()
        {
            tempRegno.Temp_RegNo = txtRegno.Text;
            tempRegno.Save();
        }

        public void CheckRegNoCount()
        {
            //clear list           
            tempRegNos.Clear();

            
            //pass value to list
            //MessageBox.Show(assements.Count().ToString());
            if (dgvTempRegno.Rows.Count - 1 < 1)
            {
                //MessageBox.Show(tempRegNos.Count().ToString());
                txtRegno.Text = "REG-" + DateTime.Today.ToString("yyyy") + "-" + (1).ToString("0000");
                TempRegNo();//save temp Regno
            }
            else
            {
                //MessageBox.Show(tempRegNos.Count().ToString() + "meron na laman");
                tempRegNos = tempRegno.Load();

                foreach (var item in tempRegNos)
                {

                    txtRegno.Text = "REG-" + DateTime.Today.ToString("yyyy") + "-" + (item.Id + 1).ToString("0000");
                    
                }
                TempRegNo();//save temp Regno
            }     
        }//End LoadRecords() OK

        private void cmbStudType_SelectedIndexChanged(object sender, EventArgs e)
        {
            optAcademic.Checked = true;
            if (cmbStudType.Text.Equals("Old Student"))
            {
                opt2ndYear.Checked = true;
            }
            else
            {
                opt1stYear.Checked = true;
            }
        }

        private void dtBirthday_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                dtBirthday.Select(0, 0);
            });
        }

        private void txtStudCell_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtStudCell.Select(0, 0);
            });
        }

        private void txtTelNo_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtTelNo.Select(0, 0);
            });
        }

        private void txtFatherContact_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtFatherContact.Select(0, 0);
            });
        }

        private void txtMotherContact_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtMotherContact.Select(0, 0);
            });
        }

        private void txtGuardianCell_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtGuardianCell.Select(0, 0);
            });
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           

          
        }

        private void cmbStudType_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cmbStudType.Text.Equals("Old Student"))
           // {
                txtOldStudNo.Visible = true;
           // }
        }

        private void txtBarangay2_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtGuardianTel_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtGuardianTel.Select(0, 0);
            });
        }

        private void opt1stYear_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opt1stYear_Click(object sender, EventArgs e)
        {
            cmbStudType.Text = "New Student";
            txtOldStudNo.Visible = true; ////to true for saving SY: 2019 : 2020 temp: 9.27.2019
            txtOldStudNo.Focus();
        }

        private void opt2ndYear_Click(object sender, EventArgs e)
        {
            cmbStudType.Text = "Old Student";
            txtOldStudNo.Visible = true;
            txtOldStudNo.Focus();
        }

        private void dtBirthday_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LRNtxt_TextChanged_1(object sender, EventArgs e)
        {
            if (LRNtxt.MaskFull == true)
            {
                LRNtxt.BackColor = Color.White;
            }
        }

        private void LRNtxt_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                LRNtxt.Select(0, 0);
            });
        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private bool otherAddress()
        {
            if (txtAddress.Text == "" && other_address == true)
            {
               
                return true;
            }

            if (txtBarangay.Text == "" && other_address == true)
            {
               
                return true;
            }

            if (cmbProvince.Text == "" && other_address == true)
            {
                
                return true;
            }

            if (cmbMunicipality.Text == "" && other_address == true)
            {
                
                return true;
            }

            return false;
        }

        private void chkOtherAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtherAddress.Checked == true)
            {
                other_address = true;
                otherAddress();
                txtOtherAddress.Enabled = true;
            
                txtAddress.Text = string.Empty;
                
                cmbProvince.Text = string.Empty;
                cmbMunicipality.Text = string.Empty;
                txtBarangay.Text = string.Empty;

                txtAddress.Enabled = false;
                cmbMunicipality.Enabled = false;
                cmbProvince.Enabled = false;
                txtBarangay.Enabled = false;

            }
            else
            {
                other_address = false;
                otherAddress();

                txtOtherAddress.Enabled = false;
                txtOtherAddress.Text = string.Empty;

                txtAddress.Enabled = true;
                cmbMunicipality.Enabled = true;
                cmbProvince.Enabled = true;
                txtBarangay.Enabled = true;

               
                
            }  
        }

        public void RegNoCount()
        {
            int sum = 0;
            for (int i = 0; i < dgvTempRegno.Rows.Count -1; i++)
            {
                 sum = sum + 1;
            }
           // MessageBox.Show("Laman is" + sum);
        }

        public void LoadRecordsTempRegNo()
        {
            //try
            //{
            //    using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
            //    {
            //        con.Open();
            //        string sql = "SELECT * FROM tempregno";
            //        MySqlCommand cmd = new MySqlCommand(sql, con);
            //        MySqlDataAdapter da = new MySqlDataAdapter();
            //        da.SelectCommand = cmd;

            //        //initialize new datatable
            //        DataTable dt = new DataTable();
            //        da.Fill(dt);
            //        dgvTempRegno.DataSource = dt;
            //    }
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            
        }

        public void LoadTempRegNo()
        {
            //clear list
            tempRegNos.Clear();
            dgvTempRegno.Rows.Clear();
            //pass value to list
            tempRegNos = tempRegno.Load();

            //loop through load it to list view
            foreach (var item in tempRegNos)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                //TempRegNumber = item.Temp_RegNo;
                //MessageBox.Show(TempRegNumber);
                dgvTempRegno.Rows.Add(item.Id,item.Temp_RegNo);

            }
        }//End LoadRecords(



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

          //  opt1stYear.Checked = true;
        }

        private void optAcademic_CheckedChanged(object sender, EventArgs e)
        {
            opt1stYear.Text = "11";
            opt2ndYear.Text = "12";
            opt3rdYear.Visible = false;
            opt4thYear.Visible = false;
            cmbCourseStrand.Text = "";
            LoadCombo();

           // opt1stYear.Checked = true;
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

           // opt1stYear.Checked = true;
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
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

          

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
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
            LoadComboAddress();
           
        }

        public void LoadComboAddress()
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


            //panel4.Visible = true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cmbProvince2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProvince2.SelectedItem.Equals("Aurora"))
            {
                cmbMunicipality2.Items.Clear();
                cmbMunicipality2.Items.Add("Baler");
                cmbMunicipality2.Items.Add("Casiguran ");
                cmbMunicipality2.Items.Add("Dilasag ");
                cmbMunicipality2.Items.Add("Dinalungan ");
                cmbMunicipality2.Items.Add("Dingalan ");
                cmbMunicipality2.Items.Add("Dipaculao ");
                cmbMunicipality2.Items.Add("Maria Aurora ");
                cmbMunicipality2.Items.Add("San Luis");



            }
            if (cmbProvince2.SelectedItem.Equals("Bataan"))
            {
                cmbMunicipality2.Items.Clear();
                cmbMunicipality2.Items.Add("Abucay");
                cmbMunicipality2.Items.Add("Bagac");
                cmbMunicipality2.Items.Add("Dinalupihan");
                cmbMunicipality2.Items.Add("Hermosa");
                cmbMunicipality2.Items.Add("Limay");
                cmbMunicipality2.Items.Add("Mariveles");
                cmbMunicipality2.Items.Add("Morong");
                cmbMunicipality2.Items.Add("Orani");
                cmbMunicipality2.Items.Add("Orion");
                cmbMunicipality2.Items.Add("Pilar");
                cmbMunicipality2.Items.Add("SamalCity Of Balanga");

            }

            if (cmbProvince2.SelectedItem.Equals("Bulacan"))
            {
                cmbMunicipality2.Items.Clear();
                cmbMunicipality2.Items.Add("Angat ");
                cmbMunicipality2.Items.Add("Balagtas ");
                cmbMunicipality2.Items.Add("Baliuag ");
                cmbMunicipality2.Items.Add("Bocaue ");
                cmbMunicipality2.Items.Add("Bulacan ");
                cmbMunicipality2.Items.Add("Bustos ");
                cmbMunicipality2.Items.Add("Calumpit ");
                cmbMunicipality2.Items.Add("Doña Remedios ");
                cmbMunicipality2.Items.Add("Trinidad ");
                cmbMunicipality2.Items.Add("Guiguinto ");
                cmbMunicipality2.Items.Add("Hagonoy ");
                cmbMunicipality2.Items.Add("Marilao ");
                cmbMunicipality2.Items.Add("Meycauayan City ");
                cmbMunicipality2.Items.Add("Norzagaray ");
                cmbMunicipality2.Items.Add("Obando ");
                cmbMunicipality2.Items.Add("Pandi ");
                cmbMunicipality2.Items.Add("Paombong ");
                cmbMunicipality2.Items.Add("Plaridel ");
                cmbMunicipality2.Items.Add("Pulilan ");
                cmbMunicipality2.Items.Add("San Ildefonso ");
                cmbMunicipality2.Items.Add("San Miguel ");
                cmbMunicipality2.Items.Add("San Rafael ");
                cmbMunicipality2.Items.Add("Santa Maria Malolos City");
                cmbMunicipality2.Items.Add("San Jose Del Monte City");


            }

            if (cmbProvince2.SelectedItem.Equals("Nueva Ecija"))
            {
                cmbMunicipality2.Items.Clear();
                cmbMunicipality2.Items.Add("Aliaga ");
                cmbMunicipality2.Items.Add("Bongabon ");
                cmbMunicipality2.Items.Add("Cabiao ");
                cmbMunicipality2.Items.Add("Carranglan ");
                cmbMunicipality2.Items.Add("Cuyapo ");
                cmbMunicipality2.Items.Add("Gabaldon ");
                cmbMunicipality2.Items.Add("General Mamerto Natividad ");
                cmbMunicipality2.Items.Add("General Tinio ");
                cmbMunicipality2.Items.Add("Guimba ");
                cmbMunicipality2.Items.Add("Jaen ");
                cmbMunicipality2.Items.Add("Laur ");
                cmbMunicipality2.Items.Add("Licab ");
                cmbMunicipality2.Items.Add("Llanera ");
                cmbMunicipality2.Items.Add("Lupao ");
                cmbMunicipality2.Items.Add("Nampicuan ");
                cmbMunicipality2.Items.Add("Pantabangan ");
                cmbMunicipality2.Items.Add("Peñaranda ");
                cmbMunicipality2.Items.Add("Quezon ");
                cmbMunicipality2.Items.Add("Rizal ");
                cmbMunicipality2.Items.Add("San Antonio ");
                cmbMunicipality2.Items.Add("San Isidro ");
                cmbMunicipality2.Items.Add("San Leonardo ");
                cmbMunicipality2.Items.Add("Santa Rosa ");
                cmbMunicipality2.Items.Add("Santo Domingo ");
                cmbMunicipality2.Items.Add("Talavera ");
                cmbMunicipality2.Items.Add("Talugtug ");
                cmbMunicipality2.Items.Add("Zaragoza  ");
                cmbMunicipality2.Items.Add("Cabanatuan City ");
                cmbMunicipality2.Items.Add("Gapan City ");
                cmbMunicipality2.Items.Add("Muñoz Science City ");
                cmbMunicipality2.Items.Add("Palayan City");
                cmbMunicipality2.Items.Add("San Jose City");



            }

            if (cmbProvince2.SelectedItem.Equals("Pampanga"))
            {
                cmbMunicipality2.Items.Clear();
                cmbMunicipality2.Items.Add("Apalit ");
                cmbMunicipality2.Items.Add("Arayat ");
                cmbMunicipality2.Items.Add("Bacolor ");
                cmbMunicipality2.Items.Add("Candaba ");
                cmbMunicipality2.Items.Add("Floridablanca ");
                cmbMunicipality2.Items.Add("Guagua ");
                cmbMunicipality2.Items.Add("Lubao ");
                cmbMunicipality2.Items.Add("Macabebe ");
                cmbMunicipality2.Items.Add("Magalang ");
                cmbMunicipality2.Items.Add("Masantol ");
                cmbMunicipality2.Items.Add("Mexico ");
                cmbMunicipality2.Items.Add("Minalin ");
                cmbMunicipality2.Items.Add("Porac ");
                cmbMunicipality2.Items.Add("San Luis ");
                cmbMunicipality2.Items.Add("San Simon ");
                cmbMunicipality2.Items.Add("Santa Ana ");
                cmbMunicipality2.Items.Add("Santa Rita ");
                cmbMunicipality2.Items.Add("Santo Tomas ");
                cmbMunicipality2.Items.Add("Sasmuan ");
                cmbMunicipality2.Items.Add("Angeles City ");
                cmbMunicipality2.Items.Add("Mabalacat ");
                cmbMunicipality2.Items.Add("San Fernando City");
            }

            if (cmbProvince2.SelectedItem.Equals("Tarlac"))
            {
                cmbMunicipality2.Items.Clear();
                cmbMunicipality2.Items.Add("Anao");
                cmbMunicipality2.Items.Add("Bamban ");
                cmbMunicipality2.Items.Add("Camiling ");
                cmbMunicipality2.Items.Add("Capas ");
                cmbMunicipality2.Items.Add("Concepcion ");
                cmbMunicipality2.Items.Add("Gerona ");
                cmbMunicipality2.Items.Add("La Paz ");
                cmbMunicipality2.Items.Add("Mayantoc ");
                cmbMunicipality2.Items.Add("Moncada ");
                cmbMunicipality2.Items.Add("Paniqui ");
                cmbMunicipality2.Items.Add("Pura ");
                cmbMunicipality2.Items.Add("Ramos ");
                cmbMunicipality2.Items.Add("San Clemente ");
                cmbMunicipality2.Items.Add("San Jose ");
                cmbMunicipality2.Items.Add("San Manuel ");
                cmbMunicipality2.Items.Add("Santa Ignacia ");
                cmbMunicipality2.Items.Add("Victoria  ");
                cmbMunicipality2.Items.Add("Tarlac City");

            }

            if (cmbProvince2.SelectedItem.Equals("Zambales"))
            {
                cmbMunicipality2.Items.Clear();
                cmbMunicipality2.Items.Add("Botolan ");
                cmbMunicipality2.Items.Add("Cabangan ");
                cmbMunicipality2.Items.Add("Candelaria ");
                cmbMunicipality2.Items.Add("Castillejos ");
                cmbMunicipality2.Items.Add("Iba");
                cmbMunicipality2.Items.Add("Masinloc ");
                cmbMunicipality2.Items.Add("Palauig ");
                cmbMunicipality2.Items.Add("San Antonio ");
                cmbMunicipality2.Items.Add("San Felipe ");
                cmbMunicipality2.Items.Add("San Marcelino ");
                cmbMunicipality2.Items.Add("San Narciso ");
                cmbMunicipality2.Items.Add("Santa Cruz ");
                cmbMunicipality2.Items.Add("Subic  ");
                cmbMunicipality2.Items.Add("Olongapo City");
            }
        }
        #region Rick's
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmBilling frmBilling = new frmBilling();
            frmBilling.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            frmAssessmentSearch frmAssessmentSearch = new frmAssessmentSearch();
            frmAssessmentSearch.Show();
        }
        #endregion
        private void optFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtStudCell_LostFocus(object sender, EventArgs e)
        {

           
        }

        private void txtStudCell_TextChanged(object sender, EventArgs e)
        {
            if (txtStudCell.MaskFull == true)
            {
                txtStudCell.BackColor = Color.White;
            }
        }

        private void dtBirthday_TextChanged(object sender, EventArgs e)
        {
            if (dtBirthday.MaskFull == true)
            {
                dtBirthday.BackColor = Color.White;
            }
        }

        public void UpdateEnrollee()
        {
            EnrolledStudents enrollee = new EnrolledStudents();

            if (txtEditGLevel.Text == "11")
            {
                enrollee.FullName = txtLastName.Text.ToUpper() + ", " + txtFName.Text.ToUpper() + " " + txtMName.Text.ToUpper();

                enrollee.TheGOCNo = The_GOC_No;
                enrollee.UpdateEnrollee11();
            }
            else
            {
                enrollee.FullName = txtLastName.Text.ToUpper() + ", " + txtFName.Text.ToUpper() + " " + txtMName.Text.ToUpper();

                enrollee.TheGOCNo = The_GOC_No;
                enrollee.UpdateEnrollee12();
            }
        }

        public void UpdateEnrolle_Billing()
        {
            Billing_Partial BP = new Billing_Partial();

            BP.Full_name = txtLastName.Text.ToUpper() + ", " + txtFName.Text.ToUpper() + " " + txtMName.Text.ToUpper();
            BP.IdNo = The_GOC_No;
            BP.UpdateEnrolleeName();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
           

            if (toEdit==true)
            {
                

                sp.StudType = cmbStudType.Text;
                sp.StudLRN = LRNtxt.Text;
                //sp.StudGOCNo = "N/A";
                sp.StudRegistrationNo = txtRegno.Text;
                sp.StudLastName = txtLastName.Text.ToUpper();
                sp.StudMiddleName = txtMName.Text.ToUpper();
                sp.StudFirstName = txtFName.Text.ToUpper();
                sp.StudStrand = cmbCourseStrand.Text.ToUpper(); ;
                sp.StudVoucher = cmbVoucher.Text;

                sp.StudAddress1 = txtEditAddress.Text;

                sp.StudDateOfBirth = dtBirthday.Text.ToString();
                sp.StudBirthPlace = txtBirthPlace.Text;
                sp.Religion = txtReligion.Text;
                sp.Nationality = cmbNationality.Text;
                //sp.StudGender = checkGender.Text;
                sp.StudContactNo = txtStudCell.Text;
                sp.StudTelNo = txtTelNo.Text;
                sp.StudPrevSchool = txtLastSchool.Text;
                sp.StudPrevSchoolAddress = txtLastSchAddress.Text;
                sp.StudType = cmbStudType.Text;
                sp.FatherName = txtFatherName.Text;
                sp.MotherName = txtMother.Text;
                sp.MotherWork = txtMotherWork.Text;
                sp.FatherWork = txtFatherWork.Text;
                sp.FatherContactNo = txtFatherContact.Text;
                sp.MotherContactNo = txtMotherContact.Text;
                sp.GuardianName = txtGuardianName.Text;
                sp.GuardianWork = txtGuardianWork.Text;

                sp.GuardianCompleteAddress = txtEditAddressGuardian.Text;

                sp.GuardianRelationship = txtRelation.Text;
                sp.GuardianContactNo = txtGuardianCell.Text;
                sp.GuardianTelNo = txtGuardianTel.Text;
                //sp.SYEnrolled = School;
                //sp.DateEnrolled = DateTime.Today.ToString("yyyy-mm-dd");
                //////////////////////////////////////
                sp.Reservee = "0";
                sp.ReserveFor = "0";
                sp.PartialPayment = "0";
                sp.FullPayment = "0";
                sp.Section = "0";
                //function to load important filtering            

                checkYearLevel();
                CheckTrack();
                checkRequirements();
                checkGender();

                sp.OldStudentNo = txtOldStudNo.Text;

                string message = "Please double check the information, click ok to update records.";
                string title = "GOC_INFO_SYS";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (Profile_edit == true)
                    {
                        sp.UpdateStudProfile();
                    }                    
                    else
                    {
                        //update the info to database
                        UpdateEnrollee();
                        UpdateEnrolle_Billing();
                        sp.UpdateStudProfile();
                    }                
                }
                else
                {
                    return;
                }
            }

            else
            {               
               //For Registration
               bool required = true;

                if (txtStudCell.MaskFull == true && dtBirthday.MaskFull == true && LRNtxt.MaskFull == true && other_address == true)
                {
                    required = true;

                }
                else
                {
                    if (LRNtxt.MaskFull == false)
                    {
                        MessageBox.Show("Please Check the LRN Number if Completed");
                        LRNtxt.BackColor = Color.LightBlue;

                        required = false;
                    }

                    if (txtOldStudNo.Text == "")
                    {
                        MessageBox.Show("Please Check the Student Number if Completed");
                        txtOldStudNo.BackColor = Color.LightBlue;

                        required = false;
                    }

                    if (txtStudCell.MaskFull == false)
                    {
                        MessageBox.Show("Please Check Student Phone Number.");
                        txtStudCell.BackColor = Color.LightBlue;

                        required = false;
                    }

                    if (dtBirthday.MaskFull == false)
                    {
                        MessageBox.Show("Please Check the Birthday");
                        dtBirthday.BackColor = Color.LightBlue;

                        required = false;
                    }
                }

                if (this.CheckRequiredFields() == true && required == true)
                {

                    foreach (Control child in Controls)
                    {
                        if (child is TextBox)
                        {
                            TextBox tb = child as TextBox;
                            if (string.IsNullOrEmpty(tb.Text))
                            {
                                tb.Text = @"N/A";
                            }
                        }
                    }


                    if (cmbStudType.Text.Equals("Old Student"))
                    {
                        registration.OldStudentNo = txtOldStudNo.Text;
                    }
                    else
                    {
                        registration.OldStudentNo = txtOldStudNo.Text; // //to true for saving SY: 2019 : 2020 temp: 9.27.2019
                    }

                    registration.StudType = cmbStudType.Text;
                    registration.StudLRN = LRNtxt.Text;
                    registration.StudGOCNo = "N/A";
                    registration.StudRegistrationNo = txtRegno.Text;
                    registration.StudLastName = txtLastName.Text.ToUpper();
                    registration.StudMiddleName = txtMName.Text.ToUpper();
                    registration.StudFirstName = txtFName.Text.ToUpper();
                    registration.StudStrand = cmbCourseStrand.Text.ToUpper(); ;
                    registration.StudVoucher = cmbVoucher.Text;
                    registration.StudAddress1 = txtAddress.Text + " " + txtBarangay.Text + " " + cmbMunicipality.Text + " " + cmbProvince.Text;
                    registration.StudDateOfBirth = dtBirthday.Text.ToString();
                    registration.StudBirthPlace = txtBirthPlace.Text;
                    registration.Religion = txtReligion.Text;
                    registration.Nationality = cmbNationality.Text;
                    //registration.StudGender = checkGender.Text;
                    registration.StudContactNo = txtStudCell.Text;
                    registration.StudTelNo = txtTelNo.Text;
                    registration.StudPrevSchool = txtLastSchool.Text;
                    registration.StudPrevSchoolAddress = txtLastSchAddress.Text;

                    registration.StudType = cmbStudType.Text;

                    registration.FatherName = txtFatherName.Text;
                    registration.MotherName = txtMother.Text;
                    registration.MotherWork = txtMotherWork.Text;
                    registration.FatherWork = txtFatherWork.Text;
                    //registration.FatherContactNo = txtFatherContact.Text;
                    //registration.MotherContactNo = txtMotherContact.Text;
                    registration.GuardianName = txtGuardianName.Text;
                    registration.GuardianWork = txtGuardianWork.Text;
                    registration.GuardianCompleteAddress = txtAddress2.Text + " " + txtBarangay2.Text + " " + cmbMunicipality2.Text + " " + cmbProvince2.Text;
                    registration.GuardianRelationship = txtRelation.Text;
                    //registration.GuardianContactNo = txtGuardianCell.Text;
                    //registration.GuardianTelNo = txtGuardianTel.Text;

                    if (txtFatherContact.Equals(""))
                    {

                        registration.FatherContactNo = "0000-000-0000";
                    }
                    else
                    {
                        registration.FatherContactNo = txtFatherContact.Text;
                    }

                    if (txtMotherContact.Text == "")
                    {
                        registration.MotherContactNo = "0000-000-0000";
                    }
                    else
                    {
                        registration.MotherContactNo = txtMotherContact.Text;
                    }

                   

                    if (txtGuardianCell.Text == "")
                    {
                        registration.GuardianContactNo = "0000-000-0000";
                    }
                    else
                    {
                        registration.GuardianContactNo = txtGuardianCell.Text;
                    }

                    if (txtGuardianTel.Text == "")
                    {
                        registration.GuardianTelNo = "0000-000-0000";
                    }
                    else
                    {
                        registration.GuardianTelNo = txtGuardianTel.Text;
                    }

                    registration.SYEnrolled = School;
                    //registration.DateEnrolled = DateTime.Today.ToString("yyyy-mm-dd");
                    //////////////////////////////////////
                    registration.Reservee = "0";
                    registration.ReserveFor = "0";
                    registration.PartialPayment = "0";
                    registration.FullPayment = "0";
                    registration.Section = "0";
                    //function to load important filtering            

                    checkYearLevel();
                    CheckTrack();
                    checkRequirements();
                    checkGender();

                    string message = "Please double check the information, click ok to save record." +

                        "\n\nRegistration No.: " + txtRegno.Text +
                        "\nLRN: " + LRNtxt.Text +
                        "\nVoucher Type: " + cmbVoucher.Text +
                        "\nStudent Type: " + cmbStudType.Text +
                        "\nTrack: " + frmAssesment.Track +

                        "\n\nGrade Level/Year Level: " + frmAssesment.GradeLevel +
                        "\nStrand/Course: " + cmbCourseStrand.Text +
                        "\nFirst Name: " + txtFName.Text +
                        "\nMiddle Name: " + txtMName.Text +
                        "\nLast Name: " + txtLastName.Text +

                        "\n\nReligion : " + txtReligion.Text +
                        "\nNationality: " + cmbNationality.Text +
                        "\nGender: " + registration.StudGender +
                        "\nContact No.: " + txtStudCell.Text +

                        "\n\nBirthdate: " + dtBirthday.Text +
                        "\nPlace of Birth: " + txtBirthPlace.Text +
                        "\nAddress: " + txtAddress.Text + " " + txtBarangay.Text + " " + cmbMunicipality.Text + " " + cmbProvince.Text +

                        "\n\nPrevious School Name : " + txtLastSchool.Text +
                        "\nPrevious School Address: " + txtLastSchAddress.Text;

                    string title = "GOC_INFO_SYS";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        //save the info to database
                        registration.Save();
                    }
                    else
                    {
                        return;
                    }

                    frmAssesment.Reset();
                    assements.Clear();

                    frmAssesment.RegNo = txtRegno.Text;
                    frmAssesment.StudName = txtLastName.Text.ToUpper() + " , " + txtFName.Text.ToUpper() + " " + txtMName.Text.ToUpper();
                    frmAssesment.LRN = LRNtxt.Text;
                    frmAssesment.Strand = cmbCourseStrand.Text.ToUpper();

                    frmAssesment.LoadSection();
                    frmAssesment.LoadSchoolYear();
                    frmAssesment.Voucher = cmbVoucher.Text;
                    frmAssesment.ComputeVoucher();
                    frmAssesment.LoadAssesOtherFees();
                    frmAssesment.LoadAssesMiscFees();
                    frmAssesment.LoadTuitionFee();
                    frmAssesment.TotalTuition();

                    frmAssessmentSearch search = new frmAssessmentSearch();
                    MainWindow mainwin = (MainWindow)Application.OpenForms["MainWindow"];
                    mainwin.dispanel.Controls.Clear();
                    search.TopLevel = false;
                    search.AutoScroll = true;
                    mainwin.dispanel.Controls.Add(search);

                    search.Show();
                }
                else
                {
                    MessageBox.Show("Please fill out all required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }         
        }

    }
}
