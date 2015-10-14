using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberOfWords
{
    class CountNumOfWordsInString
    {
        static void Main(string[] args)
        {
            String s = "this is, test, string,;,l;l. This is test.";
            PrintCountOfWords(s);
            Console.ReadKey();
        }

        private static void PrintCountOfWords(string s)
        {
            int OUT = 1;
            int IN = 0;
            int state = OUT;
            int wordcount = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == ' ' || s[i] == ',' || s[i] == '.')
                    state = OUT;
                else if (state == OUT)
                {
                    state = IN;
                    wordcount++;
                }
            }

            Console.WriteLine("Word count = " + wordcount);
        }
    }
}
