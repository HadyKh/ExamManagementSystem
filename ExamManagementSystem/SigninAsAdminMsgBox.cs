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
using System.Configuration;

namespace ExamManagementSystem
{
    public partial class SigninAsAdminMsgBox : Form
    {
        public SigninAsAdminMsgBox()
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

        private void SignIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_AdminLogin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = txt_username.Text;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txt_password.Text;
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        AdminWindow aw = new AdminWindow();
                        aw.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("user or pass not valid!!", "Invalid Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Text = string.Empty;
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
