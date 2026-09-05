import random

numeros = [0] * 10

# Llenar el arreglo
for i in range(10):
    numeros[i] = random.randint(1, 100)

# for clásico
print("Recorrido usando for clásico:")

for i in range(len(numeros)):
    print(numeros[i])

# for-each
print("\nRecorrido usando for-each:")

for numero in numeros:
    print(numero)