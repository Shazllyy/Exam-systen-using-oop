namespace Day10.QuestionTypes
{
    internal class ChooseMultipleQuestion : Question
    {
        public ChooseMultipleQuestion(string header, float mark, string[] answers, string[] correctAnswer) 
        : base(header, mark, new Answer(answers), new Answer(correctAnswer))
        {
        }
        public override bool IsCorrect(string userInput)
        {

            int flag = 0;
            string[] UserInput = userInput.Split(',');
            if (CorrectAnswer.Answers.Length == UserInput.Length)
            {
                Array.Sort(UserInput);
                for (int i = 0; i < UserInput.Length; i++)
                {
                    if (CorrectAnswer.Answers[i] != UserInput[i])
                    {
                        return false;
                    }
                    else flag++;
                }

            }
            if (flag == CorrectAnswer.Answers.Length) return true;
            else return false;
        }
    }
}
