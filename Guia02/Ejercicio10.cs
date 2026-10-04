using System;

/*Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuales son mayores a 100.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, num3, num4;

            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el Tercer Número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el Cuarto Número: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 100)
            {
                Console.WriteLine(num1 + " es Mayor a 100");
            }

            if (num2 > 100)
            {
                Console.WriteLine(num2 + " es Mayor a 100");
            }

            if (num3 > 100)
            {
                Console.WriteLine(num3 + " es Mayor a 100");
            }
        
            if (num4 > 100)
            {
                Console.WriteLine(num4 + " es Mayor a 100");
            }
            
        }
    }