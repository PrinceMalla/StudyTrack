namespace StudyTrack
{
    public class Task
    {
        public int TaskId { get; set; }

        public string Title { get; set; }

        public int SubjectId { get; set; }

        public DateTime DueDate { get; set; }

        public string Priority { get; set; }

        public string TaskType { get; set; }

        public bool IsComplete { get; set; }

        public string Notes { get; set; }
    }
}