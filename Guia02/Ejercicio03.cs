using System;

/*Hacer un programa para ingresar dos números y que luego emita por pantalla el mayor de ellos o un cartel
  aclaratorio “Son Iguales” en el caso de que sea así.
  Nota: los números pueden ser iguales.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber, secondNumber;

            Console.Write("Ingrese el Primer Número: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("El Mayor es: " + firstNumber);
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine("El Mayor es: " + secondNumber);
            }
            else
            {
                Console.WriteLine("Ambos Números Son Iguales");
            }

        }
    }