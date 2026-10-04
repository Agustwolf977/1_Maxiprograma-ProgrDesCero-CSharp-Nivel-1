using System;

/*Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio
  de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro
  teniendo en cuenta los datos ingresados.*/

namespace Guia01;

    class Program
    {
        static void Main(string[] args)
        {

            float distanceInKilometers, averageSpeed, arrivalTime;
        
            Console.Write("Ingrese la Distancia a Recorrer: ");
            distanceInKilometers = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese la Velocidad Promedio de Su vehículo: ");
            averageSpeed = Convert.ToSingle(Console.ReadLine());

            arrivalTime = distanceInKilometers / averageSpeed;

            Console.WriteLine("Su Tiempo de Llegada es de: " + arrivalTime + " Horas");

        }
    }