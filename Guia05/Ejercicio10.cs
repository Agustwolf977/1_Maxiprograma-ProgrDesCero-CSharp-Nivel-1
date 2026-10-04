using System;

/*Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero y luego emitir por pantalla el máximo de los
  números negativos y el mínimo de los números positivos.*/

namespace Guia05;

    class Program
    {
        static void Main(string[] args)
        {
            
            int number, maxNegative=0, minPositive=0;
            bool flagPositive=false, flagNegative=false;

            Console.Write("Ingrese Un Número: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                if (number > 0)
                {
                    if (!flagPositive)
                    {
                        minPositive = number;
                        flagPositive = true;
                    }
                    else if (number < minPositive) minPositive = number;
                }
                else if (!flagNegative)
                {
                    maxNegative = number;
                    flagNegative = true;
                }
                else if (number > maxNegative) maxNegative = number;

                Console.Write("Ingrese Otro Número: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("El Máximo Negativo es: " + maxNegative);
            Console.WriteLine("El Mínimo Positivo es: " + minPositive);
            
        }
    }