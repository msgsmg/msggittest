using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutations
{
    class GenerateStringPermutations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            PrintPermuations(str.ToCharArray(),0);
            Console.ReadKey();
        }

        /// <summary>
        /// 1. Use a focus variable
        /// 2. If focus = length print string
        /// 3. Swap current char with focus var and recursively call
        /// </summary>
        /// <param name="str"></param>
        private static void PrintPermuations(char[] str, int focus)
        {
            if (focus == str.Length)
            {
                Console.WriteLine(str);
                return;
            }
            PrintPermuations(str, focus + 1);

            for(int i=focus +1; i<str.Length;++i)
            {
                if (str[i] != str[focus])
                {
                    char temp = str[i];
                    str[i] = str[focus];
                    str[focus] = temp;
                    PrintPermuations(str, focus + 1);
                    temp = str[i];
                    str[i] = str[focus];
                    str[focus] = temp;
                }
            }
        }
    }
}
