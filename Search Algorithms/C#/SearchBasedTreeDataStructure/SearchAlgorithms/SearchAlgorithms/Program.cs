using SearchAlgorithms.BFS;
using SearchAlgorithms.DFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create the tree from the sample
            Tree<int> tree =
                new Tree<int>(7,
                    new Tree<int>(19,
                        new Tree<int>(1),
                        new Tree<int>(12),
                        new Tree<int>(31)),
                    new Tree<int>(21),
                    new Tree<int>(14,
                        new Tree<int>(23),
                        new Tree<int>(6))
                );

            //    7
            //  19, 21, 14
            // 1,12,31    23,6
            // Traverse and print the tree using Depth-First-Search
            //DFSHelper.Tree = tree;
            //DFSHelper.TraverseDFS(tree);

            // Traverse and print the tree using Breadth-First-Search
            BFSHelper.Tree = tree;
            BFSHelper.TraverseBFS(tree);

            Console.Read();
        }
    }
}
