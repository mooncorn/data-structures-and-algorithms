using System;

namespace DataStructure_LinkedQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new LinkedQueue<string>();
            myQueue.Enqueue("ALPHA");
            myQueue.Enqueue("BRAVO");
            myQueue.Enqueue("CHARLIE");
            myQueue.Enqueue("DELTA");

            Console.WriteLine("These are your elements:");
            while (myQueue.Count() > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
