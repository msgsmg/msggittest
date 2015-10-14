using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfTwoStringsAreIsomorphic
{
    class Program
    {
        /// <summary>
        /// IsoMorphic - If letters from one word can be remapped to latters in second word.
        /// Remapping means replacing all occurances of a letter with another letter while ordering of
        /// letters is unchanged. No two letters can mapped to same letter. 
        /// foo -> app are isomorphic
        /// bar and foo are not isomorphic
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            String str1 = Console.ReadLine();
            Console.WriteLine("Enter one more String");
            String str2 = Console.ReadLine();
            Console.WriteLine("Are " + str1 + " and " + str2 + "  Isomorphic ?" + AreTwoStringsIsoMorphic(str1, str2));
            Console.ReadKey();
        }

        private static bool AreTwoStringsIsoMorphic(string str1, string str2)
        {
            StringBuilder iso1 = new StringBuilder();
            StringBuilder iso2 = new StringBuilder();
            char[] cArr1 = str1.ToCharArray();
            char[] cArr2 = str2.ToCharArray();
            Hashtable h1 = new Hashtable();
            Hashtable h2 = new Hashtable();

            if (cArr1.Length != cArr2.Length)
                return false;

            int i = 0;
            int j = 0;
            int m = 0;
            int n = 0;
            for(i =0; i<cArr1.Length; ++ i)
            {
                if (!h1.Contains(cArr1[i]))
                {
                    h1.Add(cArr1[i], true);
                    iso1.Append("" + (++m));
                }
                else
                {
                    if (cArr1[i] == cArr1[i - 1])
                    {
                        iso1.Append("" + m);
                    }
                    else
                    {
                        iso1.Append("" + (++m));
                    }
                }
            }
            for (i = 0; i < cArr2.Length; ++i)
            {
                if (!h2.Contains(cArr2[i]))
                {
                    h2.Add(cArr2[i], true);
                    iso2.Append("" + (++n));
                }
                else
                {
                    if (cArr2[i] == cArr2[i - 1])
                    {
                        iso2.Append("" + (n));
                    }
                    else
                    {
                        iso2.Append("" + (++n));
                    }
                }
            }

            if (iso1.ToString() == iso2.ToString())
                return true;

            return false;

        }
    }
}
