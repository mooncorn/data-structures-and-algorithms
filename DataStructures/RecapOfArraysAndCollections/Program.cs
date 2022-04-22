using RecapOfArraysAndCollections.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RecapOfArraysAndCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayExamples();

            //ArrayOfClassesAndStructuresExample();

            //ArrayListExample();

            //ListExample();

            Console.ReadLine();
        }

        static void ArrayExamples()
        {
            //EXAMPLE 1:
            Console.WriteLine("*** EXAMPLE 1 ***");

            //Declaring and initializing a string array:
            string[] companies = new string[3]; //array with 3 elements
            //Assigning values:
            companies[0] = "Tesla";
            companies[1] = "Ford";
            companies[2] = "BMW";
            /*** Another ways to do the same thing in a single line:
            string[] companies = new string[3] {"Tesla", "Ford", "BMW"}; 
            string[] companies = {"Tesla", "Ford", "BMW"}; 
            var companies = new string[3] {"Tesla", "Ford", "BMW"}; 
            */


            //Declaring, initializing, and assigning values to an int array:
            int[] numbers = new int[3]; //array with 3 elements
            //Assigning values:
            numbers[0] = 50;
            numbers[1] = 40;
            numbers[2] = 60;
            /*** Another ways to do the same thing in a single line:
            int[] numbers = new int[3] {50, 40, 60}; 
            int[] numbers = {50, 40, 60}; 
            var numbers = new int[3] {50, 40, 60};  
            */

            //Declaring, initializing, and assigning values to a char array:
            char[] characters = new char[3]; //array with 3 elements
            //Assigning values:
            characters[0] = 'c';
            characters[1] = 'b';
            characters[2] = 'a';
            /*** Another ways to do the same thing in a single line:
            char[] characters = new int[3] {'c', 'b', 'a'}; 
            char[] characters = {'c', 'b', 'a'}; 
            var characters = new int[3] {'c', 'b', 'a'}; 
            */

            Console.WriteLine("Showing the content of companies array only:");
            for (int i = 0; i < companies.Length; i++)
            {
                Console.WriteLine("companies[" + i + "] = " + companies[i]);
            }

            Console.WriteLine("\nShowing the contents of companies, numbers, and characters: ");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("companies[" + i + "] = " + companies[i]);
                Console.WriteLine("numbers[" + i + "] = " + numbers[i]);
                Console.WriteLine("characters[" + i + "] = " + characters[i]);
            }

            Console.WriteLine("\nSorting the arrays...");
            Array.Sort(companies);
            Array.Sort(numbers);
            Array.Sort(characters);

            Console.WriteLine("\nShowing the contents after sorting:");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("companies[" + i + "] = " + companies[i]);
                Console.WriteLine("numbers[" + i + "] = " + numbers[i]);
                Console.WriteLine("characters[" + i + "] = " + characters[i]);
            }

            Console.WriteLine("\nMaking the values of companies and characters to be in UPPERCASE...");
            for (int i = 0; i <= 2; i++)
            {
                companies[i] = companies[i].ToUpper();
                characters[i] = char.ToUpper(characters[i]);
            }

            /* FOREACH LOOPS...
               Important info 1:
               - You cannot iterate multiple collections in a single foreach
                 because you don't have an index.
               Important info 2:
               - You can't the the values of the array using foreach
            /*/

            Console.WriteLine("\nLooping companies using foreach:");
            foreach (string company in companies)
            {
                Console.WriteLine(company);
                //company = "SOMETHING ELSE..."; //if you uncomment this line, you will see that you can't change the value of company
            }

            Console.WriteLine("\nLooping numbers using foreach:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nLooping characters using foreach:");
            foreach (char c in characters)
            {
                Console.WriteLine(c);
            }
        }

        static void ArrayOfClassesAndStructuresExample()
        {
            //EXAMPLE 2:
            Console.WriteLine("*** EXAMPLE 2 ***");

            //Declaring an array of customers (class)
            Customer[] customers = new Customer[3];
            customers[0] = new Customer(100, "Julia", "Roberts");

            customers[1] = new Customer();
            customers[1].Id = 101;
            customers[1].FirstName = "Tom";
            customers[1].LastName = "Hanks";

            customers[2] = new Customer() { Id = 102, FirstName = "Cameron", LastName = "Diaz" };

            //Declaring an array of products (struct)
            Product[] products = new Product[3];
            products[0] = new Product(200, "Samsung Galaxy S22", "Snapdragon 8 Gen, 8GB RAM");

            products[1] = new Product();
            products[1].Id = 201;
            products[1].Name = "IPhone 13";
            products[1].Description = "Hexa-core, 4GB RAM";

            products[2] = new Product() { Id = 203, Name = "Microsoft Keyboard", Description = "Wireless Keyboard" };

            Console.WriteLine("\nShowing Products and Customers:");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("customers[" + i + "] = " + customers[i].ToString());
                Console.WriteLine("products[" + i + "] = " + products[i].ToString());
            }

            Console.WriteLine("\nLooping customers using foreach:");
            foreach (Customer c in customers)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("\nLooping products using foreach:");
            foreach (var p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }

        static void ArrayListExample()
        {
            //EXAMPLE 3:
            Console.WriteLine("*** EXAMPLE 3 ***");

            ArrayList arrayListOfNumbers = new ArrayList();
            arrayListOfNumbers.Add(7);
            arrayListOfNumbers.Add(5);
            arrayListOfNumbers.Add(1);
            //There's no limit of items you can add into an ArrayList...

            /*** The problem of ArrayLists is that you can add multiple datatypes. ***/
            //arrayListOfNumbers.Add("banana"); //if you uncomment this line, arrayListOfNumbers.Sort() will cause a runtime errpr.

            for (int i = 0; i < arrayListOfNumbers.Count; i++)
            {
                Console.WriteLine("arrayListOfNumbers[" + i + "] = " + arrayListOfNumbers[i].ToString());
            }

            Console.WriteLine("\nSorting the ArrayList...\n");
            arrayListOfNumbers.Sort();

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("arrayListOfNumbers[" + i + "] = " + arrayListOfNumbers[i].ToString());
            }
        }

        static void ListExample()
        {
            List<int> listOfNumbers = new List<int>();
            listOfNumbers.Add(7);
            listOfNumbers.Add(5);
            listOfNumbers.Add(1);
            //There's no limit of items you can add in a List<T>

            /*** List<T> is strongly typed and you can't add other multiple datatypes as you can 
             *   when using ArrayList. Because of that and many other features, List<T> is better than ArrayList. */
            //listOfNumbers.Add("banana"); //if you uncomment this line, you will get a compilation error, which is better than getting a runtime error.

            List<string> listOfCompanies = new List<string>();
            listOfCompanies.Add("Microsoft");
            listOfCompanies.Add("Apple");
            listOfCompanies.Add("Amazon");

            List<Customer> listOfCustomers = new List<Customer>();
            listOfCustomers.Add(new Customer(100, "Julia", "Roberts"));
            listOfCustomers.Add(new Customer(101, "Tom", "Hanks"));
            listOfCustomers.Add(new Customer() { Id = 102, FirstName = "Cameron", LastName = "Diaz" });

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("listOfNumbers[" + i + "] = " + listOfNumbers[i].ToString());
                Console.WriteLine("listOfCompanies[" + i + "] = " + listOfCompanies[i]);
                Console.WriteLine("listOfCustomers[" + i + "] = " + listOfCustomers[i].ToString());
            }

            Console.WriteLine("\nSorting the lists...\n");
            listOfNumbers.Sort();
            listOfCompanies.Sort();
            listOfCustomers = listOfCustomers.OrderBy(x => x.FirstName).ToList();

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("listOfNumbers[" + i + "] = " + listOfNumbers[i].ToString());
                Console.WriteLine("listOfCompanies[" + i + "] = " + listOfCompanies[i]);
                Console.WriteLine("listOfCustomers[" + i + "] = " + listOfCustomers[i].ToString());
            }


        }
    }
}
