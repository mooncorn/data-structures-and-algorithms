namespace DataStructure_LinkedList.Nodes
{
    public class NumericNode
    {
        private int data;
        private NumericNode next;

        public int Data { get => data; set => data = value; }
        public NumericNode Next { get => next; set => next = value; }

        public NumericNode(int initialData)
        {
            data = initialData;
            next = null;
        }

        //Here we are overriding the < operator:
        public static bool operator <(NumericNode left, NumericNode right)
        {
            return left.Data < right.Data;
        }

        //Here we are overriding the > operator:
        public static bool operator >(NumericNode left, NumericNode right)
        {
            return left.Data > right.Data;
        }

        //Here we are overriding the <= operator:
        public static bool operator <=(NumericNode left, NumericNode right)
        {
            return left.Data <= right.Data;
        }

        //Here we are overriding the >= operator:
        public static bool operator >=(NumericNode left, NumericNode right)
        {
            return left.Data >= right.Data;
        }
    }
}
