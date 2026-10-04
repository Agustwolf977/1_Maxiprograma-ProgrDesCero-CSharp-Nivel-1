using System;
using System.Globalization;
using System.Numerics;

/*Hacer un programa que solicite 50 números enteros y los guarde en un vector.  Luego recorrer todos los elementos del vector y determinar
  cuál es el valor  máximo y su posición dentro del vector.*/

namespace Guia08;

    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[50];
            
            Console.WriteLine();
            for (int i=0; i < vector.Length; i++)
            {
                Console.Write("Escriba Un Número: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int greater = vector[0], position=1;

            for (int i=0; i < vector.Length; i++)
            {
                if (vector[i] > greater)
                {
                    greater = vector[i];
                    position = i+1;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"El Máximo de los Números Registrados es: {greater}");
            Console.WriteLine($"Su Posición es: {position}");
            Console.WriteLine();
        }
    }