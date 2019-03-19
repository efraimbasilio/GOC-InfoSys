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
    public partial class frmGrading : Form
    {
        public frmGrading()
        {
            InitializeComponent();
        }

        Section section = new Section();
        Grading grade = new Grading();


        List<Grading> grades = new List<Grading>();
        List<Section> sections = new List<Section>();

        /****************************************************************************************************************************/
        private void LoadGrade()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT * FROM grading";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    //initialize new datatable
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvGrades.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /****************************************************************************************************************************/
        public void searchData(string valueToSearch)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM grading WHERE CONCAT(`last_name`, `first_name`,`regno`) LIKE '%" + valueToSearch + "%'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    //initialize new datatable
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvGrades.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadGrading()
        {
            //clear list
            grades.Clear();
            dgvGrades.Rows.Clear();
            //pass value to list
            grades = grade.Load();

            //loop through load it to list view
            foreach (var item in grades)
            {
                //Load to datagridView
                dgvGrades.Rows.Add(item.Id,item.StudentId, item.Fullname, item.SubjectCode, item.Units, item.FirstQ, item.SecondQ, item.Average, item.Remarks, item.Term, item.GradeLevel, item.Section, item.Strand);
            }//End LoadSchedule()
        }

        public void LoadThisGrades()
        {
            //clear list
            grades.Clear();
            dgvGrades.Rows.Clear();
            //pass value to list

            grades = grade.LoadThisGrades();

            //loop through load it to list view
            foreach (var item in grades)
            {
                //Load to datagridView
                dgvGrades.Rows.Add(item.Id, item.StudentId, item.Fullname, item.SubjectCode, item.Units, item.FirstQ, item.SecondQ, item.Average, item.Remarks, item.Term, item.GradeLevel, item.Section, item.Strand);
            }//End LoadSchedule()
        }

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

        public void LoadSubject()
        {
            //clear list

            //dgvDiscount.Rows.Clear();
            cmbSubject.Items.Clear();
            grades.Clear();

            //pass value to list
            grades = grade.Load();

            //loop through load it to list view
            foreach (var item in grades)
            {
                //Load to datagridView
                //dgvDiscount.Rows.Add(item.Id, item.DiscountName, item.DiscountAmount);
                cmbSubject.Items.Add(item.SubjectCode);
            }

        }//End LoadRecords()
        /****************************************************************************************************************************/
        private void frmGrading_Load(object sender, EventArgs e)
        {
            LoadGrading();
            LoadSection();
            LoadSubject();
        }

        private void cmbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grade.Term = cmbTerm.Text;
            grade.Section = cmbSection.Text;
            grade.SubjectCode = cmbSubject.Text;
            grade.GradeLevel = cmbGradeLevel.Text;

            LoadThisGrades();
        }
    }
}
