using System;

/*Hacer un programa que solicite 10 números y luego mostrar por pantalla el maximo de ellos y la posición en la que fue ingresado.
  Para este código se trató de respetar la configuración estándar de la posición de las vueltas, las cuales comienzan de 0 a N-1.*/

namespace Guia04;

    class Program
    {
        static void Main(string[] args)
        {
            
            float number, max=0;
            int i, position=0, limit=10;

            for (i=0; i<limit; i++)
            {   
                Console.Write($"Ingrese el Valor {i+1}: ");
                number = Convert.ToSingle(Console.ReadLine());

                if (i == 0)
                {
                    max = number;
                    position = i+1;
                }
                else if (number > max)
                {
                    max = number;
                    position = i+1;
                }
            }
            
            Console.WriteLine("El Máximo Número es: " + max);
            Console.WriteLine("su Posición es: " + position);

        }
    }