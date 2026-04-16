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
            // Ejercicio 3: Convertir una temperatura de Celsius a Fahrenheit y Kelvin.
            // Se aplican las fórmulas F = C * (9.0/5) + 32 y K = C + 273.15.
            // En C# es importante usar 9.0/5 para evitar división entera (9/5 = 1).
            // Se debe mostrar ambas conversiones a partir del valor ingresado.

            // Solicitar al usuario que ingrese la temperatura en Celsius.
            Console.WriteLine("Ingrese la temperatura en Celsius:");
            double celsius = double.Parse(Console.ReadLine());

            // Calcular la temperatura en Fahrenheit y Kelvin.
            double fahrenheit = celsius * (9.0 / 5) + 32;
            double kelvin = celsius + 273.15;

            // Mostrar los resultados.
            Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit:F2} °F");
            Console.WriteLine($"La temperatura en Kelvin es: {kelvin:F2} K");


        }
    }
}
