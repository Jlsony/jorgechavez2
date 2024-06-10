using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        int[] numerosGanadores = new int[6];
       
        List<int> numerosUsuario = new List<int>();

        
        Random random = new Random();

        
        for (int i = 0; i < numerosGanadores.Length; i++)
        {
            int numero;

            
            while (true)
            {
                numero = random.Next(1, 50);

                if (!Array.Exists(numerosGanadores, x => x == numero))
                {
                    break;
                }
            }

            
            numerosGanadores[i] = numero;
        }

        
        for (int i = 0; i < 6; i++)
        {
            int numeroUsuario;

            while (true)
            {
                Console.Write("Ingrese un número entre 1 y 49: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numeroUsuario) && numeroUsuario >= 1 && numeroUsuario <= 49 && !numerosUsuario.Contains(numeroUsuario))
                {
                    numerosUsuario.Add(numeroUsuario);
                    break;
                }
                else
                {
                    Console.WriteLine("Número inválido o repetido. Intente de nuevo.");
                }
            }
        }

       
        int aciertos = 0;

        foreach (int numeroGanador in numerosGanadores)
        {
            if (numerosUsuario.Contains(numeroGanador))
            {
                aciertos++;
            }
        }

       
        Console.WriteLine("\nNúmeros ganadores: " + string.Join(", ", numerosGanadores));
        Console.WriteLine("Números del usuario: " + string.Join(", ", numerosUsuario));
        Console.WriteLine("Número de aciertos: " + aciertos);

        if (aciertos == 6)
        {
            Console.WriteLine("¡Felicidades! Has acertado todos los números.");
        }
    }
}

