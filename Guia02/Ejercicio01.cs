using System;

/*Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratoria si “Es Mayor
  a 10” o “No es Mayor a 10”.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {

            int number;

            Console.Write("Ingrese un Número: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 10)
            {
                Console.WriteLine("Es Mayor a 10");
            }
            else
            {
                Console.WriteLine("No es Mayor a 10");
            }

        }
    }