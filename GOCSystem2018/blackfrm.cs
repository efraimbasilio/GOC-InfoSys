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
    public partial class blackfrm : Form
    {
        public blackfrm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            frmcmb fmsb = new frmcmb();
            fmsb.ShowDialog();
            
        }

        private void blackfrm_Load(object sender, EventArgs e)
        {
        
        }
        

        private void blackfrm_Click(object sender, EventArgs e)
        {
            frmcmb frmcmb = (frmcmb)Application.OpenForms["frmcmb"];
            frmcmb.Close();
            this.Close();
        }
    }
}
