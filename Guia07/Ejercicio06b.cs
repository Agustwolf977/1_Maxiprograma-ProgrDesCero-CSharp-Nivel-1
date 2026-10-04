using System;
using System.Globalization;
using System.Reflection.Metadata;

/*Hacer una función que se llame “sumaResta” que reciba dos números y que devuelva la suma Y la resta del primer número con el segundo.

  Nota: recordemos que una función solo puede devolver UN valor por return.
  Cómo podríamos hacer para tener ambos resultados en el main?*/

namespace Guia07;

    class Program
    {
        static float SumaResta(float number1, float number2, out float resta)
        {
            resta = number1 - number2;
            
            return number1 + number2;
        }

        static void Main(string[] args)
        {
            float num1, num2, sum, resta;

            Console.WriteLine();
            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToSingle(Console.ReadLine());
            
            sum = SumaResta(num1, num2, out resta);

            Console.WriteLine();
            Console.WriteLine($"La Suma es: {sum}");
            Console.WriteLine($"La Resta es: {resta}");
        }
    }