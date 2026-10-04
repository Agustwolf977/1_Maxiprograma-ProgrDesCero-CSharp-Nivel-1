using System;

/*Realizar nuevamente el ejercicio 8 pero ahora debe devolver también la posición en la que fueron encontrados cada uno de los números.*/

namespace Guia05;

    class Program
    {
        static void Main(string[] args)
        {
            
            float number, minNumber1=0, minNumber2=0;
            int counter=1, position1=0, position2=0;
            bool flag1=false, flag2=false;

            Console.Write("Ingrese Un Número: ");
            number = Convert.ToSingle(Console.ReadLine());

            while (number != 0)
            {
                if (!flag1)
                {
                    minNumber1 = number;
                    position1 = counter;
                    flag1 = true;
                }
                else if (!flag2)
                {
                    flag2 = true;
                    
                    if (number < minNumber1)
                    {
                        minNumber2 = minNumber1;
                        minNumber1 = number;
                        position2 = position1;
                        position1 = counter;
                    }
                    else
                    {
                        minNumber2 = number;
                        position2 = counter;
                    }
                }
                else if (number < minNumber1)
                {
                    minNumber2 = minNumber1;
                    minNumber1 = number;
                    position2 = position1;
                    position1 = counter;
                }
                else if (number < minNumber2)
                {
                    minNumber2 = number;
                    position2 = counter;
                }
                
                counter++;

                Console.Write("Ingrese Otro Número: ");
                number = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine($"El Número Mas Pequeño es: {minNumber1} - Su Posición es: {position1}");
            Console.WriteLine($"El Segundo Número Mas Pequeño es: {minNumber2} - Su Posición es: {position2}");
            
        }
    }