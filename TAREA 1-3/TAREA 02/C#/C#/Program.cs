using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 2: Calcular la factura de consumo eléctrico con IGV.
            // Se suma un cargo fijo de S/.5.00 más S/.0.55 por cada kWh consumido.
            // Al subtotal se le aplica el 18% de IGV para obtener el impuesto.
            // El total es la suma del subtotal más el IGV calculado.

            // Ingresar datos de consumo eléctrico
            Console.WriteLine("Ingrese el consumo eléctrico en kWh:");
            double consumo = double.Parse(Console.ReadLine());

            // Calcular el subtotal
            double subtotal = 5 + (0.55 * consumo);

            // Calcular el IGV
            double igv = subtotal * 0.18;

            // Calcular el total
            double total = subtotal + igv;

            // Mostrar resultados
            Console.WriteLine($"Consumo: {consumo} kWh");
            Console.WriteLine($"Subtotal: S/.{subtotal:F2}");
            Console.WriteLine($"IGV (18%): S/.{igv:F2}");
        }
    }
}
