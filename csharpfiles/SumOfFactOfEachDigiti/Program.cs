using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFactOfEachDigiti
{
    class Program
    {
        // input = 1234567
        // output = 1! + 2! + 3! + 4! + 5! + 6! + 7!
        static void Main(string[] args)
        {
            int n = 9999999;
            Console.WriteLine("Sum of Fact of each digit is " + FindSumofFactOfEachDigit(n));
            Console.ReadKey();
        }

        private static int FindSumofFactOfEachDigit(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += Factorial(n % 10);
                n = n / 10;
            }
            return sum;
        }
        private static int Factorial(int n)
        { 
            if(n==0 || n==1)
                return 1;
            return n*Factorial(n-1);
        }
    }
}
