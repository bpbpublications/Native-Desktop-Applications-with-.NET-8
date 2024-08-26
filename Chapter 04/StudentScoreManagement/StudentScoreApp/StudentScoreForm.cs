using StudentScoreControl;

namespace StudentScoreApp
{
    public partial class StudentScoreForm : Form
    {
        public StudentScoreForm()
        {
            InitializeComponent();
        }

        private List<Student> _students;
        public List<Student> Students
        {
            get
            {

                if (_students?.Count > 0) return _students;

                _students = GetStudentsFromDataStore();
                return _students;
            }
        }

        private void StudentScoreForm_Load(object sender, EventArgs e)
        {
            lbStudents.DataSource = Students;
            lbStudents.DisplayMember = "StudentName";
            lbStudents.ValueMember = "StudentId";
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItem != null)
            {
                studentScore.SelectedStudent = (Student)lbStudents.SelectedItem;
            }
        }

        private List<Student> GetStudentsFromDataStore()
        {
            List<Student> students = new();

            students.Add(new Student() { StudentId = 1, StudentName = "Sai", MathsScore = 90, PhysicsScore = 80, ChemistoryScore = 45, ComputerScienceScore = 60 });
            students.Add(new Student() { StudentId = 1, StudentName = "Santosh", MathsScore = 89, PhysicsScore = 60, ChemistoryScore = 95, ComputerScienceScore = 90 });

            return students;
        }

        private void btnUpdateScore_Click(object sender, EventArgs e)
        {
            string message = $"Updated Score for Student {studentScore.SelectedStudent.StudentName}; " +
                $"with values Maths({studentScore.SelectedStudent.MathsScore}) Physics({studentScore.SelectedStudent.PhysicsScore}) " +
                $"Chemistory({studentScore.SelectedStudent.ChemistoryScore}) Computer Science({studentScore.SelectedStudent.ComputerScienceScore})";

            MessageBox.Show(message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}