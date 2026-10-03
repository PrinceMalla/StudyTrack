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
            SuspendLayout();
            // 
            // LblSubjectName
            // 
            LblSubjectName.AutoSize = true;
            LblSubjectName.Location = new Point(100, 47);
            LblSubjectName.Name = "LblSubjectName";
            LblSubjectName.Size = new Size(81, 15);
            LblSubjectName.TabIndex = 0;
            LblSubjectName.Text = "Subject Name";
            // 
            // TxtSubjectName
            // 
            TxtSubjectName.Location = new Point(187, 47);
            TxtSubjectName.Name = "TxtSubjectName";
            TxtSubjectName.Size = new Size(250, 23);
            TxtSubjectName.TabIndex = 1;
            // 
            // txtSubjectCode
            // 
            txtSubjectCode.Location = new Point(187, 81);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.Size = new Size(250, 23);
            txtSubjectCode.TabIndex = 3;
            // 
            // LblSubjectCode
            // 
            LblSubjectCode.AutoSize = true;
            LblSubjectCode.Location = new Point(104, 81);
            LblSubjectCode.Name = "LblSubjectCode";
            LblSubjectCode.Size = new Size(77, 15);
            LblSubjectCode.TabIndex = 2;
            LblSubjectCode.Text = "Subject Code";
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(242, 110);
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
            LstSubjects.Location = new Point(116, 146);
            LstSubjects.Name = "LstSubjects";
            LstSubjects.Size = new Size(370, 109);
            LstSubjects.TabIndex = 5;
            // 
            // LblTaskTitle
            // 
            LblTaskTitle.AutoSize = true;
            LblTaskTitle.Location = new Point(104, 273);
            LblTaskTitle.Name = "LblTaskTitle";
            LblTaskTitle.Size = new Size(56, 15);
            LblTaskTitle.TabIndex = 6;
            LblTaskTitle.Text = "Task Title";
            // 
            // LblTaskSubject
            // 
            LblTaskSubject.AutoSize = true;
            LblTaskSubject.Location = new Point(104, 302);
            LblTaskSubject.Name = "LblTaskSubject";
            LblTaskSubject.Size = new Size(46, 15);
            LblTaskSubject.TabIndex = 7;
            LblTaskSubject.Text = "Subject";
            // 
            // CmbTaskSubject
            // 
            CmbTaskSubject.FormattingEnabled = true;
            CmbTaskSubject.Location = new Point(177, 288);
            CmbTaskSubject.Name = "CmbTaskSubject";
            CmbTaskSubject.Size = new Size(121, 23);
            CmbTaskSubject.TabIndex = 8;
            // 
            // LblDueDate
            // 
            LblDueDate.AutoSize = true;
            LblDueDate.Location = new Point(100, 334);
            LblDueDate.Name = "LblDueDate";
            LblDueDate.Size = new Size(55, 15);
            LblDueDate.TabIndex = 9;
            LblDueDate.Text = "Due Date";
            // 
            // LblPriority
            // 
            LblPriority.AutoSize = true;
            LblPriority.Location = new Point(100, 354);
            LblPriority.Name = "LblPriority";
            LblPriority.Size = new Size(45, 15);
            LblPriority.TabIndex = 10;
            LblPriority.Text = "Priority";
            // 
            // CmbPriority
            // 
            CmbPriority.FormattingEnabled = true;
            CmbPriority.Location = new Point(177, 346);
            CmbPriority.Name = "CmbPriority";
            CmbPriority.Size = new Size(121, 23);
            CmbPriority.TabIndex = 11;
            // 
            // BtnAddTask
            // 
            BtnAddTask.Location = new Point(242, 371);
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
            LstTasks.Location = new Point(225, 396);
            LstTasks.Name = "LstTasks";
            LstTasks.Size = new Size(120, 94);
            LstTasks.TabIndex = 13;
            // 
            // TxtTaskTitle
            // 
            TxtTaskTitle.Location = new Point(177, 261);
            TxtTaskTitle.Name = "TxtTaskTitle";
            TxtTaskTitle.Size = new Size(100, 23);
            TxtTaskTitle.TabIndex = 14;
            // 
            // DtpDueDate
            // 
            DtpDueDate.Location = new Point(177, 317);
            DtpDueDate.Name = "DtpDueDate";
            DtpDueDate.Size = new Size(200, 23);
            DtpDueDate.TabIndex = 15;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 539);
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
            Text = "StudyTrack";
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
    }
}