using System;
using System.Globalization;

/*Una compañía de electricidad necesita calcular anualmente el consumo que ha registrado de cada uno de sus usuarios y el monto pagado por
  cada uno de ellos.
  Para ello tiene un lote de registros por cada uno de los usuarios con los siguientes datos:
  * Zona (numérico entero).
  * Número de cliente (número de cuatro dígitos no correlativos).
  * Cantidad de Kilovatios consumidos en el periodo.
  El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro con zona igual a cero.

  Se pide generar un listado con el siguiente formato:

  Zona: xx
  Cantidad de usuarios de la zona: xx
  Total facturado en la zona: xx

  Zona: xx
  Cantidad de usuarios de la zona: xx
  Total facturado en la zona: xx

  El precio es escalonado según la siguiente escala:
  * $0.10 por kW por los primeros 100 kW de consumo.
  * $0.12 por kW por el consumo de 101 a 200 kW.
  * $0.15 por kW por el consumo de 201 kW en adelante.*/

namespace Guia06;

    class Program
    {
        static void Main(string[] args)
        {   
            // Variables Principales
            
            int zona, numeroCliente, zonaActual;
            double kilovatios, monto;

            Console.WriteLine();
            Console.Write("Ingrese el Código de Zona: ");
            zona = Convert.ToInt32(Console.ReadLine());

            while (zona != 0)
            {
                zonaActual = zona;

                // Variables Que Se Recetean Por Grupo

                int contUsuarios = 0;
                double montoTotal = 0;

                while (zona == zonaActual)
                {
                    Console.Write("Ingrese el Número de Cliente: ");
                    numeroCliente = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese los Kilovatios Consumidos en el Periodo: ");
                    kilovatios = Convert.ToDouble(Console.ReadLine());
                    
                    contUsuarios++;

                    if (kilovatios > 200) monto = (0.15 * kilovatios);
                    else if (kilovatios > 100) monto = (0.12 * kilovatios);
                    else monto = (0.10 * kilovatios);

                    montoTotal += monto;

                    Console.WriteLine();
                    Console.Write("Ingrese el Código de Zona: ");
                    zona = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Zona: {zonaActual}");
                Console.WriteLine($"Cantida de Usuarios de la Zona: {contUsuarios}");
                Console.WriteLine($"Total Facturado en la Zona: {montoTotal}");
                Console.WriteLine("------------------------------------------------");
            }
        }
    }