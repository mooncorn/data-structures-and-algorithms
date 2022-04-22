using System;

namespace DataStructure_LinkedStack
{
    public class LinkedStack<T> : IStack<T>
    {
        private GenericNode<T> head;
        private int count;


        //*** Time complexity: O(1)
        public LinkedStack()
        {
            head = null;
            count = 0;
        }

        //*** Time complexity: O(1)
        public int Count()
        {
            return count;
        }

        //*** Time complexity: O(1)
        public virtual void Push(T itemValue)
        {
            GenericNode<T> node = new GenericNode<T>(itemValue);
            node.Next = head;
            head = node;
            count++;
        }

        //*** Time complexity: O(1)
        public T Peek()
        {
            if (head == null)
                throw new
                InvalidOperationException("Stack empty");

            return head.Data;
        }

        //*** Time complexity: O(1)
        public T Pop()
        {
            if (head == null)
                throw new
                InvalidOperationException("Stack empty");

            var first = head;
            head = head.Next;
            count--;
            return first.Data;
        }

        //*** Time complexity: O(1)
        public void Clear()
        {
            head = null;
            count = 0;
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
    }
}
