using System;
using System.Collections;
using System.Linq;
class UsingToArray
    {
    public static void Main()
    {
        //convert an ArrayList to an array using the ToArray() method.
        ArrayList BrandsList = new ArrayList() { "Lee cooper", "BIBA", "AVASSA","HOSH" };
        object[] list=BrandsList.ToArray();//toArray of object type

        Console.WriteLine("Array Elements:original");
        foreach (var cart in list)
        {
            Console.WriteLine(cart);
        }
        Console.WriteLine(BrandsList.Contains("BIBA"));//true

        //BrandsList.Reverse();
        BrandsList.Reverse(1, 3);
        Console.WriteLine("Array Elements:reverse");
        foreach (var cart in BrandsList)
        {
            Console.WriteLine(cart+" ");//biba hosh reverses
        }
        
    }

    }

