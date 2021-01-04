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
            //string s = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HI3M44K\\DEVSQL;Initial Catalog=ExamManagementSystem;Integrated Security=True");           
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
            listItemAvailableExam[] listItems = new listItemAvailableExam[10];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new listItemAvailableExam();
                listItems[i].At = "10:00 PM";
                listItems[i].TopicName = "C#";
                listItems[i].CrsName = "Programming";
                listItems[i].Time = "1 hour";
                listItems[i].ExamType = "First chance";

                if (flowLayoutPanelwindowshow.Controls.Count < 0)
                {
                    flowLayoutPanelwindowshow.Controls.Clear();
                }
                else
                    flowLayoutPanelwindowshow.Controls.Add(listItems[i]);
            }

        }

        private void populateGradeItems()
        {
            ListItemStudentGrade[] GradeItems = new ListItemStudentGrade[10]; // <= number of exams that the student took

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


    }
}
