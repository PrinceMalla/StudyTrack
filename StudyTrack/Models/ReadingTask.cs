namespace StudyTrack.Models
{
    public class ReadingTask : StudyTaskBase
    {
        public override string GetTaskDescription()
        {
            return "Reading: " + Title;
        }
    }
}