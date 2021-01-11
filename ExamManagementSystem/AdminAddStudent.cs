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
    
    public partial class AdminAddStudent : Form
    {
        
        public AdminAddStudent()
        {
            InitializeComponent();
        }

        string Gendervalue = "";

        private void AdminAddStudent_Load(object sender, EventArgs e)
        {
            StudentRecord();
        }
        private void StudentRecord()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Student", con);
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

                    SqlCommand cmd = new SqlCommand("SP_Student_Insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@st_fname", textBoxFname.Text);
                    cmd.Parameters.AddWithValue("@st_lname", textBoxLname.Text);
                    cmd.Parameters.AddWithValue("@gender", Gendervalue);
                    cmd.Parameters.AddWithValue("@st_ssn", int.Parse(textBoxSSN.Text));
                    cmd.Parameters.AddWithValue("@bdate", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxemail.Text);
                    cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Student is added Successfully ","Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please! Fill all the empty fields or Contact your adminstrator", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.ToString());
                }
            }
        }

        private void radioFemaleButton_click(object sender, MouseEventArgs e)
        {
            Gendervalue = "f";
            
        }

        private void radioButtonMale_Click(object sender, MouseEventArgs e)
        {
            Gendervalue = "m";
            
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            AdminWindow aw = new AdminWindow();
            aw.Show();
            this.Hide();
        }
    }
}
