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
            bool content = CheckPassContent(password);
            bool digitsNum = CheckDigitsNum(password);

            if (length && content && digitsNum)
            {
                Console.WriteLine("Password is valid");
            }

            else
            {
                if (!length)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!content)
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

            return (password.Length >= 6 && password.Length <= 10) ? true : false;
        }
        

        static bool CheckPassContent(char[] password)
        {
            return (Array.Exists(password, c => !Char.IsDigit(c) && !Char.IsLetter(c))) ? false : true;
        }

        static bool CheckDigitsNum(char[] password)
        {
            return (password.Count(Char.IsDigit) >= 2) ? true : false;
        }
    }
}