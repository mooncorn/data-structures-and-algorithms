using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_CircularLinkedList
{
    public class CircularLinkedList<T>
    {
        private GenericNode<T> head;
        private GenericNode<T> tail;
        private int count;

        public GenericNode<T> Head { get => head; set => head = value; }
        public GenericNode<T> Tail { get => tail; set => tail = value; }
        public int Count { get => count; set => count = value; }

        public void AddLast(GenericNode<T> node)
        {
            if (head == null)
            {
                node.Next = node;
                head = node;
            }
            else
            {
                node.Next = tail.Next;
                tail.Next = node;
            }
            tail = node;
            count++;
        }

        public GenericNode<T> AddLast(T data)
        {
            GenericNode<T> node = new GenericNode<T>(data);
            AddLast(node);
            return node;
        }
    }
}
