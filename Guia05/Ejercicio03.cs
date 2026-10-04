using System;

/*Hacer un programa que solicite la edad de un grupo de personas. El programa deberá pedir edades hasta que se ingrese una edad menor a 18
  años. Deberá mostrar por pantalla cuántas personas mayores se registraron.*/

namespace Guia05;

    class Program
    {
        static void Main(string[] args)
        {
            
            int age, counter=0;

            Console.Write("Ingrese Una Edad: ");
            age = Convert.ToInt32(Console.ReadLine());

            while (age >= 18)
            {
                counter++;

                Console.Write("Ingrese Otra Edad: ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Cantidad de Personas Mayores de 18 Años: " + counter);
            
        }
    }