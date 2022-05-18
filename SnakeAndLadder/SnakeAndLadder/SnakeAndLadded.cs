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
            Random dice = new Random();
            int diceValue = dice.Next(1, 7);
        }
    }
}
