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
    public partial class SplashScreenWindow : Form
    {
        public SplashScreenWindow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            paneltimer.Width += 3;
            if (paneltimer.Width >= panel1.Width)
            {
                timer1.Stop();
                var s = new SigninWindow();
                s.Show();
                this.Hide();
            }
                
        }

        private void paneltimer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplashScreenWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
