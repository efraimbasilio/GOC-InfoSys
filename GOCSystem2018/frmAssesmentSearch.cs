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
    public partial class frmStudSearch : Form
    {
        Assesment assesment = new Assesment();
        List<Assesment> assesments = new List<Assesment>();

        frmAssesment frmAssesment = new frmAssesment();

        public frmStudSearch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load all record From stud registration table
        /// </summary>
        public void LoadRecords()
        {
            //clear list        
            dgvSearch.Rows.Clear();
            assesments.Clear();        
            //pass value to list
            assesments = assesment.Load();
            //loop through load it to list view
            foreach (var item in assesments)
            {               
                dgvSearch.Rows.Add(item.Id, item.StudLRN, item.StudRegistrationNo, item.StudGOCNo, item.StudLastName, item.StudFirstName, item.StudGradeLevel, item.StudStrand);
            }
        }

        private void frmStudSearch_Load(object sender, EventArgs e)
        {

        }

        private void dgvSearch_DoubleClick(object sender, EventArgs e)
        {            
            if (dgvSearch.SelectedRows.Count > 0)
            {
                //clear list
                assesments.Clear();
                //pass value
                assesment.Id = Int32.Parse(dgvSearch.CurrentRow.Cells[0].FormattedValue.ToString());
                assesments = assesment.GetById();

                foreach (var item in assesments)
                {                    
                    //pass variable to form Assesment
                    frmAssesment.StudName = item.StudLastName+", "+item.StudFirstName +" "+item.StudMiddleName;
                    frmAssesment.LRN = item.StudLRN;
                    frmAssesment.GradeLevel = item.StudGradeLevel;
                    frmAssesment.Track = item.StudAcadTrack;
                    frmAssesment.RegNo = item.StudRegistrationNo;
                    frmAssesment.Strand = item.StudStrand;
                    
                    frmAssesment.Reset();
                    frmAssesment.LoadSection();
                    frmAssesment.LoadSchoolYear();
                   // frmAssesment.LoadStrand();
                    frmAssesment.RenderStudNo();
                    ///frmAssesment.tuitionFees2();
                }
                //show assesment                             
                frmAssesment.Show();
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //textBox1.Location = new Point(80, 141);
                //pictureBox1.Location = new Point(5, 87);
               // label2.Visible = false;
               // label1.Visible = false;

                dgvSearch.Visible = true;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

