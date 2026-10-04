using System;
using System.Globalization;

/*Hacer un programa para ingresar los valores de los pesos de distintas encomiendas que se deben enviar a distintos clientes y que finaliza
  cuando se ingresa un peso cero. Se deben agrupar las encomiendas en camiones que pueden transportar hasta 200 kilos en total.

  Por ejemplo:

  | Camión 1   | Camión 2 |  Camión 3   | Camión 4 | Camión 5 |
  | 10,20,140, |  70,100  | 40,10,50,80 | 90,30,40 |  50, etc |    0    |

  Se puede determinar e informar:

  A. El número de camión y peso total de encomiendas (Camión 1: 170kg, Camión 2: 170kg, etc).
  B. El número de camión que transporta mayor cantidad de encomiendas (en el ejemplo anterior sería el Camión 3 con 4 encomiendas).
  C. La cantidad de camiones que se terminaron cargando.*/

namespace Guia06;

    class Program
    {
        static void Main(string[] args)
        {   
            // Variables Principales

            int camion=0, camionMaximo=0, maximoEncomiendas=0;
            float pesoEncomienda;

            Console.WriteLine();
            Console.Write("Ingrese Encomienda Por Peso: ");
            pesoEncomienda = Convert.ToSingle(Console.ReadLine());

            while (pesoEncomienda != 0)
            {
                camion++;

                // Variables Que Se Recetean Por Grupo

                int encomiendas=0;
                float pesoCamion=0;

                while ((pesoEncomienda + pesoCamion) < 200 && pesoEncomienda != 0)
                {
                    pesoCamion += pesoEncomienda;
                    encomiendas++;

                    Console.Write("Ingrese Encomienda Por Peso: ");
                    pesoEncomienda = Convert.ToSingle(Console.ReadLine());
                }

                Console.WriteLine();
                Console.WriteLine($"Camión: {camion}");
                Console.WriteLine();
                Console.WriteLine($"Peso Total de la Carga: {pesoCamion}");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine();

                if (encomiendas > maximoEncomiendas)
                {
                    maximoEncomiendas = encomiendas;
                    camionMaximo = camion;
                }
            }

            Console.WriteLine($"Camión con la Máxima Cantidad de Encomiendas: Camión {camionMaximo}");
            Console.WriteLine($"Cantida Total de Camiones que Fueron Cargados: {camion}");
        }
    }