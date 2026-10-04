using System;

// Hacer un programa que permita sumar entre dos números:

namespace Guia01;

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Definir las variables como enteros (int)
            int num1, num2, sumResult;

            // 2. Pedir y leer el primer número
            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            // 3. Pedir y leer el segundo número
            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // 4. Realizar la suma
            sumResult = num1 + num2;

            // 5. Mostrar el resultado en pantalla
            Console.WriteLine("El Resultado de la Suma es: " + sumResult);

        }
    }