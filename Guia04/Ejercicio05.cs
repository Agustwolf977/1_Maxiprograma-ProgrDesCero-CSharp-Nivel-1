using System;

/*Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo: 0, 5, 10, 15, 20, 20… 100.*/

namespace Guia04;

    class Program
    {
        static void Main(string[] args)
        {
            int i, limit=100;

            for (i=1; i<=limit; i+=5) Console.WriteLine(i);
        }
    }