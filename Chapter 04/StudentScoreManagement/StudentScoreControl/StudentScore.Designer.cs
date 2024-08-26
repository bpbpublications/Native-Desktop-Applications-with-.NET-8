namespace StudentScoreControl
{
    partial class StudentScore
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
            lblTitle = new Label();
            lblMaths = new Label();
            lblPhysics = new Label();
            lblComputerScience = new Label();
            lblChemistory = new Label();
            txtMaths = new TextBox();
            txtPhysics = new TextBox();
            txtChemistory = new TextBox();
            txtComputerScience = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(26, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Selected Student:";
            // 
            // lblMaths
            // 
            lblMaths.AutoSize = true;
            lblMaths.Location = new Point(26, 73);
            lblMaths.Name = "lblMaths";
            lblMaths.Size = new Size(40, 15);
            lblMaths.TabIndex = 1;
            lblMaths.Text = "Maths";
            // 
            // lblPhysics
            // 
            lblPhysics.AutoSize = true;
            lblPhysics.Location = new Point(163, 73);
            lblPhysics.Name = "lblPhysics";
            lblPhysics.Size = new Size(46, 15);
            lblPhysics.TabIndex = 2;
            lblPhysics.Text = "Physics";
            // 
            // lblComputerScience
            // 
            lblComputerScience.AutoSize = true;
            lblComputerScience.Location = new Point(163, 149);
            lblComputerScience.Name = "lblComputerScience";
            lblComputerScience.Size = new Size(104, 15);
            lblComputerScience.TabIndex = 4;
            lblComputerScience.Text = "Computer Science";
            // 
            // lblChemistory
            // 
            lblChemistory.AutoSize = true;
            lblChemistory.Location = new Point(26, 149);
            lblChemistory.Name = "lblChemistory";
            lblChemistory.Size = new Size(68, 15);
            lblChemistory.TabIndex = 3;
            lblChemistory.Text = "Chemistory";
            // 
            // txtMaths
            // 
            txtMaths.Location = new Point(26, 91);
            txtMaths.Name = "txtMaths";
            txtMaths.Size = new Size(68, 23);
            txtMaths.TabIndex = 5;
            txtMaths.TextChanged += txtMaths_TextChanged;
            // 
            // txtPhysics
            // 
            txtPhysics.Location = new Point(163, 91);
            txtPhysics.Name = "txtPhysics";
            txtPhysics.Size = new Size(68, 23);
            txtPhysics.TabIndex = 6;
            txtPhysics.TextChanged += txtPhysics_TextChanged;
            // 
            // txtChemistory
            // 
            txtChemistory.Location = new Point(26, 167);
            txtChemistory.Name = "txtChemistory";
            txtChemistory.Size = new Size(68, 23);
            txtChemistory.TabIndex = 7;
            txtChemistory.TextChanged += txtChemistory_TextChanged;
            // 
            // txtComputerScience
            // 
            txtComputerScience.Location = new Point(163, 167);
            txtComputerScience.Name = "txtComputerScience";
            txtComputerScience.Size = new Size(68, 23);
            txtComputerScience.TabIndex = 8;
            txtComputerScience.TextChanged += txtComputerScience_TextChanged;
            // 
            // StudentScore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtComputerScience);
            Controls.Add(txtChemistory);
            Controls.Add(txtPhysics);
            Controls.Add(txtMaths);
            Controls.Add(lblComputerScience);
            Controls.Add(lblChemistory);
            Controls.Add(lblPhysics);
            Controls.Add(lblMaths);
            Controls.Add(lblTitle);
            Name = "StudentScore";
            Size = new Size(349, 224);
            Load += StudentScore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMaths;
        private Label lblPhysics;
        private Label lblComputerScience;
        private Label lblChemistory;
        private TextBox txtMaths;
        private TextBox txtPhysics;
        private TextBox txtChemistory;
        private TextBox txtComputerScience;
    }
}