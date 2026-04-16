# Ejercicio 5: Aplicar diferentes tipos de redondeo a un precio en soles.
# Se debe mostrar el valor redondeado hacia arriba (Ceiling), hacia abajo (Floor)
# y el valor truncado eliminando los decimales.
# Se utilizan funciones matemáticas propias del lenguaje para cada caso.

import math

# Solicitar al usuario el precio en soles
precio = float(input("Ingrese el precio en soles: "))

# Redondear hacia arriba (Ceiling)
precio_ceil = math.ceil(precio)

# Redondear hacia abajo (Floor)
precio_floor = math.floor(precio)

# Truncar el valor eliminando los decimales
precio_trunc = math.trunc(precio)

# Mostrar los resultados
print(f"Precio original: {precio}")
print(f"Precio redondeado hacia arriba (Ceiling): {precio_ceil}")
print(f"Precio redondeado hacia abajo (Floor): {precio_floor}")
print(f"Precio truncado (eliminando decimales): {precio_trunc}")
