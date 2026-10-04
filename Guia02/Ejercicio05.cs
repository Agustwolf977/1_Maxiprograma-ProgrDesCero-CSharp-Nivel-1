using System;

/*Hacer un programa para ingresar un número y mostrar por pantalla un cartel aclaratorio si el mismo es PAR o
  IMPAR.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {

            int number;

            Console.Write("Ingrese un Número: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("El Número es PAR");
            }
            else
            {
                Console.WriteLine("El Número es IMPAR");
            }

        }
    }