using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCStyleStringInPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("Reverse string is : " + RevString(str));
            Console.ReadKey();
        }

        private static string RevString(string str)
        {
            int end = str.Length - 1;
            int start = 0;
            char[] cArr = str.ToCharArray();
            char tmp = '\0';
            while (start < end)
            {
                tmp = cArr[start];
                cArr[start] = cArr[end];
                cArr[end] = tmp;
                start++;
                end--;
            }
            return new string(cArr);
        }
    }
}
