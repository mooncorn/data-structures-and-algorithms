using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_LinkedQueue
{
    public interface IQueue<T>
    {
        void Clear();
        int Count();
        void Enqueue(T item);
        T Peek();
        T Dequeue();
        bool Contains(T item);
        
    }
}
