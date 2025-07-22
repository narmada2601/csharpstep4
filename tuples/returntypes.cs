using System;
 class returntypes
    {
    public static void Main()
    {
        var person = GetPerson();
        Console.WriteLine($"Id={person.Item1}");
        Console.WriteLine($"FirstName={person.Item2}");
        Console.WriteLine($"LastName={person.Item3}");


    }
    static Tuple<int,string,string>GetPerson()
    {
        return Tuple.Create(1, "Narmada", "Teegala");
    }
    }

