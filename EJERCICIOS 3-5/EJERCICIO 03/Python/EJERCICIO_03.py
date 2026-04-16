# Ejercicio 3: Calcular la distancia entre dos puntos en el plano.
# Se aplica el teorema de Pitágoras usando las coordenadas (x1, y1) y (x2, y2).
# Se calcula la raíz cuadrada de la suma de los cuadrados de las diferencias.
# En código: Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

import math

# Solicitar al usuario las coordenadas de los dos puntos
x1 = float(input("Ingrese la coordenada x del primer punto: "))
y1 = float(input("Ingrese la coordenada y del primer punto: "))
x2 = float(input("Ingrese la coordenada x del segundo punto: "))
y2 = float(input("Ingrese la coordenada y del segundo punto: "))


dx = x2 - x1
dy = y2 - y1

# Match.Sqrt calcula la raíz cuadrada de la suma de los cuadrados de las diferencias

distancia = math.sqrt(math.pow(dx, 2) + math.pow(dy, 2))

# Mostrar el resultado

print(f"La distancia entre los puntos ({x1}, {y1}) y ({x2}, {y2}) es: {distancia}")
