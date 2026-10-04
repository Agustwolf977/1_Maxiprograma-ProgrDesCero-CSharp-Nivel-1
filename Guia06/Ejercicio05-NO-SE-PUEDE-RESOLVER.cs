using System;
using System.Globalization;

/*Una empresa registró las compras realizadas a sus distintos proveedores durante todo el año anterior. Para cada compra se registraron
  los siguientes datos:

  * Número de proveedor (número de cuatro cifras no correlativo).
  * Día (1 a 31).
  * Mes (1 a 12).
  * Tipo de Factura (Responsable Inscripto: “A”, Consumidor Final: “B”, o Monotributo: “C”).
  * Número de producto (número no correlativo).
  * Cantidad comprada.
  * Precio unitario del producto.

  Ese lote finaliza con un registro con número de proveedor igual a 0.
  Los registros están agrupados por número de proveedores. En el lote anterior no aparecen registros de los proveedores a los que no se
  les hayan realizado compras.

  Se pide determinar e informar:

  A. El monto máximo registrado en una sola compra por cada proveedor y el número de proveedor al que se le compró.
  B. La inversión total de todo el año discriminada por tipo de factura.
  C. La compra con menor monto registrada durante el mes de Agosto junto al número de producto comprado.
  D. La cantidad de compras que se realizaron a cada proveedor.
  E. El número de producto con mayor cantidad adquirida en una sola compra y a qué proveedor se compró.*/

namespace Guia06;

    class Program
    {
        static void Main(string[] args)
        {   
            // Variables Principales

            int cantidadComprada, maxcantidadComprada=0, numProveeActual, dia, mes, productoMinimo, numeroProducto, maxProducto, tipoFactura, numeroProveedor, maxNumProveedor;
            float precioUnitario, monto, minMontoAgosto=0, acumTFA=0, acumTFB=0, acumTFC=0;
            bool bandera=false;

            Console.WriteLine();
            Console.Write("Ingrese el Número de Proveedor: ");
            numeroProveedor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Día (Del 1 al 31): ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Mes (Del 1 al 12): ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Tipo de Factura (Responsable Inscripto: 1, Consumidor Final: 2, Moontributo: 3): ");
            tipoFactura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Número de Producto: ");
            numeroProducto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la Cantidad Comprada: ");
            cantidadComprada = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Precio Unitario del Producto: ");
            precioUnitario = Convert.ToSingle(Console.ReadLine());

            while (numeroProveedor != 0)
            {
                numProveeActual = numeroProveedor;

                // Variables Que Se Recetean Por Grupo

                int contCompras=0;
                float montoMaximo=0;

                while (numeroProveedor == numProveeActual)
                {
                    monto = cantidadComprada * precioUnitario;

                    if (monto > montoMaximo) montoMaximo = monto;

                    switch (tipoFactura)
                    {
                        case 1:
                            acumTFA += monto;
                            break;
                        case 2:
                            acumTFB += monto;
                            break;
                        case 3:
                            acumTFC += monto;
                            break;
                        default:
                            Console.WriteLine("Número Inválido");
                        break;
                    }

                    contCompras++;

                    if (mes == 8)
                    {
                        if (!bandera)
                        {
                            minMontoAgosto = monto;
                            productoMinimo = numeroProducto;
                            bandera = true;
                        }
                        else if (monto < minMontoAgosto)
                        {
                            minMontoAgosto = monto;
                            productoMinimo = numeroProducto;
                        }
                    }
                    if (cantidadComprada > maxcantidadComprada)
                    {
                        maxcantidadComprada = cantidadComprada;
                        maxProducto = numeroProducto;
                        maxNumProveedor = numeroProveedor;
                    }

                    Console.WriteLine();
                    Console.Write("Ingrese el Número de Proveedor: ");
                    numeroProveedor = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el Día (Del 1 al 31): ");
                    dia = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el Mes (Del 1 al 12): ");
                    mes = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el Tipo de Factura (Responsable Inscripto: 1, Consumidor Final: 2, Moontributo: 3): ");
                    tipoFactura = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el Número de Producto: ");
                    numeroProducto = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese la Cantidad Comprada: ");
                    cantidadComprada = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el Precio Unitario del Producto: ");
                    precioUnitario = Convert.ToSingle(Console.ReadLine());
                }

                Console.WriteLine(montoMaximo, numeroProveedor);
                Console.WriteLine(contCompras);
            }

            Console.WriteLine();
            Console.WriteLine("INVERSIÓN ANUAL POR TIPO DE FACTURA:");
            Console.WriteLine();
            Console.WriteLine($"Tipo A: ${acumTFA} - Tipo B: ${acumTFB} - Tipo C: ${acumTFC}");
            Console.WriteLine(minMontoAgosto, productoMinimo);
            Console.WriteLine(maxProducto, maxNumProveedor);
        }
    }

    /* LA LOGICA DE ESTE CODIGO ESTA BIEN, PERO DEBIDO A QUE SOLO SE PUEDE USAR CON LAS ESTRUCTURAS ALGORITMICAS DE ESTA GUIA, NO SE PUEDE
       MOSTRAR DE MANERA ORDENADA LOS DATOS OBTENIDOS*/