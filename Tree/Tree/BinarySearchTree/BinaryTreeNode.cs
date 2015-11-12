using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    /// <summary>
    /// Represents binary search tree node
    /// </summary>
    /// <typeparam name="T">Specifies the type for the values in the nodes</typeparam>
    public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
    {
        //Contains the value of node
        internal T value;

        //Contains the parent of the node
        internal BinaryTreeNode<T> parent;

        //Contains the left child of the node
        internal BinaryTreeNode<T> leftChild;

        //Contains the right child of the node
        internal BinaryTreeNode<T> rightChild;

        /// <summary>
        /// Constructs the tree node 
        /// </summary>
        /// <param name="value">the value of the tree node</param>
        public BinaryTreeNode(T value)
        { 
           if(value == null)
           {
               //the null value cannot be compared,not allow to construct.
               throw new ArgumentNullException("Cannot insert null value");
           }

           this.value = value;
           this.parent = null;
           this.leftChild = null;
           this.rightChild = null;
        }

        /// <summary>
        /// Override the method to return the value of the node
        /// </summary>
        /// <returns>the value of current node</returns>
        public string ToString()
        {
            return this.value.ToString();
        }

        //In the code we have also implemented the methods Equals(Object obj) and GetHashCode() too. A good (recommended) practice is these two methods to be consistent in their behavior, i.e. when two objects are the same, then their hash-code is the same.

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BinaryTreeNode<T> other = (BinaryTreeNode<T>)obj;
            return this.CompareTo(other) == 0;
        }

        public int CompareTo(BinaryTreeNode<T> other)
        {
            return this.value.CompareTo(other.value);
        }
    }
}
