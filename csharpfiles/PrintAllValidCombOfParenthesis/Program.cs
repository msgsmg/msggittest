using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAllValidCombOfParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintValidCombinationsOfParen(3, 3, "");
            //Console.WriteLine("All VAlid combo are " + combo);
            Console.ReadKey();
        }

        private static void PrintValidCombinationsOfParen(int leftRemaining, int rightRemaining, string current)
        {
            if (rightRemaining == 0) // No Parenthesis left to print
            {
                Console.WriteLine(current);
                return;
            }
            else if (leftRemaining > 0)
            {
                PrintValidCombinationsOfParen(leftRemaining - 1, rightRemaining, current + "(");
                if (leftRemaining < rightRemaining)
                    PrintValidCombinationsOfParen(leftRemaining, rightRemaining - 1, current + ")");
            }
            else
                PrintValidCombinationsOfParen(leftRemaining, rightRemaining - 1, current + ")");
        }
    }
}
