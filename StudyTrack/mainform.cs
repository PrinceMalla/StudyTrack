using StudyTrack.Models;
using StudyTask = StudyTrack.Models.Task;

namespace StudyTrack
{
    public partial class MainForm : Form
    {
        private List<Subject> subjects = new List<Subject>();
        private List<StudyTask> tasks = new List<StudyTask>();

        private JsonStorageService storageService =
            new JsonStorageService();

        public MainForm()
        {
            InitializeComponent();

            SetupControls();
            ApplyProfessionalStyle();
            ArrangeLayout();
            LoadData();

            LstTasks.DoubleClick += LstTasks_DoubleClick;
            LstSubjects.SelectedIndexChanged += LstSubjects_SelectedIndexChanged;
        }

        private void SetupControls()
        {
            CmbPriority.Items.Clear();
            CmbPriority.Items.Add("Low");
            CmbPriority.Items.Add("Medium");
            CmbPriority.Items.Add("High");
            CmbPriority.SelectedIndex = 1;

            CmbTaskType.Items.Clear();
            CmbTaskType.Items.Add("Assignment");
            CmbTaskType.Items.Add("Quiz");
            CmbTaskType.Items.Add("Exam");
            CmbTaskType.Items.Add("Reading");
            CmbTaskType.Items.Add("Other");
            CmbTaskType.SelectedIndex = 0;

            CmbTaskSubject.Enabled = true;
            CmbTaskSubject.Visible = true;
            CmbTaskSubject.DropDownStyle = ComboBoxStyle.DropDownList;

            DtpDueDate.MinDate = DateTime.Today;
        }

        private void ApplyProfessionalStyle()
        {
            Text = "StudyTrack - Academic Planner";
            StartPosition = FormStartPosition.CenterScreen;

            ClientSize = new Size(1000, 650);
            MinimumSize = new Size(1000, 650);
            MaximumSize = new Size(1000, 650);

            BackColor = Color.FromArgb(244, 247, 250);
            Font = new Font("Segoe UI", 10F);

            StyleLabel(LblSubjectName);
            StyleLabel(LblSubjectCode);
            StyleLabel(LblTaskTitle);
            StyleLabel(LblTaskSubject);
            StyleLabel(LblDueDate);
            StyleLabel(LblPriority);
            StyleLabel(label1);

            StyleTextBox(TxtSubjectName);
            StyleTextBox(txtSubjectCode);
            StyleTextBox(TxtTaskTitle);

            StyleComboBox(CmbTaskSubject);
            StyleComboBox(CmbPriority);
            StyleComboBox(CmbTaskType);

            DtpDueDate.Font = new Font("Segoe UI", 10F);
            DtpDueDate.BackColor = Color.White;

            StyleListBox(LstSubjects);
            StyleListBox(LstTasks);

            StyleButton(btnAddSubject);
            StyleButton(BtnAddTask);
            StyleButton(BtnMarkComplete);
            StyleButton(BtnDeleteTask);

            btnAddSubject.Text = "Add Subject";
            BtnAddTask.Text = "Add Task";
            BtnMarkComplete.Text = "Mark Complete";
            BtnDeleteTask.Text = "Delete";
        }

