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
    public partial class frmAssesmentSearch : Form
    {
        Assesment assesment = new Assesment();

        List<Assesment> assesments = new List<Assesment>();


        public frmAssesmentSearch()
        {
            InitializeComponent();
        }

        public void LoadSearchAsses()
        {
            ////clear list            
            ////dgvTuitionFees.Rows.Clear();            
            //assesments.Clear();

            ////pass value to list
            //assesments = assesment.Load();

            ////loop through load it to list view
            //foreach (var item in assesments)
            //{
            //    //Load to datagridView
            //    //dgvTuitionFees.Rows.Add(item.Id, item.TuitionFeeName, item.TuitionFeeAmount, item.TuitionFeeDescription);
            //    lblLRN.Text = item.StudLRN;
            //    lblName.Text = item.StudLastName + ", " + item.StudFirstName + " " + item.StudMiddleName;
            //    //lblName.Text = item.StudLastName;

            //}
        }
    }
}
