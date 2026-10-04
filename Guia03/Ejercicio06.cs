using System;

/*Hacer un programa para ingresar por teclado las longitud de los tres lados de un triángulo y luego determine e informe con un cartel
  aclaratorio a qué tipo de triángulo corresponde:
  -Equilátero: cuando los tres lados son iguales.
  -Isósceles: cuando dos de los tres lados sean iguales.
  -Escaleno: cuando todos los lados sean distintos.*/

namespace Guia03;

    class Program
    {
        static void Main(string[] args)
        {
            
            float sideA, sideB, sideC;

            Console.Write("Ingrese el Primer Lado: ");
            sideA = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Segundo Lado: ");
            sideB = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese el Tercer Lado: ");
            sideC = Convert.ToSingle(Console.ReadLine());

            if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine("Triángulo Equilátero");
            }
            else if (sideA != sideB && sideB != sideC && sideA != sideC)
            {
                Console.WriteLine("Triángulo Escaleno");
            }
            else
            {
                Console.WriteLine("Triángulo Isósceles");
            }
            
        }
    }