using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i >= 0 ; i++)
            {
                if (playerOne.Count > 0 && playerTwo.Count > 0)
                {
                    if (playerOne[i] > playerTwo[i])
                    {
                        int add = playerOne[i];
                        playerOne.Remove(playerOne[i]);
                        playerOne.Add(add);
                        playerOne.Add(playerTwo[i]);
                        playerTwo.Remove(playerTwo[i]);
                        i--;
                    }
                    
                    else if (playerOne[i] < playerTwo[i])
                    {
                        int add = playerTwo[i];
                        playerTwo.Remove(playerTwo[i]);
                        playerTwo.Add(add);
                        playerTwo.Add(playerOne[i]);
                        playerOne.Remove(playerOne[i]);
                        i--;
                    }
                    
                    else
                    {
                        playerOne.Remove(playerOne[i]);
                        playerTwo.Remove(playerTwo[i]);
                        i--;
                    }
                }
                else
                {
                    break;
                }
            }

            if (playerOne.Count != 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            }
            else if (playerTwo.Count != 0)
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            }
            
        }
    }
}