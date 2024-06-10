using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> calificaciones = new List<double>();
       
        while (true)
        {
            Console.Write("Ingrese una calificación (o 'x' para finalizar): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "x")
            {
                break;
            }

            if (double.TryParse(input, out double calificacion))
            {
               
                calificaciones.Add(calificacion);
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }
        Console.WriteLine("\nCalificaciones ingresadas:");

        foreach (double calificacion in calificaciones)
        {
            Console.WriteLine(calificacion);
        }
        
        double max = calificaciones.Max();
        double min = calificaciones.Min();
        double promedio = calificaciones.Average();

        Console.WriteLine("Calificación más alta: " + max);
        Console.WriteLine("Calificación más baja: " + min);
        Console.WriteLine("Promedio de calificaciones: " + promedio);
       
        
    }
}
