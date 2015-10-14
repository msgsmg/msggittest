using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAllIncreasingSequence
{
    /// <summary>
    /// 
    /// Input: k = 2, n = 3
    /// Output: 1 2
    ///    1 3
    ///    2 3 
    /// </summary>
    class PrintAllIncreasingSequenceFromKToN
    {
        static void Main(string[] args)
        {
            PrintSequence(2, 3);
        }

        private static void PrintSequence(int k, int n)
        { 
            int[] arr =new int[1000];
            PrintSeqUntil(k, n, arr, 0);
        }

        private static void PrintSeqUntil(int k, int n, int[] arr, int len)
        {
            if (len == n)
                PrintArray(arr);
            int i;
            if (len == 0)
                i = 1;
            else
                i = arr[len - 1];
            len++;
            while (i <= n)
            {
                arr[len - 1] = i;
                PrintSeqUntil(i, n, arr, len);
                i++;
            }
            len--;
        }

        private static void PrintArray(int[] arr)
        {
            Console.WriteLine("Printing array");
            for (int i = 0; i < arr.Length; ++i)
                Console.WriteLine(arr[i]);
        }
    }
}
