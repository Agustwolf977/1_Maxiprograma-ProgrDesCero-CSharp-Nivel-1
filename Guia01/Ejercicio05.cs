using System;

/*Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 mas una comisión del 5% sobre el
  total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y
  que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.*/

namespace Guia01;

    class Program
    {
        static void Main(string[] args)
        {

            float totalInvoiced, fixedSalary, commission, totalToRecieve;
        
            Console.Write("Ingrese el Total Facturado: ");
            totalInvoiced = Convert.ToSingle(Console.ReadLine());

            fixedSalary = 15000;
            commission = totalInvoiced * 0.05;
            totalToRecieve = fixedSalary + commission;

            Console.WriteLine("El Total de Su Sueldo a Cobrar es: " + "ARS" + totalToRecieve);

        }
    }