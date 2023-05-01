using System;

namespace PassingRefereceTypeParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** EXAMPLE 1 ***");
            Coordinate location1 = new Coordinate(1, 2);
            PassCoordinateByValue_EX1(location1);
            Console.WriteLine(location1.ToString());
            //output: X = 2, Y = 3

            Console.WriteLine("\n*** EXAMPLE 2 ***");
            Coordinate location2 = new Coordinate(1, 2);
            PassCoordinateByReference_EX2(ref location2);
            Console.WriteLine(location2.ToString());
            //output: X = 2, Y = 3

            Console.WriteLine("\n*** EXAMPLE 3 ***");
            Coordinate location3 = new Coordinate(1, 2);
            PassCoordinateByValue_EX3(location3);
            Console.WriteLine(location3.ToString());
            //output: X = 1 , Y = 2

            Console.WriteLine("\n*** EXAMPLE 4 ***");
            Coordinate location4 = new Coordinate(1, 2);
            PassCoordinateByReference_EX4(ref location4);
            Console.WriteLine(location4.ToString());
            //output: X = 11 , Y = 22

            Console.ReadLine();
        }

        static void PassCoordinateByValue_EX1(Coordinate c)
        {
            /* When you use a reference type variable as a value parameter, 
             * the method receives a copy of the reference. This means that 
             * for the duration of the call there are two references 
             * pointing to the same location1 object in memory.
             */
            c.X++;
            c.Y++;
        }

        static void PassCoordinateByReference_EX2(ref Coordinate c)
        {
            /* If you pass a reference type as a ref parameter the outcome will
             * be the same as it was a value parameter. In other words, changes
             * made to c parameter will reflect in location2 object because
             * both are poiting to the same object in memory.
             */
            c.X++;
            c.Y++;
        }

        static void PassCoordinateByValue_EX3(Coordinate c)
        {
            /* In this example we force c parameter to point to a new memory address 
             * so that it does not interact with location3 memory location anymore
             */
            c = new Coordinate(11, 22);
        }

        static void PassCoordinateByReference_EX4(ref Coordinate c)
        {
            /* When you use a reference variable as a ref parameter, the method
             * receives the actual reference variable. In contrast to passing by value, 
             * in this case there is only one reference. The method does not make its 
             * own copy. This means that any changes to c parameter will affect location4. 
            */
            c = new Coordinate(11, 22);
        }

    }
}
