using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 5: Aplicar diferentes tipos de redondeo a un precio en soles.
            // Se debe mostrar el valor redondeado hacia arriba (Ceiling), hacia abajo (Floor)
            // y el valor truncado eliminando los decimales.
            // Se utilizan funciones matemáticas propias del lenguaje para cada caso.

            Console.WriteLine("Ingrese el precio en soles: ");
            double precio = double.Parse(Console.ReadLine());

            // Redondeo hacia arriba (Ceiling)

            double precio_cell = Math.Ceiling(precio);

            // Redondeo hacia abajo (Floor)

            double precio_floor = Math.Floor(precio);

            // Valor truncado eliminando los decimales

            double precio_trunc = Math.Truncate(precio);

            // Redondea automaticamente a decimales

            double precio_round = Math.Round(precio, 2);


            // Mostrar los resultados

            Console.WriteLine($"Precio original: {precio}");
            Console.WriteLine($"Precio redondeado hacia arriba (Ceiling): {precio_cell}");
            Console.WriteLine($"Precio redondeado hacia abajo (Floor): {precio_floor}");
            Console.WriteLine($"Precio truncado eliminando los decimales: {precio_trunc}");
            Console.WriteLine($"Precio redondeado a 2 decimales (Round): {precio_round}");
        }
    }
}
