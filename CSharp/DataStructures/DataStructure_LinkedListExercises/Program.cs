using System;
using DataStructure_LinkedList.Nodes;

namespace DataStructure_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //UNCOMMENT TO RUN ONE OF THE FOLLOWING EXERCISES:
            //Exercise1_FindNodeFromEndToStart();
            //Exercise2_IsPalindrome();
            Exercise3_DeleteDuplicates();

            Console.ReadKey();
        }

        static void Exercise1_FindNodeFromEndToStart()
        {
            LinkedList<int> list = new LinkedList<int>();
            int[] values = { 1, 2, 3 };
            foreach (int v in values)
            {
                list.AddLast(v);
            }

            int endToStartNumber = 3;
            var node = list.FindNodeFromEndToStartV1(endToStartNumber);
            //var node = list.FindNodeFromEndToStartV2(endToStartNumber);

            Console.WriteLine($"Node {endToStartNumber} from end to start has this value: ");
            if (node == null)
                Console.WriteLine("null");
            else
                Console.WriteLine(node.Data);
        }

        static void Exercise2_IsPalindrome()
        {
            LinkedList<int> list = new LinkedList<int>();
            int[] values = { 1, 2, 3, 2, 1 }; //a palindrome
            //int[] values = { 1, 2, 3, 2, 2 }; //NOT a palindrome
            foreach (int v in values)
            {
                list.AddLast(v);
            }

            Console.Write(list);
            if (list.IsPalindrome())
                Console.WriteLine(" is a palindrome.");
            else
                Console.WriteLine(" is NOT a palindrome.");
        }

        static void Exercise3_DeleteDuplicates()
        {
            LinkedList<int> list = new LinkedList<int>();
            int[] values = { 1, 2, 1, 1, 3, 3, 4, 5, 6, 7, 8, 7 };
            foreach (int v in values)
            {
                list.AddLast(v);
            }

            Console.WriteLine("Before:");
            Console.WriteLine(list);

            list.DeleteDuplicatesUsingBuffer();
            //list.DeleteDuplicatesNoBuffer();

            Console.WriteLine("\nAfter:");
            Console.WriteLine(list);
        }
    }
}
