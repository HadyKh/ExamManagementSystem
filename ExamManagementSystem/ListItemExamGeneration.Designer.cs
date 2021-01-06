
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
            this.textBoxCrsName = new System.Windows.Forms.TextBox();
            this.lblTpName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelNoMCQ = new System.Windows.Forms.Label();
            this.comboBoxMCQ = new System.Windows.Forms.ComboBox();
            this.lblNoTF = new System.Windows.Forms.Label();
            this.comboBoxTF = new System.Windows.Forms.ComboBox();
            this.lblTrial = new System.Windows.Forms.Label();
            this.comboBoxTrial = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 183);
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
            // textBoxCrsName
            // 
            this.textBoxCrsName.Location = new System.Drawing.Point(234, 38);
            this.textBoxCrsName.Name = "textBoxCrsName";
            this.textBoxCrsName.Size = new System.Drawing.Size(175, 22);
            this.textBoxCrsName.TabIndex = 2;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 4;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Green;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(324, 128);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(85, 33);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = false;
            // 
            // labelNoMCQ
            // 
            this.labelNoMCQ.AutoSize = true;
            this.labelNoMCQ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMCQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelNoMCQ.Location = new System.Drawing.Point(527, 32);
            this.labelNoMCQ.Name = "labelNoMCQ";
            this.labelNoMCQ.Size = new System.Drawing.Size(278, 23);
            this.labelNoMCQ.TabIndex = 6;
            this.labelNoMCQ.Text = "Number of MCQ Questions:";
            // 
            // comboBoxMCQ
            // 
            this.comboBoxMCQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMCQ.FormattingEnabled = true;
            this.comboBoxMCQ.Location = new System.Drawing.Point(823, 35);
            this.comboBoxMCQ.Name = "comboBoxMCQ";
            this.comboBoxMCQ.Size = new System.Drawing.Size(73, 24);
            this.comboBoxMCQ.TabIndex = 7;
            this.comboBoxMCQ.SelectedIndexChanged += new System.EventHandler(this.comboBoxMCQ_SelectedIndexChanged);
            // 
            // lblNoTF
            // 
            this.lblNoTF.AutoSize = true;
            this.lblNoTF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblNoTF.Location = new System.Drawing.Point(527, 79);
            this.lblNoTF.Name = "lblNoTF";
            this.lblNoTF.Size = new System.Drawing.Size(254, 23);
            this.lblNoTF.TabIndex = 8;
            this.lblNoTF.Text = "Number of T/F Questions:";
            this.lblNoTF.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxTF
            // 
            this.comboBoxTF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTF.FormattingEnabled = true;
            this.comboBoxTF.Location = new System.Drawing.Point(823, 82);
            this.comboBoxTF.Name = "comboBoxTF";
            this.comboBoxTF.Size = new System.Drawing.Size(73, 24);
            this.comboBoxTF.TabIndex = 9;
            this.comboBoxTF.SelectedIndexChanged += new System.EventHandler(this.comboBoxTF_SelectedIndexChanged);
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblTrial.Location = new System.Drawing.Point(527, 125);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(143, 23);
            this.lblTrial.TabIndex = 10;
            this.lblTrial.Text = "Trial Number :";
            // 
            // comboBoxTrial
            // 
            this.comboBoxTrial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrial.FormattingEnabled = true;
            this.comboBoxTrial.Location = new System.Drawing.Point(823, 128);
            this.comboBoxTrial.Name = "comboBoxTrial";
            this.comboBoxTrial.Size = new System.Drawing.Size(73, 24);
            this.comboBoxTrial.TabIndex = 11;
            this.comboBoxTrial.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrial_SelectedIndexChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.Green;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.ForeColor = System.Drawing.Color.White;
            this.buttonGenerate.Location = new System.Drawing.Point(936, 55);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(112, 70);
            this.buttonGenerate.TabIndex = 12;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            // 
            // ListItemExamGeneration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.comboBoxTrial);
            this.Controls.Add(this.lblTrial);
            this.Controls.Add(this.comboBoxTF);
            this.Controls.Add(this.lblNoTF);
            this.Controls.Add(this.comboBoxMCQ);
            this.Controls.Add(this.labelNoMCQ);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTpName);
            this.Controls.Add(this.textBoxCrsName);
            this.Controls.Add(this.lblCrsName);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListItemExamGeneration";
            this.Size = new System.Drawing.Size(1095, 183);
            this.Load += new System.EventHandler(this.ListItemExamGeneration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCrsName;
        private System.Windows.Forms.TextBox textBoxCrsName;
        private System.Windows.Forms.Label lblTpName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelNoMCQ;
        private System.Windows.Forms.ComboBox comboBoxMCQ;
        private System.Windows.Forms.Label lblNoTF;
        private System.Windows.Forms.ComboBox comboBoxTF;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.ComboBox comboBoxTrial;
        private System.Windows.Forms.Button buttonGenerate;
    }
}
