using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.QuestionTypes
{
    internal class TrueOrFalseQuestion : Question
    {

        public TrueOrFalseQuestion(string header, float mark, string[] answers, string[] correctAnswer) : base(header, mark, new Answer(answers), new Answer(correctAnswer))
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

