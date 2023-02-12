namespace Day10.QuestionTypes
{
    internal class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string header, float mark, string[] answers, string[] correctAnswer) : base(header, mark, new Answer(answers), new Answer(correctAnswer))
        {
        }
        public override bool IsCorrect(string userInput)
        {

            if (userInput == CorrectAnswer.Answers[0])
            {
                return true;
            }
            return false;
        }
    }
}
