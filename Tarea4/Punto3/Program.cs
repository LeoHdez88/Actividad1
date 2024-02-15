namespace Punto3;
using System;
using System.Linq;
using System.Collections.Generic;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
        new Person { Name = "Alice", Age = 25 },
        new Person { Name = "Bob", Age = 40 },
        new Person { Name = "Carol", Age = 32 }
        };

        var olderPeople = people.Where(p => p.Age > 30);

        Console.WriteLine("Personas mayores de 30 años:");

        foreach (var person in olderPeople)
        {
            Console.WriteLine($"{person.Name}, {person.Age} años");
        }
    }
}