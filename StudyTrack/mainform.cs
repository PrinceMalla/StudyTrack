using StudyTrack.Models;
using StudyTask = StudyTrack.Models.Task;

namespace StudyTrack
{
    public partial class MainForm : Form
    {
        private List<Subject> subjects = new List<Subject>();
        private List<StudyTask> tasks = new List<StudyTask>();

        public MainForm()
        {
            InitializeComponent();

            CmbPriority.Items.Add("Low");
            CmbPriority.Items.Add("Medium");
            CmbPriority.Items.Add("High");

            CmbPriority.SelectedIndex = 1;
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

            CmbTaskSubject.Items.Add(
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

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            string title = TxtTaskTitle.Text.Trim();

            if (title == "")
            {
                MessageBox.Show(
                    "Please enter a task title.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (CmbTaskSubject.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a subject.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Subject selectedSubject =
                subjects[CmbTaskSubject.SelectedIndex];

            StudyTask newTask = new StudyTask
            {
                TaskId = tasks.Count + 1,
                Title = title,
                SubjectId = selectedSubject.SubjectId,
                DueDate = DtpDueDate.Value,
                Priority = CmbPriority.Text,
                TaskType = "Other",
                IsComplete = false,
                Notes = ""
            };

            tasks.Add(newTask);

            LstTasks.Items.Add(
                newTask.Title +
                " - " +
                selectedSubject.Code +
                " - Due: " +
                newTask.DueDate.ToShortDateString() +
                " - " +
                newTask.Priority
            );

            TxtTaskTitle.Clear();

            MessageBox.Show(
                "Task added successfully.",
                "StudyTrack",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}