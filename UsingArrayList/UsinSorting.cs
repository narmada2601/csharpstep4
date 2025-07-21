using System;
using System.Collections;


class UsinSorting
{
    public static void Main()
    {
        ArrayList al = new ArrayList() { 3, 4, 2, 6, 8, 1 };

        al.Sort();
        Console.WriteLine("sorted arrayList:");
        foreach (int number in al)
        {
            Console.WriteLine(number);//1,2,3,4,6,8
        }
    }
}


