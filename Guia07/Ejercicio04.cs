using System;
using System.Globalization;
using System.Reflection.Metadata;

/*Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa
  para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.*/

namespace Guia07;

    class Program
    {
        static int Primo(int parameter)
        {
            if (parameter <= 1) return 0;
            
            int counter=0;

            for (int i=1; i <= parameter; i++) if (parameter % i == 0) counter++;

            if (counter == 2) return 1;
            else return 0;
        }

        static void Main(string[] args)
        {
            int number, prime, acumPrime=0, countPrimo=0;
            float promedio;

            Console.WriteLine();
            Console.Write("Ingrese Un Número: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            while (number != 0)
            {
                prime = Primo(number);

                if (prime == 1)
                {
                    acumPrime += number;
                    countPrimo++;
                }

                Console.Write("Ingrese Otro Número: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            if (countPrimo > 0)
            {
                promedio = (float)acumPrime / (float)countPrimo;
                Console.WriteLine();
                Console.WriteLine($"El Promedio de Números Primos es: {promedio}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No Se Ingresaron Números Primos");
                Console.WriteLine();
            }
        }
    }