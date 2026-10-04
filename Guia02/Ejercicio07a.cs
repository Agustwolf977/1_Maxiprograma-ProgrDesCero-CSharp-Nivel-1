using System;

/*Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el mayor de ellos.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {

            float num1, num2, num3, num4;

            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Tercer Número: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Cuarto Número: ");
            num4 = Convert.ToSingle(Console.ReadLine());


            if (num1 > num2 && num1 > num3 && num1 > num4)
            {
                Console.WriteLine("El Mayor de Ellos es: " + num1);
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4)
            {
                Console.WriteLine("El Mayor de Ellos es: " + num2);
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4)
            {
                Console.WriteLine("El Mayor de Ellos es: " + num3);
            }
            else
            {
                Console.WriteLine("El Mayor de Ellos es: " + num4);
            }

        }
    }