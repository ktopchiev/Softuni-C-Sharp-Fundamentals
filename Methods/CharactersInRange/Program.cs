using System;
using System.Text;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = Char.Parse(Console.ReadLine());
            
            string outputString = GetCharactersInRange(start, end);
            
            Console.WriteLine(outputString);
        }

        static string GetCharactersInRange(char start, char end)
        {
            int startNum = (int) start;
            int endNum = (int) end;
            int a = 0;
            
            //If input is reversed we should swap start and end nums to get for loop backwards
            if (startNum > endNum)
            {
                a = startNum;
                startNum = endNum;
                endNum = a;
            }
            
            StringBuilder outputString = new StringBuilder();
            
            for (int ch = startNum + 1; ch < endNum; ch++)
            {
                outputString.Append($"{(char)ch} ");
            }

            return outputString.ToString();
        }
    }
}