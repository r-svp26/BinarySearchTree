using System;

namespace BinarySearchTree
{
    /*
     * UC1- create a simple binary search tree.
     * UC2- implement size method in bst.
     */
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
            mybinarynode.InsertNode(22);
            mybinarynode.InsertNode(40);
            mybinarynode.InsertNode(60);
            mybinarynode.InsertNode(95);
            mybinarynode.InsertNode(11);
            mybinarynode.InsertNode(65);
            mybinarynode.InsertNode(3);
            mybinarynode.InsertNode(16);
            mybinarynode.InsertNode(63);
            mybinarynode.InsertNode(67);
            mybinarynode.Display(mybinarynode.root);
            mybinarynode.Root();
            Console.WriteLine("Pre-Order Binary Search Tree");
            mybinarynode.PreOrder(mybinarynode.root);
            Console.WriteLine("In-Order Binary Search Tree");
            mybinarynode.InOrder(mybinarynode.root);
            Console.WriteLine("Post-Order Binary Search Tree");
            mybinarynode.PostOrder(mybinarynode.root);
            Console.WriteLine("The number of nodes in BST:{0}", mybinarynode.Size(mybinarynode.root));
        }
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program.BSTView();
        }
    }
}
