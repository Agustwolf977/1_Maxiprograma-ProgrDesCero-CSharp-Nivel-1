using System;

/*Hacer un programa para ingresar dos números. Si el segundo es distinto de cero, calcular la división del primero por el segundo y mostrar
  el resultado por pantalla; caso contrario, emitir un cartel aclarando que no se puede dividir por cero.*/

namespace Guia03;

    class Program
    {
        static void Main(string[] args)
        {
            
            float num1, num2, result;

            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            if (num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine("El Resultado es: " + result);
            }
            else
            {
                Console.WriteLine("No Se Puede Dividir Por Cero");
            }
            
        }
    }