namespace DataStructure_Queue
{
    public class QueueDynamicArray<T> : QueueArray<T>
    {
        public QueueDynamicArray() : base(2)
        {

        }

        public override void Enqueue(T item)
        {
            //Resize array if it is full
            if (count == array.Length)
            {
                T[] tempArray = new T[2 * array.Length];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = array[i];
                }
                array = tempArray;
            }

            base.Enqueue(item);
        }
    }
}
