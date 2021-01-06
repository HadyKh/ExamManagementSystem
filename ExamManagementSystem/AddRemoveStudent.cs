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
    public partial class AddRemoveStudent : Form
    {
        public AddRemoveStudent()
        {
            InitializeComponent();
        }

        //private void buttonMaximize_Click(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Maximized;
        //}

        //private void buttonMinimize_Click(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Minimized;
        //}

        //private void buttonClose_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
