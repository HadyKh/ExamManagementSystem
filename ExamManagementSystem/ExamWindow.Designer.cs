﻿namespace ExamManagementSystem
{
    partial class ExamWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTopicName = new System.Windows.Forms.Label();
            this.lblExamType = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanelExamQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFinish);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblTopicName);
            this.panel1.Controls.Add(this.lblExamType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 68);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Green;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(734, 24);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(56, 31);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTimer.Location = new System.Drawing.Point(546, 24);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(83, 31);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "Timer";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopicName
            // 
            this.lblTopicName.AutoSize = true;
            this.lblTopicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicName.Location = new System.Drawing.Point(327, 24);
            this.lblTopicName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopicName.Name = "lblTopicName";
            this.lblTopicName.Size = new System.Drawing.Size(165, 31);
            this.lblTopicName.TabIndex = 0;
            this.lblTopicName.Text = "Topic name";
            // 
            // lblExamType
            // 
            this.lblExamType.AutoSize = true;
            this.lblExamType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamType.Location = new System.Drawing.Point(27, 24);
            this.lblExamType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExamType.Name = "lblExamType";
            this.lblExamType.Size = new System.Drawing.Size(159, 31);
            this.lblExamType.TabIndex = 0;
            this.lblExamType.Text = "Exam Type";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanelExamQuestion
            // 
            this.flowLayoutPanelExamQuestion.AutoScroll = true;
            this.flowLayoutPanelExamQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelExamQuestion.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanelExamQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelExamQuestion.Name = "flowLayoutPanelExamQuestion";
            this.flowLayoutPanelExamQuestion.Size = new System.Drawing.Size(821, 327);
            this.flowLayoutPanelExamQuestion.TabIndex = 1;
            // 
            // ExamWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(821, 395);
            this.Controls.Add(this.flowLayoutPanelExamQuestion);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExamWindow";
            this.Text = "ExamWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamWindow_FormClosing);
            this.Load += new System.EventHandler(this.ExamWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTopicName;
        private System.Windows.Forms.Label lblExamType;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelExamQuestion;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnFinish;
    }
}