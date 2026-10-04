using System;

/*Hacer un programa que muestre los números del 0 al 100 de 5 en 5. Ejemplo 0, 5, 10, 15, 20… 100. Usando WHILE.*/

namespace Guia05;

    class Program
    {
        static void Main(string[] args)
        {
            
            int number=0;

            while (number <= 100)
            {
                Console.WriteLine(number);
                number += 5;
            }
            
        }
    }