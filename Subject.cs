namespace Day10
{
    enum SubjectName
    {
        math,sports
    }
    internal class Subject
    {
        public string SubjectCode { get; set; }
        public SubjectName SubjectName { get; set; }

        public Subject(string subjectCode, SubjectName subjectName)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;  
        }
    }
}
