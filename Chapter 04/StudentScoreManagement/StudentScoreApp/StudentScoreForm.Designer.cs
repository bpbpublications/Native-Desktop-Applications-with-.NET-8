namespace StudentScoreApp
{
    partial class StudentScoreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUpdateScore = new Button();
            label2 = new Label();
            studentScore = new StudentScoreControl.StudentScore();
            label1 = new Label();
            lbStudents = new ListBox();
            SuspendLayout();
            // 
            // btnUpdateScore
            // 
            btnUpdateScore.Location = new Point(230, 307);
            btnUpdateScore.Name = "btnUpdateScore";
            btnUpdateScore.Size = new Size(101, 23);
            btnUpdateScore.TabIndex = 9;
            btnUpdateScore.Text = "Update Score";
            btnUpdateScore.UseVisualStyleBackColor = true;
            btnUpdateScore.Click += btnUpdateScore_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(175, 9);
            label2.Name = "label2";
            label2.Size = new Size(269, 25);
            label2.TabIndex = 8;
            label2.Text = "Students Score Management";
            // 
            // studentScore
            // 
            studentScore.BackColor = SystemColors.GradientInactiveCaption;
            studentScore.Location = new Point(279, 68);
            studentScore.Name = "studentScore";
            studentScore.SelectedStudent = null;
            studentScore.Size = new Size(349, 224);
            studentScore.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 53);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 6;
            label1.Text = "Students";
            // 
            // lbStudents
            // 
            lbStudents.FormattingEnabled = true;
            lbStudents.ItemHeight = 15;
            lbStudents.Location = new Point(19, 75);
            lbStudents.Name = "lbStudents";
            lbStudents.Size = new Size(227, 214);
            lbStudents.TabIndex = 5;
            lbStudents.SelectedIndexChanged += lbStudents_SelectedIndexChanged;
            // 
            // StudentScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 348);
            Controls.Add(btnUpdateScore);
            Controls.Add(label2);
            Controls.Add(studentScore);
            Controls.Add(label1);
            Controls.Add(lbStudents);
            Name = "StudentScoreForm";
            Text = "Form1";
            Load += StudentScoreForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateScore;
        private Label label2;
        private StudentScoreControl.StudentScore studentScore;
        private Label label1;
        private ListBox lbStudents;
    }
}