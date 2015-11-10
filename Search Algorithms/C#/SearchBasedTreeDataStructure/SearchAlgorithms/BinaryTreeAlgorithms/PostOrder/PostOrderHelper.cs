using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeAlgorithms.PostOrder
{
    // <summary>
    /// Represents the helper to traverse the binary tree by Left-Right-Root method
    /// </summary>
    public class PostOrderHelper<T>
    {
        /// <summary>
        /// Print the each node value by order left right root;
        /// </summary>
        /// <param name="tree">The tree to be traverse</param>
        public static void PrintPostOrder(BinaryTree<T> tree)
        {

            //Visit the left child
            if (tree.LeftChild != null)
            {
                PrintPostOrder(tree.LeftChild);
            }

            //Visit the right child
            if (tree.RightChild != null)
            {
                PrintPostOrder(tree.RightChild);
            }

            //Visit the root of the tree
            Console.Write(tree.Value + " ");

        }
    }
}
