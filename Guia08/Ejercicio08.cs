using System;
using System.Globalization;
using System.Numerics;

/*Se ingresa una lista de 20 números en un vector. Se pide ordenar dichos números en forma decreciente (de mayor a menor). Mostrar el listado ordenado informando también la
  posición original de cada número en el vector.

  Pista: usar ciclos combinados.*/

namespace Guia08;

    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[20];
            int[] vectorPos = new int[20];

            int auxiliar, auxiliarPos;

            Console.WriteLine();
            for (int i=0; i < vector.Length; i++)
            {
                Console.Write($"Ingrese Un Número (Posición {i+1}): ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
                vectorPos[i] = i+1;
            }

            for (int j=0; j < vector.Length; j++)
            {
                for (int i=0; i < ((vector.Length)-1)-j; i++)
                {
                    if (vector[i] < vector[i+1])
                    {
                        auxiliar = vector[i];
                        vector[i] = vector[i+1];
                        vector[i+1] = auxiliar;
                        auxiliarPos = vectorPos[i];
                        vectorPos[i] = vectorPos[i+1];
                        vectorPos[i+1] = auxiliarPos;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("LISTADO ORDENADO DE MAYOR A MENOR:");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine();
            for (int i=0; i < vector.Length; i++) Console.WriteLine($"Valor: {vector[i]} | Posicion Original: {vectorPos[i]}");
            Console.WriteLine();
        }
    }