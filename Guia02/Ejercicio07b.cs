using System;

/*Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el mayor de ellos.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {

            float num1, num2, num3, num4, greater;

            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Tercer Número: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Cuarto Número: ");
            num4 = Convert.ToSingle(Console.ReadLine());


            if (num1 > num2)
            {
                greater = num1;
            }
            else
            {
                greater = num2;
            }

            if (num3 > greater)
            {
                greater = num3;
            }

            if (num4 > greater)
            {
                greater = num4;
            }

            Console.WriteLine("El Mayor de Ellos es: " + greater);

        }
    }