
namespace ExamManagementSystem
{
    partial class ListItemStudentGrade
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
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblExamType = new System.Windows.Forms.Label();
            this.lblTopicName = new System.Windows.Forms.Label();
            this.lblGradeFixed = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblCourseName.Location = new System.Drawing.Point(56, 20);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(153, 27);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "CourseName";
            // 
            // lblExamType
            // 
            this.lblExamType.AutoSize = true;
            this.lblExamType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblExamType.Location = new System.Drawing.Point(57, 85);
            this.lblExamType.Name = "lblExamType";
            this.lblExamType.Size = new System.Drawing.Size(83, 19);
            this.lblExamType.TabIndex = 1;
            this.lblExamType.Text = "ExamType";
            // 
            // lblTopicName
            // 
            this.lblTopicName.AutoSize = true;
            this.lblTopicName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTopicName.Location = new System.Drawing.Point(57, 57);
            this.lblTopicName.Name = "lblTopicName";
            this.lblTopicName.Size = new System.Drawing.Size(100, 19);
            this.lblTopicName.TabIndex = 2;
            this.lblTopicName.Text = "TopicName";
            // 
            // lblGradeFixed
            // 
            this.lblGradeFixed.AutoSize = true;
            this.lblGradeFixed.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblGradeFixed.Location = new System.Drawing.Point(417, 52);
            this.lblGradeFixed.Name = "lblGradeFixed";
            this.lblGradeFixed.Size = new System.Drawing.Size(92, 27);
            this.lblGradeFixed.TabIndex = 3;
            this.lblGradeFixed.Text = "Grade :";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblGrade.Location = new System.Drawing.Point(562, 52);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(78, 27);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "Grade";
            this.lblGrade.Click += new System.EventHandler(this.label2_Click);
            // 
            // ListItemStudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblGradeFixed);
            this.Controls.Add(this.lblTopicName);
            this.Controls.Add(this.lblExamType);
            this.Controls.Add(this.lblCourseName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "ListItemStudentGrade";
            this.Size = new System.Drawing.Size(1100, 136);
            this.Load += new System.EventHandler(this.ListItemStudentGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblExamType;
        private System.Windows.Forms.Label lblTopicName;
        private System.Windows.Forms.Label lblGradeFixed;
        private System.Windows.Forms.Label lblGrade;
    }
}
