using System;
using System.Text;

namespace DataStructure_DoublyLinkedList
{
    internal class DoublyLinkedList<T>
    {
        private GenericNode<T> head;
        private GenericNode<T> tail;
        private int count;

        public GenericNode<T> Head { get => head; set => head = value; }
        public GenericNode<T> Tail { get => tail; set => tail = value; }
        public int Count { get => count; set => count = value; }


        public DoublyLinkedList()
        {
            head = null;
            count = 0;
        }

        public void AddLast(GenericNode<T> node)
        {
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.Prev = tail;
                tail.Next = node;
                tail = node;
                count++;
            }
        }

        public GenericNode<T> AddLast(T data)
        {
            var node = new GenericNode<T>(data);
            AddLast(node);
            return node;
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            var current = head;
            while (current != null)
            {
                if (sb.Length > 0)
                    sb.Append(", ");
                sb.Append(current.Data);
                current = current.Next;
            }
            return sb.ToString();
        }

        public string ToStringReverse()
        {
            var sb = new StringBuilder();
            var current = tail;
            while (current != null)
            {
                if (sb.Length > 0)
                    sb.Append(", ");
                sb.Append(current.Data);
                current = current.Prev;
            }
            return sb.ToString();
        }
    }
}
