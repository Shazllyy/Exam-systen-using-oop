using Day10.QuestionTypes;

namespace Day10.ExamTypes
{
    internal class PracticeExam : FinalExam
    {
        public override void DisplayRandQuestions(Question[] QuestionArr, int NumOfQuestion)
        {
            Random rnd = new Random();
            Question[] MyRandomArray = QuestionArr.OrderBy(x => rnd.Next()).ToArray();
            for (int i = 0; i < NumOfQuestion; i++)
            {
                MyRandomArray[i].ShowQuestion(i + 1);
                string UserInput = Console.ReadLine();
                string CheckedUserInput=UserAnswersCheck(UserInput, MyRandomArray[i], i);
                TotalMark += MyRandomArray[i].Mark;
                if (MyRandomArray[i].IsCorrect(CheckedUserInput))
                {
                    Mark += MyRandomArray[i].Mark;
                    Console.WriteLine("Correct answer");
                }
                else { Console.WriteLine($"Wrong answer, Correct answer is:"); ShowRightAnswer(MyRandomArray[i]); }
            }
        }
        public void ShowRightAnswer(Question question)
        {
            int i = 1;
            foreach (var answer in question.CorrectAnswer.Answers)
            {
                Console.WriteLine($"{i}- {question.AllAnswers.Answers[int.Parse(answer) - 1]}");
                i++;
            }
        }

    }
}
