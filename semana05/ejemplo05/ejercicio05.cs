class Ejercicio05
{
    public static void Ejecutar()
    {
        Console.Write("Ejercicio 5.\nEscribir un programa que pregunte al usuario cuántos nombres quiere introducir, losalmacene en una lista y luego los muestre en orden alfabético.\n");

        Console.Write("¿Cuántos nombres quieres introducir? ");
        int cantidad = int.Parse(Console.ReadLine());
        List<string> nombres = new List<string>();

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Nombre {i + 1}: ");
            nombres.Add(Console.ReadLine());
        }

        nombres.Sort();
        Console.WriteLine("Nombres en orden alfabético:");
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}