using System;
using System.Globalization;
using System.Numerics;

/*Hacer un programa que solicite 100 números enteros y los guarde en un  vector. Luego recorrer ese vector para calcular el promedio.
  Mostrar por  pantalla los valores del vector que son mayores al promedio calculado.*/

namespace Guia08;

    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[100];
            int acumulator=0;
            float average;
            
            Console.WriteLine();
            for (int i=0; i < vector.Length; i++)
            {
                Console.Write("Escriba Un Número: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
                acumulator += vector[i];
            }

            average = (float)acumulator / vector.Length;

            for (int i=0; i < vector.Length; i++)
            {
                if (vector[i] > average)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Este Número es Mayor al Promedio: {vector[i]}");
                    Console.WriteLine();
                }
            }
        }
    }