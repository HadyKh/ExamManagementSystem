using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        private int totalseconds;
        public ExamWindow()
        {
            InitializeComponent();
        }

        private void ExamWindow_Load(object sender, EventArgs e)
        {
            #region Timer
            int minuts = global.ExamDuration;
            int seconds = 0;
            totalseconds = (minuts * 60) + seconds;
            this.timer1.Enabled = true;
            #endregion

            GetCountOfExamQuestions();
            GetExamQuestions();
        }
        //first logical method to count the questions in the exam (we start here)
        private void GetCountOfExamQuestions()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_CountExamQuestion", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Ex_ID", SqlDbType.Int).Value = 1;//global.ExamID;
                    global.countExamQuestions = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void GetExamQuestions()
        {
            ListItemExamQuestion[] listItem = new ListItemExamQuestion[global.countExamQuestions];
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_GetExamQuestions", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Ex_ID", SqlDbType.Int).Value = 1;//global.ExamID;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    int i = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        listItem[i] = new ListItemExamQuestion();
                        listItem[i].QNum = i+1;
                        listItem[i].Question = row["Quest"].ToString();
                        int QID = (int)row["Q_ID"]; //get Question ID from above dr at SP_GetExamQuestions for each row
                        SqlCommand cmd2 = new SqlCommand("SP_GetQuestionChoices", con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@Q_ID", SqlDbType.Int).Value = QID;
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        DataTable dt2 = new DataTable();
                        dt2.Load(dr2);
                        string[] arr = new string[5];
                        int j = 0;
                        foreach (DataRow item in dt2.Rows)
                        {
                            arr[j] = item["Choice"].ToString();
                            j++;
                        }
                        listItem[i].Answer1 = arr[0];
                        listItem[i].Answer2 = arr[1];
                        listItem[i].Answer3 = arr[2];
                        listItem[i].Answer4 = arr[3];
                        flowLayoutPanelExamQuestion.Controls.Add(listItem[i]);
                        i++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        #region methods
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalseconds > 0)
            {
                totalseconds--;
                int minuts = totalseconds / 60;
                int seconds = totalseconds - (minuts * 60);
                lblTimer.Text = minuts.ToString() + " : " + seconds.ToString();
            }
            else
            {
                this.timer1.Stop();
                this.Hide();
                MessageBox.Show("time's up!!");
                Form1 f1 = new Form1();
                f1.Show();
            }

        }

        private void ExamWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        #endregion
    }
}
