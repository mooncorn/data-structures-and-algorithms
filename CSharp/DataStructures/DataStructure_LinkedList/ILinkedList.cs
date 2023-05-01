using DataStructure_LinkedList.Nodes;

namespace DataStructure_LinkedList
{
    public interface ILinkedList<T>
    {
        int Count { get; set; }
        GenericNode<T> Head { get; set; }
        void AddFirst(GenericNode<T> node);
        GenericNode<T> AddFirst(T data);
        void AddLast(GenericNode<T> node);
        GenericNode<T> AddLast(T data);
        void AddAfter(GenericNode<T> node, GenericNode<T> newNode);
        GenericNode<T> AddAfter(GenericNode<T> node, T data);
        GenericNode<T> RemoveFirst();
        GenericNode<T> RemoveLast();
        void Remove(GenericNode<T> node);
        bool Contains(T data);
        GenericNode<T> Find(T data);
        GenericNode<T> FindLast(T data);
        void Clear();
        string ToString();
        string ToStringReverse();
        LinkedList<T> CloneReverse();
        LinkedList<T> Clone();
    }
}
