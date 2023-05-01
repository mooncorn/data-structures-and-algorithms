using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BuiltInStackExample();
            StackArrayExample();
            Console.ReadLine();
        }

        static void BuiltInStackExample()
        {
            Stack<int> myStack = new Stack<int>();

            myStack.Push(6);
            myStack.Push(0);
            myStack.Push(2);
            myStack.Push(12);

            Console.Write("myStack.Contains(77): ");
            Console.WriteLine(myStack.Contains(77));
            Console.Write("myStack.Contains(6): ");
            Console.WriteLine(myStack.Contains(6));

            Console.Write("myStack.Peek(): ");
            Console.WriteLine(myStack.Peek());

            Console.Write("myStack.Count: ");
            Console.WriteLine(myStack.Count);

            while (myStack.Count > 0)
            {
                int item = myStack.Pop();
                Console.Write("Retrieving item: ");
                Console.WriteLine(item);
            }

            Console.Write("myStack.Count: ");
            Console.WriteLine(myStack.Count);

        }

        static void StackArrayExample()
        {
            StackArray<string> myStack = new StackArray<string>(3);
            bool addMore;
            int counter = 0;
            do
            {
                Console.Write($"Element {counter + 1} value: ");
                myStack.Push(Console.ReadLine());

                Console.Write("\nAdd more (y/n)? ");
                addMore = Console.ReadLine() == "y";
                counter++;

                if (addMore)
                    Console.WriteLine();

            } while (addMore);

            Console.WriteLine("\nThese are your elements:");
            while (myStack.Count() > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
}
