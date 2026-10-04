using System;

/*Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la summa de los dos primeros es mayor  al producto del
  segundo con el  tercero.*/

namespace Guia03;

    class Program
    {
        static void Main(string[] args)
        {
            
            float num1, num2, num3, addition, product;

            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Tercer Número: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            addition = num1 + num2;
            product = num2 * num3;

            if (addition > product)
            {
                Console.WriteLine("El Resultado de la Suma es Mayor");
            }

        }
    }