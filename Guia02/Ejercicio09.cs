using System;

/*Hacer un programa para ingresar cinco números distintos y luego mostrar por pantalla el mayor y el menor de
  ellos.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {

            float num1, num2, num3, num4, num5, greater, smallest;

            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Tercer Número: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Cuarto Número: ");
            num4 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Quinto Número: ");
            num5 = Convert.ToSingle(Console.ReadLine());


            if (num1 > num2)
            {
                greater = num1;
                smallest = num2;
            }
            else
            {
                greater = num2;
                smallest = num1;
            }

            if (num3 > greater)
            {
                greater = num3;
            }
            else if (num3 < smallest)
            {
                smallest = num3;
            }

            if (num4 > greater)
            {
                greater = num4;
            }
            else if (num4 < smallest)
            {
                smallest = num4;
            }

            if (num5 > greater)
            {
                greater = num5;
            }
            else if (num5 < smallest)
            {
                smallest = num5;
            }

            Console.WriteLine("El Mayor de Ellos es: " + greater);
            Console.WriteLine("El Menor de Ellos es: " + smallest);

        }
    }