        private void ArrangeLayout()
        {
            LblSubjectName.Location = new Point(40, 105);
            LblSubjectName.Size = new Size(130, 25);

            TxtSubjectName.Location = new Point(40, 132);
            TxtSubjectName.Size = new Size(300, 30);

            LblSubjectCode.Location = new Point(40, 172);
            LblSubjectCode.Size = new Size(130, 25);

            txtSubjectCode.Location = new Point(40, 199);
            txtSubjectCode.Size = new Size(300, 30);

            btnAddSubject.Location = new Point(40, 242);
            btnAddSubject.Size = new Size(145, 40);

            LblTaskTitle.Location = new Point(390, 105);
            LblTaskTitle.Size = new Size(120, 25);

            TxtTaskTitle.Location = new Point(390, 132);
            TxtTaskTitle.Size = new Size(280, 30);

            LblTaskSubject.Location = new Point(690, 105);
            LblTaskSubject.Size = new Size(120, 25);

            CmbTaskSubject.Location = new Point(690, 132);
            CmbTaskSubject.Size = new Size(270, 30);

            LblDueDate.Location = new Point(390, 172);
            LblDueDate.Size = new Size(120, 25);

            DtpDueDate.Location = new Point(390, 199);
            DtpDueDate.Size = new Size(180, 30);

            LblPriority.Location = new Point(590, 172);
            LblPriority.Size = new Size(100, 25);

            CmbPriority.Location = new Point(590, 199);
            CmbPriority.Size = new Size(150, 30);

            label1.Location = new Point(760, 172);
            label1.Size = new Size(100, 25);

            CmbTaskType.Location = new Point(760, 199);
            CmbTaskType.Size = new Size(200, 30);

            BtnAddTask.Location = new Point(390, 242);
            BtnAddTask.Size = new Size(145, 40);

            LstSubjects.Location = new Point(40, 345);
            LstSubjects.Size = new Size(300, 235);

            LstTasks.Location = new Point(390, 345);
            LstTasks.Size = new Size(570, 190);

            BtnMarkComplete.Location = new Point(390, 550);
            BtnMarkComplete.Size = new Size(170, 40);

            BtnDeleteTask.Location = new Point(575, 550);
            BtnDeleteTask.Size = new Size(120, 40);

            CmbTaskSubject.BringToFront();
            LstSubjects.BringToFront();
        }

        private void AddTitleLabels()
        {
            Label titleLabel = new Label
            {
                Name = "lblStudyTrackTitle",
                Text = "StudyTrack",
                AutoSize = true,
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.FromArgb(22, 58, 95),
                BackColor = Color.Transparent,
                Location = new Point(40, 20)
            };

            Controls.Add(titleLabel);
            titleLabel.BringToFront();

            Label subtitleLabel = new Label
            {
                Name = "lblStudyTrackSubtitle",
                Text = "Your simple academic planner",
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(90, 105, 120),
                BackColor = Color.Transparent,
                Location = new Point(43, 60)
            };

            Controls.Add(subtitleLabel);
            subtitleLabel.BringToFront();

            Label subjectsHeader = new Label
            {
                Text = "SUBJECTS",
                AutoSize = true,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(22, 58, 95),
                Location = new Point(40, 310)
            };

            Controls.Add(subjectsHeader);
            subjectsHeader.BringToFront();

            Label tasksHeader = new Label
            {
                Text = "MY TASKS",
                AutoSize = true,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(22, 58, 95),
                Location = new Point(390, 310)
            };

            Controls.Add(tasksHeader);
            tasksHeader.BringToFront();
        }

        private void StyleLabel(Label label)
        {
            label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(40, 55, 70);
            label.BackColor = Color.Transparent;
        }

        private void StyleTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Segoe UI", 10F);
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.FromArgb(35, 45, 55);
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void StyleComboBox(ComboBox comboBox)
        {
            comboBox.Font = new Font("Segoe UI", 10F);
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = Color.FromArgb(35, 45, 55);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Enabled = true;
        }

        private void StyleListBox(ListBox listBox)
        {
            listBox.Font = new Font("Segoe UI", 10F);
            listBox.BackColor = Color.White;
            listBox.ForeColor = Color.FromArgb(35, 45, 55);
            listBox.BorderStyle = BorderStyle.FixedSingle;
            listBox.Enabled = true;
        }

        private void StyleButton(Button button)
        {
            button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button.BackColor = Color.FromArgb(25, 118, 140);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(21, 101, 116);
            button.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(18, 87, 100);
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
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

            CmbTaskSubject.SelectedIndex = -1;
            CmbTaskSubject.Enabled = true;
            LstSubjects.Enabled = true;
        }

        private void LstSubjects_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            if (LstSubjects.SelectedIndex >= 0 &&
                LstSubjects.SelectedIndex < subjects.Count)
            {
                CmbTaskSubject.SelectedIndex =
                    LstSubjects.SelectedIndex;
            }
        }

