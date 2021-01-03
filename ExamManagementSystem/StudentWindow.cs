using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            String cs = "data source =DESKTOP-HI3M44K\\DEVSQL ; database = ExamManagmentSystem : integrated security = SSPI";
            SqlConnection con = new SqlConnection(cs);
            
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

        private void populateItems()
        {
            listItemAvailableExam[] listItems = new listItemAvailableExam[10];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new listItemAvailableExam();
                listItems[i].At = "10:00 PM";
                listItems[i].TopicName = "C#";
                listItems[i].CrsName = "Programming";
                listItems[i].Time = "1 hour";
                listItems[i].ExamType = "First chance";

                if (flowLayoutPanelwindowshow.Controls.Count < 0)
                {
                    flowLayoutPanelwindowshow.Controls.Clear();
                }
                else
                    flowLayoutPanelwindowshow.Controls.Add(listItems[i]);
            }

        }

        private void buttonAvailableExams_Click(object sender, EventArgs e)
        {
            
            populateItems();
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {

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

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonGrades_Click(object sender, EventArgs e)
        {

        }
    }
}
