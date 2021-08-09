using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class INode<T>
    {
        public T data;
        public INode<T> left;
        public INode<T> right;
        /// <summary>
        /// initialization of the nodes.
        /// </summary>
        /// <param name="data"></param>
        public INode(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}
