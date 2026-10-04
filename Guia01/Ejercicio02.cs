using System;

/*Hace un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
  Nota: no olvides que solo contamos con las cuatro operaciones básicas.*/

namespace Guia01;

    class Program
    {
        static void Main(string[] args)
        {

            float num, powerResult;
        
            Console.Write("Ingrese Un Número: ");
            num = Convert.ToSingle(Console.ReadLine());

            powerResult = num * num * num;

            Console.WriteLine("El Resultado de la Potencia es: " + powerResult);

        }
    }