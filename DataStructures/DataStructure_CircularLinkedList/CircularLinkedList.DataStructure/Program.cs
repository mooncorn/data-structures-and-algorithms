using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_CircularLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedListExample();
            Console.ReadKey();
        }

        static void CircularLinkedListExample()
        {
            var list = new CircularLinkedList<string>();
            list.AddLast("A");
            list.AddLast("B");
            list.AddLast("C");

            Console.WriteLine("\nLooping the Circular List 10 times: ");
            var current = list.Head;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}: {current.Data}");
                current = current.Next;
            }
            Console.WriteLine("\nFinish");
        }
    }
}
