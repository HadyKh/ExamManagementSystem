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
    }
}
