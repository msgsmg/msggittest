using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindifBinaryTreeisBST
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
            myTree.left = new Tree( 2);
            myTree.right = new Tree(6);
            myTree.left.left = new Tree(1);
            myTree.left.right = new Tree(3);
            myTree.right.left = new Tree(5);
            myTree.right.right = new Tree(7);
            Console.WriteLine("Is My Tree BST ? " + IsBst(myTree, Int32.MinValue, Int32.MaxValue));
            Console.ReadKey();
        }

        private static bool IsBst(Tree a, int small, int large)
        {
            if (a == null)
                return true;
            if (a.value > small && a.value < large)
            {
                bool IsLeftBST = IsBst(a.left, small, a.value);
                bool IsRightBST = IsBst(a.right, a.value, large);
                return IsLeftBST && IsRightBST;
            }
            return false;
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
