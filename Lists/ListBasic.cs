using System;
using System.Collections.Generic;
class ListBasic
    {
    public static void Main()
    {
        //list:generic collection-same datatype
        List<string> names = new List<string>();
        //1.type safety
        names.Add("likhil");
        names.Add("Ananya");
        names.Add("Saranya");
        //print  looping
        Console.WriteLine("Names  in the list:");
        foreach (string  i in names)
        {
            Console.WriteLine(i);
        }
        //3.Multiple datartypes not possible
        //4.no boxing
        //5.Dynamic sizes

        Console.WriteLine("...........................");
        List<int> number = new List<int>();
        number.Add(2);
        number.Add(4);
        number.Add(6);
        number.Add(8);
        number.Add(10);
        // number.Add("2 Table"); coonot convert string to int

        //we can also create
        List<string> courses = new List<string>() { "Angular","Data science" ,"testing","Python"};
        //accessing the elements
        Console.WriteLine("the First course name is " + courses[0]);
        Console.WriteLine("The Second course name is" + courses[1]);
        Console.WriteLine("we are iterating ");
        foreach(string i in courses)
        {
            Console.WriteLine("courses list" + i);
        }
        //Basic operations are add ,insert
        courses.Add("c sharp.net");
        //insert
        courses.Insert(2, "javascript");
        //display
        Console.WriteLine(courses[2]);
        //remove
        courses.Remove("Angular");
        //printb the updated list
        for(int  i=0;i<courses.Count;i++)
        {
            Console.WriteLine("Updted list"+courses[i]);
          //  courses.Add(i); noboxing
        }


    }
    }

