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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "-";
            // 
            // radioBtnAns4
            // 
            this.radioBtnAns4.AutoSize = true;
            this.radioBtnAns4.Location = new System.Drawing.Point(514, 122);
            this.radioBtnAns4.Name = "radioBtnAns4";
            this.radioBtnAns4.Size = new System.Drawing.Size(83, 21);
            this.radioBtnAns4.TabIndex = 6;
            this.radioBtnAns4.TabStop = true;
            this.radioBtnAns4.Text = "Answer4";
            this.radioBtnAns4.UseVisualStyleBackColor = true;
            this.radioBtnAns4.CheckedChanged += new System.EventHandler(this.radioBtnAns4_CheckedChanged);
            // 
            // radioBtnAns3
            // 
            this.radioBtnAns3.AutoSize = true;
            this.radioBtnAns3.Location = new System.Drawing.Point(109, 122);
            this.radioBtnAns3.Name = "radioBtnAns3";
            this.radioBtnAns3.Size = new System.Drawing.Size(83, 21);
            this.radioBtnAns3.TabIndex = 7;
            this.radioBtnAns3.TabStop = true;
            this.radioBtnAns3.Text = "Answer3";
            this.radioBtnAns3.UseVisualStyleBackColor = true;
            this.radioBtnAns3.CheckedChanged += new System.EventHandler(this.radioBtnAns3_CheckedChanged);
            // 
            // radioBtnAns2
            // 
            this.radioBtnAns2.AutoSize = true;
            this.radioBtnAns2.Location = new System.Drawing.Point(514, 71);
            this.radioBtnAns2.Name = "radioBtnAns2";
            this.radioBtnAns2.Size = new System.Drawing.Size(83, 21);
            this.radioBtnAns2.TabIndex = 8;
            this.radioBtnAns2.TabStop = true;
            this.radioBtnAns2.Text = "Answer2";
            this.radioBtnAns2.UseVisualStyleBackColor = true;
            this.radioBtnAns2.CheckedChanged += new System.EventHandler(this.radioBtnAns2_CheckedChanged);
            // 
            // radioBtnAns1
            // 
            this.radioBtnAns1.AutoSize = true;
            this.radioBtnAns1.Location = new System.Drawing.Point(109, 71);
            this.radioBtnAns1.Name = "radioBtnAns1";
            this.radioBtnAns1.Size = new System.Drawing.Size(83, 21);
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
            this.lblQuestion.Location = new System.Drawing.Point(105, 30);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(364, 20);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "The question to be answered will be here?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // lblQNumber
            // 
            this.lblQNumber.AutoSize = true;
            this.lblQNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQNumber.Location = new System.Drawing.Point(28, 30);
            this.lblQNumber.Name = "lblQNumber";
            this.lblQNumber.Size = new System.Drawing.Size(60, 20);
            this.lblQNumber.TabIndex = 4;
            this.lblQNumber.Text = "QNUM";
            this.lblQNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQNumber.Click += new System.EventHandler(this.lblQNumber_Click);
            // 
            // ListItemExamQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnAns4);
            this.Controls.Add(this.radioBtnAns3);
            this.Controls.Add(this.radioBtnAns2);
            this.Controls.Add(this.radioBtnAns1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQNumber);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "ListItemExamQuestion";
            this.Size = new System.Drawing.Size(1100, 185);
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
    }
}
