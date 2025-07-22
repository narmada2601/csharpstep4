using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step4.tuples
{
    class CreatingTuple
    {
        public static void Main()
        {
            //creating 
            var person = Tuple.Create( "narmada", "fullstack developer","misard");
            //allows only 8 elements
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);

            // 2. Access values using Item1, Item2, Item3
            Console.WriteLine("Name: " + person.Item1);//returns name
            Console.WriteLine("Designation: " + person.Item2);
            Console.WriteLine("company: " + person.Item3);

            //tuple as method parameter
            DisplayTuple(person);
        }
        static void DisplayTuple(Tuple<string,string,string>person)
        {
            Console.WriteLine($"ID={person.Item1}");
           
        } 
        }
    }


