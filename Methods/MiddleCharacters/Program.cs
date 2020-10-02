using System;
using System.Text;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();
            string result = GetMiddleCharacters(chars);
            Console.WriteLine(result);
        }

        static string GetMiddleCharacters(char[] chars)
        {
            StringBuilder s = new StringBuilder();
            
            if (chars.Length % 2 == 0)
            {
                s.Append(chars[chars.Length / 2 - 1]);
                s.Append(chars[chars.Length / 2]);
            }

            else
            {
                s.Append(chars[chars.Length / 2]);
            }

            return s.ToString();
        }
    }
}