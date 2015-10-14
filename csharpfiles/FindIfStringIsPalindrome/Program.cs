using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIfStringIsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("Is string   " + str + " a palindrome???"  + IsPalindrome(str));
            Console.ReadKey();
        }

        private static bool IsPalindrome(string str)
        {
            char[] cArr = str.ToCharArray();
            int start = 0;
            int end = cArr.Length - 1;
            while (start < end)
            {
                if (cArr[start] != cArr[end])
                    return false;
                else
                {
                    start++;
                    end--;
                }
            }
            // If we reach here, string is palindrome
            return true;
        }
    }
}
