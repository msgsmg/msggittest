using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedArrayWithougExtraMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] one = new int[] {1,3,4,0,0,0};
            int[] two = new int[] {2,5};
            Merge(one, two);
            Console.ReadKey();
        }

        private static void Merge(int[] big, int[] small)
        {
            int i = 3;
            int j = small.Length-1;
            int k = i + j-1;
            while (i >0 && j > 0)
            {
                if (big[i] > small[j])
                {
                    big[k--] = big[i--];
                }
                else
                {
                    big[k--] = small[j--];
                }
            }
            while (j > 0)
            {
                big[k--] = small[j--];
            }

            for (int m = 0; m < big.Length - 1; ++m)
                Console.WriteLine(big[m]);
        }
    }
}
