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
    public partial class ListItemExamGeneration : UserControl
    {
        public ListItemExamGeneration()
        {
            InitializeComponent();
        }

        #region Property
        private string _CourseName;
        private string _TopicName;
        private int _MCQ;
        private int _TF;
        private string _Trial;

        public string CourseName
        {
            get { return _CourseName; }
            set { _CourseName = value; }
        }

        public string TopicName
        {
            get { return _TopicName; }
            set { _TopicName = value; }
        }

        public int MCQ
        {
            get { return _MCQ; }
            set { _MCQ = value; }
        }

        public int TF
        {
            get { return _TF; }
            set { _TF = value; }
        }

        public string Trial
        {
            get { return _Trial; }
            set { _Trial = value; }
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMCQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMCQ.Items.Add(1);
            comboBoxMCQ.Items.Add(2);
            comboBoxMCQ.Items.Add(3);
            comboBoxMCQ.Items.Add(4);
            comboBoxMCQ.Items.Add(5);
            comboBoxMCQ.Items.Add(6);
        }

        private void comboBoxTF_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTF.Items.Add(1);
            comboBoxTF.Items.Add(2);
            comboBoxTF.Items.Add(3);
            comboBoxTF.Items.Add(4);
            comboBoxTF.Items.Add(5);
            comboBoxTF.Items.Add(6);
        }

        private void comboBoxTrial_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTrial.Items.Add("First Chance");
            comboBoxTrial.Items.Add("Second Chance");
            comboBoxTrial.Items.Add("Last Chance");
        }

        private void ListItemExamGeneration_Load(object sender, EventArgs e) { }
    }
}
