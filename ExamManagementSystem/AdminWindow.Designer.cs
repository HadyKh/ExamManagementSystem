namespace ExamManagementSystem
{
    partial class AdminWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Courses = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.Instructor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExitAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Courses);
            this.panel1.Controls.Add(this.Student);
            this.panel1.Controls.Add(this.Instructor);
            this.panel1.Location = new System.Drawing.Point(271, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 101);
            this.panel1.TabIndex = 5;
            // 
            // Courses
            // 
            this.Courses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Courses.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Courses.Location = new System.Drawing.Point(426, 23);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(124, 62);
            this.Courses.TabIndex = 2;
            this.Courses.Text = "Courses";
            this.Courses.UseVisualStyleBackColor = true;
            this.Courses.Click += new System.EventHandler(this.Courses_Click);
            // 
            // Student
            // 
            this.Student.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Student.Location = new System.Drawing.Point(42, 23);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(124, 62);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // Instructor
            // 
            this.Instructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Instructor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Instructor.Location = new System.Drawing.Point(235, 23);
            this.Instructor.Name = "Instructor";
            this.Instructor.Size = new System.Drawing.Size(121, 62);
            this.Instructor.TabIndex = 0;
            this.Instructor.Text = "Instructor";
            this.Instructor.UseVisualStyleBackColor = true;
            this.Instructor.Click += new System.EventHandler(this.Instructor_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(24, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 435);
            this.panel2.TabIndex = 6;
            // 
            // buttonExitAdmin
            // 
            this.buttonExitAdmin.FlatAppearance.BorderSize = 0;
            this.buttonExitAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitAdmin.Image")));
            this.buttonExitAdmin.Location = new System.Drawing.Point(1077, 12);
            this.buttonExitAdmin.Name = "buttonExitAdmin";
            this.buttonExitAdmin.Size = new System.Drawing.Size(75, 57);
            this.buttonExitAdmin.TabIndex = 4;
            this.buttonExitAdmin.UseVisualStyleBackColor = true;
            this.buttonExitAdmin.Click += new System.EventHandler(this.buttonExitAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(960, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "dd/mm/yyyy";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(962, 539);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(41, 37);
            this.buttonMinimize.TabIndex = 9;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(1009, 539);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(40, 37);
            this.buttonMaximize.TabIndex = 8;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1164, 688);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonMaximize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExitAdmin);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Courses;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Instructor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
    }
}