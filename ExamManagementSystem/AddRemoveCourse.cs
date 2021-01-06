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
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-HI3M44K\\DEVSQL;Initial Catalog=ExamManagementSystem;Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("select Crs_ID from Courses", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr["Crs_ID"]);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        #endregion
        private void AddRemoveCourse_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonRemoveID_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_Course_Delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Crs_ID", SqlDbType.Int).Value = int.Parse(comboBox1.Text);

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

                    MessageBox.Show(ex.ToString());
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

                    SqlCommand cmd = new SqlCommand("SP_Course_Details", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Crs_ID", SqlDbType.Int).Value = int.Parse(comboBox1.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    txt_CourseName.Text = dr["Crs_Name"].ToString();
                    txt_Mgr_ID.Text = dr["Mgr_ID"].ToString();
                    txt_Duration.Text = dr["Crs_Duration"].ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
