class Ejercicio09
{
    public static void Ejecutar()
    {
        Console.Write("Ejercicio 9.\nEscribir un programa que lea una lista de números separados por comas y cree otra lista con los mismos números sin duplicados.\n");

        Console.Write("Introduce una lista de números separados por comas: ");
        string entrada = Console.ReadLine();
        List<int> numeros = entrada.Split(',').Select(int.Parse).ToList();
        List<int> sinDuplicados = numeros.Distinct().ToList();

        Console.WriteLine("Lista sin duplicados:");
        foreach (int n in sinDuplicados)
        {
            Console.WriteLine(n);
        }
    }
}