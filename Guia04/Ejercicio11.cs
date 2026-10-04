using System;

/*Hacer un programa para ingresar 10 números y luego calcule y emita el mayor de los primos de la lista. En caso de no haber ningún número
  primo, deberá aclararlo con un cartel.*/

namespace Guia04;

class Program
{
    static void Main(string[] args)
    {

        int number, maxPrime=0, i, j, counter, limit = 10;
        bool primeFlag = false;

        Console.WriteLine($"Ingrese {limit} Valores: ");

        for (i = 0; i < limit; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 1)
            {
                counter = 0;

                for (j=1; j <= number; j++)
                {
                    if (number % j == 0) counter++;
                    if (counter > 2) break;
                }

                if (counter == 2)
                {
                    if (!primeFlag)
                    {
                        maxPrime = number;
                        primeFlag = true;
                    }
                    else if (number > maxPrime) maxPrime = number;
                }
            }
        }

        if (primeFlag == true) Console.WriteLine("El Mayor de los Números Primos es: " + maxPrime);
        else Console.WriteLine("No se Registraron Números Primos");
        
    }
}