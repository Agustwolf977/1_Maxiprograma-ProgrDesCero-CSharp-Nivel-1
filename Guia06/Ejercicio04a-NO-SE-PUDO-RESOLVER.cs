using System;
using System.Globalization;

/*Una compañía de turismo aventura registró los paquetes vendidos durante la última temporada vacacional. Para cada venta se ingresó:

  * Número de paquetes (4 dígitos no correlativos).
  * Cantidad de personas incluidas.
  * Precio por persona.
  * Horas totales de actividades.
  * Tipo de aventura (“M”, Montaña, “T”, Trekking. “R”, Rafting. “B”, Bicicleta. “C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”,
    Jumping. “P”, Parapente).

  El lote se encuentra no ordenado y agrupado por tipo de aventura y corta con número de paquete cero. En el lote no se ingresan registros
  cuyo tipo de aventura no se haya vendido.

  A partir de dichos datos, se solicita informar:

  A. La cantidad de paquetes vendidos de cada tipo de aventura.
  B. La cantidad total de personas que disfrutaron de las aventuras durante la temporada.
  C. El total recaudado por cada venta.
  D. La venta con mayor importe de cada tipo de aventura.
  E. El paquete con menos horas incurridas y en qué tipo de actividad fue.*/

namespace Guia06;

    class Program
    {
        static void Main(string[] args)
        {   
            // Variables Principales

            int numeroPaquete, cantidadPersonas, contPaqueteA=0, acumB=0;
            float precioxPersona, precioVenta, maxPrecioVenta=0, horasActividad, paqueteMinHoras;
            char tipoAventura, minTipoAventura, tipoAventuraActual;

            Console.WriteLine();
            Console.Write("Ingrese el Número de Paquete: ");
            numeroPaquete = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la Cantidad de Personas Incluidas: ");
            cantidadPersonas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Precio Por Persona: ");
            precioxPersona = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese las Horas Totales de Actividad: ");
            horasActividad = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese el Tipo de Aventura: ");
            tipoAventura = Convert.ToChar(Console.ReadLine()!);

            paqueteMinHoras = horasActividad;
            minTipoAventura = tipoAventura;

            while (numeroPaquete != 0)
            {
                tipoAventuraActual = tipoAventura;

                // Variables Que Se Recetean Por Grupo

                contPaqueteA=0;
                maxPrecioVenta=0;

                while (tipoAventura == tipoAventuraActual)
                {
                    contPaqueteA++;
                    acumB += cantidadPersonas;
                    precioVenta = cantidadPersonas * precioxPersona;


                    Console.WriteLine();
                    Console.WriteLine($"Total Recaudado Por Venta: {precioVenta}");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine();

                    if (precioVenta > maxPrecioVenta) maxPrecioVenta = precioVenta;

                    if (horasActividad < paqueteMinHoras)
                    {
                        paqueteMinHoras = horasActividad;
                        minTipoAventura = tipoAventura;
                    }

                    Console.Write("Ingrese el Número de Paquete: ");
                    numeroPaquete = Convert.ToInt32(Console.ReadLine());

                    if(numeroPaquete != 0)
                    {
                        Console.Write("Ingrese la Cantidad de Personas Incluidas: ");
                        cantidadPersonas = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el Precio Por Persona: ");
                        precioxPersona = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Ingrese las Horas Totales de Actividad: ");
                        horasActividad = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Ingrese el Tipo de Aventura: ");
                        tipoAventura = Convert.ToChar(Console.ReadLine()!);
                    }
                    else break;
                }

                Console.WriteLine($"CANTIDA DE PAQUETES VENDIDOS EN CADA AVENTURA: {contPaqueteA}");
                Console.WriteLine($"VENTA DE MAYOR IMPORTE: {maxPrecioVenta}");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"CANTIDAD TOTAL DE PERSONAS QUE DISFRUTARON DE LA TEMPORADA: {acumB}");
            Console.WriteLine($"PAQUETE CON MENOS HORAS INCURRIDAS: {paqueteMinHoras} - TIPO DE AVENTURA: {minTipoAventura}");
        }
    }

    /* LA LOGICA DE ESTE CODIGO ESTA BIEN, PERO DEBIDO A QUE SOLO SE PUEDE USAR CON LAS ESTRUCTURAS ALGORITMICAS DE ESTA GUIA, NO SE PUEDE
       MOSTRAR DE MANERA ORDENADA LOS DATOS OBTENIDOS*/