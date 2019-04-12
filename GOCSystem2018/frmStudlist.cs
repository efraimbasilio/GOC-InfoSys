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
    public partial class frmStudlist : Form
    {
        public frmStudlist()
        {
            InitializeComponent();
        }

        private void frmStudlist_Load(object sender, EventArgs e)
        {
            

            #region removal of unneccessary header
            this.dgvSearch.Columns["id"].Visible = false;
            this.dgvSearch.Columns["IDNo"].Visible = false;
            this.dgvSearch.Columns["regNo"].Visible = false;
            this.dgvSearch.Columns["Reservee"].Visible = false;
            this.dgvSearch.Columns["Reserve_for"].Visible = false;
            this.dgvSearch.Columns["Full_payment"].Visible = false;
            this.dgvSearch.Columns["Partial_payment"].Visible = false;
            this.dgvSearch.Columns["photo_loc"].Visible = false;
            this.dgvSearch.Columns["voucher_type"].Visible = false;
            this.dgvSearch.Columns["address"].Visible = false;
            this.dgvSearch.Columns["date_of_birth"].Visible = false;
            this.dgvSearch.Columns["place_of_birth"].Visible = false;
            this.dgvSearch.Columns["religion"].Visible = false;
            this.dgvSearch.Columns["nationality"].Visible = false;
            this.dgvSearch.Columns["gender"].Visible = false;
            this.dgvSearch.Columns["stud_contactNo"].Visible = false;
            this.dgvSearch.Columns["stud_telNo"].Visible = false;
            this.dgvSearch.Columns["prev_school"].Visible = false;
            this.dgvSearch.Columns["prev_school_address"].Visible = false;
            this.dgvSearch.Columns["father_name"].Visible = false;
            this.dgvSearch.Columns["father_work"].Visible = false;
            this.dgvSearch.Columns["mother_name"].Visible = false;
            this.dgvSearch.Columns["mother_work"].Visible = false;
            this.dgvSearch.Columns["guardian_name"].Visible = false;
            this.dgvSearch.Columns["guardian_work"].Visible = false;
            this.dgvSearch.Columns["guardian_address"].Visible = false;
            this.dgvSearch.Columns["guardian_relationship"].Visible = false;
            this.dgvSearch.Columns["guardian_contactNo"].Visible = false;
            this.dgvSearch.Columns["guardian_telNo"].Visible = false;
            this.dgvSearch.Columns["bc"].Visible = false;
            this.dgvSearch.Columns["form138"].Visible = false;
            this.dgvSearch.Columns["drugtest"].Visible = false;
            this.dgvSearch.Columns["good_moral"].Visible = false;
            this.dgvSearch.Columns["en_exam"].Visible = false;
            this.dgvSearch.Columns["ncae"].Visible = false;
            this.dgvSearch.Columns["date_enrolled"].Visible = false;
            this.dgvSearch.Columns["sy_enrolled"].Visible = false;
            this.dgvSearch.Columns["1"].Visible = false;
            this.dgvSearch.Columns["2"].Visible = false;
            #endregion
            #region header name fix
            dgvSearch.Columns["LRN"].HeaderText = "LRN";
            dgvSearch.Columns["last_name"].HeaderText = "Last Name";
            dgvSearch.Columns["first_name"].HeaderText = "First Name";
            dgvSearch.Columns["middle_name"].HeaderText = "Middle Name";
            dgvSearch.Columns["grade_Level"].HeaderText = "Grade Level";
            dgvSearch.Columns["section"].HeaderText = "Section";
            dgvSearch.Columns["track"].HeaderText = "Track";
            dgvSearch.Columns["strand"].HeaderText = "Strand";
            #endregion
            #region designing DVG
            dgvSearch.BorderStyle = BorderStyle.None;
            dgvSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSearch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSearch.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvSearch.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSearch.BackgroundColor = Color.White;

            dgvSearch.EnableHeadersVisualStyles = false;
            dgvSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 150, 179);
            dgvSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            #endregion
        }
    }
}
