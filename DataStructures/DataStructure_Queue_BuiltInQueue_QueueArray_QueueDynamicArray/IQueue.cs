namespace DataStructure_Queue
{
    public interface IQueue<T>
    {
        void Enqueue(T item);
        T Peek();
        T Dequeue();
        void Clear();
        bool Contains(T item);
        int Count();
    }
}
