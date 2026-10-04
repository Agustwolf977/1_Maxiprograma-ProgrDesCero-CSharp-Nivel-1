using System;

/*Hacer un programa que permita ingresar el año actual y el año de la fecha de nacimiento de una persona y
  luego calcule y emita por pantalla su edad.
  Nota: no hay que tener en cuenta si la persona cumplió años o no, simplemente calcular.*/

namespace Guia01;

    class Program
    {
        static void Main(string[] args)
        {

            int currentYear, birthYear, age;
        
            Console.Write("Ingrese el Año Actual: ");
            currentYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el Año de su Nacimiento: ");
            birthYear = Convert.ToInt32(Console.ReadLine());

            age = currentYear - birthYear;

            Console.WriteLine("Su Edad es: " + age);

        }
    }