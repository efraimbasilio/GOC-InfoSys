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

                    frmAssesment.Reset();
                    frmAssesment.LoadSection();
                    frmAssesment.LoadSchoolYear();
                    frmAssesment.LoadStrand();
                    frmAssesment.RenderStudNo();
                }
                //show assesment                             
                frmAssesment.Show();
                this.Dispose();
            }
        }
        


     }
}

