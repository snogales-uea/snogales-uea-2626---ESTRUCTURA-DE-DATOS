class Ejercicio04
{
    public static void Ejecutar()
    {
        Console.Write("Ejercicio 4.\n Escribir un programa que pida al usuario una frase y cree una lista con todas las palabras. Luego debe mostrar la cantidad total de palabras.\n");

        Console.Write("Introduce una frase: ");
        string frase = Console.ReadLine();
        string[] palabras = frase.Split(' ');

        Console.WriteLine($"La frase contiene {palabras.Length} palabras.");
    }
}