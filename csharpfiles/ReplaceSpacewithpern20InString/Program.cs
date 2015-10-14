using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSpacewithpern20InString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string s = Console.ReadLine();
            string ret = ReplaceSpaces(s);
            Console.WriteLine(ret);
            Console.ReadKey();
        }

        private static string ReplaceSpaces(string s)
        {
            int spaceCount = 0;
            int newLen;
            char[] charArr = s.ToCharArray();
            for (int i = 0; i < charArr.Length; ++i)
            {
                if (charArr[i] == ' ')
                    spaceCount++;
            }
            newLen = charArr.Length + (spaceCount * 2);
            char[] newCharArr = new char[newLen];
            int j = charArr.Length-1;
            int k = newLen-1;
            while (j >= 0)
            {
                if (charArr[j] == ' ')
                {
                    newCharArr[k] = '0';
                    newCharArr[k- 1] = '2';
                    newCharArr[k - 2] = '%';
                    j--;
                    k = k - 3;
                }
                else
                {
                    newCharArr[k--] = charArr[j--];
                }
            }
            return new string(newCharArr);
        }
    }
}
