using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeAlgorithms.PreOrder
{
    /// <summary>
    /// Represents the helper to traverse the binary tree by Root-Left-Right method
    /// </summary>
    public class PreOrderHelper<T>
    {
        /// <summary>
        /// Print the each node value by order root left right;
        /// </summary>
        /// <param name="tree">The tree to be traverse</param>
        public static void PrintPreOrder(BinaryTree<T> tree)
        {          
            //Visit the root of the tree
            Console.Write(tree.Value + " ");

            //Visit the left child
            if (tree.LeftChild != null)
            {
                PrintPreOrder(tree.LeftChild);
            }

            //Visit the right child
            if (tree.RightChild != null)
            {
                PrintPreOrder(tree.RightChild);
            }


        }
    }
}
