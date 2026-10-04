using System;

/*Hacer un programa que solicite 10 números y luego mostrar por pantalla el maximo de ellos y la posición en la que fue ingresado.*/

namespace Guia04;

    class Program
    {
        static void Main(string[] args)
        {
            
            float number, max=0;
            int i, position=0, limit=10;

            for (i=1; i<=limit; i++)
            {   
                Console.Write($"Ingrese el Valor {i}: ");
                number = Convert.ToSingle(Console.ReadLine());

                if (i == 1)
                {
                    max = number;
                    position = i;
                }
                else if (number > max)
                {
                    max = number;
                    position = i;
                }
            }
            
            Console.WriteLine("El Máximo Número es: " + max);
            Console.WriteLine("su Posición es: " + position);

        }
    }