# Ejercicio 1: Calcular el pago total mensual por el alquiler de una casa.
# Se consideran los precios por habitación, baño y patio según la inmobiliaria.
# El usuario ingresa la cantidad de cada uno y se multiplica por su costo.
# El total es la suma de (habitaciones*30) + (baños*10) + (patios*15).

import math

# Solicitar al usuario la cantidad de habitaciones, baños y patios
habitaciones = int(input("Ingrese la cantidad de habitaciones: "))
banos = int(input("Ingrese la cantidad de baños: "))
patios = int(input("Ingrese la cantidad de patios: "))

# Calcular el pago total mensual

pago_total = (habitaciones * 30) + (banos * 10) + (patios * 15)

# Mostrar el resultado
print(f"El pago total mensual por el alquiler de la casa es: {pago_total} soles")