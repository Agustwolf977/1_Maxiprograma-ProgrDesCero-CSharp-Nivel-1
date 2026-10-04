using System;

/*Hacer un programa que solicite 20 números y calcule y emita por pantalla cuántos son positivos (mayores a cero). Se debe mostrar un solo
  valor: el conteo final.*/

namespace Guia04;

    class Program
    {
        static void Main(string[] args)
        {
            
            float number;
            int counter=0, i, limit=20;

            Console.WriteLine($"Ingrese {limit} Valores:");

            for (i=0; i<limit; i++)
            {
                Console.Write("Valor " + (i+1) + ": ");
                number = Convert.ToSingle(Console.ReadLine());
                
                if (number > 0) counter++;
            }
            
            Console.WriteLine("La Cantidad de Números Positivos Son: " + counter);
        }
    }