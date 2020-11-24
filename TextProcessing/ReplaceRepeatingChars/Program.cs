using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            List<char> singles = new List<char>();
            singles.Add(text[0]);
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i + 1] != text[i])
                {
                    singles.Add(text[i + 1]);
                }
            }

            Console.WriteLine(String.Join("", singles));
        }
    }
}