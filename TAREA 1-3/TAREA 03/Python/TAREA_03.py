# Ejercicio 3: Convertir una temperatura de Celsius a Fahrenheit y Kelvin.
# Se aplican las fórmulas F = C * (9.0/5) + 32 y K = C + 273.15.
# Python maneja bien los decimales, pero se recomienda usar valores con punto.
# Se debe mostrar ambas conversiones a partir del valor ingresado.

import math

# Solicitar al usuario la temperatura en Celsius
temperatura_celsius = float(input("Ingrese la temperatura en Celsius: "))

# Convertir a Fahrenheit
temperatura_fahrenheit = temperatura_celsius * (9.0 / 5) + 32

# Convertir a Kelvin
temperatura_kelvin = temperatura_celsius + 273.15

# Mostrar los resultados
print(f"{temperatura_celsius} °C es igual a {temperatura_fahrenheit} °F")
print(f"{temperatura_celsius} °C es igual a {temperatura_kelvin} K")
