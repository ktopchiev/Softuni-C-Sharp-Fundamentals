using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str = Console.ReadLine().ToCharArray();
            Dictionary<char, int> counts = new Dictionary<char, int>();
            
            foreach (var cr in str.Where(x=>x != ' '))
            {
                int counter = 0;
                
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == cr)
                    {
                        counter++;
                    }
                }

                if (!counts.ContainsKey(cr))
                {
                    counts.Add(cr,counter);   
                }
            }

            foreach (KeyValuePair<char,int> pair in counts)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}