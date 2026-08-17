using System;
using System.Collections.Generic;

class Ejercicio2
{
    // Representación de las tres torres como pilas
    public static Stack<int> origen = new Stack<int>();
    public static Stack<int> auxiliar = new Stack<int>();
    public static Stack<int> destino = new Stack<int>();

    // Método recursivo que resuelve el problema
    public static void Resolver(int n, Stack<int> desde, Stack<int> hacia, Stack<int> por, string nombreDesde, string nombreHacia, string nombrePor)
    {
        if (n == 1)
        {
            int disco = desde.Pop();
            hacia.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreDesde} a {nombreHacia}");
            MostrarTorres();
        }
        else
        {
            Resolver(n - 1, desde, por, hacia, nombreDesde, nombrePor, nombreHacia);
            Resolver(1, desde, hacia, por, nombreDesde, nombreHacia, nombrePor);
            Resolver(n - 1, por, hacia, desde, nombrePor, nombreHacia, nombreDesde);
        }
    }

    // Método para mostrar el estado de las torres
    public static void MostrarTorres()
    {
        Console.WriteLine("\nEstado de las torres:");
        ImprimirTorre("Origen", origen);
        ImprimirTorre("Auxiliar", auxiliar);
        ImprimirTorre("Destino", destino);
        Console.WriteLine("------------------------------\n");
    }

    private static void ImprimirTorre(string nombre, Stack<int> torre)
    {
        Console.Write(nombre + ": ");
        foreach (int disco in torre.ToArray())
        {
            Console.Write(disco + " ");
        }
        Console.WriteLine();
    }
}
