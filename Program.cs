using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a player - these details could be loaded from a file and their user could select their profile
            PlayerClass player1 = new PlayerClass("Bob"); //use the default values for numOfPlays and averageScore
            PlayerClass player2 = new PlayerClass("Chris", 4, 80); // set specific values for all attributes

            //Alternatively this can be entered from the Console or any other input
            Console.WriteLine("New Player? Please enter your name");
            PlayerClass player3 = new PlayerClass(Console.ReadLine()); //userinput for name plus default values

            //Display player details - gettPlayerDetails is a method from the Player Class
            Console.WriteLine(player1.getPlayerDetails());
            Console.WriteLine(player2.getPlayerDetails());
            Console.WriteLine(player3.getPlayerDetails());

            //lets assume player1 has somehow taken 2 quizes and scored 6 and 10. Average should be 8
            Console.WriteLine("");
            Console.WriteLine("player one has now played two games");
            player1.completedAGame(6);
            player1.completedAGame(10);
            Console.ReadLine();

            //display player details- getplayerDetails is a method from the Player Class
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(player1.getPlayerDetails());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(player2.getPlayerDetails());
            Console.WriteLine(player3.getPlayerDetails());
        }

    }
}
