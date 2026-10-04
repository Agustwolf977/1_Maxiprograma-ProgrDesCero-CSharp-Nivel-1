using System;

/*Hacer un programa para ingresar un valor que estará expresado en minutos. Si los minutos superan los 60,
  pasar el valor a horas, de lo contrario dejarlo en minutos. Mostrar el resultado en pantalla aclarando si
  se muestran minutos u horas.*/

namespace Guia02;

    class Program
    {
        static void Main(string[] args)
        {
            
            float minutesCount, hoursCount;

            Console.Write("Ingrese un Valor: ");
            minutesCount = Convert.ToSingle(Console.ReadLine());

            if (minutesCount > 60)
            {
                hoursCount = minutesCount / 60;
                Console.WriteLine(hoursCount + " Horas");
            }
            else
            {
                Console.WriteLine(minutesCount + " Minutos");
            }
            
        }
    }