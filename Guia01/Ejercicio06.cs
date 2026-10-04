using System;

/*Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y que luego calcule
  y emita por pantalla el promedio final.*/

namespace Guia01;

    class Program
    {
        static void Main(string[] args)
        {

            float examScore1, examScore2, examScore3, finalAverage;
        
            Console.Write("Ingrese la Primera Nota de Exámen: ");
            examScore1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese la Segunda Nota de Exámen: ");
            examScore2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese la Tercera Nota de Exámen: ");
            examScore3 = Convert.ToSingle(Console.ReadLine());

            finalAverage = (examScore1 + examScore2 + examScore3) / 3;

            Console.WriteLine("El Promedio Final de Notas es: " + finalAverage);

        }
    }