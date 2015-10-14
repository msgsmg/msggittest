using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPossibleWordsByPlacingSpace
{
    class GenerateWordsByPlacingSpace
    {
        static void Main(string[] args)
        {
            PringPossibleWords("msg".ToCharArray());
            Console.ReadKey();
        }

        private static void PringPossibleWords(char[] p)
        {
            char[] buf = new char[p.Length * 2];
            buf[0] = p[0];
            PrintPattern(p, buf, 1, 1, buf.Length);

        }

        private static void PrintPattern(char[] str, char[] buf, int i, int j, int n)
        {
            if (i == n)
            {
                Console.WriteLine(buf);
            }
            buf[j] = str[i];
            PrintPattern(str, buf, i + 1, j + 1, n);

            buf[j] = ' ';
            buf[j + 1] = str[i];
            PrintPattern(str, buf, i + 1, j + 2, n);
            
        }
    }
}
