using System;

/*Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes
  valores:
  - Si el importe es menor a ARS 1000, no hay descuento.
  - Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
  - Si el importe es ARS 5000 o más,  aplica un descuento del 18%.
  Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento
  que corresponda.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {

            double amount, finalAmount;

            Console.Write("Ingrese el Importe de Venta: ");
            amount = Convert.ToDouble(Console.ReadLine());

            if (amount >= 1000 && amount < 5000)
            {
                finalAmount = amount * 0.90;
            }
            else if (amount >= 5000)
            {
                finalAmount = amount * 0.82;
            }
            else
            {
                finalAmount = amount;
            }

            Console.WriteLine("El Importe Final es de: " + finalAmount);

        }
    }