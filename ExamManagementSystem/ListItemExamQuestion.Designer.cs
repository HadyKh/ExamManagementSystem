namespace ExamManagementSystem
{
    partial class ListItemExamQuestion
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtnAns4 = new System.Windows.Forms.RadioButton();
            this.radioBtnAns3 = new System.Windows.Forms.RadioButton();
            this.radioBtnAns2 = new System.Windows.Forms.RadioButton();
            this.radioBtnAns1 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "-";
            // 
            // radioBtnAns4
            // 
            this.radioBtnAns4.AutoSize = true;
            this.radioBtnAns4.Location = new System.Drawing.Point(658, 127);
            this.radioBtnAns4.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnAns4.Name = "radioBtnAns4";
            this.radioBtnAns4.Size = new System.Drawing.Size(95, 25);
            this.radioBtnAns4.TabIndex = 6;
            this.radioBtnAns4.TabStop = true;
            this.radioBtnAns4.Text = "Answer4";
            this.radioBtnAns4.UseVisualStyleBackColor = true;
            this.radioBtnAns4.CheckedChanged += new System.EventHandler(this.radioBtnAns4_CheckedChanged);
            // 
            // radioBtnAns3
            // 
            this.radioBtnAns3.AutoSize = true;
            this.radioBtnAns3.Location = new System.Drawing.Point(239, 127);
            this.radioBtnAns3.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnAns3.Name = "radioBtnAns3";
            this.radioBtnAns3.Size = new System.Drawing.Size(95, 25);
            this.radioBtnAns3.TabIndex = 7;
            this.radioBtnAns3.TabStop = true;
            this.radioBtnAns3.Text = "Answer3";
            this.radioBtnAns3.UseVisualStyleBackColor = true;
            this.radioBtnAns3.CheckedChanged += new System.EventHandler(this.radioBtnAns3_CheckedChanged);
            // 
            // radioBtnAns2
            // 
            this.radioBtnAns2.AutoSize = true;
            this.radioBtnAns2.Location = new System.Drawing.Point(658, 78);
            this.radioBtnAns2.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnAns2.Name = "radioBtnAns2";
            this.radioBtnAns2.Size = new System.Drawing.Size(95, 25);
            this.radioBtnAns2.TabIndex = 8;
            this.radioBtnAns2.TabStop = true;
            this.radioBtnAns2.Text = "Answer2";
            this.radioBtnAns2.UseVisualStyleBackColor = true;
            this.radioBtnAns2.CheckedChanged += new System.EventHandler(this.radioBtnAns2_CheckedChanged);
            // 
            // radioBtnAns1
            // 
            this.radioBtnAns1.AutoSize = true;
            this.radioBtnAns1.Location = new System.Drawing.Point(239, 78);
            this.radioBtnAns1.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnAns1.Name = "radioBtnAns1";
            this.radioBtnAns1.Size = new System.Drawing.Size(95, 25);
            this.radioBtnAns1.TabIndex = 9;
            this.radioBtnAns1.TabStop = true;
            this.radioBtnAns1.Text = "Answer1";
            this.radioBtnAns1.UseVisualStyleBackColor = true;
            this.radioBtnAns1.CheckedChanged += new System.EventHandler(this.radioBtnAns1_CheckedChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(132, 19);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(316, 17);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "The question to be answered will be here?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // lblQNumber
            // 
            this.lblQNumber.AutoSize = true;
            this.lblQNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQNumber.Location = new System.Drawing.Point(39, 19);
            this.lblQNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQNumber.Name = "lblQNumber";
            this.lblQNumber.Size = new System.Drawing.Size(50, 17);
            this.lblQNumber.TabIndex = 4;
            this.lblQNumber.Text = "QNUM";
            this.lblQNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQNumber.Click += new System.EventHandler(this.lblQNumber_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 1);
            this.panel1.TabIndex = 11;
            // 
            // ListItemExamQuestion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnAns4);
            this.Controls.Add(this.radioBtnAns3);
            this.Controls.Add(this.radioBtnAns2);
            this.Controls.Add(this.radioBtnAns1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQNumber);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListItemExamQuestion";
            this.Size = new System.Drawing.Size(1070, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtnAns4;
        private System.Windows.Forms.RadioButton radioBtnAns3;
        private System.Windows.Forms.RadioButton radioBtnAns2;
        private System.Windows.Forms.RadioButton radioBtnAns1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQNumber;
        private System.Windows.Forms.Panel panel1;
    }
}
