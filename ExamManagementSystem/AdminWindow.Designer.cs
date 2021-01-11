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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExitAdmin = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCourses = new System.Windows.Forms.Panel();
            this.buttonRemoveCourse = new System.Windows.Forms.Button();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonDisplayCourses = new System.Windows.Forms.Button();
            this.buttonCourses = new System.Windows.Forms.Button();
            this.panelInstructor = new System.Windows.Forms.Panel();
            this.buttonRemoveInstructor = new System.Windows.Forms.Button();
            this.buttonAddInstructor = new System.Windows.Forms.Button();
            this.buttonDisplayInstructor = new System.Windows.Forms.Button();
            this.buttonInstructor = new System.Windows.Forms.Button();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.buttonRemoveStudent = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonDisplayStudent = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCourses.SuspendLayout();
            this.panelInstructor.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.buttonExitAdmin);
            this.panel1.Controls.Add(this.buttonMaximize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 101);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "dd/mm/yyyy";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(979, 29);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(41, 37);
            this.buttonMinimize.TabIndex = 9;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExitAdmin
            // 
            this.buttonExitAdmin.FlatAppearance.BorderSize = 0;
            this.buttonExitAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitAdmin.Image")));
            this.buttonExitAdmin.Location = new System.Drawing.Point(1077, 19);
            this.buttonExitAdmin.Name = "buttonExitAdmin";
            this.buttonExitAdmin.Size = new System.Drawing.Size(75, 57);
            this.buttonExitAdmin.TabIndex = 4;
            this.buttonExitAdmin.UseVisualStyleBackColor = true;
            this.buttonExitAdmin.Click += new System.EventHandler(this.buttonExitAdmin_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(1040, 29);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(40, 37);
            this.buttonMaximize.TabIndex = 8;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelCourses);
            this.panel2.Controls.Add(this.panelInstructor);
            this.panel2.Controls.Add(this.panelStudent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 587);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelCourses
            // 
            this.panelCourses.Controls.Add(this.buttonRemoveCourse);
            this.panelCourses.Controls.Add(this.buttonAddCourse);
            this.panelCourses.Controls.Add(this.buttonDisplayCourses);
            this.panelCourses.Controls.Add(this.buttonCourses);
            this.panelCourses.Location = new System.Drawing.Point(447, 309);
            this.panelCourses.MaximumSize = new System.Drawing.Size(240, 155);
            this.panelCourses.MinimumSize = new System.Drawing.Size(240, 62);
            this.panelCourses.Name = "panelCourses";
            this.panelCourses.Size = new System.Drawing.Size(240, 62);
            this.panelCourses.TabIndex = 5;
            // 
            // buttonRemoveCourse
            // 
            this.buttonRemoveCourse.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonRemoveCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveCourse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveCourse.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveCourse.Location = new System.Drawing.Point(0, 125);
            this.buttonRemoveCourse.Name = "buttonRemoveCourse";
            this.buttonRemoveCourse.Size = new System.Drawing.Size(240, 31);
            this.buttonRemoveCourse.TabIndex = 5;
            this.buttonRemoveCourse.Text = "Remove/Update Course";
            this.buttonRemoveCourse.UseVisualStyleBackColor = false;
            this.buttonRemoveCourse.Click += new System.EventHandler(this.buttonRemoveCourse_Click);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonAddCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCourse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.ForeColor = System.Drawing.Color.Black;
            this.buttonAddCourse.Location = new System.Drawing.Point(0, 94);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(240, 31);
            this.buttonAddCourse.TabIndex = 4;
            this.buttonAddCourse.Text = "Add Course";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // buttonDisplayCourses
            // 
            this.buttonDisplayCourses.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonDisplayCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDisplayCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisplayCourses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayCourses.ForeColor = System.Drawing.Color.Black;
            this.buttonDisplayCourses.Location = new System.Drawing.Point(0, 63);
            this.buttonDisplayCourses.Name = "buttonDisplayCourses";
            this.buttonDisplayCourses.Size = new System.Drawing.Size(240, 31);
            this.buttonDisplayCourses.TabIndex = 3;
            this.buttonDisplayCourses.Text = "Display Courses";
            this.buttonDisplayCourses.UseVisualStyleBackColor = false;
            this.buttonDisplayCourses.Click += new System.EventHandler(this.buttonDisplayCourses_Click);
            // 
            // buttonCourses
            // 
            this.buttonCourses.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCourses.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCourses.ForeColor = System.Drawing.Color.Black;
            this.buttonCourses.Image = global::ExamManagementSystem.Properties.Resources.expand_Arrow;
            this.buttonCourses.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonCourses.Location = new System.Drawing.Point(0, 0);
            this.buttonCourses.Name = "buttonCourses";
            this.buttonCourses.Size = new System.Drawing.Size(240, 63);
            this.buttonCourses.TabIndex = 2;
            this.buttonCourses.Text = "Courses";
            this.buttonCourses.UseVisualStyleBackColor = false;
            this.buttonCourses.MouseLeave += new System.EventHandler(this.buttonCourses_MouseLeave);
            this.buttonCourses.MouseHover += new System.EventHandler(this.buttonCourses_MouseHover);
            // 
            // panelInstructor
            // 
            this.panelInstructor.Controls.Add(this.buttonRemoveInstructor);
            this.panelInstructor.Controls.Add(this.buttonAddInstructor);
            this.panelInstructor.Controls.Add(this.buttonDisplayInstructor);
            this.panelInstructor.Controls.Add(this.buttonInstructor);
            this.panelInstructor.Location = new System.Drawing.Point(708, 132);
            this.panelInstructor.MaximumSize = new System.Drawing.Size(240, 155);
            this.panelInstructor.MinimumSize = new System.Drawing.Size(240, 62);
            this.panelInstructor.Name = "panelInstructor";
            this.panelInstructor.Size = new System.Drawing.Size(240, 62);
            this.panelInstructor.TabIndex = 4;
            // 
            // buttonRemoveInstructor
            // 
            this.buttonRemoveInstructor.BackColor = System.Drawing.Color.LightGreen;
            this.buttonRemoveInstructor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRemoveInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveInstructor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveInstructor.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveInstructor.Location = new System.Drawing.Point(0, 124);
            this.buttonRemoveInstructor.Name = "buttonRemoveInstructor";
            this.buttonRemoveInstructor.Size = new System.Drawing.Size(240, 31);
            this.buttonRemoveInstructor.TabIndex = 3;
            this.buttonRemoveInstructor.Text = "Remove/Update Instructor";
            this.buttonRemoveInstructor.UseVisualStyleBackColor = false;
            this.buttonRemoveInstructor.Click += new System.EventHandler(this.buttonRemoveInstructor_Click);
            // 
            // buttonAddInstructor
            // 
            this.buttonAddInstructor.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAddInstructor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddInstructor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddInstructor.ForeColor = System.Drawing.Color.Black;
            this.buttonAddInstructor.Location = new System.Drawing.Point(0, 93);
            this.buttonAddInstructor.Name = "buttonAddInstructor";
            this.buttonAddInstructor.Size = new System.Drawing.Size(240, 31);
            this.buttonAddInstructor.TabIndex = 2;
            this.buttonAddInstructor.Text = "Add Instructor";
            this.buttonAddInstructor.UseVisualStyleBackColor = false;
            this.buttonAddInstructor.Click += new System.EventHandler(this.buttonAddInstructor_Click);
            // 
            // buttonDisplayInstructor
            // 
            this.buttonDisplayInstructor.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDisplayInstructor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDisplayInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisplayInstructor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayInstructor.ForeColor = System.Drawing.Color.Black;
            this.buttonDisplayInstructor.Location = new System.Drawing.Point(0, 62);
            this.buttonDisplayInstructor.Name = "buttonDisplayInstructor";
            this.buttonDisplayInstructor.Size = new System.Drawing.Size(240, 31);
            this.buttonDisplayInstructor.TabIndex = 1;
            this.buttonDisplayInstructor.Text = "Display Instructors";
            this.buttonDisplayInstructor.UseVisualStyleBackColor = false;
            this.buttonDisplayInstructor.Click += new System.EventHandler(this.buttonDisplayInstructor_Click);
            // 
            // buttonInstructor
            // 
            this.buttonInstructor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonInstructor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstructor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstructor.ForeColor = System.Drawing.Color.Black;
            this.buttonInstructor.Image = global::ExamManagementSystem.Properties.Resources.expand_Arrow;
            this.buttonInstructor.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonInstructor.Location = new System.Drawing.Point(0, 0);
            this.buttonInstructor.Name = "buttonInstructor";
            this.buttonInstructor.Size = new System.Drawing.Size(240, 62);
            this.buttonInstructor.TabIndex = 0;
            this.buttonInstructor.Text = "Instructor";
            this.buttonInstructor.UseVisualStyleBackColor = false;
            this.buttonInstructor.MouseLeave += new System.EventHandler(this.buttonInstructor_MouseLeave);
            this.buttonInstructor.MouseHover += new System.EventHandler(this.buttonInstructor_MouseHover);
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.buttonRemoveStudent);
            this.panelStudent.Controls.Add(this.buttonAddStudent);
            this.panelStudent.Controls.Add(this.buttonDisplayStudent);
            this.panelStudent.Controls.Add(this.buttonStudent);
            this.panelStudent.Location = new System.Drawing.Point(179, 132);
            this.panelStudent.MaximumSize = new System.Drawing.Size(240, 155);
            this.panelStudent.MinimumSize = new System.Drawing.Size(240, 62);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(240, 62);
            this.panelStudent.TabIndex = 3;
            // 
            // buttonRemoveStudent
            // 
            this.buttonRemoveStudent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRemoveStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRemoveStudent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRemoveStudent.FlatAppearance.BorderSize = 5;
            this.buttonRemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveStudent.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveStudent.Location = new System.Drawing.Point(0, 124);
            this.buttonRemoveStudent.Name = "buttonRemoveStudent";
            this.buttonRemoveStudent.Size = new System.Drawing.Size(240, 30);
            this.buttonRemoveStudent.TabIndex = 4;
            this.buttonRemoveStudent.Text = "Remove/Update Student";
            this.buttonRemoveStudent.UseVisualStyleBackColor = false;
            this.buttonRemoveStudent.Click += new System.EventHandler(this.buttonRemoveStudent_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddStudent.FlatAppearance.BorderSize = 5;
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStudent.ForeColor = System.Drawing.Color.Black;
            this.buttonAddStudent.Location = new System.Drawing.Point(0, 93);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(240, 31);
            this.buttonAddStudent.TabIndex = 3;
            this.buttonAddStudent.Text = "Add Student";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonDisplayStudent
            // 
            this.buttonDisplayStudent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDisplayStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDisplayStudent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDisplayStudent.FlatAppearance.BorderSize = 5;
            this.buttonDisplayStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisplayStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayStudent.ForeColor = System.Drawing.Color.Black;
            this.buttonDisplayStudent.Location = new System.Drawing.Point(0, 62);
            this.buttonDisplayStudent.Name = "buttonDisplayStudent";
            this.buttonDisplayStudent.Size = new System.Drawing.Size(240, 31);
            this.buttonDisplayStudent.TabIndex = 2;
            this.buttonDisplayStudent.Text = "Display Students";
            this.buttonDisplayStudent.UseVisualStyleBackColor = false;
            this.buttonDisplayStudent.Click += new System.EventHandler(this.buttonDisplayStudent_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStudent.FlatAppearance.BorderSize = 5;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStudent.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudent.ForeColor = System.Drawing.Color.Black;
            this.buttonStudent.Image = global::ExamManagementSystem.Properties.Resources.expand_Arrow;
            this.buttonStudent.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonStudent.Location = new System.Drawing.Point(0, 0);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(240, 62);
            this.buttonStudent.TabIndex = 1;
            this.buttonStudent.Text = "Student";
            this.buttonStudent.UseVisualStyleBackColor = false;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            this.buttonStudent.MouseLeave += new System.EventHandler(this.buttonStudent_MouseLeave);
            this.buttonStudent.MouseHover += new System.EventHandler(this.buttonstudent_mousehover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // AdminWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1164, 688);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminWindow";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelCourses.ResumeLayout(false);
            this.panelInstructor.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCourses;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonInstructor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Button buttonRemoveStudent;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonDisplayStudent;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelInstructor;
        private System.Windows.Forms.Panel panelCourses;
        private System.Windows.Forms.Button buttonRemoveInstructor;
        private System.Windows.Forms.Button buttonAddInstructor;
        private System.Windows.Forms.Button buttonDisplayInstructor;
        private System.Windows.Forms.Button buttonRemoveCourse;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button buttonDisplayCourses;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}