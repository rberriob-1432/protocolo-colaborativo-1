import random

numeros = [0] * 10

for i in range(10):
    numeros[i] = random.randint(1, 100)

print(numeros)