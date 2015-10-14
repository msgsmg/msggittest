using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargetSubSumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { -1, 2, 5, -2 };
            int largestSubSum = FindLargetSubSum(a);
            Console.WriteLine("Larget Sub sum = " + largestSubSum);
            Console.ReadKey();
        }

        private static int FindLargetSubSum(int[] a)
        {
            int Max = 0;
            int tempSum = 0;
            int futureSum = 0;

            for (int i = 0; i < a.Length - 1; ++i)
            {
                futureSum = tempSum + a[i];
                if (futureSum > 0)
                {
                    tempSum = futureSum;
                    if (tempSum > Max)
                    {
                        Max = tempSum;
                    }
                }
            }
            return Max;
        }
    }
}
