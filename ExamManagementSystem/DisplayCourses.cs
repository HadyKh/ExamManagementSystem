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
    public partial class DisplayCourses : Form
    {
        public DisplayCourses()
        {
            InitializeComponent();
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(" select c.crs_id, crs_name,crs_duration, mgr_ID, tp_name from courses c,topic t where c.crs_id=t.crs_id order by c.crs_id", con);
                    DataTable dtb1 = new DataTable();
                    sqlDa.Fill(dtb1);

                    dataGridView1.DataSource = dtb1;

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
