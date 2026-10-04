using System;
using System.Globalization;
using System.Reflection.Metadata;

/*Hacer una función que se llame “sumaResta” que reciba dos números y que devuelva la suma Y la resta del primer número con el segundo.

  Nota: recordemos que una función solo puede devolver UN valor por return.
  Cómo podríamos hacer para tener ambos resultados en el main?*/

namespace Guia07;

    class Program
    {
        static float SumaResta(ref float number1, float number2)
        {
            float result = number1 + number2;
            
            number1 = number1 - number2;

            return result;
        }

        static void Main(string[] args)
        {
            float num1, num2, sum;

            Console.WriteLine();
            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToSingle(Console.ReadLine());
            
            sum = SumaResta(ref num1, num2);

            Console.WriteLine();
            Console.WriteLine($"La Suma del Primer Número Por el Segundo es: {sum}");
            Console.WriteLine($"La Resta del Primer Número Por el Segundo es: {num1}");
        }
    }