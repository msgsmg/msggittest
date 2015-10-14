using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAllKLengthStringFromSetOfNChars
{
        //    Input: 
        //set[] = {'a', 'b'}, k = 3

        //Output:
        //aaa
        //aab
        //aba
        //abb
        //baa
        //bab
        //bba
        //bbb
    class PrintAllStringsOfLenghKFromSetOfNChars
    {
        static void Main(string[] args)
        {
            char[] set = { 'a', 'b' };
            int k = 3;
            PrintKLenStrings(set, k);
            Console.ReadKey();
        }

        private static void PrintKLenStrings(char[] set, int k)
        {
            int len = set.Length;
            PrintKLenStringsRecursive(set, k, len, "");
        }

        private static void PrintKLenStringsRecursive(char[] set, int k, int len, string pre)
        {
            if (k == 0)
            {
                Console.WriteLine(pre);
                return;
            }

            for (int i = 0; i < len; ++i)
            {
                PrintKLenStringsRecursive(set, k - 1, len, pre + set[i]);
            }

        }
    }
}
