using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingStack
{
    class Program
    {
        public static Stack<int> s1 = new Stack<int>();
        public static Stack<int> s2 = new Stack<int>();

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; ++i)
            {
                enQueue(i + 1);
            }

            Console.WriteLine(deQueue());
            Console.ReadKey();
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine(deQueue());
            }
            Console.ReadKey();
            enQueue(1000);
            Console.WriteLine(deQueue());
            Console.ReadKey();

        }

        //private static void PrintQueue()
        //{
        //    throw new NotImplementedException();
        //}

        private static void enQueue(int p)
        {
            s1.Push(p);
        }
        private static int deQueue()
        {
            if(s1.Count ==0 && s2.Count == 0)
                return -1;
            else if(s1.Count !=0 && s2.Count==0)
            {
                while(s1.Count !=0)
                {
                    s2.Push(s1.Pop());
                }
                return s2.Pop();
            }
            else
            {
                return s2.Pop();
            }
        }

    }
}
