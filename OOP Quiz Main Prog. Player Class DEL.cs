using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quiz
{
    internal class Program
    {
        static void createQuestions(ref QuestionClass[] question)
        {
            question[0] = new QuestionClass(1, 1, "What does OO stand for?", "Object Oriented", "Oriented Objects", "Over Objects", "Other Objects");
            question[1] = new QuestionClass(2, 1, "What does ED stand for?", "Event Driven", "Event Document", "Even Driven", "Edit Documents");
            question[2] = new QuestionClass(5, 1, "What does GUI stand for?", "Gummy User Ilam", "Goof User Ick", "Graphical User Interface", "Graphic User In");
            question[3] = new QuestionClass(4, 1, "What is the prefix m for?", "decimal", "floating point", "maths");
            question[4] = new QuestionClass(10, 5, "What is a getter?", "Minus", "Read Only");
        }
        static void runTheQuiz(ref PlayerClass player, QuestionClass[] question)
        {
            int score = 0; //stores the player's score
            int maxScore = 0; //maths quiz score - calculated from each individual question value
            string userInput = "";

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(question[i].QuestionNum.ToString() + ": " + question[i].Question);
                Console.WriteLine("- A - " + question[i].CorrectAnswer);
                Console.WriteLine(" - B - " + question[i].Incorrect1);
                Console.WriteLine("- C - " + question[i].Incorrect2);
                Console.WriteLine(" - D - " + question[i].Incorrect3);
                Console.WriteLine("Choose A, B, C or D and press enter");
                userInput = Console.ReadLine().ToUpper();
                maxScore = maxScore + question[i].PointsIfCorrect;

                if (userInput[0] == 'A')
                {
                    score = score + question[i].PointsIfCorrect;
                }
            }
            Console.WriteLine("You scored " + score.ToString() + " out of a possible " + maxScore.ToString());
            player.completedAGame(score);
        }
    }
}
