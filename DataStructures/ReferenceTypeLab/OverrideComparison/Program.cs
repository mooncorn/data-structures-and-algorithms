using System;

namespace OverrideComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordinate c1 = new Coordinate(1, 2);
            Coordinate c2 = new Coordinate(1, 2);

            Console.WriteLine("C1: " + c1.ToString());
            Console.WriteLine("C2: " + c2.ToString());


            if (c1 == c2)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are different");
            }
            Console.ReadLine();
        }
    }
}
