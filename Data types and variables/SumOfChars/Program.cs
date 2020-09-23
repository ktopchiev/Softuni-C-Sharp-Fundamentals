using System;
using System.Text;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfAsciiCodes = 0;
            byte[] inputChar = { };
            
            for (int i = 0; i < n; i++)
            {
                inputChar = Encoding.ASCII.GetBytes(Console.ReadLine());
                sumOfAsciiCodes += inputChar[0];
            }

            Console.WriteLine($"The sum equals: {sumOfAsciiCodes}");
        }
    }
}