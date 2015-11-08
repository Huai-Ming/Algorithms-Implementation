using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    /// <summary>
    /// Represents a tree data structure
    /// </summary>
    /// <typeparam name="T">the type of value in the tree</typeparam>
    public class Tree<T>
    {
        //the root of the tree
        private TreeNode<T> root;

        /// <summary>
        /// Construct a tree
        /// </summary>
        /// <param name="value">the value of the root node</param>
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value");
            }

            this.root = new TreeNode<T>(value);
        }

        /// <summary>
        /// Construct a tree 
        /// </summary>
        /// <param name="value">the value of root node</param>
        /// <param name="children">the children of root node</param>
        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach(Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary>
        /// The root node or null if the tree is empty
        /// </summary>
        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }
        
    }
}
