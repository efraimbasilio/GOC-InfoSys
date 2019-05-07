using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class Grading
    {
        /******************************
         * Protected Properties
         * ***************************/
        protected int id;
        protected string studentId;
        protected string fullName;
        protected string subjectCode;
        protected string subjectDesc;
        protected string units;
        protected double firstQ;
        protected double secondQ;
        protected double average;
        protected string remarks;
        protected string term;
        protected string gradeLevel;
        protected string section;
        protected string strand;

        //protected int flag;

        /******************************
         * Private Properties
         * ***************************/
        /******************************
         * Public Properties
         * ***************************/
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Average
        {
            get { return average; }
            set { average = value; }
        }
        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string Fullname
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        public string SubjectDesc
        {
            get { return subjectDesc; }
            set { subjectDesc = value; }
        }
        public string Units
        {
            get { return units; }
            set { units = value; }
        }
        public double FirstQ
        {
            get { return firstQ; }
            set { firstQ = value; }
        }
        public double SecondQ
        {
            get { return secondQ; }
            set { secondQ = value; }
        }
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
        public string Term  
        {
            get { return term; }
            set { term = value; }
        }

        public string GradeLevel
        {
            get { return gradeLevel; }
            set { gradeLevel = value; }
        }
        public string Section
        {
            get { return section; }
            set { section = value; }
        }
        public string Strand
        {
            get { return strand; }
            set { strand = value; }
        }

        List<Grading> grades = new List<Grading>();

        public List<Grading> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM grading";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Grading grade = new Grading();

                        //prepare properties
                        grade.id = Convert.ToInt32(reader["id"].ToString());
                        grade.studentId = reader["IDNo"].ToString();
                        grade.fullName = reader["full_name"].ToString();
                        grade.subjectCode = reader["subject_code"].ToString();
                        grade.subjectDesc = reader["subject_desc"].ToString();
                        grade.units = reader["units"].ToString();
                        grade.firstQ = Convert.ToDouble(reader["1stQ"].ToString());
                        grade.secondQ = Convert.ToDouble(reader["2ndQ"].ToString());
                        grade.average = Convert.ToDouble(reader["average"].ToString());
                        grade.remarks = reader["remarks"].ToString();
                        grade.term = reader["term"].ToString();
                        grade.gradeLevel = reader["grade_level"].ToString();
                        grade.section = reader["section"].ToString();
                        grade.strand = reader["strand"].ToString();

                        grades.Add(grade);

                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return grades;
        }//End of Load

        public List<Grading> LoadThisGrades()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT * FROM grading WHERE subject_Code=@subjectCode and term=@term and grade_level=@gradeLevel and section=@section";
                    //IDNo = @studentId and
                     MySqlCommand cmd = new MySqlCommand(sql, con);

                    //cmd.Parameters.AddWithValue("studentId", studentId);
                    cmd.Parameters.AddWithValue("subjectCode", subjectCode);
                    cmd.Parameters.AddWithValue("term", term);
                    cmd.Parameters.AddWithValue("gradeLevel", gradeLevel);
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("strand", strand);


                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Grading grade = new Grading();

                        //prepare properties
                        grade.id = Convert.ToInt32(reader["id"].ToString());
                        grade.studentId = reader["IDNo"].ToString();
                        grade.fullName = reader["full_name"].ToString();
                        grade.subjectCode = reader["subject_code"].ToString();
                        grade.subjectDesc = reader["subject_desc"].ToString();
                        grade.units = reader["units"].ToString();
                        grade.firstQ = Convert.ToDouble(reader["1stQ"].ToString());
                        grade.secondQ = Convert.ToDouble(reader["2ndQ"].ToString());
                        grade.average = Convert.ToDouble(reader["average"].ToString());
                        grade.remarks = reader["remarks"].ToString();
                        grade.term = reader["term"].ToString();
                        grade.gradeLevel = reader["grade_level"].ToString();
                        grade.section = reader["section"].ToString();
                        grade.strand = reader["strand"].ToString();

                        grades.Add(grade);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return grades;
        }//End of Load

        public List<Grading> LoadSubjects()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //prepare sql query
                    string sql = "SELECT subject_code FROM grading ";
                    //IDNo = @studentId and grading WHERE subject_Code=@subjectCode and term=@term and grade_level=@gradeLevel, section=@section
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    //cmd.Parameters.AddWithValue("studentId", studentId);
                    //cmd.Parameters.AddWithValue("subjectCode", subjectCode);
                    //cmd.Parameters.AddWithValue("term", term);
                    //cmd.Parameters.AddWithValue("gradeLevel", gradeLevel);
                    //cmd.Parameters.AddWithValue("section", section);
                    //cmd.Parameters.AddWithValue("strand", strand);


                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Grading grade = new Grading();

                        //prepare properties
                        grade.id = Convert.ToInt32(reader["id"].ToString());
                        grade.studentId = reader["IDNo"].ToString();
                        //grade.fullName = reader["full_name"].ToString();
                        grade.subjectCode = reader["subject_code"].ToString();
                        //grade.subjectDesc = reader["subject_desc"].ToString();
                        //grade.units = reader["units"].ToString();
                        //grade.firstQ = Convert.ToDouble(reader["1stQ"].ToString());
                        //grade.secondQ = Convert.ToDouble(reader["2ndQ"].ToString());
                        //grade.average = Convert.ToDouble(reader["average"].ToString());
                        //grade.remarks = reader["remarks"].ToString();
                        //grade.term = reader["term"].ToString();
                        //grade.gradeLevel = reader["grade_level"].ToString();
                        //grade.section = reader["section"].ToString();
                        //grade.strand = reader["strand"].ToString();

                        grades.Add(grade);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return grades;
        }//End of Load

        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOCSystem2018.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO grading(IDNo,	full_name,subject_code,	subject_desc, units,1stQ,2ndQ,average,remarks,term,grade_level,section,	strand) " +
                                    " VALUES (@studentId,@fullName,@subjectCode,@subjectDesc,@units,@firstQ,@secondQ,@average,@remarks,@term,@gradeLevel,@section,@strand);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("studentId", studentId);
                    cmd.Parameters.AddWithValue("fullName", fullName);
                    cmd.Parameters.AddWithValue("subjectCode", subjectCode);
                    cmd.Parameters.AddWithValue("subjectDesc", subjectDesc);
                    cmd.Parameters.AddWithValue("units", units);
                    cmd.Parameters.AddWithValue("firstQ", firstQ);
                    cmd.Parameters.AddWithValue("secondQ", secondQ);
                    cmd.Parameters.AddWithValue("average", average);
                    cmd.Parameters.AddWithValue("remarks", remarks);
                    cmd.Parameters.AddWithValue("term", term);
                    cmd.Parameters.AddWithValue("gradeLevel", gradeLevel);
                    cmd.Parameters.AddWithValue("section", section);
                    cmd.Parameters.AddWithValue("strand", strand);
                    
                    cmd.ExecuteNonQuery();

                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
