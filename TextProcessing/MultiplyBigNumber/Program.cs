using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();
            int multiplier = int.Parse(Console.ReadLine());
            int remainder = 0;
            StringBuilder ouput = new StringBuilder();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == 48 && input.Any(x => x!= 48))
                {
                    input.RemoveAt(i);
                    i = 0;
                }
                else
                {
                    break;
                }
            }
            
            for (int i = input.Count - 1; i >= 0; i--)
            {
                int num = (int) Char.GetNumericValue(input[i]);
                int current = num * multiplier;
                char[] currentArr = current.ToString().ToCharArray();
                int lastIndex = currentArr.Length - 1;
                int currentNum = (int) Char.GetNumericValue(currentArr[lastIndex]);
                currentNum += remainder;
                remainder = 0;
                if (currentNum > 9)
                {
                    char[] remainderArr = currentNum.ToString().ToCharArray();
                    currentNum = (int) Char.GetNumericValue(remainderArr[1]);
                    remainder = (int) Char.GetNumericValue(remainderArr[0]);
                }

                ouput.Insert(0, currentNum);
                if (currentArr.Length > 1)
                {
                    remainder = (int) Char.GetNumericValue(currentArr[0]);
                }

                if (i == 0 && remainder != 0)
                {
                    ouput.Insert(0, remainder);
                }
            }

            Console.WriteLine(ouput.ToString());
        }
    }
}