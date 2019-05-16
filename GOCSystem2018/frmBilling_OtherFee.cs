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
    public partial class frmBilling_OtherFee : Form
    {
        public string GOCNo, GLEVEL; 
        public frmBilling_OtherFee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double total=0;
            total = Convert.ToDouble(txtTuitionFee.Text)+ Convert.ToDouble(txtUniform.Text) + Convert.ToDouble(txtBooks.Text) + Convert.ToDouble(txtLocker.Text);
            lblAmount_Due.Text = total.ToString("n");
        }

        private void txtTuitionFee_Leave(object sender, EventArgs e)
        {
            txtTuitionFee.Text = string.Format("{0:#,##0.00}", double.Parse(txtTuitionFee.Text));
            //textBox1.Text = string.Format("{0:#,##0.00}", double.Parse(textBox1.Text));
            if (txtAmountGiven.Text == "")
            {
                string defaultNull = "0";
                txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(defaultNull));
            }
        }

        private void txtUniform_Leave(object sender, EventArgs e)
        {
            txtUniform.Text = string.Format("{0:#,##0.00}", double.Parse(txtUniform.Text));
            if (txtAmountGiven.Text == "")
            {
                string defaultNull = "0";
                txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(defaultNull));
            }
        }

        private void txtBooks_Leave(object sender, EventArgs e)
        {
            txtBooks.Text = string.Format("{0:#,##0.00}", double.Parse(txtBooks.Text));
            if (txtAmountGiven.Text == "")
            {
                string defaultNull = "0";
                txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(defaultNull));
            }
        }

        private void txtLocker_Leave(object sender, EventArgs e)
        {
            txtLocker.Text = string.Format("{0:#,##0.00}", double.Parse(txtLocker.Text));
            if (txtAmountGiven.Text == "")
            {
                string defaultNull = "0";
                txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(defaultNull));
            }
        }

        private void txtAmountGiven_Leave(object sender, EventArgs e)
        {
            txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(txtAmountGiven.Text));
            if (txtAmountGiven.Text == "")
            {
                string defaultNull = "0";
                txtAmountGiven.Text = string.Format("{0:#,##0.00}", double.Parse(defaultNull));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtAmountGiven.Text) < Convert.ToDouble(lblAmount_Due.Text ))
            {
                MessageBox.Show("Please check the payment", "GOC_INFO_SYS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Billing_Other_Fees fee = new Billing_Other_Fees();
                fee.GocNumber = GOCNo;
                fee.OrNo = txtORNo.Text;
                fee.GLevel= GLEVEL;
                fee.Uniform =txtUniform.Text ;
                fee.Books = txtBooks.Text;
                fee.Locker = txtLocker.Text;

                fee.Save();
            }
        }
    }
}
