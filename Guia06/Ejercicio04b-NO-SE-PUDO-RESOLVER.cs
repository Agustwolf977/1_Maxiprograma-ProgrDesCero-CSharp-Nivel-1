using System;
using System.Globalization;

namespace Guia06
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Variables Principales (Control general y Totales de la Temporada)
            int numeroPaquete;
            int cantidadPersonas=0;
            int acumb = 0; // Punto B: Total general de personas
            
            float precioxPersona=0;
            float precioVenta;
            float horasActividad=0;
            
            // Variables para el Mínimo de todo el programa (Punto E)
            float paqueteMinHoras = 9999; // Arranca alto para que cualquier paquete sea menor
            char minTipoAventura = ' ';
            
            char tipoAventura;
            char tipoAventuraActual;

            // Primera lectura antes de los ciclos
            Console.WriteLine();
            Console.Write("Ingrese el Número de Paquete: ");
            numeroPaquete = Convert.ToInt32(Console.ReadLine());
            
            if (numeroPaquete != 0)
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
            else
            {
                tipoAventura = ' '; // Evita error de variable no asignada si meten 0 al inicio
            }

            // --- BUCLE PRINCIPAL (Controla el final de todo el lote con paquete 0) ---
            while (numeroPaquete != 0)
            {
                tipoAventuraActual = tipoAventura;
                
                // // Variables Que Se Resetean Por Grupo (Exclusivas de CADA tipo de aventura)
                int contPaqueteA = 0;       // Punto A
                float maxPrecioVenta = 0;   // Punto D

                // --- BUCLE INTERNO (Procesa el grupo actual y frena si cambia la aventura O si meten paquete 0) ---
                while (tipoAventura == tipoAventuraActual && numeroPaquete != 0)
                {
                    contPaqueteA++;
                    acumb += cantidadPersonas;
                    precioVenta = cantidadPersonas * precioxPersona;

                    // Informe individual por cada venta (Punto C)
                    Console.WriteLine();
                    Console.WriteLine($"Total Recaudado Por Venta: {precioVenta}");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine();

                    // Determinar el mayor importe del grupo actual (Punto D)
                    if (precioVenta > maxPrecioVenta)
                    {
                        maxPrecioVenta = precioVenta;
                    }

                    // Determinar el paquete con menos horas de toda la temporada (Punto E)
                    if (horasActividad < paqueteMinHoras)
                    {
                        paqueteMinHoras = horasActividad;
                        minTipoAventura = tipoAventura;
                    }

                    // Lectura de los datos de la SIGUIENTE venta dentro del grupo
                    Console.Write("Ingrese el Número de Paquete: ");
                    numeroPaquete = Convert.ToInt32(Console.ReadLine());
                    
                    if (numeroPaquete != 0)
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
                } // Aquí cierra el while interno (Se terminó un tipo de aventura o se metió un 0)

                // --- INFORMES POR GRUPO (Aparecen apenas cambia la actividad) ---
                Console.WriteLine();
                Console.WriteLine($">>>> INFORMES AVENTURA TIPO {tipoAventuraActual} <<<<");
                Console.WriteLine($"CANTIDAD DE PAQUETES VENDIDOS: {contPaqueteA}"); // Punto A
                Console.WriteLine($"VENTA DE MAYOR IMPORTE: {maxPrecioVenta}");         // Punto D
                Console.WriteLine("=============================================");
                Console.WriteLine();

            } // Aquí cierra el while principal

            // --- INFORMES GENERALES (Final de toda la temporada, afuera de los bucles) ---
            Console.WriteLine();
            Console.WriteLine("======= REPORTE FINAL DE LA TEMPORADA =======");
            Console.WriteLine($"CANTIDAD TOTAL DE PERSONAS QUE DISFRUTARON: {acumb}"); // Punto B
            Console.WriteLine($"PAQUETE CON MENOS HORAS INCURRIDAS: {paqueteMinHoras} horas (Actividad: {minTipoAventura})"); // Punto E
            Console.WriteLine("=============================================");
            Console.WriteLine();
        }
    }
}

/* LA LOGICA DE ESTE CODIGO ESTA BIEN, PERO DEBIDO A QUE SOLO SE PUEDE USAR CON LAS ESTRUCTURAS ALGORITMICAS DE ESTA GUIA, NO SE PUEDE
   MOSTRAR DE MANERA ORDENADA LOS DATOS OBTENIDOS*/