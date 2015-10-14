using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrixBy90Degrees
{
    class Program
    {
        // Unfinished.
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int n = matrix.GetLength(0);
            for(int x =0;x<n/2;++x)
            {
                for(int y =0;y<n/2;++y)
                {
                    int temp = matrix[x,y];
                    matrix[x,y] = matrix[n-1-x,y];
                    matrix[n-1-x,y] = matrix[n-1-x,n-1-y];
                    matrix[n-1-x,n-1-y] = matrix[x,n-1-y];
                    matrix[x,n-1-y] = temp;
                }
            }

            // Print matrix
            for(int i =0;i<n;++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
