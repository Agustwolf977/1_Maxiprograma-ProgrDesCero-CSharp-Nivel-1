using System;

/*Hacer un programa que solicite el ingreso de un número y luego emita una cartel por pantalla aclarando si el mismo es múltiplo de 5.*/

namespace Guia03;

    class Program
    {
        static void Main(string[] args)
        {
            
            int number;

            Console.Write("Ingrese un Valor: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 5 == 0) Console.WriteLine(number + " es Multiplo de 5");
            
        }
    }