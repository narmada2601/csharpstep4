using System;
using System.Collections.Generic;


/// <summary>
/// hashset:duplicates values wont allow.....
/// </summary>

class BasicHashset
{
    public static void Main()
    {
        HashSet<string> test = new HashSet<string>()
        {
            "1234","Narmada",null,"fullstacK developer",null,"1234"
        };
        foreach(string s in test)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("contains Nmae?"+test.Contains("narmada"));
        //list-allows duplicaTE VAlues...
        List<string> list1 = new List<string>()
        {
            "1234","Narmada",null,"fullstacK developer",null,"1234"
        };
    }
}

