using Day10.QuestionTypes;

namespace Day10.QuestionData
{
    internal class QuestionBank
    {
        public QuestionBank()
        {
            MathQuestions = new Question[] {
        new ChooseMultipleQuestion("4 x 4 = ",5f, new string[] { "12", "16", "32/2" }, new string[] { "2", "3" }
        ) ,
            new ChooseOneQuestion("0 / 1 = ",5f, new string[] { "0", "1", "infinity" }, new string[] { "1" }
        ) ,
            new ChooseOneQuestion("20 + 21 = ", 85f, new string[] { "41","51","61" }, new string[] { "1" }
        ) ,
            new ChooseMultipleQuestion("100 / 5 = ",5f, new string[] { "5", "18+2", "5*4" }, new string[] { "2", "3" }
        ) ,
            new TrueOrFalseQuestion("10 % 2 = 5 ",5f, new string[] {"true","false" }, new string[] { "2" }
        ) ,
            new TrueOrFalseQuestion("10 ^ 2 = 20 ", 5f, new string[] { "true","false"  }, new string[] {  "2" }
        ) ,
            new TrueOrFalseQuestion("10 / 20 = 1 / 2 ", 5f, new string[] { "true", "false" }, new string[] { "1" }
        ) ,
            new TrueOrFalseQuestion("1 * 0 = 10 ",5f, new string[] { "true", "false" }, new string[] { "2" }
        ) ,

            new ChooseOneQuestion("21 / 7 = ",5f, new string[] { "2", "3", ".5" }, new string[] {"1"}
        ) ,
            new ChooseOneQuestion("6 * 6 = ", 5f, new string[] { "30", "3600/100", "34" }, new string[] { "2" }
        ) ,
                new ChooseMultipleQuestion("10 + 10 + 10 ",5f, new string[] { "20", "30", "15*2" }, new string[] { "2", "3" }
        ) 

        };
            SportsQuestions = new Question[] {
        new TrueOrFalseQuestion("france won worldcup 2014",5f, new string[] { "true", "false" }, new string[] { "2" }
        ) ,
            new TrueOrFalseQuestion("brazil is the most national team to win worldcup", 5f, new string[] { "true", "false" }, new string[] {  "1" }
        ) ,
            new TrueOrFalseQuestion("Messi won ballon dior more than 7 times", 5f, new string[] {"true", "false" }, new string[] { "1" }
        ) ,
            new TrueOrFalseQuestion("Zinedine Zidan is spanish player",5f, new string[] {"true", "false" }, new string[] { "2" }
        ) ,
            new TrueOrFalseQuestion("liverpool won premier league 2008",5f, new string[] {"true", "false" }, new string[] { "2" }
        ) ,
            new ChooseOneQuestion("how many times has salah won premier league",5f, new string[] { "1", "2", "0" }, new string[] { "1" }
        ) ,
            new ChooseOneQuestion("how many times has Ahmed hassan won Africa nation title",5f, new string[] { "5", "4", "3" }, new string[] { "2" }
        ) ,
            new ChooseOneQuestion("when did barcelona won the champions league for last time",5f, new string[] { "2012", "2019", "2015" }, new string[] {  "3" }
        ) ,
            new ChooseMultipleQuestion("spanish clubs", 5f, new string[] { "barcelona", "realmadrid", "PSG" }, new string[] { "1", "2" }
        ) ,
            new ChooseMultipleQuestion("Won CAF Champions league more than 4 times", 5f, new string[] { "Ahly", "zamalek", "esmaily" }, new string[] { "1", "2" }
        )

        };

        }
        public Question[] MathQuestions { get; }
        public Question[] SportsQuestions { get; }

    }

}
