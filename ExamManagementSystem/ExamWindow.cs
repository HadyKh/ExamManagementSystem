using System;
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
            populateItem();


            int minuts = 10;//global.ExamDuration;
            int seconds = 0;

            totalseconds = (minuts * 60) + seconds;

            this.timer1.Enabled = true;
        }
        private void GetQuestionID()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("GetQuestionID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Qest", SqlDbType.NVarChar, 50).Value = " ";//global.ExamID;
                    global.countExamQuestions = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
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
        private void GetCountOfQuestionChoices()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_CountQuestionChoices", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Q_ID", SqlDbType.Int).Value = 1;//;
                    global.countQuestionChoices = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void populateItem()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    ListItemExamQuestion[] listQuestionItems = new ListItemExamQuestion[global.countExamQuestions];
                    SqlCommand cmd = new SqlCommand("GetExamQuestions", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@EX_ID", SqlDbType.Int).Value = global.ExamID;
                    SqlDataReader dr = cmd.ExecuteReader();
                    for (int i = 0; i < listQuestionItems.Length; i++)
                    {
                        dr.Read();
                        listQuestionItems[i] = new ListItemExamQuestion();
                        listQuestionItems[i].QNum = (i+1).ToString();
                        listQuestionItems[i].Question = dr["Quest"].ToString();
                        //listQuestionItems[i].Answer1 = dr["Ex_type"].ToString();
                        //listQuestionItems[i].Answer2 = dr["Duration"].ToString();
                        //listQuestionItems[i].Answer3 = dr["Ex_Datetime"].ToString();
                        //listQuestionItems[i].Answer4 = dr["Ex_Datetime"].ToString();
                    }
                    for (int i = 0; i < listQuestionItems.Length; i++)
                    {
                        flowLayoutPanelExamQuestion.Controls.Add(listQuestionItems[i]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

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
    }
}
