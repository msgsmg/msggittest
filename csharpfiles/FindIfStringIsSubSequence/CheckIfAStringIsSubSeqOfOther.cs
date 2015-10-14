using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIfStringIsSubSequence
{
    class CheckIfAStringIsSubSeqOfOther
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if subsequenec" + CheckSubSeq("geek", "geeksforgeeks", "geek".Length,"geeksforgeeks".Length));
            Console.ReadKey();
        }

        private static bool CheckSubSeq(string p1, string p2, int len1, int len2)
        {
            if (len1 == 0)
                return true;
            if (len2 == 0)
                return false;
            if (p1[len1 - 1] == p2[len2 - 1])
            {
                return CheckSubSeq(p1, p2, len1 - 1, len2 - 1);
            }
            return CheckSubSeq(p1, p2, len1, len2 - 1);
        }
    }
}
