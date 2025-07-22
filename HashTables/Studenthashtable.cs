using System;
using System.Collections;
/// <summary>
/// In Hashtable,
///           keys must be unique and cannot be null.
///          However, values can be null or duplicate.
/// </summary>
class Studenthashtable
    {
    public static void  Main()
    {
        //create a hashtable
        Hashtable mytable = new Hashtable();

        // add items to hashtable
        mytable.Add("Name", "likhil");
        mytable.Add("RollNumber", 12);
        mytable.Add("Address", "Amenpur");//here keys are name,rollnumber,address

        Console.WriteLine(mytable["RollNumber"]);//12

        //anotherway
        Hashtable mytable2 = new Hashtable()
        {
            {"courses1","fullstack developer" },
            {"course2","human resource" },
            {"course3","php developer" }
        };
        //anotherway to acces the elements inside a hashtable
        // create a hashtable and add elements 
        Hashtable myTable3 = new Hashtable();

        // add items to hashtable
        myTable3.Add("Employee", "james");
        myTable3.Add("Id", 3);
        //access the employee whose key is employee
        Console.WriteLine(myTable3["Employee"]);
        Console.WriteLine(myTable3["ID"]);

        //print keys of hashtable
        foreach (var item in myTable3.Keys)
        {
            Console.WriteLine("key={0}", item);

        }
        //print values
        foreach (var item in myTable3.Values)
        {
            Console.WriteLine("Value = {0}", item);
        }
        //update the value
        myTable3["Employee"] = "Aravind";
        Console.WriteLine("updated value" + myTable3["Employee"]);

        myTable3.Add("Address", "London");

        Console.WriteLine("Original Hashtable :");

        foreach (DictionaryEntry item in myTable3)
        {
            Console.WriteLine("{0} : {1} ", item.Key, item.Value);
        }
        // remove value with key "Id"
        myTable3.Remove("Id");

        Console.WriteLine("\nModified Hashtable :");

        // iterate through the modified hashtable
        foreach (DictionaryEntry item in myTable3)
        {
            Console.WriteLine("{0} : {1} ", item.Key, item.Value);
        }
    }


}

