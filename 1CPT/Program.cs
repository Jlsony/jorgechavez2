using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa un texto o párrafo:");
        string texto = Console.ReadLine();

        // Dividir el texto en palabras
        string[] palabras = texto.Split(' ', '.', ',');

        Dictionary<string, int> frecuencias = new Dictionary<string, int>();

        foreach (string palabra in palabras)
        {
            Console.WriteLine(palabra);
        
             if (!string.IsNullOrEmpty(palabra))
            {
                if (frecuencias.ContainsKey(palabra))
                {
                    frecuencias[palabra]++;
                }
                else
                {
                    frecuencias[palabra] = 1;
                }
            }
        }
       Console.WriteLine("Palabra\tFrecuencia");
        foreach (var kvp in frecuencias)
        {
            Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
        }   
    }
}
