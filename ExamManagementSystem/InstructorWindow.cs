﻿using System;
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
    public partial class InstructorWindow : Form
    {
        
        public InstructorWindow()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

       

        private void buttonExam_Click(object sender, EventArgs e)
        {
            ListItemExamGeneration listItems = new ListItemExamGeneration();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(listItems);
            //decoration panel
            panelForButton.Height = buttonExam.Height;
            panelForButton.Top = buttonExam.Top;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelForButton.Height = buttonDashboard.Height;
            panelForButton.Top = buttonDashboard.Top;
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            ListItemStudentFromInstrutor listItem = new ListItemStudentFromInstrutor();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(listItem);
            //database Connection
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    //SqlDataAdapter sqlDa = new SqlDataAdapter("SP_studentInfoForInstructor", con);
                    SqlDataAdapter sqlDa = new SqlDataAdapter("select CONCAT(s.St_Fname,' ',s.St_Lname) 'Student Name', c.Crs_Name as 'Course Name', t.Tp_name 'Topic Name', e.Ex_Type'Exam Type', se.Score 'Topic Score', sc.Crs_Grade 'Course Grade' from Student s, Std_Crs sc, Courses c, Topic t, Student_Exam se, Exam e where s.St_ID = sc.St_ID and c.Crs_ID = sc.Crs_ID and se.St_ID = s.St_ID and t.Ins_ID = 21 and se.EX_ID = e.Ex_ID", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    listItem.GridSetGet = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            //decoration panel
            panelForButton.Height = buttonStudents.Height;
            panelForButton.Top = buttonStudents.Top;
        }

        #region ordinaryButtons
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e) //buttonEdit
        {
            panelForButton.Height = buttonEdit.Height;
            panelForButton.Top = buttonEdit.Top;
        }

        private void buttonExitInstructor_Click(object sender, EventArgs e)
        {
            //do not forget to terminate the database connection
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

       
        private void circularPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
               WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label2.Text = datetime.ToString();
        }

       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion
    }
}
