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
        private ListItemExamQuestion[] listItemQuestion;
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
            listItemQuestion = new ListItemExamQuestion[global.countExamQuestions];
            GetExamQuestions();
        }
        #region get questions and create card
        private void GetCountOfExamQuestions()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_CountExamQuestion", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Ex_ID", SqlDbType.Int).Value = 1022;//global.ExamID;
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
            //ListItemExamQuestion[] listItem = new ListItemExamQuestion[global.countExamQuestions];
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_GetExamQuestions", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Ex_ID", SqlDbType.Int).Value = 1022;//global.ExamID;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    int i = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        listItemQuestion[i] = new ListItemExamQuestion();
                        listItemQuestion[i].QNum = i+1;
                        listItemQuestion[i].Question = row["Quest"].ToString();
                        listItemQuestion[i].QID = (int)row["Q_ID"];
                        global.QID = (int)row["Q_ID"]; //get Question ID from above dr at SP_GetExamQuestions for each row
                        SqlCommand cmd2 = new SqlCommand("SP_GetQuestionChoices", con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@Q_ID", SqlDbType.Int).Value = listItemQuestion[i].QID;
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        DataTable dt2 = new DataTable();
                        dt2.Load(dr2);
                        string[] arr = new string[5];
                        int[] arr2 = new int[5];
                        int j = 0;
                        foreach (DataRow item in dt2.Rows)
                        {
                            arr[j] = item["Choice"].ToString();
                            arr2[j] = (int)item["Ch_ID"];
                            j++;
                        }
                        listItemQuestion[i].Answer1 = arr[0];
                        listItemQuestion[i].Answer2 = arr[1];
                        listItemQuestion[i].Answer3 = arr[2];
                        listItemQuestion[i].Answer4 = arr[3];

                        listItemQuestion[i].Answer1ID = arr2[0];
                        listItemQuestion[i].Answer2ID = arr2[1];
                        listItemQuestion[i].Answer3ID = arr2[2];
                        listItemQuestion[i].Answer4ID = arr2[3];
                        flowLayoutPanelExamQuestion.Controls.Add(listItemQuestion[i]);
                        i++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        #endregion


        #region set aswers to DB
        //private void dataTableParameterForSP(int ans)
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("St_ID");
        //    dt.Columns.Add("Ex_ID");
        //    dt.Columns.Add("Q_ID");
        //    dt.Columns.Add("Ins_ID");
        //    dt.Columns.Add("Answer");
        //    DataRow row;
        //    int numberOfRows = global.countExamQuestions;
        //    for (int i = 0; i < numberOfRows; i++)
        //    {
        //        row = dt.NewRow();
        //        row["St_ID"] = global.StudentID;
        //        row["Ex_ID"] = global.ExamID;
        //        row["Q_ID"] = global.QID;
        //        row["Ins_ID"] = global.InsID;
        //        row["Answer"] = ans;
        //    }
        //}
        #endregion


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

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("St_ID");
            dt.Columns.Add("Ex_ID");
            dt.Columns.Add("Q_ID");
            dt.Columns.Add("Ins_ID");
            dt.Columns.Add("Answer");
            DataRow row;
            int numberOfRows = global.countExamQuestions;
            for (int i = 0; i < listItemQuestion.Length; i++)
            {
                row = dt.NewRow();
                row["St_ID"] = 10;// global.StudentID;
                row["Ex_ID"] = 1022;// global.ExamID;
                row["Q_ID"] = listItemQuestion[i].QID;
                //MessageBox.Show(listItemQuestion[i].QID.ToString());
                row["Ins_ID"] = 28;// global.InsID;
                row["Answer"] = listItemQuestion[i].StAnswerID;
                //MessageBox.Show(listItemQuestion[i].StAnswerID.ToString());
            }
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_StudentAnswerLoad", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@St_ID", 10);// global.StudentID);
                    //cmd.Parameters.AddWithValue("@ex_id", 14);// global.ExamID);
                    //cmd.Parameters.AddWithValue("@St_Ans", dt);
                    cmd.Parameters.Add("@St_ID",SqlDbType.Int ).Value= 10;// global.StudentID);
                    MessageBox.Show("3zma");
                    cmd.Parameters.Add("@ex_id", SqlDbType.Int).Value = 1022;// global.ExamID);
                    cmd.Parameters.Add("@St_Ans", SqlDbType.Structured).Value = dt;
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("SP_ExamCorrection", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    //MessageBox.Show(global.ExamID.ToString());
                    cmd.Parameters.Add("@Ex_ID", SqlDbType.Int).Value = 1022; //global.ExamID;
                    cmd.Parameters.Add("@St_ID", SqlDbType.Int).Value = 1;// global.StudentID;
                    //cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
