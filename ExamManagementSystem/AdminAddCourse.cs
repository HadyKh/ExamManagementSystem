using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ExamManagementSystem
{
    public partial class AdminAddCourse : Form
    {
        public AdminAddCourse()
        {
            InitializeComponent();
        }

        private void AdminAddCourse_Load(object sender, EventArgs e)
        {
            CoursesRecord();
        }

        private void CoursesRecord()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Courses", con);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please! Contact your adminstrator", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.ToString());
                }
            }

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_Courses_Insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@crs_name", textBoxCrsName.Text );
                    cmd.Parameters.AddWithValue("@crs_duration",int.Parse(textBoxCrsDuration.Text));
                    cmd.Parameters.AddWithValue("@mgr_id", int.Parse(textBoxInsID.Text));
                    cmd.Parameters.AddWithValue("@tp_name", textBoxtpName.Text);
                    


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Course is added Successfully ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please! Fill the empty fields or Contact your adminstrator", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            AdminWindow aw = new AdminWindow();
            aw.Show();
            this.Hide();
        }
    }
}
