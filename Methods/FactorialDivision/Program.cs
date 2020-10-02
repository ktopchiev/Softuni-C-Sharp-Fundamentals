using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = double.Parse(Console.ReadLine());
            var secondNum = double.Parse(Console.ReadLine());

            var factorial = Factorial(firstNum);
            var secondFactorial = Factorial(secondNum);
            Console.WriteLine($"{Divisor(factorial, secondFactorial):F}");
        }

        static double Factorial(double num)
        {
            double factorial = 1;
            
            for (double i = 1; i <= Math.Abs(num); i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static double Divisor(double num, double secondNum)
        {
            return num / secondNum;
        }
    }
}