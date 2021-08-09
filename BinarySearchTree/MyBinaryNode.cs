using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
   public class MyBinaryNode<T> where T : IComparable
    {
        public INode<T> root;
        /// <summary>
        /// insert the node into bst.
        /// </summary>
        /// <param name="value"></param>
        public void InsertNode(T value)
        {
            INode<T> newNode = new INode<T>(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                INode<T> parent = root;
                INode<T> current = root;
                while (true)
                {
                    parent = current;
                    if (current.data.CompareTo(value) >= 0)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// display the binary search tree.
        /// </summary>
        /// <param name="parent"></param>
        public void Display(INode<T> parent)
        {
            if (parent != null)
            {
                Display(parent.left);
                Display(parent.right);
                Console.WriteLine("{0} is BST Node", parent.data);
            }
        }
        /// <summary>
        /// display the root node of BST.
        /// </summary>
        public void Root()
        {
            do
            {
                Console.WriteLine("BST Root Node:" + root.data);
                break;
            } while (root != null);
        }
        /// <summary>
        /// print the bst in pre-order.
        /// </summary>
        /// <param name="root"></param>
        public void PreOrder(INode<T> root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.data + " ");
            PreOrder(root.left);
            PreOrder(root.right);
        }
        /// <summary>
        /// print the bst in in-order.
        /// </summary>
        /// <param name="root"></param>
        public void InOrder(INode<T> root)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.left);
            Console.WriteLine(root.data + " ");
            InOrder(root.right);
        }
        /// <summary>
        /// print the bst in post-order.
        /// </summary>
        /// <param name="root"></param>
        public void PostOrder(INode<T> root)
        {
            if (root == null)
            {
                return;
            }
            PostOrder(root.left);
            PostOrder(root.right);
            Console.WriteLine(root.data + " ");
        }
        /// <summary>
        /// length of bst
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Size(INode<T> root)
        {
            if (root == null)
                return 0;
            else
                return (Size(root.left) + 1 + Size(root.right));
        }
        /// <summary>
        /// search the key into bst.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Search(INode<T> root, T key)
        {
            if (root == null)
            {
                return false;
            }
            if (root.data.CompareTo(key) == 0)
            {
                return true;
            }
            else if (root.data.CompareTo(key) < 0)
            {
                return Search(root.left, key);
            }
            else
            {
                return Search(root.right, key);
            } 
        }
    }
}
