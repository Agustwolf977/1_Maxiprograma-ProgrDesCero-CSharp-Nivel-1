using System;

/*Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. USAR WHILE.*/

namespace Guia05;

    class Program
    {
        static void Main(string[] args)
        {
            
            int number,  divisor=1, counter=0;

            Console.Write("Ingrese Un Número: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (divisor <= number)
            {
                if (number % divisor == 0) counter++;
                
                if (counter > 2) break;

                divisor++;
            }

            if (counter == 2) Console.WriteLine("El Número es Primo");
            else Console.WriteLine("El Número NO es Primo");
            
        }
    }