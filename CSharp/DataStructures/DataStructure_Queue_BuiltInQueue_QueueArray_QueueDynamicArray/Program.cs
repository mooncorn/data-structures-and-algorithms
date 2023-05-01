using System;
using System.Collections.Generic;

namespace DataStructure_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuiltInQueueExample();

            //QueueArrayExample();

            //QueueDynamicArrayExample();

            Console.ReadKey();
        }

        static void BuiltInQueueExample()
        {
            //Built-in Queue class in .NET
            Queue<int> myQueue = new Queue<int>();

            //Use the Enqueue method to add items in the queue:
            myQueue.Enqueue(12);
            myQueue.Enqueue(2);
            myQueue.Enqueue(0);
            myQueue.Enqueue(6);

            Console.Write("myQueue.Contains(77): ");
            Console.WriteLine(myQueue.Contains(77));
            Console.Write("myQueue.Contains(2): ");
            Console.WriteLine(myQueue.Contains(2));

            //Use the Peek method to get the item in the front
            //without removing from the queue:
            Console.Write("myQueue.Peek(): ");
            Console.WriteLine(myQueue.Peek());

            Console.Write("myQueue.Count: ");
            Console.WriteLine(myQueue.Count);

            Console.WriteLine("\n*************");
            while (myQueue.Count > 0)
            {
                //Use the Dequeue method to get the item and
                //remove from the queue:
                int item = myQueue.Dequeue();
                Console.Write("Retrieving item: ");
                Console.WriteLine(item);
            }

            Console.Write("myQueue.Count: ");
            Console.WriteLine(myQueue.Count);
        }

        static void QueueArrayExample()
        {
            QueueArray<string> myQueue = new QueueArray<string>(3);
            bool addMore;
            int counter = 0;
            do
            {
                Console.Write($"Element {counter + 1} value: ");
                myQueue.Enqueue(Console.ReadLine());

                Console.Write("\nAdd more (y/n)? ");
                addMore = Console.ReadLine() == "y";
                counter++;

                if (addMore)
                    Console.WriteLine();

            } while (addMore);

            Console.WriteLine("\nThese are your elements:");
            while(myQueue.Count() > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        }

        static void QueueDynamicArrayExample()
        {
            var myQueue = new QueueDynamicArray<string>();
            bool addMore;
            int counter = 0;
            do
            {
                Console.Write($"Element {counter + 1} value: ");
                myQueue.Enqueue(Console.ReadLine());

                Console.Write("\nAdd more (y/n)? ");
                addMore = Console.ReadLine() == "y";
                counter++;

                if (addMore)
                    Console.WriteLine();

            } while (addMore);

            Console.WriteLine("\nThese are your elements:");
            while (myQueue.Count() > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        }
    }
}
