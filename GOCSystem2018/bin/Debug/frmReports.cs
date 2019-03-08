using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MySql.Data.MySqlClient;

namespace GOCSystem2018
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }
        public string studName { get; set; }
        public string SY { get; set; }
        public string GOCNO { get; set; }
        public string Strand { get; set; }
        public string Semester { get; set; }
        public string StudName { get; set; }
        public string GradeLevel { get; set; }
        public string Section { get; set; }

        public string Start { get; set; }
        public string End { get; set; }
        public string Mon { get; set; }
        public string Tue { get; set; }
        public string Wed { get; set; }
        public string Thur { get; set; }
        public string Fri { get; set; }
        public double Tuition { get; set; }
        public string Room { get; set; }
        public string Strand2 { get; set; }


        Schedule schedule = new Schedule();
        List<Schedule> schedules = new List<Schedule>();
        public void Credential()
        {

            //CrystalConnection.HOST = AcquaintanceSTI2016.Config.DB_HOST;
            CrystalConnection1.DSN = GOCSystem2018.Config.DSN;
            CrystalConnection1.database = GOCSystem2018.Config.DB_NAME;
            CrystalConnection1.username = GOCSystem2018.Config.DB_USER;
            CrystalConnection1.password = GOCSystem2018.Config.DB_PASSWORD;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
        public string studname;
        private void button1_Click(object sender, EventArgs e)
        {
            Credential();

            ReportDocument cryRpt = new ReportDocument();

            cryRpt.Load(Application.StartupPath + "/rptAssesment.rpt");

            CrystalConnection1.Instance.SetConnection(ref cryRpt);

            cryRpt.SetParameterValue("StudentName", studName);
            cryRpt.SetParameterValue("SY", SY);
            cryRpt.SetParameterValue("Strand", Strand);
            cryRpt.SetParameterValue("Semester", Semester);
            cryRpt.SetParameterValue("Section", Section);
            cryRpt.SetParameterValue("GradeLevel", GradeLevel);
            cryRpt.SetParameterValue("GOCNo", GOCNO);

            cryRpt.SetParameterValue("Start", Start);
            cryRpt.SetParameterValue("End", End);
            cryRpt.SetParameterValue("Mon", Mon);
            cryRpt.SetParameterValue("Tue", Tue);
            cryRpt.SetParameterValue("Wed", Wed);
            cryRpt.SetParameterValue("Thur", Thur);
            cryRpt.SetParameterValue("Fri", Fri);
            cryRpt.SetParameterValue("Room", Room);

            cryRpt.SetParameterValue("Tuition", Tuition);
            cryRpt.SetParameterValue("Strand2", Strand2);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
