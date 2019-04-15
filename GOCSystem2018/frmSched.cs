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
            #region dynamic control creation

            int startposition = 400;
            int endposition = 183;
            int endposition2 = 183;
            int endposition3 = 20;
            int startposition2 = 20;
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
            String[] sched2 = { "08:00",
                               "09:00",
                               "10:00",
                               "11:00",
                               "12:00",
                               "01:00",
                               "02:00",
                               "03:00",
                               "04:00", };
            
                              
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

                endposition += 32;
            }
            for (int i = 0; i <= 8; i++)
            {
                Panel span6 = addSpan6(i, startposition, endposition2, sched[i]);
                Label labspan6 = addlabspan6(i, startposition, endposition2, sched2[i]);
                this.Controls.Add(labspan6);
                this.Controls.Add(span6);
                
                

                endposition2 += 64;
            }

            for (int i = 0; i < Secforschedcmb.Items.Count; i++)
            {
                RadioButton subrad = addSubRad(i, startposition2, endposition3, Secforschedcmb.Items[i].ToString());
                subrad.Click += new System.EventHandler(this.RadiobutClicked);
                this.panel1.Controls.Add(subrad);

                Panel legendpanel = addlegendpan(i, startposition2, endposition3);
                this.panel1.Controls.Add(legendpanel);
                endposition3 += 30;
            }
#endregion 
        }
        #region panel event
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
        }
#endregion

        #region radio button properties
        RadioButton addSubRad(int i, int start, int end, String name)
        {
            RadioButton subrad = new RadioButton();
            subrad.Name = name;
            subrad.Text = name;
            subrad.Font = new Font("Century Gothic", 8);
            subrad.Location = new Point(start, end);

            return subrad;
        }
        #endregion
        Panel addlegendpan(int i, int start, int end)
        {
            Panel legendpan = new Panel();
            legendpan.Name = i + "pan";
            legendpan.BackColor = Color.Transparent;
            legendpan.Font = new Font("Century Gothic", 8);
            legendpan.Width = 5;
            legendpan.Height = 23;
            legendpan.Location = new Point(0, end);
            if (i == 0)
            {
                legendpan.BackColor = Color.Blue;
            }
            else if (i == 1)
            {
                legendpan.BackColor = Color.Red;
            }
            else if (i == 2)
            {
                legendpan.BackColor = Color.Green;
            }
            else if (i == 3)
            {
                legendpan.BackColor = Color.Yellow;
            }
            else if (i == 4)
            {
                legendpan.BackColor = Color.Orange;
            }
            else if (i == 5)
            {
                legendpan.BackColor = Color.Purple;
            }
            else if (i == 6)
            {
                legendpan.BackColor = Color.Turquoise;
            }
            else if (i == 7)
            {
                legendpan.BackColor = Color.Black;
            }

            return legendpan;
        }

        #region radiobutton event
        void RadiobutClicked(Object sender, EventArgs e)
        {
            RadioButton subrad = (RadioButton)sender;
            textBox1.Text = subrad.Text;
        }
        #endregion

        #region panel properties
        Panel addSpan(int i, int start, int end, string sched)
        {
            Panel stud = new Panel();
            stud.Name = sched;
            stud.Text = "Panel" + i;
            stud.BackColor = Color.Transparent;
            stud.Font = new Font("Century Gothic", 8);
            stud.Width = 156;
            stud.Height = 30;
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
            stud.Height = 30;
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
            stud.Height = 30;
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
            stud.Height = 30;
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
            stud.Height = 30;
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
            stud.Height = 62;
            stud.Location = new Point(start-156, end);
            stud.BackColor = Color.FromArgb(165, 209, 217);

            return stud;
        }
        Label addlabspan6(int i, int start, int end, string sched)
        {
            Label labspan6 = new Label();
            labspan6.Name = sched;
            labspan6.Text = sched;
            labspan6.Font = new Font("Century Gothic", 12);
            labspan6.Location = new Point(start - 156, end);
            labspan6.ForeColor = Color.White;
            labspan6.BackColor = Color.FromArgb(165, 209, 217);
            return labspan6;
        }
        #endregion

    }
}
