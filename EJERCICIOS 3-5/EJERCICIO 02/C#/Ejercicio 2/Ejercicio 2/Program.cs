using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Precio unitario (S/.): ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("Cantidad de productos: ");
            double cantidad = double.Parse(Console.ReadLine());

            double subtotal = precio * cantidad;
            double igv = subtotal * 0.18;
            double total = subtotal * igv;

            Console.WriteLine("Subtotal (sin IGV):  S/. " + subtotal);
            Console.WriteLine("IGV (18%):  S/. " + igv);
            Console.WriteLine("Total a pagar:  S/. " + total);

        }
    }
}
