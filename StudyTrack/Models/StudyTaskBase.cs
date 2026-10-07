namespace StudyTrack.Models
{
    public abstract class StudyTaskBase
    {
        private int taskId;
        private string title = "";
        private int subjectId;
        private DateTime dueDate;
        private string priority = "";
        private bool isComplete;
        private string notes = "";

        public int TaskId
        {
            get
            {
                return taskId;
            }
            set
            {
                taskId = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    title = value;
                }
            }
        }

        public int SubjectId
        {
            get
            {
                return subjectId;
            }
            set
            {
                subjectId = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }

        public string Priority
        {
            get
            {
                return priority;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    priority = value;
                }
            }
        }

        public bool IsComplete
        {
            get
            {
                return isComplete;
            }
            set
            {
                isComplete = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }

        public abstract string GetTaskDescription();
    }
}