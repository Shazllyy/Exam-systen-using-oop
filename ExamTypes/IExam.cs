using Day10.QuestionTypes;

namespace Day10.ExamTypes
{
    interface IExam
    {
        public void DisplayRandQuestions(Question[] QuestionArr, int NumOfQuestion);
        public void ShowGrade();
        public string ExamType { get; set; }

    }



}

