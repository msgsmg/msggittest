using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAllPairsSumtoM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 9, 9, 10 };
            Console.WriteLine("Enter M");
            int M = Convert.ToInt32(Console.ReadLine());
            PrintAllPairsinSortedArraySumtoM(arr, M);
            Console.ReadKey();
        }

        private static void PrintAllPairsinSortedArraySumtoM(int[] arr, int M)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                if (arr[i] + arr[j] == M)
                {
                    Console.WriteLine("{" + arr[i] + ", " + arr[j] + "}");
                    i++;
                    j--;
                }
                else if (arr[i] + arr[j] < M)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
        }
    }
}
