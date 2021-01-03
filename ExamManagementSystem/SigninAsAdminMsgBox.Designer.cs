
namespace ExamManagementSystem
{
    partial class SigninAsAdminMsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SigninAsAdminMsgBox));
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Admin = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.UserName.Location = new System.Drawing.Point(84, 89);
            this.UserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(108, 23);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Username";
            this.UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.Password.Location = new System.Drawing.Point(96, 168);
            this.Password.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(103, 23);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 168);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 27);
            this.textBox2.TabIndex = 4;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.Admin.Location = new System.Drawing.Point(27, 25);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(73, 23);
            this.Admin.TabIndex = 6;
            this.Admin.Text = "Admin";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(650, 1);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(39, 34);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // SignIn
            // 
            this.SignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.SignIn.Image = global::ExamManagementSystem.Properties.Resources.login_3;
            this.SignIn.Location = new System.Drawing.Point(620, 230);
            this.SignIn.Margin = new System.Windows.Forms.Padding(5);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(55, 68);
            this.SignIn.TabIndex = 0;
            this.SignIn.UseVisualStyleBackColor = true;
            // 
            // SigninAsAdminMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(691, 309);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.SignIn);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SigninAsAdminMsgBox";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label Admin;
    }
}