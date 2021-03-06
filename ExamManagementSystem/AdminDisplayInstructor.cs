﻿using System;
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
    public partial class AdminDisplayInstructor : Form
    {
        public AdminDisplayInstructor()
        {
            InitializeComponent();
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            AdminWindow aw = new AdminWindow();
            aw.Show();
            this.Hide();
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("select ins_id, ssn, ins_fname, ins_lname, gender, bd_date, phone, email from instructor", con);
                    DataTable dtb1 = new DataTable();
                    sqlDa.Fill(dtb1);

                    dataGridView1.DataSource = dtb1;

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
