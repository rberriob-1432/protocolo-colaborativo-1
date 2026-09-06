using System;

class CuartoEjercicio
{
    static void Main()
    {
        int[] numeros = new int[10];

        Random r = new Random();

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = r.Next(1, 101);
        }

        Console.WriteLine("Arreglo:");

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        Console.Write("Ingrese el valor que desea buscar: ");
        int valorBuscado = int.Parse(Console.ReadLine());

        int posicion = -1;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == valorBuscado)
            {
                posicion = i;
                break;
            }
        }

        if (posicion != -1)
        {
            Console.WriteLine($"El valor {valorBuscado} se encuentra en la posición {posicion}");
        }
        else
        {
            Console.WriteLine($"El valor {valorBuscado} no se encuentra en el arreglo");
        }
    }
}