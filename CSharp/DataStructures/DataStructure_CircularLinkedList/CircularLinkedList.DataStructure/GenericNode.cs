using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_CircularLinkedList
{
    public class GenericNode<T>
    {
        private T data;
        private GenericNode<T> next;

        public T Data { get => data; set => data = value; }
        public GenericNode<T> Next { get => next; set => next = value; }

        public GenericNode(T initialData)
        {
            data = initialData;
            next = null;
        }
    }
}
