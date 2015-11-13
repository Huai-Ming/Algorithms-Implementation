using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree<string> tree = new BinarySearchTree<string>();
            tree.Insert("Microsoft");
            tree.Insert("Telerik");
            tree.Insert("Google");
            tree.Insert("Loogle");
            tree.Insert("IBM");
            tree.PrintTreeDFS();

            Console.WriteLine(tree.Contains("Google"));
            Console.WriteLine(tree.Contains("GG"));
            tree.Remove("IBM");
            Console.WriteLine(tree.Contains("IBM"));
            tree.PrintTreeDFS();

            Console.ReadKey();
        }
    }
}
