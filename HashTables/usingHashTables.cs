using System;
using System.Collections;
using System.Collections.Generic;

class usingHashTables
{
    public static void Main()
    {
        //key-value pair not generic
        Hashtable ht = new Hashtable();
        ht.Add("narmada", "9490479864");
       // ht.Add("narmada", "Employee id 1");//runtime exception
        ht.Add("Salary", 10000);

        string phonenum = (string)ht["narmada"];
        string descripiton = (string)ht[101];
        int salary = (int)ht["Salary"];
        //Update
        ht[101] = "Employee id with 101 is availble in Ban";


        //remove
        ht.Remove("Salary");


        //Add
        ht.Add("IsActive", true);


        foreach (DictionaryEntry entry in ht)
        {
            Console.WriteLine($"Key - {entry.Key}  ,  Value - {entry.Value}");

        }


        if (ht.ContainsKey(101))
        {
            Console.WriteLine(ht[101] + " Availble");
        }

    }

}


