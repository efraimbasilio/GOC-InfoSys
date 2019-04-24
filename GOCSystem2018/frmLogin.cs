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
    public partial class frmLogin : Form
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
        User user = new User();
        List<User> users = new List<User>();

 

        public string UserType, Username, Password;
        public bool Flag;
        public frmLogin()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.B))
            {
                txtUsername.Text = "admin";
                txtpassword.Text = "admin123";
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void credential()
        {

            if (Flag == true)
            {
                if (UserType.Equals("Admin"))
                {
                    MainWindow main = new MainWindow();
                    main.accver = UserType.ToString();
                    main.Show();
                    this.Hide();
                }

                else if (UserType.Equals("Cashier"))
                {
                    MainWindow main = new MainWindow();
                    main.accver = UserType.ToString();
                    main.Show();
                    //frmBillingSearch bill = new frmBillingSearch
                    //bill.Show     
                    this.Hide();
                }

                else if (UserType.Equals("Registrar"))
                {
                    MainWindow main = new MainWindow();
                    main.accver = "Registrar";
                    main.Show();
                    //frmAssessmentSearch assess = new frmAssessmentSearch();
                    // assess.Show();
                    
                    this.Hide();
                }
                else if (UserType.Equals("Teacher"))
                {
                    MainWindow main = new MainWindow();
                    main.accver = "Teacher";
                    main.Show();
                    //frmGrading grade = new frmGrading();
                    //grade.Show();
                    
                    this.Hide();
                }
                else
                {
                    string message = "Erorr";
                    string title = "GOC_INFO_SYS";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

                    if (result == DialogResult.OK)
                    {
                        Flag = false;
                        return ;
                    }
                }
            }
            else
            {
                string message = "User not existing";
                string title = "GOC_INFO_SYS";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                {
                    return;
                }
            }
        }
       public void LogMein()
       {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            else
            {
                //clear list
                users.Clear();
                //pass value
                user.Username = txtUsername.Text;
                user.Password = txtpassword.Text;
                users = user.GetUserType();

                foreach (var item in users)
                {
                    //pass variable to form Assesment
                    //MessageBox.Show(item.UserType, item.Username);
                   // MessageBox.Show(item.Username);
                    UserType = item.UserType;
                    Password = item.Password;
                    Username = item.Username;
                    Flag = true;
                }
                credential();
            }                                
        }

        //this.Hide();

        //    try
        //    {
        //        using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
        //        {
        //            //try to open connection
        //            con.Open();

        //            //prepare sql query
        //            string sql = "SELECT * FROM users WHERE username='"+txtUsername.Text+"' AND password='"+txtpassword.Text+"'";

        //            MySqlCommand cmd = new MySqlCommand(sql, con);

        //            MySqlDataReader reader = cmd.ExecuteReader();

        //            int count = 0;
        //            while (reader.Read())
        //            {
        //                count = count + 1;
        //            }

        //            if (count == 1)
        //            {
        //                txtUsername.Text = "";
        //                txtpassword.Text = "";

        //                this.Hide();
        //                MainWindow mainWindow = new MainWindow();
        //                mainWindow.ShowDialog();
        //            }
        //            else if (count > 1)
        //            {
        //                MessageBox.Show("Duplicate");
        //            }
        //            else
        //            {
        //                MessageBox.Show("User not Exist");
        //            }
        //            con.Close();

        //        }
        //    }
        //    catch (MySqlException ex)
        //    {

        //        MessageBox.Show("Error : " + ex.Message.ToString(), "GOC System", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }  

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        #region design code
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar.Equals('•')) {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
            }

        }//hiding password        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                label2.Text = "username";
            }
            else
            {
                label2.Text = "";
            }
        }//textbox tip
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text.Equals(""))
            {
                label3.Text = "password";
            }
            else
            {
                label3.Text = "";
            }
        }//textbox tip
        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }//misc func
        private void label3_Click(object sender, EventArgs e)
        {
            txtpassword.Focus();
        }//misc func
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtpassword.Focus();
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSetting set = new frmSetting();
            set.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.GotFocus += new System.EventHandler(this.txtUsername_GotFocus);
            txtUsername.LostFocus += new System.EventHandler(this.txtUsername_LostFocus);

            txtpassword.GotFocus += new System.EventHandler(this.txtpassword_GotFocus);
            txtpassword.LostFocus += new System.EventHandler(this.txtpassword_LostFocus);

            MessageBox.Show("Successfully connected to the database: " + Properties.Settings.Default.HOST, "GOC Infosys Database connection",MessageBoxButtons.OK,MessageBoxIcon.Information);

            //frmSetting set = new frmSetting();
            //set.setThis();
            
        }

        #region 
        private void txtUsername_GotFocus(Object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(165, 209, 217);
        }
        private void txtUsername_LostFocus(Object sender, EventArgs e)
        {
            label5.ForeColor = Color.Gray;
        }
        private void txtpassword_GotFocus(Object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(165, 209, 217);
        }
        private void txtpassword_LostFocus(Object sender, EventArgs e)
        {
            label6.ForeColor = Color.Gray;
        }
        #endregion
        private void button3_Click(object sender, EventArgs e)
        {
            LogMein();
            //this.Hide();
            //this.Dispose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LogMein();
            }
        }
    }
}
