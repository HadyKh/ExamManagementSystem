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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblExamType
            // 
            this.lblExamType.AutoEllipsis = true;
            this.lblExamType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblExamType.Location = new System.Drawing.Point(114, 115);
            this.lblExamType.Name = "lblExamType";
            this.lblExamType.Size = new System.Drawing.Size(138, 31);
            this.lblExamType.TabIndex = 4;
            this.lblExamType.Text = "ExamType";
            // 
            // lblTopicName
            // 
            this.lblTopicName.AutoEllipsis = true;
            this.lblTopicName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTopicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblTopicName.Location = new System.Drawing.Point(114, 73);
            this.lblTopicName.Name = "lblTopicName";
            this.lblTopicName.Size = new System.Drawing.Size(167, 31);
            this.lblTopicName.TabIndex = 3;
            this.lblTopicName.Text = "TopicName";
            this.lblTopicName.Click += new System.EventHandler(this.lblTopicName_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoEllipsis = true;
            this.lblCourseName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblCourseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblCourseName.Location = new System.Drawing.Point(112, 25);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(255, 44);
            this.lblCourseName.TabIndex = 6;
            this.lblCourseName.Text = "CourseName";
            // 
            // lblGradeFixed
            // 
            this.lblGradeFixed.AutoEllipsis = true;
            this.lblGradeFixed.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblGradeFixed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblGradeFixed.Location = new System.Drawing.Point(406, 78);
            this.lblGradeFixed.Name = "lblGradeFixed";
            this.lblGradeFixed.Size = new System.Drawing.Size(190, 53);
            this.lblGradeFixed.TabIndex = 7;
            this.lblGradeFixed.Text = "Grade: ";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoEllipsis = true;
            this.lblGrade.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblGrade.Location = new System.Drawing.Point(546, 78);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(160, 53);
            this.lblGrade.TabIndex = 8;
            this.lblGrade.Text = "Grade";
            this.lblGrade.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.AutoEllipsis = true;
            this.buttonDetail.BackColor = System.Drawing.Color.Green;
            this.buttonDetail.FlatAppearance.BorderSize = 0;
            this.buttonDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetail.ForeColor = System.Drawing.Color.White;
            this.buttonDetail.Location = new System.Drawing.Point(838, 33);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(196, 109);
            this.buttonDetail.TabIndex = 10;
            this.buttonDetail.Text = "Details";
            this.buttonDetail.UseVisualStyleBackColor = false;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 2);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 181);
            this.panel1.TabIndex = 15;
            // 
            // ListItemStudentGrade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblGradeFixed);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblExamType);
            this.Controls.Add(this.lblTopicName);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ListItemStudentGrade";
            this.Size = new System.Drawing.Size(1062, 183);
            this.Load += new System.EventHandler(this.ListItemStudentGrade_Load);
            this.MouseEnter += new System.EventHandler(this.ListItemStudentGrade_MouseEnter);
            this.MouseHover += new System.EventHandler(this.ListItemStudentGrade_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblExamType;
        private System.Windows.Forms.Label lblTopicName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblGradeFixed;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
