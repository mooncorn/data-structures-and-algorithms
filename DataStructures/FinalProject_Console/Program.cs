using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var initialList = new DCLinkedList<int>();

            var node1 = new GenericNode<int>(3);
            var node2 = new GenericNode<int>(5);
            var node3 = new GenericNode<int>(7);
            var node4 = new GenericNode<int>(5);
            var node5 = new GenericNode<int>(1);
            //var node6 = new GenericNode<int>(7);

            initialList.AddLast(node1);
            initialList.AddLast(node2);
            initialList.AddLast(node3);
            initialList.AddLast(node4);
            initialList.AddLast(node5);
            //initialList.AddLast(node6);

            Console.WriteLine("\n============= (1) AddFirst =============");
            var list1 = initialList.Copy();
            Console.WriteLine($"Nodes: {list1}\t\tCount: {list1.Count}");
            Console.WriteLine("# Adding 1");
            list1.AddFirst(1);
            Console.WriteLine($"Nodes: {list1}\t\tCount: {list1.Count}");

            Console.WriteLine("\n============= (2) AddLast ==============");
            var list2 = initialList.Copy();
            Console.WriteLine($"Nodes: {list2}\t\tCount: {list2.Count}");
            Console.WriteLine("# Adding 1");
            list2.AddLast(1);
            Console.WriteLine($"Nodes: {list2}\t\tCount: {list2.Count}");

            Console.WriteLine("\n============= (3) AddAfter =============");
            var list3 = initialList.Copy();
            Console.WriteLine($"Nodes: {list3}\t\tCount: {list3.Count}");
            Console.WriteLine("# Adding 4 After 7");
            list3.AddAfter(list3.Head.Next.Next, new GenericNode<int>(4));
            Console.WriteLine($"Nodes: {list3}\t\tCount: {list3.Count}");

            Console.WriteLine("\n============= (4) AddBefore ============");
            var list4 = initialList.Copy();
            Console.WriteLine($"Nodes: {list4}\t\tCount: {list4.Count}");
            Console.WriteLine("# Adding 4 Before 7");
            list4.AddBefore(list4.Head.Next.Next, new GenericNode<int>(4));
            Console.WriteLine($"Nodes: {list4}\t\tCount: {list4.Count}");

            Console.WriteLine("\n============ (5) RemoveFirst ===========");
            var list5 = initialList.Copy();
            Console.WriteLine($"Nodes: {list5}\t\tCount: {list5.Count}");
            Console.WriteLine("# Removing First");
            list5.RemoveFirst();
            Console.WriteLine($"Nodes: {list5}\t\tCount: {list5.Count}");

            Console.WriteLine("\n============ (6) RemoveLast ============");
            var list6 = initialList.Copy();
            Console.WriteLine($"Nodes: {list6}\t\tCount: {list6.Count}");
            Console.WriteLine("# Removing Last");
            list6.RemoveLast();
            Console.WriteLine($"Nodes: {list6}\t\tCount: {list6.Count}");

            Console.WriteLine("\n============== (7) Remove ==============");
            var list7 = initialList.Copy();
            Console.WriteLine($"Nodes: {list7}\t\tCount: {list7.Count}");
            Console.WriteLine("# Removing 7");
            list7.Remove(list7.Head.Next.Next);
            Console.WriteLine($"Nodes: {list7}\t\tCount: {list7.Count}");

            Console.WriteLine("\n============= (8) FindFirst ============");
            var list8 = initialList.Copy();
            Console.WriteLine($"Nodes: {list8}\t\tCount: {list8.Count}");
            Console.WriteLine("# Finding First 5");
            Console.WriteLine(list8.FindFirst(5).Data);

            Console.WriteLine("\n============= (9) FindLast =============");
            var list9 = initialList.Copy();
            Console.WriteLine($"Nodes: {list9}\t\tCount: {list9.Count}");
            Console.WriteLine("# Finding Last 5");
            Console.WriteLine(list9.FindLast(5).Data);

            Console.WriteLine("\n============== (10) Merge ==============");
            var list10 = initialList.Copy();
            var list101 = initialList.Copy();
            Console.WriteLine($"Nodes: {list10}\t\tCount: {list10.Count}");
            Console.WriteLine($"Nodes: {list101}\t\tCount: {list101.Count}");
            Console.WriteLine("# Merging");
            list10.Merge(list101);
            Console.WriteLine($"Nodes: {list10}\t\tCount: {list10.Count}");

            Console.WriteLine("\n============== (11) Clear ==============");
            var list11 = initialList.Copy();
            Console.WriteLine($"Nodes: {list11}\t\tCount: {list11.Count}");
            Console.WriteLine("# Clearing");
            list11.Clear();
            Console.WriteLine($"Nodes: {list11}\t\tCount: {list11.Count}");

            Console.WriteLine("\n============= (12) ToString ============");
            var list12 = initialList.Copy();
            Console.WriteLine($"Nodes: {list12}\t\tCount: {list12.Count}");

            Console.WriteLine("\n========= (13) ToStringReverse =========");
            var list13 = initialList.Copy();
            Console.WriteLine($"Nodes: {list13.ToStringReverse()}\t\tCount: {list13.Count}");

            Console.WriteLine("\n=========== (14) RotateRight ===========");
            var list14 = initialList.Copy();
            Console.WriteLine($"Nodes: {list14}\t\tCount: {list14.Count}");
            Console.WriteLine("# Rotating Right 4 Times");
            list14.RotateRight(4);
            Console.WriteLine($"Nodes: {list14}\t\tCount: {list14.Count}");

            Console.WriteLine("\n============ (15) RotateLeft ===========");
            var list15 = initialList.Copy();
            Console.WriteLine($"Nodes: {list15}\t\tCount: {list15.Count}");
            Console.WriteLine("# Rotating Left 2 Times");
            list15.RotateLeft(2);
            Console.WriteLine($"Nodes: {list15}\t\tCount: {list15.Count}");


            Console.ReadKey();
        }
    }
}
