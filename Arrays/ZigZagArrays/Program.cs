using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstNums = new int[n];
            int[] secondNums = new int[n];
            
            for (int i = 1; i <= n; i++)
            {
                
                int[] inputArr = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                foreach (var element in inputArr)
                {
                    if (i % 2 == 0)
                    {
                        secondNums[i - 1] = inputArr[0];
                        firstNums[i - 1] = inputArr[1];
                    }

                    else
                    {
                        secondNums[i - 1] = inputArr[1];
                        firstNums[i - 1] = inputArr[0];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(firstNums[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(secondNums[i] + " ");
            }
        }
    }
}