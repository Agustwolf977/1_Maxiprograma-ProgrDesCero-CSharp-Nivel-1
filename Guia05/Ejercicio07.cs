using System;

/*Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero y luego mostrar por pantalla el máximo de ellos
  y la posición en la que fue ingresado. Si, usar WHILE.*/

namespace Guia05;

    class Program
    {
        static void Main(string[] args)
        {
            
            float number, maxNumber;
            int position=1, maxPosition;

            Console.Write("Ingrese Un Número: ");
            number = Convert.ToSingle(Console.ReadLine());

            maxNumber = number;
            maxPosition = position;

            while (number != 0)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                    maxPosition = position;
                }

                position++;
                
                Console.Write("Ingrese Otro Número: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("El Máximo Número: " + maxNumber);
            Console.WriteLine("Su Posición es: " + maxPosition);
            
        }
    }