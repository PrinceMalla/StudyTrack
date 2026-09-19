namespace StudyTrack
{
    partial class mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblSubjectName = new Label();
            TxtSubjectName = new TextBox();
            txtSubjectCode = new TextBox();
            LblSubjectCode = new Label();
            button1 = new Button();
            btnAddSubject = new Button();
            LstSubjects = new ListBox();
            SuspendLayout();
            // 
            // LblSubjectName
            // 
            LblSubjectName.AutoSize = true;
            LblSubjectName.Location = new Point(153, 72);
            LblSubjectName.Name = "LblSubjectName";
            LblSubjectName.Size = new Size(81, 15);
            LblSubjectName.TabIndex = 0;
            LblSubjectName.Text = "Subject Name";
            LblSubjectName.Click += label1_Click;
            // 
            // TxtSubjectName
            // 
            TxtSubjectName.Location = new Point(294, 77);
            TxtSubjectName.Name = "TxtSubjectName";
            TxtSubjectName.Size = new Size(100, 23);
            TxtSubjectName.TabIndex = 1;
            // 
            // txtSubjectCode
            // 
            txtSubjectCode.Location = new Point(322, 122);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.Size = new Size(100, 23);
            txtSubjectCode.TabIndex = 2;
            // 
            // LblSubjectCode
            // 
            LblSubjectCode.AutoSize = true;
            LblSubjectCode.Location = new Point(165, 125);
            LblSubjectCode.Name = "LblSubjectCode";
            LblSubjectCode.Size = new Size(81, 15);
            LblSubjectCode.TabIndex = 3;
            LblSubjectCode.Text = "Subject Name";
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(334, 189);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(75, 23);
            btnAddSubject.TabIndex = 5;
            btnAddSubject.Text = "add Subject";
            btnAddSubject.UseVisualStyleBackColor = true;
            // 
            // LstSubjects
            // 
            LstSubjects.FormattingEnabled = true;
            LstSubjects.Location = new Point(148, 257);
            LstSubjects.Name = "LstSubjects";
            LstSubjects.Size = new Size(120, 94);
            LstSubjects.TabIndex = 6;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstSubjects);
            Controls.Add(btnAddSubject);
            Controls.Add(button1);
            Controls.Add(LblSubjectCode);
            Controls.Add(txtSubjectCode);
            Controls.Add(TxtSubjectName);
            Controls.Add(LblSubjectName);
            Name = "mainform";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSubjectName;
        private TextBox TxtSubjectName;
        private TextBox txtSubjectCode;
        private Label LblSubjectCode;
        private Button button1;
        private Button btnAddSubject;
        private ListBox LstSubjects;
    }
}
