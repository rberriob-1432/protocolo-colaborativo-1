using System;
class TercerEjercicio
{
    static void Main()
    {
        int [] numeros = new int [10];
        Random r = new Random();
        for(byte i = 0; i < numeros.Length; i++)
        {
            numeros[i]=r.Next(1,101);

        }
        Console.WriteLine("Arreglo original");
        foreach(int numero in numeros)
        {
            Console.WriteLine(numero);
        }
        for (byte i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 != 0)
            {
                numeros[i]=0;
            }
        }
        Console.WriteLine("Arreglo modificado para impares vueltos ceros");
        foreach(int numero in numeros)
        {
            Console.WriteLine(numero);
        }
        for (byte i=0; i < numeros.Length; i++)
        {
            numeros[i]=numeros[i]*i;
        }
        Console.WriteLine("Arreglo modificado para multiplicar el numero por indice");
             foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    
    }
}