using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLongestCommonSubStringOfTwoStrings
{
    class FindLongestCommonSubStr
    {
        static void Main(string[] args)
        {
            int lenLCF = LongestCommonSubStr("OldSite:GeeksforGeeks.org".ToCharArray(), "NewSite:GeeksQuiz.com".ToCharArray());
            Console.WriteLine("Length of LCSubStr = " + lenLCF);
            Console.ReadKey();
        }

        private static int LongestCommonSubStr(char[] p1, char[] p2)
        {
            int result = 0;
            int[,] LCF = new int[p1.Length,p2.Length];
            for(int i=0; i<p1.Length;++i)
            {
                for(int j=0; j<p2.Length; ++j)
                {
                    if(i==0 || j==0)
                    {
                        LCF[i,j] = 0;
                    }
                    else if(p1[i] == p2[j])
                    {
                        LCF[i,j] = LCF[i-1,j-1] + 1;
                        result = Math.Max(result, LCF[i,j]);
                    }
                    else
                    {
                        LCF[i,j] = 0;
                    }
                }
            }
            return result;
        }
    }
}
