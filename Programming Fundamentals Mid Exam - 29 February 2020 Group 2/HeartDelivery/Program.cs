using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighbourhood = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            int lastJumpPosition = 0;
            
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                
                if (command.Contains("Love!"))
                {
                    Console.WriteLine($"Cupid's last position was {lastJumpPosition}.");
                    break;
                }

                else if (command.Contains("Jump"))
                {
                    var jumpLength = int.Parse(command[1]);

                    if (jumpLength + lastJumpPosition >= neighbourhood.Count)
                    {
                        jumpLength = 0;
                        lastJumpPosition = 0;
                    }

                    if (neighbourhood[jumpLength + lastJumpPosition] != 0)
                    {
                        neighbourhood[jumpLength + lastJumpPosition] -= 2;
                        
                        if (neighbourhood[jumpLength + lastJumpPosition] == 0)
                        {
                            Console.WriteLine($"Place {jumpLength + lastJumpPosition} has Valentine's day.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Place {jumpLength + lastJumpPosition} already had Valentine's day.");
                    }

                    lastJumpPosition += jumpLength;
                }
            }

            if (neighbourhood.Count(x => x == 0) == neighbourhood.Count())
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighbourhood.Count(x => x != 0)} places.");
            }
        }
    }
}