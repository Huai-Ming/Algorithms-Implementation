using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeAlgorithms
{
    /// <summary>
    /// Represents a binary tree
    /// </summary>
    /// <typeparam name="T">Type of values in the tree</typeparam>
    public class BinaryTree<T>
    {
        /// <summary>
        /// The value stored in the current node
        /// </summary>
        public T Value { set; get; }

        /// <summary>
        /// The left child of current node
        /// </summary>
        public BinaryTree<T> LeftChild { get; private set; }

        /// <summary>
        /// The right child of current node
        /// </summary>
        public BinaryTree<T> RightChild { get; private set; }

        /// <summary>
        /// Constructs a binary tree
        /// </summary>
        /// <param name="value">the vlaue of the tree node</param>
        /// <param name="leftChild">the left child of the tree</param>
        /// <param name="rightChild">the right child of the tree</param>
        public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        /// <summary>
        /// Constructs a binary tree with no children
        /// </summary>
        /// <param name="value"></param>
        public BinaryTree(T value): this(value,null,null)
        {

        }
    }
}
