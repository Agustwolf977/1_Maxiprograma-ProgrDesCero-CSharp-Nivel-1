using System;

/*Hacer un programa que solicite 20 números y luego mostrar por pantalla el menor de ellos y la posición en la que fue encontrado.*/

namespace Guia04;

    class Program
    {
        static void Main(string[] args)
        {
            
            float number, min=0;
            int i, position=0, limit=20;

            for (i=0; i<limit; i++)
            {   
                Console.Write($"Ingrese el Valor {i+1}: ");
                number = Convert.ToSingle(Console.ReadLine());

                if (i == 0)
                {
                    min = number;
                    position = i+1;
                }
                else if (number < min)
                {
                    min = number;
                    position = i+1;
                }
            }
            
            Console.WriteLine("El Menor de los Número es: " + min);
            Console.WriteLine("su Posición es: " + position);

        }
    }