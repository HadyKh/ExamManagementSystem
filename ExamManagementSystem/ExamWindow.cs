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
        private void populateItem()
        {
            ListItemExamQuestion[] listItems = new ListItemExamQuestion[20];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItemExamQuestion();
                listItems[i].QNum = "1";
                listItems[i].Question = "What is whata is what is";
                listItems[i].Answer1 = "select 1";
                listItems[i].Answer2 = "select 2";
                listItems[i].Answer3 = "select 3";
                listItems[i].Answer4 = "select 4";
                if (flowLayoutPanelExamQuestion.Controls.Count < 0)
                {
                    flowLayoutPanelExamQuestion.Controls.Clear();
                }
                else
                    flowLayoutPanelExamQuestion.Controls.Add(listItems[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s >= 60)
            {
                m++;
                s = 0;
            }
            if (m >= 60)
            {
                m = 0;
                s = 0;
                h++;
            }
            lblhh.Text = h.ToString();
            lblmm.Text = m.ToString();
            lblss.Text = s.ToString();
        }

        private void ExamWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void ExamWindow_Load(object sender, EventArgs e)
        {
            h = 0;
            m = 0;
            s = 0;
            populateItem();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

    }
}
