using System;
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
    public partial class ListItemStudentGrade : UserControl
    {
        public ListItemStudentGrade()
        {
            InitializeComponent();
        }

        private DataTable gridVD;

        public DataTable GridSetGet
        {
            get { return gridVD; }
            set
            {
                gridVD = value;
                dataGridView1.DataSource = value;
            }
        }

        private void ListItemStudentGrade_Load(object sender, EventArgs e)
        {

        }

        private void ListItemStudentGrade_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void ListItemStudentGrade_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnTpScore_Click(object sender, EventArgs e)
        {
            //database Connection
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_StudentScores", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@ST_ID", SqlDbType.Int).Value = global.StudentID;
                    cmd.Parameters.Add("@ST_ID", SqlDbType.Int).Value = 8;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dtbl = new DataTable();
                    dtbl.Load(dr);
                    GridSetGet = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnCrsGrade_Click(object sender, EventArgs e)
        {
            //database Connection
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_StudentGrade", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ST_ID", SqlDbType.Int).Value = 8;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dtbl = new DataTable();
                    dtbl.Load(dr);
                    GridSetGet = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
