﻿namespace ExamManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGrades = new System.Windows.Forms.Button();
            this.buttonAvailableExams = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.circularPictureBox1 = new ExamManagementSystem.CircularPictureBox();
            this.lblSt_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelForButton = new System.Windows.Forms.Panel();
            this.buttonExitStudent = new System.Windows.Forms.Button();
            this.flowLayoutPanelwindowshow = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonGrades);
            this.panel1.Controls.Add(this.buttonAvailableExams);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 551);
            this.panel1.TabIndex = 0;
            // 
            // buttonGrades
            // 
            this.buttonGrades.FlatAppearance.BorderSize = 0;
            this.buttonGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrades.Image = ((System.Drawing.Image)(resources.GetObject("buttonGrades.Image")));
            this.buttonGrades.Location = new System.Drawing.Point(0, 222);
            this.buttonGrades.Name = "buttonGrades";
            this.buttonGrades.Size = new System.Drawing.Size(200, 110);
            this.buttonGrades.TabIndex = 4;
            this.buttonGrades.Text = "Grades";
            this.buttonGrades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGrades.UseVisualStyleBackColor = true;
            this.buttonGrades.Click += new System.EventHandler(this.buttonGrades_Click);
            // 
            // buttonAvailableExams
            // 
            this.buttonAvailableExams.FlatAppearance.BorderSize = 0;
            this.buttonAvailableExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvailableExams.Image = ((System.Drawing.Image)(resources.GetObject("buttonAvailableExams.Image")));
            this.buttonAvailableExams.Location = new System.Drawing.Point(0, 106);
            this.buttonAvailableExams.Name = "buttonAvailableExams";
            this.buttonAvailableExams.Size = new System.Drawing.Size(200, 110);
            this.buttonAvailableExams.TabIndex = 4;
            this.buttonAvailableExams.Text = "Available exams";
            this.buttonAvailableExams.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAvailableExams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAvailableExams.UseVisualStyleBackColor = true;
            this.buttonAvailableExams.Click += new System.EventHandler(this.buttonAvailableExams_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.circularPictureBox1);
            this.panel3.Controls.Add(this.lblSt_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(70, 9);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(76, 63);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularPictureBox1.TabIndex = 2;
            this.circularPictureBox1.TabStop = false;
            this.circularPictureBox1.Click += new System.EventHandler(this.circularPictureBox1_Click);
            // 
            // lblSt_name
            // 
            this.lblSt_name.AutoSize = true;
            this.lblSt_name.Location = new System.Drawing.Point(47, 75);
            this.lblSt_name.Name = "lblSt_name";
            this.lblSt_name.Size = new System.Drawing.Size(125, 21);
            this.lblSt_name.TabIndex = 0;
            this.lblSt_name.Text = "Student Name";
            this.lblSt_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonMinimize);
            this.panel2.Controls.Add(this.buttonMaximize);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 65);
            this.panel2.TabIndex = 1;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(945, 10);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(41, 37);
            this.buttonMinimize.TabIndex = 7;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click_1);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(992, 10);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(40, 37);
            this.buttonMaximize.TabIndex = 5;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "dd/mm/yyyy";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelForButton
            // 
            this.panelForButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelForButton.Location = new System.Drawing.Point(200, 106);
            this.panelForButton.Name = "panelForButton";
            this.panelForButton.Size = new System.Drawing.Size(7, 110);
            this.panelForButton.TabIndex = 2;
            // 
            // buttonExitStudent
            // 
            this.buttonExitStudent.FlatAppearance.BorderSize = 0;
            this.buttonExitStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitStudent.Image")));
            this.buttonExitStudent.Location = new System.Drawing.Point(1238, 0);
            this.buttonExitStudent.Name = "buttonExitStudent";
            this.buttonExitStudent.Size = new System.Drawing.Size(57, 57);
            this.buttonExitStudent.TabIndex = 3;
            this.buttonExitStudent.UseVisualStyleBackColor = true;
            this.buttonExitStudent.Click += new System.EventHandler(this.buttonExitStudent_Click);
            // 
            // flowLayoutPanelwindowshow
            // 
            this.flowLayoutPanelwindowshow.AutoScroll = true;
            this.flowLayoutPanelwindowshow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelwindowshow.Location = new System.Drawing.Point(200, 65);
            this.flowLayoutPanelwindowshow.Name = "flowLayoutPanelwindowshow";
            this.flowLayoutPanelwindowshow.Size = new System.Drawing.Size(1095, 486);
            this.flowLayoutPanelwindowshow.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1295, 551);
            this.Controls.Add(this.buttonExitStudent);
            this.Controls.Add(this.panelForButton);
            this.Controls.Add(this.flowLayoutPanelwindowshow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSt_name;
        private System.Windows.Forms.Panel panel2;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Panel panelForButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExitStudent;
        private System.Windows.Forms.Button buttonAvailableExams;
        private System.Windows.Forms.Button buttonGrades;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelwindowshow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
    }
}

