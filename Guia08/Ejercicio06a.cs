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

            float repetido;
            int contador;
            bool banderaRepetido=false;

            Console.WriteLine();
            for (int i=0; i < vector.Length; i++)
            {
                Console.Write("Ingrese Un Número: ");
                vector[i] = Convert.ToSingle(Console.ReadLine());
            }

            for (int i=0; i < vector.Length; i++)
            {
                repetido = vector[i];
                contador = 0;
                for (int j=0; j < vector.Length; j++) if (repetido == vector[j]) contador++;

                if (contador >= 2) banderaRepetido = true;
            }

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