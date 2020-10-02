using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int substractNum = int.Parse(Console.ReadLine());

            int sum = Sum(firstNum, secondNum);
            int result = Substract(sum, substractNum);
            Console.WriteLine(result);
        }

        static int Sum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        static int Substract(int sum, int substractNum)
        {
            return sum - substractNum;
        }
    }
}