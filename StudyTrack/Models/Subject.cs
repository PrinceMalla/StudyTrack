namespace StudyTrack.Models
{
    public class Subject
    {
        private int subjectId;
        private string name = "";
        private string code = "";
        private string colourTag = "";

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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    code = value;
                }
            }
        }

        public string ColourTag
        {
            get
            {
                return colourTag;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    colourTag = value;
                }
            }
        }
    }
}