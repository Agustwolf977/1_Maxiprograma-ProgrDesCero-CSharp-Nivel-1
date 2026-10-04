using System;

/*El negocio de desinfectante antes mencionado vende además detergente suelto, y los precios se aplican según la siguiente escala:
  -25 ARS por litro los primeros 50 litros.
  -20 ARS por litro si la venta es de 51 a 200 litros.
  -15 ARS por litro si la venta es de 201 a 500 litros.
  Además, si se paga en efectivo, tiene un adicional de 10% sobre el importe final.
  Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago (ingresará 1 si se paga en efectivo y 0 si es con
  cualquier otro medio de pago) y calcule y emita por pantalla el monto final a abonar por el cliente.*/

namespace Guia03;

    class Program
    {
        static void Main(string[] args)
        {
            
            double litersSold, totalAmount;
            int paymentMethod;

            Console.Write("Ingrese la Cantidad de Litros Vendidos: ");
            litersSold = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el Método de Pago: ");
            paymentMethod = Convert.ToInt32(Console.ReadLine());

            if (litersSold > 200)
            {
                totalAmount = litersSold * 15;
            }
            else if (litersSold > 50)
            {
                totalAmount = litersSold * 20;
            }
            else
            {
                totalAmount = litersSold * 25;
            }
            
            if (paymentMethod == 1)
            {
                totalAmount *= 1.10;
            }
            else if (paymentMethod == 0)
            {
                totalAmount = totalAmount;
            }
            
            Console.WriteLine("El Importe Final es de: " + totalAmount);

        }
    }