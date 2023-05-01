using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_BinarySearchTree
{
    internal class BinarySearchTree
    {
        private Node root;

        public bool IsEmpty()
        {
            return root == null;
        }

        public bool Add(int key)
        {
            Node newNode = new Node(key);
            if (IsEmpty())
            {
                root = newNode;
                return true;
            }

            Node leafNode = null;
            Node runnerNode = root;

            while (runnerNode != null)
            {
                leafNode = runnerNode;
                if (newNode.Key < runnerNode.Key)
                    runnerNode = runnerNode.Left;
                else if (newNode.Key > runnerNode.Key)
                    runnerNode = runnerNode.Right;
                else
                    return false;
            }

            if (newNode.Key < leafNode.Key)
                leafNode.Left = newNode;
            else
                leafNode.Right = newNode;
            return true;
        }

        public void Print()
        {
            BTreePrinterV2.Print(root);
        }

        public Node Find(int key)
        {
            Node runnerNode = root;
            while (runnerNode != null)
            {
                if (runnerNode.Key == key)
                    return runnerNode;
                else if (key < runnerNode.Key)
                    runnerNode = runnerNode.Left;
                else
                    runnerNode = runnerNode.Right;
            }
            return runnerNode;
        }

        public Node FindRecursive(int key)
        {
            return FindRecursive(key, root);
        }

        public Node FindRecursive(int key, Node node)
        {
            if (node == null)
                return null;
            else if (node.Key == key)
                return node;
            else if (key < node.Key)
                return FindRecursive(key, node.Left);
            else //key > node.Key
                return FindRecursive(key, node.Right);
        }

        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }

        private void TraversePreOrder(Node node)
        {
            if (node == null)
                return;

            Console.Write(node.Key + ", ");
            TraversePreOrder(node.Left);
            TraversePreOrder(node.Right);
        }

        public void TraverseInOrder() 
        { 
            TraverseInOrder(root);
        }

        public void TraverseInOrder(Node node)
        {
            if (node == null)
                return;

            TraverseInOrder(node.Left);
            Console.Write(node.Key + ", ");
            TraverseInOrder(node.Right);
        }

        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }

        public void TraversePostOrder(Node node)
        {
            if (node == null)
                return;

            TraversePostOrder(node.Left);
            TraversePostOrder(node.Right);
            Console.Write(node.Key + ", ");
        }

        public int GetHeight()
        {
            return GetHeight(root);
        }

        private int GetHeight(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                int heightFromLeft = GetHeight(node.Left);
                int heightFromRight = GetHeight(node.Right);

                if (heightFromLeft > heightFromRight)
                    return heightFromLeft + 1;
                else 
                    return heightFromRight + 1;
            }
        }

        public void TraverseLevelOrder()
        {
            int height = GetHeight(root);
            for (int i = 1; i <= height; i++)
            {
                //Here we have to call a function that calculates the level
                TraverseLevelOrder(root, i);
            }
        }

        private void TraverseLevelOrder(Node node, int level)
        {
            if (node == null)
                return;
            else if (level == 1)
                Console.Write(node.Key + ", ");
            else
            {
                TraverseLevelOrder(node.Left, level - 1);
                TraverseLevelOrder(node.Right, level - 1);
            }
        }

        public bool Remove(int key)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Error: The tree is Empty!\n");
                return false;
            }
            //Start with the root node
            Node runnerNode = root;

            //parent of the current node
            Node parent = null;

            //Find data to be removed in the BST
            while (runnerNode != null && runnerNode.Key != key)
            {
                //update the parent pointer
                parent = runnerNode;

                if (key < runnerNode.Key)
                    runnerNode = runnerNode.Left;
                else
                    runnerNode = runnerNode.Right;
            }

            //Check if key is not found
            if (runnerNode == null)
                return false;

            //runnerNode represents the node to delete

            //Case 1: Check if runnerNode is a leaf (has no children)
            if (runnerNode.Left == null && runnerNode.Right == null)
            {
                if (runnerNode == root)
                {
                    root = null;
                    return true;
                }
                else
                {
                    if (parent.Left == runnerNode)
                        parent.Left = null;
                    else
                        parent.Right = null;
                    return true;
                }
            }

            //Case 2: Check if current has one child
            if (runnerNode.Left == null && runnerNode.Right != null ||
                runnerNode.Left != null && runnerNode.Right == null)
            {
                Node child = (runnerNode.Left != null) ? runnerNode.Left : runnerNode.Right;

                if (runnerNode == root)
                {
                    root = child;
                    return true;
                }
                else
                {
                    if (parent.Left == runnerNode)
                        parent.Left = child;
                    else
                        parent.Right = child;
                    return true;
                }
            }

            //Case 3: Check if current has two children

            //Find the next highest node (lowest node in the right subtree)
            Node successor = FindNextHigherNode(runnerNode.Right);

            //store the data of successor in temp 
            int temp = successor.Key;

            //Delete the successor node that will replace the current
            Remove(successor.Key);

            //Update the data of current node by the successor data
            runnerNode.Key = temp;
            return true;
        }

        public Node FindNextHigherNode(Node parentNode)
        {
            Node current = parentNode;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }
    }
}
