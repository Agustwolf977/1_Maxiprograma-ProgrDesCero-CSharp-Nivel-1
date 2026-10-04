using System;

/*Hacer un programa que solicite dos números y luego los muestre junto con los números entre el menor y el mayor de ellos.
  Acordate: usando WHILE.*/

namespace Guia05;

    class Program
    {
        static void Main(string[] args)
        {
            
            int number1, number2, maxNum, minNum;

            Console.Write("Ingrese el Primer Número: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el Segundo Número: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                maxNum = number1;
                minNum = number2;
            }
            else
            {
                maxNum = number2;
                minNum = number1;
            }

            while (minNum <= maxNum)
            {
                Console.WriteLine(minNum);
                minNum++;
            }
            
        }
    }