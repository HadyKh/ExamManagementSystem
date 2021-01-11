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
    public partial class SigninAsInstructorMsgBox : Form
    {
        public SigninAsInstructorMsgBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    //login
                    SqlCommand cmd = new SqlCommand("SP_InstructorLogin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = txt_email.Text;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txt_password.Text;
                    int result = (int)cmd.ExecuteScalar();

                    //get Ins ID
                    SqlCommand cmd2 = new SqlCommand("SP_InstructorLoginGetID", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = txt_email.Text;
                    cmd2.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txt_password.Text;
                    global.InsID = (int)cmd2.ExecuteScalar();

                    //MessageBox.Show("Ins id is " + global.InsID);

                    if (result > 0)
                    {
                        InstructorWindow iw = new InstructorWindow();
                        iw.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email or password not valid!!", "Invalid Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_email.Text = string.Empty;
                        txt_password.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please! Contact your adminstrator", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnlogin_as_Click(object sender, EventArgs e)
        {
            SigninWindow signin = new SigninWindow();
            signin.Show();
            this.Hide();
        }
    }
}
