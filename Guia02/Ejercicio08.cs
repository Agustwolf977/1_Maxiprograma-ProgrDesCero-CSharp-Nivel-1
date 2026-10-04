using System;

/*Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {

            float num1, num2, num3, num4, smallest;

            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Tercer Número: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Cuarto Número: ");
            num4 = Convert.ToSingle(Console.ReadLine());


            if (num1 < num2)
            {
                smallest = num1;
            }
            else
            {
                smallest = num2;
            }

            if (num3 < smallest)
            {
                smallest = num3;
            }

            if (num4 < smallest)
            {
                smallest = num4;
            }

            Console.WriteLine("El Menor de Ellos es: " + smallest);

        }
    }