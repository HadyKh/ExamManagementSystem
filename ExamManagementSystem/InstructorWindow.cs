using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExam_Click(object sender, EventArgs e)
        {
            
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
            panelForButton.Height = buttonStudents.Height;
            panelForButton.Top = buttonStudents.Top;
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
    }
}
