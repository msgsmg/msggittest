using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQRTBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for which you want to find Square Root:");
            int num = Convert.ToInt32(Console.ReadLine());
            double sqrt = FindSQRT(num);
            Console.WriteLine("SQRT of " + num + "is " + sqrt);
            Console.ReadKey();
        }

        private static double FindSQRT(double num)
        {
            if (num < 1)
                return 1;
            double start = 0;
            double end = num;
            double mid = 0;
            double precision = 0.001;
            while ((start + end) > precision)
            {
                
                mid = (start + end) / 2;
                double midSqr = mid * mid;
                if (midSqr == num)
                    return mid;
                else if (num > midSqr)
                    start = mid;
                else
                    end = mid;

            }
            return (start + end) / 2;
            
        }
    }
}
