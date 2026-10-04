using System;

/*Hacer un programa para mostrar los números del 10 al 1. No se debe realizar ningún pedido de datos.*/

namespace Guia04;

    class Program
    {
        static void Main(string[] args)
        {
            int i, limit=1;

            for (i=10; i>=limit; i--) Console.WriteLine(i);
        }
    }