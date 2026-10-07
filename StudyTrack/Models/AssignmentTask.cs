namespace StudyTrack.Models
{
    public class AssignmentTask : StudyTaskBase
    {
        public override string GetTaskDescription()
        {
            return "Assignment: " + Title;
        }
    }
}