using System;
using System.Globalization;
using System.Reflection.Metadata;

/*Hacer una función llamada “Par” que reciba un número entero y devuelva 1 si es par o 0 si no lo es. Hacer un programa para ingresar
  20 números y mostrar por pantalla cuántos son pares.*/

namespace Guia07;

    class Program
    {
        static int Par(int parameter)
        {
            if (parameter % 2 == 0) return 1;
            else return 0;
        }

        static void Main(string[] args)
        {
            int number, even, acumEven=0, limit=20;
            
            Console.WriteLine();
            for (int i=0; i<limit; i++)
            {
                Console.Write("Ingrese Un Número: ");
                number = Convert.ToInt32(Console.ReadLine());
                even = Par(number);
                acumEven += even;
            }

            Console.WriteLine();
            Console.WriteLine($"La Cantidad de Números Pares es: {acumEven}");
            Console.WriteLine();
        }
    }