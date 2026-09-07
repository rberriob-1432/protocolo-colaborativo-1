using System;

class SegundoEjercicio
{
    static void Main()
    {
        int[,] matriz =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Matriz forma de tabla:");

        for (byte i = 0; i < matriz.GetLength(0); i++)
        {
            for (byte j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Recorrido por columnas:");

        for (byte j = 0; j < matriz.GetLength(1); j++)
        {
            for (byte i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}