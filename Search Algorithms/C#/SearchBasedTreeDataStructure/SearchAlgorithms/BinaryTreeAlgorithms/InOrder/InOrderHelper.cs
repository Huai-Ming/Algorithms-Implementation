using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeAlgorithms.InOrder
{
    /// <summary>
    /// Represents the helper to traverse the binary tree by Left-Root-Right method
    /// </summary>
    public class InOrderHelper<T>
    {
        /// <summary>
        /// Print the each node value by order left root right;
        /// </summary>
        /// <param name="tree">The tree to be traverse</param>
        public static void PrintInOrder(BinaryTree<T> tree)
        {
            //Visit the left child
            if(tree.LeftChild != null)
            {
                PrintInOrder(tree.LeftChild);
            }

            //Visit the root of the tree
            Console.Write(tree.Value + " ");

            //Visit the right child
            if(tree.RightChild != null)
            {
                PrintInOrder(tree.RightChild);
            }


        }
    }
}
