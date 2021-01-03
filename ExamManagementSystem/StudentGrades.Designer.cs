
namespace ExamManagementSystem
{
    partial class StudentGrades
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listItemStudentGrade1 = new ExamManagementSystem.ListItemStudentGrade();
            this.SuspendLayout();
            // 
            // listItemStudentGrade1
            // 
            this.listItemStudentGrade1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.listItemStudentGrade1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.listItemStudentGrade1.Location = new System.Drawing.Point(95, 24);
            this.listItemStudentGrade1.Name = "listItemStudentGrade1";
            this.listItemStudentGrade1.Size = new System.Drawing.Size(803, 131);
            this.listItemStudentGrade1.TabIndex = 0;
            // 
            // StudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1095, 486);
            this.Controls.Add(this.listItemStudentGrade1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentGrades";
            this.Text = "StudentGrades";
            this.ResumeLayout(false);

        }

        #endregion

        private ListItemStudentGrade listItemStudentGrade1;
    }
}