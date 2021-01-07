using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ExamManagementSystem
{
    public partial class ListItemStudentFromInstrutor : UserControl
    {
        public ListItemStudentFromInstrutor()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
