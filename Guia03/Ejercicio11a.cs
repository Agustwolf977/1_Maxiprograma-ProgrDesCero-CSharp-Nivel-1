using System;

/*Hacer un programa para ingresar tres números y luego mostrarlos ordenados de menor a mayor.*/

namespace Guia03;

    class Program
    {
        static void Main(string[] args)
        {
            
            float num1, num2, num3;

            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Tercer Número: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");
            
            Console.WriteLine("El Orden de los Números es:");

            if (num1 < num2 && num1 < num3)
            {
                Console.Write(" - " + num1);
                if (num2 < num3)
                {
                    Console.Write(" - " + num2);
                    Console.Write(" - " + num3);
                }
                else
                {
                    Console.Write(" - " + num3);
                    Console.Write(" - " + num2);
                }
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.Write(" - " + num2);
                if (num3 < num1)
                {
                    Console.Write(" - " + num3);
                    Console.Write(" - " + num1);
                }
                else
                {
                    Console.Write(" - " + num1);
                    Console.Write(" - " + num3);
                }
            }
            else
            {
                Console.Write(" - " + num3);
                if (num2 < num1)
                {
                    Console.Write(" - " + num2);
                    Console.Write(" - " + num1);
                }
                else
                {
                    Console.Write(" - " + num1);
                    Console.Write(" - " + num2);
                }
            }

            Console.WriteLine("");

          
        }
    }