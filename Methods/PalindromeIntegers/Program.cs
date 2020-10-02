using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string num = Console.ReadLine();
                if (num == "END")
                {
                    break;
                }
                
                Console.WriteLine(PalindromeCheck(num));
            }
        }
        
        static string PalindromeCheck(string num)
        {
            
            int n, r, sum = 0, temp; 
            n = int.Parse(num);  
            temp = n;
            string isPalindrome = null;
            
            while(n > 0)      
            {      
                r = n % 10;      
                sum = (sum * 10) + r;      
                n = n / 10;
            }
            
            if(temp == sum)      
                isPalindrome = "true";      
            else      
                isPalindrome = "false";

            return isPalindrome;
        }
    }
}