using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ExamManagementSystem
{
    public partial class ExamWindow : Form
    {
        private int h, m, s;
        public ExamWindow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s>=60)
            {
                m++;
                s = 0;
            }
            if (m>=60)
            {
                m = 0;
                s = 0;
                h++;
            }
            lblhh.Text = h.ToString();
            lblmm.Text = m.ToString();
            lblss.Text = s.ToString();
        }

        private void ExamWindow_Load(object sender, EventArgs e)
        {
            h = 0;
            m = 0;
            s = 0;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

    }
}
