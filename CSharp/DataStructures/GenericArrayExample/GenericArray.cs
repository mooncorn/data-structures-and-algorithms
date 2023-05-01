namespace GenericArrayExample
{
    internal class GenericArray<T>
    {
        private T[] array;
        private int count;

        public GenericArray()
        {
            array = new T[2];
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public T Get(int index)
        {
            if (index < count && index >= 0)
            {
                return array[index];
            }
            return default(T);
        }

        public void Add(T element)
        {
            if (count == array.Length)
            {
                T[] temp = new T[2 * array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    temp[i] = array[i];
                }
                array = temp;
            }
            array[count] = element;
            count++;
        }

        public void RemoveAt(int index)
        {
            if (index < count)
            {
                for (int i = index; i < count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[count - 1] = default(T);
                count--;
            }
        }
    }
}
