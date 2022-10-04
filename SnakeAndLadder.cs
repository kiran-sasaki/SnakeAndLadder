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
        public const int WINING_POSITION = 100;
        public static void SnakeAndLadderGame()
        {
            int PlayerPosition=0;
            while (PlayerPosition < WINING_POSITION)
            {
                Random random = new Random();
                int diceRoll = random.Next(1, 7);
                int option = random.Next(1, 3);
                switch (option)
                {
                    case LADDER:
                        PlayerPosition += diceRoll;
                        break;
                    case SNAKE:
                        PlayerPosition -= diceRoll;
                        break;
                    case NO_PLAY:
                        Console.WriteLine("No Play ");
                        break;
                }
                if (PlayerPosition < 0)
                {
                    PlayerPosition = 0;
                }
                else if (PlayerPosition > WINING_POSITION)
                {
                    PlayerPosition -= diceRoll;
                    Console.WriteLine("Stay in some previous position " + PlayerPosition);
                }
                PlayerPosition++;
            }
        }
    }
}
