using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTripletsThatSumToK
{
    /// <summary>
    ///  Input = {5,2,3,0,-2,-3,-5} K = 0
    ///  OUTPUT = List : {-5,0,5}, {2,0,-2}, {3,0,-3}, {-2,-3,5}
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Value");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[] { 5, 2, 3, 0, -5, -2, -3 };
            //PrintTripletsSumToK(arr, k);
            PrintTripletsSumtoKBruteForce(arr, k);
            Console.ReadKey();
        }

        private static void PrintTripletsSumtoKBruteForce(int[] arr, int target)
        {
            int i;
            int j;
            int k;
            int n = arr.Length;
            List<Triplets> listOfTriplets = new List<Triplets>();
            for (i = 0; i < n; ++i)
            {
                for (j = i + 1; j < n; ++j)
                {
                    for (k = j + 1; k < n; ++k)
                    {
                        int inner_Sum = arr[j] + arr[k];
                        int total_Sum = inner_Sum + arr[i];
                        if (total_Sum == target)
                        {
                            listOfTriplets.Add(new Triplets(arr[i], arr[j], arr[k]));
                        }
                    }
                }
            }
            string str = listOfTriplets.ToString();
        }

        private static void PrintTripletsSumToK(int[] arr, int target)
        {
            List<Triplets> listOfTriplets = new List<Triplets>();
            int n = arr.Length;
            int k = n - 1;
            int j = 0;
            for (int i = 0; i < n; ++i)
            {
                j = i + 1;
                k = n - 1;
                while (j < k)
                {
                    int innter_sum = arr[j] + arr[k];
                    int total_sum = innter_sum + arr[i];
                    if (total_sum == target)
                    {
                        listOfTriplets.Add(new Triplets(arr[i], arr[j], arr[k]));
                        j++;
                        k--;
                    }
                    else if (total_sum < target)
                        j++;
                    else
                        k--;
                }
            }

            // Print Triplets from List;

            foreach (Triplets t in listOfTriplets)
            {
                Console.WriteLine(t.ToString());
            }
            Console.ReadKey();
        }
    }
    class Triplets
    {
        int x;
        int y;
        int z;
        public Triplets(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
