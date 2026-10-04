using System;

/*Hacer un programa para ingresar una lista de números que corta cuando se ingresa un cero y luego mostrar: la cantidad de números primos,
  la cantidad de números pares, la cantidad de positivos y la cantidad de negativos.*/

namespace Guia05;

    class Program
    {
        static void Main(string[] args)
        {
            
            float number;
            int counter1, counter2, counterPrime=0, counterEven=0, counterNegative=0, counterPositive=0;

            Console.Write("Ingrese Un Número: ");
            number = Convert.ToSingle(Console.ReadLine());

            while (number != 0)
            {
                if (number > 0) counterPositive++;
                else if (number < 0) counterNegative++;

                if (number % 2 == 0 && number != 0) counterEven++;

                counter1 = 0;
                counter2 = 1;

                while (counter2 <= number)
                {
                    if (number % counter2 == 0) counter1++;

                    if (counter1 > 2) break;

                    counter2++;
                }

                if (counter1 == 2) counterPrime++;

                Console.Write("Ingrese Otro Número: ");
                number = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("La Cantidad de Números Primos es: " + counterPrime);
            Console.WriteLine("La Cantidad de Números Pares es: " + counterEven);
            Console.WriteLine("La Cantidad de Números Positivos es: " + counterPositive);
            Console.WriteLine("La Cantidad de Números Negativos es: " + counterNegative);
        }
    }