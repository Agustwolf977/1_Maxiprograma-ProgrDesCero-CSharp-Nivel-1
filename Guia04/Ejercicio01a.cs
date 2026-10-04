using System;

/*Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir un valor por
  pantalla.*/

namespace Guia04;

    class Program
    {
        static void Main(string[] args)
        {
            
            float number, max=0;
            int i, limit=10;

            Console.WriteLine("Ingrese 10 Valores:");

            for (i=0; i<limit; i++)
            {
                Console.Write($"Valor {i+1}: ");
                number = Convert.ToSingle(Console.ReadLine());
                
                if (number > max) max = number;
            }
            
            Console.WriteLine("El Mayor de los Números Ingresados es: " + max);
        }
    }