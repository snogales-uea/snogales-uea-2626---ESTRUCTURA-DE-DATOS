class Ejercicio02
{
    public static void Ejecutar()
    {
        Console.Write("Ejercicio 2. Escribir un programa que pida al usuario una lista de números separados por comas, los convierta en una lista de enteros y muestre por pantalla solo los números pares.\n");

        Console.Write("Introduce una lista de números separados por comas: ");
        string entrada = Console.ReadLine();
        List<int> numeros = entrada.Split(',').Select(int.Parse).ToList();

        Console.WriteLine("Números pares:");
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
                Console.WriteLine(numero);
        }
    }
}