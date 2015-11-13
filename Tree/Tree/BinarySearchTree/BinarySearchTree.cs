using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    /// <summary>
    /// Represent the binary search tree data structure.
    /// </summary>
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        /// <summary>
        /// Represents binary search tree node
        /// </summary>
        /// <typeparam name="T">Specifies the type for the values in the nodes</typeparam>
        internal class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
        {
            //Contains the value of node
            internal T value;

            //Contains the parent of the node
            internal BinaryTreeNode<T> parent;

            //Contains the left child of the node
            internal BinaryTreeNode<T> leftChild;

            //Contains the right child of the node
            internal BinaryTreeNode<T> rightChild;

            /// <summary>
            /// Constructs the tree node 
            /// </summary>
            /// <param name="value">the value of the tree node</param>
            public BinaryTreeNode(T value)
            {
                if (value == null)
                {
                    //the null value cannot be compared,not allow to construct.
                    throw new ArgumentNullException("Cannot insert null value");
                }

                this.value = value;
                this.parent = null;
                this.leftChild = null;
                this.rightChild = null;
            }

            /// <summary>
            /// Override the method to return the value of the node
            /// </summary>
            /// <returns>the value of current node</returns>
            public string ToString()
            {
                return this.value.ToString();
            }

            //In the code we have also implemented the methods Equals(Object obj) and GetHashCode() too. A good (recommended) practice is these two methods to be consistent in their behavior, i.e. when two objects are the same, then their hash-code is the same.

            public override int GetHashCode()
            {
                return this.value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                BinaryTreeNode<T> other = (BinaryTreeNode<T>)obj;
                return this.CompareTo(other) == 0;
            }

            public int CompareTo(BinaryTreeNode<T> other)
            {
                return this.value.CompareTo(other.value);
            }
        }

        /// <summary>
        /// The root of the binary search tree
        /// </summary>
        private BinaryTreeNode<T> root;

        /// <summary>
        /// Constructs binary search tree
        /// </summary>
        public BinarySearchTree()
        {
            this.root = null;
        }


        ////Insert Algorithm:
        //Inserting (or adding) an element in a binary search tree means to put a new element somewhere in the tree so that the tree must stay ordered. Here is the algorithm: if the tree is empty, we add the new element as a root. Otherwise:
        //-     If the element is smaller than the root, we call recursively the same method to add the element in the left sub-tree.
        //-     If the element is bigger than the root, we call recursively to the same method to add the element in the right sub-tree.
        //-     If the element is equal to the root, we don’t do anything and exit from the recursion.

        /// <summary>
        /// Inserts the value to the binary search tree
        /// </summary>
        /// <param name="value">the value to be inserted</param>
        public void Insert(T value)
        {
            this.root = Insert(value, null, root);
        }


        /// <summary>
        /// Inserts the node to the binary tree by the given value
        /// </summary>
        /// <param name="value">the value to be inserted</param>
        /// <param name="parentNode">the parent of the new value</param>
        /// <param name="node">current node</param>
        /// <returns>the inserted value</returns>
        private BinaryTreeNode<T> Insert(T value, BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
        {
            //case 1 if the node is null so just add the node as the root 
            if (node == null)
            {
                node = new BinaryTreeNode<T>(value);
                node.parent = parentNode;
            }
            else //case 2 there are some nodes in the tree
            {
                int compareTo = value.CompareTo(node.value);
                if (compareTo < 0)// the value is smaller than the current node value, we will traverse the left child of the current node
                {
                    node.leftChild = Insert(value, node, node.leftChild);
                }
                else
                {
                    node.rightChild = Insert(value, node, node.rightChild);
                }
            }

            return node;
        }

        //Searching in a binary search tree is an operation which is more intuitive. In the sample code we have shown how the search of an element can be done without recursion and with iteration instead. The algorithm starts with element node, pointing to the root. After that we do the following:
        //-     If the element is equal to node, we have found the searched element and return it.
        //-     If the element is smaller than node, we assign to node its left successor, i.e. we continue the searching in the left sub-tree.
        //-     If the element is bigger than node, we assign to node its right successor, i.e. we continue the searching in the right sub-tree.

        /// <summary>
        /// Finds the given value in the tree and return the node which 
        /// </summary>
        /// <param name="value">the value to be found</param>
        /// <returns></returns>
        private BinaryTreeNode<T> Find(T value)
        {
            BinaryTreeNode<T> node = this.root;

            while (node != null)
            {
                int commpareTo = value.CompareTo(node.value);
                if (commpareTo > 0)
                {
                    node = node.rightChild;
                }
                else if (commpareTo < 0)
                {
                    node = node.leftChild;
                }
                else
                {
                    break;
                }
            }

            return node;
        }

        /// <summary>
        /// Return whether given value is in the tree
        /// </summary>
        /// <param name="value">the value to be checked</param>
        /// <returns>true if the value is found in the tree.</returns>
        public bool Contains(T value)
        {
            bool found = Find(value) != null;
            return found;
        }


        //The first step before we remove an element from the tree is to find it. We already know how it happens. After that, we have 3 cases:
        //-     If the node is a leaf – we point its parent’s reference to null. If the element has no parent, it means that it is a root and we just remove it.
        //-     If the node has only one sub-tree – left or right, it is replacing with the root of this sub-tree.
        //-     The node has two sub-trees. Then we have to find the smallest node in the right sub-tree and swap with it. After this exchange the node will have one sub-tree at most and then we remove it grounded on some of the above two rules. Here we have to say that it can be done analogical swap, just that we get the left sub-tree and it is the biggest element.

        /// <summary>
        /// Remove an element from the tree if it exists
        /// </summary>
        /// <param name="value">the value to be deleted.</param>
        public void Remove(T value)
        {
            BinaryTreeNode<T> node = Find(value);

            if (node != null)
            {
                Remove(node);
            }
        }

        private void Remove(BinaryTreeNode<T> node)
        {
            //Case 3: If the node has two children
            //Note that if we get here at the end
            //the note will be at most one child
            if (node.leftChild != null && node.rightChild != null)
            {
                BinaryTreeNode<T> replacement = node.rightChild;
                while (replacement.leftChild != null)
                {
                    replacement = replacement.leftChild;
                }

                //Here i still have some doubts
                node.value = replacement.value;
                node = replacement;
            }

            //Case 1 and Case 2; If the node has at most one child
            BinaryTreeNode<T> theChild = node.leftChild != null ? node.leftChild : node.rightChild;

            //If the element to be deleted has one child
            if(theChild != null)
            {
                theChild.parent = node.parent;

                //Handle the case when the node is root
                if(node.parent == null)
                {
                    this.root = theChild;
                }
                else
                {
                    //Replace the element with its child sub-tree
                    if(node.parent.leftChild == node)
                    {
                        node.parent.leftChild = theChild;
                    }
                    else
                    {
                        node.parent.rightChild = theChild;
                    }
                }
            }
            else
            {
                //Handle the case when the element is the root
                if(node.parent == null)
                {
                    this.root = theChild;
                }
                else
                {
                    //Remove the element  --it is the leaf
                    if(node.parent.leftChild  == node)
                    {
                        node.parent.leftChild = null;
                    }
                    else
                    {
                        node.parent.rightChild = null;
                    }
                }
            }
        }

        /// <summary>
        /// Traverses the ordered binary search tree and
        /// Tree starting from the given root node
        /// </summary>
        /// <param name="node">the starting node</param>
        private void PrintTreeDFS(BinaryTreeNode<T> node)
        {
            if(node != null)
            {
                PrintTreeDFS(node.leftChild);
                Console.Write(node.value + " ");
                PrintTreeDFS(node.rightChild);
            }
        }

        /// <summary>
        /// Traverses and prints the tree
        /// </summary>
        public void PrintTreeDFS()
        {
            PrintTreeDFS(this.root);
            Console.WriteLine();
        }
    }
}
