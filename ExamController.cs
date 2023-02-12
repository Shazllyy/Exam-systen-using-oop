using Day10.ExamTypes;
using Day10.QuestionData;
using Day10.QuestionTypes;

namespace Day10
{
    internal static class ExamController
    {
        static Subject subject;
        public static int GetSubject()
        {
            int SubjectNum;
            do
            {
                Console.WriteLine("\t\t\t\tPlease Choose Subject:(1)-Math,(2)-Sports");
            }
            while (!int.TryParse(Console.ReadLine(), out SubjectNum) || SubjectNum > 2 || SubjectNum < 1);
            return SubjectNum;

        }
        public static Question[] SetSubject(int SubjectNum) {
            QuestionsDictionary QuestionDict = new QuestionsDictionary();
            Question[] QuestionArr;
            if (SubjectNum == 1)
            {
                QuestionArr = QuestionDict.allQuestionDictionary["1"];
                subject = new Subject("1", SubjectName.math);

            }
            else { QuestionArr = QuestionDict.allQuestionDictionary["2"]; subject = new Subject("2", SubjectName.sports); }

            return QuestionArr;
        }
        public static string GetExamType() {
            string DesiredExam;
            do
            {
            Console.WriteLine("\t\t\t\t Do you prefer (1)-practice (2)-final");
             DesiredExam = Console.ReadLine();

            } 
            while (DesiredExam!="1" && DesiredExam != "2" && DesiredExam.ToLower()!="practice"&& DesiredExam.ToLower() != "final");
            return DesiredExam;
        }
        public static IExam SetExamType(string ExamType) {
            IExam Exam;
            if (ExamType == "1" || ExamType.ToLower() == "practice") { Exam = new PracticeExam(); Exam.ExamType = "Practice"; }
            else {Exam =new FinalExam(); Exam.ExamType = "Final"; }
            return Exam;

        }
        public static int GetNumOfQuestions()
        {
            int NumOfQuestions;
            do
            {
                Console.WriteLine("\t\t\t\tHow many questions do you want ? (3~5)");
            } while (!int.TryParse(Console.ReadLine(), out NumOfQuestions) || NumOfQuestions > 5 || NumOfQuestions < 3);
            return NumOfQuestions;
        }
        public static void StartExam()
        {
            string PlayAgain;
            Console.WriteLine("\t\t\t******************************************************");
            Console.WriteLine("\t\t\t******\t\tWelcome to test program\t\t******");
            Console.WriteLine("\t\t\t******************************************************");
            Console.WriteLine();
            do
            {
                int SubjectNum = GetSubject();
                Question[] QuestionArr = SetSubject(SubjectNum);
                string ExamType = GetExamType();
                IExam Exam = SetExamType(ExamType);
                int NumOfQuestions = GetNumOfQuestions();
                Console.WriteLine($"\t\t\t\t\tYou choosed {Exam.ExamType} {subject.SubjectName.ToString().ToUpper()} exam");
                //Console.WriteLine($"\t\t\t\t\t\t{Exam.ExamType} exam");
                Exam.DisplayRandQuestions(QuestionArr, NumOfQuestions);
                Console.WriteLine("***********************************************");
                Exam.ShowGrade();
                Console.WriteLine("Wanna try again? press Y to take another one - press any key to exit");
                PlayAgain = Console.ReadLine();
            } while (PlayAgain.ToLower()=="y");
            Console.WriteLine("Good bye");

        }
    }
}

