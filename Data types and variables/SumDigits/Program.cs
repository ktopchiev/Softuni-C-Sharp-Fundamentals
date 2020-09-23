using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var a = 0;
            var length = num.ToString();
            var sum = 0;

            for (int i = 0; i < length.Length ; i++)
            {
                a = num % 10;
                sum += a;
                num = num / 10;
            }

            Console.WriteLine(sum);
        }
    }
}