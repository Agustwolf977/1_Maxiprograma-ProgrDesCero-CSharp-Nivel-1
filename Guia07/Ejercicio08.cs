using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Xml.XPath;

/*Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

  A. El mayor de los números pares.
  B. La cantidad de números impares.
  C. El menor de los números primos.

  Hacer uso de las funciones anteriormente desarrolladas.*/

namespace Guia07;

    class Program
    {
        static bool Par(int number)
        {
            bool result=false;

            if (number % 2 == 0) result=true;

            return result;
        }

        static bool Primo(int number)
        {
            if (number <= 1) return false; // Filtro Para Descartar Negativos, 0 y 1

            int divisor = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) divisor++;
                if (divisor > 2) break;
            }

            if (divisor == 2) return true;
            else return false;
        }

        static void Main(string[] args)
        {
            int num, maxPar=0, menPrimo=0, countImpar=0;
            bool banderaPar=false, banderaMaxPar=false, banderaPrimos=false, banderaMenPrimos=false;

            Console.WriteLine();
            Console.Write("Ingrese Un Número: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                banderaPar = Par(num);

                if (banderaPar)
                {
                    if(!banderaMaxPar)
                    {
                        maxPar = num;
                        banderaMaxPar = true;
                    }
                    else if (num > maxPar) maxPar = num;
                }
                else countImpar++;

                banderaPrimos = Primo(num);

                if (banderaPrimos)
                {
                    if (!banderaMenPrimos)
                    {
                        menPrimo = num;
                        banderaMenPrimos = true;
                    }
                    else if (num < menPrimo) menPrimo = num;
                }

                Console.WriteLine();
                Console.Write("Ingrese Otro Número: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            if (banderaMaxPar) Console.WriteLine($"$El Mayor de los Números Pares es: {maxPar}");
            else Console.WriteLine("No se ingresaron números Pares.");

            Console.WriteLine($"La Cantidad de Númeors Impares es: {countImpar}");
            Console.WriteLine($"El Menor de los Números Primos es: {menPrimo}");
        }
    }