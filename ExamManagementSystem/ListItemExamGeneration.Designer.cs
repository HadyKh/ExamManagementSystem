
namespace ExamManagementSystem
{
    partial class ListItemExamGeneration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCrsName = new System.Windows.Forms.Label();
            this.lblTpName = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelNoMCQ = new System.Windows.Forms.Label();
            this.cmbBxMCQ = new System.Windows.Forms.ComboBox();
            this.lblNoTF = new System.Windows.Forms.Label();
            this.cmbBxTF = new System.Windows.Forms.ComboBox();
            this.lblTrial = new System.Windows.Forms.Label();
            this.cmbBxTrial = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBxDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmBxCrsName = new System.Windows.Forms.ComboBox();
            this.cmbBxTpName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 279);
            this.panel1.TabIndex = 0;
            // 
            // lblCrsName
            // 
            this.lblCrsName.AutoSize = true;
            this.lblCrsName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrsName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblCrsName.Location = new System.Drawing.Point(82, 40);
            this.lblCrsName.Name = "lblCrsName";
            this.lblCrsName.Size = new System.Drawing.Size(151, 23);
            this.lblCrsName.TabIndex = 1;
            this.lblCrsName.Text = "Course Name:";
            // 
            // lblTpName
            // 
            this.lblTpName.AutoSize = true;
            this.lblTpName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblTpName.Location = new System.Drawing.Point(82, 91);
            this.lblTpName.Name = "lblTpName";
            this.lblTpName.Size = new System.Drawing.Size(134, 23);
            this.lblTpName.TabIndex = 3;
            this.lblTpName.Text = "Topic Name:";
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Green;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(276, 128);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(85, 33);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelNoMCQ
            // 
            this.labelNoMCQ.AutoSize = true;
            this.labelNoMCQ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMCQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelNoMCQ.Location = new System.Drawing.Point(465, 32);
            this.labelNoMCQ.Name = "labelNoMCQ";
            this.labelNoMCQ.Size = new System.Drawing.Size(278, 23);
            this.labelNoMCQ.TabIndex = 6;
            this.labelNoMCQ.Text = "Number of MCQ Questions:";
            // 
            // cmbBxMCQ
            // 
            this.cmbBxMCQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxMCQ.FormattingEnabled = true;
            this.cmbBxMCQ.Location = new System.Drawing.Point(749, 35);
            this.cmbBxMCQ.Name = "cmbBxMCQ";
            this.cmbBxMCQ.Size = new System.Drawing.Size(147, 24);
            this.cmbBxMCQ.TabIndex = 7;
            this.cmbBxMCQ.SelectedIndexChanged += new System.EventHandler(this.comboBoxMCQ_SelectedIndexChanged);
            // 
            // lblNoTF
            // 
            this.lblNoTF.AutoSize = true;
            this.lblNoTF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblNoTF.Location = new System.Drawing.Point(465, 79);
            this.lblNoTF.Name = "lblNoTF";
            this.lblNoTF.Size = new System.Drawing.Size(254, 23);
            this.lblNoTF.TabIndex = 8;
            this.lblNoTF.Text = "Number of T/F Questions:";
            this.lblNoTF.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbBxTF
            // 
            this.cmbBxTF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxTF.FormattingEnabled = true;
            this.cmbBxTF.Location = new System.Drawing.Point(749, 82);
            this.cmbBxTF.Name = "cmbBxTF";
            this.cmbBxTF.Size = new System.Drawing.Size(147, 24);
            this.cmbBxTF.TabIndex = 9;
            this.cmbBxTF.SelectedIndexChanged += new System.EventHandler(this.comboBoxTF_SelectedIndexChanged);
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblTrial.Location = new System.Drawing.Point(465, 125);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(143, 23);
            this.lblTrial.TabIndex = 10;
            this.lblTrial.Text = "Trial Number :";
            // 
            // cmbBxTrial
            // 
            this.cmbBxTrial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxTrial.FormattingEnabled = true;
            this.cmbBxTrial.Location = new System.Drawing.Point(749, 128);
            this.cmbBxTrial.Name = "cmbBxTrial";
            this.cmbBxTrial.Size = new System.Drawing.Size(147, 24);
            this.cmbBxTrial.TabIndex = 11;
            this.cmbBxTrial.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrial_SelectedIndexChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.Green;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.ForeColor = System.Drawing.Color.White;
            this.buttonGenerate.Location = new System.Drawing.Point(961, 91);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(112, 70);
            this.buttonGenerate.TabIndex = 12;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(465, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Duration :";
            // 
            // cmbBxDuration
            // 
            this.cmbBxDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxDuration.FormattingEnabled = true;
            this.cmbBxDuration.Location = new System.Drawing.Point(749, 176);
            this.cmbBxDuration.Name = "cmbBxDuration";
            this.cmbBxDuration.Size = new System.Drawing.Size(72, 24);
            this.cmbBxDuration.TabIndex = 11;
            this.cmbBxDuration.SelectedIndexChanged += new System.EventHandler(this.comboBoxDuration_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(834, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hour/s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(465, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(749, 221);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 13;
            this.dateTimePicker.Value = new System.DateTime(2021, 1, 7, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // cmBxCrsName
            // 
            this.cmBxCrsName.FormattingEnabled = true;
            this.cmBxCrsName.Location = new System.Drawing.Point(254, 37);
            this.cmBxCrsName.Name = "cmBxCrsName";
            this.cmBxCrsName.Size = new System.Drawing.Size(175, 24);
            this.cmBxCrsName.TabIndex = 14;
            this.cmBxCrsName.SelectedIndexChanged += new System.EventHandler(this.cmBxCrsName_SelectedIndexChanged);
            // 
            // cmbBxTpName
            // 
            this.cmbBxTpName.FormattingEnabled = true;
            this.cmbBxTpName.Location = new System.Drawing.Point(254, 90);
            this.cmbBxTpName.Name = "cmbBxTpName";
            this.cmbBxTpName.Size = new System.Drawing.Size(175, 24);
            this.cmbBxTpName.TabIndex = 15;
            this.cmbBxTpName.SelectedIndexChanged += new System.EventHandler(this.cmbBxTpName_SelectedIndexChanged);
            // 
            // ListItemExamGeneration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.cmbBxTpName);
            this.Controls.Add(this.cmBxCrsName);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.cmbBxDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxTrial);
            this.Controls.Add(this.lblTrial);
            this.Controls.Add(this.cmbBxTF);
            this.Controls.Add(this.lblNoTF);
            this.Controls.Add(this.cmbBxMCQ);
            this.Controls.Add(this.labelNoMCQ);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.lblTpName);
            this.Controls.Add(this.lblCrsName);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListItemExamGeneration";
            this.Size = new System.Drawing.Size(1095, 279);
            this.Load += new System.EventHandler(this.ListItemExamGeneration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCrsName;
        private System.Windows.Forms.Label lblTpName;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelNoMCQ;
        private System.Windows.Forms.ComboBox cmbBxMCQ;
        private System.Windows.Forms.Label lblNoTF;
        private System.Windows.Forms.ComboBox cmbBxTF;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.ComboBox cmbBxTrial;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cmBxCrsName;
        private System.Windows.Forms.ComboBox cmbBxTpName;
    }
}
