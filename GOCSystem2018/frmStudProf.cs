using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOCSystem2018
{
    public partial class frmStudProf : Form
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
        Billing_Partial billingPartial = new Billing_Partial();
        StudentProfile studProfile = new StudentProfile();


        List<StudentProfile> studProfiles = new List<StudentProfile>();
        List<Billing_Partial> billingPartials = new List<Billing_Partial>();

        frmRegistration frmReg = new frmRegistration();

        public string Student_Name,GOC_No, LRN, REG_No, Strand, Glvl, Section, DOB, Add, Gender, ConNo, Nat, Rel, BirthPlace, Fname, Focc, Mname, Mocc, Gname, Gocc;
        //
        String apppath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).ToString();
       

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                circularPictureBox1.Image = Image.FromFile(opf.FileName);
                string fullPath = opf.FileName;
                string fileName = opf.SafeFileName;
                string path = fullPath.Replace(fileName, "");

                txtPath.Text = path;//path name from browse file
                txtFileName.Text = fileName; // filename from browse

                //copy image*********************************************************************************
                string[] files = System.IO.Directory.GetFiles(txtPath.Text);

                foreach (string file in files)
                {
                    System.IO.File.Copy(txtPath.Text + txtFileName.Text, txtFromDB.Text + lrntxt.Text + ".jpg", true);
                    break;
                }
                //*******************************************************************************************
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PassToEdit();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerInfoPanel.Visible = false;
            Accpanel.Visible = false;
            acadPanel.Visible = true;

            button2.BackColor = Color.FromArgb(245, 246, 251);
            button2.ForeColor = Color.DarkGray;

            button3.BackColor = Color.FromArgb(245, 246, 251);
            button3.ForeColor = Color.DarkGray;

            button1.BackColor = Color.FromArgb(1, 172, 120);
            button1.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerInfoPanel.Visible = false;
            Accpanel.Visible = true;
            acadPanel.Visible = false;

            button3.BackColor = Color.FromArgb(245, 246, 251);
            button3.ForeColor = Color.DarkGray;

            button1.BackColor = Color.FromArgb(245, 246, 251);
            button1.ForeColor = Color.DarkGray;

            button2.BackColor = Color.FromArgb(1, 172, 120);
            button2.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PerInfoPanel.Visible = true;
            Accpanel.Visible = false;
            acadPanel.Visible = false;

            button2.BackColor = Color.FromArgb(245, 246, 251);
            button2.ForeColor = Color.DarkGray;

            button1.BackColor = Color.FromArgb(245, 246, 251);
            button1.ForeColor = Color.DarkGray;

            button3.BackColor = Color.FromArgb(1, 172, 120);
            button3.ForeColor = Color.White;
        }
        public frmStudProf()
        {
            InitializeComponent();
        }

        
        public void PassToEdit()
        {
            //clear list
            studProfiles.Clear();
            //pass value
            studProfile.StudGOCNo = GOC_No;
            studProfiles = studProfile.GetByGOCNoToEdit();

            foreach (var item in studProfiles)
            {
                //pass variable to form Assesment
                frmReg.RegNo = item.StudRegistrationNo;
                frmReg.LRN = item.StudLRN;
                frmReg.VType = item.VoucherType;
                frmReg.StudType = item.StudType;
                frmReg.Track = item.Track;
                frmReg.Grade_Level = item.StudGradeLevel;
                frmReg.StrandCourse = item.StudStrand;
                frmReg.F_Name = item.StudFirstName;
                frmReg.M_Name = item.StudMiddleName;
                frmReg.L_Name = item.StudLastName;
                frmReg.Religion = item.Religion;
                frmReg.Nationality = item.Nationality;
                frmReg.Gender = item.StudGender;
                frmReg.Birthdate = item.StudDateOfBirth;
                frmReg.Place_of_birth = item.StudBirthPlace;

                frmReg.Edit_Address = item.StudAddress1;
                //frmReg.House_No = item.StudAddress1;\

                frmReg.Cell_No = item.StudContactNo;
                frmReg.Tel_No = item.StudTelNo;
                frmReg.Last_School = item.StudPrevSchool;
                frmReg.School_Address = item.StudPrevSchoolAddress;

                frmReg.Father = item.FatherName;
                frmReg.F_Occupation = item.FatherWork;
                frmReg.Mother = item.MotherName;
                frmReg.M_Occupation = item.MotherWork;

                frmReg.M_Contact = item.MotherContactNo;
                frmReg.F_Contact = item.FatherContactNo;

                frmReg.Guardian = item.GuardianName;
                frmReg.G_CellNo = item.GuardianContactNo;
                frmReg.G_TelNo = item.GuardianTelNo;
                frmReg.G_Occupation = item.GuardianWork;
                frmReg.G_Relationship = item.GuardianRelationship;

                frmReg.Edit_GuardianAddress = item.GuardianCompleteAddress;

                frmReg._PSA = item.ReqPSA;
                frmReg._FORM_138 = item.ReqForm138;
                frmReg._GM = item.ReqGoodMoral;
                frmReg._MD = item.ReqDrugTest;
                frmReg._ESV = item.ReqAdmissionTest;
                frmReg._NCAE = item.ReqNCAE;

                frmReg.toEdit = true;
                //frmReg.G_House_No = item.GuardianCompleteAddress;
            }
            frmReg.EditRender();

            MainWindow mainwin = (MainWindow)Application.OpenForms["MainWindow"];
            mainwin.dispanel.Controls.Clear();
            frmReg.TopLevel = false;
            frmReg.AutoScroll = true;
            mainwin.dispanel.Controls.Add(frmReg);

            frmReg.Show();
        }

        public void LoadPaymentHistory()
        {
            //clear list
            billingPartials.Clear();
            //MessageBox.Show(REG_No);
            //pass value to list                    
            billingPartial.RegNo = REG_No;

            billingPartials = billingPartial.GetMonthlyDue();

            //loop through load it to list view
            foreach (var item in billingPartials)
            {
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

                M1txt.Text = Month_1;
                M2txt.Text = Month_2;
                M3txt.Text = Month_3;
                M4txt.Text = Month_4;
                M5txt.Text = Month_5;
                M6txt.Text = Month_6;
                M7txt.Text = Month_7;
                M8txt.Text = Month_8;
                M9txt.Text = Month_9;
                M10txt.Text = Month_10;

                tp1txt.Text = item.P1;
                tp2txt.Text = item.P2;
                tp3txt.Text = item.P3;
                tp4txt.Text = item.P4;
                tp5txt.Text = item.P5;
                tp6txt.Text = item.P6;
                tp7txt.Text = item.P7;
                tp8txt.Text = item.P8;
                tp9txt.Text = item.P9;
                tp10txt.Text = item.P10;

            }
        }

        private void frmStudProf_Load(object sender, EventArgs e)
        {
            
            apppath = @"\\server\Main_File_Server\IT\gocinfosys_resource\";
            txtFromDB.Text = apppath;
            circularPictureBox1.ImageLocation = apppath + lrntxt.Text +".jpg";
        }

        public void Render()
        {
            lblStudName.Text = Student_Name;
            txtRegNo.Text = REG_No;
            lblGOCNo.Text = GOC_No;
            lrntxt.Text = LRN;
            strandtxt.Text = Strand;
            glvltxt.Text = Glvl;
            sectiontxt.Text = Section;
            bdtxt.Text = DOB;
            addtxt.Text = Add;
            Gendertxt.Text = Gender;
            Contactnotxt.Text = ConNo;
            nationalitytxt.Text = Nat;
            religiontxt.Text = Rel;
            bptxt.Text = BirthPlace;
            fathertxt.Text = Fname;
            mothertxt.Text = Mname;
            guardiantxt.Text = Gname;

            textBox1.Text = LRN;

            LoadPaymentHistory();
        }


    }
}

