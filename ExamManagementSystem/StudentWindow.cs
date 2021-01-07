using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ExamManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    //Set student name under his pic
                    con.Open();
                    SigninAsStudentMsgBox s = new SigninAsStudentMsgBox();
                    SqlCommand cmd = new SqlCommand("Select Concat(St_fname,' ' ,St_lname) 'Student Name' from Student where St_ID = "+global.StudentID ,con);
                    string name = Convert.ToString(cmd.ExecuteScalar());
                    lblSt_name.Text = name;
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitStudent_Click(object sender, EventArgs e)
        {
            //do not forget to terminate the database connection
            #region TerminationOfDataBase Connection
            //Termination code goes Here
            #endregion

            #region CloseAndOpen
            //this has to be the last code in this method
            //open the signIn window and close the admin window
            var m = new SigninWindow();
            m.Show();
            this.Close();
            #endregion
        }

        private void populateExamItems()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SigninAsStudentMsgBox s = new SigninAsStudentMsgBox();

                    listItemAvailableExam[] listExamItems = new listItemAvailableExam[10];
                    for (int i = 0; listExamItems.Length > i; i++)
                    {
                        listExamItems[i] = new listItemAvailableExam();
                        SqlCommand cmd = new SqlCommand("SP_AvailableExam", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@St_ID", SqlDbType.NVarChar, 50).Value =global.StudentID ;
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            listExamItems[i].CrsName = dr["Crs_name"].ToString();
                            listExamItems[i].TopicName = dr["Tp_name"].ToString();
                            listExamItems[i].ExamType = dr["Ex_type"].ToString();
                            listExamItems[i].Time = dr["Duration"].ToString();
                            listExamItems[i].At = dr["Ex_Datetime"].ToString(); 
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void populateGradeItems()
        {
            ListItemStudentGrade[] GradeItems = new ListItemStudentGrade[10]; //<= number of exams that the student took

            for (int i = 0; i < GradeItems.Length; i++)
            {
                GradeItems[i] = new ListItemStudentGrade();
                GradeItems[i].CourseName = "Web";
                GradeItems[i].TopicName = "HTML";
                GradeItems[i].ExamType = "First Chance";
                GradeItems[i].Grade = 80.76M;

                if (flowLayoutPanelwindowshow.Controls.Count < 0)
                {
                    flowLayoutPanelwindowshow.Controls.Clear();
                }
                else
                    flowLayoutPanelwindowshow.Controls.Add(GradeItems[i]);
            }
        }
        private void buttonAvailableExams_Click(object sender, EventArgs e)
        {
            flowLayoutPanelwindowshow.Controls.Clear();
            populateExamItems();
            panelForButton.Height = buttonAvailableExams.Height;
            panelForButton.Top = buttonAvailableExams.Top;
        }

        private void buttonGrades_Click(object sender, EventArgs e)
        {
            flowLayoutPanelwindowshow.Controls.Clear();
            populateGradeItems();
            panelForButton.Height = buttonGrades.Height;
            panelForButton.Top = buttonGrades.Top;
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label2.Text = datetime.ToString();
        }

        private void buttonMaximize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void buttonMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
