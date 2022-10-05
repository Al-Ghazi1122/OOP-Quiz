using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quiz
{
    internal class PlayerClass
    {
        private string Name { get; }
        private int NumOfPlays { get; set; }
        private decimal AverageScore { get; set; }

        public  PlayerClass(string name, int numofplays = 0, decimal averageScore = 0)
        {
            Name = name;
            NumOfPlays = numofplays;

        } public string getPlayerDetails()
        {
            return (Name + " Has played " + NumOfPlays.ToString() + " games " + " and has an average score of " + AverageScore);

        }
        public void completedAGame(int score)
        {
            if (NumOfPlays == 0)
            {
                this.NumOfPlays = 1;
                this.AverageScore = score;
            }
            else
            {
                this.NumOfPlays++;
                this.AverageScore = (this.AverageScore + score) / 2;
            }
        }
    }
}
