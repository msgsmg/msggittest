using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1234;
            Console.WriteLine("Rever of " + n + " is " + ReverseNumber(n));
            Console.ReadKey();
        }

        private static int ReverseNumber(int n)
        {
            int reverseNum = 0;
            while (n > 0)
            {
                reverseNum = reverseNum * 10 + (n % 10);
                n = n / 10;
            }
            return reverseNum;

        }
    }
}
