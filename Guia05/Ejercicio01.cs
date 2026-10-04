using System;

/*Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos. USAR WHILE.*/

namespace Guia05;

    class Program
    {
        static void Main(string[] args)
        {
            
            int number=1;

            while (number <= 10)
            {
                Console.WriteLine(number);
                number++;
            }
            
        }
    }