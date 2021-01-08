namespace ExamManagementSystem
{
    partial class ListItemStudentGrade
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGradeFixed = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTpScore = new System.Windows.Forms.Button();
            this.btnCrsGrade = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGradeFixed
            // 
            this.lblGradeFixed.AutoEllipsis = true;
            this.lblGradeFixed.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblGradeFixed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblGradeFixed.Location = new System.Drawing.Point(448, 11);
            this.lblGradeFixed.Name = "lblGradeFixed";
            this.lblGradeFixed.Size = new System.Drawing.Size(148, 41);
            this.lblGradeFixed.TabIndex = 7;
            this.lblGradeFixed.Text = "Grades";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 569);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 2);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnCrsGrade);
            this.panel1.Controls.Add(this.btnTpScore);
            this.panel1.Controls.Add(this.lblGradeFixed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 126);
            this.panel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 443);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnTpScore
            // 
            this.btnTpScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTpScore.Location = new System.Drawing.Point(235, 58);
            this.btnTpScore.Name = "btnTpScore";
            this.btnTpScore.Size = new System.Drawing.Size(177, 42);
            this.btnTpScore.TabIndex = 8;
            this.btnTpScore.Text = "Topic Scores";
            this.btnTpScore.UseVisualStyleBackColor = true;
            this.btnTpScore.Click += new System.EventHandler(this.btnTpScore_Click);
            // 
            // btnCrsGrade
            // 
            this.btnCrsGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrsGrade.Location = new System.Drawing.Point(624, 58);
            this.btnCrsGrade.Name = "btnCrsGrade";
            this.btnCrsGrade.Size = new System.Drawing.Size(181, 42);
            this.btnCrsGrade.TabIndex = 8;
            this.btnCrsGrade.Text = "Course Grades";
            this.btnCrsGrade.UseVisualStyleBackColor = true;
            this.btnCrsGrade.Click += new System.EventHandler(this.btnCrsGrade_Click);
            // 
            // ListItemStudentGrade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ListItemStudentGrade";
            this.Size = new System.Drawing.Size(1062, 571);
            this.Load += new System.EventHandler(this.ListItemStudentGrade_Load);
            this.MouseEnter += new System.EventHandler(this.ListItemStudentGrade_MouseEnter);
            this.MouseHover += new System.EventHandler(this.ListItemStudentGrade_MouseHover);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGradeFixed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCrsGrade;
        private System.Windows.Forms.Button btnTpScore;
    }
}
