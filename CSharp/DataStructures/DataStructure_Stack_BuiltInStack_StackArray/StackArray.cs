using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Stack
{
    internal class StackArray<T> : IStack<T>
    {
        private T[] array;
        private int count;

        public StackArray(int size)
        {
            array = new T[size];
            count = 0;
        }

        public void Clear()
        {
            for(int i = 0; i < count; i++)
            {
                array[i] = default(T);
            }
            count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public int Count()
        {
            return count;
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new 
                    InvalidOperationException("Stack is empty");
            }
            return array[count - 1];
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new
                    InvalidOperationException("Stack is empty");
            }
            
            T item = array[count - 1];
            array[count - 1] = default(T);
            count--;
            return item;
        }

        public void Push(T item)
        {
            if (count == array.Length)
                throw new IndexOutOfRangeException();
            array[count] = item;
            count++;    
        }
    }
}
