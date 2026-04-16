# Ejercicio 4: Calcular el área y perímetro de un círculo a partir del radio.
# Se utiliza la constante π que el lenguaje proporciona (Math.PI o math.pi).
# El área se obtiene con π * r^2 y el perímetro con 2 * π * r.
# Estas fórmulas permiten calcular las propiedades básicas del círculo.

import math

# Solicitar al usuario el radio del círculo
radio = float(input("Ingrese el radio del círculo: "))

# Calcular el área del círculo
area = math.pi * math.pow(radio, 2)

# Calcular el perímetro del círculo
perimetro = 2 * math.pi * radio

# Mostrar los resultados
print(f"El área del círculo con radio {radio} es: {area}")
print(f"El perímetro del círculo con radio {radio} es: {perimetro}")