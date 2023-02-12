using Day10.QuestionTypes;

namespace Day10.QuestionData
{
    internal class QuestionsDictionary
    {
        public QuestionsDictionary()
        {

            allQuestionDictionary = new Dictionary<string, Question[]>();
            allQuestionDictionary.Add("1", new QuestionBank().MathQuestions);
            allQuestionDictionary.Add("2", new QuestionBank().SportsQuestions);
        
        }
        public Dictionary<string, Question[]> allQuestionDictionary { get; }
    }
}