        private void RefreshTasks()
        {
            LstTasks.Items.Clear();

            foreach (StudyTask task in tasks)
            {
                Subject? subject =
                    subjects.FirstOrDefault(
                        s => s.SubjectId == task.SubjectId);

                string subjectCode = "Unknown";

                if (subject != null)
                {
                    subjectCode = subject.Code;
                }

                StudyTaskBase taskObject =
                    CreateTaskObject(task);

                string completedText = "";

                if (task.IsComplete)
                {
                    completedText = " - [Completed]";
                }

                LstTasks.Items.Add(
                    taskObject.GetTaskDescription()
                    + " - "
                    + subjectCode
                    + " - Due: "
                    + task.DueDate.ToShortDateString()
                    + " - "
                    + task.Priority
                    + completedText
                );
            }
        }

        private StudyTaskBase CreateTaskObject(
            StudyTask task)
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

        private void btnAddSubject_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string name = TxtSubjectName.Text.Trim();
                string code = txtSubjectCode.Text.Trim();

                if (name == "")
                {
                    throw new Exception(
                        "Please enter a subject name.");
                }

                if (code == "")
                {
                    throw new Exception(
                        "Please enter a subject code.");
                }

                bool duplicateCode =
                    subjects.Any(
                        s => s.Code.Equals(
                            code,
                            StringComparison.OrdinalIgnoreCase));

                if (duplicateCode)
                {
                    throw new Exception(
                        "A subject with this code already exists.");
                }

                Subject newSubject =
                    new Subject
                    {
                        SubjectId = subjects.Count + 1,
                        Name = name,
                        Code = code,
                        ColourTag = "#4CAF50"
                    };

                subjects.Add(newSubject);

                storageService.SaveSubjects(subjects);

                RefreshSubjects();

                TxtSubjectName.Clear();
                txtSubjectCode.Clear();

                MessageBox.Show(
                    "Subject added successfully.",
                    "StudyTrack",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void BtnAddTask_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string title =
                    TxtTaskTitle.Text.Trim();

                if (title == "")
                {
                    throw new Exception(
                        "Please enter a task title.");
                }

                if (CmbTaskSubject.SelectedIndex == -1)
                {
                    throw new Exception(
                        "Please select a subject.");
                }

                if (CmbTaskType.SelectedIndex == -1)
                {
                    throw new Exception(
                        "Please select a task type.");
                }

                if (DtpDueDate.Value.Date <
                    DateTime.Today)
                {
                    throw new Exception(
                        "The due date cannot be in the past.");
                }

                Subject selectedSubject =
                    subjects[CmbTaskSubject.SelectedIndex];

                StudyTask newTask =
                    new StudyTask
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

                storageService.SaveTasks(tasks);

                RefreshTasks();

                TxtTaskTitle.Clear();

                MessageBox.Show(
                    "Task added successfully.",
                    "StudyTrack",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void BtnMarkComplete_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (LstTasks.SelectedIndex == -1)
                {
                    throw new Exception(
                        "Please select a task from My Tasks first.");
                }

                int selectedTaskIndex =
                    LstTasks.SelectedIndex;

                if (selectedTaskIndex >= tasks.Count)
                {
                    return;
                }

                StudyTask selectedTask =
                    tasks[selectedTaskIndex];

                selectedTask.IsComplete =
                    !selectedTask.IsComplete;

                storageService.SaveTasks(tasks);

                RefreshTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Task Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void BtnDeleteTask_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (LstTasks.SelectedIndex == -1)
                {
                    throw new Exception(
                        "Please select a task from My Tasks first.");
                }

                int selectedTaskIndex =
                    LstTasks.SelectedIndex;

                if (selectedTaskIndex >= tasks.Count)
                {
                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete this task?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (result == DialogResult.Yes)
                {
                    tasks.RemoveAt(selectedTaskIndex);

                    storageService.SaveTasks(tasks);

                    RefreshTasks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void LstTasks_DoubleClick(
            object? sender,
            EventArgs e)
        {
            BtnMarkComplete_Click(sender, e);
        }

        private void MainForm_Load(
            object sender,
            EventArgs e)
        {
        }
    }
}