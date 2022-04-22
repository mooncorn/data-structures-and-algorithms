using System;

namespace GenericArrayExample
{
    public static class Comparator<T>
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //bool equal = Comparator<string>.AreEqual("a", "a");
            //Console.WriteLine(equal);

            //ArrayExample();
            GenericArrayExample();

            Console.ReadKey();
        }

        static void GenericArrayExample()
        {
            GenericArray<string> array = new GenericArray<string>();
            bool addMore;
            int counter = 0;
            do
            {
                Console.Write($"Element {counter + 1} value: ");
                array.Add(Console.ReadLine());

                Console.Write("\nAdd more (y/n)? ");
                addMore = Console.ReadLine() == "y";

                if (addMore)
                    Console.WriteLine();

            } while (addMore);

            Console.WriteLine("\nThese are your elements:");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.WriteLine(array.Get(i));
            }
        }

        static void ArrayExample()
        {
            string[] array = new string[2];
            bool addMore;
            int counter = 0;
            do
            {
                Console.Write($"Element {counter + 1} value: ");
                array[counter++] = Console.ReadLine();

                Console.Write("\nAdd more (y/n)? ");
                addMore = Console.ReadLine() == "y";

                if (addMore)
                    Console.WriteLine();

            } while (addMore);

            Console.WriteLine("\nThese are your elements:");
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
