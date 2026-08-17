class Ejercicio07
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ejercicio 7.\nEscribir un programa que genere una lista con los 20 primeros números impares y calcule su suma total.\n");

        List<int> impares = new List<int>();
        int suma = 0;

        for (int i = 1; impares.Count < 20; i += 2)
        {
            impares.Add(i);
            suma += i;
        }

        Console.WriteLine("Primeros 20 números impares:");
        foreach (int num in impares)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine($"Suma total: {suma}");
    }
}