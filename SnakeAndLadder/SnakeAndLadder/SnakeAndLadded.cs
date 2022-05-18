using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class snakeGame
    {
        int player1 = 0, player2 = 0, player1DiceCount = 0, player2DiceCount = 0, selectPlayer = 1;
        Random dice = new Random();
        public void startGame()
        {
            while (player2 < 100 && player1 < 100)
            {
                int possibility = dice.Next(3);
                if (selectPlayer == 1)
                {
                    int diceValue = dice.Next(1, 7);
                    if (player1 < 100 && player1 >= 0)
                    {
                        Console.WriteLine("Player1 Dice value = " + diceValue);
                        switch (possibility)
                        {
                            case 1: // ladder
                                player1 = player1 + diceValue;
                                selectPlayer = 1;
                                if (player1 > 100)
                                {
                                    player1 = player1 - diceValue;
                                }
                                break;
                            case 2: // snake
                                player1 = player1 - diceValue;
                                selectPlayer = 2;
                                break;
                            case 0: // noPlay
                                break;
                        }
                        Console.WriteLine("Player1 current position = " + player1);
                        if (player1 < 0)
                        {
                            player1 = 0;
                        }
                    }
                    player1DiceCount++;
                }
                else
                {
                    int diceValue = dice.Next(1, 7);
                    if (player2 < 100 && player2 >= 0)
                    {
                        Console.WriteLine("player2 Dice value = " + diceValue);
                        switch (possibility)
                        {
                            case 1: // ladder
                                player2 = player2 + diceValue;
                                selectPlayer = 2;
                                if (player2 > 100)
                                {
                                    player2 = player2 - diceValue;
                                }
                                    break;
                            case 2: // snake
                                player2 = player2 - diceValue;
                                selectPlayer = 1;
                                break;
                            case 0: // noPlay
                                break;
                        }
                        Console.WriteLine("Player2 current position = " + player2);
                    }
                        if (player2 < 0)
                        {
                            player2 = 0;
                        }
                    
                    player2DiceCount++;
                } 
            }
            Console.WriteLine();
            Console.WriteLine("Player1 dice rolled count = " + player1DiceCount);
            Console.WriteLine("Player2 dice rolled count = " + player2DiceCount);
            Console.WriteLine("Total dice Count = " + (player2DiceCount+ player1DiceCount));
            if (player1 == 100)
            {
                Console.WriteLine("Player1 Wins");
            }
            else
            {
                Console.WriteLine("player2 wins");
            }
        }
    }
}
