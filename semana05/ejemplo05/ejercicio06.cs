class Ejercicio06
{
    public static void Ejecutar()
    {
        Console.Write("Ejercicio 6.\nEscribir un programa que almacene una lista de contraseñas (por ejemplo: '1234', 'qwerty', 'admin') y verifique si una contraseña ingresada por el usuario es válida (es decir, está en la lista).\n");

        List<string> contraseñas = new List<string> { "1234", "qwerty", "admin" };
        Console.Write("Introduce tu contraseña: ");
        string contraseña = Console.ReadLine();

        if (contraseñas.Contains(contraseña))
            Console.WriteLine("Contraseña válida.");
        else
            Console.WriteLine("Contraseña incorrecta.");
    }
}