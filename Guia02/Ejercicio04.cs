using System;

/*Hacer un programa para ingresar un número y que luego se emita un cartel por pantalla “Positivo” si el número
  es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {

            float number;

            Console.Write("Ingrese un Número: ");
            number = Convert.ToSingle(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("El Número es Positivo");
            }
            else if (number < 0)
            {
                Console.WriteLine("El Número es Negativo");
            }
            else
            {
                Console.WriteLine("El Número Ingresado es Cero");
            }

        }
    }