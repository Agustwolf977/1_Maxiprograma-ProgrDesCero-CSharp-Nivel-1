using System;
using System.Globalization;
using System.Numerics;

/*Dada una lista de 10 números enteros, cargarlos en un vector. Luego,  determinar e informar si el vector está ordenado en forma creciente.
  Por  ejemplo, el vector con los valores 1, 3, 5, 7 y 9 está ordenado; el vector 1, 5, 3, 7  y 9 no lo está.*/

namespace Guia08;

    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];

            Console.WriteLine();
            for (int i=0; i < vector.Length; i++)
            {
                Console.Write("Escriba Un Número: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            int greater = vector[0];

            bool flag = true;

            for (int i=0; i < vector.Length; i++)
            {
                if (vector[i] >= greater) greater = vector[i];
                else flag = false;
            }

            if (flag)
            {
                Console.WriteLine();
                Console.WriteLine("El Vector Está Ordenado de Forma Creciente");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El Vector NO Está Ordenado de Forma Creciente");
                Console.WriteLine();
            }
        }
    }