using System;
using System.Globalization;

/*Una empresa que fabrica 20 artículos tiene la siguiente información para cada uno de ellos:

  Código de Artículo (4 dígitos, no correlativos).
  Precio Unitario.

  Este primer lote no se encuentra ordenado.
  Cuenta por otro lado con un lote de registros con las ventas del año anterior. Cada registro contiene la siguiente información:

  Número de Cliente (1 a 300).
  Código de Artículo (4 dígitos no correlativos).
  Mes (1 a 12).
  Día (1 a 31).
  Cantidad vendida.

  Puede haber más de un registro para el mismo artículo. El lote finaliza con un registro con número de cliente igual a cero. Se pide:

  Un listado con el siguiente formato:


  |    Código de Artículo    |    Cantidad Total Vendida    |
  |           999            |             999              |

  Este listado debe salir ordenado de mayor a menor por cantidad total vendida.

  Informar, si los hubiera, los nombres de los meses en que no hubo ventas.
  Informar los códigos de los artículos cuyas ventas en cantidad son mayores al promedio.*/

namespace Guia09;

    class Program
    {
        // --- FUNCION DE CARGA ---

        static void CargarProductos(int[] vCod, float[] vPre)
        {
            for (int i=0; i < vCod.Length; i++)
            {
                Console.WriteLine();
                Console.Write($"Artículo {i+1}/{vCod.Length} - Ingrese Código (4 Dígitos): ");
                vCod[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba el Precio Unitario: ");
                vPre[i] = Convert.ToSingle(Console.ReadLine());
            }
        }

        // --- FUNCION DE PROCESO DE VENTAS --- Acumula Ventas y Cuenta Meses

        static void ProcesarVentas(int[] vCod, int[] vCant, int[] vMes)
        {
            Console.Write("Ingrese el Número de Cliente: ");
            int numeroCliente = Convert.ToInt32(Console.ReadLine());

            while (numeroCliente != 0)
            {
                Console.Write("Ingrese el Código de Artículo: ");
                int codArticulo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el Mes (1-12): ");
                int mes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el Día (1-31): ");
                int dia = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese la Cantidad Vendida: ");
                int cantVendida = Convert.ToInt32(Console.ReadLine());

                // Actualizo Acumulador del Punto A (Busco el Indice)
                for (int i=0; i < vCod.Length; i++) if (vCod[i] == codArticulo) vCant[i] += cantVendida;

                vMes[mes-1]++; // Actualizo Registro del Punto B (Meses)

                Console.WriteLine();
                Console.Write("Siguiente Número de Cliente: ");
                numeroCliente = Convert.ToInt32(Console.ReadLine());
            }
        }

        // --- FUNCION DE ORDENAMIENTO (PUNTO A: Ordenamiento Burbuja, de Mayor a Menor Por Cantidad)

        static void OrdenarRanking(int[] vCod, int[] vCant)
        {
            for (int i=0; i < vCant.Length; i++)
            {
                
                for (int j=0; j < ((vCant.Length)-1)-i; j++)
                {
                    if (vCant[j] < vCant[j+1])
                    {
                        //Intercambio Cantidades
                        int auxCant = vCant[j];
                        vCant[j] = vCant[j+1];
                        vCant[j+1] = auxCant;

                        // Intercambio Códigos
                        int auxCod = vCod[j];
                        vCod[j] = vCod[j+1];
                        vCod[j+1] = auxCod; 
                    }    

                }
                
            }
        }

        // --- FUNCION DE MESES SIN VENTAS (PUNTO B: Determino Cuales Fueron los Meses que no Presentaron Ventas)

        static void MesesSinVentas(int[] vMes)
        {
            for (int i=0; i < 12; i++)
            {
                if (vMes[i] == 0)
                {
                    switch (i+1)
                    {
                        case 1: Console.WriteLine("- Enero"); break;
                        case 2: Console.WriteLine("- Febrero"); break;
                        case 3: Console.WriteLine("- Marzo"); break;
                        case 4: Console.WriteLine("- Abril"); break;
                        case 5: Console.WriteLine("- Mayo"); break;
                        case 6: Console.WriteLine("- Junio"); break;
                        case 7: Console.WriteLine("- Julio"); break;
                        case 8: Console.WriteLine("- Agosto"); break;
                        case 9: Console.WriteLine("- Septiembre"); break;
                        case 10: Console.WriteLine("- Octubre"); break;
                        case 11: Console.WriteLine("- Noviembre"); break;
                        case 12: Console.WriteLine("- Diciembre"); break;
                    }
                }
            }
        }

        // --- FUNCION DE ARTICULOS SOBRE EL PROMEDIO (PUNTO C: Determino Que Articulo Supero el Promedio de Ventas)

        static void ArtSobrePromedio(int[] vCod, int[] vCant)
        {
            int acumuladorTotal = 0;

            for (int i=0; i < vCant.Length; i++) acumuladorTotal += vCant[i];

            float promedio = (float)acumuladorTotal / vCod.Length;

            Console.WriteLine($"- Promedio General de Ventas: {promedio:F2}");
            Console.WriteLine();
            
            for (int i=0; i < vCant.Length; i++)
            {
                if (vCant[i] > promedio)
                {
                    Console.WriteLine($"- El Artículo {vCod[i]} Superó el Promedio Con {vCant[i]} Ventas.");
                }
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int[] vectorCodArt = new int[5], vectorCantTotal = new int[5], vectorMeses = new int[12];
            float[] vectorPrecio = new float[5];

            // --- 1. LOTE DE CARGA (Los 20 Artículos) ---

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---INICIO DE CARGA DE ARTÍCULOS: ");
            Console.WriteLine();

            CargarProductos(vectorCodArt, vectorPrecio);


            // --- 2. LOTE DE PROCESO (Ventas) ---
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---INICIO DE CARGA DE VENTAS (Corta Con Cliente 0): ");
            Console.WriteLine();
    
            for (int i=0; i < vectorCantTotal.Length; i++) vectorCantTotal[i] = 0; // Inicializo el Acumulador de Ventas en 0.
            
            for (int i=0; i < 12; i++) vectorMeses[i] = 0; // Inicializo  Vector Meses en 0.

            ProcesarVentas(vectorCodArt, vectorCantTotal, vectorMeses);


            // --- 3. PROCESAMIENTO DE RESULTADOS / SALIDA DE DATOS ---

            // Punto A: Ordenamiento Por Burbujeo (Mayor a Menor Por Cantidad)

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- PUNTO A: LISTA DE VENTAS ---");
            Console.WriteLine();

            OrdenarRanking(vectorCodArt, vectorCantTotal);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" Codigo de Articulo | Cantidad Total Vendida ");
            Console.WriteLine("---------------------------------------------");
            
            for (int i = 0; i < vectorCantTotal.Length; i++)
            {
                Console.WriteLine($"{vectorCodArt[i],19} | {vectorCantTotal[i],-23}");
            }
            Console.WriteLine("---------------------------------------------");

            // Punto B: Meses sin ventas

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- PUNTO B: MESIS SIN VENTAS ---");
            Console.WriteLine();

            MesesSinVentas(vectorMeses);

            // Punto C: Artículos Sobre el Promedio

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- PUNTO C: ARTICULOS SOBRE EL PROMEDIO ---");
            Console.WriteLine();

            ArtSobrePromedio(vectorCodArt, vectorCantTotal);
        }
    }