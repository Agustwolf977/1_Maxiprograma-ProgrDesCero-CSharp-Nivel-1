using System;

/*Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números
  impares.*/

namespace Guia04;

class Program
{
    static void Main(string[] args)
    {

        int number, maxEven=0, minOdd=0, i, limit = 20;
        bool evenFlag = false, oddFlag = false;

        Console.WriteLine($"Ingrese {limit} Valores: ");

        for (i = 0; i < limit; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                if (!evenFlag)
                {
                    maxEven = number;
                    evenFlag = true;
                }
                else if (number > maxEven) maxEven = number;
            }
            else if (!oddFlag)
            {
                minOdd = number;
                oddFlag = true;
            }
            else if (number < minOdd) minOdd = number;
        }

        if (evenFlag) Console.WriteLine("El Mayor de los Números Pares es: " + maxEven);
        else Console.WriteLine("No se ingresaron números pares.");

        if (oddFlag) Console.WriteLine("El Menor de los Números Impares es: " + minOdd);
        else Console.WriteLine("No se ingresaron números impares.");
    }
}