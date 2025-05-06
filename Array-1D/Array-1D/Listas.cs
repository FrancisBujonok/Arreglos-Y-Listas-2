using System;
using System.Collections.Generic;

//1- Solicitar al usuario que ingrese 5 números enteros y guardarlos en una lista.
//Luego calcular y mostrar la suma total de los elementos.
/*

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            numeros.Add(num);
        }

        int suma = 0;

        foreach (int n in numeros)
        {
            suma += n;
        }

        Console.WriteLine($"La suma total de los números es: {suma}");
        Console.ReadLine();
    }
}
*/
//2- Pedir al usuario que ingrese 7 números y guardarlos en una lista.
//Luego pedir otro número y verificar si está en la lista. Mostrar un mensaje informando si se encontró o no.
/*
class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            numeros.Add(num);
        }
        Console.Write("Ingrese un número para verificar si está en la lista: ");
        int buscado = int.Parse(Console.ReadLine());
        if (numeros.Contains(buscado))
        {
            Console.WriteLine("El número se encuentra en la lista.");
        }
        else
        {
            Console.WriteLine("El número NO se encuentra en la lista.");
        }
        Console.ReadLine();
    }
}
*/

//3- Generar una lista con 10 números aleatorios entre 1 y 100.
//Luego pedir al usuario un valor límite y eliminar todos los elementos menores a ese valor.
//Mostrar la lista resultante.
class Program
{
    static void Main()
    {
        Random aleatorio = new Random();
        List<int> numeros = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            int numero = aleatorio.Next(1, 101);
            numeros.Add(numero);
        }
        Console.WriteLine("Lista generada:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine("\n\nIngrese un valor límite:");
        int limite = int.Parse(Console.ReadLine());
        numeros.RemoveAll(n => n < limite);
        Console.WriteLine("\nLista después de eliminar los menores al límite:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }

        Console.ReadLine();
    }
}
