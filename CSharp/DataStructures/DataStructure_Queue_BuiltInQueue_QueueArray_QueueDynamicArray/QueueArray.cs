using System;

namespace DataStructure_Queue
{
    public class QueueArray<T> : IQueue<T>
    {
        protected T[] array;
        protected int count;

        public QueueArray(int size)
        {
            array = new T[size];
            count = 0;
        }

        public void Clear()
        {
            for (int i = 0; i < count; i++)
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
                    return true;
            }
            return false;
        }

        public int Count()
        {
            return count;
        }

        public virtual void Enqueue(T item)
        {
            if (count == array.Length)
                throw new IndexOutOfRangeException();
            array[count] = item;
            count++;
        }

        public T Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("Queue empty");
            return array[0];
        }

        public T Dequeue()
        {
            if (count == 0)
              throw new InvalidOperationException("Queue empty");

            T item = array[0];
            for (int i = 0; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[count - 1] = default(T);
            count--;
            return item;
        }

    }
}
