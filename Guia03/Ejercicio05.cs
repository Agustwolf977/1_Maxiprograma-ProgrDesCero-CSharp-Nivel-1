using System;

/*Hacer un programa que solicite el ingreso de las notas del primer parcial y del segundo parcial de una alumna de programación.
  El programa deberá analizar las notas y emitir la situación de la alumna según la siguiente escala:
  -Si tiene 8 o más en ambos parciales, emitir “Aprobación Directa”.
  -Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales (se aprueba con 6 o más), emitir “Rinde Examen Final”.
  -Si tiene menos de 6 en alguno de los dos parciales, emitir “Debe Recuperar".
  El programa deberá emitir solo un cartel, el que corresponda.*/

namespace Guia03;

    class Program
    {
        static void Main(string[] args)
        {
            
            float firstExam, secondExam;

            Console.Write("Ingrese la Nota del Primer Parcial: ");
            firstExam = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese la Nota del Segundo Parcial: ");
            secondExam = Convert.ToSingle(Console.ReadLine());

            if (firstExam >= 8 && secondExam >= 8)
            {
                Console.WriteLine("Aprobación Directa");
            }
            else if (firstExam >= 6 && secondExam >= 6)
            {
                Console.WriteLine("Rinde Exámen Final");
            }
            else
            {
                Console.WriteLine("Debe Recuperar");
            }
            
        }
    }