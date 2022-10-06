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
        public int PlayerPosition;
        public int counter = 0;
        public int SnakeAndLadderGame(int Player)
        {
            int PlayerPosition = Player;
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
                counter++;
                Console.WriteLine("Count Of Dies Roll " + counter + " PlayerPositon " + PlayerPosition);
            }
            return PlayerPosition;
        }
        public void initialPlay()
        {
            int playerA = 0;
            int playerB = 0;
            while (playerA != 100 && playerB != 100)
            {
                playerA = SnakeAndLadderGame(playerA);
                //   playerA += resA;
                playerB =SnakeAndLadderGame(playerB);
                //   playerB += resB;
                if(playerA == WINING_POSITION)
                {
                    Console.WriteLine("Player A is Winner");
                }
                else
                {
                    Console.WriteLine("Player B is Winner");
                }
            }
        }
    }
}
