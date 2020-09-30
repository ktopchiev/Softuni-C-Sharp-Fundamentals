using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int smallestOfThreeNums = FindSmallestNum(firstNum, secondNum, thirdNum);
            Console.WriteLine(smallestOfThreeNums);
        }

        static int FindSmallestNum(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum < secondNum && firstNum < thirdNum)
            {
                return firstNum;
            }
            
            else if (secondNum < firstNum && secondNum < thirdNum)
            {
                return secondNum;
            }

            else
            {
                return thirdNum;
            }
        }
    }
}