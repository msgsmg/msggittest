using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionWithoutDivideOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividevalue = DivBruteForce(16, 2);
            Console.WriteLine("16 / 2 =" + dividevalue);
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
    }
}
