using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string> input = Console.ReadLine().Split(new string[] {"|"}, StringSplitOptions.None).ToList();
            List<string> outputList = new List<string>();
            
                foreach (var element in input)
                {
                    string s = element;
                    
                    //Remove more than one whitespaces between elements
                    RegexOptions options = RegexOptions.None;
                    Regex regex = new Regex("[ ]{2,}", options);
                    s = regex.Replace(s, " ");
                    
                    s = s.Trim();
                    
                    //Insert the element at the beginning of the list
                    if (!s.Equals("") && !s.Equals(" ")) 
                    {
                       outputList.Insert(0, s);
                    }
                }
                
            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}