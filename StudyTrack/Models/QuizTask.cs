namespace StudyTrack.Models
{
    public class QuizTask : StudyTaskBase
    {
        public override string GetTaskDescription()
        {
            return "Quiz: " + Title;
        }
    }
}
