using System;
using System.Collections;
using System.Collections.Generic;

class example1
{
    public static void Main()
    {
        Hashtable customerId = new Hashtable();
        customerId["narmada"] = "c1";
        customerId["likhil"] = "c2";
        Console.WriteLine("customer ids");
        foreach (DictionaryEntry entry in customerId)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}

