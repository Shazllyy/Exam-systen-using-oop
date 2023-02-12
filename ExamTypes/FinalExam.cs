using Day10.QuestionTypes;

namespace Day10.ExamTypes
{
    class FinalExam : IExam
    {
        public static float Mark { get; set; }
        public static float TotalMark { get; set; }
        public string ExamType { get; set; }
        public virtual void DisplayRandQuestions(Question[] QuestionArr, int NumOfQuestion)
        {
            Random rnd = new Random();
            Question[] MyRandomArray = QuestionArr.OrderBy(x => rnd.Next()).ToArray();
            for (int i = 0; i < NumOfQuestion; i++)
            {
                Random Random = new Random();
                MyRandomArray[i].ShowQuestion(i + 1);
                string UserInput = Console.ReadLine();
                string CheckedUserInput=UserAnswersCheck(UserInput, MyRandomArray[i], i);
                TotalMark += MyRandomArray[i].Mark;
                if (MyRandomArray[i].IsCorrect(CheckedUserInput))
                {
                    Mark += MyRandomArray[i].Mark;
                }
            }
        }
        public void ShowGrade()
        {
            float percentage = Mark * 100 / TotalMark;

            if(percentage>=85) Console.WriteLine($"Perfect your grade is Excellent with mark {Mark} / {TotalMark}");
            else if(percentage>=75) Console.WriteLine($"Almost there your grade is V.Good with mark {Mark} / {TotalMark}");
            else if(percentage>=65) Console.WriteLine($"Not bad your grade is Good with mark {Mark} / {TotalMark}");
            else if(percentage>=50) Console.WriteLine($"hardly passed your grade is Average with mark {Mark} / {TotalMark}");
            else  Console.WriteLine($"Bad Luck.. your grade is under Avg with mark {Mark} / {TotalMark} Give it try again..");
        }
        //Function to check user-answer validation
        public string UserAnswersCheck(string UserInput, Question question, int counter)
        {
            string[] UserInputArr = UserInput.Split(",");
            int Input;
            for (int i = 0; i < UserInputArr.Length; i++)
            {
                while (UserInputArr.Length > question.AllAnswers.Answers.Length||!int.TryParse(UserInputArr[i], out Input) || Input < 1 || Input > question.AllAnswers.Answers.Length)
                {
                    Console.WriteLine("please enter suitable answer");
                    question.ShowQuestion(counter + 1);
                    UserInput = Console.ReadLine();
                    UserInputArr = UserInput.Split(",");
                }
            }
            return UserInput;
        }

    }
}
