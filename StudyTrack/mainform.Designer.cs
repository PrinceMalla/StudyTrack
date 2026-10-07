namespace StudyTrack
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null;
       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            LblSubjectName = new Label();
            TxtSubjectName = new TextBox();
            txtSubjectCode = new TextBox();
            LblSubjectCode = new Label();
            btnAddSubject = new Button();
            LstSubjects = new ListBox();
            LblTaskTitle = new Label();
            LblTaskSubject = new Label();
            CmbTaskSubject = new ComboBox();
            LblDueDate = new Label();
            LblPriority = new Label();
            CmbPriority = new ComboBox();
            BtnAddTask = new Button();
            LstTasks = new ListBox();
            TxtTaskTitle = new TextBox();
            DtpDueDate = new DateTimePicker();
            CmbTaskType = new ComboBox();
            label1 = new Label();
            BtnMarkComplete = new Button();
            BtnDeleteTask = new Button();
            SuspendLayout();
            // 
            // LblSubjectName
            // 
            LblSubjectName.AutoSize = true;
            LblSubjectName.Location = new Point(25, 31);
            LblSubjectName.Name = "LblSubjectName";
            LblSubjectName.Size = new Size(81, 15);
            LblSubjectName.TabIndex = 0;
            LblSubjectName.Text = "Subject Name";
            // 
            // TxtSubjectName
            // 
            TxtSubjectName.Location = new Point(25, 49);
            TxtSubjectName.Name = "TxtSubjectName";
            TxtSubjectName.Size = new Size(93, 23);
            TxtSubjectName.TabIndex = 1;
            // 
            // txtSubjectCode
            // 
            txtSubjectCode.Location = new Point(25, 115);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.Size = new Size(120, 23);
            txtSubjectCode.TabIndex = 3;
            // 
            // LblSubjectCode
            // 
            LblSubjectCode.AutoSize = true;
            LblSubjectCode.Location = new Point(29, 89);
            LblSubjectCode.Name = "LblSubjectCode";
            LblSubjectCode.Size = new Size(77, 15);
            LblSubjectCode.TabIndex = 2;
            LblSubjectCode.Text = "Subject Code";
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(29, 187);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(120, 30);
            btnAddSubject.TabIndex = 4;
            btnAddSubject.Text = "Add Subject";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // LstSubjects
            // 
            LstSubjects.FormattingEnabled = true;
            LstSubjects.Location = new Point(29, 251);
            LstSubjects.Name = "LstSubjects";
            LstSubjects.Size = new Size(370, 109);
            LstSubjects.TabIndex = 5;
            // 
            // LblTaskTitle
            // 
            LblTaskTitle.AutoSize = true;
            LblTaskTitle.Location = new Point(177, 31);
            LblTaskTitle.Name = "LblTaskTitle";
            LblTaskTitle.Size = new Size(56, 15);
            LblTaskTitle.TabIndex = 6;
            LblTaskTitle.Text = "Task Title";
            // 
            // LblTaskSubject
            // 
            LblTaskSubject.AutoSize = true;
            LblTaskSubject.Location = new Point(402, 31);
            LblTaskSubject.Name = "LblTaskSubject";
            LblTaskSubject.Size = new Size(46, 15);
            LblTaskSubject.TabIndex = 7;
            LblTaskSubject.Text = "Subject";
            // 
            // CmbTaskSubject
            // 
            CmbTaskSubject.FormattingEnabled = true;
            CmbTaskSubject.Location = new Point(316, 49);
            CmbTaskSubject.Name = "CmbTaskSubject";
            CmbTaskSubject.Size = new Size(121, 23);
            CmbTaskSubject.TabIndex = 8;
            // 
            // LblDueDate
            // 
            LblDueDate.AutoSize = true;
            LblDueDate.Location = new Point(214, 89);
            LblDueDate.Name = "LblDueDate";
            LblDueDate.Size = new Size(55, 15);
            LblDueDate.TabIndex = 9;
            LblDueDate.Text = "Due Date";
            // 
            // LblPriority
            // 
            LblPriority.AutoSize = true;
            LblPriority.Location = new Point(519, 89);
            LblPriority.Name = "LblPriority";
            LblPriority.Size = new Size(45, 15);
            LblPriority.TabIndex = 10;
            LblPriority.Text = "Priority";
            // 
            // CmbPriority
            // 
            CmbPriority.FormattingEnabled = true;
            CmbPriority.Location = new Point(470, 115);
            CmbPriority.Name = "CmbPriority";
            CmbPriority.Size = new Size(121, 23);
            CmbPriority.TabIndex = 11;
            // 
            // BtnAddTask
            // 
            BtnAddTask.Location = new Point(619, 194);
            BtnAddTask.Name = "BtnAddTask";
            BtnAddTask.Size = new Size(75, 23);
            BtnAddTask.TabIndex = 12;
            BtnAddTask.Text = "Add Task";
            BtnAddTask.UseVisualStyleBackColor = true;
            BtnAddTask.Click += BtnAddTask_Click;
            // 
            // LstTasks
            // 
            LstTasks.FormattingEnabled = true;
            LstTasks.Location = new Point(470, 251);
            LstTasks.Name = "LstTasks";
            LstTasks.Size = new Size(472, 94);
            LstTasks.TabIndex = 13;
            // 
            // TxtTaskTitle
            // 
            TxtTaskTitle.Location = new Point(158, 49);
            TxtTaskTitle.Name = "TxtTaskTitle";
            TxtTaskTitle.Size = new Size(100, 23);
            TxtTaskTitle.TabIndex = 14;
            // 
            // DtpDueDate
            // 
            DtpDueDate.Location = new Point(168, 115);
            DtpDueDate.Name = "DtpDueDate";
            DtpDueDate.Size = new Size(200, 23);
            DtpDueDate.TabIndex = 15;
            // 
            // CmbTaskType
            // 
            CmbTaskType.FormattingEnabled = true;
            CmbTaskType.Location = new Point(698, 115);
            CmbTaskType.Name = "CmbTaskType";
            CmbTaskType.Size = new Size(121, 23);
            CmbTaskType.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(749, 89);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 17;
            label1.Text = "Task Type";
            // 
            // BtnMarkComplete
            // 
            BtnMarkComplete.Location = new Point(470, 392);
            BtnMarkComplete.Name = "BtnMarkComplete";
            BtnMarkComplete.Size = new Size(75, 23);
            BtnMarkComplete.TabIndex = 18;
            BtnMarkComplete.Text = "Mark Complete";
            BtnMarkComplete.UseVisualStyleBackColor = true;
            BtnMarkComplete.Click += BtnMarkComplete_Click;
            // 
            // BtnDeleteTask
            // 
            BtnDeleteTask.Location = new Point(652, 392);
            BtnDeleteTask.Name = "BtnDeleteTask";
            BtnDeleteTask.Size = new Size(75, 23);
            BtnDeleteTask.TabIndex = 19;
            BtnDeleteTask.Text = "Delete";
            BtnDeleteTask.UseVisualStyleBackColor = true;
            BtnDeleteTask.Click += BtnDeleteTask_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(984, 611);
            Controls.Add(BtnDeleteTask);
            Controls.Add(BtnMarkComplete);
            Controls.Add(label1);
            Controls.Add(CmbTaskType);
            Controls.Add(DtpDueDate);
            Controls.Add(TxtTaskTitle);
            Controls.Add(LstTasks);
            Controls.Add(BtnAddTask);
            Controls.Add(CmbPriority);
            Controls.Add(LblPriority);
            Controls.Add(LblDueDate);
            Controls.Add(CmbTaskSubject);
            Controls.Add(LblTaskSubject);
            Controls.Add(LblTaskTitle);
            Controls.Add(LstSubjects);
            Controls.Add(btnAddSubject);
            Controls.Add(txtSubjectCode);
            Controls.Add(LblSubjectCode);
            Controls.Add(TxtSubjectName);
            Controls.Add(LblSubjectName);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudyTrack - Academic Planner";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSubjectName;
        private TextBox TxtSubjectName;
        private TextBox txtSubjectCode;
        private Label LblSubjectCode;
        private Button btnAddSubject;
        private ListBox LstSubjects;
        private Label LblTaskTitle;
        private Label LblTaskSubject;
        private ComboBox CmbTaskSubject;
        private Label LblDueDate;
        private Label LblPriority;
        private ComboBox CmbPriority;
        private Button BtnAddTask;
        private ListBox LstTasks;
        private TextBox TxtTaskTitle;
        private DateTimePicker DtpDueDate;
        private ComboBox CmbTaskType;
        private Label label1;
        private Button BtnMarkComplete;
        private Button BtnDeleteTask;
    }
}