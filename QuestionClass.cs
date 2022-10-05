using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quiz
{
    internal class QuestionClass
    {
        public int QuestionNum { get; }
        public int PointsIfCorrect { get; }
        public string Question { get; }
        public string CorrectAnswer { get; }
        public string Incorrect1 { get; }
        public string Incorrect2 { get; }
        public string Incorrect3 { get; }

        public QuestionClass(int qNum, int points, string question, string correctAns, string incor1, string incor2, string incor3)
        {
            QuestionNum = qNum;
            PointsIfCorrect = points;
            Question = question;
            CorrectAnswer = correctAns;
            Incorrect1 = incor1;
            Incorrect2 = incor2;
            Incorrect3 = incor3;
        }
    }
    

}
