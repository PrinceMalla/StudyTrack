using StudyTrack.Models;

namespace StudyTrack
{
    public partial class MainForm : Form
    {
        private List<Subject> subjects = new List<Subject>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string name = TxtSubjectName.Text.Trim();
            string code = txtSubjectCode.Text.Trim();

            if (name == "" || code == "")
            {
                MessageBox.Show(
                    "Please enter both the subject name and subject code.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Subject newSubject = new Subject
            {
                SubjectId = subjects.Count + 1,
                Name = name,
                Code = code,
                ColourTag = "#4CAF50"
            };

            subjects.Add(newSubject);

            LstSubjects.Items.Add(
                newSubject.Code + " - " + newSubject.Name
            );

            TxtSubjectName.Clear();
            txtSubjectCode.Clear();

            MessageBox.Show(
                "Subject added successfully.",
                "StudyTrack",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}