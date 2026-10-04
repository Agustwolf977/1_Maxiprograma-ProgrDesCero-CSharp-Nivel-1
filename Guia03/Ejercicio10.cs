using System;

/*Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si son todos iguales entre sí, caso contrario, no emitir
  nada.*/

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

            if (num1 == num2 && num2 == num3 && num3 == num4)
            {
                Console.WriteLine("Los Números Ingresados Son Todos Iguales");
            }
            
        }
    }