using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    /// <summary>
    /// Represents a tree node
    /// </summary>
    /// <typeparam name="T">the type of tree node value</typeparam>
    public class TreeNode<T>
    {
        //Contains the vaue of tree node.
        private T value;

        //shows if the current node has a parent.
        private bool hasParent;

        //Contains the children of a tree node.
        private List<TreeNode<T>> children;

        /// <summary>
        /// Construct a tree node 
        /// </summary>
        /// <param name="value">the value of the node</param>
        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value");
            }

            this.value = value;
            this.children = new List<TreeNode<T>>();
        }

        /// <summary>
        /// The value of current node
        /// </summary>
        public T Value
        {
            set { this.value = value; }
            get { return this.value; }
        }

        /// <summary>
        /// The number of the tree node's children
        /// </summary>
        public int ChildrenCount
        {
            get { return this.children.Count(); }
        }

        /// <summary>
        /// Add a child to the node
        /// </summary>
        /// <param name="child">the child to be added.</param>
        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot add a null value");
            }

            if (child.hasParent)
            {
                throw new ArgumentException("The node has already had a parent");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        /// <summary>
        /// Get the child of node at the specific index
        /// </summary>
        /// <param name="index">the index of desired child</param>
        /// <returns></returns>
        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }

    }
}
