using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTreeByLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build Tree
            //          4
            //      2       6
            //  1     3  5      7  
            Tree myTree = new Tree(4);
            myTree.left = new Tree(2);
            myTree.right = new Tree(6);
            myTree.left.left = new Tree(1);
            myTree.left.right = new Tree(3);
            myTree.right.left = new Tree(5);
            myTree.right.right = new Tree(7);

            PrintTreeLevel(myTree);
            Console.ReadKey();
        }

        // Print Tree by level
        private static void PrintTreeLevel(Tree root)
        {
            if (root == null)
                return;
            Queue<Tree> currQ = new Queue<Tree>();
            Queue<Tree> nextQ = new Queue<Tree>();

            currQ.Enqueue(root);
            while (currQ.Count > 0)
            {
                Tree tmp = currQ.Dequeue();
                if (tmp != null)
                {
                    Console.Write(tmp.value + " ");
                    nextQ.Enqueue(tmp.left);
                    nextQ.Enqueue(tmp.right);
                }
                if (currQ.Count == 0)
                {
                    Console.WriteLine();
                    Queue<Tree> temp = currQ;
                    currQ = nextQ;
                    nextQ = temp;
                }
            }
        }

    }

    // Tree class
    public class Tree
    {
        public int value;
        public Tree left;
        public Tree right;
        public Tree(int val)
        {
            value = val;
            left = right = null;
        }
    }
}
