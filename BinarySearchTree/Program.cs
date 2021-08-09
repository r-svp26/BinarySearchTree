using System;

namespace BinarySearchTree
{
    class Program
    {
        static readonly MyBinaryNode<int> mybinarynode = new MyBinaryNode<int>();
        /// <summary>
        /// display all the BST operations.
        /// </summary>
        public static void BSTView()
        {
            mybinarynode.InsertNode(56);
            mybinarynode.InsertNode(30);
            mybinarynode.InsertNode(70);
            mybinarynode.Display(mybinarynode.root);
            mybinarynode.Root();
            Console.WriteLine("Pre-Order Binary Search Tree");
            mybinarynode.PreOrder(mybinarynode.root);
            Console.WriteLine("In-Order Binary Search Tree");
            mybinarynode.InOrder(mybinarynode.root);
            Console.WriteLine("Post-Order Binary Search Tree");
            mybinarynode.PostOrder(mybinarynode.root);
        }
        /// <summary>
        /// UC1- create a simple binary search tree.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program.BSTView();
        }
    }
}
