using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAllPossibleCombinationOfRElements
{
    class PringAllPossibleCombinationOfLenR
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int r = 2;
            int n = arr.Length;
            PringRCombinations(arr,r,n);
            // PrintRComboIterative(arr, r, n);
            Console.ReadKey();
        }

        private static void PringRCombinations(int[] arr, int r, int n)
        {
            int[] data = new int[r];
            PrintRComboRecur(arr, data,0, n-1,0,r);
        }

        private static void PrintRComboIterative(int[] arr, int r, int n)
        {
            int j = 0;
            for (int i = 0; i < n; ++i)
            {
                j = i;
                while (j != r && j<n)
                {
                    Console.Write("" + arr[j] + " ");
                    j++;
                    if (j == r)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
        private static void PrintRComboRecur(int[] arr, int[] data, int start, int end, int index,int r)
        {
            if (index == r)
            {
                for (int j = 0; j < r; ++j)
                {
                    Console.Write(" " + data[j]);
                }
                return;
            }

            for (int i = start; i <= end && end - i + 1 >= r - index; ++i)
            { 
                data[index] = arr[i];
                PrintRComboRecur(arr,data, i+1, end,index+1,r);
            }
            
        }
    }
}
