using System.ComponentModel.Design;
using System.ComponentModel;

namespace StudentScoreControl
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class StudentScore : UserControl
    {
        public StudentScore()
        {
            InitializeComponent();
        }

        private Student _student;

        public Student SelectedStudent
        {
            get => _student ?? new();
            set
            {
                _student = value;
                LoadFieldData();
            }
        }

        private void StudentScore_Load(object sender, EventArgs e)
        {
            txtMaths.KeyPress += Validate_KeyPress;
            txtPhysics.KeyPress += Validate_KeyPress;
            txtChemistory.KeyPress += Validate_KeyPress;
            txtComputerScience.KeyPress += Validate_KeyPress;
        }

        private void LoadFieldData()
        {
            if (SelectedStudent?.StudentId > 0)
            {
                lblTitle.Text = $"Selected Student: {SelectedStudent.StudentName}";
                txtMaths.Text = SelectedStudent.MathsScore.ToString();
                txtPhysics.Text = SelectedStudent.PhysicsScore.ToString();
                txtChemistory.Text = SelectedStudent.ChemistoryScore.ToString();
                txtComputerScience.Text = SelectedStudent.ComputerScienceScore.ToString();
            }
        }

        private void Validate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) //Make sure the entered key is a number (0-9) or backspace
            {
                // Tell the text box that the key press event was handled, do not process it
                e.Handled = true;
            }
        }

        private void txtMaths_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txtMaths.Text, out int mathsScore))
                SelectedStudent.MathsScore = mathsScore;
        }

        private void txtPhysics_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtPhysics.Text, out int physicsScore))
                SelectedStudent.PhysicsScore = physicsScore;
        }

        private void txtChemistory_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtChemistory.Text, out int chemistoryScore))
                SelectedStudent.ChemistoryScore = chemistoryScore;
        }

        private void txtComputerScience_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtComputerScience.Text, out int computerScienceScore))
                SelectedStudent.ComputerScienceScore = computerScienceScore;
        }
    }
}