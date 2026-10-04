using System;
using System.Globalization;

/*Se dispone de una lista de 10 grupos de números enteros separados entre ellos por ceros. Se pide determinar e informar:

  A.El número del grupo con mayor porcentaje de números impares positivos respecto al total de números que forman el grupo.
  B.Para cada grupo, el último número primo y en qué orden apareció en ese grupo. Si en un grupo no hubiera números primos, informarlo con
    un cartel aclaratorio.
  C.Informar cuántos grupos están todos formados por números ordenados de mayor a menor.*/

namespace Guia06;

    class Program
    {
        static void Main(string[] args)
        {
            // Variables Principales

            float maxPorcentaje=0, porcentImparesPos=0;
            int grMaPorcentImpPos=0, gruposOrdenados=0;

            for (int i=0; i<10; i++)
            {
                // Variables Que Se Recetean Por Grupo

                int numero=0, posicion=0, mayor=0, cantNumeros=0, cantImparesPos=0, ultimoPrimo=0, posUltimoPrimo=0, cantPrimos=0;
                bool banderaNoOrdenado=false;

                Console.WriteLine();
                Console.WriteLine($"* GRUPO {i+1}. INGRESE NÚMEROS (0 PARA FINALIZAR): ");
                Console.WriteLine();
                Console.Write("Ingrese Un Número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                while (numero != 0)
                {
                    // PUNTO A: Impares Positivos --

                    cantNumeros++;

                    if (numero % 2 != 0 && numero > 0) cantImparesPos++;


                    // PUNTO B: Lógica de Primos --

                    posicion++;

                    int divisor=0;

                    // Probamos desde 1 Hasta la Variable "numero" Para Ver Cuántos Divisores Tiene

                    for (int j=1; j<=numero; j++) if (numero % j == 0) divisor++;

                    // Si Tiene Exáctamente 2 Divisores (1 y sí Mismo), Es Primo

                    if (divisor == 2)
                    {
                        cantPrimos++;
                        ultimoPrimo = numero;
                        posUltimoPrimo = posicion;
                    }


                    // PUNTO C: Orden de Mayor a Menor --

                    if (posicion == 1) mayor = numero;
                    else if (numero <= mayor) mayor = numero;
                    else banderaNoOrdenado = true;

                    Console.Write("Ingrese Otro Número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                }

                // --- AL SALIR DEL WHILE (PROCESAR GRUPO) ---


                // A. Informe del Grupo con Más Porcentaje de Números Impares Positivos

                if (cantNumeros > 0)
                {
                    porcentImparesPos = (cantImparesPos * 100) / cantNumeros;
                    if (porcentImparesPos > maxPorcentaje)
                    {
                        maxPorcentaje = porcentImparesPos;
                        grMaPorcentImpPos = i+1;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"El Grupo {i+1} no Tiene Números Para Calcular Porcentajes");
                }

                // B. Informe de Primos

                if (cantPrimos > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Último Primo: {ultimoPrimo} - Posición: {posUltimoPrimo}");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"No Se Encontraron Números Primos en el Grupo {i+1}");
                }

                // C. Orden de Mayor a Menor

                if (banderaNoOrdenado == false && cantNumeros > 0) gruposOrdenados++;
            }   

            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"Grupo con Mayor % de Impares Positivos: {grMaPorcentImpPos}");
            Console.WriteLine($"Cantidad de Grupos Ordenados de Mayor a Menor: {gruposOrdenados}");
        }
    }