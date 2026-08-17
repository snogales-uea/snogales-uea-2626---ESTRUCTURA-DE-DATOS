public class Ejercicio01
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ejercicio 1.\nEscribir un programa que almacene una lista de ciudades (por ejemplo: Madrid, París, Londres, Berlín, Roma), y pida al usuario que introduzca una ciudad. El programa debe decir si la ciudad está en la lista.\n");

        List<string> ciudades = new List<string> { "Madrid", "París", "Londres", "Berlín", "Roma" };
        Console.Write("Introduce una ciudad: ");
        string ciudad = Console.ReadLine();

        if (ciudades.Contains(ciudad))
            Console.WriteLine("La ciudad está en la lista.");
        else
            Console.WriteLine("La ciudad NO está en la lista.");
    }
}