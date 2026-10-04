using System;

/*Hacer un programa que solicite 200 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.*/

namespace Guia04;

    class Program
    {
        static void Main(string[] args)
        {
            
            float average;
            int i, age, counter=0, accumulator=0, limit=200;

            Console.WriteLine($"Ingrese {limit} Edades: ");

            for (i=0; i<limit; i++)
            {   
                Console.Write($"Edad {i+1}: ");
                age = Convert.ToInt32(Console.ReadLine());

                if (age >= 18)
                {
                    accumulator += age;
                    counter ++;
                }
                
            }

            if (counter > 0)
            {
                average = ((float)accumulator / counter);
                Console.WriteLine("Promedio de Mayores de 18: " + average);
            }
            else Console.WriteLine("No Se Registraron Personas de Mayores de 18");
            
        }
    }