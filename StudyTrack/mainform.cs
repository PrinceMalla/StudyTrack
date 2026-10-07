using StudyTrack.Models;
using StudyTask = StudyTrack.Models.Task;

namespace StudyTrack
{
    public partial class MainForm : Form
    {
        private List<Subject> subjects = new List<Subject>();
        private List<StudyTask> tasks = new List<StudyTask>();

        private JsonStorageService storageService = new JsonStorageService();

        public MainForm()
        {
            InitializeComponent();

            CmbPriority.Items.Add("Low");
            CmbPriority.Items.Add("Medium");
            CmbPriority.Items.Add("High");

            CmbPriority.SelectedIndex = 1;

            CmbTaskType.Items.Add("Assignment");
            CmbTaskType.Items.Add("Quiz");
            CmbTaskType.Items.Add("Exam");
            CmbTaskType.Items.Add("Reading");
            CmbTaskType.Items.Add("Other");

            CmbTaskType.SelectedIndex = 0;

            LoadData();

            LstTasks.DoubleClick += LstTasks_DoubleClick;
        }

        private void LoadData()
        {
            subjects = storageService.LoadSubjects();
            tasks = storageService.LoadTasks();

            RefreshSubjects();
            RefreshTasks();
        }

        private void RefreshSubjects()
        {
            LstSubjects.Items.Clear();
            CmbTaskSubject.Items.Clear();

            foreach (Subject subject in subjects)
            {
                string subjectDisplay =
                    subject.Code + " - " + subject.Name;

                LstSubjects.Items.Add(subjectDisplay);
                CmbTaskSubject.Items.Add(subjectDisplay);
            }
        }

        private void RefreshTasks()
        {
            LstTasks.Items.Clear();

            foreach (StudyTask task in tasks)
            {
                Subject? subject = subjects.FirstOrDefault(
                    s => s.SubjectId == task.SubjectId
                );

                string subjectCode = "Unknown";

                if (subject != null)
                {
                    subjectCode = subject.Code;
                }

                StudyTaskBase taskObject = CreateTaskObject(task);

                string completedText = "";

                if (task.IsComplete)
                {
                    completedText = " - [Completed]";
                }

                LstTasks.Items.Add(
                    taskObject.GetTaskDescription() +
                    " - " +
                    subjectCode +
                    " - Due: " +
                    task.DueDate.ToShortDateString() +
                    " - " +
                    task.Priority +
                    completedText
                );
            }
        }

        private StudyTaskBase CreateTaskObject(StudyTask task)
        {
            StudyTaskBase taskObject;

            switch (task.TaskType)
            {
                case "Assignment":
                    taskObject = new AssignmentTask();
                    break;

                case "Quiz":
                    taskObject = new QuizTask();
                    break;

                case "Exam":
                    taskObject = new ExamTask();
                    break;

                case "Reading":
                    taskObject = new ReadingTask();
                    break;

                default:
                    taskObject = task;
                    break;
            }

            taskObject.TaskId = task.TaskId;
            taskObject.Title = task.Title;
            taskObject.SubjectId = task.SubjectId;
            taskObject.DueDate = task.DueDate;
            taskObject.Priority = task.Priority;
            taskObject.IsComplete = task.IsComplete;
            taskObject.Notes = task.Notes;

            return taskObject;
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

            RefreshSubjects();

            storageService.SaveSubjects(subjects);

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

            if (CmbTaskType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a task type.",
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
                TaskType = CmbTaskType.Text,
                IsComplete = false,
                Notes = ""
            };

            tasks.Add(newTask);

            RefreshTasks();

            storageService.SaveTasks(tasks);

            TxtTaskTitle.Clear();

            MessageBox.Show(
                "Task added successfully.",
                "StudyTrack",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void LstTasks_DoubleClick(object? sender, EventArgs e)
        {
            if (LstTasks.SelectedIndex == -1)
            {
                return;
            }

            int selectedTaskIndex = LstTasks.SelectedIndex;

            if (selectedTaskIndex >= tasks.Count)
            {
                return;
            }

            StudyTask selectedTask = tasks[selectedTaskIndex];

            selectedTask.IsComplete = !selectedTask.IsComplete;

            storageService.SaveTasks(tasks);

            RefreshTasks();
        }
    }
}