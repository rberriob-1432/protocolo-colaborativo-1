import random
numeros = [0]*10
for i in range (10):
    numeros[i]= random.randint(1,100)
print("Arreglo original:")
print(numeros)
for i in range (len(numeros)):
    if numeros [i] % 2 !=0:
        numeros[i]=0
print("Impares vueltos ceros")
print(numeros)
for i in range(len(numeros)):
    numeros[i]=numeros[i]*i
print("Numeros multiplicados por su indice")
print(numeros)