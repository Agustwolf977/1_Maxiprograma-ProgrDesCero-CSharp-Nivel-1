using System;

/*Hacer un programa para ingresar por teclado los metros cuadrados totales de un predio y los metros
  cuadrados cubiertos; luego calcular y mostrar por pantalla el porcentaje de metros cuadrados cubiertos
  y el porcentaje de metros cuadrados descubiertos.*/

namespace Guia01;

    class Program
    {
        static void Main(string[] args)
        {

            float totalSquareMeters, coveredSquareMeters, coveredPorcentage, uncoveredPorcentage;
        
            Console.Write("Ingrese los Metros Cuadrados Totales del Predio: ");
            totalSquareMeters = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese los Metros Cuadrados Cubiertos: ");
            coveredSquareMeters = Convert.ToSingle(Console.ReadLine());

            coveredPorcentage = (coveredSquareMeters * 100) / totalSquareMeters;
            uncoveredPorcentage = 100 - coveredPorcentage;

            Console.WriteLine("El Porcentaje de Metros Cuadrados Cubiertos es: " + coveredPorcentage);
            Console.WriteLine("El Porcentaje de Metros Cuadrados Descubiertos es: " + uncoveredPorcentage);

        }
    }