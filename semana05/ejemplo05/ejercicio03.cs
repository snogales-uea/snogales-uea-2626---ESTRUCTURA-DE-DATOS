class Ejercicio03
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ejercicio 3.\nEscribir un programa que genere una lista con los 10 primeros cuadrados (1², 2², ..., 10²) y los muestre por pantalla.");

        List<int> cuadrados = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            cuadrados.Add(i * i);
        }

        Console.WriteLine("Cuadrados del 1 al 10:");
        foreach (int c in cuadrados)
        {
            Console.WriteLine(c);
        }
    }
}