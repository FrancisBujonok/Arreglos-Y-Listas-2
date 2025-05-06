using System;
/*
//1- Cargar un array con 10 números aleatorios entre 1 y 100. Mostrar el mayor y el menor.
class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        Random aleatorio = new Random();

        for (int i = 0; i < 10; i++)
        {
            numeros[i] = aleatorio.Next(1, 101);
        }

        Console.WriteLine("Números generados:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();

        int mayor = numeros[0];
        int menor = numeros[0];

        for (int i = 1; i < 10; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        Console.WriteLine($"El número mayor es: {mayor}");
        Console.WriteLine($"El número menor es: {menor}");

        Console.ReadLine();
    }
}
*/
//2- Solicitar al usuario 8 nombres y almacenarlos en un array. Mostrar cuántos empiezan con la letra 'A'.
/*
class Program
{
    static void Main()
    {
        string[] nombres = new string[8];

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Ingrese el nombre #{i + 1}: ");
            nombres[i] = Console.ReadLine();
        }

        int cantidadConA = 0;

        for (int i = 0; i < 8; i++)
        {
            if (!string.IsNullOrEmpty(nombres[i]) && nombres[i][0] == 'A')
            {
                cantidadConA++;
            }
        }

        Console.WriteLine($"Cantidad de nombres que empiezan con 'A': {cantidadConA}");

        Console.ReadLine();
    }
}
*/
//Ingresar 10 números y mostrar cuántos son positivos, negativos y ceros.
/*

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int positivos = 0;
        int negativos = 0;
        int ceros = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el número #{i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] > 0)
            {
                positivos++;
            }
            else if (numeros[i] < 0)
            {
                negativos++;
            }
            else
            {
                ceros++;
            }
        }

        Console.WriteLine($"Positivos: {positivos}");
        Console.WriteLine($"Negativos: {negativos}");
        Console.WriteLine($"Ceros: {ceros}");

        Console.ReadLine();
    }
}
*/
//4- Crear un array con los días de la semana y mostrar solo los días laborales.
/*
class Program
{
    static void Main()
    {
        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        Console.WriteLine("Días laborales:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(dias[i]);
        }

        Console.ReadLine();
    }
}
*/