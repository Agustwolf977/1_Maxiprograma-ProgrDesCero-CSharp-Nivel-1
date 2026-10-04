using System;

/*Una importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente
  escala:
  -Si vende menos de 100 litros, no hay descuento.
  -Si vende entre 101 y 300 litros, el descuento es del 10%.
  -Si vende entre 301 y 500 litros, el descuento es del 15%.
  -Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
  Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita
  el importe con el descuento aplicado.*/

namespace Guia03;

    class Program
    {
        static void Main(string[] args)
        {
            
            double totalAmount, litersSold;

            Console.Write("Ingrese el Importe Total de la Venta: ");
            totalAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la Cantida de Litros Vendidos: ");
            litersSold = Convert.ToDouble(Console.ReadLine());

            if (litersSold > 500)
            {
                totalAmount *= 0.75;
            }
            else if (litersSold > 300)
            {
                totalAmount *= 0.85;
            }
            else if (litersSold > 100)
            {
                totalAmount *= 0.90;
            }

            Console.WriteLine("El Importe Final es de: " + totalAmount);

        }
    }