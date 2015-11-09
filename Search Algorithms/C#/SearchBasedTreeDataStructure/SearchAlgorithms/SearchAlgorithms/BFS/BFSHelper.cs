using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms.BFS
{
    /// <summary>
    /// Represent the helper to implement the breadth first search based the tree data structure.
    /// </summary>
    public class BFSHelper
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
        private static void PrintBFS(TreeNode<int> root, string spaces)
        {
            if (Tree.Root == null)
            {
                return;
            }

            Queue<TreeNode<int>> visitedQueue =
           new Queue<TreeNode<int>>();
            visitedQueue.Enqueue(root);
            while (visitedQueue.Count > 0)
            {
                TreeNode<int> node = visitedQueue.Dequeue();
                Console.WriteLine(spaces + node.Value);

                TreeNode<int> child = null;

                for (int i = 0; i < node.ChildrenCount; i++)
                {
                    child = node.GetChild(i);
                    visitedQueue.Enqueue(child);
                }
            }
        }

        /// <summary>Traverses and prints the tree in
        /// Breadth-First Search (DFS) manner</summary>
        public static void TraverseBFS(Tree<int> tree)
        {
            PrintBFS(tree.Root, string.Empty);
        }
    }
}
