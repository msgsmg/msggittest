using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIfStringhasAllUniqueinON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("String " + str + " has all unique chars ??? " + DoesStringHaveAllUniqueChars(str));
            Console.ReadKey();
        }

        private static bool DoesStringHaveAllUniqueChars(string str)
        {
            char[] cArr = str.ToCharArray();
            Hashtable h = new Hashtable();
            for (int i = 0; i < cArr.Length; ++i)
            { 
                if(h.ContainsKey(cArr[i]))
                {
                    return false;
                }
                else
                {
                    h.Add(cArr[i], true);
                }
            }
            //if we didn't return from loop, that means all chars are unique
            return true;
        }
    }
}
