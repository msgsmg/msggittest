using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindValueInSorted2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { { 1, 2, 3, }, { 4, 5, 6 }, { 7, 8, 9 } };
            FindElement(arr, 5);
            Console.ReadKey();
        }

        private static void FindElement(int[,] arr, int p)
        {
            int row = 2;
            int col = 0;
            while (row >= 0 && col <= 2)
            {
                if (arr[row, col] > p)
                {
                    row--;
                }
                else if (arr[row, col] < p)
                    col++;
                else
                {
                    Console.WriteLine("Found element " + p + "At location" + row + " " + col);
                    return;
                }
            }
        }
    }
}
