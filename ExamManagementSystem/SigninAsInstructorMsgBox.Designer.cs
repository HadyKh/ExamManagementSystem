
namespace ExamManagementSystem
{
    partial class SigninAsInstructorMsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SigninAsInstructorMsgBox));
            this.UserName = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.Instructor = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.btnlogin_as = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            resources.ApplyResources(this.UserName, "UserName");
            this.UserName.Name = "UserName";
            this.UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_email
            // 
            resources.ApplyResources(this.txt_email, "txt_email");
            this.txt_email.Name = "txt_email";
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.Password.Name = "Password";
            this.Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_password
            // 
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.Name = "txt_password";
            // 
            // SignIn
            // 
            this.SignIn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.SignIn, "SignIn");
            this.SignIn.Image = global::ExamManagementSystem.Properties.Resources.login_3;
            this.SignIn.Name = "SignIn";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Instructor
            // 
            resources.ApplyResources(this.Instructor, "Instructor");
            this.Instructor.Name = "Instructor";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnlogin_as
            // 
            resources.ApplyResources(this.btnlogin_as, "btnlogin_as");
            this.btnlogin_as.Name = "btnlogin_as";
            this.btnlogin_as.UseVisualStyleBackColor = true;
            this.btnlogin_as.Click += new System.EventHandler(this.btnlogin_as_Click);
            // 
            // SigninAsInstructorMsgBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnlogin_as);
            this.Controls.Add(this.Instructor);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.buttonClose);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SigninAsInstructorMsgBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Label Instructor;
        private System.Windows.Forms.Button btnlogin_as;
    }
}