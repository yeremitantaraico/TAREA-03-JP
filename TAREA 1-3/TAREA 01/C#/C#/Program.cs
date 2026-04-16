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
            // Ejercicio 1: Calcular el pago total mensual por el alquiler de una casa.
            // Se consideran los precios por habitación, baño y patio según la inmobiliaria.
            // El usuario ingresa la cantidad de cada uno y se multiplica por su costo.
            // El total es la suma de (habitaciones*30) + (baños*10) + (patios*15).

            // Declaracion de variables
            Console.WriteLine("Ingrese la cantidad de habitaciones:");
            int habitaciones = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de baños:");
            int banos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de patios:");
            int patios = int.Parse(Console.ReadLine());

            // Calculo del pago total

            int pagoTotal = (habitaciones * 30) + (banos * 10) + (patios * 15);

            // Mostrar el resultado

            Console.WriteLine($"El pago total mensual por el alquiler de la casa es: " + pagoTotal);
        }
    }
}
