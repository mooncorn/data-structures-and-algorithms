using System;

namespace DataStructure_LinkedStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStack = new LinkedStack<string>();
            myStack.Push("ALPHA");
            myStack.Push("BRAVO");
            myStack.Push("CHARLIE");
            myStack.Push("DELTA");

            Console.WriteLine("These are your elements:");
            while (myStack.Count() > 0)
            {
                Console.WriteLine(myStack.Pop());
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
