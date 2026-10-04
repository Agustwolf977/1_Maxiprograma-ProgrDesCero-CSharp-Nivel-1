using System;

/*Una importante cadena de delivery cuenta con una promoción de tiempo limitado en la que otorga un 15% de
  descuento sobre el total del valor de la compra realizada. Hacer un programa para solicitar el monto total
  y que el mismo calcule y emita por pantalla el total a cobrar más el descuento aplicado.*/

namespace Guia01;

    class Program
    {
        static void Main(string[] args)
        {

            float totalAmount, discount, totalToPay;
        
            Console.Write("Ingrese el Monto Total: ");
            totalAmount = Convert.ToSingle(Console.ReadLine());

            discount = totalAmount * 0.15;
            totalToPay = totalAmount - discount;

            Console.WriteLine("Total a Pagar: " + totalToPay);
            
        }
    }