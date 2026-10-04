using System;

/*Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.
  Nota: un número es primo cuando es divisible únicamente por 1 y por sí mismo*/

namespace Guia04;

    class Program
    {
        static void Main(string[] args)
        {
            
            int i, number, counter=0;

            Console.WriteLine("Ingrese Un Número:");
            number = Convert.ToInt32(Console.ReadLine());

            for (i=1; i<=number; i++)
            {   
                if (number % i == 0) counter++;
                
                if (counter > 2) break;
            }
            
            if (counter == 2) Console.WriteLine("El Número es Primo");
            else Console.WriteLine("El Número NO es Primo");
            
        }
    }