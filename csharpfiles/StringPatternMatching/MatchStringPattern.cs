using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPatternMatching
{
    /// <summary>
    /// * --> Matches with 0 or more instances of any character or set of characters.
    ///? --> Matches with any one character.
    ///test("g*ks", "geeks"); // Yes
    //test("ge?ks*", "geeksforgeeks"); // Yes
    //test("g*k", "gee");  // No because 'k' is not in second
    //test("*pqrs", "pqrst"); // No because 't' is not in first
    //test("abc*bcd", "abcdhghgbcd"); // Yes
    //test("abc*c?d", "abcd"); // No because second must have 2 instances of 'c'
    //test("*c*d", "abcd"); // Yes
    //test("*?c*d", "abcd"); // Yes
    /// 
    /// 
    /// 
    /// </summary>
    class MatchStringPattern
    {
        static void Main(string[] args)
        {
            bool isMatch =Match("g*ks".ToCharArray(), "geeks".ToCharArray(),0,0);
            Console.WriteLine("Pattern match ?" + isMatch);
            Console.ReadKey();
        }

        private static bool Match(char[] pattern, char[] str, int patternFocus, int strFocus)
        {
            if (patternFocus == pattern.Length && strFocus != str.Length)
                return false;
            if (patternFocus != pattern.Length && strFocus == str.Length)
                return false;
            if (patternFocus == pattern.Length && strFocus == str.Length)
                return true;
            if (pattern[patternFocus] == '\0' && str[strFocus] == '\0')
                return true;
            if (pattern[patternFocus] == '*' && pattern[patternFocus + 1] != '\0' && str[strFocus] == '\0')
                return false;
            if (pattern[patternFocus] == '?' || pattern[patternFocus] == str[strFocus])
                Match(pattern, str, patternFocus + 1, strFocus + 1);
            if (pattern[patternFocus] == '*')
                return Match(pattern, str, patternFocus + 1, strFocus) || Match(pattern, str, patternFocus, strFocus + 1);
            return false;
        }
    }
}
