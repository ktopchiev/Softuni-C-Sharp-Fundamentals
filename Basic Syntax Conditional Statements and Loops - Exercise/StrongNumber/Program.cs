using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;
            int extractedNum = 0;
            int factorialsSum = 0;

            while (num > 0)
            {
                //extract each digit from the integer
                extractedNum = num % 10;
                num /= 10;
                
                int factorial = 1;
                //find the factorial of this digit
                for (int i = 2; i <= extractedNum; i++)
                {
                    factorial *= i;
                }
                
                //sum the factorials
                factorialsSum += factorial;
            }

            string output = (factorialsSum == numCopy) ? "yes" : "no";
            Console.WriteLine(output);
        }
    }
}