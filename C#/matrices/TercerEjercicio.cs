using System;

class TercerEjercicio
{
    static void Main()
    {
        int[,] matriz =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Matriz original:");

        for (byte i = 0; i < matriz.GetLength(0); i++)
        {
            for (byte j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }

            Console.WriteLine();
        }
        int suma = 0;

        for (byte i = 0; i < matriz.GetLength(0); i++)
        {
            for (byte j = 0; j < matriz.GetLength(1); j++)
            {
                suma += matriz[i, j];
            }
        }

        Console.WriteLine("La suma de los números de la matriz es: " + suma);
        int temporal;

        for (byte j = 0; j < matriz.GetLength(1); j++)
        {
            temporal = matriz[0, j];
            matriz[0, j] = matriz[matriz.GetLength(0) - 1, j];
            matriz[matriz.GetLength(0) - 1, j] = temporal;
        }

        Console.WriteLine("\nMatriz después de intercambiar primera y última fila:");

        for (byte i = 0; i < matriz.GetLength(0); i++)
        {
            for (byte j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }
}