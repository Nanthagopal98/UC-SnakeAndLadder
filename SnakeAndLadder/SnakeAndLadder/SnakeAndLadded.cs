using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class snakeGame
    {
        int player1 = 0,diceCount=0;
        public void startGame()
        {
            for (player1 = 0; player1 < 100;)
            {
                Random dice = new Random();
                int diceValue = dice.Next(1, 7);
                if (player1 < 100 && player1 >= 0)
                {
                    Console.WriteLine(diceValue);
                    int possibility = dice.Next(3);
                    switch (possibility)
                    {
                        case 1: // ladder
                            player1 = player1 + diceValue;
                            break;
                        case 2: // snake
                            player1 = player1 - diceValue;
                            break;
                        case 0: // noPlay
                            break;
                    }
                    Console.WriteLine(player1);
                    if(player1>100)
                    {
                        player1 = player1 - diceValue;
                    }
                }
                else { player1 = 0; }
                diceCount++;
                
            }
            Console.WriteLine("Number of times dice rolled = " + diceCount);
        }
        
    }
}
