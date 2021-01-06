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
    public partial class SigninWindow : Form
    {
        public SigninWindow()
        {
            InitializeComponent();
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

        private void buttonInstructorSignIn_Click(object sender, EventArgs e)
        {
            var m = new SigninAsInstructorMsgBox();
            m.Show();
            this.Hide();
        }

        private void buttonStudentSignIn_Click(object sender, EventArgs e)
        {
            var m = new SigninAsStudentMsgBox();
            m.Show();
            this.Hide();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            var m = new SigninAsAdminMsgBox();
            m.Show();
            this.Hide();
        }
    }
}
