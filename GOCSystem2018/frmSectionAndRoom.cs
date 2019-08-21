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
    public partial class frmSectionAndRoom : Form
    {
        public frmSectionAndRoom()
        {
            InitializeComponent();
        }

        Section section = new Section();
        List<Section> sections = new List<Section>();

        public string strand;

        public void CheckSectionInfo()
        {
            //clear list
            sections.Clear();
            dgvSectionInfo.Rows.Clear();

            //pass value to list
            sections = section.Load();
            foreach (var item in sections)
            {
                if (item.Strand == strand)
                {
                    dgvSectionInfo.Rows.Add(item.Strand, item.Room);
                }                          
            }           
        }

    }
}
