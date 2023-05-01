using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleDoublyLinkedList();
            Console.ReadKey();
        }

        static void ExampleDoublyLinkedList()
        {
            var list = new DoublyLinkedList<string>();
            list.AddLast("A");
            list.AddLast("B");
            list.AddLast("C");
            list.AddLast("D");
            
            Console.WriteLine("Left to right order: ");
            Console.WriteLine(list.ToString());

            Console.WriteLine("\nRight to left order: ");
            Console.WriteLine(list.ToStringReverse());
        }
    }
}
