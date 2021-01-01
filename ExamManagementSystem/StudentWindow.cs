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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitStudent_Click(object sender, EventArgs e)
        {
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

        private void buttonAvailableExams_Click(object sender, EventArgs e)
        {

        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
