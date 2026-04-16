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
            // Ejercicio 4: Calcular el área y perímetro de un círculo a partir del radio.
            // Se utiliza la constante π que el lenguaje proporciona (Math.PI).
            // El área se obtiene con π * r^2 y el perímetro con 2 * π * r.
            // Estas fórmulas permiten calcular las propiedades básicas del círculo.

            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = Convert.ToDouble(Console.ReadLine());

            // Cálculo del área

            double area = Math.PI * Math.Pow(radio, 2);

            // Cálculo del perímetro

            double perimetro = 2 * Math.PI * radio;

            // Mostrar los resultados

            Console.WriteLine($"El área del círculo es: {area}");
            Console.WriteLine($"El perímetro del círculo es: {perimetro}");
        }
    }
}
