using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] password = Console.ReadLine().ToCharArray();
            bool length = CheckPassLength(password);
            int content = CheckPassContent(password);
            bool digitsNum = CheckDigitsNum(password);

            if (length && content == 0 && digitsNum)
            {
                Console.WriteLine("Password is valid");
            }

            else
            {
                if (!length)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (content != 0)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!digitsNum)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        static bool CheckPassLength(char[] password)
        {

            bool length = (password.Length >= 6 && password.Length <= 10) ? true : false;

            return length;
        }
        

        static int CheckPassContent(char[] password)
        {
            int notValid = 0;
            
            foreach (var ch in password)
            {
                var letter = Char.IsLetter(ch);
                var digit = Char.IsDigit(ch);
                
                if (!letter && !digit)
                {
                    notValid++;
                }
            }
            
            return notValid;
        }

        static bool CheckDigitsNum(char[] password)
        {
            int digitsNum = password.Count(Char.IsDigit);
            bool condIstrue = (digitsNum >= 2) ? true : false;

            return condIstrue;
        }
    }
}