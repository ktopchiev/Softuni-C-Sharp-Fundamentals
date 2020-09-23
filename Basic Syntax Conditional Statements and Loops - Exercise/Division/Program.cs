using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] divisors = {10, 7, 6, 3, 2};

            for (int i = 0; i < divisors.Length; i++)
            {
                if (num % divisors[i] == 0)
                {
                    Console.WriteLine($"The number is divisible by {divisors[i]}");
                    break;
                }

                if (i == divisors.Length - 1)
                {
                    Console.WriteLine("Not divisible");
                    break;
                }
            }
        }
    }
}