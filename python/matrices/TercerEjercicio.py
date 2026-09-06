matriz = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]

print("matriz original:")

for i in range(len(matriz)):
    for j in range(len(matriz[i])):
        print(matriz[i][j], end=" ")
    print()

suma = 0

for i in range(len(matriz)):
    for j in range(len(matriz[i])):
        suma = suma + matriz[i][j]

print("suma de todos los elementos:", suma)

matriz[0], matriz[len(matriz) - 1] = matriz[len(matriz) - 1], matriz[0]

# Imprimir matriz después del intercambio
print("matriz después de intercambiar la primera fila con la última:")

for i in range(len(matriz)):
    for j in range(len(matriz[i])):
        print(matriz[i][j], end=" ")
    print()