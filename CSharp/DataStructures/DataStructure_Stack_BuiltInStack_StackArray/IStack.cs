using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Stack
{
    internal interface IStack<T>
    {
        void Push(T item);
        T Peek();
        T Pop();
        void Clear();
        bool Contains(T item);
        int Count();
    }
}
