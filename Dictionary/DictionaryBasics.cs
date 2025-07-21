using System;
using System.Collections.Generic;
/// <summary>
/// Dictionary:generic collection that stores key and value pair 
/// </summary>


class DictionaryBasics
    {
    public static void Main()
    {
        Dictionary<int, string> cities = new Dictionary<int, string>();
        cities.Add(1, "Vizag");
        cities.Add(2, "delhi");
        cities.Add(3, "hyderbad");
        cities.Add(4, "Mumbai");
        cities.Add(5, "");//values can be null or duplicate
        //cities.Add(2, "punjab");exception
        if (cities.ContainsKey(2))
        {
            cities[2] = "delhi";
        }
        //lambda expressions
        foreach (KeyValuePair<int,string> kvp in cities)
        {
            Console.WriteLine($"key is {kvp.Key} value is {kvp.Value}");
          
           
        }
    }
    }

