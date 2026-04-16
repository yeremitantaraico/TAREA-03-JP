# Ejercicio 2: Calcular la factura de consumo eléctrico con IGV.
# Se suma un cargo fijo de S/.5.00 más S/.0.55 por cada kWh consumido.
# Al subtotal se le aplica el 18% de IGV para obtener el impuesto.
# El total es la suma del subtotal más el IGV calculado.

import math

# Solicitar al usuario el consumo eléctrico en kWh
consumo_kwh = float(input("Ingrese el consumo eléctrico en kWh: "))

# Calcular el subtotal de la factura
subtotal = 5 + (0.55 * consumo_kwh)

# Calcular el IGV (18% del subtotal)
igv = subtotal * 0.18

# Calcular el total de la factura
total_factura = subtotal + igv

# Mostrar los resultados
print(f"Consumo eléctrico: {consumo_kwh} kWh")
print(f"Subtotal de la factura: S/.{subtotal:.2f}")
print(f"IGV (18%): S/.{igv:.2f}")
print(f"Total de la factura: S/.{total_factura:.2f}")
