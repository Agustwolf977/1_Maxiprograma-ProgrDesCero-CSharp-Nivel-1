using System;
using System.Globalization;

/*Hacer un programa para ingresar por teclado una palabra y luego contar cuántas veces aparece el carácter “a” en la misma.*/

namespace Guia10;

    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorCodArt = new int[5], vectorCantTotal = new int[5], vectorMeses = new int[12];
            float[] vectorPrecio = new float[5];

            int codArticulo, auxCant, auxCod, numeroCliente, mes, dia, cantVendida;
            float promedio, acumuladorTotal;

            // --- 1. LOTE DE CARGA (Los 20 Artículos) ---

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---INICIO DE CARGA DE ARTÍCULOS: ");
            Console.WriteLine();

            for (int i=0; i < vectorCodArt.Length; i++)
            {
                Console.WriteLine();
                Console.Write($"Artículo {i+1}/{vectorCodArt.Length} - Ingrese Código (4 Dígitos): ");
                vectorCodArt[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba el Precio Unitario: ");
                vectorPrecio[i] = Convert.ToSingle(Console.ReadLine());

                vectorCantTotal[i] = 0; // Inicializo el Acumulador de Ventas, ya que estamos...
            }

            for (int i=0; i < 12; i++) vectorMeses[i] = 0; // Inicializo  Vector Meses en 0.


            // --- 2. LOTE DE PROCESO (Ventas) ---
    
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---INICIO DE CARGA DE VENTAS (Corta Con Cliente 0): ");
            Console.WriteLine();

            Console.Write("Ingrese el Número de Cliente: ");
            numeroCliente = Convert.ToInt32(Console.ReadLine());

            while (numeroCliente != 0)
            {
                Console.Write("Ingrese el Código de Artículo: ");
                codArticulo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el Mes (1-12): ");
                mes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el Día (1-31): ");
                dia = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese la Cantidad Vendida: ");
                cantVendida = Convert.ToInt32(Console.ReadLine());

                // Actualizo Acumulador del Punto A (Busco el Indice)

                // Acordémonos que este también nos sirve para el Punto C.
                for (int i=0; i < vectorCodArt.Length; i++) if (vectorCodArt[i] == codArticulo) vectorCantTotal[i] += cantVendida;

                // Actualizo Registro del Punto B (Meses)
                vectorMeses[mes-1]++;

                Console.WriteLine();
                Console.Write("Siguiente Número de Cliente: ");
                numeroCliente = Convert.ToInt32(Console.ReadLine());
            }


            // --- 3. PROCESAMIENTO DE RESULTADOS / SALIDA DE DATOS ---


            // PUNTO A: Ordenamiento Por Burbujeo (Mayor a Menor Por Cantidad)

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- PUNTO A: LISTA DE VENTAS ---");
            Console.WriteLine();

            for (int i=0; i < vectorCantTotal.Length; i++)
            {
                for (int j=0; j < ((vectorCantTotal.Length)-1)-i; j++)
                {
                    if (vectorCantTotal[j] < vectorCantTotal[j+1])
                    {
                        //Intercambio Cantidades
                        auxCant = vectorCantTotal[j];
                        vectorCantTotal[j] = vectorCantTotal[j+1];
                        vectorCantTotal[j+1] = auxCant;

                        // Intercambio Códigos
                        auxCod = vectorCodArt[j];
                        vectorCodArt[j] = vectorCodArt[j+1];
                        vectorCodArt[j+1] = auxCod; 
                    }

                }
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" Codigo de Articulo | Cantidad Total Vendida ");
            Console.WriteLine("---------------------------------------------");
            
            for (int i = 0; i < vectorCantTotal.Length; i++)
            {
                Console.WriteLine($"{vectorCodArt[i],19} | {vectorCantTotal[i],-23}");
            }
            Console.WriteLine("---------------------------------------------");


            // PUNTO B: Meses sin ventas

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- PUNTO B: MESIS SIN VENTAS ---");
            Console.WriteLine();

            for (int i=0; i < 12; i++)
            {
                if (vectorMeses[i] == 0)
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


            // PUNTO C: Artículos Sobre el Promedio

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- PUNTO C: ARTICULOS SOBRE EL PROMEDIO ---");
            Console.WriteLine();

            acumuladorTotal = 0;

            for (int i=0; i < vectorCantTotal.Length; i++) acumuladorTotal += vectorCantTotal[i];

            promedio = acumuladorTotal / vectorCodArt.Length;

            Console.WriteLine($"- Promedio General de Ventas: {promedio:F2}");
            Console.WriteLine();
            
            for (int i=0; i < vectorCantTotal.Length; i++)
            {
                if (vectorCantTotal[i] > promedio)
                {
                    Console.WriteLine($"- El Artículo {vectorCodArt[i]} Superó el Promedio Con {vectorCantTotal[i]} Ventas.");
                }
            }
            Console.WriteLine();
        }
    }