using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] + intArray[j] == num)
                    {
                        Console.Write($"{intArray[i]} {intArray[j]}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}