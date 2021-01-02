namespace ExamManagementSystem
{
    partial class ListItemAvailableExam
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
            this.lblTopicName = new System.Windows.Forms.Label();
            this.lblExamType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExamTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTopicName
            // 
            this.lblTopicName.AutoSize = true;
            this.lblTopicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblTopicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblTopicName.Location = new System.Drawing.Point(79, 16);
            this.lblTopicName.Name = "lblTopicName";
            this.lblTopicName.Size = new System.Drawing.Size(162, 31);
            this.lblTopicName.TabIndex = 0;
            this.lblTopicName.Text = "TopicName";
            this.lblTopicName.Click += new System.EventHandler(this.lblTopicName_Click);
            // 
            // lblExamType
            // 
            this.lblExamType.AutoSize = true;
            this.lblExamType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamType.Location = new System.Drawing.Point(80, 59);
            this.lblExamType.Name = "lblExamType";
            this.lblExamType.Size = new System.Drawing.Size(115, 25);
            this.lblExamType.TabIndex = 1;
            this.lblExamType.Text = "ExamType";
            this.lblExamType.Click += new System.EventHandler(this.lblExamType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CrsName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(878, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 76);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Exam";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(572, 44);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "hh:mm";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(527, 44);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 20);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "At: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time:";
            // 
            // lblExamTime
            // 
            this.lblExamTime.AutoSize = true;
            this.lblExamTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamTime.Location = new System.Drawing.Point(699, 44);
            this.lblExamTime.Name = "lblExamTime";
            this.lblExamTime.Size = new System.Drawing.Size(29, 20);
            this.lblExamTime.TabIndex = 6;
            this.lblExamTime.Text = "hh";
            this.lblExamTime.Click += new System.EventHandler(this.lblExamTime_Click);
            // 
            // ListItemAvailableExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1100, 129);
            this.Controls.Add(this.lblExamTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExamType);
            this.Controls.Add(this.lblTopicName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListItemAvailableExam";
            this.Text = "ListItemAvailableExam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopicName;
        private System.Windows.Forms.Label lblExamType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExamTime;
    }
}