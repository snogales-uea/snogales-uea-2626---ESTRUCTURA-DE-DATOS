class Ejercicio10
{
    public static void Ejecutar()
    {
        Console.Write("Ejercicio 10.\nEscribir un programa que almacene dos listas de igual longitud con números enteros introducidos por el usuario y calcule la suma de los elementos correspondientes (suma elemento a elemento).\n");

        List<int> lista1 = new List<int>();
        List<int> lista2 = new List<int>();
        Console.Write("¿Cuántos números quieres introducir en cada lista? ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce los números de la primera lista:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Número {i + 1}: ");
            lista1.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Introduce los números de la segunda lista:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Número {i + 1}: ");
            lista2.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Suma de elementos correspondientes:");
        for (int i = 0; i < cantidad; i++)
        {
            int suma = lista1[i] + lista2[i];
            Console.WriteLine($"{lista1[i]} + {lista2[i]} = {suma}");
        }
    }
}