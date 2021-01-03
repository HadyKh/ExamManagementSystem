using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        #region PropertiesGradeListItems

        private string _CourseName;
        private string _TopicName;
        private string _ExamType;
        private decimal _Grade;
        public string CourseName
        {
            get { return _CourseName; }
            set { _CourseName = value; lblCourseName.Text = value; }
        }

        public string TopicName
        {
            get { return _TopicName; }
            set { _TopicName = value; lblTopicName.Text = value; }
        }

        public string ExamType
        {
            get { return _ExamType; }
            set { _ExamType = value; lblExamType.Text = value; }
        }


        public decimal Grade
        {
            get { return _Grade; }
            set { _Grade = value; lblGrade.Text = value.ToString(); }
        }

        #endregion

        private void lblTopicName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {

        }

        private void ListItemStudentGrade_Load(object sender, EventArgs e)
        {

        }
    }
}
