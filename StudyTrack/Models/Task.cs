namespace StudyTrack.Models
{
    public class Task : StudyTaskBase
    {
        public string TaskType { get; set; } = "";

        public override string GetTaskDescription()
        {
            return TaskType + ": " + Title;
        }
    }
}