namespace Tarea3;

using System;
using System.Linq.Expressions;
class Program
{
    static void Main()
    {
        // Crear parámetros para x e y
        var xParameter = Expression.Parameter(typeof(double), "x");
        var yParameter = Expression.Parameter(typeof(double), "y");
        // Crear nodos para las operaciones
        var xSquared = Expression.Multiply(xParameter, xParameter);
        var ySquared = Expression.Multiply(yParameter, yParameter);
        var sum = Expression.Add(xSquared, ySquared);
        // Crear una expresión lambda
        var distanceCalc = Expression.Lambda<Func<double, double, double>>(sum, xParameter, yParameter);
        // Compilar y ejecutar la expresión
        var calculateDistance = distanceCalc.Compile();
        double result = calculateDistance(3.0, 4.0); // Debería ser 5.0 (teorema de Pitágoras)

        Console.WriteLine($"Distancia: {result}");

    }
}
