using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLinkListFromKthElement
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkList link = new MyLinkList(1);
            link.next = new MyLinkList(2);
            link.next.next = new MyLinkList(3);
            link.next.next.next = new MyLinkList(4);
            link.next.next.next.next = new MyLinkList(5);
            PrintList(link);

            MyLinkList newHead= RotateLinkList(link, 3);
            PrintList(newHead);
            Console.ReadKey();

        }

        private static MyLinkList RotateLinkList(MyLinkList link, int p)
        {
            MyLinkList t = link;
            while (p != 0)
            {
                t = t.next;
                p--;
                if (t == null)
                    return null;
            }
            //Set new head
            MyLinkList newHead = t.next;
            // Set t.next = null to make it end of list
            t.next = null;
            MyLinkList newHeadTemp = newHead;
            while (newHeadTemp.next != null)
            {
                newHeadTemp = newHeadTemp.next;
            }
            newHeadTemp.next = newHead;
            return newHead;
        }

        private static void PrintList(MyLinkList link)
        {
            MyLinkList t = link;
            while (t != null)
            {
                Console.Write("" + t.val + " ");
                t = t.next;
            }
        }
    }
    class MyLinkList
    {
        public MyLinkList next;
        public int val;
        public MyLinkList(int a)
        {
            val = a;
            next = null;
        }
    }
}
