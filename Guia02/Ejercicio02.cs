using System;

/*Hacer un programa para ingresar dos números distintos y luego se muestre por pantalla el menor de ellos.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;

            Console.Write("Ingrese un Número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese Otro Número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("El Menor es: " + num1);
            }
            else
            {
                Console.WriteLine("El Menor es: " + num2);
            }

        }
    }