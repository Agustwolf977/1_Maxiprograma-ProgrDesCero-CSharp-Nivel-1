using System;

/*Hacer un programa que solicite el ingreso de dos números y luego calcular:
  -La resta, si el primero es mayor al segundo.
  -La suma, si son iguales.
  -El producto, si el primero es menor.*/

namespace Guia03;

    class Program
    {
        static void Main(string[] args)
        {
            
            int num1, num2, result;

            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                result = num1 - num2;
            }
            else if (num1 == num2)
            {
                result = num1 + num2;
            }
            else
            {
                result = num1 * num2;
            }
            
            Console.WriteLine("El Resultado es: " + result);
            
        }
    }