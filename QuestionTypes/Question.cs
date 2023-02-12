namespace Day10.QuestionTypes
{
    internal abstract class Question
    {
        private Answer answer;

        public string Header { get; set; }
        public float Mark { get; set; }
        public Answer AllAnswers { get; set; }
        public Answer CorrectAnswer { get; set; }
        public Question(string _header, float _mark, Answer _answers, Answer _correctAnswer)
        {
            Header = _header;
            Mark = _mark;
            AllAnswers = _answers;
            CorrectAnswer = _correctAnswer;
        }



        public void ShowQuestion(int counter)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine($"({counter})- {Header}    (Mark:{Mark})");
            Console.WriteLine();
            AllAnswers.ShowAnswer();
        }
        public abstract bool IsCorrect(string userInput);
    }
}
