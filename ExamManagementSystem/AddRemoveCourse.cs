﻿using System;
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
    public partial class AddRemoveCourse : Form
    {
        public AddRemoveCourse()
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

                    SqlCommand cmd = new SqlCommand("select c.Crs_Name from Courses c", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr["Crs_Name"]);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please! Contact your adminstrator", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.ToString());
                }
            }
        }

        #endregion

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AddRemoveCourse_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void buttonRemoveID_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    //string[] s = comboBox1.Text.Split();
                    SqlCommand cmd1 = new SqlCommand("select c.Crs_ID from Courses c where Crs_Name ='"+ comboBox1.Text+"'", con);
                    int st_ID = (int)cmd1.ExecuteScalar();



                    SqlCommand cmd = new SqlCommand("SP_Course_Delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Crs_ID", SqlDbType.Int).Value = st_ID;// int.Parse(comboBox1.Text);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Deleted Succesfuly");
                    }
                    comboBox1.Text = string.Empty;
                    txt_CourseName.Text = string.Empty;
                    txt_Mgr_ID.Text = string.Empty;
                    txt_Duration.Text = string.Empty;
                    FillCombo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please! Contact your adminstrator", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.ToString());
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select c.Crs_ID from Courses c where Crs_Name ='" + comboBox1.Text + "'", con);
                    int st_ID = (int)cmd1.ExecuteScalar();

                    SqlCommand cmd = new SqlCommand("SP_Course_Details", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Crs_ID", SqlDbType.Int).Value = st_ID;// int.Parse(comboBox1.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    txt_CourseName.Text = dr["Crs_Name"].ToString();
                    txt_Mgr_ID.Text = dr["Mgr_ID"].ToString();
                    txt_Duration.Text = dr["Crs_Duration"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please! Contact your adminstrator", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.ToString());
                }
            }

        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            this.Close();
            var m = new AdminWindow();
            m.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select c.Crs_ID from Courses c where Crs_Name ='" + comboBox1.Text + "'", con);
                    int st_ID = (int)cmd1.ExecuteScalar();

                    SqlCommand cmd = new SqlCommand("SP_Courses_Update", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@crs_ID", SqlDbType.Int).Value = st_ID;// int.Parse(comboBox1.Text);
                    cmd.Parameters.AddWithValue("@crs_name", txt_CourseName.Text);
                    cmd.Parameters.AddWithValue("@crs_duration",int.Parse(txt_Duration.Text));
                    cmd.Parameters.AddWithValue("@Mgr_ID", int.Parse(txt_Mgr_ID.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course is Updated Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please! Contact your adminstrator", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.ToString());
                }
            }
        }
    }
    
}
