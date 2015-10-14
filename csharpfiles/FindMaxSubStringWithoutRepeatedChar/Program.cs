using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FindMaxSubStringWithoutRepeatedChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String str = Console.ReadLine();
            Console.WriteLine("Max SubStr with all Unique Chars is: " + MaxSubStringWithUniqueChars(str));
            Console.ReadKey();
        }

        private static string MaxSubStringWithUniqueChars(string str)
        {
            char[] cArr = str.ToCharArray();
            Hashtable h = new Hashtable();
            h.Clear();
            int n = cArr.Length;
            int begin = 0;
            int j = 0;
            string maxSub = "";
            for (int i = 0; i < n; ++i)
            {
                if (!h.Contains(cArr[i]))
                {
                    h.Add(cArr[i], true);
                    j++;

                }
                else
                {
                    int newSublen = j - begin;
                    if (maxSub.Length < newSublen)
                    {
                        maxSub = str.Substring(begin, j);

                    }
                    begin = i;
                    j = begin + 1;
                    h.Clear();
                }
            }
            return maxSub;
        }
    }
}
