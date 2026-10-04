using System;
using System.Globalization;
using System.Numerics;

/*Una empresa comercializa 15 tipos de artículos y por cada venta realizada  genera un registro con los siguientes datos:

  * Número de artículo (1 a 15).
  * Cantidad vendida.

  Puede haber varios registros para el mismo artículo y el último se indica número de artículo igual a cero.

  Se pide determinar e informar:

  A. El número de artículos que más se vendió en total.
  B. Los números de artículos que no registraron ventas.
  C. La cantidad de unidades vendidas para el artículo número 10.

  Nota: tener en cuenta el concepto de “registro” y el planteo de estructura  principal separado de consignas (ver videos de ciclos combinados y ejercicios  resueltos de
  ciclos combinados).*/

namespace Guia08;

    class Program
    {
        static void Main(string[] args)
        {
            int[] acumulador = new int[15];

            int numArticulo, cantVendida;

            for (int i=0; i < acumulador.Length; i++) acumulador[i] = 0;

            Console.WriteLine();
            Console.Write("Ingrese el Número de Artículo: ");
            numArticulo = Convert.ToInt32(Console.ReadLine());
            
            while (numArticulo != 0)
            {
                Console.Write("Ingrese la Cantidad Vendida: ");
                cantVendida = Convert.ToInt32(Console.ReadLine());
                
                acumulador[numArticulo-1] += cantVendida;

                Console.WriteLine();
                Console.Write("Ingrese el Número de Artículo: ");
                numArticulo = Convert.ToInt32(Console.ReadLine());
            }

            int maxArticulo = acumulador[0], articulo = 0;

            for (int i=0; i < acumulador.Length; i++)
            {
                if (acumulador[i] >= maxArticulo)
                {
                    maxArticulo = acumulador[i];
                    articulo = i+1;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Artículo Que Más Se Vendió: {articulo}");

            Console.WriteLine();
            for (int i=0; i < acumulador.Length; i++)
            {
                if (acumulador[i] == 0) Console.WriteLine($"Artículo Que No Registró Ventas: {i+1}");
            }

            Console.WriteLine();
            Console.WriteLine($"Cantidad de Unidades Vendidas del Artículo 10: {acumulador[9]}");
            Console.WriteLine();
        }
    }