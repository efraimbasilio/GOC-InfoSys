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
    public partial class frmSched : Form
    {
        public frmSched()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            
        }//clear add sched window
        private void label19_Click(object sender, EventArgs e)
        {
            
        }//clear edit sched window
        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

           
        }//sched form close button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmSched_Load(object sender, EventArgs e)
        {

            int startposition = 290;
            int endposition = 143;
            int endposition2 = 143;
            String[] sched = { "08:00-08:30",
                               "08:30-09:00",
                               "09:00-09:30",
                               "09:30-010:00",
                               "10:00-10:30",
                               "10:30-11:00",
                               "11:00-11:30",
                               "11:30-12:00",
                               "12:00-12:30",
                               "12:30-01:00",
                               "01:00-01:30",
                               "01:30-02:00",
                               "02:00-02:30",
                               "02:30-03:00",
                               "03:00-03:30",
                               "03:30-04:00",
                               "04:00-04:30",
                               "04:30-05:00"};
            for (int i = 0; i < 18; i++)
            {
                Panel span = addSpan(i, startposition, endposition, sched[i]);
                this.Controls.Add(span);

                span.DoubleClick += new System.EventHandler(this.PanelDoubleClick);

                Panel span2 = addSpan2(i, startposition, endposition, sched[i]);
                this.Controls.Add(span2);

                Panel span3 = addSpan3(i, startposition, endposition, sched[i]);
                this.Controls.Add(span3);

                Panel span4 = addSpan4(i, startposition, endposition, sched[i]);
                this.Controls.Add(span4);

                Panel span5 = addSpan5(i, startposition, endposition, sched[i]);
                this.Controls.Add(span5);




                endposition += 37;

            }
            for (int i = 0; i <= 8; i++)
            {
                Panel span6 = addSpan6(i, startposition, endposition2, sched[i]);
                this.Controls.Add(span6);
                endposition2 += 74;
            }
        }
        void PanelDoubleClick(Object sender, EventArgs e)
        {
            Panel eveforPan = (Panel)sender;
            if (Secforschedcmb.Text.Equals("English"))
            {
                eveforPan.BackColor = Color.Black;
            }
            else if (Secforschedcmb.Text.Equals("Math"))
            {
                eveforPan.BackColor = Color.Red;
            }
            else if (Secforschedcmb.Text.Equals("Science"))
            {
                eveforPan.BackColor = Color.Yellow;
            }
            else if (Secforschedcmb.Text.Equals("Filipino"))
            {
                eveforPan.BackColor = Color.Turquoise;
            }
            //MessageBox.Show(eveforPan.Name);
            //if(((Panel)this.Controls.Find("3:00 - 3:30", true)[0]).BackColor == Color.Red){
            //    MessageBox.Show(eveforPan.Name + "good");
            //}

        }
        Panel addSpan(int i, int start, int end, string sched)
        {
            Panel stud = new Panel();
            stud.Name = sched;
            stud.Text = "Panel" + i;
            stud.BackColor = Color.Transparent;
            stud.Font = new Font("Century Gothic", 8);
            stud.Width = 156;
            stud.Height = 35;
            stud.Location = new Point(start, end);
            stud.BackColor = Color.White;
            
            return stud;
        }
        Panel addSpan2(int i, int start, int end, string sched)
        {
            Panel stud = new Panel();
            stud.Name = sched;
            stud.Text = "Panel" + i;
            stud.BackColor = Color.Transparent;
            stud.Font = new Font("Century Gothic", 8);
            stud.Width = 156;
            stud.Height = 35;
            stud.Location = new Point(start + 158, end);
            stud.BackColor = Color.White;
            

            return stud;
        }

        Panel addSpan3(int i, int start, int end, string sched)
        {
            Panel stud = new Panel();
            stud.Name = sched;
            stud.Text = "Panel" + i;
            stud.BackColor = Color.Transparent;
            stud.Font = new Font("Century Gothic", 8);
            stud.Width = 156;
            stud.Height = 35;
            stud.Location = new Point(start + 316, end);
            stud.BackColor = Color.White;
            
            return stud;
        }

        Panel addSpan4(int i, int start, int end, string sched)
        {
            Panel stud = new Panel();
            stud.Name = sched;
            stud.Text = "Panel" + i;
            stud.BackColor = Color.Transparent;
            stud.Font = new Font("Century Gothic", 8);
            stud.Width = 156;
            stud.Height = 35;
            stud.Location = new Point(start + 474, end);
            stud.BackColor = Color.White;
            
            return stud;
        }

        Panel addSpan5(int i, int start, int end, string sched)
        {
            Panel stud = new Panel();
            stud.Name = "fri" + sched;
            stud.Text = "Panel" + i;
            stud.BackColor = Color.Transparent;
            stud.Font = new Font("Century Gothic", 8);
            stud.Width = 156;
            stud.Height = 35;
            stud.Location = new Point(start + 632, end);
            stud.BackColor = Color.White;
            
            return stud;
        }
        Panel addSpan6(int i, int start, int end, string sched)
        {
            Panel stud = new Panel();
            stud.Name = sched;
            stud.Text = "Panel" + i;
            stud.BackColor = Color.Transparent;
            stud.Font = new Font("Century Gothic", 8);
            stud.Width = 156;
            stud.Height = 72;
            stud.Location = new Point(start-156, end);
            stud.BackColor = Color.FromArgb(34, 119, 246);

            return stud;
        }

    }
}
