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
            // Ejercicio 3: Calcular la distancia entre dos puntos en el plano.
            // Se utiliza el teorema de Pitágoras con las coordenadas (x1, y1) y (x2, y2).
            // La fórmula aplica raíz cuadrada a la suma de los cuadrados de las diferencias.
            // En código: Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Ingrese las coordenadas del punto x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas del punto y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas del punto x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas del punto y2:");
            double y2 = double.Parse(Console.ReadLine());

            // Cálculo de la distancia utilizando el teorema de Pitágoras

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            // Mostrar el resultado
           
            Console.WriteLine($"La distancia entre los puntos ({x1}, {y1}) y ({x2}, {y2}) es: {distancia}");
        }
    }
}
