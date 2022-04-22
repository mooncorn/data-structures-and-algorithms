namespace DataStructure_LinkedList.Nodes
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

        public static int Compare(string left, string right)
        {
            int leftNumeric;
            int rightNumeric;
            if (int.TryParse(left, out leftNumeric) && int.TryParse(right, out rightNumeric))
            {
                // Both strings left and right are numeric.
                // We can use leftNumeric and rightNumeric to perform numeric comparisons
                if (leftNumeric > rightNumeric)
                    return 1;
                else if (leftNumeric == rightNumeric)
                    return 0;
                else 
                    return -1;
            }
            /******************************  
                EXAMPLES of string.Compare:
                string.Compare("BRAVO", "CHARLIE") will return -1, which means "BRAVO" < "CHARLIE" in alphabetical order
                string.Compare("BRAVO", "BRAVO") will return 0, which means "BRAVO" == "BRAVO" in alphabetical order
                string.Compare("BRAVO", "ALPHA") will return -1, which means "BRAVO" > "ALPHA" in alphabetical order
            */
            return string.Compare(left, right);
        }

        //Here we are overriding the < operator:
        public static bool operator <(GenericNode<T> left, GenericNode<T> right)
        {
            return Compare(left.Data.ToString(), right.Data.ToString()) < 0;
        }

        //Here we are overriding the > operator:
        public static bool operator >(GenericNode<T> left, GenericNode<T> right)
        {
            return Compare(left.Data.ToString(), right.Data.ToString()) > 0;
        }

        //Here we are overriding the <= operator:
        public static bool operator <=(GenericNode<T> left, GenericNode<T> right)
        {
            return Compare(left.Data.ToString(), right.Data.ToString()) <= 0;
        }

        //Here we are overriding the >= operator:
        public static bool operator >=(GenericNode<T> left, GenericNode<T> right)
        {
            return Compare(left.Data.ToString(), right.Data.ToString()) >= 0;
        }
    }
}
