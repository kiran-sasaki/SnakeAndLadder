using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SankeAndLadder
    {
        //Constant for a program
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NO_PLAY = 0;
        public static void SnakeAndLadderGame()
        {
            int PlayerPositon = 0;
            Random random = new Random();
            int diceRoll = random.Next(1,7);
            int option = random.Next(1, 3);
            switch (option)
            {
                case LADDER:
                    PlayerPositon += diceRoll;
                    break;
                case SNAKE:
                    PlayerPositon -= diceRoll;
                    break;
                case NO_PLAY:
                    Console.WriteLine("No Play ");
                    break;
            }
        }
    }
}
