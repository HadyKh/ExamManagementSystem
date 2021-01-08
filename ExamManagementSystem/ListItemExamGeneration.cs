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
using System.Windows.Forms;

namespace ExamManagementSystem
{
    public partial class ListItemExamGeneration : UserControl
    {
        int y;
        public ListItemExamGeneration()
        {
            InitializeComponent();
        }

        private int x = 10, mcq, tf;
        #region Property
        private string _CourseName;
        private string _TopicName;
        private int _MCQ;
        private int _TF;
        private string _Trial;

        public string CourseName
        {
            get { return _CourseName; }
            set { _CourseName = value; }
        }

        public string TopicName
        {
            get { return _TopicName; }
            set { _TopicName = value; }
        }

        public int MCQ
        {
            get { return _MCQ; }
            set { _MCQ = value; }
        }

        public int TF
        {
            get { return _TF; }
            set { _TF = value; }
        }

        public string Trial
        {
            get { return _Trial; }
            set { _Trial = value; }
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxChoicesPopulate() 
        {
            //MCQ comboBox
            cmbBxMCQ.Items.Add(1);
            cmbBxMCQ.Items.Add(2);
            cmbBxMCQ.Items.Add(3);
            cmbBxMCQ.Items.Add(4);
            cmbBxMCQ.Items.Add(5);
            cmbBxMCQ.Items.Add(6);

            //TF comboBox
            cmbBxTF.Items.Add(1);
            cmbBxTF.Items.Add(2);
            cmbBxTF.Items.Add(3);
            cmbBxTF.Items.Add(4);
            cmbBxTF.Items.Add(5);
            cmbBxTF.Items.Add(6);

            //trial comboBox
            cmbBxTrial.Items.Add("First Chance");
            cmbBxTrial.Items.Add("Second Chance");
            cmbBxTrial.Items.Add("Third Chance");
            //duration comboBox
            cmbBxDuration.Items.Add("60");
            cmbBxDuration.Items.Add("120");
            cmbBxDuration.Items.Add("180");

        }

        private void FillCombo()
        {
            //load all IDs 
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd2 = new SqlCommand("select crs_name from courses", con);
                    SqlDataReader dr2 = cmd2.ExecuteReader();

                    while (dr2.Read())
                    {
                        cmBxCrsName.Items.Add(dr2["Crs_name"]);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                
            }
        }

        private void FillCombo2()
        {
            
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Tp_name from Topic t,courses c where t.crs_ID = c.crs_ID and c.crs_Name = '" + cmBxCrsName.Text + " '", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cmbBxTpName.Items.Add(dr["Tp_name"]);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void comboBoxMCQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            mcq = int.Parse(cmbBxMCQ.Text);
            int diff = x - mcq;
            cmbBxTF.Text = diff.ToString();
            if (mcq + tf == 10)
                buttonGenerate.Enabled = true;
            else
                buttonGenerate.Enabled = false;
        }

        private void comboBoxTF_SelectedIndexChanged(object sender, EventArgs e)
        {
            tf = int.Parse(cmbBxTF.Text);
            int diff = x - tf;
            cmbBxMCQ.Text = diff.ToString();
            if (mcq + tf == 10)
                buttonGenerate.Enabled = true;
            else
               buttonGenerate.Enabled = false;
        }

        private void comboBoxTrial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mcq + tf == 10)
                buttonGenerate.Enabled = true;
            else
                buttonGenerate.Enabled = false;
        }

        private void ListItemExamGeneration_Load(object sender, EventArgs e)
        {
            //generate crs name topic name combobx
            FillCombo();
            buttonGenerate.Enabled = false;
            comboBoxChoicesPopulate();
        }

        private void comboBoxDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmBxCrsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBxTpName.Items.Clear();
            cmbBxTpName.Text = "";
            FillCombo2();

            
        }

        private void cmbBxTpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd23 = new SqlCommand("select Tp_ID from Topic where Tp_name = '" + cmbBxTpName.Text + "'", con);
                    SqlDataReader dr2 = cmd23.ExecuteReader();
                    dr2.Read();
                    y = (int)dr2["Tp_ID"];
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    //generate exam 
                    SqlCommand cmd = new SqlCommand("SP_ExamGeneration", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Ex_Type",SqlDbType.VarChar,20 ).Value = cmbBxTrial.Text;
                    cmd.Parameters.Add("@Duration", SqlDbType.BigInt).Value = int.Parse(cmbBxDuration.Text);
                    cmd.Parameters.Add("@Tp_ID", SqlDbType.BigInt).Value = y;
                    cmd.Parameters.Add("@Ex_Datetime", SqlDbType.Date).Value = dateTimePicker.Value.ToShortDateString();
                    cmd.Parameters.Add("@MCQ_No", SqlDbType.BigInt).Value = int.Parse(cmbBxMCQ.Text);
                    cmd.Parameters.Add("@TF_No", SqlDbType.BigInt).Value = int.Parse(cmbBxTF.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(dateTimePicker.Value.ToShortDateString().ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (cmBxCrsName.Text != "" && cmbBxTpName.Text != "")
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
                {
                    try
                    {
                        con.Open();
                        //crs check
                        SqlCommand cmd = new SqlCommand("SP_CrsCheck", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@CRS_Name", SqlDbType.NVarChar, 20).Value =cmBxCrsName.Text;
                        //topic check
                        SqlCommand cmd2 = new SqlCommand("SP_TopicCheck", con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@Tp_Name", SqlDbType.NVarChar, 255).Value = cmbBxTpName.Text;
                        //questions check
                        
                        SqlCommand cmd3 = new SqlCommand("SP_QuestionsCheck", con);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.Add("@Tp_ID", SqlDbType.NVarChar, 255).Value = y;
                        //results
                        int resultCRS = (int)cmd.ExecuteScalar();
                        int resultTP = (int)cmd2.ExecuteScalar();
                        int resultQues = (int)cmd3.ExecuteScalar();
                       
                        if(resultCRS > 0 && resultTP > 0)
                        {
                            MessageBox.Show("Course and Topic are already exist. you can generate exam", "Existence check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Course and Topic are not exist. Please! visit the admin to add them", "Existence check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                        if (resultQues == 0)
                        {
                            MessageBox.Show("This topic has no questions, Please! insert some questions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
                MessageBox.Show("Please Enter course name and topic name to be checked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //courseName = txtBxCrsName.Text;
            //topicName = txtBxTopicName.Text;
        }
    }
}
