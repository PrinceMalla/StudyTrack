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
            string name = txtSubjectName.Text.Trim();
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

            Subject newSubject = new Subject();

            newSubject.SubjectId = subjects.Count + 1;
            newSubject.Name = name;
            newSubject.Code = code;
            newSubject.ColourTag = "#4CAF50";

            subjects.Add(newSubject);

            lstSubjects.Items.Add(
                newSubject.Code + " - " + newSubject.Name
            );

            txtSubjectName.Clear();
            txtSubjectCode.Clear();

            MessageBox.Show(
                "Subject added successfully.",
                "StudyTrack"
            );
        }
    }
}