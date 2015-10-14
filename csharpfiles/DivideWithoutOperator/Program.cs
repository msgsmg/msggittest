using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividevalue = DivBruteForce(16, 2);
            Console.WriteLine("16 / 2 =" + dividevalue);
            Console.ReadKey();
            Console.WriteLine("Optimized way : 10000/5 = " + DivOptimized(10000,5));
            Console.ReadKey();
        }

        // Bruteforce
        private static int DivBruteForce(int divident, int divisor)
        {
            int quotient = 0;
            while (divisor <= divident)
            {
                divident = divident - divisor;
                quotient++;
            }
            return quotient;
        }

        private static int DivOptimized(int divident, int divisor)
        {
            int currentDivisor = divisor;
            int quotient=0;
            int currentQuotientBase = 1;

            while (divident >= divisor)
            {
                if (divident >= currentDivisor)
                {
                    divident -= currentDivisor;
                    quotient += currentQuotientBase;
                    currentDivisor *= 2;
                    currentQuotientBase *= 2;
                }
                else
                {
                    currentDivisor /= 2;
                    currentQuotientBase /= 2;
                }
            }
            return quotient;
        }
    }
}
