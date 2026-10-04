using System;

/*Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma
  decreciente.*/

namespace Guia03;

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

            if (num1 >= num2 && num2 >= num3 && num3 >= num4)
            {
                Console.WriteLine("Los Números Están Ordenados de Forma Decreciente");
            }
            else
            {
                Console.WriteLine("Los Números NO Están Ordenados de Forma Decreciente");
            }
            
        }
    }