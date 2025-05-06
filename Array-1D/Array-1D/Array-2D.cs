using System;
//1- Crear una matriz de 3x3. Solicitar al usuario que ingrese todos los elementos y luego mostrar la suma de cada fila.
/*
class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"Ingrese el número para la posición [{fila}, {col}]: ");
                matriz[fila, col] = int.Parse(Console.ReadLine());
            }
        }

        for (int fila = 0; fila < 3; fila++)
        {
            int suma = 0;
            for (int col = 0; col < 3; col++)
            {
                suma += matriz[fila, col];
            }
            Console.WriteLine($"La suma de la fila {fila + 1} es: {suma}");
        }

        Console.ReadLine();
    }
}
*/

//2- Cargar una matriz de 3x3. Mostrar la fila con mayor suma.
/*
class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"Ingrese el número para la posición [{fila}, {col}]: ");
                matriz[fila, col] = int.Parse(Console.ReadLine());
            }
        }

        int mayorSuma = 0;
        int filaMayor = 0;

        for (int fila = 0; fila < 3; fila++)
        {
            int suma = 0;
            for (int col = 0; col < 3; col++)
            {
                suma += matriz[fila, col];
            }

            if (fila == 0 || suma > mayorSuma)
            {
                mayorSuma = suma;
                filaMayor = fila;
            }
        }

        Console.WriteLine($"La fila con mayor suma es la fila {filaMayor + 1}, con un total de {mayorSuma}.");
        Console.ReadLine();
    }
}
*/
//3- Crear una matriz de 3x3. Reemplazar todos los elementos negativos por cero.
/*

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"Ingrese el valor para la posición [{fila}, {col}]: ");
                matriz[fila, col] = int.Parse(Console.ReadLine());
            }
        }

        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (matriz[fila, col] < 0)
                {
                    matriz[fila, col] = 0;
                }
            }
        }

        Console.WriteLine("\nMatriz resultante:");
        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matriz[fila, col] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
*/