using System;
using System.Globalization;

/*Hacer una función llamada “Producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la
  cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.*/

namespace Guia07;

    class Program
    {
        static int Producto(int number1, int number2)
        {
            return number1 * number2;
        }

        static void Main(string[] args)
        {
            float price;
            int quantity, totalAmount;
            
            Console.WriteLine();
            Console.Write("Ingrese el Precio del Artículo: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la Cantidad de Artículos: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            
            totalAmount = Producto((int)price, quantity);

            Console.WriteLine();
            Console.WriteLine($"Monto Total a Pagar: {totalAmount}");
            Console.WriteLine();
        }
    }