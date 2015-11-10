using BinaryTreeAlgorithms.InOrder;
using BinaryTreeAlgorithms.PostOrder;
using BinaryTreeAlgorithms.PreOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create the binary tree
            BinaryTree<int> binaryTree = new BinaryTree<int>(14,
                                       new BinaryTree<int>(19,new BinaryTree<int>(23),new BinaryTree<int>(6, new BinaryTree<int>(10),new BinaryTree<int>(21))),
                                       new BinaryTree<int>(15,new BinaryTree<int>(3),null)     
                                           );
            //                          14
            //              19                          15
            //      23           6                  3
            //                10    21
            //Inorder traversal 23, 19,10,6,21,14,3,15
            InOrderHelper<int>.PrintInOrder(binaryTree);

            Console.WriteLine();
            //Preorder traversal 14,19,23,6,10,21,15,3
            PreOrderHelper<int>.PrintPreOrder(binaryTree);

            Console.WriteLine();
            //Postorder traversal 23,10,21,6,19,3,15,14
            PostOrderHelper<int>.PrintPostOrder(binaryTree);

            Console.Read();
        }
    }
}
