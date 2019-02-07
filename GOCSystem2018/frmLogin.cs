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
        User users = new User();
        public frmLogin()
        {
            InitializeComponent();
        }

       

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
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            else
            {
                //users.Username = txtUsername.Text;
                //users.Password = txtpassword.Text;
                //users.AccessGrant();

                //this.Hide();

                try
                {
                    using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                    {
                        //try to open connection
                        con.Open();

                        //prepare sql query
                        string sql = "SELECT * FROM users WHERE username='"+txtUsername.Text+"' AND password='"+txtpassword.Text+"'";

                        MySqlCommand cmd = new MySqlCommand(sql, con);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        int count = 0;
                        while (reader.Read())
                        {
                            count = count + 1;
                        }

                        if (count == 1)
                        {
                            txtUsername.Text = "";
                            txtpassword.Text = "";

                            this.Hide();
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.ShowDialog();
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate");
                        }
                        else
                        {
                            MessageBox.Show("User not Exist");
                        }
                        con.Close();
                       
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error : " + ex.Message.ToString(), "GOC System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                        
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtpassword.Focus();
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (e.KeyChar == (char)13)
                //btnLogin.Click();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }
    }
}
