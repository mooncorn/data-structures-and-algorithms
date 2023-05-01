using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bst = new BinarySearchTree();

            Console.WriteLine("Initial BST:");

            bst.Add(6);
            bst.Add(2);
            bst.Add(1);
            bst.Add(4);
            bst.Add(3);
            bst.Add(5);
            bst.Add(8);
            bst.Add(7);
            bst.Add(15);
            bst.Add(12);
            bst.Add(20);
            bst.Add(16);

            bst.Print();

            Console.WriteLine("\nRemoving node 3 (case 1 - leaf node) ...");
            bst.Remove(3);
            bst.Print();

            Console.WriteLine("\nRemoving node 4 (case 2 - a node with 1 child) ...");
            bst.Remove(4);
            bst.Print();

            Console.WriteLine("\nRemoving node 8 (case 3 - a node with 2 children) ...");
            bst.Remove(8);
            bst.Print();

            Console.WriteLine("Tree size: " + bst.GetHeight());

            Console.WriteLine("Find 9");
            if (bst.FindRecursive(9) == null)
                Console.WriteLine("The node 9 is not found");
            else
                Console.WriteLine("The node 9 is found");

            Console.WriteLine("\nPre-Order Traverse:");
            bst.TraversePreOrder();

            Console.WriteLine("\n\nIn-Order Traverse:");
            bst.TraverseInOrder();

            Console.WriteLine("\n\nPost-Order Traverse:");
            bst.TraversePostOrder();

            Console.WriteLine("\n\nLevel-Order Traverse:");
            bst.TraverseLevelOrder();
            Console.ReadKey();
        }
    }
}
