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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        
        public void setThis()
        {
            if (this.CheckRequiredFields() == true)
            {
                //set properties
                GOCSystem2018.Config.DSN = txtDSN.Text;
                GOCSystem2018.Config.DB_HOST = txtHost.Text;
                GOCSystem2018.Config.DB_NAME = txtName.Text;
                GOCSystem2018.Config.DB_USER = txtUser.Text;
                GOCSystem2018.Config.DB_PASSWORD = txtPassword.Text;

                //save settings
                GOCSystem2018.Config.saveSettings();

                if (GOCSystem2018.Config.TestConnection())
                {
                    MessageBox.Show("Successfully Connected to Database", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //if (flag == "Client")
                    //{
                    //    frmFrontMain frmFrontMain = new frmFrontMain();
                    //    frmFrontMain.ShowDialog();
                    //    this.Dispose();
                    //    this.Close();
                    //}
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                
            }
        }


        private void btnSaveConfiguration_Click(object sender, EventArgs e)
        {
            setThis();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            if (!(GOCSystem2018.Config.DSN == string.Empty))
            {
                this.GetServerSettings();
            }
        }

        private void GetServerSettings()
        {
            txtDSN.Text = GOCSystem2018.Config.DSN;
            txtHost.Text = GOCSystem2018.Config.DB_HOST;
            txtName.Text = GOCSystem2018.Config.DB_NAME;
            txtUser.Text = GOCSystem2018.Config.DB_USER;
            txtPassword.Text = GOCSystem2018.Config.DB_PASSWORD;
        }

        private bool CheckRequiredFields()
        {
            if (txtDSN.Text == "")
            {
                return false;
            }

            if (txtHost.Text == "")
            {
                return false;
            }

            if (txtName.Text == "")
            {
                return false;
            }

            if (txtUser.Text == "")
            {
                return false;
            }

            return true;
        }

        private void frmSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSaveConfiguration.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
