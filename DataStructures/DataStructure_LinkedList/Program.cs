using System;
using DataStructure_LinkedList.Nodes;

namespace DataStructure_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NumericNodeExample();
            //GenericNodeExample()
            LinkedListExample();

            Console.ReadKey();
        }

        static void NumericNodeExample()
        {
            var nodeA = new NumericNode(10);
            var nodeB = new NumericNode(20);
            var nodeC = new NumericNode(30);

            nodeA.Next = nodeB;
            nodeB.Next = nodeC;

            var tempNode = nodeA;
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Data);
                tempNode = tempNode.Next;
            }

            //Comparing node values:
            if (nodeB < nodeA)
                Console.WriteLine($"nodeB < nodeA because {nodeB.Data} < {nodeA.Data}");
            else
                Console.WriteLine($"nodeB >= nodeA because {nodeB.Data} >= {nodeA.Data}");
        }

        static void GenericNodeExample()
        {
            var nodeA = new GenericNode<string>("ALPHA");
            var nodeB = new GenericNode<string>("BRAVO");
            var nodeC = new GenericNode<string>("CHARLIE");

            nodeA.Next = nodeB;
            nodeB.Next = nodeC;

            var tempNode = nodeA;
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Data);
                tempNode = tempNode.Next;
            }

            //Comparing node values:
            if (nodeB < nodeA)
                Console.WriteLine($"nodeB < nodeA because {nodeB.Data} < {nodeA.Data} in alphabetical order");
            else
                Console.WriteLine($"nodeB >= nodeA because {nodeB.Data} >= {nodeA.Data} in alphabetical order");
        }

        static void LinkedListExample()
        {
            LinkedList<int> myList = new LinkedList<int>();
            
            var node20 = new GenericNode<int>(20);
            myList.AddFirst(node20);

            var node10 = myList.AddFirst(10);
            Console.WriteLine("\nCurrent LinkedList values after AddFirst(10):");
            Console.WriteLine(myList);

            var node30 = myList.AddLast(30);
            Console.WriteLine("\nCurrent LinkedList values after AddLast(30):");
            Console.WriteLine(myList);

            var node40 = myList.AddLast(40);
            Console.WriteLine("\nCurrent LinkedList values after AddLast(40):");
            Console.WriteLine(myList);

            var node35 = myList.AddAfter(node30, 35);
            Console.WriteLine("\nCurrent LinkedList values after AddAfter(node30, 35):");
            Console.WriteLine(myList);

            var firstNode = myList.RemoveFirst();
            Console.WriteLine("\nRemoveFirst() returned node: " + firstNode.Data);
            Console.WriteLine("\nRemoved node: " + firstNode.Data);
            Console.WriteLine("Current LinkedList values:");
            Console.WriteLine(myList);

            var lastNode = myList.RemoveLast();
            Console.WriteLine("\nRemoveLast() returned node: " + lastNode.Data);
            Console.WriteLine("\nCurrent LinkedList values after RemoveLast():");
            Console.WriteLine(myList);

            myList.Remove(node30);
            Console.WriteLine("\nCurrent LinkedList values after Remove(node30):");
            Console.WriteLine(myList);

            Console.WriteLine("\nContains(30): " + myList.Contains(30));
            Console.WriteLine("Contains(35): " + myList.Contains(35));

            myList.AddLast(35);
            Console.WriteLine("\nCurrent LinkedList values after AddLast(35):");
            Console.WriteLine(myList);

            myList.AddLast(36);
            Console.WriteLine("\nCurrent LinkedList values after AddLast(36):");
            Console.WriteLine(myList);

            var foundNode = myList.Find(35);
            if (foundNode != null)
            {
                Console.WriteLine("\nmyList.Find(35) found a node ");
                if (foundNode.Next != null)
                    Console.WriteLine("The next node is " + foundNode.Next.Data);
                else
                    Console.WriteLine("This is the last node");
            }
            else
                Console.WriteLine("\nmyList.Find(35) did not found the node");

            
            var foundLastNode = myList.FindLast(35);
            if (foundLastNode != null)
            {
                Console.WriteLine("\nmyList.FindLast(35) found a node ");
                if (foundLastNode.Next != null)
                    Console.WriteLine("The next is " + foundLastNode.Next.Data);
                else
                    Console.WriteLine("This is the last node");
            }
            else
                Console.WriteLine("\nmyList.FindLast(35) did not found the node");

            Console.WriteLine("\nCurrent LinkedList values:");
            Console.WriteLine(myList);

            Console.WriteLine("\nToStringReverse() values:");
            Console.WriteLine(myList.ToStringReverse());

            myList.Clear();
            Console.WriteLine("\nCurrent LinkedList values after Clear():");
            Console.WriteLine(myList);
        }
    }
}
