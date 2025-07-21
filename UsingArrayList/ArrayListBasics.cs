using System;
using System.Collections;
///<summary>ARRAYLIST:create arraylist by using ArrayList class from system.Collections namespace
///</summary>



    class ArrayListBasics
    {
    public static void Main()
    {
        //creating an empty list
        ArrayList list1 = new ArrayList();
        //adding elements
        list1.Add(10);//integer
        list1.Add("hello");//string
        list1.Add(false);//boolean
        list1.Add(3.5);//decimal
        list1.Add(" ");//empty
        list1.Add(null);
        Console.WriteLine("capacity:{0}", list1.Capacity);//4
        Console.WriteLine("Count:{0}", list1.Count);//4
        //printing
        //foreach (int i in list1)
        //{
        //    Console.WriteLine(i + " ");//10
        //}

        //ACCESSING THE FIRST ELEMENT
        var First = list1[0];
        Console.WriteLine("First ELEMENT "+First);//10

        //Modifying the second element
        list1[2] = "Narmada";
        Console.WriteLine("My Modified string is:" + list1[2]);//Narmada

        Console.WriteLine("...................................");
        ArrayList studentNames = new ArrayList() { "Hanvi", "Tanvi", "likhil", "nihal" };
        Console.WriteLine("student Names");
        foreach(var student in studentNames)
        {
            Console.WriteLine("using foreach loop"+student);
        }
        //using for loop
        for (int i = 0; i < studentNames.Count; i++)
        {
            Console.WriteLine("using for loop"+ studentNames[i]);
        }

        //Adding elements to arraylist using object intilaiizer
        var ArrayList2 = new ArrayList()
        {
            1,"aravind","cognizant","Administration department",900000
        };
        foreach(var info in ArrayList2)
        {
            Console.WriteLine("emp info"+info);
        }
        Console.ReadKey();
        }
    }

//ArrayList:store elements of differnt datatypes