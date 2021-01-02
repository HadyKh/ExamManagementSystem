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
            this.lblExamType = new System.Windows.Forms.Label();
            this.lblTopicName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblGradeFixed = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExamType
            // 
            this.lblExamType.AutoSize = true;
            this.lblExamType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblExamType.Location = new System.Drawing.Point(49, 81);
            this.lblExamType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExamType.Name = "lblExamType";
            this.lblExamType.Size = new System.Drawing.Size(83, 19);
            this.lblExamType.TabIndex = 4;
            this.lblExamType.Text = "ExamType";
            // 
            // lblTopicName
            // 
            this.lblTopicName.AutoSize = true;
            this.lblTopicName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTopicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblTopicName.Location = new System.Drawing.Point(49, 53);
            this.lblTopicName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopicName.Name = "lblTopicName";
            this.lblTopicName.Size = new System.Drawing.Size(100, 19);
            this.lblTopicName.TabIndex = 3;
            this.lblTopicName.Text = "TopicName";
            this.lblTopicName.Click += new System.EventHandler(this.lblTopicName_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblCourseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblCourseName.Location = new System.Drawing.Point(48, 15);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(153, 27);
            this.lblCourseName.TabIndex = 6;
            this.lblCourseName.Text = "CourseName";
            // 
            // lblGradeFixed
            // 
            this.lblGradeFixed.AutoSize = true;
            this.lblGradeFixed.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblGradeFixed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblGradeFixed.Location = new System.Drawing.Point(300, 42);
            this.lblGradeFixed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradeFixed.Name = "lblGradeFixed";
            this.lblGradeFixed.Size = new System.Drawing.Size(114, 33);
            this.lblGradeFixed.TabIndex = 7;
            this.lblGradeFixed.Text = "Grade: ";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblGrade.Location = new System.Drawing.Point(407, 42);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(96, 33);
            this.lblGrade.TabIndex = 8;
            this.lblGrade.Text = "Grade";
            this.lblGrade.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.BackColor = System.Drawing.Color.Green;
            this.buttonDetail.FlatAppearance.BorderSize = 0;
            this.buttonDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetail.ForeColor = System.Drawing.Color.White;
            this.buttonDetail.Location = new System.Drawing.Point(616, 27);
            this.buttonDetail.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(98, 68);
            this.buttonDetail.TabIndex = 9;
            this.buttonDetail.Text = "Details";
            this.buttonDetail.UseVisualStyleBackColor = false;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // ListItemStudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblGradeFixed);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblExamType);
            this.Controls.Add(this.lblTopicName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "ListItemStudentGrade";
            this.Size = new System.Drawing.Size(803, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblExamType;
        private System.Windows.Forms.Label lblTopicName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblGradeFixed;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button buttonDetail;
    }
}
