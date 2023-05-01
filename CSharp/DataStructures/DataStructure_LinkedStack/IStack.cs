using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_LinkedStack
{
    public interface IStack<T>
    {
        int Count();
        void Push(T itemValue);
        T Peek();
        T Pop();
        void Clear();
        bool Contains(T itemValue);
    }
}
