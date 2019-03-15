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
        User user = new User();
        List<User> users = new List<User>();

        public string UserType, Username, Password;
        public bool Flag;
        public frmLogin()
        {
            InitializeComponent();
        }
        public void credential()
        {
            if (Flag == true)
            {
                if (UserType.Equals("Admin"))
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Hide();
                }

                else if (UserType.Equals("Cashier"))
                {
                    frmBillingSearch bill = new frmBillingSearch();
                    bill.Show();
                    this.Hide();
                }

                else if (UserType.Equals("Registrar"))
                {
                    frmAssessmentSearch assess = new frmAssessmentSearch();
                    assess.Show();
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
            LogMein();
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
            set.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
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
