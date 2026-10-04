using System;
using System.Globalization;

/*Hacer una función llamada “Mayor” que reciba dos números enteros y devuelva el mayor de ellos o cero si son iguales.*/

namespace Guia07;

    class Program
    {
        static int Mayor(int parameter1, int parameter2)
        {
            if (parameter1 > parameter2) return parameter1;
            else if (parameter2 > parameter1) return parameter2;
            else return 0;
        }

        static void Main(string[] args)
        {
            int number1, number2, greater;
            
            Console.WriteLine();
            Console.Write("Ingrese el Primer Número: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Segundo Número: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            greater = Mayor(number1, number2);

            Console.WriteLine();
            Console.WriteLine($"El Mayor de Ellos es (el Resultado Será 0 en Caso de Ser Iguales): {greater}");
            Console.WriteLine();
        }
    }