namespace Actividad1;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // foreach (var number in EvenSequence(5, 18))
        // {
        //     Console.Write(number + " ");
        // }

        // Uso del indexador
        // var tempRecord = new TempRecord();
        // tempRecord[4] = 72.5f; // Asigna una temperatura
        // float temperature = tempRecord[4]; // Recupera la temperatura

        // Uso del indexador
        var indexerInstance = new IndexerClass();
        indexerInstance[0] = 42; // Asigna un valor
        int value = indexerInstance[0]; // Recupera el valo

        // Salida: 6 8 10 12 14 16 18
        //Console.Write(temperature);
        Console.Write(value);
        Console.ReadKey();

        //Console.WriteLine("Hello, World!");
    }

    private static IEnumerable<int> EvenSequence(int firstNumber, int lastNumber)
    {
        // Devuelve números pares en el rango.
        for (int number = firstNumber; number <= lastNumber; number++)
        {
            if (number % 2 == 0)
            {
                yield return number;
            }
        }
    }
}
