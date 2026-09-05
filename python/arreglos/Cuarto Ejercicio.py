import random
numeros = [0]*10
for i in range(10):
    numeros[i]= random.randint(1,100)
print("Arreglo")
print(numeros)
encontrado = False
num=int(input("Ingresar numeros a buscar"))
for i in range(len(numeros)):
    if numeros[i]==num:
        print("Numero encontrado en el indice ",i)
        encontrado = True
        break
if not encontrado:
    print("El valor no fue encontrado en el arreglo")
