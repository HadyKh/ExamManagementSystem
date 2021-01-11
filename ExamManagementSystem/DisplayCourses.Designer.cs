
namespace ExamManagementSystem
{
    partial class DisplayCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayCourses));
            this.panelstudentInfo = new System.Windows.Forms.Panel();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Crs_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ins_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crs_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelstudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelstudentInfo
            // 
            this.panelstudentInfo.Controls.Add(this.buttonBackward);
            this.panelstudentInfo.Controls.Add(this.buttonGetData);
            this.panelstudentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelstudentInfo.Location = new System.Drawing.Point(0, 0);
            this.panelstudentInfo.Name = "panelstudentInfo";
            this.panelstudentInfo.Size = new System.Drawing.Size(1176, 86);
            this.panelstudentInfo.TabIndex = 0;
            // 
            // buttonBackward
            // 
            this.buttonBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonBackward.Image = global::ExamManagementSystem.Properties.Resources.icons8_export_30;
            this.buttonBackward.Location = new System.Drawing.Point(1089, 12);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(75, 57);
            this.buttonBackward.TabIndex = 58;
            this.buttonBackward.UseVisualStyleBackColor = true;
            this.buttonBackward.Click += new System.EventHandler(this.buttonBackward_Click);
            // 
            // buttonGetData
            // 
            this.buttonGetData.FlatAppearance.BorderSize = 2;
            this.buttonGetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetData.Location = new System.Drawing.Point(537, 28);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(227, 35);
            this.buttonGetData.TabIndex = 55;
            this.buttonGetData.Text = "Get All Courses Data";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Crs_ID,
            this.Course_Name,
            this.Ins_ID,
            this.Topic_Name,
            this.Crs_duration});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1176, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // Crs_ID
            // 
            this.Crs_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Crs_ID.DataPropertyName = "Crs_ID";
            this.Crs_ID.HeaderText = "Course ID";
            this.Crs_ID.Name = "Crs_ID";
            // 
            // Course_Name
            // 
            this.Course_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Course_Name.DataPropertyName = "Crs_Name";
            this.Course_Name.HeaderText = "Course Name";
            this.Course_Name.Name = "Course_Name";
            // 
            // Ins_ID
            // 
            this.Ins_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ins_ID.DataPropertyName = "Mgr_ID";
            this.Ins_ID.HeaderText = "Instructor ID";
            this.Ins_ID.Name = "Ins_ID";
            // 
            // Topic_Name
            // 
            this.Topic_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Topic_Name.DataPropertyName = "Tp_name";
            this.Topic_Name.HeaderText = "Topic Name";
            this.Topic_Name.Name = "Topic_Name";
            // 
            // Crs_duration
            // 
            this.Crs_duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Crs_duration.DataPropertyName = "crs_duration";
            this.Crs_duration.HeaderText = "Course Duration";
            this.Crs_duration.Name = "Crs_duration";
            // 
            // DisplayCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1176, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelstudentInfo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayCourses";
            this.panelstudentInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelstudentInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crs_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ins_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crs_duration;
    }
}