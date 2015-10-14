using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStacksUsingOneArray
{
    class Program
    {
        static int[] arr = new int[1000];
        static int tosA = -1;
        static int tosB = 999;

        static void Main(string[] args)
        {
            PushA(44);
            PushA(45);
            PushA(4);
            PushA(99);
            PushB(3);
            PushB(4);
            PushB(34);
            PushB(2);
            Console.WriteLine("PopA = " + PopA());
            Console.WriteLine("PopA = " + PopA());
            Console.WriteLine("PopA = " + PopA());
            Console.WriteLine("PopB = " + PopB());
            Console.WriteLine("PopB = " + PopB());
            Console.WriteLine("PopB = " + PopB());
            Console.ReadKey();

        }

        public static bool PushA(int val)
        {
            if (tosA < tosB && tosA < 1000)
            {
                arr[++tosA] = val;
                return true;
            }
            else
            {
                return false; // Can't push on stack A
            }
        }
        public static int PopA()
        {
            if (tosA >= 0)
            {
                return arr[--tosA];
            }
            else
            {
                return -1;
            }
        }
        public static bool PushB(int val)
        {
            if (tosB < 1000 && tosB > tosA)
            {
                arr[--tosB] = val;
                return true;
            }
            else
            { 
                // Cant push on stackB
                return false;
            }
        }
        public static int PopB()
        {
            if (tosB < 1000 && tosB > tosA)
            {
                return arr[++tosB];
            }
            else
            {
                return -1;
            }
        }
    }
}
