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
    public partial class frmAssesment : Form
    {
        Assesment assesment = new Assesment();
        Registration registration = new Registration();
        Section section = new Section();
        Strand strand = new Strand();
        SchoolYear schoolYear = new SchoolYear();


        List<Section> sections = new List<Section>();
        List<Strand> strands = new List<Strand>();
        List<Assesment> assesments = new List<Assesment>();
        List<SchoolYear> schoolYears = new List<SchoolYear>();

        public frmAssesment()
        {
            InitializeComponent();
        }

        private void frmAssesment_Load(object sender, EventArgs e)
        {
                    
        }

        private void Render()
        {
            lblLRN.Text = assesment.StudLRN;
            
        }
        public void LoadSchoolYear()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            cmbSchoolYear.Items.Clear();
            schoolYears.Clear();

            //pass value to list
            schoolYears = schoolYear.Load();

            //loop through load it to list view
            foreach (var item in schoolYears)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                string School;
                School = (item.YearStart +" - " +item.YearEnd);
                cmbSchoolYear.Items.Add(School);
            }
        }//End LoadRecords()

        public void LoadSection()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            cmbSection.Items.Clear();
            sections.Clear();

            //pass value to list
            sections = section.Load();

            //loop through load it to list view
            foreach (var item in sections)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                cmbSection.Items.Add(item.SectionName);
            }
        }//End LoadRecords()

        public void LoadStrand()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            cmbStrand.Items.Clear();
            strands.Clear();

            //pass value to list
            strands = strand.Load();

            //loop through load it to list view
            foreach (var item in strands)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                cmbStrand.Items.Add(item.StrandName);
            }
        }//End LoadRecords()



        public void LoadRecords()
        {
            //clear list
            //listView1.Items.Clear();
            //dgvTuitionFees.Rows.Clear();
            List<Assesment> assesments = new List<Assesment>();
            
            assesments.Clear();

            //pass value to list
            assesments = assesment.Load();

            //loop through load it to list view
            foreach (var item in assesments)
            {
                //Load to datagridView
                //dgvTuitionFees.Rows.Add(item.Id, item.TuitionFeeName, item.TuitionFeeAmount, item.TuitionFeeDescription);
                lblLRN.Text = item.StudLRN;
                lblName.Text = item.StudLastName + ", " + item.StudFirstName + " " + item.StudMiddleName;
                lblGradeLevel.Text = item.StudGradeLevel;
                lblTrack.Text = item.StudAcadTrack;

            }
        }//End LoadRecords()


        public void Reset()
        {
            assesments.Clear();
            txtSearhAssesment.Text = string.Empty;
            lblLRN.Text = string.Empty;
            lblName.Text = string.Empty;
            lblGradeLevel.Text = string.Empty;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            assesment.StudLRN = "";
            assesment.GetById();

            LoadRecords();
        }
    }
}
