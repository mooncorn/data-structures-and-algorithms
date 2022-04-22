using System;

namespace DataStructure_LinkedQueue
{
    internal class LinkedQueue<T>
    {
        private GenericNode<T> head;
        private GenericNode<T> tail;
        private int count;


        public LinkedQueue()
        {
            Clear();
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }


        public int Count()
        {
            return count;
        }

        //*** Time complexity: O(n)
        public bool Contains(T data)
        {
            if (head == null)
                return false;

            GenericNode<T> current = head;
            while (current != null && !current.Data.Equals(data))
            {
                current = current.Next;
            }
            if (current != null && current.Data.Equals(data))
                return true;
            else
                return false;
        }

        public virtual void Enqueue(T item)
        {
            var node = new GenericNode<T>(item);
            if (count == 0)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            count++;
        }

        public T Peek()
        {
            if (head == null)
                throw new InvalidOperationException("Queue is empty");
            return head.Data;
        }

        public T Dequeue()
        {
            if (head == null)
                throw new InvalidOperationException("Queue is empty");

            T item = head.Data;
            head = head.Next;
            count--;
            return item;
        }
    }
}
