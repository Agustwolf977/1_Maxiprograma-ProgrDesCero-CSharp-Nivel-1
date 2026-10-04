using System;

/*Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero y luego mostrar por pantalla el menor y el
  segundo menor.*/

namespace Guia05;

    class Program
    {
        static void Main(string[] args)
        {
            
            float number, minNumber1=0, minNumber2=0;
            bool flag1=false, flag2=false;

            Console.Write("Ingrese Un Número: ");
            number = Convert.ToSingle(Console.ReadLine());

            while (number != 0)
            {
                if (!flag1)
                {
                    minNumber1 = number;
                    flag1 = true;
                }
                else if (!flag2)
                {
                    flag2 = true;
                    
                    if (number < minNumber1)
                    {
                        minNumber2 = minNumber1;
                        minNumber1 = number;
                    }
                    else minNumber2 = number;
                }
                else if (number < minNumber1)
                {
                    minNumber2 = minNumber1;
                    minNumber1 = number;
                }
                else if (number < minNumber2) minNumber2 = number;
                
                Console.Write("Ingrese Otro Número: ");
                number = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("El Número Mas Pequeño es: " + minNumber1);
            Console.WriteLine("El Segundo Número Mas Pequeño es: " + minNumber2);
            
        }
    }