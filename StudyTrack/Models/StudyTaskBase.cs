namespace StudyTrack.Models
{
    public abstract class StudyTaskBase
    {
        public int TaskId { get; set; }

        public string Title { get; set; } = "";

        public int SubjectId { get; set; }

        public DateTime DueDate { get; set; }

        public string Priority { get; set; } = "";

        public bool IsComplete { get; set; }

        public string Notes { get; set; } = "";

        public abstract string GetTaskDescription();
    }
}