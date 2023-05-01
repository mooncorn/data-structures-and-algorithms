using System;
using DataStructure_LinkedList.Nodes;

namespace DataStructure_LinkedList
{
    public class LinkedList<T>
    {
        private GenericNode<T> head;
        private int count;

        public int Count { get => count; set => count = value; }
        public GenericNode<T> Head { get => head; set => head = value; }

        //*** Time complexity: O(1)
        public LinkedList()
        {
            head = null;
            count = 0;
        }

        //*** Time complexity: O(1)
        public LinkedList(GenericNode<T> node)
        {
            head = node;
            count = 1;
        }

        //*** Time complexity: O(1)
        public void AddFirst(GenericNode<T> node)
        {
            node.Next = head;
            head = node;
            count++;
        }

        //*** Time complexity: O(1)
        public GenericNode<T> AddFirst(T data)
        {
            GenericNode<T> node = new GenericNode<T>(data);
            AddFirst(node);
            return node;
        }

        //*** Time complexity: O(n)
        public void AddLast(GenericNode<T> node)
        {
            if (head == null)
            {
                AddFirst(node);
            }
            else
            {
                GenericNode<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
                count++;
            }
        }

        //*** Time complexity: O(n)
        public GenericNode<T> AddLast(T data)
        {
            GenericNode<T> node = new GenericNode<T>(data);
            AddLast(node);
            return node;
        }

        //*** Time complexity: O(n)
        public void AddAfter(GenericNode<T> node, GenericNode<T> newNode)
        {
            if (node == null)
                throw new ArgumentNullException("The given node is null");
            else if (head == null)
                throw new InvalidOperationException("The node is not found, because the current LinkedList is empty");

            GenericNode<T> current = head;
            while (current != node && current.Next != null)
            {
                current = current.Next;
            }

            if (current != node)
                throw new InvalidOperationException("The node is not found in the current LinkedList");

            newNode.Next = current.Next;
            current.Next = newNode;
            count++;
        }

        //*** Time complexity: O(n)
        public GenericNode<T> AddAfter(GenericNode<T> node, T data)
        {
            GenericNode<T> newNode = new GenericNode<T>(data);
            AddAfter(node, newNode);
            return newNode;
        }

        //*** Time complexity: O(1)
        public GenericNode<T> RemoveFirst()
        {
            GenericNode<T> first = null;
            if (head != null)
            {
                first = head;
                head = head.Next;
                count--;
            }
            return first;
        }

        //*** Time complexity: O(n)
        public GenericNode<T> RemoveLast()
        {
            if (head == null)
                return null;

            GenericNode<T> current = head;
            GenericNode<T> previous = null;

            while (current.Next != null)
            {
                previous = current;
                current = current.Next;
            }

            if (head.Next == null)
                head = null;
            else
                previous.Next = null;

            count--;

            return current;
        }

        //*** Time complexity: O(n)
        public void Remove(GenericNode<T> node)
        {
            if (head == null)
                throw new InvalidOperationException("The node is not found, because the current LinkedList is empty");

            GenericNode<T> previous = head;
            GenericNode<T> current = previous.Next;
            while (current != node && current.Next != null)
            {
                previous = previous.Next;
                current = current.Next;
            }
            
            if (current != node)
                throw new InvalidOperationException("The node is not found in the current LinkedList");

            previous.Next = current.Next;
            count--;
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

        //*** Time complexity: O(n)
        public GenericNode<T> Find(T data)
        {
            if (head == null)
                return null;

            GenericNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return current;
                current = current.Next;
            }

            return null;
        }

        //*** Time complexity: O(n)
        public GenericNode<T> FindLast(T data)
        {
            if (head == null)
                return null;

            GenericNode<T> lastNode = null;
            GenericNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    lastNode = current;
                }
                current = current.Next;
            }
            return lastNode;
        }

        //*** Time complexity: O(1)
        public void Clear()
        {
            head = null;
            count = 0;

            /* In other programming languages where there is no
             * Garbage Collector, you need to transverse the 
             * Linked List and remove all nodes [time complexity O(n)], 
             * like this:
            if (head != null)
            {
                GenericNode<T> current = head;
                while (head.Next != null)
                {
                    head = head.Next;
                    current.Next = null;
                    current = Head;
                }
                head = null;
                count = 0;
            }
            */
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
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
            return CloneReverse().ToString();
        }

        public LinkedList<T> CloneReverse()
        {
            var cloneList = new LinkedList<T>();

            if (head == null)
                return cloneList;

            var current = head;
            do
            {
                var newNode = new GenericNode<T>(current.Data);
                cloneList.AddFirst(newNode);
                current = current.Next;
            } while (current != null);

            return cloneList;
        }

        public LinkedList<T> Clone()
        {
            return CloneReverse().CloneReverse();
        }
    }
}
