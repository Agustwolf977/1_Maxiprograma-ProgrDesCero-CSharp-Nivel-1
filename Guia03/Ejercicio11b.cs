using System;

/*Hacer un programa para ingresar tres números y luego mostrarlos ordenados de menor a mayor.*/

namespace Guia03;

    class Program
    {
        static void Main(string[] args)
        {
            
            float num1, num2, num3, aux;

            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Tercer Número: ");
            num3 = Convert.ToSingle(Console.ReadLine());
            
            if (num1 > num2)
            {
                aux = num1;
                num1 = num2;
                num2 = aux;
            }

            if (num1 > num3)
            {
                aux = num1;
                num1 = num3;
                num3 = aux;
            }

            if (num2 > num3)
            {
                aux = num2;
                num2 = num3;
                num3 = aux;
            }

            Console.WriteLine($"El Orden de los Números es: {num1} - {num2} - {num3}");
          
        }
    }