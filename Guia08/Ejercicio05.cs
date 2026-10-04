using System;
using System.Globalization;
using System.Numerics;

/*Hacer un programa que solicite una serie de valores de tipo char (caracteres).  Se entiende por carácter a cada elemento que se obtiene de presionar una  tecla. Por ejemplo
  el valor “25” tiene dos caracteres (si quisiéramos guardarlo  en variables enteras nos alcanza con una, pero si queremos guardarlo en  variables char, necesitaremos dos);
  la frase “maxi programa” tiene 13 (se incluye el espacio como un carácter). La cantidad de valores será como máximo 50, pero el programa puede cortar  antes si se ingresa
  el carácter “.” (punto). Una vez cargado el vector de char,  recorrerlo y reemplazar todas las apariciones de la letra “a” por la letra “e”,  por ejemplo:

  Vector char original: “Hola muchachada cómo están”.
  Vector char modificado: “Hole muchechede cómo esten”

  Finalmente, mostrar el resultado en pantalla.

  Nota: necesitaremos un vector char de 50, pero no lo cargaremos con un FOR.*/

namespace Guia08;

    class Program
    {
        static void Main(string[] args)
        {
            char[] vector = new char[50];

            char letter;
            int i=0, length;
            
            Console.WriteLine();
            Console.Write("Ingrese Una Letra: ");
            letter = Convert.ToChar(Console.ReadLine()!);

            while (letter != '.' && i < vector.Length)
            {
                vector[i] = letter;
                i++;

                if (i<vector.Length)
                {
                    Console.Write("Ingrese Otra Letra: ");
                    letter = Convert.ToChar(Console.ReadLine()!);
                }
            }

            length = i;

            for (i=0; i < length; i++) if (vector[i] == 'a' || vector[i] == 'á') vector[i] = 'e';

            for (i=0; i < length; i++) Console.WriteLine(vector[i]);
        }
    }