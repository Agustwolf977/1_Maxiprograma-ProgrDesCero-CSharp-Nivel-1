using System;

/*Hacer un programa que permita ingresar por teclado dos números y que luego muestre por pantalla
  la suma, la resta, la multiplicación y la división de dichos números. Se deben mostrar cuatro
  resultados en pantalla. Los números deben ser solicitados una única vez.*/

namespace Guia01;

    class Program
    {
        static void Main(string[] args)
        {

            float num1, num2, sum, subtraction, multiplication, division;
        
            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            sum = num1 + num2;
            subtraction = num1 - num2;
            multiplication = num1 * num2;
            division = num1 / num2;

            Console.WriteLine("El Resultado de la Suma es: " + sum);
            Console.WriteLine("El Resultado de la Resta es: " + subtraction);
            Console.WriteLine("El Resultado de la Multiplicación es: " + multiplication);
            Console.WriteLine("El Resultado de la División es: " + division);
        }
    }