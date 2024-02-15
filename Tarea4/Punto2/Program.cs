namespace Punto2;
using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
        "Alice", "Bob", "Anna", "Alex", "John"
        };

        var filteredNames = names.Where(name => name.StartsWith("A"));

        Console.WriteLine("Nombres que comienzan con 'A':");

        foreach (var name in filteredNames)
        {
            Console.WriteLine(name);
        }
    }
}