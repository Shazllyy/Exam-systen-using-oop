namespace Day10
{
    internal class Answer
    {
        public string[] Answers;
        public Answer(string[] answers)
        {
            Answers = answers;
        }
        public void ShowAnswer() {
            int i = 1;
            foreach (var answer in Answers)
            {
                Console.WriteLine($"{i}- {answer}");
                i++;
            }
        }
    }
}
