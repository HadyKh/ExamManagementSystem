using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamManagementSystem
{
    public partial class ListItemExamQuestion : UserControl
    {

        #region fields
        private int _qNum;
        private string _question;
        private string _answer1;
        private string _answer2;
        private string _answer3;
        private string _answer4;
        private int _answer1ID;
        private int _answer2ID;
        private int _answer3ID;
        private int _answer4ID;
        private int _stAnswerID;
        private int _qID;

        public int QID
        {
            get { return _qID; }
            set { _qID = value; }
        }

        public int StAnswerID
        {
            get { return _stAnswerID; }
        }

        public int Answer1ID
        {
            get { return _answer1ID; }
            set
            {
                _answer1ID = value;
            }
        }
        public int Answer2ID
        {
            get { return _answer2ID; }
            set
            {
                _answer2ID = value;
            }
        }

        public int Answer3ID
        {
            get { return _answer3ID; }
            set
            {
                _answer3ID = value;
            }
        }

        public int Answer4ID
        {
            get { return _answer4ID; }
            set
            {
                _answer4ID = value;
            }
        }
        public int QNum
        {
            get { return _qNum; }
            set 
            {
                _qNum = value;
                lblQNumber.Text = value.ToString();
            }
        }

        public string Question
        {
            get { return _question; }
            set 
            {
                _question = value;
                lblQuestion.Text = value;
            }
        }

        public string Answer1
        {
            get { return _answer1; }
            set 
            {
                _answer1 = value;
                radioBtnAns1.Text = value;
            }
        }

        public string Answer2
        {
            get { return _answer2; }
            set
            {
                _answer2 = value;
                radioBtnAns2.Text = value;
            }
        }

        public string Answer3
        {
            get { return _answer3; }
            set
            { 
                _answer3 = value;
                radioBtnAns3.Text = value;
            }
        }

        public string Answer4
        {
            get { return _answer4; }
            set 
            {
                _answer4 = value;
                radioBtnAns4.Text = value;
            }
        }
        #endregion

        public ListItemExamQuestion()
        {
            InitializeComponent();
        }

        private void lblQNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void radioBtnAns1_Click(object sender, EventArgs e)
        {
            _stAnswerID = _answer1ID;
        }

        private void radioBtnAns2_Click(object sender, EventArgs e)
        {
            _stAnswerID = _answer2ID;
        }

        private void radioBtnAns3_Click(object sender, EventArgs e)
        {
            _stAnswerID = _answer3ID;
        }

        private void radioBtnAns4_Click(object sender, EventArgs e)
        {
            _stAnswerID = _answer4ID;
        }


        #region not needed
        private void radioBtnAns1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnAns2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnAns3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnAns4_CheckedChanged(object sender, EventArgs e)
        {

        }


        #endregion
        private void ListItemExamQuestion_Load(object sender, EventArgs e)
        {
            if (_answer1 == "FALSE" && _answer2 == "TRUE" || _answer1 == "TRUE" && _answer2 == "FALSE")
            {
                radioBtnAns3.Hide();
                radioBtnAns4.Hide();
            }
        }

    }
}
