﻿using System;
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
    public partial class ListItemAvailableExam : UserControl
    {
        public ListItemAvailableExam()
        {
            InitializeComponent();
        }

        private void buttonStartExam_Click(object sender, EventArgs e)
        {
            var m = new StartExamBtnMsgBox();
            m.Show();
        }
    }
}
