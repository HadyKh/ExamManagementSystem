using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;


namespace ExamManagementSystem
{
    public partial class AdminWindow : Form
    {
        //private bool isCollapsed;
        public AdminWindow()
        {
            InitializeComponent();
        }

        int t1 = 62;
        int t2 = 62;
        int t3 = 62;

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void buttonExitAdmin_Click(object sender, EventArgs e)
        {
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label2.Text = datetime.ToString();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
  
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panelStudent.Height> 300)
            {
                buttonStudent.Image = Properties.Resources.collapse_arrow;
                timer2.Stop();
            }
            else
            {
                buttonStudent.Image = Properties.Resources.expand_Arrow;
                this.panelStudent.Size = new Size(panelStudent.Size.Width, t1);
                t1 += 5;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (panelInstructor.Height > 300)
            {
                buttonInstructor.Image = Properties.Resources.collapse_arrow;
                timer3.Stop();
            }
            else
            {
                buttonInstructor.Image = Properties.Resources.expand_Arrow;
                this.panelInstructor.Size = new Size(panelInstructor.Size.Width, t2);
                t2 += 5;
            }
        }
       
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (panelCourses.Height > 300)
            {
                buttonCourses.Image = Properties.Resources.collapse_arrow;
                timer4.Stop();
            }
            else
            {
                buttonCourses.Image = Properties.Resources.expand_Arrow;
                this.panelCourses.Size = new Size(panelCourses.Size.Width, t3);
                t3 += 5;
            }

        }

        private void buttonstudent_mousehover(object sender, EventArgs e)
        {
            this.panelInstructor.Size = new Size(this.panelInstructor.Size.Width, t2);
            this.panelCourses.Size = new Size(this.panelCourses.Size.Width, t3);
            timer2.Start();
        }

        private void buttonStudent_MouseLeave(object sender, EventArgs e)
        {
            timer2.Stop();
            t1 =62;
        }

        private void buttonInstructor_MouseHover(object sender, EventArgs e)
        {
            this.panelStudent.Size = new Size(this.panelStudent.Size.Width, t1);
            this.panelCourses.Size = new Size(this.panelCourses.Size.Width, t3);
            timer3.Start();
        }

        private void buttonInstructor_MouseLeave(object sender, EventArgs e)
        {
            timer3.Stop();
            t2 = 62;
        }

        private void buttonCourses_MouseHover(object sender, EventArgs e)
        {
            this.panelStudent.Size = new Size(this.panelStudent.Size.Width, t1);
            this.panelInstructor.Size = new Size(this.panelInstructor.Size.Width, t2);
            timer4.Start();
        }

        private void buttonCourses_MouseLeave(object sender, EventArgs e)
        {
            timer4.Stop();
            t3 = 62;

        }

        private void buttonDisplayCourses_Click(object sender, EventArgs e)
        {
            var m = new DisplayCourses();
            m.Show();
            this.Hide();
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            var m = new AdminAddCourse();
            m.Show();
            this.Hide();
        }

        private void buttonRemoveCourse_Click(object sender, EventArgs e)
        {
            var m = new AddRemoveCourse();
            m.Show();
            this.Hide();
        }

        private void buttonDisplayInstructor_Click(object sender, EventArgs e)
        {
            var m = new AdminDisplayInstructor();
            m.Show();
            this.Hide();
        }

        private void buttonAddInstructor_Click(object sender, EventArgs e)
        {
            var m = new AdminAddInstructor();
            m.Show();
            this.Hide();
        }

        private void buttonRemoveInstructor_Click(object sender, EventArgs e)
        {
            var m = new AddRemoveInstructor();
            m.Show();
            this.Hide();
        }

        private void buttonDisplayStudent_Click(object sender, EventArgs e)
        {
            var m = new AdminDisplayStudent();
            m.Show();
            this.Hide();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var m = new AdminAddStudent();
            m.Show();
            this.Hide();
        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            var m = new AddRemoveStudent();
            m.Show();
            this.Hide();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
