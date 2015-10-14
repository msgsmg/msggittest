using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIfRotatedPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            Console.WriteLine("The string " + str + " is palindrome ?? " + IsRotatedPalindrome(str));
            Console.ReadKey();
        }

        private static bool IsPalindrome(string str)
        {
            if (str.Length <= 1)
                return true;
            for (int i = 0; i < str.Length; ++i)
            {
                if (!(str[i] == str[str.Length - 1 - i]))
                    return false;
            }
            return true;
        }

        private static bool IsRotatedPalindrome(string str)
        {
            if (str.Length <= 1)
                return true;
            for (int i = 0; i < str.Length; ++i)
            {
                string left = str.Substring(0, i);
                string right= str.Substring(i);
                if(IsPalindrome(right+left))
                    return true;
            }
            return false;
        }
    }
}
