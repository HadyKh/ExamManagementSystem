using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExamManagementSystem
{
    public partial class listItemAvailableExam : UserControl
    {
        public listItemAvailableExam()
        {
            InitializeComponent();
        }

        private string _topicName;
        private string _time;
        private string _examType;
        private string _crsName;
        private string _at;
        private int _Ex_ID;
        private int _insID;

        public int InsID
        {
            get { return _insID; }
            set { _insID = value; }
        }


        public int Ex_ID
        {
            get { return _Ex_ID; }
            set { _Ex_ID = value; }
        }

        public string TopicName
        {
            get { return _topicName; }
            set
            {
                _topicName = value;
                lblTopicName.Text = value;
            }
        }

        public string ExamType
        {
            get { return _examType; }
            set
            {
                _examType = value;
                lblExamType.Text = value;
            }
        }

        public string CrsName
        {
            get { return _crsName; }
            set
            {
                _crsName = value;
                lblCrsName.Text = value;
            }
        }

        public string At
        {
            get { return _at; }
            set
            {
                _at = value;
                lblAtTime.Text = value;
            }
        }

        public string Time
        {
            get { return _time; }
            set
            {
                _time = value;
                lblExamTime.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.ExamDuration = int.Parse(Time);
            global.ExamID = Ex_ID;
            global.InsID = _insID;
            var m = new StartExamBtnMsgBox();
            m.Show();
        }

        private void mouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(19, 13, 0, 64);
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(41, 44, 51);
        }
    }
}