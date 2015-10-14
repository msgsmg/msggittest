using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAllInterleavingsOfTwoStrings
{
    class PrintInterleavings
    {
        static void Main(string[] args)
        {
            string s1 = "AB";
            string s2 = "CD";
            int m = s1.Length;
            int n = s2.Length;
            int i = 0;
            PrintInterleavingsOfStrings(s1, s2,"", m, n, i);
            Console.ReadKey();
        }

        private static void PrintInterleavingsOfStrings(string s1, string s2, string output, int m, int n, int i)
        {
            if (m == 0 && n == 0)
            {
                Console.WriteLine(output);
                return;
            }

            if(m != 0)
            {
                if (!String.IsNullOrEmpty(s1))
                {
                    output += s1[0];
                    PrintInterleavingsOfStrings(s1.Substring(1), s2, output, m - 1, n, i);
                }
                else
                {
                    return;
                }
            }

            if (n != 0)
            {
                if (!String.IsNullOrEmpty(s2))
                {
                    output += s2[0];
                    PrintInterleavingsOfStrings(s1, s2.Substring(1), output, m, n - 1, i);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
