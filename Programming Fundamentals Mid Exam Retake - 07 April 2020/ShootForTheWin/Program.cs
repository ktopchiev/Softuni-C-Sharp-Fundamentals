using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targetSequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int shotTargets = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (!input.Contains("End"))
                {
                   int targetIndex = Convert.ToInt32(input);
                   int index = 0;

                   if (targetIndex >= targetSequence.Length)
                   {
                       continue;
                   }

                   var lastShotTarget = targetSequence[targetIndex];
                   
                   targetSequence[targetIndex] = -1;
                   shotTargets++;
                   
                   for (int i = 0; i < targetSequence.Length; i++)
                   {
                       
                       if (targetSequence[i] != -1)
                       {
                           if (targetSequence[i] > lastShotTarget)
                           {
                               targetSequence[i] -= lastShotTarget;
                           }
                           else
                           {
                               targetSequence[i] += lastShotTarget;
                           }
                       }
                   }
                }
                else
                {
                    Console.WriteLine($"Shot targets: {shotTargets} -> {String.Join(' ', targetSequence)}");
                    break;
                }
            }
        }
    }
}