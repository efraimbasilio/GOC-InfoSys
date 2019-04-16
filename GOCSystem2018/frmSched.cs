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

            String[] subsub2 = new String[10];


            for (int i = 0; i < 18; i++)
            {
                Panel span = addSpan(i, startposition, endposition, sched[i]);
                this.Controls.Add(span);

                span.DoubleClick += new System.EventHandler(this.PanelDoubleClick);

                Panel span2 = addSpan2(i, startposition, endposition, sched[i]);
                this.Controls.Add(span2);

                span2.DoubleClick += new System.EventHandler(this.PanelDoubleClick);

                Panel span3 = addSpan3(i, startposition, endposition, sched[i]);
                this.Controls.Add(span3);

                span3.DoubleClick += new System.EventHandler(this.PanelDoubleClick);

                Panel span4 = addSpan4(i, startposition, endposition, sched[i]);
                this.Controls.Add(span4);

                span4.DoubleClick += new System.EventHandler(this.PanelDoubleClick);

                Panel span5 = addSpan5(i, startposition, endposition, sched[i]);
                this.Controls.Add(span5);

                span5.DoubleClick += new System.EventHandler(this.PanelDoubleClick);

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
                
                subsub2[i] = Secforschedcmb.Items[i].ToString(); 
            }


            for (int i = 0; i < Secforschedcmb.Items.Count; i++)
            {

                RadioButton subrad = addSubRad(i, startposition2, endposition3, Secforschedcmb.Items[i].ToString());
                subrad.Click += new System.EventHandler(this.RadiobutClicked);
                this.panel1.Controls.Add(subrad);
                subsub2[i] = subrad.Text;

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
            if (textBox1.Text.Equals(Secforschedcmb.Items[0].ToString()))
            {
                eveforPan.BackColor = Color.Blue;
            }
            else if (textBox1.Text.Equals(Secforschedcmb.Items[1].ToString()))
            {
                eveforPan.BackColor = Color.Red;
            }
            else if (textBox1.Text.Equals(Secforschedcmb.Items[2].ToString()))
            {
                eveforPan.BackColor = Color.Green;
            }
            else if (textBox1.Text.Equals(Secforschedcmb.Items[3].ToString()))
            {
                eveforPan.BackColor = Color.Yellow;
            }
            else if (textBox1.Text.Equals(Secforschedcmb.Items[4].ToString()))
            {
                eveforPan.BackColor = Color.Orange;
            }
            else if (textBox1.Text.Equals(Secforschedcmb.Items[5].ToString()))
            {
                eveforPan.BackColor = Color.Purple;
            }
            else if (textBox1.Text.Equals(Secforschedcmb.Items[6].ToString()))
            {
                eveforPan.BackColor = Color.Turquoise;
            }
            else if (textBox1.Text.Equals(Secforschedcmb.Items[7].ToString()))
            {
                eveforPan.BackColor = Color.Black;
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
            stud.Name = sched + "t";
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
            stud.Name = sched + "w";
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
            stud.Name = sched + "th";
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
            stud.Name = sched + "f";
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

        private void button2_Click(object sender, EventArgs e)
        {

            normalizationMon();
            normalizationTues();
            normalizationWed();
            normalizationThurs();
            normalizationFri();
        }

        public void normalizationMon()
        {
        #region Adding listbox
                    listBox1.Items.Clear();
                    listBox3.Items.Clear();

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
                    for (int j = 0; j <= 17; j++)
                    {

                        if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Blue)
                        {

                            listBox1.Items.Add(Secforschedcmb.Items[0] + "/ " + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                        }
                        else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Red)
                        {
                            listBox1.Items.Add(Secforschedcmb.Items[1] + "/ " + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                        }
                        else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Green)
                        {
                            listBox1.Items.Add(Secforschedcmb.Items[2] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                        }
                        else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Yellow)
                        {
                            listBox1.Items.Add(Secforschedcmb.Items[3] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                        }
                        else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Orange)
                        {
                            listBox1.Items.Add(Secforschedcmb.Items[4] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                        }
                        else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Purple)
                        {
                            listBox1.Items.Add(Secforschedcmb.Items[5] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                        }
                        else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Turquoise)
                        {
                            listBox1.Items.Add(Secforschedcmb.Items[6] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                        }
                        else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Black)
                        {
                            listBox1.Items.Add(Secforschedcmb.Items[7] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                        }
               
                    }
                    listBox1.Items.Add("Last Entry");

                    #region normalize
                    int curind = 0;
                    String cursub = listBox1.Items[curind].ToString();

                    for (int k = 0; k < listBox1.Items.Count; k++)
                    {
                        String curval = listBox1.Items[curind].ToString();
                        for (int l = 0; l < curval.Length; l++)
                        {
                            if (curval[l].ToString().Equals("/"))
                            {
                                curval = curval.Substring(0, l + 1);
                            }
                        }

                        String curval2 = listBox1.Items[k].ToString();
                        for (int d = 0; d < curval2.Length; d++)
                        {
                            if (curval2[d].ToString().Equals("/"))
                            {
                                curval2 = curval2.Substring(0, d + 1);
                            }
                        }

                        if (curval.Equals(curval2))
                        {

                            String curval3 = listBox1.Items[curind].ToString();
                            String subjectsubs3;
                            for (int l = 0; l < curval3.Length; l++)
                            {
                                if (curval3[l].ToString().Equals("-"))
                                {

                                    subjectsubs3 = curval3.Substring(0, l + 1);
                                    cursub = subjectsubs3;
                                }
                            }
                            String curval4 = listBox1.Items[k].ToString();
                            String subjectsubs4;
                            for (int l = 0; l < curval4.Length; l++)
                            {
                                if (curval4[l].ToString().Equals("-"))
                                {
                                    subjectsubs4 = curval4.Substring(l + 1);
                                    cursub = cursub + subjectsubs4;
                                }
                            }
                        }
                        else
                        {
                            listBox3.Items.Add(cursub);
                            curind = k;
                        }

                    }
                    #endregion
        #endregion
        }
        public void normalizationTues()
        {
        #region Adding listbox
            listBox1.Items.Clear();
            lbTues.Items.Clear();

            String[] schedt= { "08:00-08:30t",
                                       "08:30-09:00t",
                                       "09:00-09:30t",
                                       "09:30-010:00t",
                                       "10:00-10:30t",
                                       "10:30-11:00t",
                                       "11:00-11:30t",
                                       "11:30-12:00t",
                                       "12:00-12:30t",
                                       "12:30-01:00t",
                                       "01:00-01:30t",
                                       "01:30-02:00t",
                                       "02:00-02:30t",
                                       "02:30-03:00t",
                                       "03:00-03:30t",
                                       "03:30-04:00t",
                                       "04:00-04:30t",
                                       "04:30-05:00t"};
            for (int j2 = 0; j2 <= 17; j2++)
            {

                if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Blue)
                {

                    listBox1.Items.Add(Secforschedcmb.Items[0] + "/ " + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Red)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[1] + "/ " + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Green)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[2] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Yellow)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[3] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Orange)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[4] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Purple)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[5] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Turquoise)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[6] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Black)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[7] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }

            }
            listBox1.Items.Add("Last Entry");

            #region normalize
            int curind = 0;
            String cursub = listBox1.Items[curind].ToString();

            for (int k = 0; k < listBox1.Items.Count; k++)
            {
                String curval = listBox1.Items[curind].ToString();
                for (int l = 0; l < curval.Length; l++)
                {
                    if (curval[l].ToString().Equals("/"))
                    {
                        curval = curval.Substring(0, l + 1);
                    }
                }

                String curval2 = listBox1.Items[k].ToString();
                for (int d = 0; d < curval2.Length; d++)
                {
                    if (curval2[d].ToString().Equals("/"))
                    {
                        curval2 = curval2.Substring(0, d + 1);
                    }
                }

                if (curval.Equals(curval2))
                {

                    String curval3 = listBox1.Items[curind].ToString();
                    String subjectsubs3;
                    for (int l = 0; l < curval3.Length; l++)
                    {
                        if (curval3[l].ToString().Equals("-"))
                        {

                            subjectsubs3 = curval3.Substring(0, l + 1);
                            cursub = subjectsubs3;
                        }
                    }
                    String curval4 = listBox1.Items[k].ToString();
                    String subjectsubs4;
                    for (int l = 0; l < curval4.Length; l++)
                    {
                        if (curval4[l].ToString().Equals("-"))
                        {
                            subjectsubs4 = curval4.Substring(l + 1);
                            cursub = cursub + subjectsubs4;
                        }
                    }
                }
                else
                {
                    lbTues.Items.Add(cursub);
                    curind = k;
                }

            }
            #endregion
            #endregion
        }
        public void normalizationWed()
        {
            #region Adding listbox
            listBox1.Items.Clear();
            lbWed.Items.Clear();

            String[] schedt = { "08:00-08:30w",
                                       "08:30-09:00w",
                                       "09:00-09:30w",
                                       "09:30-010:00w",
                                       "10:00-10:30w",
                                       "10:30-11:00w",
                                       "11:00-11:30w",
                                       "11:30-12:00w",
                                       "12:00-12:30w",
                                       "12:30-01:00w",
                                       "01:00-01:30w",
                                       "01:30-02:00w",
                                       "02:00-02:30w",
                                       "02:30-03:00w",
                                       "03:00-03:30w",
                                       "03:30-04:00w",
                                       "04:00-04:30w",
                                       "04:30-05:00w"};
            for (int j2 = 0; j2 <= 17; j2++)
            {

                if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Blue)
                {

                    listBox1.Items.Add(Secforschedcmb.Items[0] + "/ " + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Red)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[1] + "/ " + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Green)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[2] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Yellow)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[3] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Orange)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[4] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Purple)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[5] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Turquoise)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[6] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(schedt[j2], true)[0]).BackColor == Color.Black)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[7] + "/" + ((Panel)this.Controls.Find(schedt[j2], true)[0]).Name);
                }

            }
            listBox1.Items.Add("Last Entry");

            #region normalize
            int curind = 0;
            String cursub = listBox1.Items[curind].ToString();

            for (int k = 0; k < listBox1.Items.Count; k++)
            {
                String curval = listBox1.Items[curind].ToString();
                for (int l = 0; l < curval.Length; l++)
                {
                    if (curval[l].ToString().Equals("/"))
                    {
                        curval = curval.Substring(0, l + 1);
                    }
                }

                String curval2 = listBox1.Items[k].ToString();
                for (int d = 0; d < curval2.Length; d++)
                {
                    if (curval2[d].ToString().Equals("/"))
                    {
                        curval2 = curval2.Substring(0, d + 1);
                    }
                }

                if (curval.Equals(curval2))
                {

                    String curval3 = listBox1.Items[curind].ToString();
                    String subjectsubs3;
                    for (int l = 0; l < curval3.Length; l++)
                    {
                        if (curval3[l].ToString().Equals("-"))
                        {

                            subjectsubs3 = curval3.Substring(0, l + 1);
                            cursub = subjectsubs3;
                        }
                    }
                    String curval4 = listBox1.Items[k].ToString();
                    String subjectsubs4;
                    for (int l = 0; l < curval4.Length; l++)
                    {
                        if (curval4[l].ToString().Equals("-"))
                        {
                            subjectsubs4 = curval4.Substring(l + 1);
                            cursub = cursub + subjectsubs4;
                        }
                    }
                }
                else
                {
                    lbWed.Items.Add(cursub);
                    curind = k;
                }

            }
            #endregion
            #endregion
        }
        public void normalizationThurs()
        {
            #region Adding listbox
            listBox1.Items.Clear();
            lbThurs.Items.Clear();

            String[] sched = { "08:00-08:30th",
                                       "08:30-09:00th",
                                       "09:00-09:30th",
                                       "09:30-010:00th",
                                       "10:00-10:30th",
                                       "10:30-11:00th",
                                       "11:00-11:30th",
                                       "11:30-12:00th",
                                       "12:00-12:30th",
                                       "12:30-01:00th",
                                       "01:00-01:30th",
                                       "01:30-02:00th",
                                       "02:00-02:30th",
                                       "02:30-03:00th",
                                       "03:00-03:30th",
                                       "03:30-04:00th",
                                       "04:00-04:30th",
                                       "04:30-05:00th"};
            for (int j = 0; j <= 17; j++)
            {

                if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Blue)
                {

                    listBox1.Items.Add(Secforschedcmb.Items[0] + "/ " + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Red)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[1] + "/ " + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Green)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[2] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Yellow)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[3] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Orange)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[4] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Purple)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[5] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Turquoise)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[6] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Black)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[7] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }

            }
            listBox1.Items.Add("Last Entry");

            #region normalize
            int curind = 0;
            String cursub = listBox1.Items[curind].ToString();

            for (int k = 0; k < listBox1.Items.Count; k++)
            {
                String curval = listBox1.Items[curind].ToString();
                for (int l = 0; l < curval.Length; l++)
                {
                    if (curval[l].ToString().Equals("/"))
                    {
                        curval = curval.Substring(0, l + 1);
                    }
                }

                String curval2 = listBox1.Items[k].ToString();
                for (int d = 0; d < curval2.Length; d++)
                {
                    if (curval2[d].ToString().Equals("/"))
                    {
                        curval2 = curval2.Substring(0, d + 1);
                    }
                }

                if (curval.Equals(curval2))
                {

                    String curval3 = listBox1.Items[curind].ToString();
                    String subjectsubs3;
                    for (int l = 0; l < curval3.Length; l++)
                    {
                        if (curval3[l].ToString().Equals("-"))
                        {

                            subjectsubs3 = curval3.Substring(0, l + 1);
                            cursub = subjectsubs3;
                        }
                    }
                    String curval4 = listBox1.Items[k].ToString();
                    String subjectsubs4;
                    for (int l = 0; l < curval4.Length; l++)
                    {
                        if (curval4[l].ToString().Equals("-"))
                        {
                            subjectsubs4 = curval4.Substring(l + 1);
                            cursub = cursub + subjectsubs4;
                        }
                    }
                }
                else
                {
                    lbThurs.Items.Add(cursub);
                    curind = k;
                }

            }
            #endregion
            #endregion
        }
        public void normalizationFri()
        {
            #region Adding listbox
            listBox1.Items.Clear();
            lbFri.Items.Clear();

            String[] sched = { "08:00-08:30f",
                                       "08:30-09:00f",
                                       "09:00-09:30f",
                                       "09:30-010:00f",
                                       "10:00-10:30f",
                                       "10:30-11:00f",
                                       "11:00-11:30f",
                                       "11:30-12:00f",
                                       "12:00-12:30f",
                                       "12:30-01:00f",
                                       "01:00-01:30f",
                                       "01:30-02:00f",
                                       "02:00-02:30f",
                                       "02:30-03:00f",
                                       "03:00-03:30f",
                                       "03:30-04:00f",
                                       "04:00-04:30f",
                                       "04:30-05:00f"};
            for (int j = 0; j <= 17; j++)
            {

                if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Blue)
                {

                    listBox1.Items.Add(Secforschedcmb.Items[0] + "/ " + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Red)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[1] + "/ " + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Green)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[2] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Yellow)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[3] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Orange)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[4] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Purple)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[5] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Turquoise)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[6] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }
                else if (((Panel)this.Controls.Find(sched[j], true)[0]).BackColor == Color.Black)
                {
                    listBox1.Items.Add(Secforschedcmb.Items[7] + "/" + ((Panel)this.Controls.Find(sched[j], true)[0]).Name);
                }

            }
            listBox1.Items.Add("Last Entry");

            #region normalize
            int curind = 0;
            String cursub = listBox1.Items[curind].ToString();

            for (int k = 0; k < listBox1.Items.Count; k++)
            {
                String curval = listBox1.Items[curind].ToString();
                for (int l = 0; l < curval.Length; l++)
                {
                    if (curval[l].ToString().Equals("/"))
                    {
                        curval = curval.Substring(0, l + 1);
                    }
                }

                String curval2 = listBox1.Items[k].ToString();
                for (int d = 0; d < curval2.Length; d++)
                {
                    if (curval2[d].ToString().Equals("/"))
                    {
                        curval2 = curval2.Substring(0, d + 1);
                    }
                }

                if (curval.Equals(curval2))
                {

                    String curval3 = listBox1.Items[curind].ToString();
                    String subjectsubs3;
                    for (int l = 0; l < curval3.Length; l++)
                    {
                        if (curval3[l].ToString().Equals("-"))
                        {

                            subjectsubs3 = curval3.Substring(0, l + 1);
                            cursub = subjectsubs3;
                        }
                    }
                    String curval4 = listBox1.Items[k].ToString();
                    String subjectsubs4;
                    for (int l = 0; l < curval4.Length; l++)
                    {
                        if (curval4[l].ToString().Equals("-"))
                        {
                            subjectsubs4 = curval4.Substring(l + 1);
                            cursub = cursub + subjectsubs4;
                        }
                    }
                }
                else
                {
                    lbFri.Items.Add(cursub);
                    curind = k;
                }

            }
            #endregion
            #endregion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label10.Text = textBox1.Text;
        }
    }
}
