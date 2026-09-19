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

            SuspendLayout();

            // 
            // LblSubjectName
            // 
            LblSubjectName.AutoSize = true;
            LblSubjectName.Location = new Point(100, 70);
            LblSubjectName.Name = "LblSubjectName";
            LblSubjectName.Size = new Size(81, 15);
            LblSubjectName.TabIndex = 0;
            LblSubjectName.Text = "Subject Name";

            // 
            // TxtSubjectName
            // 
            TxtSubjectName.Location = new Point(220, 67);
            TxtSubjectName.Name = "TxtSubjectName";
            TxtSubjectName.Size = new Size(250, 23);
            TxtSubjectName.TabIndex = 1;

            // 
            // LblSubjectCode
            // 
            LblSubjectCode.AutoSize = true;
            LblSubjectCode.Location = new Point(100, 110);
            LblSubjectCode.Name = "LblSubjectCode";
            LblSubjectCode.Size = new Size(77, 15);
            LblSubjectCode.TabIndex = 2;
            LblSubjectCode.Text = "Subject Code";

            // 
            // txtSubjectCode
            // 
            txtSubjectCode.Location = new Point(220, 107);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.Size = new Size(250, 23);
            txtSubjectCode.TabIndex = 3;

            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(220, 150);
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
            LstSubjects.Location = new Point(100, 210);
            LstSubjects.Name = "LstSubjects";
            LstSubjects.Size = new Size(370, 120);
            LstSubjects.TabIndex = 5;

            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);

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
    }
}