namespace ExamManagementSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblss = new System.Windows.Forms.Label();
            this.lblmm = new System.Windows.Forms.Label();
            this.lblhh = new System.Windows.Forms.Label();
            this.lblTopicName = new System.Windows.Forms.Label();
            this.lblExamType = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanelExamQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.listItemExamQuestion1 = new ExamManagementSystem.ListItemExamQuestion();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelExamQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblss);
            this.panel1.Controls.Add(this.lblmm);
            this.panel1.Controls.Add(this.lblhh);
            this.panel1.Controls.Add(this.lblTopicName);
            this.panel1.Controls.Add(this.lblExamType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 68);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(746, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(692, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // lblss
            // 
            this.lblss.AutoSize = true;
            this.lblss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblss.Location = new System.Drawing.Point(764, 35);
            this.lblss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblss.Name = "lblss";
            this.lblss.Size = new System.Drawing.Size(25, 20);
            this.lblss.TabIndex = 1;
            this.lblss.Text = "ss";
            // 
            // lblmm
            // 
            this.lblmm.AutoSize = true;
            this.lblmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmm.Location = new System.Drawing.Point(710, 35);
            this.lblmm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmm.Name = "lblmm";
            this.lblmm.Size = new System.Drawing.Size(35, 20);
            this.lblmm.TabIndex = 1;
            this.lblmm.Text = "mm";
            // 
            // lblhh
            // 
            this.lblhh.AutoSize = true;
            this.lblhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhh.Location = new System.Drawing.Point(662, 35);
            this.lblhh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhh.Name = "lblhh";
            this.lblhh.Size = new System.Drawing.Size(27, 20);
            this.lblhh.TabIndex = 1;
            this.lblhh.Text = "hh";
            // 
            // lblTopicName
            // 
            this.lblTopicName.AutoSize = true;
            this.lblTopicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicName.Location = new System.Drawing.Point(364, 24);
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
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanelExamQuestion
            // 
            this.flowLayoutPanelExamQuestion.AutoScroll = true;
            this.flowLayoutPanelExamQuestion.Controls.Add(this.listItemExamQuestion1);
            this.flowLayoutPanelExamQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelExamQuestion.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanelExamQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelExamQuestion.Name = "flowLayoutPanelExamQuestion";
            this.flowLayoutPanelExamQuestion.Size = new System.Drawing.Size(996, 446);
            this.flowLayoutPanelExamQuestion.TabIndex = 1;
            // 
            // listItemExamQuestion1
            // 
            this.listItemExamQuestion1.Answer1 = null;
            this.listItemExamQuestion1.Answer2 = null;
            this.listItemExamQuestion1.Answer3 = null;
            this.listItemExamQuestion1.Answer4 = null;
            this.listItemExamQuestion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.listItemExamQuestion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listItemExamQuestion1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.listItemExamQuestion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.listItemExamQuestion1.Location = new System.Drawing.Point(4, 4);
            this.listItemExamQuestion1.Margin = new System.Windows.Forms.Padding(4);
            this.listItemExamQuestion1.Name = "listItemExamQuestion1";
            this.listItemExamQuestion1.QNum = null;
            this.listItemExamQuestion1.Question = null;
            this.listItemExamQuestion1.Size = new System.Drawing.Size(978, 0);
            this.listItemExamQuestion1.TabIndex = 0;
            // 
            // ExamWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(996, 514);
            this.Controls.Add(this.flowLayoutPanelExamQuestion);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExamWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamWindow_FormClosing);
            this.Load += new System.EventHandler(this.ExamWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanelExamQuestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTopicName;
        private System.Windows.Forms.Label lblExamType;
        private System.Windows.Forms.Label lblhh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblss;
        private System.Windows.Forms.Label lblmm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelExamQuestion;
        private ListItemExamQuestion listItemExamQuestion1;
    }
}