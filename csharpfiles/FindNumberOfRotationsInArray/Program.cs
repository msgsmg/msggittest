using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumberOfRotationsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, 5, 1, 2, };
            int rotations = FindRotatins(arr);
            Console.WriteLine("Rotations = " + rotations);
            Console.ReadKey();

            arr = new int[] { 3, 4, 5, 6, 2 };
            Console.WriteLine("Rotations = " + FindRotatins(arr));
            Console.ReadKey();

        }

        private static int FindRotatins(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            int mid = 0;
            while (start < end)
            {
                if (arr[start] < arr[end])
                {
                    return end + 1;
                }
                // we find correct cut point - 5 in our example
                else
                {
                    mid = (start + end) / 2;
                    if (arr[start] < arr[mid] && arr[mid + 1] < arr[end])
                    {
                        return mid + 1;
                    }
                    else if (arr[start] <= arr[mid])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            // if we dont' return from loop
            return -1;
        }
    }
}
