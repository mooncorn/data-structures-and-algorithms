using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Console
{
    public class DCLinkedList<T> 
    {
        private GenericNode<T> head;
        private GenericNode<T> tail;
        private int count;

        public GenericNode<T> Head { get => head; set => head = value; }
        public GenericNode<T> Tail { get => tail; set => tail = value; }
        public int Count { get => count; set => count = value; }

        public DCLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        // Time complexity: O(1)
        public void AddFirst(GenericNode<T> node)
        {
            if (head == null)
            {
                node.Next = node;
                node.Prev = node;

                tail = node;
            }
            else
            {
                node.Prev = tail;
                node.Next = head;

                tail.Next = node;
                head.Prev = node;
            }
            head = node;
            count++;
        }

        // Time complexity: O(1)
        public GenericNode<T> AddFirst(T data)
        {
            var node = new GenericNode<T>(data);
            AddFirst(node);
            return node;
        }

        // Time complexity: O(1)
        public void AddLast(GenericNode<T> node)
        {
            if (head == null)
            {
                node.Next = node;
                node.Prev = node;

                head = node;
            }
            else
            {
                node.Prev = tail;
                node.Next = head;

                tail.Next = node;
                head.Prev = node;
            }
            tail = node;
            count++;
        }

        // Time complexity: O(1)
        public GenericNode<T> AddLast(T data)
        {
            var node = new GenericNode<T>(data);
            AddLast(node);
            return node;
        }

        // Time complexity: O(n)
        public void AddBefore(GenericNode<T> node, GenericNode<T> newNode)
        {
            if (head == null)
                throw new InvalidOperationException("List is empty");
            if (head == node)
            {
                AddFirst(newNode);
                return;
            }

            GenericNode<T> current = head.Next;
            while (current != head)
            {
                if (current == node)
                {
                    var leftNode = current.Prev;
                    var rightNode = current;

                    rightNode.Prev = newNode;
                    newNode.Next = rightNode;

                    leftNode.Next = newNode;
                    newNode.Prev = leftNode;

                    count++;
                    return;
                }
                current = current.Next;
            }

            throw new InvalidOperationException("Node does not exist");
        }

        // Time complexity: O(n)
        public void AddAfter(GenericNode<T> node, GenericNode<T> newNode)
        {
            if (head == null)
                throw new InvalidOperationException("List is empty");
            if (tail == node)
            {
                AddLast(newNode);
                return;
            }

            GenericNode<T> current = head;
            while (current != tail) 
            {
                if (current == node)
                {
                    var leftNode = current;
                    var rightNode = current.Next;

                    rightNode.Prev = newNode;
                    newNode.Next = rightNode;

                    leftNode.Next = newNode;
                    newNode.Prev = leftNode;

                    count++;
                    return;
                }
                current = current.Next;
            }

            throw new InvalidOperationException("Node does not exist");
        }

        // Time complexity: O(1)
        public void RemoveFirst()
        {
            if (head == null)
                return;
            if (count == 1)
            {
                head = null;
                tail = null;
                return;
            }

            head = head.Next;
            tail.Next = head;
            head.Prev = tail;
            count--;
        }

        // Time complexity: O(1)
        public void RemoveLast()
        {
            if (head == null)
                return;
            if (count == 1)
            {
                head = null;
                tail = null;
                return;
            }

            tail = tail.Prev;
            tail.Next = head;
            head.Prev = tail;
            count--;
        }

        // Time complexity: O(n)
        public void Remove(GenericNode<T> node)
        {
            if (head == null)
                return;
            if (node == head) 
            {
                RemoveFirst();
                return;
            }
            if (node == tail)
            {
                RemoveLast();
                return;
            }

            var current = head.Next;
            while (current != tail)
            {
                if (node == current)
                {
                    var leftNode = current.Prev;
                    var rightNode = current.Next;

                    leftNode.Next = rightNode;
                    rightNode.Prev = leftNode;

                    count--;
                    return;
                }
                current = current.Next;
            }
        }

        // Time complexity: O(n)
        public GenericNode<T> FindFirst(T data)
        {
            if (head == null)
                return null;
            if (head.Data.Equals(data))
                return head;

            var current = head.Next;
            while (current != head)
            {
                if (current.Data.Equals(data))
                    return current;
                current = current.Next;
            }

            return null;
        }

        // Time complexity: O(n)
        public GenericNode<T> FindLast(T data)
        {
            if (head == null)
                return null;
            if (tail.Data.Equals(data))
                return tail;

            var current = tail.Prev;
            while (current != tail)
            {
                if (current.Data.Equals(data))
                    return current;
                current = current.Prev;
            }

            return null;
        }

        // Time complexity: O(1)
        public void Merge(DCLinkedList<T> list)
        {
            if (list.head == null)
                return;
            if (head == null)
            {
                head = list.head;
                tail = list.tail;
                count = list.count;
                return;
            }

            var secondTail = list.tail;
            var secondHead = list.Head;

            tail.Next = secondHead;
            secondHead.Prev = tail;

            head.Prev = secondTail;
            secondTail.Next = head;

            tail = secondTail;

            count += list.count;
        }

        // Time complexity: O(1)
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        // Time complexity: O(n)
        public override string ToString()
        {
            if (head == null) 
                return String.Empty;

            StringBuilder stringBuilder = new StringBuilder();

            var current = head;
            do
            {
                if (stringBuilder.Length > 0)
                    stringBuilder.Append(", ");
                stringBuilder.Append(current.Data.ToString());

                current = current.Next;
            } while (current != head);

            return stringBuilder.ToString();
        }

        // Time complexity: O(n)
        public string ToStringReverse()
        {
            if (head == null)
                return String.Empty;

            StringBuilder stringBuilder = new StringBuilder();

            var current = tail;
            do
            {
                if (stringBuilder.Length > 0)
                    stringBuilder.Append(", ");
                stringBuilder.Append(current.Data.ToString());

                current = current.Prev;
            } while (current != tail);

            return stringBuilder.ToString();
        }

        // Time complexity: O(n)
        public void RotateRight(int nPositions)
        {
            for (int i = 0; i < nPositions % count; i++)
            {
                head = tail;
                tail = tail.Prev;
            }
        }

        // Time complexity: O(n)
        public void RotateLeft(int nPositions)
        {
            for (int i = 0; i < nPositions % count; i++)
            {
                tail = head;
                head = head.Next;
            }
        }

        // Time complexity: O(n)
        public DCLinkedList<T> Copy()
        {
            var list = new DCLinkedList<T>();

            var current = head;
            do
            {
                list.AddLast(new GenericNode<T>(current.Data));
                current = current.Next;
            } while (current != head);

            return list;
        }
    }
}
