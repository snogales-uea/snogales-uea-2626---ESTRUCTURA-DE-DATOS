class Ejercicio08
{
    public static void Ejecutar()
    {
        Console.Write("Ejercicio 8.\nEscribir un programa que almacene en una lista los caracteres de una palabra introducida por el usuario y elimine todos los caracteres repetidos (manteniendo el orden).\n");

        Console.Write("Introduce una palabra: ");
        string palabra = Console.ReadLine();
        List<char> caracteresUnicos = new List<char>();

        foreach (char c in palabra)
        {
            if (!caracteresUnicos.Contains(c))
            {
                caracteresUnicos.Add(c);
            }
        }

        Console.WriteLine("Caracteres sin repeticiones:");
        foreach (char c in caracteresUnicos)
        {
            Console.Write(c);
        }
        Console.WriteLine();
    }
}