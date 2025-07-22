using System;
using System.Collections.Generic;
namespace DictionaryExample
{
    class Books
    {
        static void Main()
        {
            Dictionary<int, string> book = new Dictionary<int, string>();
            book.Add(1, "Basicsof Csharp");
            book.Add(101, "Data types");
            book.Add(112, "Methods");
            book.Add(123, "Loops");
            book.Add(134, "Statements");
            book.Add(145, "Oops");
            book.Add(162, "Classes");
            book.Add(174, "Interfaces");

            Dictionary<string, bool> find = new Dictionary<string, bool>();
            find.Add("Book1", false);
            find.Add("Book2", true);
            find.Add("Book3", true);
            find.Add("Book4", false);
            find.Add("Book5", false);
            find.Add("Book6", true);
            find.Add("Book7", true);

            foreach (KeyValuePair<int, string> b in book)
            {
                Console.WriteLine(b);
            }
            foreach (KeyValuePair<string, bool> b in find)
            {
                Console.WriteLine(b);
            }


            Console.WriteLine("\nEnter the name of the book to check availability:");

            string choice = Console.ReadLine();

            if (find.ContainsKey(choice))
            {
                if (find[choice])
                    Console.WriteLine($"{choice} is available.");
                else
                    Console.WriteLine($"{choice} is NOT available.");
            }
            else
            {
                Console.WriteLine("Book not found in the library.");
            }
            Console.WriteLine();
            Console.WriteLine("Check the topic in page numbers:");
            int pgnumber = Convert.ToInt32(Console.ReadLine());

            if (pgnumber >= 1 && pgnumber < 101)
            {
                Console.WriteLine(book[1]);
            }
            else if (pgnumber >= 101 && pgnumber < 112)
            {
                Console.WriteLine(book[101]);
            }
            else if (pgnumber >= 112 && pgnumber < 123)
            {
                Console.WriteLine(book[112]);
            }
            else if (pgnumber >= 123 && pgnumber < 134)
            {
                Console.WriteLine(book[123]);
            }
            else if (pgnumber >= 134 && pgnumber < 145)
            {
                Console.WriteLine(book[134]);
            }
            else if (pgnumber >= 145 && pgnumber < 162)
            {
                Console.WriteLine(book[145]);
            }
            else if (pgnumber >= 162 && pgnumber < 174)
            {
                Console.WriteLine(book[162]);
            }
            else if (pgnumber >= 174 && pgnumber < 200)
            {
                Console.WriteLine(book[174]);
            }
            else
            {
                Console.WriteLine("Enter a valid page number.");
            }


        }


    }
}
