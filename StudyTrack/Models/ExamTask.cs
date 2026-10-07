namespace StudyTrack.Models
{
    public class ExamTask : StudyTaskBase
    {
        public override string GetTaskDescription()
        {
            return "Exam: " + Title;
        }
    }
}