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
    public partial class AddRemoveInstructor : Form
    {
        public AddRemoveInstructor()
        {
            InitializeComponent();
        }

        #region Fill combobox with all courses
        private void FillCombo()
        {
            comboBox1.Items.Clear();
            //load all IDs 
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("select ins_ID from Instructor", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr["ins_ID"]);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        #endregion

        private void AddRemoveInstructor_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        #region Deleting an Instructor
        private void buttonRemoveID_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_Instructor_Delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ins_ID", SqlDbType.Int).Value = int.Parse(comboBox1.Text);

                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Deleted Succesfuly");
                    }
                    comboBox1.Text = string.Empty;
                    textBox_Phone.Text = string.Empty;
                    textBox_Address.Text = string.Empty;
                    textBox_email.Text = string.Empty;
                    textBox4_DeptID.Text = string.Empty;

                    FillCombo();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

        }

        #endregion

        #region filling textboxes with Instructor Details
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_Instructor_Details", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ins_ID", SqlDbType.Int).Value = int.Parse(comboBox1.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    textBox_Phone.Text = dr["Phone"].ToString();
                    textBox_Address.Text = dr["Address"].ToString();
                    textBox_email.Text = dr["Email"].ToString();
                    textBox4_DeptID.Text = dr["Dept_ID"].ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

        }
        #endregion

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_Instructor_Update", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@ins_ID", SqlDbType.Int).Value = int.Parse(comboBox1.Text);
                    cmd.Parameters.AddWithValue("@ins_ID", int.Parse(comboBox1.Text));
                    cmd.Parameters.AddWithValue("@phone", textBox_Phone.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox_Address.Text);
                    cmd.Parameters.AddWithValue("@email", textBox_email.Text);
                    cmd.Parameters.AddWithValue("@dept_id", int.Parse(textBox4_DeptID.Text));
                   
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Instructor Info is Updated Successfully");
                
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}

    

