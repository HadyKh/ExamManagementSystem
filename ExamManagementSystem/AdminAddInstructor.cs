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
    public partial class AdminAddInstructor : Form
    {
        public AdminAddInstructor()
        {
            InitializeComponent();
        }

        string Gendervalue = "";
        private void AdminAddInstructor_Load(object sender, EventArgs e)
        {
            InstructorRecord();
        }
        private void InstructorRecord()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("select * from Instructor", con);


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
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

                    SqlCommand cmd = new SqlCommand("SP_Instructor_Insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ssn", int.Parse(textBoxSSN.Text));
                    cmd.Parameters.AddWithValue("@ins_fname", textBoxFname.Text);
                    cmd.Parameters.AddWithValue("@ins_lname", textBoxLname.Text);
                    cmd.Parameters.AddWithValue("@gender", Gendervalue);
                    cmd.Parameters.AddWithValue("@bdate", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxemail.Text);
                    cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Instructor is added Successfully ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

 

        private void radioButton1_Click(object sender, EventArgs e)
        {
            Gendervalue = "m";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            Gendervalue = "f";
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            AdminWindow aw = new AdminWindow();
            aw.Show();
            this.Hide();
        }
    }
    
}
