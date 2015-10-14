using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFirstnonRepeatedCharacterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("First non-Repeated Character in String is " + FirstNonRepeatedChar(str));
            Console.ReadKey();

        }

        private static char FirstNonRepeatedChar(string str)
        {
            char[] cArr = str.ToCharArray();
            Hashtable h = new Hashtable();
            // Build hashtable - Key = Char ; Value = Count (#of times Char occures in string)
            for (int i = 0; i < cArr.Length; ++i)
            {
                if (!h.ContainsKey(cArr[i]))
                {
                    h.Add(cArr[i], 1);
                }
                else
                {
                    int count = (int)h[cArr[i]];
                    h[cArr[i]] = count + 1;
                }
            }
            for (int i = 0; i < cArr.Length; ++i)
            { 
                if(h.ContainsKey(cArr[i]))
                {
                    if((int)h[cArr[i]] == 1)
                        return cArr[i];
                }
            }
            return '0';
        }
    }
}
