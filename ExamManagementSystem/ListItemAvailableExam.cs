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
    public partial class ListItemAvailableExam : Form
    {
        public ListItemAvailableExam()
        {
            InitializeComponent();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new StartExamBtnMsgBox();
            m.Show();
        }

        private void lblTopicName_Click(object sender, EventArgs e)
        {

        }

        private void lblExamType_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblExamTime_Click(object sender, EventArgs e)
        {

        }
    }
}
