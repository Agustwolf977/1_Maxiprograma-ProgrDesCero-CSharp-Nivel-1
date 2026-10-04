using System;
using System.Globalization;
using System.Numerics;

/*Hacer un programa que solicite 50 números enteros y los guarde en un vector. Luego recorrer el vector y determinar e informar cuál es la
  suma de los valores del mismo.
  Nota: usar dos ciclos: uno para guardar los números en el vector y otro para  recorrerlo y leerlo.*/

namespace Guia08;

    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[20];
            int acumulator=0;
            
            Console.WriteLine();
            for (int i=0; i < vector.Length; i++) // Mediante la solución ".Length" podemos sincronizar la cantidad de vueltas del ciclo con los espacios dentro del Array.
            {
                Console.Write("Escriba Un Número: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i=0; i < vector.Length; i++) acumulator += vector[i];

            Console.WriteLine();
            Console.WriteLine($"La Suma de los Números Registrados es: {acumulator}");
            Console.WriteLine();
        }
    }