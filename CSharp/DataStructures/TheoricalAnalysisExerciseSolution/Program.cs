using System;

namespace TheoricalAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Testing SortArray from Exercise 4
            int[] arr = { 25, 14, 45, 78, 13 };
            SortArray(arr);
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
            #endregion
        }

        //EXERCISE 1:
        static string HelloWorldOrFriends(bool greetFriends)
        {
            string result = "Hello ";
            if (greetFriends == true)
                return result + "World";
            else
                return result + "Friends";
            
            /// EXERCISE 1 Solution:
            /// 
            /// DECLARING = 2 
            ///      bool greetFriends ... 1
            ///      string result ... 1
            ///      
            /// ASSIGNING = 2
            ///      greetFriends paramenter ... 1
            ///      result = "Hello " ... 1
            ///      
            /// PERFORMING CONCATENATIONS = 1
            ///      Either result + "World" or result + "Friends". Not both ... 1
            ///      
            /// PERFORMING COMPARISONS = 1
            ///      if (greetFriends == true) ... 1
            ///      
            /// ACCESSING ELEMENTS = 2
            ///      greetFriends == true ... greetFriends value is retrieved ... 1
            ///      Either result + "World" or result + "Friends" ... result value is retrieved ... 1
            ///      
            /// RETURNING FUNCTION VALUE = 1
            ///      A function can return a value only once ... 1
            ///      
            /// f(n) = 9
        }

        //EXERCISE 2:
        static char ConvertNumericToAlphaGrade(float grade)
        {
            if (grade <= 100 && grade >= 90)
                return 'A';
            else if (grade < 90 && grade >= 80)
                return 'B';
            else if (grade < 80 && grade >= 70)
                return 'C';
            else if (grade < 70 && grade >= 60)
                return 'D';
            else 
                return 'E';

            /// EXERCISE 2 Solution:
            /// 
            /// DECLARING = 1
            ///      float grade ... 1
            ///      
            /// ASSIGNING = 1
            ///      grade paramenter ... 1
            ///      
            /// PERFORMING COMPARISONS = 8
            ///      grade <= 100 ... 1
            ///      grade >= 90 ... 1
            ///      grade < 90 ... 1
            ///      grade >= 80 ... 1
            ///      grade < 80 ... 1
            ///      grade >= 70 ... 1
            ///      grade < 70 ... 1
            ///      grade >= 60 ... 1
            /// ACCESSING ELEMENTS = 8
            ///      grade is read ... 8
            ///      
            /// RETURNING FUNCTION VALUE = 1
            ///      A function can return a value only once ... 1
            ///      
            /// f(n) = 19

        }

        //EXERCISE 3:
        static int FindGreatestNumber(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] > result)) 
                    result = array[i];
            }
            return result;

            /// EXERCISE 3 Solution:
            /// 
            /// DECLARING = 3 
            ///      int[] array ... 1
            ///      int result ... 1
            ///      int i ... 1
            ///      
            /// ASSIGNING = 2 + 2n
            ///      array paramenter ... 1
            ///      i = 0 ... 1
            ///      i++ ... n
            ///      result = array[i] ... n
            ///      
            /// PERFORMING ARITHMETIC OPERATIONS = n
            ///      i++ ... n
            ///      
            /// PERFORMING COMPARISONS = 2n + 1
            ///      i < array.Length ... n + 1
            ///      array[i] > result ... n
            ///      
            /// ACCESSING ELEMENTS = 7n + 2 
            ///      array.Length ... n + 1
            ///      i ... 4n + 1
            ///      array[i] ... 2n
            ///      
            /// RETURNING FUNCTION VALUE = 1
            ///      A function can return a value only once ... 1
            ///      
            /// f(n) = 12n + 9
        }

        //EXERCISE 4:
        static void SortArray(int[] array)
        {
            int swapVar;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swapVar = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = swapVar;
                    }
                }
            }

            /// EXERCISE 4 Solution:
            /// 
            /// DECLARING = 4
            ///      int[] array ... 1
            ///      int swapVar ... 1
            ///      int i ... 1
            ///      int j ... 1
            ///      
            /// ASSIGNING = 4nm + 2n + 2
            ///      array paramenter ... 1
            ///      i = 0 ... 1
            ///      i++ ... n
            ///      j = 0 ... n
            ///      j++ ... n * m
            ///      swapVar = array[j + 1] ... n * m
            ///      array[j + 1] = array[j] ... n * m
            ///      array[j] = swapVar ... n * m
            ///      
            /// PERFORMING ARITHMETIC OPERATIONS = 5nm + 2n + 1
            ///      i++ ... n
            ///      array.Length - 1 ... n + 1
            ///      array.Length - 1 ... n * m + n
            ///      j++ ... n * m
            ///      j + 1 ... 3 * n * m
            ///      
            /// PERFORMING COMPARISONS = 2nm + n + 1
            ///      i < array.Length - 1 ... n + 1
            ///      j < array.Length - 1 ... n * m + n
            ///      array[j] > array[j + 1] ... n * m
            ///      
            /// ACCESSING ELEMENTS = 12nm + 4n + 2
            ///      array.Length ... n + 1
            ///      i ... n + 1
            ///      i++ ... n
            ///      j ... n * m + n
            ///      j ... n * m
            ///      j ... n * m
            ///      j ... n * m
            ///      j ... n * m
            ///      j ... n * m
            ///      j ... n * m
            ///      array[j] ... n * m
            ///      array[j] ... n * m
            ///      array[j + 1] ... n * m
            ///      array[j + 1] ... n * m
            ///      swapVar ... n * m
            ///      
            /// RETURNING FUNCTION VALUE = 1
            ///      A function can return a value only once ... 1
            ///      
            /// f(n) = 23nm + 9n + 1 = 23n^2 + 9n + 1
        }



    }
}
