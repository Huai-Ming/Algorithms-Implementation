using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchAlgorithms;

namespace SearchAlgorithms.DFS
{
    /// <summary>
    /// Represent the helper to search by depth first search basic the tree data strucuter
    /// </summary>
    public class DFSHelper
    {
        /// <summary>
        /// The tree to be searched.
        /// </summary>
        public static Tree<int> Tree
        {
            set;
            get;
        }
        /// <summary>Traverses and prints tree in
        /// Depth-First Search (DFS) manner</summary>
        /// <param name="root">the root of the tree to be
        /// traversed</param>
        /// <param name="spaces">the spaces used for
        /// representation of the parent-child relation</param>
        private static void PrintDFS(TreeNode<int> root, string spaces)
        {
            if (Tree.Root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode<int> child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }
        }

        /// <summary>Traverses and prints the tree in
        /// Depth-First Search (DFS) manner</summary>
        public static void TraverseDFS(Tree<int> tree)
        {
            PrintDFS(tree.Root, string.Empty);
        }
    }
}
