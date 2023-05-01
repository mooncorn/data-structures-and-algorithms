namespace DataStructure_LinkedStack
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
