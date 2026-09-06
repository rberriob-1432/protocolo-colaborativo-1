using System;
class PrimerEjercicio{
    static void Main(){
        int [] numeros = new int [10];
        Random r = new Random();
        for (byte i=0;i<numeros.Length;i++){
            numeros[i]=r.Next(1,101);
        }
        Console.WriteLine("Arreglo");
        for (byte i=0;i<numeros.Length;i++){
            Console.WriteLine(numeros[i]);
        }
    }
}