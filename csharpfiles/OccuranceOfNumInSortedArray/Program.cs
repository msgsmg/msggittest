using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccuranceOfNumInSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {1,4,5,6,7,9,11,33,55,66};

            Console.WriteLine("Enter a number to see if it exist in Array");
            int num = Convert.ToInt32(Console.ReadLine());
            bool exist = DoesNumberExistinArray(a, num);
            if (exist)
                Console.WriteLine("Number exist in Array");
            else
                Console.WriteLine("Number not found in Array");
            Console.ReadLine();

        }

        private static bool DoesNumberExistinArray(int[] a, int num)
        {
            int start = 0;
            int end = a.Length;
            int mid = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (a[mid] == num)
                {
                    return true;
                }
                else if (a[mid] > num)
                {
                    end = mid-1;
                }
                else
                {
                    start = mid+1;
                }
            }
            return false; // We didn't find number in array
        }
    }
}
