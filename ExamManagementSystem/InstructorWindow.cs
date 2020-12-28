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

        }
    }
}
