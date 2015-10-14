using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressString
{
    // Input = aaabbbbccddd
    // Output = a3b4c2d3
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("Compressed string is " + CompressedString(str));
            Console.ReadKey();
        }

        private static string CompressedString(string str)
        {
            char[] cArr = str.ToCharArray();
            StringBuilder strBuff = new StringBuilder();
            int count = 1;
            char last = cArr[0];
            for (int i = 1; i < cArr.Length; ++i)
            {
                if (last == cArr[i])
                {
                    count++;
                }
                else
                {
                    strBuff.Append(last);
                    strBuff.Append(count);
                    count = 1;
                    last = cArr[i];
                }
            }
            strBuff.Append(last);
            strBuff.Append(count);
            return strBuff.ToString();
        }
    }
}
