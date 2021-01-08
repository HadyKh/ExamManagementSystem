using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ExamManagementSystem
{   
    public partial class SigninAsStudentMsgBox : Form
    {
        
        public SigninAsStudentMsgBox()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    //login proc
                    SqlCommand cmd = new SqlCommand("SP_StudentLogin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = txt_email.Text;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txt_password.Text;
                    int result = (int)cmd.ExecuteScalar();

                    //get id of the user signed in
                    SqlCommand cmd2 = new SqlCommand("SP_StudentLoginGetID", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = txt_email.Text;
                    cmd2.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txt_password.Text;
                    global.StudentID = (int)cmd2.ExecuteScalar();
                    //MessageBox.Show("student id is "+global.StudentID);


                    if (result > 0 )
                    {
                        Form1 StudentWindow = new Form1();
                        StudentWindow.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("user or pass not valid!!", "Invalid Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_email.Text = string.Empty;
                        txt_password.Text = string.Empty;
                    }                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void SigninAsStudentMsgBox_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_as_Click(object sender, EventArgs e)
        {
            SigninWindow signin = new SigninWindow();
            signin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
