using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOccuranceOfNumberInSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 1, 2, 2, 2, 4, 4, 5, 6, 6, 7, 7, 7 };
            Console.WriteLine("Enter number for which you want to find occurance");
            int num = Convert.ToInt32(Console.ReadLine());
            int occure = FindNumOfOccurance(a, num);
            Console.WriteLine("" + num + " Occurs " + occure + " times in Array");
            Console.ReadKey();
        }

        private static int FindNumOfOccurance(int[] a, int num)
        {
            int start = 0;
            int end = a.Length-1;
            if (num < a[start])
                return 0; // Number is even less than smallest number in array
            if (num > a[end])
                return 0; // Number is grater than hightest number in array
            int mid = 0;
            int count = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (a[mid] == num)
                {
                    if ((a[start] == num) && (a[end] == num))
                    {
                        return end - start + 1;
                    }
                    else
                    {
                        int left = mid - 1;
                        int right = mid + 1;
                        while (a[left] == mid && left >= start)
                        {
                            left--;
                            count++;
                        }
                        while (a[right] == mid && right <= end)
                        {
                            right++;
                            count++;
                        }
                        return count;
                    }
                }
                else if (a[mid] > num)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return count;
        }
    }
}
