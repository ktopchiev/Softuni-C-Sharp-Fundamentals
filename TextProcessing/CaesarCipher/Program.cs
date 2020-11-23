using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            byte[] chars = Encoding.ASCII.GetBytes(input);
            StringBuilder encryptedOutput = new StringBuilder();
            
            foreach (var ch in chars)
            {
                char newCh = Convert.ToChar(ch + 3);
                encryptedOutput.Append(newCh);
            }

            Console.WriteLine(encryptedOutput);
        }
    }
}