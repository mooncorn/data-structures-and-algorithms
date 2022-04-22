using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Console
{
    public class GenericNode<T>
    {
        private T data;
        private GenericNode<T> next;
        private GenericNode<T> prev;

        public T Data { get => data; set => data = value; }
        public GenericNode<T> Next { get => next; set => next = value; }
        public GenericNode<T> Prev { get => prev; set => prev = value; }

        public GenericNode(T initialData)
        {
            data = initialData;
            next = null;
            prev = null;
        }
    }
}
