using System;
using System.Globalization;
using System.Reflection.Metadata;

/*Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia.

  Que analice el número y escriba variable recibida por referencia con:

  A. 1 si el número es positivo.
  B. -1 si el número es negativo.
  C. 0 si el número es cero.

  Hacer un programa main que permita ingresar 100 números y emitir por pantalla cuántos son positivos, cuántos negativos y cuántos cero.*/

namespace Guia07;

    class Program
    {
        static void PositivoNegativoCero(float number, ref int parameter)
        {
            if (number == 0) parameter = 0;
            else
            {
                if (number > 0) parameter = 1;
                else parameter = -1;
            }
        }

        static void Main(string[] args)
        {
            float num;
            int flag=0, countNeg=0, countCero=0, countPos=0;

            for (int i=0; i<100; i++)
            {
                Console.WriteLine();
                Console.Write("Ingrese Un Número: ");
                num = Convert.ToSingle(Console.ReadLine());

                PositivoNegativoCero(num, ref flag);

                switch (flag)
                {
                    case -1:
                        countNeg++;
                        break;
                    case 0:
                        countCero++;
                        break;
                    case 1:
                        countPos++;
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"La Cantidad de Números Negativos Son: {countNeg}");
            Console.WriteLine($"La Cantidad de Ceros Son: {countCero}");
            Console.WriteLine($"La Cantidad de Números Positivos Son: {countPos}");
        }
    }