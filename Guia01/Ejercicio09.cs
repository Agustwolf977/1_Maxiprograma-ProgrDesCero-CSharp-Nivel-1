using System;

/*Una universidad desea conocer los porcentajes de mujeres y hombres en las carreras de ciencias exactas.
  Se solicita un programa para cargar la cantidad de mujeres y la cantidad de hombres y que el mismo
  calcule y emita por pantalla los porcentajes correspondientes.*/

namespace Guia01;

    class Program
    {
        static void Main(string[] args)
        {

            float numberOfWomen, numberOfMen, porcentageOfWomen, porcentageOfMen;
        
            Console.Write("Ingrese la Cantidad de Mujeres: ");
            numberOfWomen = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese la Cantida de Hombres: ");
            numberOfMen = Convert.ToSingle(Console.ReadLine());

            porcentageOfWomen = (numberOfWomen * 100) / (numberOfWomen + numberOfMen);
            porcentageOfMen = 100 - porcentageOfWomen;

            Console.WriteLine("El Porcentaje de Mujeres es: " + porcentageOfWomen + "%");
            Console.WriteLine("El Porcentaje de Hombres es: " + porcentageOfMen + "%");
            
        }
    }