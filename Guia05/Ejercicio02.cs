using System;

/*Hacer un programa para mostrar los números del 10 al 1. No se debe realizar ningún pedido de datos. USAR WHILE.*/

namespace Guia05;

    class Program
    {
        static void Main(string[] args)
        {
            
            int number=10;

            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
            
        }
    }