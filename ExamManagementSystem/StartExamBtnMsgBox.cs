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
    public partial class StartExamBtnMsgBox : Form
    {
        public StartExamBtnMsgBox()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            var m = new ExamWindow();
            m.Show();
            this.Close();
        }
    }
}
