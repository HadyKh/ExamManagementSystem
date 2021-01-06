namespace ExamManagementSystem
{
    partial class SigninWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SigninWindow));
            this.buttonStudentSignIn = new System.Windows.Forms.Button();
            this.buttonInstructorSignIn = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStudentSignIn
            // 
            this.buttonStudentSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentSignIn.Location = new System.Drawing.Point(293, 329);
            this.buttonStudentSignIn.Name = "buttonStudentSignIn";
            this.buttonStudentSignIn.Size = new System.Drawing.Size(299, 101);
            this.buttonStudentSignIn.TabIndex = 0;
            this.buttonStudentSignIn.Text = "Sign in as student";
            this.buttonStudentSignIn.UseVisualStyleBackColor = true;
            this.buttonStudentSignIn.Click += new System.EventHandler(this.buttonStudentSignIn_Click);
            // 
            // buttonInstructorSignIn
            // 
            this.buttonInstructorSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstructorSignIn.Location = new System.Drawing.Point(633, 329);
            this.buttonInstructorSignIn.Name = "buttonInstructorSignIn";
            this.buttonInstructorSignIn.Size = new System.Drawing.Size(299, 101);
            this.buttonInstructorSignIn.TabIndex = 1;
            this.buttonInstructorSignIn.Text = "Sign in as instructor";
            this.buttonInstructorSignIn.UseVisualStyleBackColor = true;
            this.buttonInstructorSignIn.Click += new System.EventHandler(this.buttonInstructorSignIn_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(1093, 12);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(40, 37);
            this.buttonMaximize.TabIndex = 2;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1139, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(41, 37);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(1046, 12);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(41, 37);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Location = new System.Drawing.Point(13, 664);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(106, 34);
            this.buttonAdmin.TabIndex = 5;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // SigninWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1192, 710);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonMaximize);
            this.Controls.Add(this.buttonInstructorSignIn);
            this.Controls.Add(this.buttonStudentSignIn);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SigninWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStudentSignIn;
        private System.Windows.Forms.Button buttonInstructorSignIn;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonAdmin;
    }
}