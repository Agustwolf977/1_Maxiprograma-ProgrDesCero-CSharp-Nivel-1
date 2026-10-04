using System;
using System.Globalization;
using System.Numerics;

/*Dada una lista de 10 números, cargarlos en un vector. Luego detectar si en el vector hay algún elemento repetido. De haberlo, indicarlo con un cartel aclaratorio “Hay
  repetidos”, de lo contrario indicar “No hay repetidos”.

  Pista: usar ciclos combinados.*/

namespace Guia08;

    class Program
    {
        static void Main(string[] args)
        {
            float[] vector = new float[10];

            bool banderaRepetido=false;

            Console.WriteLine();
            for (int i=0; i < vector.Length; i++)
            {
                Console.Write("Ingrese Un Número: ");
                vector[i] = Convert.ToSingle(Console.ReadLine());
            }


            // Para este Ejercicio 6 B se han modificado y eliminado algunas variablles de este bucle de recorrido, para dejarlo mas optimizado.

            for (int i = 0; i < vector.Length; i++) for (int j=i+1; j < vector.Length; j++) if (vector[i] == vector[j]) banderaRepetido = true;

            Console.WriteLine();
            if (banderaRepetido)
            {
                Console.WriteLine("HAY NÚMEROS REPETIDOS");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("NO HAY NÚMEROS REPETIDOS");
                Console.WriteLine();
            }
        }
    }